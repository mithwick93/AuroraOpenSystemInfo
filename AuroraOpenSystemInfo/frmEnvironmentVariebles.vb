﻿Public Class frmEnvironmentVariebles

#Region " Functions "
	Public Sub getEnvironmentalVari()
		openSysInfo.WMI_InsertInfo("Win32_Environment", Me.lstEnvironmentVariebles, True)
	End Sub

#End Region

#Region " GUI "
	Private Sub frmEnvironmentVariebles_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
		If e.KeyCode = Keys.Escape Then
			Me.Close()
		End If
	End Sub
#End Region
	
End Class