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

Imports System.Runtime.InteropServices

Namespace Win32.ApiCalls

    ''' <summary>
    ''' Helper class containing User32 API calls.
    ''' </summary>
    Public Class User32

#Region " Public Fields "

        Public Const WH_JOURNALRECORD As Integer = 0
        Public Const WH_JOURNALPLAYBACK As Integer = 1
        Public Const WH_KEYBOARD As Integer = 2
        Public Const WH_GETMESSAGE As Integer = 3
        Public Const WH_CALLWNDPROC As Integer = 4
        Public Const WH_CBT As Integer = 5
        Public Const WH_SYSMSGFILTER As Integer = 6
        Public Const WH_MOUSE As Integer = 7
        Public Const WH_HARDWARE As Integer = 8
        Public Const WH_DEBUG As Integer = 9
        Public Const WH_SHELL As Integer = 10
        Public Const WH_FOREGROUNDIDLE As Integer = 11
        Public Const WH_CALLWNDPROCRET As Integer = 12
        Public Const WH_KEYBOARD_LL As Integer = 13
        Public Const WH_MOUSE_LL As Integer = 14

#End Region

#Region " Public Methods "

        ''' <summary>
        ''' Calls the next low level hook in the given chain.
        ''' </summary>
        ''' <param name="HookHandle"></param>
        ''' <param name="Code"></param>
        ''' <param name="wParam"></param>
        ''' <param name="lParam"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DllImport("user32.dll")> _
        Public Shared Function CallNextHookEx(ByVal HookHandle As IntPtr, ByVal Code As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        End Function

        ''' <summary>
        ''' Gets the location of the mouse cursor.
        ''' </summary>
        ''' <param name="CursorPoint"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DllImport("user32.dll")> _
        Public Shared Function GetCursorPos(ByRef CursorPoint As Point) As Boolean
        End Function

        ''' <summary>
        ''' Gets the IntPtr referencing the handle to the desktop window.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DllImport("user32.dll")> _
        Public Shared Function GetDesktopWindow() As IntPtr
        End Function

        ''' <summary>
        ''' Gets the IntPtr referencing the handle to the device context for the window specified
        ''' by the given IntPtr.
        ''' </summary>
        ''' <param name="hWND"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DllImport("user32.dll")> _
        Public Shared Function GetWindowDC(ByVal hWND As IntPtr) As IntPtr
        End Function

        ''' <summary>
        ''' Gest the RECT structure for the bounds of the window specified by the given hWnd.
        ''' </summary>
        ''' <param name="hWND"></param>
        ''' <param name="rect"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DllImport("user32.dll")> _
        Public Shared Function GetWindowRect(ByVal hWND As IntPtr, ByRef rect As RECT) As IntPtr
        End Function

        ''' <summary>
        ''' Releases the device context specified by the given IntPtr.
        ''' </summary>
        ''' <param name="hWND"></param>
        ''' <param name="hDC"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DllImport("user32.dll")> _
        Public Shared Function ReleaseDC(ByVal hWND As IntPtr, ByVal hDC As IntPtr) As IntPtr
        End Function

        ''' <summary>
        ''' Adds a low level hook to the windows hook chain.
        ''' </summary>
        ''' <param name="HookType"></param>
        ''' <param name="HookCallback"></param>
        ''' <param name="ModuleHandle"></param>
        ''' <param name="ThreadId"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DllImport("user32.dll")> _
        Public Shared Function SetWindowsHookEx(ByVal HookType As Integer, ByVal HookCallback As HookCallbackDelegate, ByVal ModuleHandle As IntPtr, ByVal ThreadId As Integer) As IntPtr
        End Function

        ''' <summary>
        ''' Removes the low level hook from the windows hook chain specified by the given IntPtr.
        ''' </summary>
        ''' <param name="HookHandle"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <DllImport("user32.dll")> _
        Public Shared Function UnhookWindowsHookEx(ByVal HookHandle As IntPtr) As Integer
        End Function

#End Region

#Region " Nested Types "

        ''' <summary>
        ''' Describes a method that will be used as a callback by a low level hook.
        ''' </summary>
        ''' <param name="Code"></param>
        ''' <param name="wParam"></param>
        ''' <param name="lParam"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Delegate Function HookCallbackDelegate(ByVal Code As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer

        ''' <summary>
        ''' A structure referenced by the lParam of a low level WH_CALLWNDPROC hook.
        ''' </summary>
        ''' <remarks></remarks>
        Public Structure CWPSTRUCT
            Public lParam As IntPtr
            Public wParam As IntPtr
            Public Message As Integer
            Public hWnd As IntPtr
        End Structure

        ''' <summary>
        ''' A structure referenced by the lParam of a low level WH_GETMESSAGE hook.
        ''' </summary>
        ''' <remarks></remarks>
        Public Structure MSG
            Public hWnd As Integer
            Public Message As Integer
            Public wParam As Integer
            Public lParam As Integer
            Public Time As Integer
            Public Pt As Point
        End Structure

        ''' <summary>
        ''' A structure referenced by the device context and window bounds API calls.
        ''' </summary>
        ''' <remarks></remarks>
        <StructLayout(LayoutKind.Sequential)> _
        Public Structure RECT
            Public left As Integer
            Public top As Integer
            Public right As Integer
            Public bottom As Integer
        End Structure

#End Region

    End Class

End Namespace
