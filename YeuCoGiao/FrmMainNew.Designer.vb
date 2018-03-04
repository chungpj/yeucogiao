<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainNew
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainNew))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.mnBarAddHS = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarListHS = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarAddEatDay = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarReport = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarLogin = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarQLUser = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarThuTien = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarTH = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarQLSuatAn = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarDSLop = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarTK = New DevExpress.XtraBars.BarButtonItem()
        Me.SkinRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
        Me.lblInFo = New DevExpress.XtraBars.BarStaticItem()
        Me.lblTimer = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
        Me.mnBarDangKySD = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarDoiMatkhau = New DevExpress.XtraBars.BarButtonItem()
        Me.mnBarKhoanThu = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.mnBarQL = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.DefaultSkin = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.timDongBoGio = New System.Windows.Forms.Timer(Me.components)
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TabControl = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.btnShow = New DevExpress.XtraEditors.SimpleButton()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1, Me.BarSubItem1, Me.mnBarAddHS, Me.mnBarListHS, Me.mnBarAddEatDay, Me.mnBarReport, Me.mnBarLogin, Me.mnBarQLUser, Me.mnBarThuTien, Me.mnBarTH, Me.mnBarQLSuatAn, Me.mnBarDSLop, Me.mnBarTK, Me.SkinRibbonGalleryBarItem1, Me.lblInFo, Me.lblTimer, Me.BarButtonGroup1, Me.mnBarDangKySD, Me.mnBarDoiMatkhau, Me.mnBarKhoanThu})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 21
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4})
        Me.RibbonControl.Size = New System.Drawing.Size(951, 150)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 1
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 2
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'mnBarAddHS
        '
        Me.mnBarAddHS.Caption = "Thêm Học Sinh"
        Me.mnBarAddHS.Id = 3
        Me.mnBarAddHS.ImageUri.Uri = "Add"
        Me.mnBarAddHS.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarAddHS.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarAddHS.Name = "mnBarAddHS"
        '
        'mnBarListHS
        '
        Me.mnBarListHS.Caption = "Danh sách Học Sinh"
        Me.mnBarListHS.Id = 4
        Me.mnBarListHS.ImageUri.Uri = "ListBullets"
        Me.mnBarListHS.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarListHS.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarListHS.Name = "mnBarListHS"
        '
        'mnBarAddEatDay
        '
        Me.mnBarAddEatDay.Caption = "Thêm Ngày ăn"
        Me.mnBarAddEatDay.Id = 5
        Me.mnBarAddEatDay.ImageUri.Uri = "Edit"
        Me.mnBarAddEatDay.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarAddEatDay.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarAddEatDay.Name = "mnBarAddEatDay"
        '
        'mnBarReport
        '
        Me.mnBarReport.Caption = "Thống kê Ngày ăn"
        Me.mnBarReport.Id = 6
        Me.mnBarReport.ImageUri.Uri = "SwitchTimeScalesTo"
        Me.mnBarReport.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarReport.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarReport.Name = "mnBarReport"
        '
        'mnBarLogin
        '
        Me.mnBarLogin.Caption = "Đăng nhập"
        Me.mnBarLogin.Glyph = CType(resources.GetObject("mnBarLogin.Glyph"), System.Drawing.Image)
        Me.mnBarLogin.Id = 7
        Me.mnBarLogin.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarLogin.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarLogin.LargeGlyph = CType(resources.GetObject("mnBarLogin.LargeGlyph"), System.Drawing.Image)
        Me.mnBarLogin.Name = "mnBarLogin"
        '
        'mnBarQLUser
        '
        Me.mnBarQLUser.Caption = "Quản lý nhân sự"
        Me.mnBarQLUser.Glyph = CType(resources.GetObject("mnBarQLUser.Glyph"), System.Drawing.Image)
        Me.mnBarQLUser.Id = 8
        Me.mnBarQLUser.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarQLUser.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarQLUser.LargeGlyph = CType(resources.GetObject("mnBarQLUser.LargeGlyph"), System.Drawing.Image)
        Me.mnBarQLUser.Name = "mnBarQLUser"
        '
        'mnBarThuTien
        '
        Me.mnBarThuTien.Caption = "Thu tiền"
        Me.mnBarThuTien.Id = 9
        Me.mnBarThuTien.ImageUri.Uri = "AddItem"
        Me.mnBarThuTien.Name = "mnBarThuTien"
        '
        'mnBarTH
        '
        Me.mnBarTH.Caption = "BarButtonItem9"
        Me.mnBarTH.Id = 10
        Me.mnBarTH.Name = "mnBarTH"
        '
        'mnBarQLSuatAn
        '
        Me.mnBarQLSuatAn.Caption = "Suất ăn"
        Me.mnBarQLSuatAn.Id = 11
        Me.mnBarQLSuatAn.ImageUri.Uri = "WeekView"
        Me.mnBarQLSuatAn.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarQLSuatAn.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarQLSuatAn.Name = "mnBarQLSuatAn"
        '
        'mnBarDSLop
        '
        Me.mnBarDSLop.Caption = "Danh sách lớp"
        Me.mnBarDSLop.Glyph = CType(resources.GetObject("mnBarDSLop.Glyph"), System.Drawing.Image)
        Me.mnBarDSLop.Id = 12
        Me.mnBarDSLop.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarDSLop.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarDSLop.LargeGlyph = CType(resources.GetObject("mnBarDSLop.LargeGlyph"), System.Drawing.Image)
        Me.mnBarDSLop.Name = "mnBarDSLop"
        '
        'mnBarTK
        '
        Me.mnBarTK.Caption = "Thống kê Tiền Thu"
        Me.mnBarTK.Id = 13
        Me.mnBarTK.ImageUri.Uri = "Chart"
        Me.mnBarTK.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarTK.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarTK.Name = "mnBarTK"
        '
        'SkinRibbonGalleryBarItem1
        '
        Me.SkinRibbonGalleryBarItem1.Caption = "Đổi Giao diện"
        Me.SkinRibbonGalleryBarItem1.Glyph = CType(resources.GetObject("SkinRibbonGalleryBarItem1.Glyph"), System.Drawing.Image)
        Me.SkinRibbonGalleryBarItem1.Id = 14
        Me.SkinRibbonGalleryBarItem1.Name = "SkinRibbonGalleryBarItem1"
        '
        'lblInFo
        '
        Me.lblInFo.Caption = "lblInFo"
        Me.lblInFo.Id = 15
        Me.lblInFo.Name = "lblInFo"
        Me.lblInFo.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'lblTimer
        '
        Me.lblTimer.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.lblTimer.Caption = "lblTimer"
        Me.lblTimer.Id = 16
        Me.lblTimer.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Red
        Me.lblTimer.ItemAppearance.Normal.Options.UseForeColor = True
        Me.lblTimer.ItemInMenuAppearance.Normal.ForeColor = System.Drawing.Color.Red
        Me.lblTimer.ItemInMenuAppearance.Normal.Options.UseForeColor = True
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'BarButtonGroup1
        '
        Me.BarButtonGroup1.Caption = "BarButtonGroup1"
        Me.BarButtonGroup1.Id = 17
        Me.BarButtonGroup1.Name = "BarButtonGroup1"
        '
        'mnBarDangKySD
        '
        Me.mnBarDangKySD.Caption = "Đăng ký sử dụng"
        Me.mnBarDangKySD.Id = 18
        Me.mnBarDangKySD.ImageUri.Uri = "Paste"
        Me.mnBarDangKySD.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarDangKySD.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarDangKySD.Name = "mnBarDangKySD"
        '
        'mnBarDoiMatkhau
        '
        Me.mnBarDoiMatkhau.Caption = "Đổi mật khẩu"
        Me.mnBarDoiMatkhau.Id = 19
        Me.mnBarDoiMatkhau.ImageUri.Uri = "Refresh"
        Me.mnBarDoiMatkhau.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarDoiMatkhau.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarDoiMatkhau.Name = "mnBarDoiMatkhau"
        '
        'mnBarKhoanThu
        '
        Me.mnBarKhoanThu.Caption = "Khoản thu"
        Me.mnBarKhoanThu.Glyph = CType(resources.GetObject("mnBarKhoanThu.Glyph"), System.Drawing.Image)
        Me.mnBarKhoanThu.Id = 20
        Me.mnBarKhoanThu.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnBarKhoanThu.ItemAppearance.Normal.Options.UseFont = True
        Me.mnBarKhoanThu.LargeGlyph = CType(resources.GetObject("mnBarKhoanThu.LargeGlyph"), System.Drawing.Image)
        Me.mnBarKhoanThu.Name = "mnBarKhoanThu"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage1.Appearance.Options.UseFont = True
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup11})
        Me.RibbonPage1.Image = CType(resources.GetObject("RibbonPage1.Image"), System.Drawing.Image)
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Quản lý Học Sinh"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnBarAddHS)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.mnBarListHS)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.ItemLinks.Add(Me.mnBarDSLop)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage2.Appearance.Options.UseFont = True
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup10, Me.RibbonPageGroup4})
        Me.RibbonPage2.Image = CType(resources.GetObject("RibbonPage2.Image"), System.Drawing.Image)
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Quản lý Ngày ăn"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.mnBarAddEatDay)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.ItemLinks.Add(Me.mnBarQLSuatAn)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.mnBarReport)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage3.Appearance.Options.UseFont = True
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup7})
        Me.RibbonPage3.Image = CType(resources.GetObject("RibbonPage3.Image"), System.Drawing.Image)
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Thanh toán"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.mnBarThuTien)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.mnBarKhoanThu)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.mnBarTK)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonPage4.Appearance.Options.UseFont = True
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup8, Me.mnBarQL, Me.RibbonPageGroup9, Me.RibbonPageGroup6, Me.RibbonPageGroup2})
        Me.RibbonPage4.Image = CType(resources.GetObject("RibbonPage4.Image"), System.Drawing.Image)
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Hệ thống"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.mnBarLogin)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        '
        'mnBarQL
        '
        Me.mnBarQL.ItemLinks.Add(Me.mnBarQLUser)
        Me.mnBarQL.Name = "mnBarQL"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.mnBarDoiMatkhau)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.mnBarDangKySD)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.SkinRibbonGalleryBarItem1)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.lblInFo)
        Me.RibbonStatusBar.ItemLinks.Add(Me.lblTimer)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 551)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(951, 23)
        '
        'DefaultSkin
        '
        Me.DefaultSkin.EnableBonusSkins = True
        Me.DefaultSkin.LookAndFeel.SkinName = "Office 2007 Blue"
        '
        'timDongBoGio
        '
        Me.timDongBoGio.Interval = 1000
        '
        'TileControl1
        '
        Me.TileControl1.BackgroundImage = Global.YeuCoGiao.My.Resources.Resources.bg_body
        Me.TileControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.DragSize = New System.Drawing.Size(0, 0)
        Me.TileControl1.Location = New System.Drawing.Point(0, 150)
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(951, 401)
        Me.TileControl1.TabIndex = 2
        Me.TileControl1.Text = "TileControl1"
        '
        'TabControl
        '
        Me.TabControl.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Appearance.Options.UseFont = True
        Me.TabControl.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.AppearancePage.Header.Options.UseFont = True
        Me.TabControl.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.AppearancePage.HeaderActive.Options.UseFont = True
        Me.TabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders
        Me.TabControl.MdiParent = Me
        '
        'ToolTipController1
        '
        Me.ToolTipController1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolTipController1.Appearance.Options.UseBackColor = True
        Me.ToolTipController1.Rounded = True
        Me.ToolTipController1.ShowBeak = True
        Me.ToolTipController1.ToolTipStyle = DevExpress.Utils.ToolTipStyle.WindowsXP
        '
        'btnShow
        '
        Me.btnShow.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Appearance.Options.UseFont = True
        Me.btnShow.Location = New System.Drawing.Point(0, 389)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(13, 98)
        Me.btnShow.TabIndex = 5
        Me.btnShow.Text = ">"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Location = New System.Drawing.Point(1, 294)
        Me.MemoEdit1.MenuManager = Me.RibbonControl
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(369, 257)
        Me.MemoEdit1.TabIndex = 6
        Me.MemoEdit1.Visible = False
        '
        'FrmMainNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 574)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.MemoEdit1)
        Me.Controls.Add(Me.TileControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "FrmMainNew"
        Me.Ribbon = Me.RibbonControl
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "Phần mềm Quản lý Mầm non"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents mnBarAddHS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnBarListHS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnBarAddEatDay As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnBarReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents mnBarLogin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnBarQLUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnBarThuTien As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnBarTH As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnBarQL As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents DefaultSkin As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents timDongBoGio As System.Windows.Forms.Timer
    Friend WithEvents mnBarQLSuatAn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnBarDSLop As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnBarTK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SkinRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinRibbonGalleryBarItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents lblInFo As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents lblTimer As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
    Friend WithEvents mnBarDangKySD As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents mnBarDoiMatkhau As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TabControl As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents mnBarKhoanThu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents btnShow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit


End Class
