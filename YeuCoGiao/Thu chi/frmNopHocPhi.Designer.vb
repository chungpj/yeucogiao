<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNopHocPhi
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNopHocPhi))
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.dtgcDSHS = New DevExpress.XtraGrid.GridControl()
        Me.dtgvDSHS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.stt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nopchothang = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sotien = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ngaythu = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ResponChon = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.cboNam = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cboThang = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnLuu = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXoa = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSua = New DevExpress.XtraEditors.SimpleButton()
        Me.btnHuy = New DevExpress.XtraEditors.SimpleButton()
        Me.btnThem = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNoidung = New DevExpress.XtraEditors.TextEdit()
        Me.txtSotien = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.lbGioitinh = New System.Windows.Forms.Label()
        Me.lbNgaysinh = New System.Windows.Forms.Label()
        Me.lbLop = New System.Windows.Forms.Label()
        Me.lbHoten = New System.Windows.Forms.Label()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.dtgcDSHS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvDSHS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResponChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboNam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboThang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoidung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSotien.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.dtgcDSHS)
        Me.LayoutControl2.Controls.Add(Me.cboNam)
        Me.LayoutControl2.Controls.Add(Me.cboThang)
        Me.LayoutControl2.Controls.Add(Me.btnLuu)
        Me.LayoutControl2.Controls.Add(Me.btnXoa)
        Me.LayoutControl2.Controls.Add(Me.btnSua)
        Me.LayoutControl2.Controls.Add(Me.btnHuy)
        Me.LayoutControl2.Controls.Add(Me.btnThem)
        Me.LayoutControl2.Controls.Add(Me.txtNoidung)
        Me.LayoutControl2.Controls.Add(Me.txtSotien)
        Me.LayoutControl2.Controls.Add(Me.LayoutControl1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(554, 463)
        Me.LayoutControl2.TabIndex = 1
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'dtgcDSHS
        '
        Me.dtgcDSHS.Location = New System.Drawing.Point(9, 229)
        Me.dtgcDSHS.MainView = Me.dtgvDSHS
        Me.dtgcDSHS.Name = "dtgcDSHS"
        Me.dtgcDSHS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ResponChon})
        Me.dtgcDSHS.Size = New System.Drawing.Size(536, 225)
        Me.dtgcDSHS.TabIndex = 20
        Me.dtgcDSHS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dtgvDSHS})
        '
        'dtgvDSHS
        '
        Me.dtgvDSHS.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgvDSHS.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvDSHS.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Navy
        Me.dtgvDSHS.Appearance.FocusedCell.Options.UseBackColor = True
        Me.dtgvDSHS.Appearance.FocusedCell.Options.UseFont = True
        Me.dtgvDSHS.Appearance.FocusedCell.Options.UseForeColor = True
        Me.dtgvDSHS.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgvDSHS.Appearance.FocusedRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvDSHS.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Navy
        Me.dtgvDSHS.Appearance.FocusedRow.Options.UseBackColor = True
        Me.dtgvDSHS.Appearance.FocusedRow.Options.UseFont = True
        Me.dtgvDSHS.Appearance.FocusedRow.Options.UseForeColor = True
        Me.dtgvDSHS.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvDSHS.Appearance.HeaderPanel.Options.UseFont = True
        Me.dtgvDSHS.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgvDSHS.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvDSHS.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Navy
        Me.dtgvDSHS.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.dtgvDSHS.Appearance.HideSelectionRow.Options.UseFont = True
        Me.dtgvDSHS.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.dtgvDSHS.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtgvDSHS.Appearance.Row.Options.UseFont = True
        Me.dtgvDSHS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.stt, Me.nopchothang, Me.sotien, Me.ngaythu})
        Me.dtgvDSHS.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.dtgvDSHS.GridControl = Me.dtgcDSHS
        Me.dtgvDSHS.Name = "dtgvDSHS"
        Me.dtgvDSHS.OptionsFilter.AllowFilterEditor = False
        Me.dtgvDSHS.OptionsPrint.AutoWidth = False
        Me.dtgvDSHS.OptionsView.ShowGroupPanel = False
        Me.dtgvDSHS.OptionsView.ShowIndicator = False
        '
        'stt
        '
        Me.stt.Caption = "STT"
        Me.stt.FieldName = "stt"
        Me.stt.Name = "stt"
        Me.stt.OptionsColumn.AllowEdit = False
        Me.stt.OptionsColumn.FixedWidth = True
        Me.stt.OptionsColumn.ReadOnly = True
        Me.stt.Visible = True
        Me.stt.VisibleIndex = 0
        Me.stt.Width = 40
        '
        'nopchothang
        '
        Me.nopchothang.Caption = "Nộp cho tháng"
        Me.nopchothang.FieldName = "nopchothang"
        Me.nopchothang.Name = "nopchothang"
        Me.nopchothang.OptionsColumn.AllowEdit = False
        Me.nopchothang.OptionsColumn.ReadOnly = True
        Me.nopchothang.Visible = True
        Me.nopchothang.VisibleIndex = 1
        Me.nopchothang.Width = 200
        '
        'sotien
        '
        Me.sotien.Caption = "Số tiền"
        Me.sotien.FieldName = "sotien"
        Me.sotien.Name = "sotien"
        Me.sotien.OptionsColumn.AllowEdit = False
        Me.sotien.OptionsColumn.ReadOnly = True
        Me.sotien.Visible = True
        Me.sotien.VisibleIndex = 2
        Me.sotien.Width = 97
        '
        'ngaythu
        '
        Me.ngaythu.Caption = "Ngày thu"
        Me.ngaythu.FieldName = "ngaynop"
        Me.ngaythu.Name = "ngaythu"
        Me.ngaythu.OptionsColumn.AllowEdit = False
        Me.ngaythu.OptionsColumn.ReadOnly = True
        Me.ngaythu.Visible = True
        Me.ngaythu.VisibleIndex = 3
        Me.ngaythu.Width = 150
        '
        'ResponChon
        '
        Me.ResponChon.AutoHeight = False
        Me.ResponChon.Name = "ResponChon"
        '
        'cboNam
        '
        Me.cboNam.Location = New System.Drawing.Point(351, 95)
        Me.cboNam.Name = "cboNam"
        Me.cboNam.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNam.Properties.Appearance.Options.UseFont = True
        Me.cboNam.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNam.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboNam.Properties.AutoHeight = False
        Me.cboNam.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
        Me.cboNam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboNam.Size = New System.Drawing.Size(199, 24)
        Me.cboNam.StyleController = Me.LayoutControl2
        Me.cboNam.TabIndex = 7
        '
        'cboThang
        '
        Me.cboThang.Location = New System.Drawing.Point(76, 95)
        Me.cboThang.Name = "cboThang"
        Me.cboThang.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboThang.Properties.Appearance.Options.UseFont = True
        Me.cboThang.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboThang.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboThang.Properties.AutoHeight = False
        Me.cboThang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
        Me.cboThang.Properties.Items.AddRange(New Object() {"Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12"})
        Me.cboThang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboThang.Size = New System.Drawing.Size(199, 24)
        Me.cboThang.StyleController = Me.LayoutControl2
        Me.cboThang.TabIndex = 6
        '
        'btnLuu
        '
        Me.btnLuu.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.Appearance.Options.UseFont = True
        Me.btnLuu.Image = CType(resources.GetObject("btnLuu.Image"), System.Drawing.Image)
        Me.btnLuu.Location = New System.Drawing.Point(216, 179)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnLuu.Size = New System.Drawing.Size(111, 22)
        Me.btnLuu.StyleController = Me.LayoutControl2
        Me.btnLuu.TabIndex = 14
        Me.btnLuu.Text = "Lưu (F2)"
        '
        'btnXoa
        '
        Me.btnXoa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Appearance.Options.UseFont = True
        Me.btnXoa.Image = CType(resources.GetObject("btnXoa.Image"), System.Drawing.Image)
        Me.btnXoa.Location = New System.Drawing.Point(331, 179)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnXoa.Size = New System.Drawing.Size(98, 22)
        Me.btnXoa.StyleController = Me.LayoutControl2
        Me.btnXoa.TabIndex = 13
        Me.btnXoa.Text = "Xóa (F7)"
        '
        'btnSua
        '
        Me.btnSua.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Appearance.Options.UseFont = True
        Me.btnSua.Image = CType(resources.GetObject("btnSua.Image"), System.Drawing.Image)
        Me.btnSua.Location = New System.Drawing.Point(108, 179)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnSua.Size = New System.Drawing.Size(104, 22)
        Me.btnSua.StyleController = Me.LayoutControl2
        Me.btnSua.TabIndex = 12
        Me.btnSua.Text = "Sửa (F4)"
        '
        'btnHuy
        '
        Me.btnHuy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.Appearance.Options.UseFont = True
        Me.btnHuy.Image = CType(resources.GetObject("btnHuy.Image"), System.Drawing.Image)
        Me.btnHuy.Location = New System.Drawing.Point(433, 179)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnHuy.Size = New System.Drawing.Size(117, 22)
        Me.btnHuy.StyleController = Me.LayoutControl2
        Me.btnHuy.TabIndex = 11
        Me.btnHuy.Text = "Thoát (Esc)"
        '
        'btnThem
        '
        Me.btnThem.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Appearance.Options.UseFont = True
        Me.btnThem.Image = CType(resources.GetObject("btnThem.Image"), System.Drawing.Image)
        Me.btnThem.Location = New System.Drawing.Point(4, 179)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnThem.Size = New System.Drawing.Size(100, 22)
        Me.btnThem.StyleController = Me.LayoutControl2
        Me.btnThem.TabIndex = 10
        Me.btnThem.Text = "Thêm (F3)"
        '
        'txtNoidung
        '
        Me.txtNoidung.Location = New System.Drawing.Point(76, 151)
        Me.txtNoidung.Name = "txtNoidung"
        Me.txtNoidung.Properties.AutoHeight = False
        Me.txtNoidung.Size = New System.Drawing.Size(474, 24)
        Me.txtNoidung.StyleController = Me.LayoutControl2
        Me.txtNoidung.TabIndex = 7
        '
        'txtSotien
        '
        Me.txtSotien.Location = New System.Drawing.Point(76, 123)
        Me.txtSotien.Name = "txtSotien"
        Me.txtSotien.Properties.AutoHeight = False
        Me.txtSotien.Size = New System.Drawing.Size(474, 24)
        Me.txtSotien.StyleController = Me.LayoutControl2
        Me.txtSotien.TabIndex = 6
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.lbGioitinh)
        Me.LayoutControl1.Controls.Add(Me.lbNgaysinh)
        Me.LayoutControl1.Controls.Add(Me.lbLop)
        Me.LayoutControl1.Controls.Add(Me.lbHoten)
        Me.LayoutControl1.Location = New System.Drawing.Point(4, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(546, 87)
        Me.LayoutControl1.TabIndex = 5
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'lbGioitinh
        '
        Me.lbGioitinh.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbGioitinh.Location = New System.Drawing.Point(275, 46)
        Me.lbGioitinh.Name = "lbGioitinh"
        Me.lbGioitinh.Size = New System.Drawing.Size(267, 37)
        Me.lbGioitinh.TabIndex = 7
        Me.lbGioitinh.Text = "Giới tính:"
        Me.lbGioitinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbNgaysinh
        '
        Me.lbNgaysinh.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNgaysinh.Location = New System.Drawing.Point(4, 46)
        Me.lbNgaysinh.Name = "lbNgaysinh"
        Me.lbNgaysinh.Size = New System.Drawing.Size(267, 37)
        Me.lbNgaysinh.TabIndex = 6
        Me.lbNgaysinh.Text = "Ngày sinh:"
        Me.lbNgaysinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLop
        '
        Me.lbLop.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLop.Location = New System.Drawing.Point(275, 4)
        Me.lbLop.Name = "lbLop"
        Me.lbLop.Size = New System.Drawing.Size(267, 38)
        Me.lbLop.TabIndex = 5
        Me.lbLop.Text = "Lớp:"
        Me.lbLop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbHoten
        '
        Me.lbHoten.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHoten.Location = New System.Drawing.Point(4, 4)
        Me.lbHoten.Name = "lbHoten"
        Me.lbHoten.Size = New System.Drawing.Size(267, 38)
        Me.lbHoten.TabIndex = 4
        Me.lbHoten.Text = "Họ tên:"
        Me.lbHoten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem6})
        Me.Root.Location = New System.Drawing.Point(0, 0)
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.Root.Size = New System.Drawing.Size(546, 87)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lbHoten
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(271, 42)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.lbLop
        Me.LayoutControlItem3.Location = New System.Drawing.Point(271, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(271, 42)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.lbNgaysinh
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(271, 41)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.lbGioitinh
        Me.LayoutControlItem6.Location = New System.Drawing.Point(271, 42)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(271, 41)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15, Me.LayoutControlGroup1, Me.LayoutControlItem16, Me.LayoutControlItem9})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(554, 463)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.LayoutControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(550, 91)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem7.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem7.Control = Me.txtSotien
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 119)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 28)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(126, 28)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(550, 28)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Số tiền:"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(68, 14)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem8.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem8.Control = Me.txtNoidung
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 147)
        Me.LayoutControlItem8.MaxSize = New System.Drawing.Size(0, 28)
        Me.LayoutControlItem8.MinSize = New System.Drawing.Size(126, 28)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(550, 28)
        Me.LayoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem8.Text = "Nội dung:"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(68, 14)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnThem
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 175)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(104, 26)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnHuy
        Me.LayoutControlItem12.Location = New System.Drawing.Point(429, 175)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(121, 26)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.btnSua
        Me.LayoutControlItem13.Location = New System.Drawing.Point(104, 175)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(108, 26)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.btnXoa
        Me.LayoutControlItem14.Location = New System.Drawing.Point(327, 175)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(102, 26)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnLuu
        Me.LayoutControlItem15.Location = New System.Drawing.Point(212, 175)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(115, 26)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.AppearanceGroup.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlGroup1.AppearanceGroup.Options.UseFont = True
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 201)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(550, 258)
        Me.LayoutControlGroup1.Text = "Lịch sử"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.dtgcDSHS
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(540, 229)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem16.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem16.Control = Me.cboThang
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 91)
        Me.LayoutControlItem16.MaxSize = New System.Drawing.Size(0, 28)
        Me.LayoutControlItem16.MinSize = New System.Drawing.Size(126, 28)
        Me.LayoutControlItem16.Name = "LayoutControlItem16"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(275, 28)
        Me.LayoutControlItem16.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem16.Text = "Chọn tháng:"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(68, 14)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem9.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem9.Control = Me.cboNam
        Me.LayoutControlItem9.Location = New System.Drawing.Point(275, 91)
        Me.LayoutControlItem9.MaxSize = New System.Drawing.Size(0, 28)
        Me.LayoutControlItem9.MinSize = New System.Drawing.Size(126, 28)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(275, 28)
        Me.LayoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem9.Text = "Chọn năm:"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(68, 14)
        '
        'frmNopHocPhi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 463)
        Me.Controls.Add(Me.LayoutControl2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNopHocPhi"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thu tiền"
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.dtgcDSHS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvDSHS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResponChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboNam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboThang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoidung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSotien.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnXoa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSua As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnHuy As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnThem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNoidung As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSotien As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents lbGioitinh As Label
    Friend WithEvents lbNgaysinh As Label
    Friend WithEvents lbLop As Label
    Friend WithEvents lbHoten As Label
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnLuu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents cboThang As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboNam As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtgcDSHS As DevExpress.XtraGrid.GridControl
    Friend WithEvents dtgvDSHS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents stt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nopchothang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sotien As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ngaythu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResponChon As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
