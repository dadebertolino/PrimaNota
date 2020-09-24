Public Class ProgressControl

    Public Enum OSProgressStyleConstants
        osLEFTTORIGHT
        osLEFTANDRIGHT
    End Enum

    Public Enum OSProgressTypeConstants
        osBOXTYPE
        osGRAPHICTYPE
    End Enum
    Public Enum OSProgressBoxStyleConstants
        osSOLIDSAMESIZE
        osBOXAROUND
        osSOLIDBIGGER
        osSOLIDSMALLER
    End Enum

    Private _SpeedMultiPlier As Byte = 2
    Private _RequireClear As Boolean = False
    Private _Graphics As Graphics
    Private _Increasing As Boolean = True

    Private WithEvents tmrAutoProgress As New System.Windows.Forms.Timer
    Private _ProgressType As OSProgressTypeConstants = OSProgressTypeConstants.osBOXTYPE
    Private Function ShouldSerializeProgressType() As Boolean
        Return _ProgressType <> OSProgressTypeConstants.osBOXTYPE
    End Function
    <System.ComponentModel.Description("Determines the type of progress bar")> Public Property ProgressType() As OSProgressTypeConstants
        Get
            Return (_ProgressType)
        End Get
        Set(ByVal value As OSProgressTypeConstants)
            _ProgressType = value
            Me.Invalidate()
        End Set
    End Property

    Private _NormalImage As Image
    Private Function ShouldSerializeNormalImage() As Boolean
        If _NormalImage Is Nothing Then
            Return False
        End If
        Return True
    End Function

    <System.ComponentModel.Description("Gets/sets the background graphic")> Public Property NormalImage() As Image
        Get
            Return _NormalImage
        End Get
        Set(ByVal value As Image)
            _NormalImage = value
            Me.Invalidate()
        End Set
    End Property
    Private _PointImage As Image
    Private Function ShouldSerializePointImage() As Boolean
        If _PointImage Is Nothing Then
            Return False
        End If
        Return True
    End Function

    <System.ComponentModel.Description("Gets/sets the point graphic")> Public Property PointImage() As Image
        Get
            Return _PointImage
        End Get
        Set(ByVal value As Image)
            _PointImage = value
            Me.Invalidate()
        End Set
    End Property
    Private _ShowBorder As Boolean = True

    <System.ComponentModel.Description("Determines if the border is shown"), System.ComponentModel.DefaultValue(True)> Public Property ShowBorder() As Boolean
        Get
            Return _ShowBorder
        End Get
        Set(ByVal value As Boolean)
            _ShowBorder = value
            Me.Invalidate()
        End Set
    End Property

    Private _NumPoints As Integer
    <System.ComponentModel.Description("Number of points in the progressbar"), System.ComponentModel.Browsable(False)> Public ReadOnly Property NumPoints() As Integer
        Get
            Return _NumPoints
        End Get
    End Property

    Private _Position As Integer

    <System.ComponentModel.Description("Position of the progress indicator"), System.ComponentModel.Browsable(False)> Public Property Position() As Integer
        Get
            Return _Position
        End Get
        Set(ByVal value As Integer)
            _Position = value
            Me.Invalidate()
        End Set
    End Property

    Private _IndicatorColor As Color = Color.Red
    Private Function ShouldSerializeIndicatorColor() As Boolean
        Return _IndicatorColor <> Color.Red
    End Function

    <System.ComponentModel.Description("Color of the indicator")> Public Property IndicatorColor() As Color
        Get
            Return _IndicatorColor
        End Get
        Set(ByVal value As Color)
            _IndicatorColor = value
            Me.Invalidate()
        End Set
    End Property

    Private _ProgressStyle As OSProgressStyleConstants = OSProgressStyleConstants.osLEFTTORIGHT

    Private Function ShouldSerializeProgressStyle() As Boolean
        Return _ProgressStyle <> OSProgressStyleConstants.osLEFTTORIGHT
    End Function

    <System.ComponentModel.Description("Indicates the progress indicator rotation style")> Public Property ProgressStyle() As OSProgressStyleConstants
        Get
            Return _ProgressStyle
        End Get
        Set(ByVal value As OSProgressStyleConstants)
            _ProgressStyle = value
            Me.Invalidate()
        End Set
    End Property

    Private _AutoProgress As Boolean = False
    <System.ComponentModel.Description("Indicates whether auto-progress is enabled"), System.ComponentModel.DefaultValue(False)> Public Property AutoProgress() As Boolean
        Get
            Return _AutoProgress
        End Get
        Set(ByVal value As Boolean)
            Me.tmrAutoProgress.Interval = (255 - Me._AutoProgressSpeed) * Me._SpeedMultiPlier
            If (value = True) Then
                Me.tmrAutoProgress.Start()
            Else
                Me.tmrAutoProgress.Stop()
            End If
            _AutoProgress = value
        End Set
    End Property

    Private _AutoProgressSpeed As Integer = 100
    Private Function ShouldSerializeAutoProgressSpeed() As Boolean
        Return _AutoProgressSpeed <> 100
    End Function

    <System.ComponentModel.Description("Indicates the speed of the progress indicator (1 [slower] to 254 [faster]")> Public Property AutoProgressSpeed() As Integer
        Get
            Return _AutoProgressSpeed
        End Get
        Set(ByVal value As Integer)
            If (value < 1) Then
                value = 1
            ElseIf (value > 254) Then
                value = 254
            End If
            tmrAutoProgress.Stop()
            tmrAutoProgress.Interval = (255 - value) * _SpeedMultiPlier
            tmrAutoProgress.Enabled = Me._AutoProgress
            _AutoProgressSpeed = value
        End Set
    End Property
    Private _ProgressBoxStyle As OSProgressBoxStyleConstants = OSProgressBoxStyleConstants.osSOLIDSAMESIZE
    Private Function ShouldSerializeProgressBoxStyle() As Boolean
        Return _ProgressBoxStyle <> OSProgressBoxStyleConstants.osSOLIDSAMESIZE
    End Function

    Public Property ProgressBoxStyle() As OSProgressBoxStyleConstants
        Get
            Return _ProgressBoxStyle
        End Get
        Set(ByVal value As OSProgressBoxStyleConstants)
            _ProgressBoxStyle = value
            Me.Invalidate()
        End Set
    End Property

    Private Sub ResizeHandler(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me._RequireClear = True
        Me._Position = 0
        Me.Invalidate()
    End Sub

    Private Sub TimerHandler(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrAutoProgress.Tick
        If (Me._Position = Me._NumPoints - 1) Then
            If (Me._ProgressStyle = OSProgressStyleConstants.osLEFTTORIGHT) Then
                Me._Position = 0
            Else
                Me._Position -= 1
            End If
            Me._Increasing = False
        ElseIf (Me._Position = 0 And Me._Increasing = False) Then
            Me._Position += 1
            Me._Increasing = True
        Else
            If Me._Increasing Then
                Me._Position += 1
            Else
                Me._Position -= 1
            End If
        End If
        Me._RequireClear = False
        Me.Invalidate()
    End Sub

    Private Sub PaintHandler(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Me._Graphics = e.Graphics
        Me._Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed

        If (Me._RequireClear) Then
            Me._Graphics.Clear(Me.BackColor)
        End If
        DrawBackground()
    End Sub
    Private Sub DrawBackground()
        Me._NumPoints = 0
        If (Me.Width > 0 And Me.Height > 0) Then
            If Me._ShowBorder Then
                Me._Graphics.DrawRectangle(New Pen(SystemColors.ActiveBorder), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
            End If
            Dim iBoxSize As Integer = CInt(Me.Height * 0.75)
            Dim iBoxLeft As Integer = CInt(iBoxSize / 2)
            If (iBoxSize > 3) Then
                Do
                    Dim r As Rectangle = New Rectangle(iBoxLeft, 0, Me.Height - 1, Me.Height - 1)
                    If (r.Left + r.Width > Me.Width) Then
                        Exit Do
                    End If
                    If (Me._NumPoints = Me._Position) Then
                        PositionIndicator(r)
                    Else
                        Dim r2 As Rectangle = New Rectangle(r.Left + 3, r.Top + 3, r.Width - 6, r.Height - 6)
                        If ((Not Me._NormalImage Is Nothing) And (Me._ProgressType = OSProgressTypeConstants.osGRAPHICTYPE)) Then
                            Me._Graphics.DrawImage(Me._NormalImage, r2)
                        Else
                            Me._Graphics.FillRectangle(New SolidBrush(Me.ForeColor), r2)
                        End If
                    End If
                    iBoxLeft += CType(iBoxSize * 1.5, Integer)
                    Me._NumPoints += 1
                Loop
            End If
        End If
    End Sub
    Private Sub PositionIndicator(ByVal Rect As Rectangle)
        If ((Not Me._PointImage Is Nothing) And (Me._ProgressType = OSProgressTypeConstants.osGRAPHICTYPE)) Then
            Me._Graphics.DrawImage(Me._PointImage, Rect)
        Else
            Dim R2 As Rectangle
            If (Me.ProgressBoxStyle = OSProgressBoxStyleConstants.osSOLIDSAMESIZE) Then
                R2 = New Rectangle(Rect.Left + 3, Rect.Top + 3, Rect.Width - 5, Rect.Height - 5)
                Me._Graphics.FillRectangle(New SolidBrush(_IndicatorColor), R2)
            ElseIf (Me.ProgressBoxStyle = OSProgressBoxStyleConstants.osBOXAROUND) Then
                Me._Graphics.DrawRectangle(New Pen(_IndicatorColor), Rect)
                R2 = New Rectangle(Rect.Left + 3, Rect.Top + 3, Rect.Width - 5, Rect.Height - 5)
                Me._Graphics.FillRectangle(New SolidBrush(_IndicatorColor), R2)
            ElseIf (Me.ProgressBoxStyle = OSProgressBoxStyleConstants.osSOLIDBIGGER) Then
                Me._Graphics.FillRectangle(New SolidBrush(_IndicatorColor), Rect)
            ElseIf (Me.ProgressBoxStyle = OSProgressBoxStyleConstants.osSOLIDSMALLER) Then
                R2 = New Rectangle(Rect.Left + 5, Rect.Top + 5, Rect.Width - 9, Rect.Height - 9)
                Me._Graphics.FillRectangle(New SolidBrush(_IndicatorColor), R2)
            End If
        End If
    End Sub

End Class
