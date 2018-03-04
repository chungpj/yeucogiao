Imports DevExpress.XtraLayout

Public Class frmKhoanthu

    Private Sua As Boolean
    Private Them As Boolean
    Private Sub _ReadOnly(ByVal t As Boolean)
        txtTen.ReadOnly = t
        If t Then
            txtTen.BackColor = Color.White
            btnLuu.Enabled = False
            If Not Them AndAlso Not Sua Then
                'lúc load form/hủy thêm sửa
                txtTen.Text = ""
                btnXoa.Enabled = True
                btnThem.Enabled = True
                btnSua.Enabled = False
                btnLuu.Enabled = False
            End If
        End If
        If Them Then
            txtTen.Focus()
            btnXoa.Enabled = False
            btnSua.Enabled = False
            btnLuu.Enabled = True
        ElseIf Sua Then
            txtTen.Focus() : txtTen.SelectAll()
            btnXoa.Enabled = False
            btnThem.Enabled = False
            btnLuu.Enabled = True
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim obj As Object
        If TypeOf Me.ActiveControl Is LayoutControl Then
            obj = CType(Me.ActiveControl, LayoutControl).ActiveControl
        Else
            obj = Me.ActiveControl
        End If
        If obj.Parent Is txtTen AndAlso
                    NhapNgayF(keyData, obj.Parent, obj.Parent) Then Return True
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
                    'hủy thêm/sửa
                    _ReadOnly(True) : Return True
                End If
                Me.Close()
        End Select
        Return False
    End Function

    Private Sub frmKhoanthu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt = GetTableDl("Select Row_Number()Over(Order By id) stt, * FROM Khoannop")
        dtgvDs.DataSource = dt
        _ReadOnly(True)
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Sua = False : Them = True
        _ReadOnly(False)
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtTen.Text = "" Then
            MsgBoxF("Bạn chưa chọn khoản thu để sửa!", MsgType.Error_)
            Return
        Else
            Sua = True
            _ReadOnly(False)
        End If
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtTen.Text = "" Then
            MsgBoxF("Vui lòng nhập đầy đủ thông tin.", MsgType.Error_)
            Return
        Else
            If Sua = True Then
                If ThucThiSQL("update Khoannop set ten = N'" & txtTen.Text & "' where id = '" & dtgcDs.GetFocusedRowCellValue("id") & "'") Then
                    MsgBoxF("Lưu thành công!", MsgType.Information)
                    Dim dt2 = GetTableDl("Select Row_Number()Over(Order By id) stt, * FROM Khoannop")
                    dtgvDs.DataSource = dt2
                Else
                    MsgBoxF("Lỗi khi lưu!", MsgType.Error_)
                    Return
                End If
            Else
                If ThucThiSQL("INSERT INTO Khoannop (ten, trangthai) VALUES (N'" & txtTen.Text & "', 1)") Then
                    MsgBoxF("Lưu thành công!", MsgType.Information)
                    Dim dt2 = GetTableDl("Select Row_Number()Over(Order By id) stt, * FROM Khoannop")
                    dtgvDs.DataSource = dt2
                Else
                    MsgBoxF("Lỗi khi lưu!", MsgType.Error_)
                    Return
                End If
            End If
        End If
        Them = False
        Sua = False
        _ReadOnly(True)
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If GetTableDl("select COUNT(id) from Hoadon where idkhoannop = '" & dtgcDs.GetFocusedRowCellValue("id") & "'").Rows.Count > 0 Then
            MsgBoxF("Khoản thu này đã được sử dụng, không thể xóa được!", MsgType.Error_) : Return
        Else
            If MsgBoxF("Bạn có chắc chắn xóa?", MsgType.YesNo) = MsgBoxResult.Yes Then
                If ThucThiSQL("DELETE FROM [Khoannop] WHERE id = '" & dtgcDs.GetFocusedRowCellValue("id") & "'") Then
                    MsgBoxF("Xóa thành công!", MsgType.Information)
                Else
                    MsgBoxF("Lỗi khi xóa!", MsgType.Error_)
                End If
                Dim dt2 = GetTableDl("Select Row_Number()Over(Order By lop.id) stt, Lop.id, Lop.tenlop, COUNT(Hocsinh.id) as sohocsinh from [Lop] left join Hocsinh on Lop.id = Hocsinh.malop group by Lop.id, Lop.tenlop")
                dtgvDs.DataSource = dt2
            End If
        End If
    End Sub

    Private Sub dtgcDs_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles dtgcDs.RowCellClick
        If Them = True OrElse Sua = True Then Return
        'nếu ko ô txtId -> mi có thể dùng txtId.Tag = ... cũng đc, 1 tên/1 Id <-> 1 text/1Tag nếu muốn
        'txtId.Text = dtgvDSLop.GetRowCellValue(e.RowHandle, "id").ToString()
        txtTen.Text = dtgcDs.GetRowCellValue(e.RowHandle, "ten").ToString()
    End Sub

    Private Sub btnThoát_Click(sender As System.Object, e As System.EventArgs) Handles btnThoát.Click
        Me.Close()
    End Sub
End Class