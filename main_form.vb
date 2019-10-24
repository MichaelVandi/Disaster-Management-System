
Imports System.Data.SqlClient

Public Class main_form
    Dim connection As New SqlConnection("Data Source=MICHAEL;Initial Catalog=FLOOD_RECOVERY_SYSTEM;Integrated Security=True")
    Dim password_check As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles manager_btn.Click
        Me.Hide()

        Manager_form.Show()

    End Sub
    Sub loadvic()
        Dim command As New SqlCommand
        connection.Open()

        command = connection.CreateCommand
        command.CommandText = "select * from VICTIM where Victim_Id=@Victim_Id"
        command.Parameters.AddWithValue("@Victim_Id", usname_emp)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
    End Sub
    Sub loaddon()

        Dim command As New SqlCommand
        connection.Open()

        command = connection.CreateCommand
        command.CommandText = "select * from Donor_details where donors_Id=@donors_Id"
        command.Parameters.AddWithValue("@donors_Id", usname_emp)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
        connection.Close()
    End Sub


    Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles manager_btn.MouseHover
        manager_btn.BackColor = Color.Turquoise
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles manager_btn.MouseLeave
        manager_btn.BackColor = Color.Transparent
    End Sub

    'Button 2
    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles emp_btn.MouseHover
        emp_btn.BackColor = Color.Turquoise
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles emp_btn.MouseLeave
        emp_btn.BackColor = Color.Transparent
    End Sub
    'Button 3
    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles donor_btn.MouseHover
        donor_btn.BackColor = Color.Turquoise
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles donor_btn.MouseLeave
        donor_btn.BackColor = Color.Transparent
    End Sub
    'Button 4
    Private Sub Button4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles victim_btn.MouseHover
        victim_btn.BackColor = Color.Turquoise
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles victim_btn.MouseLeave
        victim_btn.BackColor = Color.Transparent
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        If check_user.Text = "employee" Then
            connection.Open()

            Dim Command As New SqlCommand("select * from  Employee_Details  where emp_Id=@emp_Id
            and  emp_password=@emp_password", connection)
            Command.Parameters.Add("@emp_Id", SqlDbType.VarChar).Value = usname_emp.Text
            Command.Parameters.Add("@emp_password", SqlDbType.VarChar).Value = password_emp.Text
            Dim adapter As New SqlDataAdapter(Command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() >= 1 Then
                'MessageBox.Show("Login Successfully")


                password_check = 0

            Else
                MessageBox.Show("Access Denied")
                password_check += 1
                usname_emp.Focus()
                password_emp.Focus()

            End If

            If password_check = 3 Then
                MessageBox.Show("Final try!!")
            ElseIf password_check = 4 Then
                MsgBox("You've used up all your chances, try again")
                Close()
            End If
            connection.Close()

        ElseIf check_user.Text = "victim" Then
            connection.Open()

            Dim Command As New SqlCommand("select * from  VICTIM  where Victim_Id=@Victim_Id
            and  Victim_Pin=@Victim_Pin", connection)
            Command.Parameters.Add("@Victim_Id", SqlDbType.VarChar).Value = usname_emp.Text
            Command.Parameters.Add("@Victim_Pin", SqlDbType.VarChar).Value = password_emp.Text
            Dim adapter As New SqlDataAdapter(Command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() >= 1 Then
                'MessageBox.Show("Login Successfully")

                loadvic()

                password_check = 0

            Else
                MessageBox.Show("Access Denied")
                password_check += 1
                usname_emp.Focus()
                password_emp.Focus()

            End If

            If password_check = 3 Then
                MessageBox.Show("Final try!!")
            ElseIf password_check = 4 Then
                MsgBox("You've used up all your chances, try again")
                Close()
            End If
            connection.Close()


        ElseIf check_user.Text = "donor" Then
            connection.Open()

            Dim Command As New SqlCommand("select * from  Donor_details  where donors_Id=@donors_Id
            and  donor_code=@donor_code", connection)
            Command.Parameters.Add("@donors_Id", SqlDbType.VarChar).Value = usname_emp.Text
            Command.Parameters.Add("@donor_code", SqlDbType.VarChar).Value = password_emp.Text
            Dim adapter As New SqlDataAdapter(Command)
            Dim table As New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() >= 1 Then
                'MessageBox.Show("Login Successfully")
                GroupBox2.Show()

                'show details
                loaddon()


                password_check = 0

            Else
                MessageBox.Show("Access Denied")
                password_check += 1
                usname_emp.Focus()
                password_emp.Focus()

            End If

            If password_check = 3 Then
                MessageBox.Show("Final try!!")
            ElseIf password_check = 4 Then
                MsgBox("You've used up all your chances, try again")
                Close()
            End If
            connection.Close()

        End If

    End Sub

    Private Sub emp_btn_Click(sender As Object, e As EventArgs) Handles emp_btn.Click
        GroupBox1.Show()
        check_user.Text = "employee"

    End Sub

    Private Sub donor_btn_Click(sender As Object, e As EventArgs) Handles donor_btn.Click
        GroupBox1.Show()

        check_user.Text = "donor"
    End Sub

    Private Sub victim_btn_Click(sender As Object, e As EventArgs) Handles victim_btn.Click
        GroupBox1.Show()


        check_user.Text = "victim"
    End Sub

    Private Sub main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Hide()
        GroupBox2.Hide()




    End Sub


End Class
