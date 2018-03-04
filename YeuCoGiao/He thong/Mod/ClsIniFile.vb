Public Class ClsIniFile
#Region "Đọc ghi nội dung từ file text tương tự như Regedit trên máy Client"
    Private Declare Unicode Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringW" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Int32
    Private Declare Unicode Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringW" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Int32, ByVal lpFileName As String) As Int32
    ''' <summary>
    ''' Ghi nội dung ra Text File
    ''' </summary>
    ''' <param name="lpKyeName">Khoá nhận biết dữ liệu</param>
    ''' <param name="lpApplicationName">Khoá nhận biết chương trình</param>
    ''' <param name="lpFileName">Đường dẫn Text File lưu dữ liệu</param>
    ''' <value>Giá trị muốn lưu</value>
    ''' <remarks></remarks>
    Public WriteOnly Property WriteString(ByVal lpKyeName As String, Optional ByVal lpApplicationName As String = "Establish Connection", Optional ByVal lpFileName As String = Nothing) As String
        Set(ByVal lpString As String)
            If IsNothing(lpFileName) Then lpFileName = (My.Application.Info.DirectoryPath & "\config.config").Replace("\\", "\")
            Call WritePrivateProfileString(lpApplicationName, lpKyeName, lpString, lpFileName)
        End Set
    End Property
    ''' <summary>
    ''' Lấy nội dung từ File Text
    ''' </summary>
    ''' <param name="lpKyeName">Khoá nhận biết dữ liệu</param>
    ''' <param name="lpDefault">Giá trị mặc định xẽ nhận khi không có giá trị trả ra</param>
    ''' <param name="lpApplicationName">Khoá nhận biết chương trình</param>
    ''' <param name="lpFileName">Đường dẫn Text File lưu dữ liệu</param>
    ''' <value>Giá trị trả ra</value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ReadString(ByVal lpKyeName As String, Optional ByVal lpDefault As String = "", Optional ByVal lpApplicationName As String = "Establish Connection", Optional ByVal lpFileName As String = Nothing) As String
        Get
            If IsNothing(lpFileName) Then lpFileName = (My.Application.Info.DirectoryPath & "\config.config").Replace("\\", "\")
            Dim lpReturnedString As String = Space$(1024)
            Dim iLen As Int32 = GetPrivateProfileString(lpApplicationName, lpKyeName, lpDefault, lpReturnedString, lpReturnedString.Length, lpFileName)
            Return lpReturnedString.Substring(0, iLen)
        End Get
    End Property
#End Region
End Class
