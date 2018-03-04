Imports DevExpress.XtraLayout

Public Class frmDangKyTaiKhoan
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim obj As Object
        If TypeOf Me.ActiveControl Is LayoutControl Then
            obj = CType(Me.ActiveControl, LayoutControl).ActiveControl
        Else
            obj = Me.ActiveControl
        End If
        Select Case keyData
            Case Keys.Enter

            Case Keys.Escape
                If Not Sua AndAlso txtTenDN.Enabled Then
                    edittext(False)
                    txtHoTen.Text = ""
                    txtPass.Text = ""
                    txtTenDN.Text = ""
                    cboQuyen.Text = ""
                    btnSua.Enabled = True
                    btnXoa.Enabled = True
                    Return True
                ElseIf Sua Then
                    edittext(False)
                    txtHoTen.Text = ""
                    txtPass.Text = ""
                    txtTenDN.Text = ""
                    cboQuyen.Text = ""
                    btnThem.Enabled = True
                    btnXoa.Enabled = True
                    Return True
                End If
                If Not Sua AndAlso Not txtTenDN.Enabled Then
                    Me.Close() : Return True
                End If
                End
        End Select
        Return False
    End Function
    Private Sub edittext(ByVal en As Boolean)
        txtHoTen.Enabled = en
        txtPass.Enabled = en
        txtTenDN.Enabled = en
        cboQuyen.Enabled = en
    End Sub
    Private Sua As Boolean

    Private Sub frmDangKyTaiKhoan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim dt = GetTableDl("select* from [user] where [level] >= (select [level] from [user] where [user]='" & IDNguoiDung & "')")
        dtgcDSNV.DataSource = dt
        edittext(False)
    End Sub

    Private Sub dtgvDSNV_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles dtgvDSNV.RowCellClick
        txtHoTen.Text = dtgvDSNV.GetRowCellValue(e.RowHandle, "Hoten").ToString()
        txtTenDN.Text = dtgvDSNV.GetRowCellValue(e.RowHandle, "user").ToString()
        cboQuyen.Text = dtgvDSNV.GetRowCellValue(e.RowHandle, "level").ToString()
        txtTenDN.Tag = dtgvDSNV.GetRowCellValue(e.RowHandle, "user").ToString()
    End Sub

    Private Sub btnThem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnThem.Click
        edittext(True)
        txtHoTen.Text = ""
        txtPass.Text = ""
        txtTenDN.Text = ""
        cboQuyen.Text = ""
    End Sub

    Private Sub btnLuu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLuu.Click
        If Sua = True Then
            If txtTenDN.Text = "" OrElse txtPass.Text = "" Then
                MsgBoxF("Vui lòng nhập đầy đủ thông tin.", MsgType.Error_)
            Else
                If ThucThiSQL("UPDATE [USER] SET  [USER]='" & txtTenDN.Text & "', [PASS]='" & MaHoa(txtPass.Text) & "',HOTEN= N'" & txtHoTen.Text & "',[LEVEL]='" & cboQuyen.Text & "' WHERE [USER]= '" & txtTenDN.Tag & "'") Then
                    MsgBoxF("Lưu thành công!", MsgType.Information)
                    Dim dt = GetTableDl("select* from [user] where [level] >= (select [level] from [user] where [user]='" & IDNguoiDung & "')")
                    dtgcDSNV.DataSource = dt
                    edittext(False)
                Else
                    MsgBoxF("Lỗi khi lưu!", MsgType.Error_)
                End If
            End If
        Else
            If txtPass.Text = "" OrElse txtTenDN.Text = "" OrElse cboQuyen.Text = "" Then
                MsgBoxF("Vui lòng nhập đầy đủ thông tin.", MsgType.Error_)
            Else
                If GetTableDl("select* from [user] where [user] = '" & txtTenDN.Text & "'").Rows.Count > 0 Then
                    MsgBoxF("Tên đăng nhập đã tồn tại.", MsgType.Error_)
                    txtTenDN.Focus() : txtTenDN.SelectAll()
                    Return
                Else
                    If ThucThiSQL("INSERT INTO [USER] VALUES ('" & txtTenDN.Text & "','" & MaHoa(txtPass.Text) & "',N'" & txtHoTen.Text & "','" & cboQuyen.Text & "')") Then
                        MsgBoxF("Lưu thành công!", MsgType.Information)
                        Dim dt = GetTableDl("select* from [user] where [level] >= (select [level] from [user] where [user]='" & IDNguoiDung & "')")
                        dtgcDSNV.DataSource = dt
                        edittext(False)
                    Else
                        MsgBoxF("Lỗi khi lưu!", MsgType.Error_)
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnXoa.Click
        If MsgBoxF("Bạn có chắc chắn xóa?", MsgType.YesNo) = MsgBoxResult.Yes Then
            dtgvDSNV.DeleteSelectedRows()
            If CnDLServer(dtgcDSNV.DataSource, "select* from [user] ") Then
                MsgBoxF("Xóa thành công!", MsgType.Information)

            Else
                MsgBoxF("Lỗi khi xóa!", MsgType.Error_)
            End If
            Dim dt = GetTableDl("select* from [user] where [level] >= (select [level] from [user] where [user]='" & IDNguoiDung & "')")
            dtgcDSNV.DataSource = dt
        End If
    End Sub

    Private Sub btnThoat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub

    Private Sub btnSua_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSua.Click
        If txtTenDN.Text = "" Then
            MsgBoxF("Bạn chưa chọn thông tin người dùng để sửa!", MsgType.Error_)
            Return
        Else
            edittext(True)
            Sua = True
        End If
    End Sub
End Class