Imports DevExpress.XtraLayout

Public Class frmThemHS
    Private Sua As Boolean
    Private Them As Boolean
#Region "fuction"
    Private Sub _readOnly(ByVal t As Boolean)
        txtDiachi.ReadOnly = t
        txtHoten.ReadOnly = t
        txtNgayDK.ReadOnly = t
        txtNgaysinh.ReadOnly = t
        txtTencha.ReadOnly = t
        txtTenme.ReadOnly = t
        txtSDTcha.ReadOnly = t
        txtSDTme.ReadOnly = t
        txtMaHS.ReadOnly = t
        If t Then
            txtDiachi.BackColor = Color.White
            txtHoten.BackColor = Color.White
            txtNgayDK.BackColor = Color.White
            txtNgaysinh.BackColor = Color.White
            txtTencha.BackColor = Color.White
            txtTenme.BackColor = Color.White
            txtSDTcha.BackColor = Color.White
            txtSDTme.BackColor = Color.White
            txtID.BackColor = Color.White
            txtMaHS.BackColor = Color.White
            If Not Them AndAlso Not Sua Then
                _Cleartext()
                btnThem.Enabled = True
                btnSua.Enabled = True
                btnXoa.Enabled = True
                btnLuu.Enabled = False
            End If
        End If
        If Them Then
            _Cleartext() : txtHoten.Focus()
            btnSua.Enabled = False
            btnXoa.Enabled = False
            btnLuu.Enabled = True
        ElseIf Sua Then
            txtHoten.Focus() : txtHoten.SelectAll()
            btnThem.Enabled = False
            btnXoa.Enabled = False
            btnLuu.Enabled = True
        End If
    End Sub
    Private Sub _Cleartext()
        txtHoten.Text = ""
        txtNgaysinh.Text = ""
        txtSDTcha.Text = ""
        txtSDTme.Text = ""
        txtTencha.Text = ""
        txtTenme.Text = ""
        txtDiachi.Text = ""
        txtID.Text = ""
        txtMaHS.Text = ""
        txtNgayDK.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim obj As Object
        If TypeOf Me.ActiveControl Is LayoutControl Then
            obj = CType(Me.ActiveControl, LayoutControl).ActiveControl
        Else
            obj = Me.ActiveControl
        End If
        If obj.Parent Is txtNgaysinh AndAlso
                    NhapNgayF(keyData, obj.Parent, obj.Parent) Then Return True
        If obj.Parent Is txtSDTme OrElse obj.Parent Is txtSDTcha Then
            obj.Parent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            obj.Parent.Properties.Mask.EditMask = "\d{0,11}"
            Return False
        End If

        Select Case keyData
            Case Keys.Enter

                If obj Is cboGioitinh Then
                    txtNgaysinh.Focus()
                    Return True
                End If
                If obj Is grlupLop Then
                    txtTencha.Focus()
                    Return True
                End If
            Case Keys.F2
                btnLuu.PerformClick()
                Return True
            Case Keys.F3
                btnThem.PerformClick()
                Return True
            Case Keys.F4
                btnSua.PerformClick()
                Return True
            Case Keys.F7
                btnXoa.PerformClick()
                Return True
            Case Keys.Escape
                If Them OrElse Sua Then
                    Them = False : Sua = False
                    _readOnly(True)
                    Return True
                End If
                Me.Close()
        End Select
        Return False
    End Function
    Private Sub LoadDL()
        Dim dt2 = GetTableDl(" SET DATEFORMAT dmy select (CASE WHEN gioiTinh='1' THEN 'Nam' ELSE N'Nữ' END) AS gioitinh, tenlop, malop, a.id, mahocsinh,hoten,hotencha,sdtcha,hotenme,sdtme,ngaydangky,ngaysinh,diachi from Hocsinh a join Lop b on a.malop=b.id")
        dtgcDSHS.DataSource = dt2
    End Sub
