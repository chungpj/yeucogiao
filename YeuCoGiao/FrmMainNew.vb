Public Class FrmMainNew
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim dtTimer = GetTableDl("Select Getdate() t")
        If Not IsNothing(dtTimer) Then
            lblTimer.Caption = CDate(dtTimer.Rows(0)("t")).ToString("dd/MM/yyyy HH:mm:ss")
        End If
        If IDNguoiDung.ToString.Trim <> "" Then
            lblInFo.Caption = "Bản dựng: " & Build & "   Máy chủ: " & MayChu & "" & "   Máy làm việc: " & IDMay & " - " & My.Computer.Name & "   Người dùng: " & IDNguoiDung
        Else
            End
        End If
        timDongBoGio.Enabled = True
    End Sub
    Private Sub timDongBoGio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timDongBoGio.Tick
        Dim dtTimer = GetTableDl("Select Getdate() t")
        If Not IsNothing(dtTimer) Then
            lblTimer.Caption = CDate(dtTimer.Rows(0)("t")).ToString("dd/MM/yyyy HH:mm:ss")
        End If
        If IDNguoiDung.ToString.Trim <> "" Then
            lblInFo.Caption = "Bản dựng: " & Build & "   Máy chủ: " & MayChu & "" & "   Máy làm việc: " & My.Computer.Name & "   Người dùng: " & IDNguoiDung
        Else
            End
        End If
    End Sub

    Private Sub FrmMainNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmMainNew_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        lblInFo.Caption = ""
        lblTimer.Caption = ""
    End Sub
    Private Function OpenForm(ByVal ftype As Type) As Form
        For Each f In Me.MdiChildren
            If f.GetType() = ftype Then
                Return f
            End If
        Next
        Return Nothing
    End Function
    Private Sub mnBarDoiMatkhau_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnBarDoiMatkhau.ItemClick, mnBarQLUser.ItemClick, mnBarDangKySD.ItemClick, mnBarLogin.ItemClick, mnBarListHS.ItemClick, mnBarReport.ItemClick, mnBarQLSuatAn.ItemClick, mnBarAddEatDay.ItemClick, mnBarThuTien.ItemClick, mnBarDSLop.ItemClick, mnBarKhoanThu.ItemClick, mnBarAddHS.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Dim f As Form
        Select Case e.Item.Name
            Case mnBarDoiMatkhau.Name
                f = New frmDoiMatkhau
                f.ShowDialog()
            Case mnBarDangKySD.Name
                f = New frmDangKySD
                f.ShowDialog()
            Case mnBarQLUser.Name
                f = New frmDangKyTaiKhoan
                f.ShowDialog()
            Case mnBarLogin.Name
                f = New frmDangNhap
                f.ShowDialog()
            Case mnBarListHS.Name, mnBarAddHS.Name
                TileControl1.Hide()
                Dim frm = OpenForm(GetType(frmThemHS))
                If Not IsNothing(frm) Then
                    frm.Activate()
                Else
                    f = New frmThemHS()
                    f.MdiParent = Me
                    f.Show()
                End If
            Case mnBarAddEatDay.Name
                TileControl1.Hide()
                Dim frm = OpenForm(GetType(frmChamcong))
                If Not IsNothing(frm) Then
                    frm.Activate()
                Else
                    f = New frmChamcong()
                    f.MdiParent = Me
                    f.Show()
                End If
            Case mnBarQLSuatAn.Name
                TileControl1.Hide()
                Dim frm = OpenForm(GetType(frmTaoThangChamcong))
                If Not IsNothing(frm) Then
                    frm.Activate()
                Else
                    f = New frmTaoThangChamcong()
                    f.MdiParent = Me
                    f.Show()
                End If
            Case mnBarThuTien.Name
                TileControl1.Hide()
                Dim frm = OpenForm(GetType(frmThuTien))
                If Not IsNothing(frm) Then
                    frm.Activate()
                Else
                    f = New frmThuTien()
                    f.MdiParent = Me
                    f.Show()
                End If
            Case mnBarDSLop.Name
                f = New frmDSLop()
                f.ShowDialog()
            Case mnBarKhoanThu.Name
                f = New frmKhoanthu()
                f.ShowDialog()
        End Select
        Me.Cursor = Cursors.Default
    End Sub
End Class