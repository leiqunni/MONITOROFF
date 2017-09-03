# MONITOROFF

MONITOROFF is a tool to turn off monitor's power.

## Project Description

This code is for code studying.
This is written by Visual Basic .NET and .NET 4.6.

This application's function is only this.

    Private Const WM_SYSCOMMAND = &H112
    Private Const SC_MONITORPOWER = &HF170

    Private Const MONITOR_ON = -1
    Private Const MONITOR_OFF = 2
    Private Const MONITOR_STANDBY = 1

    Private Sub btnTurnOff_Click(sender As Object, e As EventArgs) Handles btnTurnOff.Click
        PostMessage(Me.Handle, WM_SYSCOMMAND, SC_MONITORPOWER, MONITOR_OFF)
        End
    End Sub

But if monitor turn on when raising event something (ex. GPU working for GPGPU),
It has to send message frequencyly by timer.

# Source Control

Using Team Foundation Server not Git.

# Project License

Simplified BSD License (BSD)
