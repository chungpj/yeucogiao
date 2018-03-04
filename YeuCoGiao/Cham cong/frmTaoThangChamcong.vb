Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout

Public Class frmTaoThangChamcong
    Private _Load As Boolean = False
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
            Case Keys.Escape
                Me.Close()
        End Select
        Return False
    End Function
    Private Sub frmTaoThangChamcong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nam = Now.Year
        For i = nam - 5 To nam
            cboNam.Properties.Items.Add(i)
        Next
        _Load = False
        cboNam.SelectedItem = Now.Year
        cboThang.SelectedItem = "Tháng " & Now.Month
        Dim dt = GetTableDl("SELECT * FROM Lop")
        cboLop.Properties.DataSource = dt
        cboLop.Properties.DisplayMember = "tenlop"
        cboLop.Properties.ValueMember = "id"
        _Load = True
        cboLop.ItemIndex = 0

    End Sub
    
    Private Sub cboLop_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLop.EditValueChanged
        If Not _Load Then Return
        layDL()
    End Sub
#Region "Function"
    Sub layDL()
        dtgcDSHS.DataSource = GetTableDl("SELECT CONVERT(Bit, 0) as chon,Row_Number()Over(Order By id) stt,* FROM Hocsinh WHERE malop='" & cboLop.EditValue & "'")
        dtgcThang.DataSource = GetTableDl("Select Row_Number()Over(Order By ngaythang) stt,* from (select Month(ngaytich) thang,Year(ngaytich) nam,cast(Month(ngaytich) as varchar) + '/' + cast(Year(ngaytich) as varchar) ngaythang from Chamcong a join Hocsinh b on a.mahocsinh=b.id where malop='" & cboLop.EditValue & "') tbl Group by ngaythang,thang,nam")
    End Sub
#Region "check all"
    Private _dtgv As GridView
    Private _dtgc As GridControl
    Private _clm As GridColumn
    Private _chkAll As CheckEdit
    Private _picShow As PictureEdit
    Private Function CountCheck(ByVal _dtgv, ByVal _clm) As Integer
        Dim intC = 0
        For i = 0 To _dtgv.RowCount - 1
            If Not IsDBNull(_dtgv.GetDataRow(i)(_clm.FieldName)) AndAlso _dtgv.GetDataRow(i)(_clm.FieldName) Then
                intC += 1
            End If
        Next
        Return intC
    End Function

    Private Sub setCellCheck(ByVal _dtgv, ByVal _clm, ByVal _chkAll)
        'khi cell check thì trạng thái checkAll cũng thay đổi
        If _dtgv.FocusedColumn Is _clm Then
            If _chkAll.Tag = 1 OrElse _dtgv.FocusedValue() Is Nothing OrElse _dtgv.FocusedColumn.AbsoluteIndex <> _dtgv.Columns(_clm.FieldName).AbsoluteIndex Then Return
            _chkAll.Tag = 1
            Dim count As Integer = CountCheck(_dtgv, _clm)
            If _dtgv.GetFocusedValue() Then
                If count > _dtgv.RowCount - 1 Then
                    _chkAll.Checked = True
                Else
                    _chkAll.Checked = False
                End If
            Else
                If _chkAll.Checked Then _chkAll.Checked = False
            End If
            _chkAll.Tag = 0
        End If
    End Sub

    Private Sub setCheckAll(ByVal _dtgv, ByVal _clm, ByVal _chkAll)
        'khi CheckAll được check/uncheck
        If _chkAll.Tag = 1 Then Return
        _chkAll.Tag = 1
        For i = 0 To _dtgv.RowCount - 1
            _dtgv.SetRowCellValue(i, _clm, _chkAll.CheckState)
        Next
        _chkAll.Tag = 0
    End Sub

    Private Sub setRisponCheck(ByVal _dtgv, ByVal _clm, ByVal _chkAll)
        If _chkAll.Tag = 1 OrElse _dtgv.FocusedValue() Is Nothing OrElse _dtgv.FocusedColumn.AbsoluteIndex <> _dtgv.Columns(_clm.FieldName).AbsoluteIndex Then Return
        _dtgv.PostEditor()
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllHS.CheckedChanged
        setCheckAll(dtgvDSHS, clmChonHS, chkAllHS)
    End Sub
    Private Sub Risponcheck_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResponChon.EditValueChanged
        setRisponCheck(dtgvDSHS, clmChonHS, chkAllHS)
    End Sub
    Private Sub dtgv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dtgvDSHS.CellValueChanged
        setCellCheck(dtgvDSHS, clmChonHS, chkAllHS)

    End Sub
#End Region
#End Region

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        Dim thang As Integer = cboThang.Text.Replace("Tháng", "").Trim
        Dim songay As Integer = iSoNgayTrongThang(thang, cboNam.Text)
        Dim sql = "select Chamcong.* from Chamcong join Hocsinh on Chamcong.mahocsinh = Hocsinh.id where MONTH(ngaytich) = '" & thang & "' and YEAR(ngaytich) = '" & cboNam.Text & "' and malop = '" & cboLop.EditValue & "'"
        Dim dt = GetTableDl(sql)
        Me.Cursor = Cursors.WaitCursor
        If Not IsNothing(dt) Then
            For i = 0 To dtgvDSHS.RowCount - 1
                If dtgvDSHS.GetRowCellValue(i, "chon") Then
                    Dim mahs = dtgvDSHS.GetRowCellValue(i, "id")
                    If dt.Select("mahocsinh='" & mahs & "'").Length > 0 Then Continue For
                    For j = 1 To songay
                        Dim dr = dt.NewRow()
                        dr("mahocsinh") = mahs
                        dr("ngaytich") = CDate(cboNam.Text & "-" & thang & "-" & j)
                        dr("trangthai") = 0
                        dt.Rows.Add(dr)
                    Next
                End If
            Next
        End If
        If CnDLServer(dt, "SELECT * FROM Chamcong") Then
            layDL()
            MsgBoxF("Tạo tháng ăn thành công.", MsgType.Information)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ResponDelete_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ResponDelete.ButtonClick
        Dim dt = GetTableDl("SELECT TOP 1 From Chamcong WHERE Year(ngaytich)='" & dtgvThang.GetFocusedRowCellValue("nam") & "' AND Month(ngaytich)='" & dtgvThang.GetFocusedRowCellValue("thang") & "' AND trangthai=1")
        If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
            MsgBoxF("Lớp : " & cboLop.Text & "đã có dữ liệu chấm công, Bạn không thể xóa.", MsgType.Error_)
            Return
        Else
            If MsgBoxF("Bạn có chắc chắn xóa tháng ăn của lớp : " & cboLop.Text & " ?", MsgType.YesNo) = MsgBoxResult.No Then Return
            If ThucThiSQL("DELETE a FROM Chamcong a join Hocsinh b on a.mahocsinh=b.id WHERE Year(ngaytich)='" & dtgvThang.GetFocusedRowCellValue("nam") & "' AND Month(ngaytich)='" & dtgvThang.GetFocusedRowCellValue("thang") & "' AND b.malop='" & cboLop.EditValue & "'") Then
                MsgBoxF("Xóa thành công", MsgType.Information)
                layDL()
            Else
                MsgBoxF("Có lỗi khi xóa dữ liệu,Vui lòng liên hệ a Thành", MsgType.Error_)
            End If
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class