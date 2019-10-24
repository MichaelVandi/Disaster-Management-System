<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manager_victim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manager_victim))
        Me.strip_donor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDonorAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDonationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchDonationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.employee_btn = New System.Windows.Forms.Button()
        Me.donor_btn = New System.Windows.Forms.Button()
        Me.vic_btn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_vic_age = New System.Windows.Forms.Label()
        Me.tb_vic_address = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Tb_Area_code = New System.Windows.Forms.TextBox()
        Me.Tb_Vic_Sex = New System.Windows.Forms.TextBox()
        Me.Tb_emp_cell = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.check_update = New System.Windows.Forms.Label()
        Me.Tb_Emp_Id = New System.Windows.Forms.TextBox()
        Me.Stop_Btn = New System.Windows.Forms.Button()
        Me.clr_emp_btn = New System.Windows.Forms.Button()
        Me.vic_camera_view = New System.Windows.Forms.PictureBox()
        Me.save_vic_pic = New System.Windows.Forms.Button()
        Me.image_preview_vic = New System.Windows.Forms.PictureBox()
        Me.capture_vic_pic = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.start_vic_cam = New System.Windows.Forms.Button()
        Me.Tb_EmpFname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_EmpLName = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_Emp_Dob = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_vic_status = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_usname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_emp_id = New System.Windows.Forms.Label()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.Employee_Details_Grid = New System.Windows.Forms.DataGridView()
        Me.victim_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.add_vic = New System.Windows.Forms.ToolStripMenuItem()
        Me.update_vic = New System.Windows.Forms.ToolStripMenuItem()
        Me.delete_vic = New System.Windows.Forms.ToolStripMenuItem()
        Me.view_vic = New System.Windows.Forms.ToolStripMenuItem()
        Me.search_vic = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.strip_donor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.vic_camera_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image_preview_vic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_Details_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.victim_strip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'strip_donor
        '
        Me.strip_donor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDonorToolStripMenuItem, Me.UpdateDonorAmountToolStripMenuItem, Me.DeleteAmountToolStripMenuItem, Me.ViewDonationsToolStripMenuItem, Me.SearchDonationsToolStripMenuItem})
        Me.strip_donor.Name = "strip_donor"
        Me.strip_donor.Size = New System.Drawing.Size(196, 114)
        '
        'AddDonorToolStripMenuItem
        '
        Me.AddDonorToolStripMenuItem.Name = "AddDonorToolStripMenuItem"
        Me.AddDonorToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AddDonorToolStripMenuItem.Text = "Add Donor"
        '
        'UpdateDonorAmountToolStripMenuItem
        '
        Me.UpdateDonorAmountToolStripMenuItem.Name = "UpdateDonorAmountToolStripMenuItem"
        Me.UpdateDonorAmountToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.UpdateDonorAmountToolStripMenuItem.Text = "Update Donor Amount"
        '
        'DeleteAmountToolStripMenuItem
        '
        Me.DeleteAmountToolStripMenuItem.Name = "DeleteAmountToolStripMenuItem"
        Me.DeleteAmountToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DeleteAmountToolStripMenuItem.Text = "Delete Amount"
        '
        'ViewDonationsToolStripMenuItem
        '
        Me.ViewDonationsToolStripMenuItem.Name = "ViewDonationsToolStripMenuItem"
        Me.ViewDonationsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ViewDonationsToolStripMenuItem.Text = "View Donations"
        '
        'SearchDonationsToolStripMenuItem
        '
        Me.SearchDonationsToolStripMenuItem.Name = "SearchDonationsToolStripMenuItem"
        Me.SearchDonationsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SearchDonationsToolStripMenuItem.Text = "Search Donations"
        '
        'employee_btn
        '
        Me.employee_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.employee_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.employee_btn.Location = New System.Drawing.Point(40, 338)
        Me.employee_btn.Name = "employee_btn"
        Me.employee_btn.Size = New System.Drawing.Size(221, 39)
        Me.employee_btn.TabIndex = 14
        Me.employee_btn.Text = "EMPLOYEE"
        Me.employee_btn.UseVisualStyleBackColor = True
        '
        'donor_btn
        '
        Me.donor_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.donor_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.donor_btn.Location = New System.Drawing.Point(40, 383)
        Me.donor_btn.Name = "donor_btn"
        Me.donor_btn.Size = New System.Drawing.Size(221, 36)
        Me.donor_btn.TabIndex = 15
        Me.donor_btn.Text = "DONOR"
        Me.donor_btn.UseVisualStyleBackColor = True
        '
        'vic_btn
        '
        Me.vic_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.vic_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.vic_btn.Location = New System.Drawing.Point(40, 427)
        Me.vic_btn.Name = "vic_btn"
        Me.vic_btn.Size = New System.Drawing.Size(221, 37)
        Me.vic_btn.TabIndex = 16
        Me.vic_btn.Text = "VICTIM"
        Me.vic_btn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(40, 472)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(221, 37)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "ASSET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(40, 520)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 37)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "AREA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1312, 321)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Employee_Details_Grid)
        Me.GroupBox1.Location = New System.Drawing.Point(298, 322)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 405)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_vic_age)
        Me.GroupBox2.Controls.Add(Me.tb_vic_address)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Tb_Area_code)
        Me.GroupBox2.Controls.Add(Me.Tb_Vic_Sex)
        Me.GroupBox2.Controls.Add(Me.Tb_emp_cell)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.check_update)
        Me.GroupBox2.Controls.Add(Me.Tb_Emp_Id)
        Me.GroupBox2.Controls.Add(Me.Stop_Btn)
        Me.GroupBox2.Controls.Add(Me.clr_emp_btn)
        Me.GroupBox2.Controls.Add(Me.vic_camera_view)
        Me.GroupBox2.Controls.Add(Me.save_vic_pic)
        Me.GroupBox2.Controls.Add(Me.image_preview_vic)
        Me.GroupBox2.Controls.Add(Me.capture_vic_pic)
        Me.GroupBox2.Controls.Add(Me.lbl)
        Me.GroupBox2.Controls.Add(Me.start_vic_cam)
        Me.GroupBox2.Controls.Add(Me.Tb_EmpFname)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Tb_EmpLName)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Tb_Emp_Dob)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Tb_vic_status)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl_usname)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_emp_id)
        Me.GroupBox2.Controls.Add(Me.Delete_btn)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 377)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lbl_vic_age
        '
        Me.lbl_vic_age.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_vic_age.Location = New System.Drawing.Point(264, 205)
        Me.lbl_vic_age.Name = "lbl_vic_age"
        Me.lbl_vic_age.Size = New System.Drawing.Size(155, 20)
        Me.lbl_vic_age.TabIndex = 34
        Me.lbl_vic_age.Text = "auto calculated"
        '
        'tb_vic_address
        '
        Me.tb_vic_address.Cursor = System.Windows.Forms.Cursors.No
        Me.tb_vic_address.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tb_vic_address.Location = New System.Drawing.Point(263, 247)
        Me.tb_vic_address.Multiline = True
        Me.tb_vic_address.Name = "tb_vic_address"
        Me.tb_vic_address.Size = New System.Drawing.Size(183, 20)
        Me.tb_vic_address.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Victim's Address:"
        '
        'Tb_Area_code
        '
        Me.Tb_Area_code.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_Area_code.Location = New System.Drawing.Point(263, 328)
        Me.Tb_Area_code.Multiline = True
        Me.Tb_Area_code.Name = "Tb_Area_code"
        Me.Tb_Area_code.Size = New System.Drawing.Size(183, 20)
        Me.Tb_Area_code.TabIndex = 31
        '
        'Tb_Vic_Sex
        '
        Me.Tb_Vic_Sex.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_Vic_Sex.Location = New System.Drawing.Point(263, 226)
        Me.Tb_Vic_Sex.Multiline = True
        Me.Tb_Vic_Sex.Name = "Tb_Vic_Sex"
        Me.Tb_Vic_Sex.Size = New System.Drawing.Size(183, 20)
        Me.Tb_Vic_Sex.TabIndex = 30
        '
        'Tb_emp_cell
        '
        Me.Tb_emp_cell.Cursor = System.Windows.Forms.Cursors.No
        Me.Tb_emp_cell.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_emp_cell.Location = New System.Drawing.Point(263, 267)
        Me.Tb_emp_cell.Multiline = True
        Me.Tb_emp_cell.Name = "Tb_emp_cell"
        Me.Tb_emp_cell.Size = New System.Drawing.Size(183, 20)
        Me.Tb_emp_cell.TabIndex = 29
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 328)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Area Code:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Victim's Status:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Victim's Pin:"
        '
        'check_update
        '
        Me.check_update.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.check_update.Location = New System.Drawing.Point(377, 354)
        Me.check_update.Name = "check_update"
        Me.check_update.Size = New System.Drawing.Size(69, 20)
        Me.check_update.TabIndex = 24
        Me.check_update.Text = "save"
        '
        'Tb_Emp_Id
        '
        Me.Tb_Emp_Id.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Emp_Id.Location = New System.Drawing.Point(263, 122)
        Me.Tb_Emp_Id.Multiline = True
        Me.Tb_Emp_Id.Name = "Tb_Emp_Id"
        Me.Tb_Emp_Id.Size = New System.Drawing.Size(185, 16)
        Me.Tb_Emp_Id.TabIndex = 23
        '
        'Stop_Btn
        '
        Me.Stop_Btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Stop_Btn.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stop_Btn.Location = New System.Drawing.Point(188, 348)
        Me.Stop_Btn.Name = "Stop_Btn"
        Me.Stop_Btn.Size = New System.Drawing.Size(71, 30)
        Me.Stop_Btn.TabIndex = 22
        Me.Stop_Btn.Text = "STOP"
        Me.Stop_Btn.UseVisualStyleBackColor = False
        '
        'clr_emp_btn
        '
        Me.clr_emp_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.clr_emp_btn.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr_emp_btn.Location = New System.Drawing.Point(92, 348)
        Me.clr_emp_btn.Name = "clr_emp_btn"
        Me.clr_emp_btn.Size = New System.Drawing.Size(90, 30)
        Me.clr_emp_btn.TabIndex = 21
        Me.clr_emp_btn.Text = "CLEAR"
        Me.clr_emp_btn.UseVisualStyleBackColor = False
        '
        'vic_camera_view
        '
        Me.vic_camera_view.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.logo
        Me.vic_camera_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.vic_camera_view.Location = New System.Drawing.Point(6, 2)
        Me.vic_camera_view.Name = "vic_camera_view"
        Me.vic_camera_view.Size = New System.Drawing.Size(164, 117)
        Me.vic_camera_view.TabIndex = 17
        Me.vic_camera_view.TabStop = False
        '
        'save_vic_pic
        '
        Me.save_vic_pic.BackColor = System.Drawing.Color.SteelBlue
        Me.save_vic_pic.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_vic_pic.Location = New System.Drawing.Point(193, 77)
        Me.save_vic_pic.Name = "save_vic_pic"
        Me.save_vic_pic.Size = New System.Drawing.Size(66, 42)
        Me.save_vic_pic.TabIndex = 20
        Me.save_vic_pic.Text = "SAVE IMAGE"
        Me.save_vic_pic.UseVisualStyleBackColor = False
        '
        'image_preview_vic
        '
        Me.image_preview_vic.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.logo
        Me.image_preview_vic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.image_preview_vic.Location = New System.Drawing.Point(285, 2)
        Me.image_preview_vic.Name = "image_preview_vic"
        Me.image_preview_vic.Size = New System.Drawing.Size(164, 117)
        Me.image_preview_vic.TabIndex = 0
        Me.image_preview_vic.TabStop = False
        '
        'capture_vic_pic
        '
        Me.capture_vic_pic.BackColor = System.Drawing.Color.SteelBlue
        Me.capture_vic_pic.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capture_vic_pic.Location = New System.Drawing.Point(193, 47)
        Me.capture_vic_pic.Name = "capture_vic_pic"
        Me.capture_vic_pic.Size = New System.Drawing.Size(66, 30)
        Me.capture_vic_pic.TabIndex = 19
        Me.capture_vic_pic.Text = "CAPTURE"
        Me.capture_vic_pic.UseVisualStyleBackColor = False
        '
        'lbl
        '
        Me.lbl.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(6, 139)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(200, 20)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Victim's First Name:"
        '
        'start_vic_cam
        '
        Me.start_vic_cam.BackColor = System.Drawing.Color.SteelBlue
        Me.start_vic_cam.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_vic_cam.Location = New System.Drawing.Point(193, 2)
        Me.start_vic_cam.Name = "start_vic_cam"
        Me.start_vic_cam.Size = New System.Drawing.Size(71, 42)
        Me.start_vic_cam.TabIndex = 18
        Me.start_vic_cam.Text = "START"
        Me.start_vic_cam.UseVisualStyleBackColor = False
        '
        'Tb_EmpFname
        '
        Me.Tb_EmpFname.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_EmpFname.Location = New System.Drawing.Point(263, 140)
        Me.Tb_EmpFname.Multiline = True
        Me.Tb_EmpFname.Name = "Tb_EmpFname"
        Me.Tb_EmpFname.Size = New System.Drawing.Size(183, 20)
        Me.Tb_EmpFname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Victim's Last Name:"
        '
        'Tb_EmpLName
        '
        Me.Tb_EmpLName.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_EmpLName.Location = New System.Drawing.Point(263, 161)
        Me.Tb_EmpLName.Multiline = True
        Me.Tb_EmpLName.Name = "Tb_EmpLName"
        Me.Tb_EmpLName.Size = New System.Drawing.Size(183, 19)
        Me.Tb_EmpLName.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.Button4.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(9, 348)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 30)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Victim's Date Of Birth:"
        '
        'Tb_Emp_Dob
        '
        Me.Tb_Emp_Dob.Cursor = System.Windows.Forms.Cursors.No
        Me.Tb_Emp_Dob.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_Emp_Dob.Location = New System.Drawing.Point(263, 182)
        Me.Tb_Emp_Dob.Multiline = True
        Me.Tb_Emp_Dob.Name = "Tb_Emp_Dob"
        Me.Tb_Emp_Dob.Size = New System.Drawing.Size(183, 20)
        Me.Tb_Emp_Dob.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Victim's Age"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Victim's Sex"
        '
        'Tb_vic_status
        '
        Me.Tb_vic_status.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_vic_status.Location = New System.Drawing.Point(263, 308)
        Me.Tb_vic_status.Multiline = True
        Me.Tb_vic_status.Name = "Tb_vic_status"
        Me.Tb_vic_status.Size = New System.Drawing.Size(183, 20)
        Me.Tb_vic_status.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Victim's Cell:"
        '
        'lbl_usname
        '
        Me.lbl_usname.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_usname.Location = New System.Drawing.Point(264, 288)
        Me.lbl_usname.Name = "lbl_usname"
        Me.lbl_usname.Size = New System.Drawing.Size(155, 20)
        Me.lbl_usname.TabIndex = 11
        Me.lbl_usname.Text = "auto generated"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Victim's ID:"
        '
        'lbl_emp_id
        '
        Me.lbl_emp_id.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_emp_id.Location = New System.Drawing.Point(263, 121)
        Me.lbl_emp_id.Name = "lbl_emp_id"
        Me.lbl_emp_id.Size = New System.Drawing.Size(152, 20)
        Me.lbl_emp_id.TabIndex = 10
        Me.lbl_emp_id.Text = "auto generated"
        '
        'Delete_btn
        '
        Me.Delete_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Delete_btn.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_btn.Location = New System.Drawing.Point(263, 348)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(108, 30)
        Me.Delete_btn.TabIndex = 25
        Me.Delete_btn.Text = "DELETE"
        Me.Delete_btn.UseVisualStyleBackColor = False
        '
        'Employee_Details_Grid
        '
        Me.Employee_Details_Grid.AllowUserToOrderColumns = True
        Me.Employee_Details_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Employee_Details_Grid.Location = New System.Drawing.Point(464, 19)
        Me.Employee_Details_Grid.Name = "Employee_Details_Grid"
        Me.Employee_Details_Grid.Size = New System.Drawing.Size(555, 372)
        Me.Employee_Details_Grid.TabIndex = 0
        '
        'victim_strip
        '
        Me.victim_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.add_vic, Me.update_vic, Me.delete_vic, Me.view_vic, Me.search_vic})
        Me.victim_strip.Name = "strip_donor"
        Me.victim_strip.Size = New System.Drawing.Size(196, 114)
        '
        'add_vic
        '
        Me.add_vic.Name = "add_vic"
        Me.add_vic.Size = New System.Drawing.Size(195, 22)
        Me.add_vic.Text = "Add Victim"
        '
        'update_vic
        '
        Me.update_vic.Name = "update_vic"
        Me.update_vic.Size = New System.Drawing.Size(195, 22)
        Me.update_vic.Text = "Update Victim's Details"
        '
        'delete_vic
        '
        Me.delete_vic.Name = "delete_vic"
        Me.delete_vic.Size = New System.Drawing.Size(195, 22)
        Me.delete_vic.Text = "Delete Victim"
        '
        'view_vic
        '
        Me.view_vic.Name = "view_vic"
        Me.view_vic.Size = New System.Drawing.Size(195, 22)
        Me.view_vic.Text = "View Victim"
        '
        'search_vic
        '
        Me.search_vic.Name = "search_vic"
        Me.search_vic.Size = New System.Drawing.Size(195, 22)
        Me.search_vic.Text = "Search Victim"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.slid_show
        Me.PictureBox2.Location = New System.Drawing.Point(310, 359)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1020, 346)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'manager_victim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1348, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.employee_btn)
        Me.Controls.Add(Me.donor_btn)
        Me.Controls.Add(Me.vic_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "manager_victim"
        Me.Text = "manager_victim"
        Me.strip_donor.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.vic_camera_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image_preview_vic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_Details_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.victim_strip.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents strip_donor As ContextMenuStrip
    Friend WithEvents AddDonorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateDonorAmountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAmountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewDonationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchDonationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents employee_btn As Button
    Friend WithEvents donor_btn As Button
    Friend WithEvents vic_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents check_update As Label
    Friend WithEvents Tb_Emp_Id As TextBox
    Friend WithEvents Stop_Btn As Button
    Friend WithEvents clr_emp_btn As Button
    Friend WithEvents vic_camera_view As PictureBox
    Friend WithEvents save_vic_pic As Button
    Friend WithEvents image_preview_vic As PictureBox
    Friend WithEvents capture_vic_pic As Button
    Friend WithEvents lbl As Label
    Friend WithEvents start_vic_cam As Button
    Friend WithEvents Tb_EmpFname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_EmpLName As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Emp_Dob As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tb_vic_status As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_usname As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_emp_id As Label
    Friend WithEvents Delete_btn As Button
    Friend WithEvents Employee_Details_Grid As DataGridView
    Friend WithEvents Tb_emp_cell As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Tb_Vic_Sex As TextBox
    Friend WithEvents Tb_Area_code As TextBox
    Friend WithEvents victim_strip As ContextMenuStrip
    Friend WithEvents add_vic As ToolStripMenuItem
    Friend WithEvents update_vic As ToolStripMenuItem
    Friend WithEvents delete_vic As ToolStripMenuItem
    Friend WithEvents view_vic As ToolStripMenuItem
    Friend WithEvents search_vic As ToolStripMenuItem
    Friend WithEvents tb_vic_address As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_vic_age As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
