<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class manager_Donor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manager_Donor))
        Me.Employee_Details_Grid = New System.Windows.Forms.DataGridView()
        Me.check_update = New System.Windows.Forms.Label()
        Me.Tb_don_Id = New System.Windows.Forms.TextBox()
        Me.Stop_Btn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.money_check = New System.Windows.Forms.CheckBox()
        Me.Tb_don_aid = New System.Windows.Forms.TextBox()
        Me.Tb_don_country = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clr_emp_btn = New System.Windows.Forms.Button()
        Me.emp_camera_view = New System.Windows.Forms.PictureBox()
        Me.save_emp_pic = New System.Windows.Forms.Button()
        Me.image_preview = New System.Windows.Forms.PictureBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.start_emp_cam = New System.Windows.Forms.Button()
        Me.Tb_don_name = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tb_amount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_usname = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_emp_id = New System.Windows.Forms.Label()
        Me.Delete_btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SearchDonationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDonationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDonorAmountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.employee_btn = New System.Windows.Forms.Button()
        Me.AddDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.donor_btn = New System.Windows.Forms.Button()
        Me.strip_donor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.Employee_Details_Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.emp_camera_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.image_preview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.strip_donor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Employee_Details_Grid
        '
        Me.Employee_Details_Grid.AllowUserToOrderColumns = True
        Me.Employee_Details_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Employee_Details_Grid.Location = New System.Drawing.Point(464, 19)
        Me.Employee_Details_Grid.Name = "Employee_Details_Grid"
        Me.Employee_Details_Grid.Size = New System.Drawing.Size(555, 324)
        Me.Employee_Details_Grid.TabIndex = 0
        '
        'check_update
        '
        Me.check_update.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.check_update.Location = New System.Drawing.Point(377, 304)
        Me.check_update.Name = "check_update"
        Me.check_update.Size = New System.Drawing.Size(69, 20)
        Me.check_update.TabIndex = 24
        Me.check_update.Text = "save"
        '
        'Tb_don_Id
        '
        Me.Tb_don_Id.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_don_Id.Location = New System.Drawing.Point(263, 132)
        Me.Tb_don_Id.Multiline = True
        Me.Tb_don_Id.Name = "Tb_don_Id"
        Me.Tb_don_Id.Size = New System.Drawing.Size(183, 20)
        Me.Tb_don_Id.TabIndex = 23
        '
        'Stop_Btn
        '
        Me.Stop_Btn.BackColor = System.Drawing.Color.SteelBlue
        Me.Stop_Btn.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stop_Btn.Location = New System.Drawing.Point(188, 299)
        Me.Stop_Btn.Name = "Stop_Btn"
        Me.Stop_Btn.Size = New System.Drawing.Size(71, 30)
        Me.Stop_Btn.TabIndex = 22
        Me.Stop_Btn.Text = "STOP"
        Me.Stop_Btn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.money_check)
        Me.GroupBox2.Controls.Add(Me.Tb_don_aid)
        Me.GroupBox2.Controls.Add(Me.Tb_don_country)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.check_update)
        Me.GroupBox2.Controls.Add(Me.Tb_don_Id)
        Me.GroupBox2.Controls.Add(Me.Stop_Btn)
        Me.GroupBox2.Controls.Add(Me.clr_emp_btn)
        Me.GroupBox2.Controls.Add(Me.emp_camera_view)
        Me.GroupBox2.Controls.Add(Me.save_emp_pic)
        Me.GroupBox2.Controls.Add(Me.image_preview)
        Me.GroupBox2.Controls.Add(Me.lbl)
        Me.GroupBox2.Controls.Add(Me.start_emp_cam)
        Me.GroupBox2.Controls.Add(Me.Tb_don_name)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Tb_amount)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lbl_usname)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lbl_emp_id)
        Me.GroupBox2.Controls.Add(Me.Delete_btn)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 330)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'money_check
        '
        Me.money_check.AutoSize = True
        Me.money_check.Location = New System.Drawing.Point(92, 208)
        Me.money_check.Name = "money_check"
        Me.money_check.Size = New System.Drawing.Size(130, 17)
        Me.money_check.TabIndex = 30
        Me.money_check.Text = "Click if aid is monetary"
        Me.money_check.UseVisualStyleBackColor = True
        '
        'Tb_don_aid
        '
        Me.Tb_don_aid.Font = New System.Drawing.Font("Lucida Sans", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_don_aid.Location = New System.Drawing.Point(148, 229)
        Me.Tb_don_aid.Multiline = True
        Me.Tb_don_aid.Name = "Tb_don_aid"
        Me.Tb_don_aid.Size = New System.Drawing.Size(297, 45)
        Me.Tb_don_aid.TabIndex = 29
        '
        'Tb_don_country
        '
        Me.Tb_don_country.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_don_country.Location = New System.Drawing.Point(263, 180)
        Me.Tb_don_country.Multiline = True
        Me.Tb_don_country.Name = "Tb_don_country"
        Me.Tb_don_country.Size = New System.Drawing.Size(183, 20)
        Me.Tb_don_country.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 242)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Material Asset:"
        '
        'clr_emp_btn
        '
        Me.clr_emp_btn.BackColor = System.Drawing.Color.SteelBlue
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
        Me.emp_camera_view.Location = New System.Drawing.Point(6, 2)
        Me.emp_camera_view.Name = "emp_camera_view"
        Me.emp_camera_view.Size = New System.Drawing.Size(181, 128)
        Me.emp_camera_view.TabIndex = 17
        Me.emp_camera_view.TabStop = False
        '
        'save_emp_pic
        '
        Me.save_emp_pic.BackColor = System.Drawing.Color.SteelBlue
        Me.save_emp_pic.Font = New System.Drawing.Font("Lucida Handwriting", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_emp_pic.Location = New System.Drawing.Point(193, 86)
        Me.save_emp_pic.Name = "save_emp_pic"
        Me.save_emp_pic.Size = New System.Drawing.Size(66, 46)
        Me.save_emp_pic.TabIndex = 20
        Me.save_emp_pic.Text = "NEXT"
        Me.save_emp_pic.UseVisualStyleBackColor = False
        '
        'image_preview
        '
        Me.image_preview.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.logo
        Me.image_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.image_preview.Location = New System.Drawing.Point(265, 2)
        Me.image_preview.Name = "image_preview"
        Me.image_preview.Size = New System.Drawing.Size(181, 128)
        Me.image_preview.TabIndex = 0
        Me.image_preview.TabStop = False
        '
        'lbl
        '
        Me.lbl.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(6, 160)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(200, 20)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "Donor's Name:"
        '
        'start_emp_cam
        '
        Me.start_emp_cam.BackColor = System.Drawing.Color.SteelBlue
        Me.start_emp_cam.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_emp_cam.Location = New System.Drawing.Point(193, 2)
        Me.start_emp_cam.Name = "start_emp_cam"
        Me.start_emp_cam.Size = New System.Drawing.Size(66, 42)
        Me.start_emp_cam.TabIndex = 18
        Me.start_emp_cam.Text = "PREV"
        Me.start_emp_cam.UseVisualStyleBackColor = False
        '
        'Tb_don_name
        '
        Me.Tb_don_name.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_don_name.Location = New System.Drawing.Point(263, 154)
        Me.Tb_don_name.Multiline = True
        Me.Tb_don_name.Name = "Tb_don_name"
        Me.Tb_don_name.Size = New System.Drawing.Size(183, 20)
        Me.Tb_don_name.TabIndex = 2
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.SteelBlue
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
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Donor's Country:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Amount:"
        '
        'Tb_amount
        '
        Me.Tb_amount.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tb_amount.Location = New System.Drawing.Point(263, 206)
        Me.Tb_amount.Multiline = True
        Me.Tb_amount.Name = "Tb_amount"
        Me.Tb_amount.Size = New System.Drawing.Size(183, 20)
        Me.Tb_amount.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Donor Code:"
        '
        'lbl_usname
        '
        Me.lbl_usname.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_usname.Location = New System.Drawing.Point(260, 277)
        Me.lbl_usname.Name = "lbl_usname"
        Me.lbl_usname.Size = New System.Drawing.Size(155, 20)
        Me.lbl_usname.TabIndex = 11
        Me.lbl_usname.Text = "auto generated"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Donor's Id:"
        '
        'lbl_emp_id
        '
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
        Me.Delete_btn.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_btn.Location = New System.Drawing.Point(263, 299)
        Me.Delete_btn.Name = "Delete_btn"
        Me.Delete_btn.Size = New System.Drawing.Size(108, 30)
        Me.Delete_btn.TabIndex = 25
        Me.Delete_btn.Text = "DELETE"
        Me.Delete_btn.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Employee_Details_Grid)
        Me.GroupBox1.Location = New System.Drawing.Point(310, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1026, 356)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(46, 509)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 37)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "AREA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SearchDonationsToolStripMenuItem
        '
        Me.SearchDonationsToolStripMenuItem.Name = "SearchDonationsToolStripMenuItem"
        Me.SearchDonationsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.SearchDonationsToolStripMenuItem.Text = "Search Donations"
        '
        'ViewDonationsToolStripMenuItem
        '
        Me.ViewDonationsToolStripMenuItem.Name = "ViewDonationsToolStripMenuItem"
        Me.ViewDonationsToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ViewDonationsToolStripMenuItem.Text = "View Donations"
        '
        'DeleteAmountToolStripMenuItem
        '
        Me.DeleteAmountToolStripMenuItem.Name = "DeleteAmountToolStripMenuItem"
        Me.DeleteAmountToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.DeleteAmountToolStripMenuItem.Text = "Delete Amount"
        '
        'UpdateDonorAmountToolStripMenuItem
        '
        Me.UpdateDonorAmountToolStripMenuItem.Name = "UpdateDonorAmountToolStripMenuItem"
        Me.UpdateDonorAmountToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.UpdateDonorAmountToolStripMenuItem.Text = "Update Donor Amount"
        '
        'employee_btn
        '
        Me.employee_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.employee_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.employee_btn.Location = New System.Drawing.Point(46, 327)
        Me.employee_btn.Name = "employee_btn"
        Me.employee_btn.Size = New System.Drawing.Size(221, 39)
        Me.employee_btn.TabIndex = 7
        Me.employee_btn.Text = "EMPLOYEE"
        Me.employee_btn.UseVisualStyleBackColor = True
        '
        'AddDonorToolStripMenuItem
        '
        Me.AddDonorToolStripMenuItem.Name = "AddDonorToolStripMenuItem"
        Me.AddDonorToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AddDonorToolStripMenuItem.Text = "Add Donor"
        '
        'donor_btn
        '
        Me.donor_btn.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.donor_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.donor_btn.Location = New System.Drawing.Point(46, 372)
        Me.donor_btn.Name = "donor_btn"
        Me.donor_btn.Size = New System.Drawing.Size(221, 36)
        Me.donor_btn.TabIndex = 8
        Me.donor_btn.Text = "DONOR"
        Me.donor_btn.UseVisualStyleBackColor = True
        '
        'strip_donor
        '
        Me.strip_donor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDonorToolStripMenuItem, Me.UpdateDonorAmountToolStripMenuItem, Me.DeleteAmountToolStripMenuItem, Me.ViewDonationsToolStripMenuItem, Me.SearchDonationsToolStripMenuItem})
        Me.strip_donor.Name = "strip_donor"
        Me.strip_donor.Size = New System.Drawing.Size(196, 114)
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(46, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(221, 37)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "VICTIM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Lucida Handwriting", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(46, 461)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(221, 37)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "ASSET"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.Flooding_system_flash_banner22222
        Me.PictureBox1.Location = New System.Drawing.Point(24, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1312, 321)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(-23, -46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.slid_show
        Me.PictureBox3.Location = New System.Drawing.Point(309, 352)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1027, 356)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'manager_Donor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1348, 729)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.employee_btn)
        Me.Controls.Add(Me.donor_btn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Name = "manager_Donor"
        Me.Text = "Donor"
        CType(Me.Employee_Details_Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.emp_camera_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.image_preview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.strip_donor.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Employee_Details_Grid As DataGridView
    Friend WithEvents check_update As Label
    Friend WithEvents Tb_don_Id As TextBox
    Friend WithEvents Stop_Btn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents clr_emp_btn As Button
    Friend WithEvents emp_camera_view As PictureBox
    Friend WithEvents save_emp_pic As Button
    Friend WithEvents image_preview As PictureBox
    Friend WithEvents lbl As Label
    Friend WithEvents Tb_don_name As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_amount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_usname As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_emp_id As Label
    Friend WithEvents Delete_btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SearchDonationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewDonationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteAmountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateDonorAmountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents employee_btn As Button
    Friend WithEvents AddDonorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents donor_btn As Button
    Friend WithEvents strip_donor As ContextMenuStrip
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_don_country As TextBox
    Friend WithEvents Tb_don_aid As TextBox
    Friend WithEvents money_check As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents start_emp_cam As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
