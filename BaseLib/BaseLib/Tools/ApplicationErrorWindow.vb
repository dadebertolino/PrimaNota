'============================================================================================
' ? Copyright, 2005-2008 MicroFour, Inc., All rights reserved.
'
' This software and its associated documentation contain valuable trade secrets 
' and proprietary information belonging to MicroFour, Inc.  None of the software
' or its associated documentation may be stored in a retrieval system, copied,
' transmitted, distributed, transcribed or reproduced in any other way or disclosed
' to any third parties without the express written permission of MicroFour, Inc.  
'
' UNDER NO CIRCUMSTANCES SHALL MICROFOUR, INC. BE LIABLE FOR INCIDENTAL, SPECIAL,
' INDIRECT, DIRECT OR CONSEQUENTIAL DAMAGES OR LOSS OF PROFITS, INTERRUPTION OF 
' BUSINESS, OR RELATED EXPENSES WHICH MAY ARISE FROM THE USE OF SOFTWARE OR DOCUMENTATION, 
' INCLUDING BUT NOT LIMITED TO THOSE RESULTING FROM DEFECTS IN SOFTWARE AND/OR DOCUMENTATION,
' OR LOSS OR INACCURACY OF DATA OF ANY KIND.
'--------------------------------------------------------------------------------------------
' ANY USE OF THIS CODE CONSTITUTES ACCEPTANCE OF THE TERMS OF THE COPYRIGHT NOTICE
'--------------------------------------------------------------------------------------------
' DO NOT REMOVE THIS DISCLAIMER
'============================================================================================

Public Class ApplicationErrorWindow

#Region " Constructors "
    Private TestoEccezione As String
    Private RagSocErr As String
    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal Ex As Exception, RagSoc As String)
        MyBase.New()
        RagSocErr = RagSoc
        If Threading.Thread.CurrentThread.IsThreadPoolThread Then
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.LookAndFeel.UserLookAndFeel.Default.Assign(Application.Skin)
        End If

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Text = Application.ApplicationName

        Dim TestoFinestra As String = "Si è verificata una situazione non prevista" & Environment.NewLine & "Il programma verrà chiuso. Se la situazione si ripete contattare DBSistemi" & Environment.NewLine
        Me.lcTesto.Text = TestoFinestra
        '-- Set the gradient information
        'GradientFormHeader1.Title = Ex.Message

        TestoEccezione = Tools.Exceptions.CreateExceptionDetails(Ex)
        BaseLib.DBLogger.AddLogError(TestoEccezione)

        '-- Set the body text to the output
        txtError.Text = TestoEccezione
        txtError.Font = New System.Drawing.Font("Courier New", 8, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)

        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
    End Sub

#End Region

    Private Sub btnSimpleEmail_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpleEmail.Click
        Dim TMSB As New System.Text.StringBuilder
        TMSB.AppendLine("Installazione: " & RagSocErr)
        TMSB.AppendLine("Programma: " & Application.ApplicationName)
        TMSB.AppendLine("Versione: " & Application.ApplicationVersion)
        TMSB.AppendLine("Testo eccezione: ")
        TMSB.Append(Me.TestoEccezione)
        Me.Close()
    End Sub

    Private Sub BaseButton1_Click(sender As System.Object, e As System.EventArgs) Handles BaseButton1.Click
        Me.Close()
    End Sub
End Class

