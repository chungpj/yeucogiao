Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid

Module ModSystem

#Region "Khai báo biến"
    'Ngày build
    Public Build As String = "22122016-CHUNG"
    Public mIni As New ClsIniFile
    Public IDMay, MayChu, IDNguoiDung, NguoiDung, DonviDangky
    Public SqlAdapter As SqlDataAdapter
    Public SqlCon As SqlConnection
    Public CultureInfo As CultureInfo
    Public SqlCommandBuider As SqlCommandBuilder
    Public Dungthu As Integer = 0 '1: Đang được dùng thử --- 0: Đã hết hạn dùng thử 
#End Region

#Region "Làm việc với DB"
    Public Sub DongKetNoi()
        If SqlAdapter.SelectCommand.Connection.State = ConnectionState.Open Then SqlAdapter.SelectCommand.Connection.Close()
    End Sub

    Public Function GetTableDl(Optional ByVal ChuoiSQL As String = "", Optional ByVal Bang As String = "", Optional ByVal closeConnect As Boolean = True) As DataTable
        Try
            DoiCSdlieu()
            SqlAdapter.SelectCommand.CommandText = IIf(ChuoiSQL <> "", ChuoiSQL, "Select * From " & Bang)
            SqlAdapter.SelectCommand.CommandType = CommandType.Text
            Dim tbl As New DataTable
            SqlAdapter.SelectCommand.CommandTimeout = 900
            SqlAdapter.Fill(tbl)
            tbl.Locale = Thread.CurrentThread.CurrentCulture
            Return tbl
        Catch ex As Exception
            Return Nothing
        Finally
            If closeConnect Then
                DongKetNoi()
            End If
        End Try
    End Function

    Public Sub DoiCSdlieu()
        If IsNothing(SqlCon) Then
            If Not TaoKNdulieu() Then End
        End If
        SqlAdapter.SelectCommand.Connection = SqlCon
        Try
            If SqlAdapter.SelectCommand.Connection.State = ConnectionState.Closed Then _
                SqlAdapter.SelectCommand.Connection.Open()

        Catch
            If Not TaoKNdulieu() Then End
        End Try
        SqlAdapter.SelectCommand.CommandText = "Set dateformat dmy "
        SqlAdapter.SelectCommand.CommandType = CommandType.Text
        SqlAdapter.SelectCommand.CommandTimeout = 900
        SqlAdapter.SelectCommand.ExecuteNonQuery()
    End Sub

    Public Function TaoKNdulieu() As Boolean
        Try
            Dim Tam As New SqlConnectionStringBuilder
            Dim mConfig As String = (My.Application.Info.DirectoryPath & "\config.sys").Replace("\\", "\")
            If IsNothing(SqlCon) Then
                SqlCon = New SqlConnection
            End If
            Tam.DataSource = mIni.ReadString("B" & mIni.ReadString("Default", , , mConfig), , , mConfig)
            MayChu = Tam.DataSource.ToLower.Split("\")(0).ToUpper
            Tam.UserID = mIni.ReadString("C" & mIni.ReadString("Default", , , mConfig), , , mConfig)
            Tam.Password = mIni.ReadString("D" & mIni.ReadString("Default", , , mConfig), , , mConfig)
            Tam.InitialCatalog = mIni.ReadString("E" & mIni.ReadString("Default", , , mConfig), , , mConfig)
            SqlCon.ConnectionString = Tam.ConnectionString
            SqlCon.Open()
            SqlAdapter = New SqlDataAdapter("", SqlCon)
            SqlCommandBuider = New SqlCommandBuilder(SqlAdapter)
            Return True
        Catch
            If IsNothing(SqlCon) Then
                MsgBoxF("Không thể kết nối tới máy chủ", MsgType.Error_)
            End If
        End Try
        Return False
    End Function

    Public Function CnDLServer(ByRef DT As Object, Optional ByVal ChuoiSQL As String = "") As Boolean
        Try
            SqlAdapter = New SqlDataAdapter(ChuoiSQL, SqlCon)
            DoiCSdlieu()
            If ChuoiSQL.Contains(";") Then
                Dim SQL = ChuoiSQL.Split(";")
                For i = 0 To DT.Tables.Count - 1
                    SqlAdapter.SelectCommand.CommandText = SQL(i)
                    SqlCommandBuider = New SqlCommandBuilder(SqlAdapter)
                    SqlAdapter.Update(DT.Tables(i))
                    SqlCommandBuider.DataAdapter = Nothing
                Next
            Else
                If TypeOf DT Is DataSet AndAlso DT.ExtendedProperties.Count <> 0 Then
                    SqlAdapter.InsertCommand = DT.ExtendedProperties("Insert")
                    SqlAdapter.DeleteCommand = DT.ExtendedProperties("Delete")
                    SqlAdapter.UpdateCommand = DT.ExtendedProperties("Update")
                Else
                    SqlAdapter.SelectCommand.CommandText = ChuoiSQL
                    SqlCommandBuider = New SqlCommandBuilder(SqlAdapter)
                End If
                SqlAdapter.SelectCommand.CommandTimeout = 900
                SqlAdapter.Update(DT)
                SqlCommandBuider.DataAdapter = Nothing
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ThucThiSQL(ByVal ChuoiSQL As String) As Boolean
        If ChuoiSQL.Trim = "" OrElse ChuoiSQL.Trim = ";" Then Return True
        Try
            DoiCSdlieu()
            SqlAdapter.SelectCommand.CommandText = ChuoiSQL
            SqlAdapter.SelectCommand.CommandTimeout = 900
            SqlAdapter.SelectCommand.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
#Region "Mã hóa DL"
    Public Function encryptData(ByVal data As String) As Byte()
        Dim md5Hasher As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim hashedBytes As Byte()
        Dim encoder As New System.Text.UTF8Encoding()
        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(data))
        Return hashedBytes
    End Function
    'MD5
    Public Function MaHoa(ByVal data As String) As String
        Return BitConverter.ToString(encryptData(data)).Replace("-", "").ToLower()
    End Function
    'Mã Hóa Key
    Public Function MaHoaKey(ByVal toEncode As String) As String
        Dim toEncodeAsBytes As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode)
        Dim returnValue As String = System.Convert.ToBase64String(toEncodeAsBytes)
        Return returnValue
    End Function
    'Giải mã Key
    Public Function GiaiMaKey(ByVal encodedData As String) As String
        Dim encodedDataAsBytes As Byte() = System.Convert.FromBase64String(encodedData)
        Dim returnValue As String = System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes)
        Return returnValue
    End Function
    'ADMIN Pass Default
    Public Function GetAdminPass(ByVal val As String, Optional ByVal _length As Integer = 6) As String
        Dim sum = 0
        For index = 0 To val.Length - 1
            sum += Convert.ToDouble(val(index).ToString)
        Next
        sum = IIf(sum > 10, sum - 10, sum)
        While val.Length < _length
            sum = sum * 2
            sum = IIf(sum > 10, sum - 10, sum)
            val &= sum.ToString
        End While
        Return val
    End Function
