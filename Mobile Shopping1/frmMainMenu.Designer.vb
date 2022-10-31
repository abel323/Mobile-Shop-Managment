<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSell = New System.Windows.Forms.Button()
        Me.btnMobile = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTotalItems = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.panelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.Button2)
        Me.panelMenu.Controls.Add(Me.Button1)
        Me.panelMenu.Controls.Add(Me.btnSell)
        Me.panelMenu.Controls.Add(Me.btnMobile)
        Me.panelMenu.Controls.Add(Me.btnCustomer)
        Me.panelMenu.Controls.Add(Me.btnLogout)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(108, 695)
        Me.panelMenu.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Button2.Location = New System.Drawing.Point(4, 41)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 43)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Button1.Location = New System.Drawing.Point(4, 356)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Label1.Location = New System.Drawing.Point(152, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mobile Shop Management"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(116, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1227, 16)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lime
        Me.Panel2.Controls.Add(Me.lblCustomer)
        Me.Panel2.Location = New System.Drawing.Point(157, 79)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(261, 123)
        Me.Panel2.TabIndex = 3
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.ForeColor = System.Drawing.Color.Red
        Me.lblCustomer.Location = New System.Drawing.Point(4, 73)
        Me.lblCustomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(202, 22)
        Me.lblCustomer.TabIndex = 6
        Me.lblCustomer.Text = "Total Customers : "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Lime
        Me.Panel3.Controls.Add(Me.lblTotalItems)
        Me.Panel3.Location = New System.Drawing.Point(531, 79)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 123)
        Me.Panel3.TabIndex = 4
        '
        'lblTotalItems
        '
        Me.lblTotalItems.AutoSize = True
        Me.lblTotalItems.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItems.ForeColor = System.Drawing.Color.Red
        Me.lblTotalItems.Location = New System.Drawing.Point(4, 73)
        Me.lblTotalItems.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalItems.Name = "lblTotalItems"
        Me.lblTotalItems.Size = New System.Drawing.Size(148, 22)
        Me.lblTotalItems.TabIndex = 7
        Me.lblTotalItems.Text = "Total Items:  "
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Lime
        Me.Panel4.Controls.Add(Me.lblTotalSales)
        Me.Panel4.Location = New System.Drawing.Point(913, 79)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(264, 123)
        Me.Panel4.TabIndex = 5
        '
        'lblTotalSales
        '
        Me.lblTotalSales.AutoSize = True
        Me.lblTotalSales.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSales.ForeColor = System.Drawing.Color.Red
        Me.lblTotalSales.Location = New System.Drawing.Point(4, 73)
        Me.lblTotalSales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(152, 22)
        Me.lblTotalSales.TabIndex = 8
        Me.lblTotalSales.Text = "Total Sales:  "
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Lime
        Me.Panel5.Controls.Add(Me.lblBrand)
        Me.Panel5.Location = New System.Drawing.Point(157, 235)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(264, 123)
        Me.Panel5.TabIndex = 8
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.ForeColor = System.Drawing.Color.Red
        Me.lblBrand.Location = New System.Drawing.Point(4, 73)
        Me.lblBrand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(162, 22)
        Me.lblBrand.TabIndex = 7
        Me.lblBrand.Text = "Total Brand:   "
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1359, 695)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelMenu)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Window"
        Me.panelMenu.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSell As Button
    Friend WithEvents btnMobile As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblCustomer As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTotalItems As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
