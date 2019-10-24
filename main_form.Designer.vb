<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_form))
        Me.manager_btn = New System.Windows.Forms.Button()
        Me.emp_btn = New System.Windows.Forms.Button()
        Me.donor_btn = New System.Windows.Forms.Button()
        Me.victim_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.check_user = New System.Windows.Forms.Label()
        Me.vic_camera_view = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password_emp = New System.Windows.Forms.TextBox()
        Me.usname_emp = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vic_camera_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'manager_btn
        '
        Me.manager_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.manager_btn.ForeColor = System.Drawing.Color.Black
        Me.manager_btn.Location = New System.Drawing.Point(75, 327)
        Me.manager_btn.Name = "manager_btn"
        Me.manager_btn.Size = New System.Drawing.Size(176, 49)
        Me.manager_btn.TabIndex = 0
        Me.manager_btn.Text = "MANAGER"
        Me.manager_btn.UseVisualStyleBackColor = True
        '
        'emp_btn
        '
        Me.emp_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emp_btn.ForeColor = System.Drawing.Color.Black
        Me.emp_btn.Location = New System.Drawing.Point(75, 395)
        Me.emp_btn.Name = "emp_btn"
        Me.emp_btn.Size = New System.Drawing.Size(176, 49)
        Me.emp_btn.TabIndex = 1
        Me.emp_btn.Text = "EMPLOYEE"
        Me.emp_btn.UseVisualStyleBackColor = True
        '
        'donor_btn
        '
        Me.donor_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donor_btn.ForeColor = System.Drawing.Color.Black
        Me.donor_btn.Location = New System.Drawing.Point(75, 462)
        Me.donor_btn.Name = "donor_btn"
        Me.donor_btn.Size = New System.Drawing.Size(176, 49)
        Me.donor_btn.TabIndex = 2
        Me.donor_btn.Text = "DONOR"
        Me.donor_btn.UseVisualStyleBackColor = True
        '
        'victim_btn
        '
        Me.victim_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.victim_btn.ForeColor = System.Drawing.Color.Black
        Me.victim_btn.Location = New System.Drawing.Point(75, 527)
        Me.victim_btn.Name = "victim_btn"
        Me.victim_btn.Size = New System.Drawing.Size(176, 49)
        Me.victim_btn.TabIndex = 3
        Me.victim_btn.Text = "VICTIM"
        Me.victim_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.slid_show
        Me.PictureBox1.Location = New System.Drawing.Point(324, 315)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1012, 390)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.check_user)
        Me.GroupBox1.Controls.Add(Me.vic_camera_view)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.password_emp)
        Me.GroupBox1.Controls.Add(Me.usname_emp)
        Me.GroupBox1.Location = New System.Drawing.Point(337, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(999, 378)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(403, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 329)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-7, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(598, 307)
        Me.DataGridView1.TabIndex = 0
        '
        'check_user
        '
        Me.check_user.AutoSize = True
        Me.check_user.Location = New System.Drawing.Point(9, 19)
        Me.check_user.Name = "check_user"
        Me.check_user.Size = New System.Drawing.Size(39, 13)
        Me.check_user.TabIndex = 19
        Me.check_user.Text = "Label1"
        '
        'vic_camera_view
        '
        Me.vic_camera_view.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.logo
        Me.vic_camera_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vic_camera_view.Location = New System.Drawing.Point(205, 19)
        Me.vic_camera_view.Name = "vic_camera_view"
        Me.vic_camera_view.Size = New System.Drawing.Size(164, 117)
        Me.vic_camera_view.TabIndex = 18
        Me.vic_camera_view.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(205, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(7, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID:"
        '
        'password_emp
        '
        Me.password_emp.Location = New System.Drawing.Point(205, 240)
        Me.password_emp.Name = "password_emp"
        Me.password_emp.Size = New System.Drawing.Size(168, 20)
        Me.password_emp.TabIndex = 2
        '
        'usname_emp
        '
        Me.usname_emp.Location = New System.Drawing.Point(205, 214)
        Me.usname_emp.Name = "usname_emp"
        Me.usname_emp.Size = New System.Drawing.Size(168, 20)
        Me.usname_emp.TabIndex = 1
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1348, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.victim_btn)
        Me.Controls.Add(Me.donor_btn)
        Me.Controls.Add(Me.emp_btn)
        Me.Controls.Add(Me.manager_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main_form"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vic_camera_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents manager_btn As Button
    Friend WithEvents emp_btn As Button
    Friend WithEvents donor_btn As Button
    Friend WithEvents victim_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents check_user As Label
    Friend WithEvents vic_camera_view As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password_emp As TextBox
    Friend WithEvents usname_emp As TextBox
End Class
