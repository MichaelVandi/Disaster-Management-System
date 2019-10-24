Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Drawing.Printing

Public Class manager_panel
    Dim CAMEERA As VideoCaptureDevice
    Dim initial_Picture As Bitmap

    Dim array_values_check() As String = {"new", "update", "delete"}

    Dim connection As New SqlConnection("Data Source=MICHAEL;Initial Catalog=FLOOD_RECOVERY_SYSTEM;Integrated Security=True")
    Private Sub employee_btn_Click(sender As Object, e As EventArgs) Handles employee_btn.Click
        Strip_Employee.Show(employee_btn, 0, employee_btn.Height)

    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        lbl_emp_id.Show()
        GroupBox1.Show()
        Tb_Emp_Id.Hide()
        Button4.Show()
        check_update.Text = "new"
        Delete_btn.Hide()
        load1()
    End Sub

    Private Sub manager_panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        close_slide.Hide()
        open_slide.Show()
        slide.Hide()

        Dim present_date As String = Date.Now.ToString("yyyy-MM-dd")
        Label7.Text = present_date



    End Sub
    Sub load1()

        Dim query1 As String = "select * from Employee_Details"
        Dim adapter As New SqlDataAdapter(query1, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        Employee_Details_Grid.DataSource = table
        connection.Close()
    End Sub

    Sub Check_If_Data_Exists()
        connection.Open()

        Dim theQuery As String = "SELECT * FROM Employee_Details WHERE Emp_FirstName=@Emp_FirstName AND Emp_LastName=@Emp_LastName"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@Emp_FirstName", Tb_EmpFname.Text)
        cmd1.Parameters.AddWithValue("@Emp_LastName", Tb_EmpLName.Text)

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
    'Sub to check id data does not exist
    Sub check_If_Data_Is_Not_In_Table()
        connection.Open()

        Dim theQuery As String = "SELECT * FROM Employee_Details WHERE Emp_FirstName=@Emp_FirstName AND Emp_LastName=@Emp_LastName"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@Emp_FirstName", Tb_EmpFname.Text)
        cmd1.Parameters.AddWithValue("@Emp_LastName", Tb_EmpLName.Text)

        Using reader As SqlDataReader = cmd1.ExecuteReader()
            If reader.HasRows Then
                ' User already exists
                MsgBox("Changes Made Successfully!")
                ' MsgBox("Changes not made!", MsgBoxStyle.Exclamation, "Flood Recovery System")
            Else
                'MsgBox("Changes Made Successfully!")
            End If
            connection.Close()

        End Using

    End Sub


    Private Sub start_emp_cam_Click(sender As Object, e As EventArgs) Handles start_emp_cam.Click
        Dim camera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If camera.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMEERA = camera.VideoDevice
            AddHandler CAMEERA.NewFrame, New NewFrameEventHandler(AddressOf capturedView)
            CAMEERA.Start()

        End If
    End Sub
    Private Sub capturedView(sender As Object, eventArgs As NewFrameEventArgs)
        initial_Picture = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        emp_camera_view.BackgroundImage = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub capture_emp_pic_Click(sender As Object, e As EventArgs) Handles capture_emp_pic.Click
        image_preview.BackgroundImage = emp_camera_view.BackgroundImage
    End Sub
    Private Sub image_preview_Click(sender As Object, e As EventArgs) Handles image_preview.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_preview.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        If Tb_EmpFname.Text = String.Empty OrElse Tb_EmpLName.Text = String.Empty OrElse
                Tb_Emp_Add.Text = String.Empty OrElse Tb_Emp_Cell.Text = String.Empty OrElse
                Tb_Emp_psword.Text = String.Empty OrElse lbl_usname.Text = "auto generated" Then
            MessageBox.Show("At least one field is empty")
        Else

            If check_update.Text = "update" Then
                Dim ms As MemoryStream
                lbl_emp_id.Hide()
                Tb_Emp_Id.Show()

                connection.Open()


                ms = New MemoryStream()
                image_preview.BackgroundImage.Save(ms, image_preview.BackgroundImage.RawFormat)
                Dim cmd As New SqlCommand
                cmd = connection.CreateCommand
                cmd.CommandText = "update Employee_Details set Emp_FirstName=@Emp_FirstName,
                    Emp_LastName=@Emp_LastName,
                    emp_address=@emp_address,
                    emp_number=@emp_number,
                    emp_usname= @emp_usname,
                    emp_password=@emp_password,
                    emp_Image=@emp_Image
                                                                    where emp_Id=@emp_Id"
                cmd.Parameters.AddWithValue("@emp_Id", Tb_Emp_Id.Text)
                cmd.Parameters.AddWithValue("@Emp_FirstName", Tb_EmpFname.Text)
                cmd.Parameters.AddWithValue("@Emp_LastName", Tb_EmpLName.Text)
                cmd.Parameters.AddWithValue("@emp_address", Tb_Emp_Add.Text)
                cmd.Parameters.AddWithValue("@emp_number", Tb_Emp_Cell.Text)
                cmd.Parameters.AddWithValue("@emp_usname", lbl_usname.Text)
                cmd.Parameters.AddWithValue("@emp_password", Tb_Emp_psword.Text)

                cmd.Parameters.Add("@emp_Image", SqlDbType.Image).Value = ms.ToArray()
                cmd.ExecuteNonQuery()
                load1()
                connection.Close()

                Check_If_Data_Exists()

            ElseIf check_update.Text = "new" Then

                Dim insertCommand As New SqlCommand
                insertCommand = connection.CreateCommand
                insertCommand.CommandText = "insert into Employee_Details (Emp_FirstName, Emp_LastName, 
                emp_address, emp_number, emp_usname,emp_password, emp_Image)  
                    values (@Emp_FirstName, @Emp_LastName, 
               @emp_address, @emp_number, @emp_usname, @emp_password, @emp_Image)"

                Dim ms As MemoryStream

                ms = New MemoryStream()

                If image_preview.BackgroundImage Is Nothing Then
                    MessageBox.Show("IMAGE NULL")
                Else
                    image_preview.BackgroundImage.Save(ms, image_preview.BackgroundImage.RawFormat)
                End If


                insertCommand.Parameters.AddWithValue("@Emp_FirstName", Tb_EmpFname.Text)
                    insertCommand.Parameters.AddWithValue("@Emp_LastName", Tb_EmpLName.Text)
                    insertCommand.Parameters.AddWithValue("@emp_address", Tb_Emp_Add.Text)
                    insertCommand.Parameters.AddWithValue("@emp_number", Tb_Emp_Cell.Text)
                    insertCommand.Parameters.AddWithValue("@emp_usname", lbl_usname.Text)
                    insertCommand.Parameters.AddWithValue("@emp_password", Tb_Emp_psword.Text)

                    insertCommand.Parameters.Add("@emp_Image", SqlDbType.Image).Value = ms.ToArray()
                    connection.Open()
                    insertCommand.ExecuteNonQuery()
                    connection.Close()
                    Dim checkcommand As New SqlCommand
                    connection.Open()

                    checkcommand = connection.CreateCommand
                    checkcommand.CommandText = "select * from Employee_Details where Emp_FirstName= @nameInserted "
                    checkcommand.Parameters.AddWithValue("@nameInserted", Tb_EmpFname.Text)
                    load1()
                    connection.Close()
                    Check_If_Data_Exists()

                End If


            End If


    End Sub
    'Code to give random string

    Private Sub Tb_EmpFname_TextChanged(sender As Object, e As EventArgs) Handles Tb_EmpFname.TextChanged
        Dim NewUsername As String
        Dim sResult As String = ""
        Dim rdm As New Random()

        For i As Integer = 1 To 4
            sResult &= ChrW(rdm.Next(32, 126))
        Next
        NewUsername = sResult + Tb_EmpFname.Text
        lbl_usname.Text = NewUsername
    End Sub


    Private Sub save_emp_pic_Click(sender As Object, e As EventArgs) Handles save_emp_pic.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.DefaultExt = ".jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_preview.BackgroundImage.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub Stop_Btn_Click_1(sender As Object, e As EventArgs) Handles Stop_Btn.Click
        If CAMEERA.IsRunning Then
            CAMEERA.Stop()
        End If

        emp_camera_view.BackgroundImage = My.Resources.logo
    End Sub

    Private Sub UpdateEmployeeDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeDetailsToolStripMenuItem.Click
        GroupBox1.Show()
        Button4.Show()
        check_update.Text = "update"
        load1()
        lbl_emp_id.Hide()
        Tb_Emp_Id.Show()

    End Sub

    Private Sub Tb_Emp_Id_TextChanged(sender As Object, e As EventArgs) Handles Tb_Emp_Id.TextChanged
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet
        connection.Open()
        adapter = New SqlDataAdapter("select * from Employee_Details where emp_Id like'%" & Tb_Emp_Id.Text & "%'", connection)
        adapter.Fill(ds)
        Employee_Details_Grid.DataSource = ds.Tables(0)
        connection.Close()


        connection.Open()
        Dim sqlcmd As New SqlCommand("select * from Employee_Details where emp_Id like'%" & Tb_Emp_Id.Text & "%'", connection)
        Dim myreader As SqlDataReader
        myreader = sqlcmd.ExecuteReader()
        myreader.Read()
        If myreader.HasRows Then
            Tb_EmpFname.Text = myreader.Item("Emp_FirstName").ToString
            Tb_EmpLName.Text = myreader.Item("Emp_LastName").ToString
            Tb_Emp_Add.Text = myreader.Item("emp_address").ToString

            Tb_Emp_Cell.Text = myreader.Item("emp_number").ToString
            lbl_usname.Text = myreader.Item("emp_usname").ToString
            Tb_Emp_psword.Text = myreader.Item("emp_password").ToString
            myreader.Close()

            If Tb_Emp_Id.Text = String.Empty Then
            Else
                Dim show_photo As New SqlCommand("select  emp_Image from Employee_Details where emp_Id=@emp_Id", connection)
                show_photo.Parameters.AddWithValue("@emp_Id", Tb_Emp_Id.Text)
                Dim ms As New MemoryStream(CType(show_photo.ExecuteScalar, Byte()))
                'mage_preview.BackgroundImage = Image.FromStream(ms)
                show_photo.Dispose()
            End If

        End If
        connection.Close()

    End Sub

    Private Sub RemoveEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveEmployeeToolStripMenuItem.Click
        Delete_btn.Show()
        Tb_Emp_Id.Show()
        lbl_emp_id.Hide()
        Button4.Hide()
        GroupBox1.Show()
        load1()


    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        connection.Open()
        Dim cmd As New SqlCommand
        cmd = connection.CreateCommand
        cmd.CommandText = "delete from Employee_Details where emp_Id=@emp_Id"
        cmd.Parameters.AddWithValue("@emp_Id", Tb_Emp_Id.Text)
        cmd.ExecuteNonQuery()
        load1()

        'Check if deleted and tell user
        check_If_Data_Is_Not_In_Table()

    End Sub

    Private Sub ViewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEmployeeToolStripMenuItem.Click
        GroupBox1.Show()
        load1()
        Tb_Emp_Id.Show()
        lbl_emp_id.Hide()
        Button4.Hide()
        Delete_btn.Hide()
    End Sub

    Private Sub SearchEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchEmployeeToolStripMenuItem.Click
        GroupBox1.Show()
        load1()
        lbl_emp_id.Hide()
        Tb_Emp_Id.Show()
        Button4.Hide()
        Delete_btn.Hide()
    End Sub

    Private Sub clr_emp_btn_Click(sender As Object, e As EventArgs) Handles clr_emp_btn.Click
        Tb_Emp_Id.Clear()
        Tb_EmpFname.Clear()
        Tb_EmpLName.Clear()
        Tb_Emp_Add.Clear()
        Tb_Emp_Cell.Clear()
        Tb_Emp_psword.Clear()
        lbl_usname.Text = ""
    End Sub

    Private Sub open_slide_Click(sender As Object, e As EventArgs) Handles open_slide.Click
        If slide.Visible Then

        Else
            animation1.ShowSync(slide)
            close_slide.Show()
            open_slide.Hide()

        End If

    End Sub

    Private Sub donor_btn_Click(sender As Object, e As EventArgs) Handles donor_btn.Click

        strip_donor.Show(donor_btn, 0, donor_btn.Height)
        Me.Close()

        manager_Donor.Show()


    End Sub

    Private Sub close_slide_Click_1(sender As Object, e As EventArgs) Handles close_slide.Click
        If slide.Visible Then
            animation1.HideSync(slide)
            open_slide.Show()
            close_slide.Hide()
        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Victim_btn.Click
        victim_strip.Show(Victim_btn, 0, Victim_btn.Height)
        Me.Close()
        manager_victim.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.Close()
        manager_victim.Show()

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        MessageBox.Show("The flood recovery system has  five basic enteries, click the buttons to activate a drop down menu. for more information visit www.ons.com")
        Dim web_address As String = "http://www.google.com"
        Process.Start(web_address)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        asset_manager.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        manager_area.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Me.Close()

    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        PrintDialog.PrinterSettings = PrintDoc.PrinterSettings

        If PrintDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDoc.PrinterSettings = PrintDialog.PrinterSettings

            Dim PageSetup As New PageSettings
            With PageSetup
                .Margins.Left = 50
                .Margins.Right = 50
                .Margins.Top = 50
                .Margins.Bottom = 50
                .Landscape = False

            End With
            PrintDoc.DefaultPageSettings = PageSetup

        End If
        PrintPreviewDialog.Document = PrintDoc
        PrintPreviewDialog.ShowDialog()


    End Sub
End Class