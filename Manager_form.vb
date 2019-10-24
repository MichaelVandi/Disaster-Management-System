
Imports System.Data.SqlClient
Public Class Manager_form
    Dim password_check As Integer
    Dim connection As New SqlConnection("Data Source=MICHAEL;Initial Catalog=FLOOD_RECOVERY_SYSTEM;Integrated Security=True")
    Private Sub login_manager_btn_Click(sender As Object, e As EventArgs) Handles login_manager_btn.Click

        Dim Command As New SqlCommand("select * from  MANAGER_PASSWORD  where username_manager=@username_manager
            and  password_manager=@password_manager", connection)
        Command.Parameters.Add("@username_manager", SqlDbType.VarChar).Value = manager_usname.Text
        Command.Parameters.Add("@password_manager", SqlDbType.VarChar).Value = manager_psword.Text
        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() >= 1 Then
            'MessageBox.Show("Login Successfully")

            Me.Close()
            manager_panel.Show()
            password_check = 0

        Else
            MessageBox.Show("Access Denied")
            password_check += 1
            manager_usname.Focus()
        End If

        If password_check = 3 Then
            MessageBox.Show("Final try!!")
        ElseIf password_check = 4 Then
            MsgBox("You've used up all your chances, try again")
            Close()
        End If


    End Sub

    Private Sub Manager_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        manager_psword.PasswordChar = "*"
    End Sub
End Class