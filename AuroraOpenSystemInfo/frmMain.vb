Imports OpenHardwareMonitor.Hardware
Imports System.Management
Imports System.Security.Principal

Public Class frmMain
	
#Region " Declerations "
	Dim my_computer As New Computer()
	Dim principal = New WindowsPrincipal(WindowsIdentity.GetCurrent())
	Dim isElevated As Boolean = principal.IsInRole(WindowsBuiltInRole.Administrator)
#End Region

#Region " Functions "

	Public Sub app_startup()
		Try
			Me.Icon = My.Resources.Icon
			load_images()
			timer_RAM_use.Enabled = True
		Catch ex As Exception
			End
		End Try
	End Sub

	Public Sub getBIOS()
		openSysInfo.WMI_InsertInfo("Win32_BIOS", Me.lstBIOS, True)
	End Sub

	Public Sub getCPU()
		openSysInfo.WMI_InsertInfo("Win32_Processor", Me.lstCPU, True)
	End Sub

	Public Sub getPhysicalRAM()
		openSysInfo.WMI_InsertInfo("Win32_PhysicalMemory", Me.lstRAMInfo, True)
	End Sub

	Public Sub getGPU()
		openSysInfo.WMI_InsertInfo("Win32_VideoController", Me.lstGraphicAdapter, True)
	End Sub

	Public Sub getMonitors()
		openSysInfo.WMI_InsertInfo("Win32_DesktopMonitor", Me.lstMonitors, True)
	End Sub

	Public Sub getStorage()
		openSysInfo.WMI_InsertInfo("Win32_LogicalDisk", Me.LstStorage, True)
	End Sub

	Public Sub getOpticalDrives()
		openSysInfo.WMI_InsertInfo("Win32_CDROMDrive", Me.lstOptical, True)
	End Sub

	Public Sub getSound()
		openSysInfo.WMI_InsertInfo("Win32_SoundDevice", Me.lstSound, True)
	End Sub

	Public Sub getModems()
		openSysInfo.WMI_InsertInfo("Win32_POTSModem", Me.lstModem, True)
	End Sub
	
	Private Function getFromOpenHardwareMonitor(ByVal HardwareTyp As HardwareType, ByVal sensorName As String) As Double

		Try
			my_computer.Open()
			my_computer.RAMEnabled = True

			For Each hardware In my_computer.Hardware
				If hardware.HardwareType = HardwareTyp Then
					hardware.Update()

					For Each sensor In hardware.Sensors
						If sensor.Name = sensorName Then
							If sensor.Value IsNot Nothing Then
								Return CDec(sensor.Value)
								Exit Function
							End If
						End If
					Next
				End If
			Next
		Catch ex As Exception
			Return 0
		End Try
		Return 0

	End Function

	Private Sub setRAM_Usage()
		Try
			Dim tP_Ram, tV_Ram, aP_Ram, aV_Ram, uP_Ram, uV_Ram As Double

			aP_Ram = getFromOpenHardwareMonitor(HardwareType.RAM, "Available Memory")
			uP_Ram = getFromOpenHardwareMonitor(HardwareType.RAM, "Used Memory")

			tP_Ram = Format((((My.Computer.Info.TotalPhysicalMemory) / 1024) / 1024) / 1024, "Standard")
			tV_Ram = Format((((My.Computer.Info.TotalVirtualMemory) / 1024) / 1024) / 1024, "Standard")
			aV_Ram = Format((((My.Computer.Info.AvailableVirtualMemory) / 1024) / 1024) / 1024, "Standard")

			uP_Ram = Format((uP_Ram), "Standard")
			aP_Ram = Format((aP_Ram), "Standard")
			uV_Ram = Format((tV_Ram - aV_Ram), "Standard")

			txtPhysicalRAM.Text = openSysInfo.RAM_totalPhyMemory("GB")
			txtVirtualRAM.Text = openSysInfo.RAM_totalVirlMemory("GB")

			txtP_RAM_Free.Text = aP_Ram
			txtV_RAM_Free.Text = aV_Ram

			txtP_RAM_Used.Text = uP_Ram
			txtV_RAM_Used.Text = uV_Ram

		Catch ex As Exception
		End Try

	End Sub

	Private Sub load_images()
		picBx_windows.BackgroundImage = My.Resources.SystemInfo_Side_Windows_W7
		picBx_CPU.BackgroundImage = My.Resources.SystemInfo_Side_Systemdevices
		picBx_RAM.BackgroundImage = My.Resources.SystemInfo_Side_Systemdevices
		picBx_GPU.BackgroundImage = My.Resources.SystemInfo_Side_Display
		picBx_Storage.BackgroundImage = My.Resources.SystemInfo_Side_Overview
		picBx_Multi.BackgroundImage = My.Resources.SystemInfo_Side_IODevices
	End Sub

	Public Sub windows_info()
		Try
			lstWindows.Items.Add("NAME").SubItems.Add(openSysInfo.OS_Name)
			If isElevated Then
				lstWindows.Items.Add("Edition").SubItems.Add(openSysInfo.OS_Edition)
			Else
				lstWindows.Items.Add("Edition").SubItems.Add("--- Administrator rights required ---")
			End If

			lstWindows.Items.Add("Architecture").SubItems.Add(openSysInfo.OS_OSArchitecture)
			lstWindows.Items.Add("Version").SubItems.Add(openSysInfo.OS_Version)
			lstWindows.Items.Add("BuildNumber").SubItems.Add(openSysInfo.OS_BuildNumber)
			lstWindows.Items.Add("Service Pack").SubItems.Add(openSysInfo.OS_Servicepack)
			If isElevated Then
				lstWindows.Items.Add("Product ID").SubItems.Add(openSysInfo.OS_SerialNumber)
				lstWindows.Items.Add("Product Key").SubItems.Add(openSysInfo.OS_ProductKey)
			Else
				lstWindows.Items.Add("Product ID").SubItems.Add("--- Administrator rights required ---")
				lstWindows.Items.Add("Product Key").SubItems.Add("--- Administrator rights required ---")
			End If
			lstWindows.Items.Add("OS Manufacturer").SubItems.Add(openSysInfo.OS_Manufacturer)

			lstWindows.Items.Add(" ")
			If isElevated Then
				lstWindows.Items.Add("Encryption Level").SubItems.Add(openSysInfo.OS_EncryptionLevel & " " & "bit")
			Else
				lstWindows.Items.Add("Encryption Level").SubItems.Add("--- Administrator rights required ---")
			End If
			lstWindows.Items.Add("System Drive").SubItems.Add(openSysInfo.OS_SystemDrive)
			lstWindows.Items.Add("Windows Directory").SubItems.Add(openSysInfo.OS_WindowsDirectory)

			lstWindows.Items.Add(" ")

			lstWindows.Items.Add("Installed Date").SubItems.Add(openSysInfo.OS_InstallDate)
			lstWindows.Items.Add("Last Start up").SubItems.Add(openSysInfo.OS_LastBootUpTime)
			lstWindows.Items.Add("Up Time").SubItems.Add(openSysInfo.OS_UpTime)
			lstWindows.Items.Add("No of Users").SubItems.Add(openSysInfo.OS_NumberOfUsers)
			lstWindows.Items.Add("Organization").SubItems.Add(openSysInfo.OS_Organization)

			lstWindows.Items.Add(" ")
			lstWindows.Items.Add("Installed .Net FrameWorks")

			Dim lst_item As New ListViewItem()
			Dim frameworks As String() = openSysInfo.OS_Installed_dotnet_FrameWorks.Split("\".ToCharArray())

			For Each dotnet As String In frameworks

				If Not dotnet = "" Then
					If dotnet.Contains("/") Then
						Dim mainversions As String() = dotnet.Split("/")
						Dim mainversion As String = mainversions(0)
						lstWindows.Items.Add("    " & mainversion)
						Dim subversion As String = dotnet.Substring(dotnet.IndexOf("/"c) + 1)
						Dim versions As String() = subversion.Split("/".ToCharArray)
						For Each ver As String In versions
							lstWindows.Items.Add("        " & ver)
						Next
					Else
						Dim sp As String = dotnet.Substring(dotnet.IndexOf(":"c) + 1)
						lstWindows.Items.Add("    " & dotnet.Substring(0, dotnet.IndexOf(" "))).SubItems.Add(sp)
					End If

				End If
			Next dotnet
		Catch ex As Exception
		End Try

	End Sub

#End Region

#Region " Form "

	Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		frmLoading.Close()
	End Sub

#End Region

#Region " GUI "

	Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
		End
	End Sub

	Private Sub btnSpecialFolders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpecialFolders.Click
		frmSpecialFolders.ShowDialog()
	End Sub

	Private Sub btnInstalledPrograms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstalledPrograms.Click
		frmInstalledprograms.ShowDialog()
	End Sub

	Private Sub btnEnviVar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviVar.Click
		frmEnvironmentVariebles.ShowDialog()
	End Sub

	Private Sub btnControllers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControllers.Click
		frmControllers.ShowDialog()
	End Sub

#End Region

#Region " Timers "

	Private Sub timer_RAM_use_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_RAM_use.Tick
		setRAM_Usage()
	End Sub

#End Region

End Class