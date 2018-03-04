Imports DevExpress.XtraEditors

Module ModMsgBox
    Enum MsgType
        Error_
        Information
        YesNo
    End Enum
    Public Function MsgBoxF(ByVal msgContent As String, ByVal type As MsgType) As DialogResult
        Select Case type
            Case MsgType.Error_
                Return XtraMessageBox.Show(msgContent, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Case MsgType.Information
                Return XtraMessageBox.Show(msgContent, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Case MsgType.YesNo
                Return XtraMessageBox.Show(msgContent, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Case Else
                Return XtraMessageBox.Show(msgContent, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End Select
    End Function
End Module
