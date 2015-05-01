Public Class frmLoading

#Region " Form "
	Private Sub frmLoading_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

		Me.Icon = My.Resources.Icon
	End Sub
#End Region

#Region " Timer "

	Private Sub timer_load_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_load.Tick
		Try
			If prograssBarLoading.Value = 25 Then
				lbl_loading.Text = "."
				frmMain.app_startup()
				frmMain.windows_info()
				frmMain.getBIOS()
			End If
			If prograssBarLoading.Value = 50 Then
				lbl_loading.Text = ". ."
				timer_load.Enabled = False
				frmControllers.getIDEControllers()
				frmControllers.getUSBControllers()
				frmSpecialFolders.loadpaths()
				frmEnvironmentVariebles.getEnvironmentalVari()
				frmInstalledprograms.getInstalledPrograms()
				timer_load.Enabled = True
			End If

			If prograssBarLoading.Value = 75 Then
				lbl_loading.Text = ". . . "
				timer_load.Enabled = False
				frmMain.getCPU()
				frmMain.getPhysicalRAM()
				frmMain.getGPU()
				frmMain.getMonitors()
				frmMain.getStorage()
				frmMain.getOpticalDrives()
				frmMain.getSound()
				frmMain.getModems()
				timer_load.Enabled = True
			End If

			If prograssBarLoading.Value = 100 Then
				frmMain.Show()
				timer_load.Enabled = False
				Me.Hide()
			End If
			If prograssBarLoading.Value <= 75 Then prograssBarLoading.Value = prograssBarLoading.Value + 25
		Catch ex As Exception
			MsgBox("Error Occured .Exiting" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error")
			End
		End Try
	End Sub

#End Region

End Class