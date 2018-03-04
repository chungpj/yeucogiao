<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKhoanthu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhoanthu))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dtgvDs = New DevExpress.XtraGrid.GridControl()
        Me.dtgcDs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.stt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ten = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTen = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnThoát = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dtgvDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgcDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.btnThoát)
        Me.LayoutControl1.Controls.Add(Me.dtgvDs)
        Me.LayoutControl1.Controls.Add(Me.btnSua)
        Me.LayoutControl1.Controls.Add(Me.btnXoa)
        Me.LayoutControl1.Controls.Add(Me.btnLuu)
        Me.LayoutControl1.Controls.Add(Me.btnThem)
        Me.LayoutControl1.Controls.Add(Me.txtTen)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(591, 329)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dtgvDs
        '
        Me.dtgvDs.Location = New System.Drawing.Point(9, 85)
        Me.dtgvDs.MainView = Me.dtgcDs
        Me.dtgvDs.Name = "dtgvDs"
        Me.dtgvDs.Size = New System.Drawing.Size(573, 235)
        Me.dtgvDs.TabIndex = 9
        Me.dtgvDs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dtgcDs})
        '
        'dtgcDs
        '
        Me.dtgcDs.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgcDs.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcDs.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Navy
        Me.dtgcDs.Appearance.FocusedCell.Options.UseBackColor = True
        Me.dtgcDs.Appearance.FocusedCell.Options.UseFont = True
        Me.dtgcDs.Appearance.FocusedCell.Options.UseForeColor = True
        Me.dtgcDs.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgcDs.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcDs.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Navy
        Me.dtgcDs.Appearance.FocusedRow.Options.UseBackColor = True
        Me.dtgcDs.Appearance.FocusedRow.Options.UseFont = True
        Me.dtgcDs.Appearance.FocusedRow.Options.UseForeColor = True
        Me.dtgcDs.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcDs.Appearance.HeaderPanel.Options.UseFont = True
        Me.dtgcDs.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgcDs.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcDs.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Navy
        Me.dtgcDs.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.dtgcDs.Appearance.HideSelectionRow.Options.UseFont = True
        Me.dtgcDs.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.dtgcDs.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgcDs.Appearance.Row.Options.UseFont = True
        Me.dtgcDs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.stt, Me.ten})
        Me.dtgcDs.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.dtgcDs.GridControl = Me.dtgvDs
        Me.dtgcDs.Name = "dtgcDs"
        Me.dtgcDs.OptionsBehavior.Editable = False
        Me.dtgcDs.OptionsBehavior.ReadOnly = True
        Me.dtgcDs.OptionsView.ShowGroupPanel = False
        Me.dtgcDs.OptionsView.ShowIndicator = False
        '
        'stt
        '
        Me.stt.Caption = "STT"
        Me.stt.FieldName = "stt"
        Me.stt.Name = "stt"
        Me.stt.Visible = True
        Me.stt.VisibleIndex = 0
        Me.stt.Width = 68
        '
        'ten
        '
        Me.ten.Caption = "Tên khoản thu"
        Me.ten.FieldName = "ten"
        Me.ten.Name = "ten"
        Me.ten.Visible = True
        Me.ten.VisibleIndex = 1
        Me.ten.Width = 359
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.Location = New System.Drawing.Point(107, 32)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSua.Size = New System.Drawing.Size(117, 22)
        Me.btnSua.StyleController = Me.LayoutControl1
        Me.btnSua.TabIndex = 8
        Me.btnSua.Text = "Sửa (F4)"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.Location = New System.Drawing.Point(338, 32)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnXoa.Size = New System.Drawing.Size(115, 22)
        Me.btnXoa.StyleController = Me.LayoutControl1
        Me.btnXoa.TabIndex = 7
        Me.btnXoa.Text = "Xóa (F7)"
        '
        'btnLuu
        '
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(228, 32)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnLuu.Size = New System.Drawing.Size(106, 22)
        Me.btnLuu.StyleController = Me.LayoutControl1
        Me.btnLuu.TabIndex = 6
        Me.btnLuu.Text = "Lưu (F2)"
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.Location = New System.Drawing.Point(4, 32)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnThem.Size = New System.Drawing.Size(99, 22)
        Me.btnThem.StyleController = Me.LayoutControl1
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm (F3)"
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(94, 4)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen.Properties.Appearance.Options.UseFont = True
        Me.txtTen.Properties.AutoHeight = False
        Me.txtTen.Size = New System.Drawing.Size(493, 24)
        Me.txtTen.StyleController = Me.LayoutControl1
        Me.txtTen.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.TabbedControlGroup1, Me.LayoutControlItem7})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(591, 329)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me.txtTen
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.MaxSize = New System.Drawing.Size(0, 28)
        Me.LayoutControlItem1.MinSize = New System.Drawing.Size(144, 28)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(587, 28)
        Me.LayoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem1.Text = "Tên khoản thu:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(86, 14)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnThem
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 28)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(103, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnLuu
        Me.LayoutControlItem3.Location = New System.Drawing.Point(224, 28)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(110, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnXoa
        Me.LayoutControlItem4.Location = New System.Drawing.Point(334, 28)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(119, 26)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnSua
        Me.LayoutControlItem5.Location = New System.Drawing.Point(103, 28)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(121, 26)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabbedControlGroup1.AppearanceGroup.Options.UseFont = True
        Me.TabbedControlGroup1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabbedControlGroup1.AppearanceItemCaption.Options.UseFont = True
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 54)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup2
        Me.TabbedControlGroup1.SelectedTabPageIndex = 0
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(587, 271)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2})
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(577, 239)
        Me.LayoutControlGroup2.Text = "Danh sách"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.dtgvDs
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(577, 239)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'btnThoát
        '
        Me.btnThoát.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoát.Appearance.Options.UseFont = True
        Me.btnThoát.Image = CType(resources.GetObject("btnThoát.Image"), System.Drawing.Image)
        Me.btnThoát.Location = New System.Drawing.Point(457, 32)
        Me.btnThoát.Name = "btnThoát"
        Me.btnThoát.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnThoát.Size = New System.Drawing.Size(130, 22)
        Me.btnThoát.StyleController = Me.LayoutControl1
        Me.btnThoát.TabIndex = 10
        Me.btnThoát.Text = "Thoát (Esc)"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnThoát
        Me.LayoutControlItem7.Location = New System.Drawing.Point(453, 28)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(134, 26)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'frmKhoanthu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 329)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKhoanthu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách khoản thu"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dtgvDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgcDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtgvDs As DevExpress.XtraGrid.GridControl
    Friend WithEvents dtgcDs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents stt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ten As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnThoát As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
End Class
