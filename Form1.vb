Imports System.Runtime.InteropServices

Public Class Form1

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function PostMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function LockWorkStation() As Boolean
    End Function

    Private Const WM_SYSCOMMAND = &H112
    Private Const SC_MONITORPOWER = &HF170

    Private Const MONITOR_ON = -1
    Private Const MONITOR_OFF = 2
    Private Const MONITOR_STANDBY = 1

    Private Sub btnTurnOff_Click(sender As Object, e As EventArgs) Handles btnTurnOff.Click
        PostMessage(Me.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF)
        End
    End Sub

    Private Sub btnOffAndLock_Click(sender As Object, e As EventArgs) Handles btnOffAndLock.Click
        LockWorkStation()
        PostMessage(Me.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF)
        End
    End Sub

End Class
