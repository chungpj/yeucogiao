Imports DevExpress.XtraGrid.Columns

Public Class frmChamcong
    Private dtChamcong As DataTable
    Private _Load As Boolean = False 'đang load
    Private Sub frmChamcong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load = True
        Dim nam = Now.Year
        For i = nam - 5 To nam
            cboNam.Properties.Items.Add(i)
        Next
        cboNam.SelectedItem = Now.Year
        cboThang.SelectedItem = "Tháng " & Now.Month
        Dim dt = GetTableDl("SELECT * FROM Lop")
        cboLop.Properties.DataSource = dt
        cboLop.Properties.DisplayMember = "tenlop"
        cboLop.Properties.ValueMember = "id"
        _Load = False
    End Sub

    Private Sub btnNapDL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNapDL.Click
        If cboLop.ItemIndex = -1 OrElse cboLop.Text.Trim = "" Then
            MsgBoxF("Vui lòng chọn lớp.", MsgType.Error_) : Return
        End If
        dtgcChamcong.DataSource = Nothing
        dtgvChamcong.Columns.Clear()
        Dim thang As Integer = cboThang.Text.Replace("Tháng", "").Trim
        Dim songay As Integer = iSoNgayTrongThang(thang, cboNam.Text)
        dtChamcong = GetTableDl("SELECT a.* FROM Chamcong a join Hocsinh b on a.mahocsinh=b.id WHERE b.malop='" & cboLop.EditValue & "' AND Month(ngaytich)='" & thang & "' AND Year(ngaytich)='" & cboNam.Text & "' ")
        If IsNothing(dtChamcong) OrElse dtChamcong.Rows.Count = 0 Then
            MsgBoxF("Bạn chưa tạo tháng ăn cho lớp: " & cboLop.Text() & " -" & cboThang.Text() & " -Năm: " & cboNam.Text & ". Vui lòng kiểm tra lại", MsgType.Error_)
            Return
        End If
        _Load = True
        Dim dt As DataTable = New DataTable()
        dt.Columns.Add("STT", Type.GetType("System.String"))
        dt.Columns.Add("thungay", Type.GetType("System.String"))
        
        For i = 1 To songay
            dt.Columns.Add(GetThu(i & "/" & thang & "/" & cboNam.Text, i), Type.GetType("System.String"))
        Next
        dt.Columns.Add("tong", Type.GetType("System.String"))
        Dim dr = dt.NewRow()
        dr(0) = ""
        dr(1) = "hoten"
        For i = 1 To songay
            dr(i + 1) = i
        Next
        dt.Columns.Add("idHS", Type.GetType("System.String"))
        dt.Rows.Add(dr)
        Dim dtHS = GetTableDl("select Row_Number()Over(Order By mahocsinh) stt,* from Hocsinh where malop='" & cboLop.EditValue & "' AND id in (select mahocsinh from chamcong)")
        For i = 0 To dtHS.Rows.Count - 1
            Dim _dr = dt.NewRow()
            _dr(0) = dtHS.Rows(i)("stt")
            _dr(1) = dtHS.Rows(i)("hoten")
            _dr(dt.Columns.Count - 1) = dtHS.Rows(i)("id")
            dt.Rows.Add(_dr)
        Next

        If Not IsNothing(dtChamcong) Then
            Dim tong As Integer = 0
            For i = 1 To dt.Rows.Count - 1
                dtChamcong.DefaultView.RowFilter = "mahocsinh='" & dt.Rows(i)("idHS") & "'"
                For j = 0 To dtChamcong.DefaultView.Count - 1
                    If j = dtChamcong.DefaultView.Count - 1 Then
                        dt.Rows(i)(j + 3) = tong : tong = 0
                    End If
                    If dtChamcong.DefaultView(j)("trangthai") Then
                        tong += 1
                        dt.Rows(i)(j + 2) = "x"
                    End If
                Next
            Next
        End If
        
        dtgcChamcong.DataSource = dt
        SetDesign()
        _Load = False
    End Sub
