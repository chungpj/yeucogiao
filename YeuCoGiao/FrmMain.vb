Public Class FrmMain 

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt = GetTableDl("select * from ConnectManage")
    End Sub
End Class