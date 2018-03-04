Imports System.Data.SqlClient
Imports DevExpress.XtraLayout

Public Class frmKetNoi
    Private _mTo As Integer
    Private _mStr As String
    Private _mTable As DataTable
    Private _mCnn As SqlConnection
    Private ReadOnly _mConfig As String = (My.Application.Info.DirectoryPath & "\config.sys").Replace("\\", "\")

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Dim obj As Object
        If TypeOf Me.ActiveControl Is LayoutControl Then
            obj = CType(Me.ActiveControl, LayoutControl).ActiveControl
        Else
            obj = Me.ActiveControl
        End If
        Select Case keyData
            Case Keys.F2
                If obj.Parent Is txtPass Then
                    btnSave.PerformClick() : Return True
                End If
            Case Keys.Escape
                End
        End Select
        Return False
    End Function

    Private Sub frmKetNoi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _mTo = Val(mIni.ReadString("Connection", , , _mConfig))
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        mIni.WriteString("Connection", , _mConfig) = _mTo
        mIni.WriteString("B", , _mConfig) = txtMayChu.Text
        mIni.WriteString("C", , _mConfig) = txtUser.Text
        mIni.WriteString("D", , _mConfig) = txtPass.Text
        mIni.WriteString("E", , _mConfig) = txtDB.Text
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        On Error GoTo Nhan
        Me.Cursor = Cursors.WaitCursor
        Me.Cursor = Cursors.WaitCursor
        _mCnn =
            New SqlConnection(
                "Data Source=" & txtMayChu.Text & ";User ID=" & txtUser.Text & ";Password=" & txtPass.Text)
        _mCnn.Open()
        MsgBoxF("Kết nối thành công!", MsgType.Information)
        _mCnn.Close()
Nhan:
        Me.Cursor = Cursors.Default
        If TypeOf (Err.GetException) Is InvalidOperationException Then
            MsgBoxF("Tên máy chủ không chính xác hoặc kết nối đã được mở, Vui lòng kiểm tra lại!", MsgType.Error_)
        End If
        If TypeOf (Err.GetException) Is SqlException Then
            MsgBoxF("Mật khẩu không chính xác, Vui lòng kiểm tra lại!", MsgType.Error_)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub
End Class