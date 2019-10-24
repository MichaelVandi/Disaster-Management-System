Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Runtime.InteropServices
Public Class manager_victim
    Dim CAMEERA As VideoCaptureDevice
    Dim initial_Picture As Bitmap
    Dim connection As New SqlConnection("Data Source=MICHAEL;Initial Catalog=FLOOD_RECOVERY_SYSTEM;Integrated Security=True")

    Private Sub vic_btn_Click(sender As Object, e As EventArgs) Handles vic_btn.Click
        victim_strip.Show(vic_btn, 0, vic_btn.Height)

    End Sub

    Private Shared Function Hint(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Sub load1()

        Dim query1 As String = "select * from VICTIM"
        Dim adapter As New SqlDataAdapter(query1, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        Employee_Details_Grid.DataSource = table
        connection.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles add_vic.Click
        GroupBox1.Show()
        check_update.Text = "new"
        Delete_btn.Hide()
        Tb_Emp_Id.Hide()

        Tb_EmpFname.Clear()
        Tb_EmpLName.Clear()
        Tb_emp_cell.Clear()
        Tb_Vic_Sex.Clear()
        tb_vic_address.Clear()
        Tb_vic_status.Clear()
        Tb_Area_code.Clear()

        Tb_Emp_Dob.Clear()
        lbl_vic_age.Text = ""
        lbl_usname.Text = ""


        Hint(Me.Tb_Emp_Dob.Handle, &H1501, 0, "YYYY-MM-DD")
        load1()



    End Sub
    Sub Check_If_Data_Exists()
        connection.Open()

        Dim theQuery As String = "SELECT * FROM VICTIM WHERE Victim_FName=@Victim_FName AND Victim_LName=@Victim_LName"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@Victim_FName", Tb_EmpFname.Text)
        cmd1.Parameters.AddWithValue("@Victim_LName", Tb_EmpLName.Text)

        Using reader As SqlDataReader = cmd1.ExecuteReader()
            If reader.HasRows Then
                ' User already exists
                MsgBox("Changes Made Successfully!")
            Else
                MsgBox("Changes not made!", MsgBoxStyle.Exclamation, "Flood Recovery System")
            End If
            connection.Close()

        End Using
    End Sub

    Sub check_If_Data_Is_Not_In_Table()
        connection.Open()

        Dim theQuery As String = "SELECT * FROM VICTIM WHERE Victim_Id=@Victim_Id AND Victim_FName=@Victim_FName"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@Victim_Id", Tb_Emp_Id.Text)
        cmd1.Parameters.AddWithValue("@Victim_FName", Tb_EmpFname.Text)

        Using reader As SqlDataReader = cmd1.ExecuteReader()
            If reader.HasRows Then
                ' User already exists
                MsgBox("Changes not made!", MsgBoxStyle.Exclamation, "Flood Recovery System")
            Else
                MsgBox("Changes Made Successfully!")
            End If
            connection.Close()

        End Using

    End Sub

    Private Sub start_vic_cam_Click(sender As Object, e As EventArgs) Handles start_vic_cam.Click
        Dim camera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If camera.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMEERA = camera.VideoDevice
            AddHandler CAMEERA.NewFrame, New NewFrameEventHandler(AddressOf capturedView)
            CAMEERA.Start()
        End If
    End Sub
    Private Sub capturedView(sender As Object, eventArgs As NewFrameEventArgs)
        initial_Picture = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        vic_camera_view.BackgroundImage = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub capture_vic_pic_Click(sender As Object, e As EventArgs) Handles capture_vic_pic.Click
        image_preview_vic.BackgroundImage = vic_camera_view.BackgroundImage
    End Sub

    Private Sub save_vic_pic_Click(sender As Object, e As EventArgs) Handles save_vic_pic.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.DefaultExt = ".jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_preview_vic.BackgroundImage.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub image_preview_vic_Click(sender As Object, e As EventArgs) Handles image_preview_vic.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_preview_vic.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Tb_EmpFname.Text = String.Empty OrElse Tb_EmpLName.Text = String.Empty OrElse
                Tb_Emp_Dob.Text = String.Empty OrElse lbl_vic_age.Text = String.Empty OrElse
                Tb_vic_status.Text = String.Empty OrElse lbl_usname.Text = "auto generated" Then
            MessageBox.Show("At least one field is empty")
        Else
            If check_update.Text = "update" Then
                Dim update_command As New SqlCommand
                connection.Open()

                update_command = connection.CreateCommand
                update_command.CommandText = "update VICTIM set Victim_FName=@Victim_FName, Victim_LName=@Victim_LName,
                               Victim_DateOfBirth=@Victim_DateOfBirth , victim_Age=@victim_Age, Victim_Sex=@Victim_Sex, 
                                Victim_Address=@Victim_Address, Victim_Cell=@Victim_Cell,Victim_status=@Victim_status , 
                                Victim_Image=@Victim_Image, Area_Code=@Area_Code where Victim_Id =@Victim_Id "
                Dim ms As MemoryStream
                ms = New MemoryStream()
                image_preview_vic.BackgroundImage.Save(ms, image_preview_vic.BackgroundImage.RawFormat)
                update_command.Parameters.AddWithValue("@Victim_Id", Tb_Emp_Id.Text)

                update_command.Parameters.AddWithValue("@Victim_FName", Tb_EmpFname.Text)
                update_command.Parameters.AddWithValue("@Victim_LName", Tb_EmpLName.Text)
                update_command.Parameters.AddWithValue("@Victim_DateOfBirth", Tb_Emp_Dob.Text)
                update_command.Parameters.AddWithValue("@victim_Age", lbl_vic_age.Text)
                update_command.Parameters.AddWithValue("@Victim_Sex", Tb_Vic_Sex.Text)
                update_command.Parameters.AddWithValue("@Victim_Address", tb_vic_address.Text)
                update_command.Parameters.AddWithValue("@Victim_Cell", Tb_emp_cell.Text)
                update_command.Parameters.AddWithValue("@Victim_Pin", lbl_usname.Text)
                update_command.Parameters.AddWithValue("@Victim_status", Tb_vic_status.Text)
                update_command.Parameters.AddWithValue("@Area_Code", Tb_Area_code.Text)

                update_command.Parameters.Add("@Victim_Image", SqlDbType.Image).Value = ms.ToArray()

                update_command.ExecuteNonQuery()
                load1()
                connection.Close()

                Check_If_Data_Exists()

            ElseIf check_update.Text = "new" Then

                Dim insertCommand As New SqlCommand
                insertCommand = connection.CreateCommand
                insertCommand.CommandText = "insert into VICTIM (Victim_FName, Victim_LName, 
                Victim_DateOfBirth, victim_Age, Victim_Sex,Victim_Address, Victim_Cell,Victim_Pin,Victim_status,Victim_Image,Area_Code)  
                    values (@Victim_FName, @Victim_LName, @Victim_DateOfBirth, @victim_Age, @Victim_Sex,@Victim_Address,
               @Victim_Cell, @Victim_Pin, @Victim_status, @Victim_Image, @Area_Code)"


                Dim ms As MemoryStream
                ms = New MemoryStream()
                image_preview_vic.BackgroundImage.Save(ms, image_preview_vic.BackgroundImage.RawFormat)

                connection.Open()

                insertCommand.Parameters.AddWithValue("@Victim_FName", Tb_EmpFname.Text)
                insertCommand.Parameters.AddWithValue("@Victim_LName", Tb_EmpLName.Text)
                insertCommand.Parameters.AddWithValue("@Victim_DateOfBirth", Tb_Emp_Dob.Text)
                insertCommand.Parameters.AddWithValue("@victim_Age", lbl_vic_age.Text)
                insertCommand.Parameters.AddWithValue("@Victim_Sex", Tb_Vic_Sex.Text)
                insertCommand.Parameters.AddWithValue("@Victim_Address", tb_vic_address.Text)
                insertCommand.Parameters.AddWithValue("@Victim_Cell", Tb_emp_cell.Text)
                insertCommand.Parameters.AddWithValue("@Victim_Pin", lbl_usname.Text)
                insertCommand.Parameters.AddWithValue("@Victim_status", Tb_vic_status.Text)
                insertCommand.Parameters.AddWithValue("@Area_Code", Tb_Area_code.Text)

                insertCommand.Parameters.Add("@Victim_Image", SqlDbType.Image).Value = ms.ToArray()

                insertCommand.ExecuteNonQuery()

                load1()
                connection.Close()
                Check_If_Data_Exists()

            End If

        End If
    End Sub

    Private Sub Tb_EmpFname_TextChanged(sender As Object, e As EventArgs) Handles Tb_EmpFname.TextChanged
        Dim RandomClass As New Random()
        Dim randomString As String

        For i = 1 To 1000 Step 1
            randomString = RandomClass.Next(1, 9999).ToString
            If randomString.Length < 4 Then
                randomString = randomString.PadLeft(4, "0")
            End If
            lbl_usname.Text = randomString
        Next
    End Sub

    Private Sub update_vic_Click(sender As Object, e As EventArgs) Handles update_vic.Click
        Hint(Me.Tb_Emp_Dob.Handle, &H1501, 0, "YYYY-MM-DD")
        GroupBox1.Show()
        Delete_btn.Hide()
        Button4.Show()
        Tb_Emp_Id.Show()

        lbl_emp_id.Show()
        check_update.Text = "update"
        load1()

    End Sub

    Private Sub manager_victim_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim present_date As String = Date.Now.ToString("yyyy-MM-dd")
        GroupBox1.Hide()


    End Sub

    Private Sub Tb_Emp_Dob_TextChanged(sender As Object, e As EventArgs) Handles Tb_Emp_Dob.TextChanged
        If check_update.Text = "new" Then
            If Tb_Emp_Dob.Text.ToString.Length > 3 Then

                Dim present_date As String = Date.Now.ToString("yyyy-MM-dd")
                Dim yearNow As String

                yearNow = Convert.ToInt32(present_date.Substring(0, 4))

                Dim birth_year As String

                birth_year = Convert.ToInt32(Tb_Emp_Dob.Text.ToString.Substring(0, 4))

                Dim Age As Integer
                Age = yearNow - birth_year

                lbl_vic_age.Text = Age
                Dim checkAge As Integer = Integer.Parse(lbl_vic_age.Text.ToString)
                If checkAge < 0 Then
                    MessageBox.Show("Wrong age, Victim's age cannot be less than zero")
                End If
            End If

        End If



    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        connection.Open()

        Dim foreignDelete As New SqlCommand
        foreignDelete = connection.CreateCommand
        foreignDelete.CommandText = "delete from ASSET where Owner_Id=@Owner_Id"
        foreignDelete.Parameters.AddWithValue("@Owner_Id", Tb_Emp_Id.Text)
        foreignDelete.ExecuteNonQuery()


        Dim cmd As New SqlCommand
        cmd = connection.CreateCommand
        cmd.CommandText = "delete from VICTIM where Victim_Id=@Victim_Id"
        cmd.Parameters.AddWithValue("@Victim_Id", Tb_Emp_Id.Text)
        cmd.ExecuteNonQuery()
        load1()

        'Check if deleted and tell user
        check_If_Data_Is_Not_In_Table()

    End Sub

    Private Sub view_vic_Click(sender As Object, e As EventArgs) Handles view_vic.Click
        GroupBox1.Show()
        load1()
        Tb_Emp_Id.Show()
        Delete_btn.Hide()
        Button4.Hide()


    End Sub

    Private Sub search_vic_Click(sender As Object, e As EventArgs) Handles search_vic.Click
        GroupBox1.Show()
        load1()

        Tb_Emp_Id.Show()
        Tb_Emp_Id.Show()
        Delete_btn.Hide()
        Button4.Hide()
    End Sub

    Private Sub Tb_Emp_Id_TextChanged(sender As Object, e As EventArgs) Handles Tb_Emp_Id.TextChanged
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet
        connection.Open()
        adapter = New SqlDataAdapter("select * from VICTIM where Victim_Id like'%" & Tb_Emp_Id.Text & "%'", connection)
        adapter.Fill(ds)
        Employee_Details_Grid.DataSource = ds.Tables(0)
        connection.Close()


        connection.Open()
        Dim sqlcmd As New SqlCommand("select * from VICTIM where Victim_Id like'%" & Tb_Emp_Id.Text & "%'", connection)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        myreader.Read()
        If myreader.HasRows Then
            Tb_EmpFname.Text = myreader.Item("Victim_FName").ToString
            Tb_EmpLName.Text = myreader.Item("Victim_LName").ToString
            Tb_Emp_Dob.Text = myreader.Item("Victim_DateOfBirth").ToString
            lbl_vic_age.Text = myreader.Item("victim_Age").ToString
            Tb_Vic_Sex.Text = myreader.Item("Victim_Sex").ToString
            tb_vic_address.Text = myreader.Item("Victim_Address").ToString
            Tb_emp_cell.Text = myreader.Item("Victim_Cell").ToString
            lbl_usname.Text = myreader.Item("Victim_Pin").ToString
            Tb_vic_status.Text = myreader.Item("Victim_status").ToString
            Tb_Area_code.Text = myreader.Item("Area_Code").ToString

            myreader.Close()

            'Our buffer cannot be null so the textbox should not be empty
            If Tb_Emp_Id.Text = String.Empty Then
            Else
                Dim show_photo As New SqlCommand("select  Victim_Image from VICTIM where Victim_Id=@Victim_Id", connection)
                show_photo.Parameters.AddWithValue("@Victim_Id", Tb_Emp_Id.Text)
                Dim ms As New MemoryStream(CType(show_photo.ExecuteScalar, Byte()))
                image_preview_vic.BackgroundImage = Image.FromStream(ms)
                show_photo.Dispose()
            End If
        End If

        connection.Close()

    End Sub

    Private Sub delete_vic_Click(sender As Object, e As EventArgs) Handles delete_vic.Click
        GroupBox1.Show()
        Button4.Hide()
        Tb_Emp_Id.Show()

        Delete_btn.Show()
        check_update.Text = "delete"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        asset_manager.Show()

    End Sub

    Private Sub donor_btn_Click(sender As Object, e As EventArgs) Handles donor_btn.Click
        Me.Close()
        manager_Donor.Show()


    End Sub

    Private Sub employee_btn_Click(sender As Object, e As EventArgs) Handles employee_btn.Click
        Me.Close()
        manager_panel.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        manager_area.Show()

    End Sub

    Private Sub Stop_Btn_Click(sender As Object, e As EventArgs) Handles Stop_Btn.Click
        If CAMEERA.IsRunning Then
            CAMEERA.Stop()

        End If
    End Sub
End Class