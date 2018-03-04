Imports DevExpress.XtraLayout

Public Class frmNopHocPhi
    Private Sub frmNopHocPhi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private _Load As Boolean = False
    Private mahs As Integer
    Private Sua As Boolean
    Private Them As Boolean
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, keyData As System.Windows.Forms.Keys) As Boolean
        Dim obj As Object
        If TypeOf Me.ActiveControl Is LayoutControl Then
            obj = CType(Me.ActiveControl, LayoutControl).ActiveControl
        Else
            obj = Me.ActiveControl
        End If
        If obj.Parent Is txtSotien Then
            'định nghĩa lại nhập số 
            obj.Parent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
            obj.Parent.Properties.Mask.EditMask = "\d{0,15}"
        End If
        Select Case keyData
            Case Keys.Enter
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
                    _ReadOnly(True) : Return True
                End If
                Me.Close()
        End Select
        Return False
    End Function
    Private Sub _ReadOnly(ByVal t As Boolean)
        cboThang.ReadOnly = t
        cboNam.ReadOnly = t
        txtSotien.ReadOnly = t
        txtNoidung.ReadOnly = t
        If t Then
            txtSotien.BackColor = Color.White
            btnLuu.Enabled = False
            If Not Them AndAlso Not Sua Then
                'lúc load form/hủy thêm sửa
                txtSotien.Text = ""
                cboThang.SelectedItem = "Tháng " & Now.Month
                cboNam.SelectedItem = Now.Year
                txtNoidung.Text = ""
                btnXoa.Enabled = True
                btnThem.Enabled = True
                btnSua.Enabled = False
                btnLuu.Enabled = False
            End If
        End If
        If Them Then
            txtSotien.Text = ""
            txtNoidung.Text = ""
            cboThang.SelectedItem = "Tháng " & Now.Month
            cboNam.SelectedItem = Now.Year
            btnXoa.Enabled = False
            btnSua.Enabled = False
            btnLuu.Enabled = True
        ElseIf Sua Then
            btnXoa.Enabled = False
            btnThem.Enabled = False
            btnLuu.Enabled = True
        End If
    End Sub
    Public Sub New(ByVal idHS As Integer)
        InitializeComponent()
        mahs = idHS
        _Load = False
        Dim nam = Now.Year
        For i = nam - 5 To nam
            cboNam.Properties.Items.Add(i)
        Next
        cboNam.SelectedItem = Now.Year
        cboThang.SelectedItem = "Tháng " & Now.Month
        Dim dt = GetTableDl("SELECT Row_Number()Over(Order By hs.id) stt, CONVERT(VARCHAR(10),hs.ngaysinh,103) as ngaysinhhs, l.tenlop as tenlop, * FROM Hocsinh hs join Lop l on hs.malop = l.id where hs.id = '" & mahs & "'")
        lbHoten.Text = "Họ tên: " + dt.Rows(0)("hoten")
        lbLop.Text = "Lớp: " + dt.Rows(0)("tenlop")
        lbNgaysinh.Text = "Ngày sinh: " + dt.Rows(0)("ngaysinhhs").ToString()
        If dt.Rows(0)("gioitinh") = True Then
            lbGioitinh.Text = "Giới tính: Nam"
        Else
            lbGioitinh.Text = "Giới tính: Nữ"
        End If
        _Load = True
        dtgcDSHS.DataSource = GetTableDl("select Row_Number()Over(Order By id) stt,CONVERT(VARCHAR(10), nopchothang,103) as ngaysinhhs,* from Thucthu where mahocsinh = '" & mahs & "'")
        _ReadOnly(True)
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Sua = False
        Them = True
        _ReadOnly(False)
        txtSotien.Focus()
    End Sub

    Private Sub dtgvDSHS_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles dtgvDSHS.RowCellClick
        If Them = True OrElse Sua = True Then Return
        cboThang.SelectedItem = dtgvDSHS.GetFocusedRowCellValue("ngaysinhhs").ToString().Substring(2, 4)
        cboNam.ReadOnly = True
        cboThang.ReadOnly = True
        txtNoidung.EditValue = dtgvDSHS.GetRowCellValue(e.RowHandle, "noidung").ToString()
        txtSotien.Text = dtgvDSHS.GetRowCellValue(e.RowHandle, "sotien").ToString()
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtSotien.Text = "" Then
            MsgBoxF("Bạn chưa chọn học sinh để sửa!", MsgType.Error_)
            Return
        Else
            Sua = True
            _ReadOnly(False)
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        Dim thang As Integer = cboThang.Text.Replace("Tháng", "").Trim
        If txtSotien.Text = "" OrElse txtNoidung.Text = "" Then
            MsgBoxF("Vui lòng nhập đầy đủ thông tin.", MsgType.Error_)
            Return
        Else
            If Sua = True Then
                If ThucThiSQL("UPDATE thucthu SET sotien = '" & txtSotien.Text & "', noidung = N'" & txtNoidung.Text & "' WHERE id = '" & dtgvDSHS.GetFocusedRowCellValue("id") & "'") Then
                    MsgBoxF("Lưu thành công!", MsgType.Information)
                    Dim dt2 = GetTableDl("select Row_Number()Over(Order By id) stt,CONVERT(VARCHAR(10), nopchothang,103) as ngaysinhhs,* from Thucthu where mahocsinh = '" & mahs & "'")
                    dtgcDSHS.DataSource = dt2
                Else
                    MsgBoxF("Lỗi khi lưu!", MsgType.Error_)
                End If
            Else
                If ThucThiSQL("INSERT INTO thucthu (mahocsinh, sotien, nopchothang, ngaynop, noidung) VALUES ( '" & mahs & "','" & txtSotien.Text & "','01-" & thang & "-" & cboNam.EditValue & "', '" & Date.Now & "',N'" & txtNoidung.Text & "')") Then
                    MsgBoxF("Lưu thành công!", MsgType.Information)
                    Dim dt2 = GetTableDl("select Row_Number()Over(Order By id) stt,CONVERT(VARCHAR(10), nopchothang,103) as ngaysinhhs,* from Thucthu where mahocsinh = '" & mahs & "'")
                    dtgcDSHS.DataSource = dt2

                Else
                    MsgBoxF("Lỗi khi lưu!", MsgType.Error_)
                End If
            End If
        End If

        Them = False
        Sua = False
        _ReadOnly(True)
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If MsgBoxF("Bạn có chắc chắn xóa?", MsgType.YesNo) = MsgBoxResult.Yes Then
            dtgvDSHS.DeleteSelectedRows()
            If ThucThiSQL("DELETE FROM thucthu WHERE id = '" & dtgvDSHS.GetFocusedRowCellValue("id") & "'") Then
                MsgBoxF("Xóa thành công!", MsgType.Information)
            Else
                MsgBoxF("Lỗi khi xóa!", MsgType.Error_)
            End If
            Dim dt2 = GetTableDl("select Row_Number()Over(Order By id) stt,CONVERT(VARCHAR(10), nopchothang,103) as ngaysinhhs,* from Thucthu where mahocsinh = '" & mahs & "'")
            dtgcDSHS.DataSource = dt2
        End If
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        If Sua = True Then
            MsgBox("đang sửa", MsgType.Error_)
        ElseIf Them = True Then
            MsgBox("thêm mới", MsgType.Error_)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtSotien_Validated(sender As System.Object, e As System.EventArgs) Handles txtSotien.Validated
        txtSotien.Text = FormatNumber(txtSotien.Text, 2)
    End Sub
End Class