Public Module DBXpoUtil

    Public Sub CopyCollection(Source As DevExpress.Xpo.XPCollection, ByRef Destination As DevExpress.Xpo.XPCollection)
        Dim t As DevExpress.Xpo.DB.DBTable = Source.ObjectClassInfo.Table
        Dim SourceObject As DevExpress.Xpo.XPObject
        Dim DestObject As DevExpress.Xpo.XPObject
        Destination.LoadingEnabled = False
        Destination.Reload()
        For conta As Integer = 0 To Source.Count - 1
            SourceObject = Source(conta)
            DestObject = SourceObject.ClassInfo.CreateNewObject(Destination.Session)
            For Each c As DevExpress.Xpo.DB.DBColumn In t.Columns
                If c.IsIdentity = False Then
                    DestObject.SetMemberValue(c.Name, SourceObject.GetMemberValue(c.Name))
                End If
            Next
            Destination.Add(DestObject)
        Next
    End Sub
End Module
