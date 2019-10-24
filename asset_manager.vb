Imports System.Data.SqlClient

Public Class asset_manager
    Dim connection As New SqlConnection("Data Source=MICHAEL;Initial Catalog=FLOOD_RECOVERY_SYSTEM;Integrated Security=True")

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles asset_btn.Click

        Asset_strip.Show(asset_btn, 0, asset_btn.Height)



    End Sub
    Sub load1()

        Dim query1 As String = "select * from ASSET"
        Dim adapter As New SqlDataAdapter(query1, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        Employee_Details_Grid.DataSource = table
        connection.Close()
    End Sub

    Sub Check_If_Data_Exists()
        connection.Open()

        Dim theQuery As String = "SELECT * FROM ASSET WHERE asset_name=@asset_name AND asset_cost_Le=@asset_cost_Le"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@asset_name", Tb_EmpFname.Text)
        cmd1.Parameters.AddWithValue("@asset_cost_Le", cost_txt.Text)

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

        Dim theQuery As String = "SELECT * FROM ASSET WHERE asset_name=@asset_name AND asset_cost_Le=@asset_cost_Le"
        Dim cmd1 As SqlCommand = New SqlCommand(theQuery, connection)
        cmd1.Parameters.AddWithValue("@asset_name", Tb_EmpFname.Text)
        cmd1.Parameters.AddWithValue("@asset_cost_Le", cost_txt.Text)

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
    Private Sub asset_manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()

    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        GroupBox1.Show()
        Tb_Emp_Id.Hide()
        Delete_btn.Hide()
        load1()

        check_update.Text = "new"

    End Sub

    Private Sub Tb_Vic_Sex_TextChanged(sender As Object, e As EventArgs) Handles date_lost.TextChanged
        If date_obtained.Text.ToString.Length > 3 AndAlso date_lost.Text.ToString.Length > 3 Then

            Dim dateGot As String
            Dim dateLost As String

            dateGot = Convert.ToInt32(date_obtained.Text.Substring(0, 4))
            dateLost = Convert.ToInt32(date_lost.Text.Substring(0, 4))

            If dateGot > dateLost Then
                MessageBox.Show("Check your dates, date got cannot be greater than date lost")
            Else

                Dim usefulYears As Integer
                usefulYears = dateLost - dateGot
                lbl_useful.Text = usefulYears

                If cost_txt.Text = String.Empty Then
                    MessageBox.Show("Enter cost before calculating depreciation and final cost")
                Else
                    Dim cost As Integer
                    Dim depreciation As Integer
                    Dim final_cost As Integer = 0

                    cost = Convert.ToInt64(cost_txt.Text)
                    If cost >= 50000 Then

                        depreciation = (1 / 2 * cost) / (usefulYears / 5)
                        final_cost = cost - depreciation

                        Lbl_depreciation.Text = depreciation
                        Lbl_final.Text = final_cost

                    ElseIf cost < 50000 Then

                        depreciation = (2 / 3 * cost) / (usefulYears / 5)
                        final_cost = cost - depreciation

                        Lbl_depreciation.Text = depreciation
                        Lbl_final.Text = final_cost

                    End If

                End If
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Tb_EmpFname.Text = String.Empty OrElse cost_txt.Text = String.Empty OrElse date_obtained.Text =
        String.Empty OrElse date_lost.Text = String.Empty OrElse lbl_useful.Text = "auto calculated" OrElse Lbl_final.Text = "auto calculated" Then
            MessageBox.Show("There are required empty fields")
        Else
            'insert into database
            If check_update.Text = "new" Then
                Dim insertCommand As New SqlCommand

                connection.Open()

                insertCommand = connection.CreateCommand
                insertCommand.CommandText = "insert into ASSET (asset_name, asset_cost_Le, date_acquired, date_lost, useful_life_years, depreciation_Le, final_cost_le, insurance_company, Owner_Id) 
                    values (@asset_name, @asset_cost_Le, @date_acquired, @date_lost, @useful_life_years, @depreciation_Le, @final_cost_le, @insurance_company, @Owner_Id)"

                insertCommand.Parameters.AddWithValue("@asset_name", Tb_EmpFname.Text)
                insertCommand.Parameters.AddWithValue("@asset_cost_Le", cost_txt.Text)
                insertCommand.Parameters.AddWithValue("@date_acquired", date_obtained.Text)
                insertCommand.Parameters.AddWithValue("@date_lost", date_lost.Text)
                insertCommand.Parameters.AddWithValue("@useful_life_years", lbl_useful.Text)
                insertCommand.Parameters.AddWithValue("@depreciation_Le", Lbl_depreciation.Text)
                insertCommand.Parameters.AddWithValue("@final_cost_le", Lbl_final.Text)
                insertCommand.Parameters.AddWithValue("@insurance_company", Insurance_txt.Text)
                insertCommand.Parameters.AddWithValue("@Owner_Id", owner_txt_id.Text)

                insertCommand.ExecuteNonQuery()

                load1()
                connection.Close()
                Check_If_Data_Exists()


            ElseIf check_update.Text = "update" Then

                connection.Open()
                Dim updateCommand As New SqlCommand
                updateCommand = connection.CreateCommand
                updateCommand.CommandText = "update  ASSET set asset_name=@asset_name, asset_cost_Le=@asset_cost_Le,
                        date_acquired=@date_acquired, date_lost=@date_lost, useful_life_years=@useful_life_years,
                        depreciation_Le=@depreciation_Le, final_cost_le=@final_cost_le, insurance_company=@insurance_company,
                            Owner_Id=@Owner_Id where asset_Id=@asset_Id"

                updateCommand.Parameters.AddWithValue("@asset_Id", Tb_Emp_Id.Text)
                updateCommand.Parameters.AddWithValue("@asset_name", Tb_EmpFname.Text)
                updateCommand.Parameters.AddWithValue("@asset_cost_Le", cost_txt.Text)
                updateCommand.Parameters.AddWithValue("@date_acquired", date_obtained.Text)
                updateCommand.Parameters.AddWithValue("@date_lost", date_lost.Text)
                updateCommand.Parameters.AddWithValue("@useful_life_years", lbl_useful.Text)
                updateCommand.Parameters.AddWithValue("@depreciation_Le", Lbl_depreciation.Text)
                updateCommand.Parameters.AddWithValue("@final_cost_le", Lbl_final.Text)
                updateCommand.Parameters.AddWithValue("@insurance_company", Insurance_txt.Text)
                updateCommand.Parameters.AddWithValue("@Owner_Id", owner_txt_id.Text)

                updateCommand.ExecuteNonQuery()

                load1()
                connection.Close()
                Check_If_Data_Exists()



            End If


        End If
    End Sub

    Private Sub employee_btn_Click(sender As Object, e As EventArgs) Handles employee_btn.Click
        Me.Close()
        manager_panel.Show()

    End Sub

    Private Sub donor_btn_Click(sender As Object, e As EventArgs) Handles donor_btn.Click
        Me.Close()
        manager_Donor.Show()

    End Sub

    Private Sub vic_btn_Click(sender As Object, e As EventArgs) Handles vic_btn.Click
        Me.Close()
        manager_victim.Show()


    End Sub

    Private Sub area_btn_Click(sender As Object, e As EventArgs) Handles area_btn.Click
        Me.Close()
        manager_area.Show()

    End Sub



    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        GroupBox1.Show()
        Button4.Show()
        Delete_btn.Hide()

        Tb_Emp_Id.Show()
        check_update.Text = "update"

    End Sub
End Class