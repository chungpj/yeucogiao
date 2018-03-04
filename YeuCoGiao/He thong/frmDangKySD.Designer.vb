<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDangKySD
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDangKySD))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtTendonvi = New DevExpress.XtraEditors.TextEdit()
        Me.btnSinhcode = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCode = New DevExpress.XtraEditors.TextEdit()
        Me.btnThoat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDangky = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDenngay = New DevExpress.XtraEditors.TextEdit()
        Me.txtTungay = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciSinhcode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtTendonvi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDenngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTungay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciSinhcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtTendonvi)
        Me.LayoutControl1.Controls.Add(Me.btnSinhcode)
        Me.LayoutControl1.Controls.Add(Me.txtCode)
        Me.LayoutControl1.Controls.Add(Me.btnThoat)
        Me.LayoutControl1.Controls.Add(Me.btnDangky)
        Me.LayoutControl1.Controls.Add(Me.txtDenngay)
        Me.LayoutControl1.Controls.Add(Me.txtTungay)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(427, 146)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtTendonvi
        '
        Me.txtTendonvi.EditValue = ""
        Me.txtTendonvi.Location = New System.Drawing.Point(91, 4)
        Me.txtTendonvi.Name = "txtTendonvi"
        Me.txtTendonvi.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTendonvi.Properties.Appearance.Options.UseFont = True
        Me.txtTendonvi.Properties.AutoHeight = False
        Me.txtTendonvi.Size = New System.Drawing.Size(332, 24)
        Me.txtTendonvi.StyleController = Me.LayoutControl1
        Me.txtTendonvi.TabIndex = 10
        '
        'btnSinhcode
        '
        Me.btnSinhcode.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinhcode.Appearance.Options.UseFont = True
        Me.btnSinhcode.Image = CType(resources.GetObject("btnSinhcode.Image"), System.Drawing.Image)
        Me.btnSinhcode.Location = New System.Drawing.Point(67, 116)
        Me.btnSinhcode.Name = "btnSinhcode"
        Me.btnSinhcode.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSinhcode.Size = New System.Drawing.Size(111, 22)
        Me.btnSinhcode.StyleController = Me.LayoutControl1
        Me.btnSinhcode.TabIndex = 9
        Me.btnSinhcode.Text = "Sinh code"
        '
        'txtCode
        '
        Me.txtCode.EnterMoveNextControl = True
        Me.txtCode.Location = New System.Drawing.Point(91, 88)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txtCode.Properties.Appearance.Options.UseFont = True
        Me.txtCode.Properties.Appearance.Options.UseForeColor = True
        Me.txtCode.Properties.AutoHeight = False
        Me.txtCode.Size = New System.Drawing.Size(332, 24)
        Me.txtCode.StyleController = Me.LayoutControl1
        Me.txtCode.TabIndex = 8
        '
        'btnThoat
        '
        Me.btnThoat.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Appearance.Options.UseFont = True
        Me.btnThoat.Image = CType(resources.GetObject("btnThoat.Image"), System.Drawing.Image)
        Me.btnThoat.Location = New System.Drawing.Point(266, 116)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnThoat.Size = New System.Drawing.Size(157, 22)
        Me.btnThoat.StyleController = Me.LayoutControl1
        Me.btnThoat.TabIndex = 7
        Me.btnThoat.Text = "Thoát (Esc)"
        '
        'btnDangky
        '
        Me.btnDangky.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDangky.Appearance.Options.UseFont = True
        Me.btnDangky.Image = CType(resources.GetObject("btnDangky.Image"), System.Drawing.Image)
        Me.btnDangky.Location = New System.Drawing.Point(182, 116)
        Me.btnDangky.MaximumSize = New System.Drawing.Size(80, 22)
        Me.btnDangky.Name = "btnDangky"
        Me.btnDangky.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnDangky.Size = New System.Drawing.Size(80, 22)
        Me.btnDangky.StyleController = Me.LayoutControl1
        Me.btnDangky.TabIndex = 6
        Me.btnDangky.Text = "Đăng Ký"
        '
        'txtDenngay
        '
        Me.txtDenngay.EnterMoveNextControl = True
        Me.txtDenngay.Location = New System.Drawing.Point(91, 60)
        Me.txtDenngay.Name = "txtDenngay"
        Me.txtDenngay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDenngay.Properties.Appearance.Options.UseFont = True
        Me.txtDenngay.Properties.AutoHeight = False
        Me.txtDenngay.Size = New System.Drawing.Size(332, 24)
        Me.txtDenngay.StyleController = Me.LayoutControl1
        Me.txtDenngay.TabIndex = 5
        '
        'txtTungay
        '
        Me.txtTungay.EnterMoveNextControl = True
        Me.txtTungay.Location = New System.Drawing.Point(91, 32)
        Me.txtTungay.Name = "txtTungay"
        Me.txtTungay.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTungay.Properties.Appearance.Options.UseFont = True
        Me.txtTungay.Properties.AutoHeight = False
        Me.txtTungay.Size = New System.Drawing.Size(332, 24)
        Me.txtTungay.StyleController = Me.LayoutControl1
        Me.txtTungay.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.lciSinhcode, Me.EmptySpaceItem1, Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(427, 146)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.txtTungay
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(0, 28)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(141, 28)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(423, 28)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Ngày bắt đầu :"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(84, 14)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me.txtDenngay
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 28)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(141, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(423, 28)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Ngày kết thúc :"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(84, 14)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnDangky
        Me.LayoutControlItem3.Location = New System.Drawing.Point(178, 112)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(84, 30)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnThoat
        Me.LayoutControlItem4.Location = New System.Drawing.Point(262, 112)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(161, 30)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem5.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem5.Control = Me.txtCode
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 84)
        Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(0, 28)
        Me.LayoutControlItem5.MinSize = New System.Drawing.Size(141, 28)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(423, 28)
        Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem5.Text = "Code :"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(84, 14)
        '
        'lciSinhcode
        '
        Me.lciSinhcode.Control = Me.btnSinhcode
        Me.lciSinhcode.Location = New System.Drawing.Point(63, 112)
        Me.lciSinhcode.Name = "lciSinhcode"
        Me.lciSinhcode.Size = New System.Drawing.Size(115, 30)
        Me.lciSinhcode.TextSize = New System.Drawing.Size(0, 0)
        Me.lciSinhcode.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 112)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(63, 30)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.Control = Me.txtTendonvi
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 28)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(141, 28)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(423, 28)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Tên đơn vị :"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(84, 14)
        '
        'frmDangKySD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 146)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDangKySD"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Ký Sử Dụng"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtTendonvi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDenngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTungay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciSinhcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnThoat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDangky As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDenngay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTungay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnSinhcode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lciSinhcode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtTendonvi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
