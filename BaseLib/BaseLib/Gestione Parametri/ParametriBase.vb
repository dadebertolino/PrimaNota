Public Class ParametriBase
    Private dsPar As dsParametri
    Private dsParFileName As String

#Region " Constructors "

    Public Sub New(NomeFile As String)
        Dim di As New IO.DirectoryInfo(SettingPath)
        Dim fi_array() As IO.FileInfo
        Dim tbElencoImpianti As New dsElencoImpianti.ElencoImpiantiDataTable
        fi_array = di.GetFiles(NomeFile & "*.xml")
        For Each fileInfo As IO.FileInfo In fi_array
            If fileInfo.Name = "MyShopFidelity.xml" Then
            Else
                Dim NomeFileImpianto As String = fileInfo.Name
                NomeFileImpianto = NomeFileImpianto.Substring(0, NomeFileImpianto.Length - 4)
                If NomeFileImpianto = NomeFile Then
                Else
                    NomeFileImpianto = NomeFileImpianto.Replace(NomeFile, "")
                End If
                tbElencoImpianti.AddElencoImpiantiRow(NomeFileImpianto, fileInfo.Name)
            End If
        Next
        If tbElencoImpianti.Rows.Count = 1 Then
            NomeFile = tbElencoImpianti(0).FileParametri
        ElseIf fi_array.Length > 1 Then
            Using frm As New frmScegliImpianto
                For Each RigaElencoImpianti As dsElencoImpianti.ElencoImpiantiRow In tbElencoImpianti
                    frm.DsElencoImpianti.ElencoImpianti.AddElencoImpiantiRow(RigaElencoImpianti.Nome, RigaElencoImpianti.FileParametri)
                Next
                frm.ShowDialog()
                NomeFile = tbElencoImpianti.FindByID(frm.LookUpEdit1.EditValue).FileParametri
            End Using
        Else
            NomeFile = NomeFile & ".xml"
        End If
        'If Not NomeFile.ToUpper.EndsWith(".XML") Then
        '    
        'End If
        Dim DataDir As String = SettingPath
        dsParFileName = IO.Path.Combine(DataDir, NomeFile)
        Dim fi As New IO.FileInfo(dsParFileName)
        dsPar = New dsParametri
        If fi.Exists = True Then
            dsPar.ReadXml(dsParFileName)
        End If
    End Sub

#End Region

    Public Function GetKeyValueString(NomeKey As String, DefaultValue As String) As String
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, DefaultValue)
            Return DefaultValue
        End If
        Return PAR_R.Valore
    End Function

    Public Function GetKeyValueBoolean(NomeKey As String, DefaultValue As Boolean) As Boolean
        Dim DefValueString As String = "0"
        If DefaultValue = True Then
            DefValueString = "1"
        End If
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, DefValueString)
            Return DefaultValue
        End If
        If PAR_R.Valore = "0" Then
            Return False
        End If
        Return True
    End Function

    Public Function GetKeyValueInteger(NomeKey As String, DefaultValue As Integer) As Integer
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, DefaultValue)
            Return DefaultValue
        End If
        Return Integer.Parse(PAR_R.Valore)
    End Function

    Public Function GetKeyValueDecimal(NomeKey As String, DefaultValue As Decimal) As Decimal
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, DefaultValue)
            Return DefaultValue
        End If
        Return Decimal.Parse(PAR_R.Valore)
    End Function

    Public Function GetKeyValueDate(NomeKey As String, DefaultValue As Date) As Date
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, DefaultValue)
            Return DefaultValue
        End If
        Return Date.Parse(PAR_R.Valore)
    End Function

    Public Sub SetKeyValueString(NomeKey As String, Value As String)
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, Value)
        End If
        PAR_R.Valore = Value
    End Sub

    Public Sub SetKeyValueBoolean(NomeKey As String, Value As Boolean)
        Dim ValueString As String = "0"
        If Value = True Then
            ValueString = "1"
        End If
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, ValueString)
        End If
        PAR_R.Valore = ValueString
    End Sub

    Public Sub SetKeyValueInteger(NomeKey As String, Value As Integer)
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, Value.ToString)
        End If
        PAR_R.Valore = Value.ToString
    End Sub

    Public Sub SetKeyValueDecimal(NomeKey As String, Value As Decimal)
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, Value.ToString)
        End If
        PAR_R.Valore = Value.ToString
    End Sub

    Public Sub SetKeyValueDate(NomeKey As String, Value As Date)
        Dim PAR_R As dsParametri.ParametriRow = Me.dsPar.Parametri.FindByNome(NomeKey)
        If PAR_R Is Nothing Then
            Me.dsPar.Parametri.AddParametriRow(NomeKey, Value.ToString)
        End If
        PAR_R.Valore = Value.ToString
    End Sub

    Public Sub SaveParameters()
        dsPar.WriteXml(dsParFileName)
    End Sub
#Region " Private Fields "



#End Region

#Region " Events "



#End Region

#Region " Protected Properties "



#End Region

#Region " Public Properties "



#End Region

#Region " Private Methods "



#End Region

#Region " Protected Methods "



#End Region

#Region " Public Methods "



#End Region

End Class