#End Region
#Region "Events"


    Private Sub frmThemHS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNgayDK.Text = Now.Date.ToString("dd/MM/yyyy")
        Dim dt = GetTableDl("select * from [Lop]")
        grlupLop.Properties.DataSource = dt
        grlupLop.Properties.ValueMember = "id"
        grlupLop.Properties.DisplayMember = "tenlop"
        grlupLop.ItemIndex = 0

        LoadDL()
        _readOnly(True)
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnDangky_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Them = True
        _readOnly(False)

    End Sub

    Private Sub dtgvDSHS_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles dtgvDSHS.RowCellClick
        If Them = True OrElse Sua = True Then Return

        txtID.Text = dtgvDSHS.GetRowCellValue(e.RowHandle, "id").ToString()
        txtHoten.Text = dtgvDSHS.GetRowCellValue(e.RowHandle, "hoten").ToString()
        If dtgvDSHS.GetRowCellValue(e.RowHandle, "gioitinh") = "Nữ" Then
            cboGioitinh.SelectedIndex = 0
        Else
            cboGioitinh.SelectedIndex = 1
        End If
        txtNgayDK.Text = CDate(dtgvDSHS.GetRowCellValue(e.RowHandle, "ngaydangky")).ToString("dd/MM/yyyy")
        txtNgaysinh.Text = CDate(dtgvDSHS.GetRowCellValue(e.RowHandle, "ngaysinh")).ToString("dd/MM/yyyy")
        txtSDTcha.Text = dtgvDSHS.GetRowCellValue(e.RowHandle, "sdtcha")
        txtSDTme.Text = dtgvDSHS.GetRowCellValue(e.RowHandle, "sdtme").ToString()
        txtTencha.Text = dtgvDSHS.GetRowCellValue(e.RowHandle, "hotencha").ToString()
        txtTenme.Text = dtgvDSHS.GetRowCellValue(e.RowHandle, "hotenme").ToString()
        grlupLop.EditValue = dtgvDSHS.GetRowCellValue(e.RowHandle, "malop").ToString()
        txtDiachi.Text = dtgvDSHS.GetRowCellValue(e.RowHandle, "diachi").ToString()
        txtMaHS.Text = dtgvDSHS.GetRowCellValue(e.RowHandle, "mahocsinh").ToString()
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtHoten.Text = "" OrElse txtNgaysinh.Text = "" OrElse txtDiachi.Text = "" Then
            MsgBoxF("Vui lòng nhập đầy đủ thông tin.", MsgType.Error_)
            Return
        Else
            If (txtTencha.Text = "" AndAlso txtSDTcha.Text = "") AndAlso (txtSDTme.Text = "" AndAlso txtTenme.Text = "") Then
                MsgBoxF("Vui lòng nhập đầy đủ thông tin cha hoặc mẹ.", MsgType.Error_)
                Return
            Else
                If CDate(txtNgaysinh.Text) >= CDate(txtNgayDK.Text) Then
                    MsgBoxF("Ngày sinh không được lớn hơn ngày hiện tại.", MsgType.Error_)
                    txtNgaysinh.Focus() : txtNgaysinh.SelectAll()
                    Return
                Else

                    If Sua = True Then
                        If ThucThiSQL("UPDATE Hocsinh SET  Hoten=N'" & txtHoten.Text & "', Ngaysinh='" & txtNgaysinh.Text & "',Gioitinh= N'" & IIf(cboGioitinh.SelectedIndex = 1, 1, 0) & "',hotencha=N'" & txtTencha.Text & "',SDTCha='" & txtSDTcha.Text.Trim() & "',hotenme=N'" & txtTenme.Text & "',SDTMe='" & txtSDTme.Text.Trim() & "',NgayDangky='" & txtNgayDK.Text & "',malop='" & grlupLop.EditValue & "',Diachi=N'" & txtDiachi.Text & "',mahocsinh=N'" & txtMaHS.Text &
                                      "' WHERE id= '" & txtID.Text & "'") Then
                            MsgBoxF("Lưu thành công!", MsgType.Information)
                            LoadDL()

                        Else
                            MsgBoxF("Lỗi khi lưu!", MsgType.Error_)

                        End If
                    Else
                        If ThucThiSQL("INSERT INTO Hocsinh VALUES ( '" & grlupLop.EditValue & "','" & txtMaHS.Text & "',N'" & txtHoten.Text & "','" & txtNgaysinh.Text & "',N'" & IIf(cboGioitinh.SelectedIndex = 1, 1, 0) & "',N'" & txtTencha.Text & "','" & txtSDTcha.Text.Trim() & "',N'" & txtTenme.Text & "','" & txtSDTme.Text.Trim() & "',N'" & txtDiachi.Text & "','" & txtNgayDK.Text & "')") Then
                            MsgBoxF("Lưu thành công!", MsgType.Information)
                            LoadDL()

                        Else
                            MsgBoxF("Lỗi khi lưu!", MsgType.Error_)
                        End If
                    End If
                End If

            End If
            Them = False
            Sua = False
            _readOnly(True)
        End If

    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtID.Text = GetTableDl("select mahocsinh from chamcong").ToString() OrElse txtID.Text = GetTableDl("select mahocsinh from thucthu").ToString() OrElse txtID.Text = GetTableDl("select mahocsinh from hoadon").ToString() Then
            MsgBoxF("Học sinh này đã có chấm công hoặc chi phí thu.", MsgType.Error_)
        Else
            If MsgBoxF("Bạn có chắc chắn xóa?", MsgType.YesNo) = MsgBoxResult.Yes Then
                dtgvDSHS.DeleteSelectedRows()
                If ThucThiSQL("DELETE FROM hocsinh WHERE id = '" & txtID.Text & "'") Then
                    MsgBoxF("Xóa thành công!", MsgType.Information)
                Else
                    MsgBoxF("Lỗi khi xóa!", MsgType.Error_)
                End If
                LoadDL()
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click

        If txtID.Text = "" Then
            MsgBoxF("Bạn chưa chọn học sinh để sửa!", MsgType.Error_)
            Return
        Else
            Sua = True
            _readOnly(False)
        End If
    End Sub

    Private Sub txtHoten_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtHoten.Validating
        txtHoten.Text = My.Application.Culture.TextInfo.ToTitleCase(txtHoten.Text.ToLower)
    End Sub

    Private Sub txtTencha_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTencha.Validating
        txtTencha.Text = My.Application.Culture.TextInfo.ToTitleCase(txtTencha.Text.ToLower)
    End Sub

    Private Sub txtTenme_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtTenme.Validating
        txtTenme.Text = My.Application.Culture.TextInfo.ToTitleCase(txtTenme.Text.ToLower)
    End Sub

    Private Sub txtDiachi_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDiachi.Validating
        txtDiachi.Text = My.Application.Culture.TextInfo.ToTitleCase(txtDiachi.Text.ToLower)
    End Sub

    Private Sub btnToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToExcel.Click
        Me.Cursor = Cursors.WaitCursor
        ToExcell(dtgvDSHS)
        Me.Cursor = Cursors.Default
    End Sub
#End Region
End Class