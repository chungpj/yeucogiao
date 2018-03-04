Namespace My
    Partial Friend Class MyApplication
        Sub UpdateData()
            CultureInfo = Threading.Thread.CurrentThread.CurrentCulture
            Dim fc As New Globalization.CultureInfo("en-NZ", True)
            fc.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
            fc.DateTimeFormat.ShortTimePattern = "HH:mm:ss"
            fc.DateTimeFormat.AMDesignator = "AM"
            fc.DateTimeFormat.PMDesignator = "PM"
            fc.DateTimeFormat.DateSeparator = "/"
            fc.NumberFormat.CurrencyDecimalSeparator = ","
            fc.NumberFormat.CurrencyGroupSeparator = "."
            fc.NumberFormat.NumberDecimalSeparator = ","
            fc.NumberFormat.NumberGroupSeparator = "."
            fc.TextInfo.ListSeparator = ";"
            Threading.Thread.CurrentThread.CurrentCulture = fc
            Threading.Thread.CurrentThread.CurrentUICulture = fc
        End Sub
        Protected Overrides Function OnStartup(ByVal eventArgs As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) As Boolean
            UpdateData()
            If Not IO.File.Exists(My.Application.Info.DirectoryPath & "\config.sys") Then
                'Config
                frmKetNoi.ShowDialog()
            End If
            If Not TaoKNdulieu() Then
                MsgBoxF("Có lỗi khi kết nối đến máy chủ !!!", MsgType.Error_)
                End
            End If

            Return MyBase.OnStartup(eventArgs)
        End Function
    End Class
End Namespace

