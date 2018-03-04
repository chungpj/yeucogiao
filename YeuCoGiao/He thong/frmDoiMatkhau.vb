Imports DevExpress.XtraLayout

Public Class frmDoiMatkhau
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim obj As Object
        If TypeOf Me.ActiveControl Is LayoutControl Then
            obj = CType(Me.ActiveControl, LayoutControl).ActiveControl
        Else
            obj = Me.ActiveControl
        End If
        Select Case keyData
            Case Keys.Enter
                If obj.Parent Is txtpassnew2 Then
                    btnLuu.PerformClick() : Return True
                End If
            Case Keys.F2
                btnLuu.PerformClick() : Return True
            Case Keys.Escape
                btnThoat.PerformClick() : Return True
        End Select
        Return False
    End Function
    Private Sub frmDoiMatkhau_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtuser.Text = IDNguoiDung
    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If txtpassnew.Text.Trim <> txtpassnew2.Text.Trim Then
            MsgBoxF("Vui lòng nhập lại mật khẩu giống mật khẩu đã nhập", MsgType.Error_)
            Return
        End If
        Dim dt = GetTableDl("SELECT * FROM [User] WHERE [user]='" & txtuser.Text & "' AND [pass]='" & MaHoa(txtpassold.Text) & "' ")
        If IsNothing(dt) OrElse dt.Rows.Count = 0 Then
            MsgBoxF("Người dùng này không tồn tại, Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu.", MsgType.Error_)
            Return
        End If
        If ThucThiSQL("UPDATE [User] SET [pass]='" & MaHoa(txtpassnew.Text) & "' WHERE [user]='" & txtuser.Text & "'") Then
            MsgBoxF("Lưu mật khẩu thành công.", MsgType.Information)
        Else
            MsgBoxF("Có lỗi xảy ra, Đổi mật khẩu thất bại.", MsgType.Error_)
        End If
    End Sub
End Class