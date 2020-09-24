Public Module TableHelper
    Public Sub CopyTable(ByRef SourceTable As DataTable, ByRef DestinationTable As DataTable)
        If SourceTable Is Nothing Then
            Exit Sub
        End If
        If DestinationTable Is Nothing Then
            Exit Sub
        End If
        DestinationTable.Clear()
        DestinationTable.AcceptChanges()
        Dim RigaSorgente As DataRow
        Dim RigaDestinazione As DataRow
        For Each RigaSorgente In SourceTable.Rows
            DestinationTable.ImportRow(RigaSorgente)
            RigaDestinazione = DestinationTable.NewRow
        Next
        For Each RigaSorgente In DestinationTable.Rows
            RigaSorgente.SetAdded()
        Next
    End Sub
End Module
