<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSale))
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboCustomerEmail = New System.Windows.Forms.ComboBox()
        Me.cboMobile = New System.Windows.Forms.ComboBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.panelMenu.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Location = New System.Drawing.Point(119, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1408, 16)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(154, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mobile Shop Management"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(736, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 621)
        Me.Panel2.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(754, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(757, 616)
        Me.DataGridView1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Customer: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(205, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Mobile: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 29)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quantity: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(175, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Unit Price: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(224, 359)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total: "
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Green
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(168, 541)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(504, 43)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Blue
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(168, 472)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(504, 43)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'cboCustomerEmail
        '
        Me.cboCustomerEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomerEmail.FormattingEnabled = True
        Me.cboCustomerEmail.Location = New System.Drawing.Point(310, 74)
        Me.cboCustomerEmail.Name = "cboCustomerEmail"
        Me.cboCustomerEmail.Size = New System.Drawing.Size(297, 37)
        Me.cboCustomerEmail.TabIndex = 20
        '
        'cboMobile
        '
        Me.cboMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMobile.FormattingEnabled = True
        Me.cboMobile.Location = New System.Drawing.Point(310, 139)
        Me.cboMobile.Name = "cboMobile"
        Me.cboMobile.Size = New System.Drawing.Size(297, 37)
        Me.cboMobile.TabIndex = 21
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(310, 210)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(297, 34)
        Me.txtQuantity.TabIndex = 22
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Enabled = False
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(310, 288)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(297, 34)
        Me.txtUnitPrice.TabIndex = 23
        Me.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(310, 354)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(297, 34)
        Me.txtTotal.TabIndex = 24
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1532, 695)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.cboMobile)
        Me.Controls.Add(Me.cboCustomerEmail)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSale"
        Me.panelMenu.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cboCustomerEmail As ComboBox
    Friend WithEvents cboMobile As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
