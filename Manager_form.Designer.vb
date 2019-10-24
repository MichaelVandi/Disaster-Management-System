<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manager_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manager_form))
        Me.manager_usname = New System.Windows.Forms.TextBox()
        Me.manager_psword = New System.Windows.Forms.TextBox()
        Me.login_manager_btn = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'manager_usname
        '
        Me.manager_usname.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.manager_usname.Location = New System.Drawing.Point(46, 128)
        Me.manager_usname.Name = "manager_usname"
        Me.manager_usname.Size = New System.Drawing.Size(334, 36)
        Me.manager_usname.TabIndex = 0
        '
        'manager_psword
        '
        Me.manager_psword.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manager_psword.Location = New System.Drawing.Point(44, 188)
        Me.manager_psword.Name = "manager_psword"
        Me.manager_psword.Size = New System.Drawing.Size(334, 36)
        Me.manager_psword.TabIndex = 1
        '
        'login_manager_btn
        '
        Me.login_manager_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.login_manager_btn.Location = New System.Drawing.Point(140, 232)
        Me.login_manager_btn.Name = "login_manager_btn"
        Me.login_manager_btn.Size = New System.Drawing.Size(124, 43)
        Me.login_manager_btn.TabIndex = 3
        Me.login_manager_btn.Text = "LOGIN"
        Me.login_manager_btn.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(13, 261)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Manager_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Template_finally_main
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1348, 729)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.login_manager_btn)
        Me.Controls.Add(Me.manager_psword)
        Me.Controls.Add(Me.manager_usname)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Manager_form"
        Me.Text = "Manager_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents manager_usname As TextBox
    Friend WithEvents manager_psword As TextBox
    Friend WithEvents login_manager_btn As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
