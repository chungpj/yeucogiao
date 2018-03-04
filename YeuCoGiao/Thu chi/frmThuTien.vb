Public Class frmThuTien

    Private _Load As Boolean = False

    Private Sub frmThuTien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _Load = False

        Dim dt = GetTableDl("SELECT * FROM [lop]")
        cboLop.Properties.DataSource = dt
        cboLop.Properties.DisplayMember = "tenlop"
        cboLop.Properties.ValueMember = "id"
        dtgcDSHS.DataSource = GetTableDl("SELECT Row_Number()Over(Order By hs.id) stt, l.tenlop as tenlop, * FROM Hocsinh hs join Lop l on hs.malop = l.id")
        _Load = True
        cboLop.ItemIndex = 0
    End Sub

    Private Sub btnTimkiem_Click(sender As Object, e As EventArgs) Handles btnTimkiem.Click
        Dim malop = cboLop.EditValue
        Dim hoten = txtTen.Text
        If hoten = "" Then
            dtgcDSHS.DataSource = GetTableDl("SELECT Row_Number()Over(Order By hs.id) stt, l.tenlop as tenlop, * FROM Hocsinh hs join Lop l on hs.malop = l.id where malop = '" & malop & "'")
            Return
            End
        Else
            dtgcDSHS.DataSource = GetTableDl("SELECT Row_Number()Over(Order By hs.id) stt, l.tenlop as tenlop, * FROM Hocsinh hs join Lop l on hs.malop = l.id where  malop = '" & malop & "' and hs.hoten like N'%" & hoten & "%'")
            Return
        End If
    End Sub

    Private Sub ribeXem_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ribeXem.ButtonClick
        Dim maHS = dtgvDSHS.GetFocusedRowCellValue("id")
        Dim f As New frmNopHocPhi(maHS)
        f.ShowDialog()
    End Sub

    Private Sub ribeThu_Click(sender As Object, e As EventArgs) Handles ribeThu.Click
        Dim maHS = dtgvDSHS.GetFocusedRowCellValue("id")
        Dim f As New frmHoaDon(maHS)
        f.ShowDialog()
    End Sub
End Class