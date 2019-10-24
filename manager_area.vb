Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class manager_area
    Dim connection As New SqlConnection("Data Source=MICHAEL;Initial Catalog=FLOOD_RECOVERY_SYSTEM;Integrated Security=True")
    Sub load1()

        Dim query1 As String = "select * from Area"
        Dim adapter As New SqlDataAdapter(query1, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        Employee_Details_Grid.DataSource = table
        connection.Close()
    End Sub

    Sub Check_If_Data_Exists()
        connection.Open()

        Dim theQuery As String = "SELECT * FROM Area WHERE Constituency_Code=@Constituency_Code AND Area_Name=@Area_Name"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@Constituency_Code", area_code.Text)
        cmd1.Parameters.AddWithValue("@Area_Name", area_name.Text)

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
    'check if data does not exist
    Sub check_If_Data_Is_Not_In_Table()
        connection.Open()

        Dim theQuery As String = "SELECT * FROM Area WHERE Constituency_Code=@Constituency_Code AND Area_Name=@Area_Name"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@Constituency_Code", area_code.Text)
        cmd1.Parameters.AddWithValue("@Area_Name", area_name.Text)

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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If area_code.Text = String.Empty OrElse area_name.Text = String.Empty OrElse Area_Size.Text = String.Empty OrElse Area_Mayor.Text = String.Empty OrElse Area_Chairman.Text = String.Empty OrElse Area_Location.Text = String.Empty Then
            MessageBox.Show("There is an empty field")

        Else

            'check if it is insert or update,
            If check_update.Text = "new" Then
                'insert new record
                Dim command As New SqlCommand
                command = connection.CreateCommand
                connection.Open()

                command.CommandText = "insert into Area (Constituency_Code, Area_Name, Area_Location, Area_Size_Km, Area_Chairman, location_Mayor)
                                                                            values (@Constituency_Code, @Area_Name, @Area_Location, @Area_Size_Km, @Area_Chairman, @location_Mayor)"

                command.Parameters.AddWithValue("@Constituency_Code", area_code.Text)
                command.Parameters.AddWithValue("@Area_Name", area_name.Text)
                command.Parameters.AddWithValue("@Area_Location", Area_Location.Text)
                command.Parameters.AddWithValue("@Area_Size_Km", Area_Size.Text)
                command.Parameters.AddWithValue("@Area_Chairman", Area_Chairman.Text)
                command.Parameters.AddWithValue("@location_Mayor", Area_Mayor.Text)

                command.ExecuteNonQuery()
                load1()
                connection.Close()

                'check if data exists
                Check_If_Data_Exists()


            Else
                If check_update.Text = "update" Then
                    'update the record
                    Dim command As New SqlCommand
                    command = connection.CreateCommand
                    connection.Open()

                    command.CommandText = "update Area set Constituency_Code=@Constituency_Code, Area_Name=@Area_Name,
                            Area_Location=@Area_Location, Area_Size_Km=@Area_Size_Km, 
                        Area_Chairman=@Area_Chairman, location_Mayor=@location_Mayor"
                    command.Parameters.AddWithValue("@Constituency_Code", area_code.Text)
                    command.Parameters.AddWithValue("@Area_Name", area_name.Text)
                    command.Parameters.AddWithValue("@Area_Location", Area_Location.Text)
                    command.Parameters.AddWithValue("@Area_Size_Km", Area_Size.Text)
                    command.Parameters.AddWithValue("@Area_Chairman", Area_Chairman.Text)
                    command.Parameters.AddWithValue("@location_Mayor", Area_Mayor.Text)

                    command.ExecuteNonQuery()
                    load1()
                    connection.Close()

                    'check if data exists
                    Check_If_Data_Exists()

                End If
            End If

        End If

    End Sub

    Private Sub area_code_TextChanged(sender As Object, e As EventArgs) Handles area_code.TextChanged
        If check_update.Text = "update" OrElse check_update.Text = "search" OrElse check_update.Text = "view" OrElse check_update.Text = "delete" Then
            Dim adapter As SqlDataAdapter
            Dim ds As New DataSet
            connection.Open()
            adapter = New SqlDataAdapter("select * from Area where Constituency_Code like'%" & area_code.Text & "%'", connection)
            adapter.Fill(ds)
            Employee_Details_Grid.DataSource = ds.Tables(0)
            connection.Close()


            connection.Open()
            Dim sqlcmd As New SqlCommand("select * from Area where Constituency_Code like'%" & area_code.Text & "%'", connection)
            Dim myreader As SqlDataReader
            myreader = sqlcmd.ExecuteReader()
            myreader.Read()
            If myreader.HasRows Then
                area_name.Text = myreader.Item("Area_Name").ToString
                Area_Location.Text = myreader.Item("Area_Location").ToString
                Area_Size.Text = myreader.Item("Area_Size_Km").ToString

                Area_Chairman.Text = myreader.Item("Area_Chairman").ToString
                Area_Mayor.Text = myreader.Item("location_Mayor").ToString
            End If
            connection.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles area_btn.Click

        Area_strip.Show(area_btn, 0, area_btn.Height)


    End Sub

    Private Sub Add_area_Click(sender As Object, e As EventArgs) Handles Add_area.Click
        GroupBox1.Show()
        Delete_btn.Hide()
        Button4.Show()
        check_update.Text = "new"
        load1()

    End Sub

    Private Sub update_area_Click(sender As Object, e As EventArgs) Handles update_area.Click
        GroupBox1.Show()
        Delete_btn.Hide()
        Button4.Show()

        check_update.Text = "update"
        load1()
    End Sub

    Private Sub delete_area_Click(sender As Object, e As EventArgs) Handles delete_area.Click
        GroupBox1.Show()
        Delete_btn.Show()
        check_update.Text = "delete"
        Button4.Hide()
    End Sub

    Private Sub view_area_Click(sender As Object, e As EventArgs) Handles view_area.Click
        GroupBox1.Show()
        Delete_btn.Hide()
        Button4.Hide()
        check_update.Text = "view"
        load1()

    End Sub

    Private Sub search_area_Click(sender As Object, e As EventArgs) Handles search_area.Click
        GroupBox1.Show()
        Delete_btn.Hide()
        Button4.Hide()
        check_update.Text = "search"
        load1()
    End Sub

    Private Sub clr_emp_btn_Click(sender As Object, e As EventArgs) Handles clr_emp_btn.Click
        area_code.Clear()
        Area_Chairman.Clear()
        Area_Location.Clear()
        Area_Mayor.Clear()
        Area_Size.Clear()

    End Sub

    Private Sub Delete_btn_Click(sender As Object, e As EventArgs) Handles Delete_btn.Click
        connection.Open()
        Dim cmd As New SqlCommand
        cmd = connection.CreateCommand
        cmd.CommandText = "delete from Area where Constituency_Code=@Constituency_Code"
        cmd.Parameters.AddWithValue("@Constituency_Code", area_code.Text)
        cmd.ExecuteNonQuery()
        load1()

        'Check if deleted and tell user
        check_If_Data_Is_Not_In_Table()
    End Sub

    Private Sub manager_area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()

    End Sub

    Private Sub employee_btn_Click(sender As Object, e As EventArgs) Handles employee_btn.Click
        Me.Close()
        manager_panel.Show()

    End Sub

    Private Sub donor_btn_Click(sender As Object, e As EventArgs) Handles donor_btn.Click
        Me.Close()
        manager_Donor.Show()

    End Sub

    Private Sub Victim_btn_Click(sender As Object, e As EventArgs) Handles Victim_btn.Click
        Me.Close()
        manager_victim.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        asset_manager.Show()

    End Sub
End Class