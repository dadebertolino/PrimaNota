
Imports Microsoft.Win32
Public NotInheritable Class RegistryAccess
    Private Const SOFTWARE_KEY As String = "Software"
   
    Public Shared Function GetStringRegistryValue(ByVal key As String, ByVal defaultValue As String, CreaChiave As Boolean) As String
        Dim rkCompany As RegistryKey
        Dim rkApplication As RegistryKey
        rkCompany = Registry.CurrentUser.OpenSubKey(SOFTWARE_KEY, False).OpenSubKey(DBSistemiString, False)
        If Not (rkCompany Is Nothing) Then
            rkApplication = rkCompany.OpenSubKey(BaseLib.Application.ApplicationName, True)
            If Not (rkApplication Is Nothing) Then
                Dim sKEY As String
                For Each sKEY In rkApplication.GetValueNames()
                    If (sKEY = key) Then
                        Return rkApplication.GetValue(sKEY).ToString
                    End If
                Next
                If CreaChiave = True Then
                    rkApplication.SetValue(key, defaultValue)
                End If
            End If
        End If
        Return defaultValue
    End Function


    Public Shared Sub SetStringRegistryValue(ByVal key As String, ByVal stringValue As String)
        Dim rkSoftware As RegistryKey
        Dim rkCompany As RegistryKey
        Dim rkApplication As RegistryKey
        rkSoftware = Registry.CurrentUser.OpenSubKey(SOFTWARE_KEY, True)
        rkCompany = rkSoftware.CreateSubKey(DBSistemiString)
        If Not (rkCompany Is Nothing) Then
            rkApplication = rkCompany.CreateSubKey(BaseLib.Application.ApplicationName)
            If Not (rkApplication Is Nothing) Then
                rkApplication.SetValue(key, stringValue)
            End If
        End If
    End Sub



End Class