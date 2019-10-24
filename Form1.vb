Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class manager_Donor
    Dim CAMEERA As VideoCaptureDevice
    Dim initial_Picture As Bitmap

    Dim connection As New SqlConnection("Data Source=MICHAEL;Initial Catalog=FLOOD_RECOVERY_SYSTEM;Integrated Security=True")
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
    End Sub
    Sub showStrip()
        strip_donor.Show(donor_btn, 0, donor_btn.Height)
    End Sub
    Private Sub manager_Donor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showStrip()
        Tb_amount.Show()

        GroupBox1.Show()

    End Sub
    Sub load1()

        Dim query1 As String = "select * from Donor_details"
        Dim adapter As New SqlDataAdapter(query1, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        Employee_Details_Grid.DataSource = table
        connection.Close()
    End Sub

    Private Sub donor_btn_Click(sender As Object, e As EventArgs) Handles donor_btn.Click
        showStrip()
    End Sub

    Sub Check_If_Data_Exists()
        connection.Open()

        Dim theQuery As String = "SELECT * FROM Donor_details WHERE donors_Name=@donors_Name AND donor_code=@donor_code"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@donors_Name", Tb_don_name.Text)
        cmd1.Parameters.AddWithValue("@donor_code", lbl_usname.Text)

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

        Dim theQuery As String = "SELECT * FROM Donor_details WHERE donors_Name=@donors_Name AND donor_code=@donor_code"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@donors_Name", Tb_don_name.Text)
        cmd1.Parameters.AddWithValue("@donor_code", lbl_usname.Text)

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

    Private Sub AddDonorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDonorToolStripMenuItem.Click
        GroupBox1.Show()
        check_update.Text = "new"
        Delete_btn.Hide()
        Button4.Show()
        Tb_don_Id.Hide()

    End Sub
    Private Sub capturedView(sender As Object, eventArgs As NewFrameEventArgs)
        initial_Picture = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        emp_camera_view.BackgroundImage = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub


    Private Sub start_emp_cam_Click(sender As Object, e As EventArgs) Handles start_emp_cam.Click
        Dim camera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If camera.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CAMEERA = camera.VideoDevice
            AddHandler CAMEERA.NewFrame, New NewFrameEventHandler(AddressOf capturedView)
            CAMEERA.Start()
        End If
    End Sub

    Private Sub capture_emp_pic_Click(sender As Object, e As EventArgs)
        image_preview.BackgroundImage = emp_camera_view.BackgroundImage
    End Sub

    Private Sub save_emp_pic_Click(sender As Object, e As EventArgs) Handles save_emp_pic.Click
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.DefaultExt = ".jpg"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_preview.BackgroundImage.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Private Sub image_preview_Click(sender As Object, e As EventArgs) Handles image_preview.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            image_preview.BackgroundImage = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Tb_don_name.Text = String.Empty OrElse Tb_don_country.Text = String.Empty Then
            MessageBox.Show("There are empty fields")
        Else

            If check_update.Text = "new" Then
                'add new record
                connection.Open()

                Dim insert_command As New SqlCommand
                insert_command = connection.CreateCommand
                insert_command.CommandText = "insert into Donor_details (donors_Name, donors_country, donors_amount,
                            material_asset, donor_code) values (@donors_Name, @donors_country, @donors_amount,
                            @material_asset, @donor_code
                                                                                )"

                insert_command.Parameters.AddWithValue("@donors_Name", Tb_don_name.Text)
                insert_command.Parameters.AddWithValue("@donors_country", Tb_don_country.Text)
                insert_command.Parameters.AddWithValue("@donors_amount", Tb_amount.Text)
                insert_command.Parameters.AddWithValue("@material_asset", Tb_don_aid.Text)
                insert_command.Parameters.AddWithValue("@donor_code", lbl_usname.Text)

                insert_command.ExecuteNonQuery()
                load1()
                connection.Close()
                Check_If_Data_Exists()
            ElseIf check_update.Text = "update" Then

                connection.Open()

                Dim insert_command As New SqlCommand
                insert_command = connection.CreateCommand
                insert_command.CommandText = "update  Donor_details  set donors_Name=@donors_Name, donors_country=@donors_country
