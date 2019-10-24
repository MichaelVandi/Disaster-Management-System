<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manager_panel
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manager_panel))
        Me.employee_btn = New System.Windows.Forms.Button()
        Me.donor_btn = New System.Windows.Forms.Button()
        Me.Victim_btn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Strip_Employee = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateEmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.strip_donor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDonorAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDonationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchDonationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.check_update = New System.Windows.Forms.Label()
        Me.Tb_Emp_Id = New System.Windows.Forms.TextBox()
        Me.save_emp_pic = New System.Windows.Forms.Button()
        Me.Stop_Btn = New System.Windows.Forms.Button()
        Me.clr_emp_btn = New System.Windows.Forms.Button()
        Me.emp_camera_view = New System.Windows.Forms.PictureBox()
        Me.image_preview = New System.Windows.Forms.PictureBox()
        Me.capture_emp_pic = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.start_emp_cam = New System.Windows.Forms.Button()
        Me.Tb_EmpFname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_EmpLName = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tb_Emp_Add = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_Emp_Cell = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tb_Emp_psword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_usname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_emp_id = New System.Windows.Forms.Label()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.Employee_Details_Grid = New System.Windows.Forms.DataGridView()
        Me.open_slide = New System.Windows.Forms.Button()
        Me.slide = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.animation1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.victim_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Asset_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Area_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.close_slide = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog = New System.Windows.Forms.PrintDialog()
        Me.Strip_Employee.SuspendLayout()
        Me.strip_donor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.emp_camera_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_Details_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.slide.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.victim_strip.SuspendLayout()
        Me.Asset_strip.SuspendLayout()
        Me.Area_strip.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'employee_btn
        '
        Me.animation1.SetDecoration(Me.employee_btn, BunifuAnimatorNS.DecorationType.None)
        Me.employee_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.employee_btn.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.employee_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.employee_btn.Location = New System.Drawing.Point(50, 332)
        Me.employee_btn.Name = "employee_btn"
        Me.employee_btn.Size = New System.Drawing.Size(221, 39)
        Me.employee_btn.TabIndex = 1
        Me.employee_btn.Text = "EMPLOYEE"
        Me.employee_btn.UseVisualStyleBackColor = True
        '
        'donor_btn
        '
        Me.animation1.SetDecoration(Me.donor_btn, BunifuAnimatorNS.DecorationType.None)
        Me.donor_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.donor_btn.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.donor_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.donor_btn.Location = New System.Drawing.Point(50, 377)
        Me.donor_btn.Name = "donor_btn"
        Me.donor_btn.Size = New System.Drawing.Size(221, 36)
        Me.donor_btn.TabIndex = 2
        Me.donor_btn.Text = "DONOR"
        Me.donor_btn.UseVisualStyleBackColor = True
        '
        'Victim_btn
        '
        Me.animation1.SetDecoration(Me.Victim_btn, BunifuAnimatorNS.DecorationType.None)
        Me.Victim_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Victim_btn.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.Victim_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Victim_btn.Location = New System.Drawing.Point(50, 421)
        Me.Victim_btn.Name = "Victim_btn"
        Me.Victim_btn.Size = New System.Drawing.Size(221, 37)
        Me.Victim_btn.TabIndex = 3
        Me.Victim_btn.Text = "VICTIM"
        Me.Victim_btn.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.animation1.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(50, 466)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(221, 37)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "ASSET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Strip_Employee
        '
        Me.animation1.SetDecoration(Me.Strip_Employee, BunifuAnimatorNS.DecorationType.None)
        Me.Strip_Employee.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem, Me.UpdateEmployeeDetailsToolStripMenuItem, Me.RemoveEmployeeToolStripMenuItem, Me.ViewEmployeeToolStripMenuItem, Me.SearchEmployeeToolStripMenuItem})
        Me.Strip_Employee.Name = "ContextMenuStrip1"
        Me.Strip_Employee.Size = New System.Drawing.Size(206, 114)
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'UpdateEmployeeDetailsToolStripMenuItem
        '
        Me.UpdateEmployeeDetailsToolStripMenuItem.Name = "UpdateEmployeeDetailsToolStripMenuItem"
        Me.UpdateEmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.UpdateEmployeeDetailsToolStripMenuItem.Text = "Update Employee Details"
        '
        'RemoveEmployeeToolStripMenuItem
        '
        Me.RemoveEmployeeToolStripMenuItem.Name = "RemoveEmployeeToolStripMenuItem"
        Me.RemoveEmployeeToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.RemoveEmployeeToolStripMenuItem.Text = "Remove Employee"
        '
        'ViewEmployeeToolStripMenuItem
        '
        Me.ViewEmployeeToolStripMenuItem.Name = "ViewEmployeeToolStripMenuItem"
        Me.ViewEmployeeToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ViewEmployeeToolStripMenuItem.Text = "View Employee"
        '
        'SearchEmployeeToolStripMenuItem
        '
        Me.SearchEmployeeToolStripMenuItem.Name = "SearchEmployeeToolStripMenuItem"
        Me.SearchEmployeeToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SearchEmployeeToolStripMenuItem.Text = "Search Employee"
        '
        'strip_donor
        '
        Me.animation1.SetDecoration(Me.strip_donor, BunifuAnimatorNS.DecorationType.None)
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
        'Button1
        '
        Me.animation1.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(50, 514)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "AREA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Employee_Details_Grid)
        Me.animation1.SetDecoration(Me.GroupBox1, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox1.Location = New System.Drawing.Point(312, 353)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 355)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.check_update)
        Me.GroupBox2.Controls.Add(Me.Tb_Emp_Id)
        Me.GroupBox2.Controls.Add(Me.save_emp_pic)
        Me.GroupBox2.Controls.Add(Me.Stop_Btn)
        Me.GroupBox2.Controls.Add(Me.clr_emp_btn)
        Me.GroupBox2.Controls.Add(Me.emp_camera_view)
        Me.GroupBox2.Controls.Add(Me.image_preview)
        Me.GroupBox2.Controls.Add(Me.capture_emp_pic)
        Me.GroupBox2.Controls.Add(Me.lbl)
        Me.GroupBox2.Controls.Add(Me.start_emp_cam)
        Me.GroupBox2.Controls.Add(Me.Tb_EmpFname)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Tb_EmpLName)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Tb_Emp_Add)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Tb_Emp_Cell)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Tb_Emp_psword)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl_usname)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_emp_id)
        Me.GroupBox2.Controls.Add(Me.Delete_btn)
        Me.animation1.SetDecoration(Me.GroupBox2, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 330)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'check_update
        '
        Me.animation1.SetDecoration(Me.check_update, BunifuAnimatorNS.DecorationType.None)
        Me.check_update.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.check_update.Location = New System.Drawing.Point(377, 304)
        Me.check_update.Name = "check_update"
        Me.check_update.Size = New System.Drawing.Size(69, 20)
        Me.check_update.TabIndex = 24
        Me.check_update.Text = "save"
        '
        'Tb_Emp_Id
        '
        Me.animation1.SetDecoration(Me.Tb_Emp_Id, BunifuAnimatorNS.DecorationType.None)
        Me.Tb_Emp_Id.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_Emp_Id.Location = New System.Drawing.Point(263, 133)
        Me.Tb_Emp_Id.Multiline = True
        Me.Tb_Emp_Id.Name = "Tb_Emp_Id"
        Me.Tb_Emp_Id.Size = New System.Drawing.Size(185, 20)
        Me.Tb_Emp_Id.TabIndex = 23
        '
        'save_emp_pic
        '
        Me.save_emp_pic.BackColor = System.Drawing.Color.SteelBlue
        Me.animation1.SetDecoration(Me.save_emp_pic, BunifuAnimatorNS.DecorationType.None)
        Me.save_emp_pic.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_emp_pic.Location = New System.Drawing.Point(193, 86)
        Me.save_emp_pic.Name = "save_emp_pic"
        Me.save_emp_pic.Size = New System.Drawing.Size(66, 46)
        Me.save_emp_pic.TabIndex = 20
        Me.save_emp_pic.Text = "SAVE IMAGE"
        Me.save_emp_pic.UseVisualStyleBackColor = False
        '
        'Stop_Btn
        '
        Me.Stop_Btn.BackColor = System.Drawing.Color.SteelBlue
        Me.animation1.SetDecoration(Me.Stop_Btn, BunifuAnimatorNS.DecorationType.None)
        Me.Stop_Btn.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stop_Btn.Location = New System.Drawing.Point(188, 299)
        Me.Stop_Btn.Name = "Stop_Btn"
        Me.Stop_Btn.Size = New System.Drawing.Size(71, 30)
        Me.Stop_Btn.TabIndex = 22
        Me.Stop_Btn.Text = "STOP"
        Me.Stop_Btn.UseVisualStyleBackColor = False
        '
        'clr_emp_btn
        '
        Me.clr_emp_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.animation1.SetDecoration(Me.clr_emp_btn, BunifuAnimatorNS.DecorationType.None)
        Me.clr_emp_btn.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr_emp_btn.Location = New System.Drawing.Point(92, 299)
        Me.clr_emp_btn.Name = "clr_emp_btn"
        Me.clr_emp_btn.Size = New System.Drawing.Size(90, 30)
        Me.clr_emp_btn.TabIndex = 21
        Me.clr_emp_btn.Text = "CLEAR"
        Me.clr_emp_btn.UseVisualStyleBackColor = False
        '
        'emp_camera_view
        '
        Me.emp_camera_view.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.logo
        Me.emp_camera_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.animation1.SetDecoration(Me.emp_camera_view, BunifuAnimatorNS.DecorationType.None)
        Me.emp_camera_view.Location = New System.Drawing.Point(6, 2)
        Me.emp_camera_view.Name = "emp_camera_view"
        Me.emp_camera_view.Size = New System.Drawing.Size(181, 128)
        Me.emp_camera_view.TabIndex = 17
        Me.emp_camera_view.TabStop = False
        '
        'image_preview
        '
        Me.image_preview.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.logo
        Me.image_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.animation1.SetDecoration(Me.image_preview, BunifuAnimatorNS.DecorationType.None)
        Me.image_preview.Location = New System.Drawing.Point(265, 2)
        Me.image_preview.Name = "image_preview"
        Me.image_preview.Size = New System.Drawing.Size(181, 128)
        Me.image_preview.TabIndex = 0
        Me.image_preview.TabStop = False
        '
        'capture_emp_pic
        '
        Me.capture_emp_pic.BackColor = System.Drawing.Color.SteelBlue
        Me.animation1.SetDecoration(Me.capture_emp_pic, BunifuAnimatorNS.DecorationType.None)
        Me.capture_emp_pic.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capture_emp_pic.Location = New System.Drawing.Point(193, 50)
        Me.capture_emp_pic.Name = "capture_emp_pic"
        Me.capture_emp_pic.Size = New System.Drawing.Size(66, 30)
        Me.capture_emp_pic.TabIndex = 19
        Me.capture_emp_pic.Text = "CAPTURE"
        Me.capture_emp_pic.UseVisualStyleBackColor = False
        '
        'lbl
        '
        Me.animation1.SetDecoration(Me.lbl, BunifuAnimatorNS.DecorationType.None)
        Me.lbl.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(6, 155)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(200, 20)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Employee's First Name:"
        '
        'start_emp_cam
        '
        Me.start_emp_cam.BackColor = System.Drawing.Color.SteelBlue
        Me.animation1.SetDecoration(Me.start_emp_cam, BunifuAnimatorNS.DecorationType.None)
        Me.start_emp_cam.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_emp_cam.Location = New System.Drawing.Point(193, 2)
        Me.start_emp_cam.Name = "start_emp_cam"
        Me.start_emp_cam.Size = New System.Drawing.Size(66, 42)
        Me.start_emp_cam.TabIndex = 18
        Me.start_emp_cam.Text = "START"
        Me.start_emp_cam.UseVisualStyleBackColor = False
        '
        'Tb_EmpFname
        '
        Me.animation1.SetDecoration(Me.Tb_EmpFname, BunifuAnimatorNS.DecorationType.None)
        Me.Tb_EmpFname.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_EmpFname.Location = New System.Drawing.Point(263, 155)
        Me.Tb_EmpFname.Multiline = True
        Me.Tb_EmpFname.Name = "Tb_EmpFname"
        Me.Tb_EmpFname.Size = New System.Drawing.Size(183, 20)
        Me.Tb_EmpFname.TabIndex = 2
        '
        'Label1
        '
        Me.animation1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Employee's Last Name:"
        '
        'Tb_EmpLName
        '
        Me.animation1.SetDecoration(Me.Tb_EmpLName, BunifuAnimatorNS.DecorationType.None)
        Me.Tb_EmpLName.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_EmpLName.Location = New System.Drawing.Point(263, 181)
        Me.Tb_EmpLName.Multiline = True
        Me.Tb_EmpLName.Name = "Tb_EmpLName"
        Me.Tb_EmpLName.Size = New System.Drawing.Size(183, 20)
        Me.Tb_EmpLName.TabIndex = 4
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
        Me.animation1.SetDecoration(Me.Button4, BunifuAnimatorNS.DecorationType.None)
        Me.Button4.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(9, 299)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 30)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.animation1.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Employee's Address:"
        '
        'Tb_Emp_Add
        '
        Me.Tb_Emp_Add.Cursor = System.Windows.Forms.Cursors.No
        Me.animation1.SetDecoration(Me.Tb_Emp_Add, BunifuAnimatorNS.DecorationType.None)
        Me.Tb_Emp_Add.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_Emp_Add.Location = New System.Drawing.Point(263, 207)
        Me.Tb_Emp_Add.Multiline = True
        Me.Tb_Emp_Add.Name = "Tb_Emp_Add"
        Me.Tb_Emp_Add.Size = New System.Drawing.Size(183, 20)
        Me.Tb_Emp_Add.TabIndex = 14
        '
        'Label3
        '
        Me.animation1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Employee's Cell Number:"
        '
        'Tb_Emp_Cell
        '
        Me.animation1.SetDecoration(Me.Tb_Emp_Cell, BunifuAnimatorNS.DecorationType.None)
        Me.Tb_Emp_Cell.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_Emp_Cell.Location = New System.Drawing.Point(263, 231)
        Me.Tb_Emp_Cell.Multiline = True
        Me.Tb_Emp_Cell.Name = "Tb_Emp_Cell"
        Me.Tb_Emp_Cell.Size = New System.Drawing.Size(183, 20)
        Me.Tb_Emp_Cell.TabIndex = 13
        '
        'Label4
        '
        Me.animation1.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 255)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Employee's Username:"
        '
        'Tb_Emp_psword
        '
        Me.animation1.SetDecoration(Me.Tb_Emp_psword, BunifuAnimatorNS.DecorationType.None)
        Me.Tb_Emp_psword.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_Emp_psword.Location = New System.Drawing.Point(263, 276)
        Me.Tb_Emp_psword.Multiline = True
        Me.Tb_Emp_psword.Name = "Tb_Emp_psword"
        Me.Tb_Emp_psword.Size = New System.Drawing.Size(183, 20)
        Me.Tb_Emp_psword.TabIndex = 12
        '
        'Label5
        '
        Me.animation1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Employee's Password:"
        '
        'lbl_usname
        '
        Me.animation1.SetDecoration(Me.lbl_usname, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_usname.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_usname.Location = New System.Drawing.Point(260, 260)
        Me.lbl_usname.Name = "lbl_usname"
        Me.lbl_usname.Size = New System.Drawing.Size(155, 20)
        Me.lbl_usname.TabIndex = 11
        Me.lbl_usname.Text = "auto generated"
        '
        'Label6
        '
        Me.animation1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Employee's ID:"
        '
        'lbl_emp_id
        '
        Me.animation1.SetDecoration(Me.lbl_emp_id, BunifuAnimatorNS.DecorationType.None)
        Me.lbl_emp_id.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_emp_id.Location = New System.Drawing.Point(263, 132)
        Me.lbl_emp_id.Name = "lbl_emp_id"
        Me.lbl_emp_id.Size = New System.Drawing.Size(152, 20)
        Me.lbl_emp_id.TabIndex = 10
        Me.lbl_emp_id.Text = "auto generated"
        '
        'Delete_btn
        '
        Me.Delete_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.animation1.SetDecoration(Me.Delete_btn, BunifuAnimatorNS.DecorationType.None)
        Me.Delete_btn.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_btn.Location = New System.Drawing.Point(263, 299)
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
        Me.animation1.SetDecoration(Me.Employee_Details_Grid, BunifuAnimatorNS.DecorationType.None)
        Me.Employee_Details_Grid.Location = New System.Drawing.Point(464, 19)
        Me.Employee_Details_Grid.Name = "Employee_Details_Grid"
        Me.Employee_Details_Grid.Size = New System.Drawing.Size(555, 324)
        Me.Employee_Details_Grid.TabIndex = 0
        '
        'open_slide
        '
        Me.open_slide.BackColor = System.Drawing.Color.Transparent
        Me.open_slide.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Untitled
        Me.open_slide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.animation1.SetDecoration(Me.open_slide, BunifuAnimatorNS.DecorationType.None)
        Me.open_slide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.open_slide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.open_slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.open_slide.Location = New System.Drawing.Point(22, 23)
        Me.open_slide.Name = "open_slide"
        Me.open_slide.Size = New System.Drawing.Size(34, 30)
        Me.open_slide.TabIndex = 8
        Me.open_slide.UseVisualStyleBackColor = False
        '
        'slide
        '
        Me.slide.Controls.Add(Me.Label7)
        Me.slide.Controls.Add(Me.BunifuFlatButton4)
        Me.slide.Controls.Add(Me.BunifuFlatButton3)
        Me.slide.Controls.Add(Me.BunifuFlatButton2)
        Me.slide.Controls.Add(Me.PictureBox1)
        Me.animation1.SetDecoration(Me.slide, BunifuAnimatorNS.DecorationType.None)
        Me.slide.Location = New System.Drawing.Point(22, 23)
        Me.slide.Name = "slide"
        Me.slide.Size = New System.Drawing.Size(284, 716)
        Me.slide.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.animation1.SetDecoration(Me.Label7, BunifuAnimatorNS.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 27)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Present Date"
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "Print"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animation1.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 90.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(3, 372)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(277, 48)
        Me.BunifuFlatButton4.TabIndex = 30
        Me.BunifuFlatButton4.Text = "Print"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Help"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animation1.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(3, 300)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(277, 48)
        Me.BunifuFlatButton3.TabIndex = 29
        Me.BunifuFlatButton3.Text = "Help"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Exit"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animation1.SetDecoration(Me.BunifuFlatButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(3, 227)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(277, 48)
        Me.BunifuFlatButton2.TabIndex = 28
        Me.BunifuFlatButton2.Text = "Exit"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.animation1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 183)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'animation1
        '
        Me.animation1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.animation1.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.animation1.DefaultAnimation = Animation2
        '
        'victim_strip
        '
        Me.animation1.SetDecoration(Me.victim_strip, BunifuAnimatorNS.DecorationType.None)
        Me.victim_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.victim_strip.Name = "strip_donor"
        Me.victim_strip.Size = New System.Drawing.Size(196, 114)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem1.Text = "Add Victim"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem2.Text = "Update Victim's Details"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem3.Text = "Delete Victim"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem4.Text = "View Victim"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem5.Text = "Search Victim"
        '
        'Asset_strip
        '
        Me.animation1.SetDecoration(Me.Asset_strip, BunifuAnimatorNS.DecorationType.None)
        Me.Asset_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.Asset_strip.Name = "strip_donor"
        Me.Asset_strip.Size = New System.Drawing.Size(146, 114)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(145, 22)
        Me.ToolStripMenuItem6.Text = "Add Asset"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(145, 22)
        Me.ToolStripMenuItem7.Text = "Update Asset"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(145, 22)
        Me.ToolStripMenuItem8.Text = "Delete Asset"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(145, 22)
        Me.ToolStripMenuItem9.Text = "View Assets"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(145, 22)
        Me.ToolStripMenuItem10.Text = "Search Assets"
        '
        'Area_strip
        '
        Me.animation1.SetDecoration(Me.Area_strip, BunifuAnimatorNS.DecorationType.None)
        Me.Area_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem11, Me.ToolStripMenuItem12, Me.ToolStripMenuItem13, Me.ToolStripMenuItem14, Me.ToolStripMenuItem15})
        Me.Area_strip.Name = "strip_donor"
        Me.Area_strip.Size = New System.Drawing.Size(196, 114)
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem11.Text = "Add Donor"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem12.Text = "Update Donor Amount"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem13.Text = "Delete Amount"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem14.Text = "View Donations"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem15.Text = "Search Donations"
        '
        'close_slide
        '
        Me.close_slide.BackColor = System.Drawing.Color.Transparent
        Me.close_slide.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.Untitled
        Me.close_slide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.animation1.SetDecoration(Me.close_slide, BunifuAnimatorNS.DecorationType.None)
        Me.close_slide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.close_slide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.close_slide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close_slide.Location = New System.Drawing.Point(304, 23)
        Me.close_slide.Name = "close_slide"
        Me.close_slide.Size = New System.Drawing.Size(38, 30)
        Me.close_slide.TabIndex = 10
        Me.close_slide.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.animation1.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.slid_show
        Me.PictureBox2.Location = New System.Drawing.Point(312, 353)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(972, 355)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PrintPreviewDialog
        '
        Me.PrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.animation1.SetDecoration(Me.PrintPreviewDialog, BunifuAnimatorNS.DecorationType.None)
        Me.PrintPreviewDialog.Enabled = True
        Me.PrintPreviewDialog.Icon = CType(resources.GetObject("PrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog.Name = "PrintPreviewDialog"
        Me.PrintPreviewDialog.Visible = False
        '
        'PrintDialog
        '
        Me.PrintDialog.UseEXDialog = True
        '
        'manager_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1348, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.close_slide)
        Me.Controls.Add(Me.slide)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Victim_btn)
        Me.Controls.Add(Me.donor_btn)
        Me.Controls.Add(Me.employee_btn)
        Me.Controls.Add(Me.open_slide)
        Me.animation1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "manager_panel"
        Me.Text = "manager_panel"
        Me.Strip_Employee.ResumeLayout(False)
        Me.strip_donor.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.emp_camera_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image_preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_Details_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.slide.ResumeLayout(False)
        Me.slide.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.victim_strip.ResumeLayout(False)
        Me.Asset_strip.ResumeLayout(False)
        Me.Area_strip.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents employee_btn As Button
    Friend WithEvents donor_btn As Button
    Friend WithEvents Victim_btn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Strip_Employee As ContextMenuStrip
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateEmployeeDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents strip_donor As ContextMenuStrip
    Friend WithEvents AddDonorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateDonorAmountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAmountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewDonationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchDonationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Employee_Details_Grid As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Tb_Emp_Id As TextBox
    Friend WithEvents Stop_Btn As Button
    Friend WithEvents clr_emp_btn As Button
    Friend WithEvents emp_camera_view As PictureBox
    Friend WithEvents save_emp_pic As Button
    Friend WithEvents image_preview As PictureBox
    Friend WithEvents capture_emp_pic As Button
    Friend WithEvents lbl As Label
    Friend WithEvents start_emp_cam As Button
    Friend WithEvents Tb_EmpFname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_EmpLName As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Tb_Emp_Add As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_Emp_Cell As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Tb_Emp_psword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_usname As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_emp_id As Label
    Friend WithEvents check_update As Label
    Friend WithEvents Delete_btn As Button
    Friend WithEvents open_slide As Button
    Friend WithEvents slide As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents animation1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents victim_strip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents Asset_strip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents Area_strip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As ToolStripMenuItem
    Friend WithEvents close_slide As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog As PrintPreviewDialog
    Friend WithEvents PrintDialog As PrintDialog
End Class
