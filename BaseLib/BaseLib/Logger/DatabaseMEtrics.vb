'Imports Gibraltar.Agent.Metrics

'<EventMetric("yourApplicationName", "Database", "Query", Caption:="Database Query Performance", Description:="Performance data for every database query")> _
Public Class DatabaseMetric
    Implements IDisposable

    Private ReadOnly m_StopWatch As Stopwatch
    Public Sub New(_query As String)
        Query = _query
        m_StopWatch = Stopwatch.StartNew()
        'by default assume we're going to succeed - that way we don't have to explicitly add this
        'to every place we record a metric.
        Result = "Success"
    End Sub
    '<EventMetricValue("queryName", SummaryFunction.Count, Nothing, Caption:="Query Name", Description:="The name of the stored procedure or query that was executed")> _
    Public Property Query() As String
        Get
            Return m_Query
        End Get
        Private Set(value As String)
            m_Query = value
        End Set
    End Property
    Private m_Query As String

    '<EventMetricValue("rowCount", SummaryFunction.Average, Nothing, Caption:="Rows", Description:="The number of rows returned by the query")> _
    Public Property Rows() As Integer
        Get
            Return m_Rows
        End Get
        Set(value As Integer)
            m_Rows = value
        End Set
    End Property
    Private m_Rows As Integer

    '<EventMetricValue("duration", SummaryFunction.Average, "ms", Caption:="Duration", Description:="Duration of the query execution", IsDefaultValue:=True)> _
    Public Property Duration() As TimeSpan
        Get
            Return m_Duration
        End Get
        Private Set(value As TimeSpan)
            m_Duration = value
        End Set
    End Property
    Private m_Duration As TimeSpan

    '<EventMetricValue("result", SummaryFunction.Count, Nothing, Caption:="Result", Description:="The result of the query; Success or an error message.")> _
    Public Property Result() As String
        Get
            Return m_Result
        End Get
        Set(value As String)
            m_Result = value
        End Set
    End Property
    Private m_Result As String

    ''' <summary>
    ''' Stops the timer and records the metric
    ''' </summary>
    Public Sub Dispose() Implements System.IDisposable.Dispose
        m_StopWatch.[Stop]()
        Duration = m_StopWatch.Elapsed
        'EventMetric.Write(Me)
    End Sub

End Class