donors_amount=@donors_amount, material_asset=@material_asset, donor_code=@donor_code where donors_Id=@donors_Id
                                                                                )"

                insert_command.Parameters.AddWithValue("@donors_Name", Tb_don_name.Text)
                insert_command.Parameters.AddWithValue("@donors_Id", Tb_don_Id.Text)

                insert_command.Parameters.AddWithValue("@donors_country", Tb_don_country.Text)
                insert_command.Parameters.AddWithValue("@donors_amount", Tb_don_aid.Text)
                insert_command.Parameters.AddWithValue("@material_asset", Tb_don_aid.Text)
                insert_command.Parameters.AddWithValue("@donor_code", lbl_usname.Text)

                insert_command.ExecuteNonQuery()
                load1()
                connection.Close()
                Check_If_Data_Exists()
            End If

        End If
    End Sub

    Private Sub Tb_don_name_TextChanged(sender As Object, e As EventArgs) Handles Tb_don_name.TextChanged
        Dim NewUsername As String
        Dim sResult As String = ""
        Dim rdm As New Random()

        For i As Integer = 1 To 4
            sResult &= ChrW(rdm.Next(32, 126))
        Next
        NewUsername = sResult + Tb_don_name.Text
        lbl_usname.Text = NewUsername

    End Sub

    Private Sub UpdateDonorAmountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDonorAmountToolStripMenuItem.Click
        GroupBox1.Show()
        check_update.Text = "update"
        Delete_btn.Hide()
        Button4.Show()
        Tb_don_Id.Show()

    End Sub

    Private Sub Tb_don_Id_TextChanged(sender As Object, e As EventArgs) Handles Tb_don_Id.TextChanged

        If check_update.Text = "update" OrElse check_update.Text = "search" OrElse check_update.Text = "view" Then
            Dim adapter As SqlDataAdapter
            Dim ds As New DataSet
            connection.Open()
            adapter = New SqlDataAdapter("select * from Donor_details where donors_Id like'%" & Tb_don_Id.Text & "%'", connection)
            adapter.Fill(ds)
            Employee_Details_Grid.DataSource = ds.Tables(0)
            connection.Close()


            connection.Open()
            Dim sqlcmd As New SqlCommand("select * from Donor_details where donors_Id like'%" & Tb_don_Id.Text & "%'", connection)
            Dim myreader As SqlDataReader
            myreader = sqlcmd.ExecuteReader()
            myreader.Read()
            If myreader.HasRows Then

                Tb_don_name.Text = myreader.Item("donors_Name").ToString
                Tb_don_country.Text = myreader.Item("donors_country").ToString
                Tb_amount.Text = myreader.Item("donors_amount").ToString
                Tb_don_aid.Text = myreader.Item("material_asset").ToString
                lbl_usname.Text = myreader.Item("donor_code").ToString

            End If
        End If
    End Sub

    Private Sub ViewDonationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewDonationsToolStripMenuItem.Click
        GroupBox1.Show()
        Delete_btn.Hide()
        Button4.Show()
        Tb_don_Id.Show()

        check_update.Text = "view"

    End Sub

    Private Sub SearchDonationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchDonationsToolStripMenuItem.Click
        GroupBox1.Show()
        Delete_btn.Hide()
        Button4.Show()
        Tb_don_Id.Show()
        check_update.Text = "search"
    End Sub

    Private Sub employee_btn_Click(sender As Object, e As EventArgs) Handles employee_btn.Click
        Me.Close()
        manager_panel.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        manager_victim.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        asset_manager.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        manager_area.Show()

    End Sub
End Class