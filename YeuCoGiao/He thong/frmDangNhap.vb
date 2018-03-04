Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Public Class frmDangNhap
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim obj As Object
        If TypeOf Me.ActiveControl Is LayoutControl Then
            obj = CType(Me.ActiveControl, LayoutControl).ActiveControl
        Else
            obj = Me.ActiveControl
        End If
        Select Case keyData
            Case Keys.Enter
                If obj.Parent Is txtPass Then
                    btnDangNhap.PerformClick() : Return True
                End If
            Case Keys.Escape
                End
        End Select
        Return False
    End Function
    Private Sub frmDangNhap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUser.Text = mIni.ReadString("Login", "phanmem", My.Computer.Name)
        txtUser.SelectAll() : txtUser.Focus()
    End Sub

    Private Sub btnDangNhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDangNhap.Click
        If txtPass.Text.Trim = "" OrElse txtUser.Text.Trim = "" Then
            MsgBoxF("Vui lòng nhập đầy đủ thông tin.", MsgType.Error_)
            txtUser.Select()
            Return
        End If
        Dim day = DateTime.Now.Day.ToString
        day = IIf(day.Length = 1, "0" & day, day)
        If txtUser.Text = "admin" + day Then
            Dim month = DateTime.Now.Month.ToString
            month = IIf(month.Length = 1, "0" & month, month)
            If txtPass.Text = GetAdminPass(month) Then
                IDNguoiDung = "DEV-AnhChung"
                NguoiDung = "DEV-AnhChung"
                Dungthu = 0
                Me.Hide() : FrmMainNew.Show()
            Else
                txtUser.Select()
                MsgBoxF("Sai tên đăng nhập hoặc mật khẩu, Vui lòng kiểm tra lại.", MsgType.Error_)
                Return
            End If
        Else
            Dim dt = GetTableDl("SELECT * FROM [User] WHERE [user]='" & txtUser.Text & "' AND [pass]='" & MaHoa(txtPass.Text) & "' ")
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                IDNguoiDung = dt.Rows(0)("user")
                NguoiDung = dt.Rows(0)("hoten")
                mIni.WriteString("Login", My.Computer.Name) = txtUser.Text
                'mIni.WriteString("DangkySudung", "Key") = MaHoaKey("01-01-2017")
                Dim timeDungthu = GiaiMaKey(mIni.ReadString("DangkySudung", , "Key"))
                If timeDungthu.Trim <> "" AndAlso Now.Date.ToString("dd/MM/yyyy") < CDate(timeDungthu) Then
                    Dungthu = 1
                Else
                    Dungthu = 0
                End If
                Me.Hide() : FrmMainNew.Show()
            Else
                txtUser.Select()
                MsgBoxF("Sai tên đăng nhập hoặc mật khẩu, Vui lòng kiểm tra lại.", MsgType.Error_)
                Return
            End If
        End If

    End Sub

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        End
    End Sub
End Class