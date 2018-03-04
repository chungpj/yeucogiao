Imports DevExpress.XtraLayout

Public Class frmDangKySD
    Private isadmin As Boolean = False
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim obj As Object
        If TypeOf Me.ActiveControl Is LayoutControl Then
            obj = CType(Me.ActiveControl, LayoutControl).ActiveControl
        Else
            obj = Me.ActiveControl
        End If
        If obj.Parent Is txtDenngay AndAlso
                    NhapNgayF(keyData, obj.Parent, obj.Parent) Then Return True
        Select Case keyData
            Case Keys.Enter                
            Case Keys.Escape
                Me.Close()
        End Select
        Return False
    End Function
    Private Sub frmDangKySD_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtTungay.Text = Now.Date.ToString("dd/MM/yyyy")
        Dim dt = GetTableDl("SELECT * FROM [User] WHERE [user]='" & IDNguoiDung & "' AND [level]='0' ")
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            isadmin = True
            lciSinhcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            lciSinhcode.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Me.Close()

    End Sub

    Private Sub btnDangky_Click(sender As Object, e As EventArgs) Handles btnDangky.Click
        If txtDenngay.Text.Trim = "" Then
            MsgBoxF("Vui lòng nhập đầy đủ thông tin.", MsgType.Error_)
            txtDenngay.Focus()
            Return
        End If
        If CDate(txtTungay.Text.ToString()) > CDate(txtDenngay.Text.ToString()) Then
            MsgBoxF("Ngày kết thúc phải lớn hơn ngày bắt đầu.", MsgType.Error_)
            txtDenngay.Focus() : txtDenngay.SelectAll()
            Return
        End If

        If isadmin Then
            mIni.WriteString("DangkySudung", "Key") = MaHoaKey(txtDenngay.Text.ToString())
            MsgBoxF("Đăng ký thành công", MsgType.Information)
        Else
            If txtCode.Text.Trim = "" Then
                MsgBoxF("Vui lòng nhập đầy đủ thông tin.", MsgType.Error_)
                txtCode.Focus()
                Return
            ElseIf GiaiMaKey("" & txtCode.Text.ToString() & "") = txtDenngay.Text.ToString() Then
                mIni.WriteString("DangkySudung", "Key") = txtCode.Text
                MsgBoxF("Đăng ký thành công", MsgType.Information)

            End If
        End If

    End Sub

    Private Sub btnSinhcode_Click(sender As Object, e As EventArgs) Handles btnSinhcode.Click
        If Not isadmin Then Return
        txtCode.Text = MaHoaKey(txtDenngay.Text.ToString())
    End Sub
End Class