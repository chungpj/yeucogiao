Imports DevExpress.XtraLayout

Public Class frmDSLop

    Private Sua As Boolean
    Private Them As Boolean
    Private Sub _readOnly(ByVal t As Boolean)
        txtTenlop.ReadOnly = t
        If t Then
            txtTenlop.BackColor = Color.White
            If Not Them AndAlso Not Sua Then
                txtId.Text = "" : txtTenlop.Text = ""
                btnThem.Enabled = True
                btnSua.Enabled = True
                btnXoa.Enabled = True
                btnLuu.Enabled = False
            End If
        End If
        If Them Then
            txtId.Text = ""
            txtTenlop.Text = "" : txtTenlop.Focus()
            btnSua.Enabled = False
            btnXoa.Enabled = False
            btnLuu.Enabled = True
        ElseIf Sua Then
            txtTenlop.Focus() : txtTenlop.SelectAll()
            btnThem.Enabled = False
            btnXoa.Enabled = False
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
                    _readOnly(True)
                    Return True
                End If
                Me.Close()
        End Select
        Return False
    End Function

    Private Sub frmDSLop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt = GetTableDl("Select Row_Number()Over(Order By lop.id) stt, Lop.id, Lop.tenlop, COUNT(Hocsinh.id) as sohocsinh from [Lop] left join Hocsinh on Lop.id = Hocsinh.malop group by Lop.id, Lop.tenlop")
        dtgcDSLop.DataSource = dt
        _readOnly(True)
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        Them = True
        _readOnly(False)
    End Sub

    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        If txtTenlop.Text = "" Then
            MsgBoxF("Vui lòng nhập đầy đủ thông tin.", MsgType.Error_)
            Return
        Else
            If Sua Then
                If ThucThiSQL("update lop set tenlop = N'" & txtTenlop.Text & "' where id = '" & txtId.Text & "'") Then
                    MsgBoxF("Lưu thành công!", MsgType.Information)
                    Dim dt2 = GetTableDl("Select Row_Number()Over(Order By lop.id) stt, Lop.id, Lop.tenlop, COUNT(Hocsinh.id) as sohocsinh from [Lop] left join Hocsinh on Lop.id = Hocsinh.malop group by Lop.id, Lop.tenlop")
                    dtgcDSLop.DataSource = dt2
                Else
                    MsgBoxF("Lỗi khi lưu!", MsgType.Error_)
                    Return
                End If
            Else
                If GetTableDl("SELECT tenlop FROM [lop] WHERE tenlop LIKE N'" & txtTenlop.Text & "'").Rows.Count > 0 Then
                    MsgBoxF("Tên lớp đã tồn tại!", MsgType.Error_)
                    Return
                Else
                    If ThucThiSQL("INSERT INTO lop (tenlop, trangthai) VALUES (N'" & txtTenlop.Text & "', 1)") Then
                        MsgBoxF("Lưu thành công!", MsgType.Information)
                        Dim dt2 = GetTableDl("Select Row_Number()Over(Order By lop.id) stt, Lop.id, Lop.tenlop, COUNT(Hocsinh.id) as sohocsinh from [Lop] left join Hocsinh on Lop.id = Hocsinh.malop group by Lop.id, Lop.tenlop")
                        dtgcDSLop.DataSource = dt2
                        btnLuu.Enabled = False
                        btnXoa.Enabled = True
                        btnSua.Enabled = True
                    Else
                        MsgBoxF("Lỗi khi lưu!", MsgType.Error_)
                        Return
                    End If
                End If
            End If
        End If
        Them = False
        Sua = False
        _readOnly(True)
    End Sub

    Private Sub dtgvDSLop_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles dtgvDSLop.RowCellClick
        If Them OrElse Sua Then Return
        txtId.Text = dtgvDSLop.GetRowCellValue(e.RowHandle, "id").ToString()
        txtTenlop.Text = dtgvDSLop.GetRowCellValue(e.RowHandle, "tenlop").ToString()
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If dtgvDSLop.GetFocusedRowCellValue("sohocsinh") > 0 Then
            MsgBoxF("Lớp này đã tồn tại học sinh, Yêu cầu xóa học sinh có trong lớp trước khi thao tác.", MsgType.Error_)
            Return
        Else
            If MsgBoxF("Bạn có chắc chắn xóa lớp: " & txtTenlop.Text & " ?", MsgType.YesNo) = MsgBoxResult.Yes Then
                If ThucThiSQL("DELETE FROM [lop] WHERE id = '" & txtId.Text & "'") Then
                    MsgBoxF("Xóa thành công!", MsgType.Information)
                Else
                    MsgBoxF("Lỗi khi xóa!", MsgType.Error_)
                End If
                Dim dt2 = GetTableDl("Select Row_Number()Over(Order By lop.id) stt, Lop.id, Lop.tenlop, COUNT(Hocsinh.id) as sohocsinh from [Lop] left join Hocsinh on Lop.id = Hocsinh.malop group by Lop.id, Lop.tenlop")
                dtgcDSLop.DataSource = dt2
            End If
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If txtId.Text = "" Then
            MsgBoxF("Bạn chưa chọn lớp để sửa!", MsgType.Error_)
            Return
        Else
            Sua = True
            _readOnly(True)
        End If
    End Sub
End Class