Public Class frmSpecialFolders

#Region " Functions "

	Public Sub loadpaths()
		lstSpecialFolders.Items.Clear()
		lstSpecialFolders.Items.Add("Cookies").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.Cookies.ToString))
		lstSpecialFolders.Items.Add("Desktop").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.Desktop.ToString))
		lstSpecialFolders.Items.Add("Desktop Directory").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.DesktopDirectory.ToString))
		lstSpecialFolders.Items.Add("Favorites").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.Favorites.ToString))
		lstSpecialFolders.Items.Add("Fonts").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.Fonts.ToString))
		lstSpecialFolders.Items.Add("History").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.History.ToString))
		lstSpecialFolders.Items.Add("Internet Cache").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.InternetCache.ToString))
		lstSpecialFolders.Items.Add("Local Application Data").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.LocalApplicationData.ToString))
		lstSpecialFolders.Items.Add(" ")
		lstSpecialFolders.Items.Add("My Computer").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.MyComputer.ToString))
		lstSpecialFolders.Items.Add("My Documents").SubItems.Add(openSysInfo.OS_SystemFolders_Windows("MyDocuments"))
		lstSpecialFolders.Items.Add("My Music").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.MyMusic.ToString))
		lstSpecialFolders.Items.Add("My Pictures").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.MyPictures.ToString))
		lstSpecialFolders.Items.Add("My Pictures").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.MyPictures.ToString))
		lstSpecialFolders.Items.Add(" ")
		lstSpecialFolders.Items.Add("Program Files").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.ProgramFiles.ToString))
		If Environment.Is64BitOperatingSystem Then
			lstSpecialFolders.Items.Add("Program Files X86").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.ProgramFilesX86.ToString))
		End If
		lstSpecialFolders.Items.Add("Programs").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.Programs.ToString))
		lstSpecialFolders.Items.Add(" ")
		lstSpecialFolders.Items.Add("Recent").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.Recent.ToString))
		lstSpecialFolders.Items.Add("Send To").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.SendTo.ToString))
		lstSpecialFolders.Items.Add("Star tMenu").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.StartMenu.ToString))
		lstSpecialFolders.Items.Add("Start up").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.Startup.ToString))
		lstSpecialFolders.Items.Add("System").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.System.ToString))
		If Environment.Is64BitOperatingSystem Then
			lstSpecialFolders.Items.Add("SystemX 86").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.SystemX86.ToString))
		End If
		lstSpecialFolders.Items.Add("Windows").SubItems.Add(openSysInfo.OS_SystemFolders_Windows(Environment.SpecialFolder.Windows.ToString))
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