#Region "Function"
    Private Sub SetDesign()
        dtgvChamcong.Columns(0).Width = 35
        dtgvChamcong.Columns(1).Width = 180 : dtgvChamcong.Columns(1).Caption = "Thứ ngày"
        dtgvChamcong.Columns("idHS").Visible = False
        dtgvChamcong.SetRowCellValue(0, dtgvChamcong.Columns(1), "Họ và tên")
        For i = 2 To dtgvChamcong.Columns.Count - 1
            If dtgvChamcong.Columns(i).FieldName.Contains("i") Then
                dtgvChamcong.Columns(i).Caption = dtgvChamcong.Columns(i).FieldName.Substring(0, 2)
            ElseIf dtgvChamcong.Columns(i).FieldName = "tong" Then
                dtgvChamcong.Columns(i).Caption = "Tổng"
                dtgvChamcong.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                dtgvChamcong.Columns(i).AppearanceCell.ForeColor = Color.Red
                dtgvChamcong.Columns(i).Width = 40
            End If
            If i < dtgvChamcong.Columns.Count - 2 Then
                dtgvChamcong.Columns(i).Width = 36
                dtgvChamcong.Columns(i).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End If
        Next
        dtgvChamcong.FocusedRowHandle = 1
        dtgvChamcong.ShowEditor()
    End Sub

    Function GetThu(ByVal ngay As String, ByVal ngaythat As Integer) As String
        Dim thu As String = CDate(ngay).DayOfWeek.ToString()
        If thu = "Monday" Then
            thu = "T2"
        ElseIf thu = "Tuesday" Then
            thu = "T3"
        ElseIf thu = "Wednesday" Then
            thu = "T4"
        ElseIf thu = "Thursday" Then
            thu = "T5"
        ElseIf thu = "Friday" Then
            thu = "T6"
        ElseIf thu = "Saturday" Then
            thu = "T7"
        ElseIf thu = "Sunday" Then
            thu = "CN"
        End If
        If ngaythat > 7 AndAlso ngaythat <= 14 Then
            Return thu & "i"
        ElseIf ngaythat > 14 AndAlso ngaythat <= 21 Then
            Return thu & "ii"
        ElseIf ngaythat > 21 AndAlso ngaythat <= 28 Then
            Return thu & "iii"
        ElseIf ngaythat >= 29 Then
            Return thu & "iiii"
        End If
        Return thu
    End Function
#End Region
   
    Private Sub dtgvChamcong_RowCellClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles dtgvChamcong.RowCellClick
        If e.Column.VisibleIndex = dtgvChamcong.Columns.Count - 1 Then Return
        If e.RowHandle = 0 Then
            Return
            dtgvChamcong.FocusedRowHandle = 1
            dtgvChamcong.FocusedColumn.VisibleIndex = 1
            dtgvChamcong.ShowEditor()
        End If
        If e.Column.VisibleIndex > 1 AndAlso Not e.Column.FieldName.Contains("CN") Then
            If e.CellValue.ToString.Trim = "x" Then
                dtgvChamcong.SetRowCellValue(e.RowHandle, e.Column, "")
                dtgvChamcong.SetRowCellValue(e.RowHandle, "tong", dtgvChamcong.GetRowCellValue(e.RowHandle, "tong") - 1)
            Else
                dtgvChamcong.SetRowCellValue(e.RowHandle, e.Column, "x")
                dtgvChamcong.SetRowCellValue(e.RowHandle, "tong", dtgvChamcong.GetRowCellValue(e.RowHandle, "tong") + 1)
            End If
        End If

    End Sub

    Private Sub dtgvChamcong_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles dtgvChamcong.RowCellStyle
        If IsNothing(dtgcChamcong.DataSource) OrElse dtgvChamcong.RowCount = 0 Then Return
        If e.Column.FieldName.ToString.Contains("CN") Then
            e.Column.AppearanceCell.BackColor = Color.Silver
        End If
        If e.RowHandle = 0 Then
            e.Appearance.FontStyleDelta = FontStyle.Bold
        End If
    End Sub

    Private Sub dtgvChamcong_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles dtgvChamcong.FocusedRowChanged
        If e.FocusedRowHandle = 0 Then
            dtgvChamcong.FocusedRowHandle = 1
            'dtgvChamcong.FocusedColumn.VisibleIndex = 1
            dtgvChamcong.ShowEditor()
        End If
    End Sub

    Private Sub dtgvChamcong_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles dtgvChamcong.CellValueChanged
        If _Load OrElse e.Column.FieldName = "tong" Then Return
        dtgvChamcong.PostEditor()
        dtChamcong.DefaultView.RowFilter = "mahocsinh='" & dtgvChamcong.GetRowCellValue(e.RowHandle, "idHS") & "'"
        If e.Value = "x" Then
            dtChamcong.DefaultView(e.Column.VisibleIndex - 2)("trangthai") = True
        Else
            dtChamcong.DefaultView(e.Column.VisibleIndex - 2)("trangthai") = False
        End If
    End Sub

    Private Sub btnLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLuu.Click
        If _Load Then Return
        If CnDLServer(dtChamcong, "SELECT * FROM Chamcong") Then
            MsgBoxF("Lưu bảng chấm công thành công.", MsgType.Information)
        Else
            MsgBoxF("Có lỗi khi lưu dữ liệu, Vui lòng liên hệ nhà phát triển phần mềm", MsgType.Error_)
        End If
    End Sub

    Private Sub cboLop_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLop.EditValueChanged
        If _Load Then Return
        btnNapDL.PerformClick()
    End Sub
End Class