#End Region
#Region "Phân quyền"
    Public Sub Quyen()

    End Sub
#End Region
#Region "Nhập ngày/giờ"
    Public Function NhapNgayF(ByVal K As Keys, ByVal C As Object, ByVal ParamArray L() As Object) As Boolean
        If L.Length = 0 Then L = New Object() {C}
        If L.Length = 0 OrElse K >= Keys.Shift OrElse (K >= Keys.F1 AndAlso K <= Keys.F12) Then Return False
        If (K >= Keys.F13 AndAlso K <= Keys.F24) Then
            MsgBoxF("Phím này có thật không", MsgType.Error_)
            Return False
        End If
        NhapNgayF = False
        If (TypeOf C Is DataGridViewTextBoxEditingControl) OrElse (TypeOf C Is DataGridView) Then
            Dim dgv As DataGridView = Nothing
            If TypeOf C Is DataGridView Then dgv = C
            If TypeOf C Is DataGridViewTextBoxEditingControl Then dgv = C.Parent.Parent
            If IsNothing(dgv.CurrentCell) Then Return True
            For i As Byte = 0 To UBound(L)
                If IsNothing(L(i)) Then Continue For
                Select Case L(i).GetType.Name
                    Case "String"
                        If L(i).ToUpper = dgv.Columns(dgv.CurrentCell.ColumnIndex).Name.ToUpper Then _
                            NhapNgayF = True : Exit For
                    Case "Int32", "Integer"
                        If L(i) = dgv.CurrentCell.ColumnIndex Then NhapNgayF = True : Exit For
                    Case "DataGridViewTextBoxColumn"
                        If L(i) Is dgv.Columns(dgv.CurrentCell.ColumnIndex) Then NhapNgayF = True : Exit For
                    Case "DataGridViewTextBoxEditingControl"
                        If L(i) Is C Then NhapNgayF = True : Exit For
                End Select
            Next i
            If NhapNgayF AndAlso TypeOf C Is DataGridView Then
                Select Case K
                    Case Keys.Enter, Keys.Escape, Keys.Tab, Keys.Left, Keys.Right, Keys.Up, Keys.Down, Keys.Home,
                        Keys.End, (Keys.Shift + Keys.Home), (Keys.Shift + Keys.End), (Keys.Shift + Keys.Left),
                        (Keys.Shift + Keys.Right) : Return False
                    Case Keys.Back, Keys.Delete, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7,
                        Keys.D8, Keys.D9 : Return False
                    Case Keys.Subtract, Keys.OemMinus, Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3,
                        Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9 _
                        : Return False
                    Case Else : Return True
                End Select
            End If
        Else
            For i As Byte = 0 To UBound(L)
                If IsNothing(L(i)) Then Continue For
                Select Case L(i).GetType.Name
                    Case "String"
                        If L(i).ToUpper = C.Name.ToUpper Then NhapNgayF = True : Exit For
                    Case Else
                        If L(i) Is C Then NhapNgayF = True : Exit For
                End Select
            Next i
        End If
        If Not NhapNgayF Then Return False
        If _
            (Not TypeOf C Is System.Windows.Forms.ComboBox AndAlso C.ReadOnly) OrElse
            (TypeOf C Is System.Windows.Forms.ComboBox AndAlso C.DropDownStyle = ComboBoxStyle.DropDownList) Then Return False
        Select Case K
            Case Keys.Enter, Keys.Escape, Keys.Tab, Keys.Left, Keys.Right, Keys.Up, Keys.Down, Keys.Home, Keys.End,
                (Keys.Shift + Keys.Home), (Keys.Shift + Keys.End), (Keys.Shift + Keys.Left), (Keys.Shift + Keys.Right) _
                : Return False
            Case Keys.Back, Keys.Delete, Keys.Divide, Keys.OemQuestion, Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4,
                Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3,
                Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9
                If (K = Keys.Back OrElse K = Keys.Delete) Then Return False
                C.Properties.MaxLength = 10
                If (K = Keys.Divide OrElse K = Keys.OemQuestion) AndAlso C.Text.Length = 0 Then Return True
                If _
                    (K = Keys.Divide OrElse K = Keys.OemQuestion) AndAlso Regex.Matches(C.Text, "/").Count = 2 AndAlso
                    Not C.SelectedText.Contains("/") Then Return True
                If (K = Keys.Divide OrElse K = Keys.OemQuestion) Then K = AscW("/")
                If K > Keys.D9 Then K = (K - 48)
                Dim mStr As String = ChrW(K), mStart1 = 1
                mStr =
                    (C.Text.Substring(0, C.SelectionStart) & mStr &
                     C.Text.Substring(C.SelectionStart + C.SelectionLength))
                Dim mStart As Integer = (mStr.Length - C.SelectionStart)
                If C.Text.Length < 10 Then
                    Dim st As Integer = C.SelectionStart, st1 = 0
                    Dim dmy() As String = mStr.Split("/")
                    Select Case UBound(dmy)
                        Case 0
                            If dmy(0).Length > 2 AndAlso dmy(0).Length < 5 Then
                                mStr = dmy(0).Substring(0, 2) & "/" & dmy(0).Substring(2)
                                st1 = -(st = 2)
                            ElseIf dmy(0).Length > 4 Then
                                mStr = dmy(0).Substring(0, 2) & "/" & dmy(0).Substring(2, 2) & "/" & dmy(0).Substring(4)
                            End If
                        Case 1
                            If dmy(0).Length > 2 Then
                                dmy(1) = dmy(0).Substring(2) & dmy(1)
                                dmy(0) = dmy(0).Substring(0, 2)
                            End If
                            If dmy(1).Length < 3 Then
                                mStr = dmy(0) & "/" & dmy(1)
                            ElseIf dmy(1).Length > 2 AndAlso dmy(1).Length < 7 Then
                                mStr = dmy(0) & "/" & dmy(1).Substring(0, 2) & "/" & dmy(1).Substring(2)
                                st1 = -(st = 5)
                            ElseIf dmy(1).Length > 6 Then
                                mStr = dmy(0) & "/" & dmy(1).Substring(0, 2) & "/" & dmy(1).Substring(2, 4)
                            End If
                        Case 2
                            If dmy(0).Length > 2 Then
                                dmy(1) = dmy(0).Substring(2) & dmy(1)
                                dmy(0) = dmy(0).Substring(0, 2)
                            ElseIf dmy(0).Length < 2 Then
                                dmy(0) = "0" & dmy(0)
                            End If
                            If dmy(1).Length > 2 Then
                                dmy(2) = dmy(1).Substring(2) & dmy(2)
                                dmy(1) = dmy(1).Substring(0, 2)
                            ElseIf dmy(1).Length < 2 Then
                                dmy(1) = "0" & dmy(1)
                            End If
                            If dmy(2).Length > 4 Then dmy(2) = dmy(2).Substring(0, 4)
                            mStr = dmy(0) & "/" & dmy(1) & "/" & dmy(2)
                    End Select
                Else
                    mStr = ChrW(K)
                    mStart1 = 2
                    If (K = Keys.Back OrElse K = Keys.Delete) Then
                        If C.SelectionLength = 10 Then C.SelectedText = "" : Return True
                        mStr = "0"
                        mStart = -(C.SelectionStart + (K = Keys.Back))
                        mStart1 = -10
                        If K = Keys.Back Then
                            If C.SelectionStart = 0 Then Return True
                            If C.SelectionStart = 3 OrElse C.SelectionStart = 6 Then C.SelectionStart -= 2 Else _
                                C.SelectionStart -= 1
                            mStart = 10
                            mStart1 = C.SelectionStart
                        Else
                            If C.SelectionStart = 10 Then Return True
                            If C.SelectionStart = 2 OrElse C.SelectionStart = 5 Then C.SelectionStart += 1
                            mStart = 10
                            mStart1 = C.SelectionStart + 1
                            If C.SelectionStart = 10 Then C.SelectionStart -= 1
                        End If
                    Else
                        If C.Text.Length = C.SelectionLength Then mStart = C.Text.Length : mStart1 = 1
                        If C.SelectionStart = 2 OrElse C.SelectionStart = 5 Then C.SelectionStart += 1 : mStart1 = 3
                        If C.SelectionStart = 10 Then C.SelectionStart -= 1
                    End If
                    mStr = (C.Text.Substring(0, C.SelectionStart) & mStr & C.Text.Substring(C.SelectionStart + 1))
                End If
                C.SelectionStart = 0
                C.SelectionLength = C.Properties.MaxLength
                C.SelectedText = mStr
                C.SelectionStart = IIf((C.Text.Length - mStart + mStart1) < 0, 0, C.Text.Length - mStart + mStart1)
        End Select
        If Not IsNothing(C.IsModified) Then C.IsModified = True
        Return NhapNgayF
    End Function
