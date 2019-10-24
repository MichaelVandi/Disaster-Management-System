<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manager_area
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
        Dim Animation6 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manager_area))
        Me.check_update = New System.Windows.Forms.Label()
        Me.area_code = New System.Windows.Forms.TextBox()
        Me.animation1 = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.victim_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Area_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Add_area = New System.Windows.Forms.ToolStripMenuItem()
        Me.update_area = New System.Windows.Forms.ToolStripMenuItem()
        Me.delete_area = New System.Windows.Forms.ToolStripMenuItem()
        Me.view_area = New System.Windows.Forms.ToolStripMenuItem()
        Me.search_area = New System.Windows.Forms.ToolStripMenuItem()
        Me.clr_emp_btn = New System.Windows.Forms.Button()
        Me.image_preview = New System.Windows.Forms.PictureBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.area_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Area_Size = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Asset_strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Area_Location = New System.Windows.Forms.TextBox()
        Me.Area_Chairman = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Victim_btn = New System.Windows.Forms.Button()
        Me.donor_btn = New System.Windows.Forms.Button()
        Me.employee_btn = New System.Windows.Forms.Button()
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.emp_camera_view = New System.Windows.Forms.PictureBox()
        Me.Area_Mayor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_emp_id = New System.Windows.Forms.Label()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.Employee_Details_Grid = New System.Windows.Forms.DataGridView()
        Me.area_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.victim_strip.SuspendLayout()
        Me.Area_strip.SuspendLayout()
        CType(Me.image_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Asset_strip.SuspendLayout()
        Me.Strip_Employee.SuspendLayout()
        Me.strip_donor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.emp_camera_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_Details_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'area_code
        '
        Me.animation1.SetDecoration(Me.area_code, BunifuAnimatorNS.DecorationType.None)
        Me.area_code.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.area_code.Location = New System.Drawing.Point(263, 133)
        Me.area_code.Multiline = True
        Me.area_code.Name = "area_code"
        Me.area_code.Size = New System.Drawing.Size(185, 20)
        Me.area_code.TabIndex = 23
        '
        'animation1
        '
        Me.animation1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.animation1.Cursor = Nothing
        Animation6.AnimateOnlyDifferences = True
        Animation6.BlindCoeff = CType(resources.GetObject("Animation6.BlindCoeff"), System.Drawing.PointF)
        Animation6.LeafCoeff = 0!
        Animation6.MaxTime = 1.0!
        Animation6.MinTime = 0!
        Animation6.MosaicCoeff = CType(resources.GetObject("Animation6.MosaicCoeff"), System.Drawing.PointF)
        Animation6.MosaicShift = CType(resources.GetObject("Animation6.MosaicShift"), System.Drawing.PointF)
        Animation6.MosaicSize = 0
        Animation6.Padding = New System.Windows.Forms.Padding(0)
        Animation6.RotateCoeff = 0!
        Animation6.RotateLimit = 0!
        Animation6.ScaleCoeff = CType(resources.GetObject("Animation6.ScaleCoeff"), System.Drawing.PointF)
        Animation6.SlideCoeff = CType(resources.GetObject("Animation6.SlideCoeff"), System.Drawing.PointF)
        Animation6.TimeCoeff = 0!
        Animation6.TransparencyCoeff = 0!
        Me.animation1.DefaultAnimation = Animation6
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
        'Area_strip
        '
        Me.animation1.SetDecoration(Me.Area_strip, BunifuAnimatorNS.DecorationType.None)
        Me.Area_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add_area, Me.update_area, Me.delete_area, Me.view_area, Me.search_area})
        Me.Area_strip.Name = "strip_donor"
        Me.Area_strip.Size = New System.Drawing.Size(140, 114)
        '
        'Add_area
        '
        Me.Add_area.Name = "Add_area"
        Me.Add_area.Size = New System.Drawing.Size(139, 22)
        Me.Add_area.Text = "Add Area"
        '
        'update_area
        '
        Me.update_area.Name = "update_area"
        Me.update_area.Size = New System.Drawing.Size(139, 22)
        Me.update_area.Text = "Update Area"
        '
        'delete_area
        '
        Me.delete_area.Name = "delete_area"
        Me.delete_area.Size = New System.Drawing.Size(139, 22)
        Me.delete_area.Text = "Delete Area"
        '
        'view_area
        '
        Me.view_area.Name = "view_area"
        Me.view_area.Size = New System.Drawing.Size(139, 22)
        Me.view_area.Text = "View Area"
        '
        'search_area
        '
        Me.search_area.Name = "search_area"
        Me.search_area.Size = New System.Drawing.Size(139, 22)
        Me.search_area.Text = "Search Area"
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
        'lbl
        '
        Me.animation1.SetDecoration(Me.lbl, BunifuAnimatorNS.DecorationType.None)
        Me.lbl.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(6, 155)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(200, 20)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Area Name:"
        '
        'area_name
        '
        Me.animation1.SetDecoration(Me.area_name, BunifuAnimatorNS.DecorationType.None)
        Me.area_name.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.area_name.Location = New System.Drawing.Point(263, 156)
        Me.area_name.Multiline = True
        Me.area_name.Name = "area_name"
        Me.area_name.Size = New System.Drawing.Size(183, 20)
        Me.area_name.TabIndex = 2
        '
        'Label1
        '
        Me.animation1.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Area Location:"
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
        Me.Label2.Text = "Area Size"
        '
        'Area_Size
        '
        Me.Area_Size.Cursor = System.Windows.Forms.Cursors.No
        Me.animation1.SetDecoration(Me.Area_Size, BunifuAnimatorNS.DecorationType.None)
        Me.Area_Size.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Area_Size.Location = New System.Drawing.Point(263, 211)
        Me.Area_Size.Multiline = True
        Me.Area_Size.Name = "Area_Size"
        Me.Area_Size.Size = New System.Drawing.Size(183, 20)
        Me.Area_Size.TabIndex = 14
        '
        'Label3
        '
        Me.animation1.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Area Chairman:"
        '
        'Asset_strip
        '
        Me.animation1.SetDecoration(Me.Asset_strip, BunifuAnimatorNS.DecorationType.None)
        Me.Asset_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.Asset_strip.Name = "strip_donor"
        Me.Asset_strip.Size = New System.Drawing.Size(196, 114)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem6.Text = "Add Donor"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem7.Text = "Update Donor Amount"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem8.Text = "Delete Amount"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem9.Text = "View Donations"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(195, 22)
        Me.ToolStripMenuItem10.Text = "Search Donations"
        '
        'Area_Location
        '
        Me.animation1.SetDecoration(Me.Area_Location, BunifuAnimatorNS.DecorationType.None)
        Me.Area_Location.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Area_Location.Location = New System.Drawing.Point(263, 181)
        Me.Area_Location.Multiline = True
        Me.Area_Location.Name = "Area_Location"
        Me.Area_Location.Size = New System.Drawing.Size(183, 20)
        Me.Area_Location.TabIndex = 4
        '
        'Area_Chairman
        '
        Me.animation1.SetDecoration(Me.Area_Chairman, BunifuAnimatorNS.DecorationType.None)
        Me.Area_Chairman.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Area_Chairman.Location = New System.Drawing.Point(263, 235)
        Me.Area_Chairman.Multiline = True
        Me.Area_Chairman.Name = "Area_Chairman"
        Me.Area_Chairman.Size = New System.Drawing.Size(183, 20)
        Me.Area_Chairman.TabIndex = 13
        '
        'Button3
        '
        Me.animation1.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(50, 465)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(221, 37)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "ASSET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Victim_btn
        '
        Me.animation1.SetDecoration(Me.Victim_btn, BunifuAnimatorNS.DecorationType.None)
        Me.Victim_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Victim_btn.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.Victim_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Victim_btn.Location = New System.Drawing.Point(50, 420)
        Me.Victim_btn.Name = "Victim_btn"
        Me.Victim_btn.Size = New System.Drawing.Size(221, 37)
        Me.Victim_btn.TabIndex = 13
        Me.Victim_btn.Text = "VICTIM"
        Me.Victim_btn.UseVisualStyleBackColor = True
        '
        'donor_btn
        '
        Me.animation1.SetDecoration(Me.donor_btn, BunifuAnimatorNS.DecorationType.None)
        Me.donor_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.donor_btn.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.donor_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.donor_btn.Location = New System.Drawing.Point(50, 376)
        Me.donor_btn.Name = "donor_btn"
        Me.donor_btn.Size = New System.Drawing.Size(221, 36)
        Me.donor_btn.TabIndex = 12
        Me.donor_btn.Text = "DONOR"
        Me.donor_btn.UseVisualStyleBackColor = True
        '
        'employee_btn
        '
        Me.animation1.SetDecoration(Me.employee_btn, BunifuAnimatorNS.DecorationType.None)
        Me.employee_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.employee_btn.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.employee_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.employee_btn.Location = New System.Drawing.Point(50, 331)
        Me.employee_btn.Name = "employee_btn"
        Me.employee_btn.Size = New System.Drawing.Size(221, 39)
        Me.employee_btn.TabIndex = 11
        Me.employee_btn.Text = "EMPLOYEE"
        Me.employee_btn.UseVisualStyleBackColor = True
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Employee_Details_Grid)
        Me.animation1.SetDecoration(Me.GroupBox1, BunifuAnimatorNS.DecorationType.None)
        Me.GroupBox1.Location = New System.Drawing.Point(309, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1037, 365)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.check_update)
        Me.GroupBox2.Controls.Add(Me.area_code)
        Me.GroupBox2.Controls.Add(Me.clr_emp_btn)
        Me.GroupBox2.Controls.Add(Me.emp_camera_view)
        Me.GroupBox2.Controls.Add(Me.image_preview)
        Me.GroupBox2.Controls.Add(Me.lbl)
        Me.GroupBox2.Controls.Add(Me.area_name)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Area_Location)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Area_Size)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Area_Chairman)
        Me.GroupBox2.Controls.Add(Me.Area_Mayor)
        Me.GroupBox2.Controls.Add(Me.Label5)
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
        'Area_Mayor
        '
        Me.animation1.SetDecoration(Me.Area_Mayor, BunifuAnimatorNS.DecorationType.None)
        Me.Area_Mayor.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Area_Mayor.Location = New System.Drawing.Point(263, 259)
        Me.Area_Mayor.Multiline = True
        Me.Area_Mayor.Name = "Area_Mayor"
        Me.Area_Mayor.Size = New System.Drawing.Size(183, 20)
        Me.Area_Mayor.TabIndex = 12
        '
        'Label5
        '
        Me.animation1.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Location Mayor:"
        '
        'Label6
        '
        Me.animation1.SetDecoration(Me.Label6, BunifuAnimatorNS.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Constituency ID::"
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
        Me.Delete_btn.Location = New System.Drawing.Point(187, 299)
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
        'area_btn
        '
        Me.animation1.SetDecoration(Me.area_btn, BunifuAnimatorNS.DecorationType.None)
        Me.area_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.area_btn.Image = Global.WindowsApp1.My.Resources.Resources._2downarrow1
        Me.area_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.area_btn.Location = New System.Drawing.Point(50, 513)
        Me.area_btn.Name = "area_btn"
        Me.area_btn.Size = New System.Drawing.Size(221, 37)
        Me.area_btn.TabIndex = 15
        Me.area_btn.Text = "AREA"
        Me.area_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.animation1.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.slid_show
        Me.PictureBox1.Location = New System.Drawing.Point(309, 352)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1027, 355)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'manager_area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.empty_Frame_4_UI
        Me.ClientSize = New System.Drawing.Size(1348, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Victim_btn)
        Me.Controls.Add(Me.donor_btn)
        Me.Controls.Add(Me.employee_btn)
        Me.Controls.Add(Me.area_btn)
        Me.animation1.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Name = "manager_area"
        Me.Text = "manager_area"
        Me.victim_strip.ResumeLayout(False)
        Me.Area_strip.ResumeLayout(False)
        CType(Me.image_preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Asset_strip.ResumeLayout(False)
        Me.Strip_Employee.ResumeLayout(False)
        Me.strip_donor.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.emp_camera_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_Details_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents animation1 As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents check_update As Label
    Friend WithEvents area_code As TextBox
    Friend WithEvents victim_strip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents Area_strip As ContextMenuStrip
    Friend WithEvents Add_area As ToolStripMenuItem
    Friend WithEvents update_area As ToolStripMenuItem
    Friend WithEvents delete_area As ToolStripMenuItem
    Friend WithEvents view_area As ToolStripMenuItem
    Friend WithEvents search_area As ToolStripMenuItem
    Friend WithEvents clr_emp_btn As Button
    Friend WithEvents image_preview As PictureBox
    Friend WithEvents lbl As Label
    Friend WithEvents area_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Area_Size As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Asset_strip As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents Area_Location As TextBox
    Friend WithEvents Area_Chairman As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Victim_btn As Button
    Friend WithEvents donor_btn As Button
    Friend WithEvents employee_btn As Button
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Area_Mayor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_emp_id As Label
    Friend WithEvents Delete_btn As Button
    Friend WithEvents Employee_Details_Grid As DataGridView
    Friend WithEvents area_btn As Button
    Friend WithEvents emp_camera_view As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
