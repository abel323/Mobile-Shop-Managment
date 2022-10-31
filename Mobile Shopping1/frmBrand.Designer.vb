<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrand))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBrand = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.btnMobile = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvBrandData = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBrandId = New System.Windows.Forms.TextBox()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.panelMenu.SuspendLayout()
        CType(Me.dgvBrandData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.Button2)
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
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Button2.Location = New System.Drawing.Point(4, 39)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 43)
        Me.Button2.TabIndex = 17
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnBrand
        '
        Me.btnBrand.BackgroundImage = CType(resources.GetObject("btnBrand.BackgroundImage"), System.Drawing.Image)
        Me.btnBrand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBrand.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnBrand.Location = New System.Drawing.Point(4, 358)
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
        Me.btnSell.Location = New System.Drawing.Point(4, 272)
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
        Me.btnMobile.Location = New System.Drawing.Point(4, 194)
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
        Me.btnCustomer.Location = New System.Drawing.Point(4, 114)
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
        Me.Label1.Location = New System.Drawing.Point(157, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Mobile Shop Management"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(116, 39)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1239, 16)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(747, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(15, 621)
        Me.Panel2.TabIndex = 8
        '
        'dgvBrandData
        '
        Me.dgvBrandData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBrandData.Location = New System.Drawing.Point(879, 62)
        Me.dgvBrandData.Name = "dgvBrandData"
        Me.dgvBrandData.RowHeadersWidth = 51
        Me.dgvBrandData.RowTemplate.Height = 24
        Me.dgvBrandData.Size = New System.Drawing.Size(353, 618)
        Me.dgvBrandData.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 29)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Brand ID: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Brand Name: "
        '
        'txtBrandId
        '
        Me.txtBrandId.Enabled = False
        Me.txtBrandId.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrandId.Location = New System.Drawing.Point(295, 94)
        Me.txtBrandId.Name = "txtBrandId"
        Me.txtBrandId.Size = New System.Drawing.Size(265, 34)
        Me.txtBrandId.TabIndex = 12
        '
        'txtBrandName
        '
        Me.txtBrandName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrandName.Location = New System.Drawing.Point(295, 203)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(265, 34)
        Me.txtBrandName.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(134, 329)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 43)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Green
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(307, 329)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(100, 43)
        Me.btnUpdate.TabIndex = 15
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(488, 329)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 43)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'frmBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1359, 695)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtBrandName)
        Me.Controls.Add(Me.txtBrandId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvBrandData)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBrand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brand"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.dgvBrandData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnBrand As Button
    Friend WithEvents btnSell As Button
    Friend WithEvents btnMobile As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvBrandData As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBrandId As TextBox
    Friend WithEvents txtBrandName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button2 As Button
End Class
