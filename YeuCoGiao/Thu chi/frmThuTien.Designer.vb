<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThuTien
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThuTien))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.cboLop = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtgcDSHS = New DevExpress.XtraGrid.GridControl()
        Me.dtgvDSHS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.stt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.hotenhs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ngaysinh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lop = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.diachi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.hotenbo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.hotenme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sdtbo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.sdtme = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribeXem = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ribeThu = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btnTimkiem = New DevExpress.XtraEditors.SimpleButton()
        Me.txtTen = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.cboLop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgcDSHS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgvDSHS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribeXem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribeThu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.cboLop)
        Me.LayoutControl1.Controls.Add(Me.dtgcDSHS)
        Me.LayoutControl1.Controls.Add(Me.btnTimkiem)
        Me.LayoutControl1.Controls.Add(Me.txtTen)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(719, 358)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cboLop
        '
        Me.cboLop.Location = New System.Drawing.Point(257, 4)
        Me.cboLop.Name = "cboLop"
        Me.cboLop.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLop.Properties.Appearance.Options.UseFont = True
        Me.cboLop.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLop.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cboLop.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
        Me.cboLop.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("tenlop", "Name1")})
        Me.cboLop.Properties.NullText = ""
        Me.cboLop.Properties.PopupSizeable = False
        Me.cboLop.Properties.ShowFooter = False
        Me.cboLop.Properties.ShowHeader = False
        Me.cboLop.Size = New System.Drawing.Size(116, 20)
        Me.cboLop.StyleController = Me.LayoutControl1
        Me.cboLop.TabIndex = 5
        '
        'dtgcDSHS
        '
        Me.dtgcDSHS.Location = New System.Drawing.Point(4, 30)
        Me.dtgcDSHS.MainView = Me.dtgvDSHS
        Me.dtgcDSHS.Name = "dtgcDSHS"
        Me.dtgcDSHS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ribeXem, Me.ribeThu})
        Me.dtgcDSHS.Size = New System.Drawing.Size(711, 324)
        Me.dtgcDSHS.TabIndex = 19
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
        Me.dtgvDSHS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.stt, Me.hotenhs, Me.ngaysinh, Me.lop, Me.diachi, Me.hotenbo, Me.hotenme, Me.sdtbo, Me.sdtme, Me.GridColumn1, Me.GridColumn2})
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
        Me.stt.OptionsColumn.ReadOnly = True
        Me.stt.Visible = True
        Me.stt.VisibleIndex = 0
        Me.stt.Width = 20
        '
        'hotenhs
        '
        Me.hotenhs.Caption = "Họ tên HS"
        Me.hotenhs.FieldName = "hoten"
        Me.hotenhs.Name = "hotenhs"
        Me.hotenhs.OptionsColumn.AllowEdit = False
        Me.hotenhs.OptionsColumn.ReadOnly = True
        Me.hotenhs.Visible = True
        Me.hotenhs.VisibleIndex = 1
        Me.hotenhs.Width = 92
        '
        'ngaysinh
        '
        Me.ngaysinh.Caption = "Ngày sinh"
        Me.ngaysinh.FieldName = "ngaysinh"
        Me.ngaysinh.Name = "ngaysinh"
        Me.ngaysinh.OptionsColumn.AllowEdit = False
        Me.ngaysinh.OptionsColumn.ReadOnly = True
        Me.ngaysinh.Visible = True
        Me.ngaysinh.VisibleIndex = 2
        Me.ngaysinh.Width = 54
        '
        'lop
        '
        Me.lop.Caption = "Lớp"
        Me.lop.FieldName = "tenlop"
        Me.lop.Name = "lop"
        Me.lop.OptionsColumn.AllowEdit = False
        Me.lop.OptionsColumn.ReadOnly = True
        Me.lop.Visible = True
        Me.lop.VisibleIndex = 4
        Me.lop.Width = 67
        '
        'diachi
        '
        Me.diachi.Caption = "Địa chỉ"
        Me.diachi.FieldName = "diachi"
        Me.diachi.Name = "diachi"
        Me.diachi.OptionsColumn.AllowEdit = False
        Me.diachi.OptionsColumn.ReadOnly = True
        Me.diachi.Visible = True
        Me.diachi.VisibleIndex = 3
        Me.diachi.Width = 56
        '
        'hotenbo
        '
        Me.hotenbo.Caption = "Họ tên bố"
        Me.hotenbo.FieldName = "hotencha"
        Me.hotenbo.Name = "hotenbo"
        Me.hotenbo.OptionsColumn.AllowEdit = False
        Me.hotenbo.OptionsColumn.ReadOnly = True
        Me.hotenbo.Visible = True
        Me.hotenbo.VisibleIndex = 5
        Me.hotenbo.Width = 53
        '
        'hotenme
        '
        Me.hotenme.Caption = "Họ tên mẹ"
        Me.hotenme.FieldName = "hotenme"
        Me.hotenme.Name = "hotenme"
        Me.hotenme.OptionsColumn.AllowEdit = False
        Me.hotenme.OptionsColumn.ReadOnly = True
        Me.hotenme.Visible = True
        Me.hotenme.VisibleIndex = 7
        Me.hotenme.Width = 86
        '
        'sdtbo
        '
        Me.sdtbo.Caption = "SĐT bố"
        Me.sdtbo.FieldName = "sdtcha"
        Me.sdtbo.Name = "sdtbo"
        Me.sdtbo.OptionsColumn.AllowEdit = False
        Me.sdtbo.OptionsColumn.ReadOnly = True
        Me.sdtbo.Visible = True
        Me.sdtbo.VisibleIndex = 6
        Me.sdtbo.Width = 51
        '
        'sdtme
        '
        Me.sdtme.Caption = "SĐT mẹ"
        Me.sdtme.FieldName = "sdtme"
        Me.sdtme.Name = "sdtme"
        Me.sdtme.OptionsColumn.AllowEdit = False
        Me.sdtme.OptionsColumn.ReadOnly = True
        Me.sdtme.Visible = True
        Me.sdtme.VisibleIndex = 8
        Me.sdtme.Width = 99
        '
        'GridColumn1
        '
        Me.GridColumn1.ColumnEdit = Me.ribeXem
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 9
        Me.GridColumn1.Width = 38
        '
        'ribeXem
        '
        Me.ribeXem.AutoHeight = False
        Me.ribeXem.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("ribeXem.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.ribeXem.Name = "ribeXem"
        Me.ribeXem.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn2
        '
        Me.GridColumn2.ColumnEdit = Me.ribeThu
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.ToolTip = "Thu theo khoản"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 10
        Me.GridColumn2.Width = 39
        '
        'ribeThu
        '
        Me.ribeThu.AutoHeight = False
        Me.ribeThu.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("ribeThu.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.ribeThu.Name = "ribeThu"
        Me.ribeThu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btnTimkiem
        '
        Me.btnTimkiem.Image = CType(resources.GetObject("btnTimkiem.Image"), System.Drawing.Image)
        Me.btnTimkiem.Location = New System.Drawing.Point(377, 4)
        Me.btnTimkiem.Name = "btnTimkiem"
        Me.btnTimkiem.Size = New System.Drawing.Size(84, 22)
        Me.btnTimkiem.StyleController = Me.LayoutControl1
        Me.btnTimkiem.TabIndex = 6
        Me.btnTimkiem.Text = "Tìm kiếm"
        '
        'txtTen
        '
        Me.txtTen.Location = New System.Drawing.Point(55, 4)
        Me.txtTen.Name = "txtTen"
        Me.txtTen.Size = New System.Drawing.Size(147, 20)
        Me.txtTen.StyleController = Me.LayoutControl1
        Me.txtTen.TabIndex = 4
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(719, 358)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(461, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(254, 26)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtTen
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(202, 26)
        Me.LayoutControlItem1.Text = "Nhập tên:"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(48, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnTimkiem
        Me.LayoutControlItem3.Location = New System.Drawing.Point(373, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(88, 26)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtgcDSHS
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(715, 328)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.cboLop
        Me.LayoutControlItem2.Location = New System.Drawing.Point(202, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(171, 26)
        Me.LayoutControlItem2.Text = "Chọn lớp:"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(48, 13)
        '
        'ToolTipController1
        '
        Me.ToolTipController1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolTipController1.Appearance.Options.UseBackColor = True
        Me.ToolTipController1.Rounded = True
        Me.ToolTipController1.ShowBeak = True
        Me.ToolTipController1.ToolTipStyle = DevExpress.Utils.ToolTipStyle.WindowsXP
        '
        'frmThuTien
        '
        Me.ClientSize = New System.Drawing.Size(719, 358)
        Me.Controls.Add(Me.LayoutControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmThuTien"
        Me.ShowIcon = False
        Me.Text = "Thu tiền"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.cboLop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgcDSHS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgvDSHS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribeXem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribeThu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnTimkiem As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dtgcDSHS As DevExpress.XtraGrid.GridControl
    Friend WithEvents dtgvDSHS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cboLop As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents stt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hotenhs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ngaysinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents diachi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hotenbo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ribeXem As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents lop As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hotenme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sdtbo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sdtme As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ribeThu As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
End Class