#End Region
    Private Const xlLeft = -4131
    Private Const xlRight = -4152
    Private Const xlTop = -4160
    Private Const xlBottom = -4107
    Private Const xlCenter = -4108
#Region "Tiện ích"
    Public Sub ToExcell(ByVal dtgvdata As GridView)
        If dtgvdata.RowCount = 0 Then _
            MsgBoxF("Không có dữ liệu để xuất ra file Excel !", MsgType.Information) : Return
        If _
            MsgBoxF("Bạn chắc chắn chuyển số liệu ra file Excel không?", MsgType.YesNo) = MsgBoxResult.No Then Return
        Dim s As String = InputBox("Nhập tên file: ", "Chuyển Excel")
        If s = "" Then Return
        If Not Directory.Exists("C:\MamNon\") Then Directory.CreateDirectory("c:\MamNon\")
        Dim App As Object = CreateObject("Excel.Application")
        Dim filename As String = "C:\MamNon\" & s & ".xls"
        If File.Exists(filename) Then File.Delete(filename)
        Dim WorkB As Object = App.Workbooks.Add
        Dim BangTinh As Object = WorkB.Worksheets("Sheet1")

        BangTinh.Range("a1", GetCells(dtgvdata.Columns.Count)).Merge()
        BangTinh.Cells(1, 1) = "DANH SÁCH HỌC SINH"
        BangTinh.Cells(1, 1).VerticalAlignment = xlCenter
        BangTinh.Cells(1, 1).HorizontalAlignment = xlCenter
        BangTinh.Cells(1, 1).Font.Size = 12
        BangTinh.Cells(1, 1).Font.Bold = True

        For j As Integer = 0 To dtgvdata.Columns.Count - 1
            If Not dtgvdata.Columns(j).Visible Then Continue For
            BangTinh.Cells(2, j + 1) = "'" & dtgvdata.Columns(j).Caption
            BangTinh.Cells(2, j + 1).Font.Bold = True
        Next
        For i As Integer = 0 To dtgvdata.RowCount - 1
            For j As Integer = 0 To dtgvdata.Columns.Count - 1
                If Not dtgvdata.Columns(j).Visible Then Continue For
                If dtgvdata.GetRowCellValue(i, dtgvdata.Columns(j)) Is Nothing Then Continue For
                If _
                    dtgvdata.Columns(j).ColumnType Is GetType(Integer) OrElse
                    dtgvdata.Columns(j).ColumnType Is GetType(Double) OrElse
                    dtgvdata.Columns(j).ColumnType Is GetType(Single) OrElse
                    dtgvdata.Columns(j).ColumnType Is GetType(Long) Then
                    BangTinh.Cells(i + 3 + 2, j + 1) = dtgvdata.GetRowCellValue(i, dtgvdata.Columns(j))
                ElseIf dtgvdata.Columns(j).ColumnType Is GetType(Date) AndAlso dtgvdata.GetRowCellValue(i, dtgvdata.Columns(j)).ToString.Trim <> "" Then
                    BangTinh.Cells(i + 1 + 2, j + 1) = CDate(dtgvdata.GetRowCellValue(i, dtgvdata.Columns(j))).ToString("dd/MM/yyyy")
                Else
                    BangTinh.Cells(i + 1 + 2, j + 1) = "'" & dtgvdata.GetRowCellValue(i, dtgvdata.Columns(j)).ToString
                End If
            Next
        Next
        WorkB.SaveAs(filename)
        WorkB.Close()
        App.Quit()
        MsgBoxF("Đã chuyển thành công ra file Excel:  " & filename, MsgType.Information)
        Shell("explorer /select," & filename, AppWinStyle.NormalFocus)
    End Sub
    Private Function GetCells(ByVal vitri As Integer) As String
        'Lấy cột kết thúc khi gộp tiêu đề Excel
        'A:1 B:2 C:3 D:4 E:5 F:6 G:7 H:8 I:9 J:10 K:11 L:12
        Select Case vitri
            Case 1
                Return "a1"
            Case 2
                Return "b1"
            Case 3
                Return "c1"
            Case 4
                Return "d1"
            Case 5
                Return "e1"
            Case 6
                Return "f1"
            Case 7
                Return "g1"
            Case 8
                Return "h1"
            Case 9
                Return "i1"
            Case 10
                Return "j1"
            Case 11
                Return "k1"
            Case 12
                Return "l1"
        End Select
        Return "o1"
    End Function
    Function iSoNgayTrongThang(ByVal iThang As Integer, ByVal iNam As Integer) As Integer
        Return Date.DaysInMonth(iNam, iThang)
    End Function
    Public Function FormatNumber(ByVal Expression As Object, Optional ByVal NumDigitsAfterDecimal As Integer = -1,
                                 Optional ByVal defa As Object = 0, Optional ByVal Nguyendinhdang As Boolean = False)
        If _
            Expression Is Nothing OrElse IsDBNull(Expression) OrElse Not IsNumeric(Expression) OrElse
            Expression.ToString = "Infinity" Then Return defa
        If NumDigitsAfterDecimal > 15 Then NumDigitsAfterDecimal = 15
        If Expression \ 1 = Expression Then
            If Nguyendinhdang Then
                Return Microsoft.VisualBasic.FormatNumber(Expression, NumDigitsAfterDecimal)
            Else
                Return Microsoft.VisualBasic.FormatNumber(Expression, 0)
            End If
        Else
            If NumDigitsAfterDecimal = -1 Then
                Expression = Math.Round(CDbl(Expression), 2, MidpointRounding.AwayFromZero) _
                ' Do dùng FormatNumber thì 2035.4999999999998 =2036 --> Nhục
            Else
                Expression = Math.Round(CDbl(Expression), NumDigitsAfterDecimal, MidpointRounding.AwayFromZero) _
                ' Do dùng FormatNumber thì 2035.4999999999998 =2036 --> Nhục
            End If
            Dim numb As String = Microsoft.VisualBasic.FormatNumber(Expression, NumDigitsAfterDecimal)
            If Not Nguyendinhdang Then
                While _
                    numb.Contains(",") AndAlso
                    (numb.Substring(numb.Length - 1) = "0" OrElse numb.Substring(numb.Length - 1) = ",")
                    numb = numb.Substring(0, numb.Length - 1)
                End While
            End If
            Return numb
        End If
    End Function
#End Region

End Module
