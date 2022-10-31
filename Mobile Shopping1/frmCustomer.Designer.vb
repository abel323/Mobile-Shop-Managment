<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnBrand = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.btnMobile = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtMName = New System.Windows.Forms.TextBox()
        Me.txtPNumber = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtDOR = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.panelMenu.SuspendLayout()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.panelMenu.TabIndex = 2
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(112, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1336, 16)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mobile Shop Management"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(712, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 621)
        Me.Panel2.TabIndex = 6
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(235, 91)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(143, 29)
        Me.lblFName.TabIndex = 7
        Me.lblFName.Text = "First Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(238, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Last Name: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Middle Name: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Date Of Registration: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Phone Number: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(292, 406)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Email: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(154, 465)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(224, 29)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Customer Address: "
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(532, 606)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 43)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Green
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(351, 606)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 43)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(178, 606)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 43)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(396, 86)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(297, 34)
        Me.txtFName.TabIndex = 23
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(396, 148)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(297, 34)
        Me.txtLName.TabIndex = 24
        '
        'txtMName
        '
        Me.txtMName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMName.Location = New System.Drawing.Point(396, 210)
        Me.txtMName.Name = "txtMName"
        Me.txtMName.Size = New System.Drawing.Size(297, 34)
        Me.txtMName.TabIndex = 25
        '
        'txtPNumber
        '
        Me.txtPNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNumber.Location = New System.Drawing.Point(396, 341)
        Me.txtPNumber.Name = "txtPNumber"
        Me.txtPNumber.Size = New System.Drawing.Size(297, 34)
        Me.txtPNumber.TabIndex = 26
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(396, 401)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(297, 34)
        Me.txtEmail.TabIndex = 27
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(396, 462)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(297, 114)
        Me.txtAddress.TabIndex = 28
        '
        'txtDOR
        '
        Me.txtDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOR.Location = New System.Drawing.Point(396, 274)
        Me.txtDOR.Name = "txtDOR"
        Me.txtDOR.Size = New System.Drawing.Size(297, 34)
        Me.txtDOR.TabIndex = 29
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(800, 9)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 30
        Me.txtID.Visible = False
        '
        'dgvCustomer
        '
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Location = New System.Drawing.Point(730, 65)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.RowHeadersWidth = 51
        Me.dgvCustomer.RowTemplate.Height = 24
        Me.dgvCustomer.Size = New System.Drawing.Size(718, 618)
        Me.dgvCustomer.TabIndex = 31
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1461, 695)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtDOR)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPNumber)
        Me.Controls.Add(Me.txtMName)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCustomer"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblFName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtMName As TextBox
    Friend WithEvents txtPNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtDOR As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents dgvCustomer As DataGridView
End Class
