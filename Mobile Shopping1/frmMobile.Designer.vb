<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMobile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMobile))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnBrand = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.btnMobile = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblMobileName = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.lblProduction = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMobileName = New System.Windows.Forms.TextBox()
        Me.txtQuanitiy = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtProductionYear = New System.Windows.Forms.DateTimePicker()
        Me.cboBrand = New System.Windows.Forms.ComboBox()
        Me.dgvMobileData = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.panelMenu.SuspendLayout()
        CType(Me.dgvMobileData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnHome)
        Me.panelMenu.Controls.Add(Me.btnBrand)
        Me.panelMenu.Controls.Add(Me.btnSell)
        Me.panelMenu.Controls.Add(Me.btnMobile)
        Me.panelMenu.Controls.Add(Me.btnCustomer)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(108, 695)
        Me.panelMenu.TabIndex = 1
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHome.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnHome.Location = New System.Drawing.Point(4, 41)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(100, 43)
        Me.btnHome.TabIndex = 6
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'btnBrand
        '
        Me.btnBrand.BackgroundImage = CType(resources.GetObject("btnBrand.BackgroundImage"), System.Drawing.Image)
        Me.btnBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBrand.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnBrand.Location = New System.Drawing.Point(4, 356)
        Me.btnBrand.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrand.Name = "btnBrand"
        Me.btnBrand.Size = New System.Drawing.Size(100, 43)
        Me.btnBrand.TabIndex = 5
        Me.btnBrand.UseVisualStyleBackColor = False
        '
        'btnSell
        '
        Me.btnSell.BackgroundImage = CType(resources.GetObject("btnSell.BackgroundImage"), System.Drawing.Image)
        Me.btnSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSell.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnSell.Location = New System.Drawing.Point(4, 279)
        Me.btnSell.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSell.Name = "btnSell"
        Me.btnSell.Size = New System.Drawing.Size(100, 43)
        Me.btnSell.TabIndex = 4
        Me.btnSell.UseVisualStyleBackColor = False
        '
        'btnMobile
        '
        Me.btnMobile.BackgroundImage = CType(resources.GetObject("btnMobile.BackgroundImage"), System.Drawing.Image)
        Me.btnMobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMobile.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnMobile.Location = New System.Drawing.Point(4, 201)
        Me.btnMobile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMobile.Name = "btnMobile"
        Me.btnMobile.Size = New System.Drawing.Size(100, 43)
        Me.btnMobile.TabIndex = 3
        Me.btnMobile.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCustomer.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnCustomer.Location = New System.Drawing.Point(4, 121)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(100, 43)
        Me.btnCustomer.TabIndex = 2
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), System.Drawing.Image)
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogout.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnLogout.Location = New System.Drawing.Point(4, 638)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 43)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(155, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mobile Shop Management"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(119, 39)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1227, 16)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(701, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 621)
        Me.Panel2.TabIndex = 4
        '
        'lblMobileName
        '
        Me.lblMobileName.AutoSize = True
        Me.lblMobileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobileName.Location = New System.Drawing.Point(158, 85)
        Me.lblMobileName.Name = "lblMobileName"
        Me.lblMobileName.Size = New System.Drawing.Size(170, 29)
        Me.lblMobileName.TabIndex = 5
        Me.lblMobileName.Text = "Mobile Name: "
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.Location = New System.Drawing.Point(239, 153)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(89, 29)
        Me.lblBrand.TabIndex = 6
        Me.lblBrand.Text = "Brand: "
        '
        'lblProduction
        '
        Me.lblProduction.AutoSize = True
        Me.lblProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduction.Location = New System.Drawing.Point(130, 227)
        Me.lblProduction.Name = "lblProduction"
        Me.lblProduction.Size = New System.Drawing.Size(198, 29)
        Me.lblProduction.TabIndex = 7
        Me.lblProduction.Text = "Production Year: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 29)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Quantity In Stock: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(199, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Unit Price: "
        '
        'txtMobileName
        '
        Me.txtMobileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileName.Location = New System.Drawing.Point(334, 80)
        Me.txtMobileName.Name = "txtMobileName"
        Me.txtMobileName.Size = New System.Drawing.Size(297, 34)
        Me.txtMobileName.TabIndex = 10
        '
        'txtQuanitiy
        '
        Me.txtQuanitiy.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuanitiy.Location = New System.Drawing.Point(334, 304)
        Me.txtQuanitiy.Name = "txtQuanitiy"
        Me.txtQuanitiy.Size = New System.Drawing.Size(297, 34)
        Me.txtQuanitiy.TabIndex = 11
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(334, 387)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(297, 34)
        Me.txtPrice.TabIndex = 12
        '
        'txtProductionYear
        '
        Me.txtProductionYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductionYear.Location = New System.Drawing.Point(334, 222)
        Me.txtProductionYear.Name = "txtProductionYear"
        Me.txtProductionYear.Size = New System.Drawing.Size(297, 34)
        Me.txtProductionYear.TabIndex = 13
        '
        'cboBrand
        '
        Me.cboBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBrand.FormattingEnabled = True
        Me.cboBrand.Location = New System.Drawing.Point(334, 145)
        Me.cboBrand.Name = "cboBrand"
        Me.cboBrand.Size = New System.Drawing.Size(297, 37)
        Me.cboBrand.TabIndex = 14
        '
        'dgvMobileData
        '
        Me.dgvMobileData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMobileData.Location = New System.Drawing.Point(718, 62)
        Me.dgvMobileData.Name = "dgvMobileData"
        Me.dgvMobileData.RowHeadersWidth = 51
        Me.dgvMobileData.RowTemplate.Height = 24
        Me.dgvMobileData.Size = New System.Drawing.Size(629, 619)
        Me.dgvMobileData.TabIndex = 15
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(514, 480)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 43)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Green
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(333, 480)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 43)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(160, 480)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 43)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(261, 568)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 20
        Me.txtID.Visible = False
        '
        'frmMobile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1359, 695)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvMobileData)
        Me.Controls.Add(Me.cboBrand)
        Me.Controls.Add(Me.txtProductionYear)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuanitiy)
        Me.Controls.Add(Me.txtMobileName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblProduction)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.lblMobileName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMobile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.dgvMobileData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnHome As Button
    Friend WithEvents btnBrand As Button
    Friend WithEvents btnSell As Button
    Friend WithEvents btnMobile As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMobileName As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblProduction As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMobileName As TextBox
    Friend WithEvents txtQuanitiy As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtProductionYear As DateTimePicker
    Friend WithEvents cboBrand As ComboBox
    Friend WithEvents dgvMobileData As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtID As TextBox
End Class
