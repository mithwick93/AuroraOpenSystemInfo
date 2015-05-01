Public Class frmControllers

#Region " Functions "
	Public Sub getIDEControllers()
		openSysInfo.WMI_InsertInfo("Win32_IDEController", Me.lstIDE, True)
	End Sub

	Public Sub getUSBControllers()
		openSysInfo.WMI_InsertInfo("Win32_USBController", Me.lstUSB, True)
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