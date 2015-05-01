Imports System.Management
Imports Microsoft.Win32

Public Class OpenInfo

#Region " Information caller Methods "

	''' <summary>
	''' Use to get System Information in WMI which wont have multiple objects
	''' </summary>
	''' <remarks></remarks>

	Public Function WMI_Single(ByVal Key As String, ByRef subKey As String, ByVal DontInsertNull As Boolean)
		Dim value As String = String.Empty
		Try
			Dim WMIsearcher As New ManagementObjectSearcher("select * from " & Key)
			For Each manObjct As ManagementObject In WMIsearcher.Get()

				If manObjct.Properties.Count <= 0 Then
					Return "No Information available"
					Exit Function
				End If

				For Each propertyValues As PropertyData In manObjct.Properties
					If propertyValues.Name = subKey Then
						If propertyValues.Value IsNot Nothing AndAlso propertyValues.Value.ToString() <> "" Then
							Select Case propertyValues.Value.GetType().ToString()
								Case "System.String[]"
									Dim str() As String = CType(propertyValues.Value, String())

									Dim str2 As String = ""
									For Each st As String In str
										str2 &= st & " "
									Next st

									value = str2

								Case "System.UInt16[]"
									Dim shortData() As UShort = CType(propertyValues.Value, UShort())


									Dim tstr2 As String = ""
									For Each st As UShort In shortData
										tstr2 &= st.ToString() & " "
									Next st

									value = tstr2

								Case Else
									value = propertyValues.Value.ToString()

							End Select
							If Not DontInsertNull Then
								value = "No Information available"
							Else
								Continue For
							End If
						End If
					End If
				Next

			Next
		Catch ex As Exception
			value = "Eror" & " " & ex.Message.ToString
		End Try

		Return value
	End Function

	Public Sub WMI_InsertInfo(ByVal Key As String, ByRef lst As ListView, ByVal DontInsertNull As Boolean)

		Try
			lst.Items.Clear()
			Dim section As New ManagementObjectSearcher("select * from " & Key)
			For Each systemObject As ManagementObject In section.Get()
				Dim grp As ListViewGroup
				Try
					grp = lst.Groups.Add(systemObject("Name").ToString(), systemObject("Name").ToString())
				Catch
					grp = lst.Groups.Add("Default", "Default")
				End Try

				For Each propertyDta As PropertyData In systemObject.Properties

					Dim itm As New ListViewItem(grp)
					If lst.Items.Count Mod 2 <> 0 Then
						itm.BackColor = Color.White
					Else
						itm.BackColor = Color.WhiteSmoke
					End If

					itm.Text = propertyDta.Name

					If propertyDta.Value IsNot Nothing AndAlso propertyDta.Value.ToString() <> "" Then
						Select Case propertyDta.Value.GetType().ToString()
							Case "System.String[]"
								Dim str() As String = CType(propertyDta.Value, String())
								Dim str2 As String = ""
								For Each st As String In str
									str2 &= st & " "
								Next st
								itm.SubItems.Add(str2)
							Case "System.UInt16[]"
								Dim shortData() As UShort = CType(propertyDta.Value, UShort())

								Dim tstr2 As String = ""
								For Each st As UShort In shortData
									tstr2 &= st.ToString() & " "
								Next st
								itm.SubItems.Add(tstr2)
							Case Else
								itm.SubItems.Add(propertyDta.Value.ToString())
						End Select
					Else
						If Not DontInsertNull Then
							itm.SubItems.Add("N/A")
						Else
							Continue For
						End If
					End If
					lst.Items.Add(itm)
				Next propertyDta
			Next systemObject
		Catch exp As Exception
			MessageBox.Show("Can't get data because of the followeing error " & vbLf & exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End Try

	End Sub

#End Region

#Region " Operating System "

	Dim OS_Key As String = "Win32_OperatingSystem"

	Public Function OS_Name() As String
		Try
			Return (WMI_Single(OS_Key, "Caption", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_SerialNumber() As String
		Try
			Return WMI_Single(OS_Key, "SerialNumber", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_Edition() As String
		Try
			Dim Regpath As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion"
			Dim RK As RegistryKey = Registry.LocalMachine.OpenSubKey(Regpath, True)
			Dim Edition As String = RK.GetValue("EditionID")
			Return Edition
		Catch
			Return "Error"
		End Try
	End Function

	Public Function OS_ProductKey() As String
		Try
			Dim Regpath As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion"
			Dim RK As RegistryKey
			RK = Registry.LocalMachine.OpenSubKey(Regpath, True)

			Dim hexbuf As Object = RK.GetValue("DigitalProductId")

			If hexbuf Is Nothing Then Return "n/a"

			Dim tmp As String = ""

			For l As Integer = LBound(hexbuf) To UBound(hexbuf)
				tmp = tmp & " " & Hex(hexbuf(l))
			Next

			Dim startoffset As Integer = 52
			Dim endoffset As Integer = 67
			Dim digits(24) As String

			digits(0) = "B" : digits(1) = "C" : digits(2) = "D" : digits(3) = "F"
			digits(4) = "G" : digits(5) = "H" : digits(6) = "J" : digits(7) = "K"
			digits(8) = "M" : digits(9) = "P" : digits(10) = "Q" : digits(11) = "R"
			digits(12) = "T" : digits(13) = "V" : digits(14) = "W" : digits(15) = "X"
			digits(16) = "Y" : digits(17) = "2" : digits(18) = "3" : digits(19) = "4"
			digits(20) = "6" : digits(21) = "7" : digits(22) = "8" : digits(23) = "9"

			Dim dlen As Integer = 29
			Dim slen As Integer = 15
			Dim hexdigitalpid(15) As String
			Dim des(30) As String

			Dim tmp2 As String = ""

			For i = startoffset To endoffset
				hexdigitalpid(i - startoffset) = hexbuf(i)
				tmp2 = tmp2 & " " & Hex(hexdigitalpid(i - startoffset))
			Next

			Dim keystring As String = ""

			For i As Integer = dlen - 1 To 0 Step -1
				If ((i + 1) Mod 6) = 0 Then
					des(i) = "-"
					keystring = keystring & "-"
				Else
					Dim hn As Integer = 0
					For n As Integer = (slen - 1) To 0 Step -1
						Dim value As Integer = ((hn * 2 ^ 8) Or hexdigitalpid(n))
						hexdigitalpid(n) = value \ 24
						hn = (value Mod 24)
					Next
					des(i) = digits(hn)
					keystring = keystring & digits(hn)
				End If
			Next
			Return StrReverse(keystring)
		Catch ex As Exception
			Return Nothing
		End Try
	End Function

	Public Function OS_Version() As String
		Try
			Return WMI_Single(OS_Key, "Version", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_Manufacturer() As String
		Try
			Return WMI_Single(OS_Key, "Manufacturer", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_Servicepack() As String
		Try
			Return WMI_Single(OS_Key, "CSDVersion", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_ServicePackMajorVersion() As String
		Try
			Return WMI_Single(OS_Key, "ServicePackMajorVersion", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_ServicePackMinorVersion() As String
		Try
			Return WMI_Single(OS_Key, "ServicePackMinorVersion", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_BuildNumber() As String
		Try
			Return WMI_Single(OS_Key, "BuildNumber", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_OSArchitecture() As String
		Try
			Return WMI_Single(OS_Key, "OSArchitecture", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_InstallDate() As String
		Try
			Dim installDatePath As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion\"
			Dim RegKey As RegistryKey = Registry.LocalMachine.OpenSubKey(installDatePath, False)
			Dim startDate As DateTime
			Dim regVal As Int64
			startDate = New DateTime(1970, 1, 1, 0, 0, 0)
			regVal = Convert.ToInt64(RegKey.GetValue("InstallDate").ToString())
			Return startDate.AddSeconds(regVal)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_LastBootUpTime() As String
		Try
			Dim startDate As DateTime
			Dim envTicks As Integer = Environment.TickCount
			Dim msToAdd = envTicks - (envTicks * 2)
			startDate = DateTime.Now.AddMilliseconds(msToAdd)
			Return startDate
		Catch ex As Exception
			Return ex.Message
		End Try
	End Function

	Public Function OS_UpTime() As String
		Try
			Dim nTicks As Double
			Dim nDays As Integer
			Dim nHours As Integer
			Dim nMin As Integer
			Dim nSec As Integer
			nTicks = Environment.TickCount
			nTicks = nTicks / 1000
			nDays = Int(nTicks / (3600 * 24))
			nTicks = nTicks - (Int(nTicks / (3600 * 24)) * (3600 * 24))
			nHours = Int(nTicks / 3600)
			nTicks = nTicks - (Int(nTicks / 3600) * 3600)
			nMin = Int(nTicks / 60)
			nTicks = nTicks - (Int(nTicks / 60) * 60)
			nSec = nTicks
			Return nDays & " d" & " " & nHours & " h" & " " & nMin & " min" & " " & nSec & " sec"
		Catch ex As Exception
			Return ex.Message
		End Try
	End Function

	Public Function OS_NumberOfUsers() As String
		Try
			Return WMI_Single(OS_Key, "NumberOfUsers", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_Organization() As String
		Try
			Return WMI_Single(OS_Key, "Organization", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_SystemDrive() As String
		Try
			Return WMI_Single(OS_Key, "SystemDrive", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_WindowsDirectory() As String
		Try
			Return WMI_Single(OS_Key, "WindowsDirectory", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function OS_EncryptionLevel() As String
		Try
			Return WMI_Single(OS_Key, "EncryptionLevel", True)
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	''' <summary>
	''' Get paths of Special Folders -(Cookies,,Desktop,DesktopDirectory,Favorites,Fonts,History,InternetCache,LocalApplicationData,MyComputer etc,ProgramFiles,ProgramFilesX86,Programs,Recent,SendTo,StartMenu,Startup,System,SystemX86,Windows)
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>

	Public Function OS_SystemFolders_Windows(ByVal folder As String) As String
		Dim path As String = String.Empty
		If folder = "Cookies" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.Cookies)
		ElseIf folder = "Desktop" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
		ElseIf folder = "DesktopDirectory" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
		ElseIf folder = "Favorites" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.Favorites)
		ElseIf folder = "Fonts" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.Fonts)
		ElseIf folder = "History" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.History)
		ElseIf folder = "InternetCache" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache)
		ElseIf folder = "LocalApplicationData" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
		ElseIf folder = "MyComputer" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
		ElseIf folder = "MyDocuments" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
		ElseIf folder = "MyMusic" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)
		ElseIf folder = "MyPictures" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		ElseIf folder = "MyVideos" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)
		ElseIf folder = "ProgramFiles" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
		ElseIf folder = "ProgramFilesX86" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)
		ElseIf folder = "Programs" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.Programs)
		ElseIf folder = "Recent" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.Recent)
		ElseIf folder = "SendTo" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.SendTo)
		ElseIf folder = "StartMenu" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu)
		ElseIf folder = "Startup" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
		ElseIf folder = "System" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.System)
		ElseIf folder = "SystemX86" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86)
		ElseIf folder = "Windows" Then
			path = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
		Else
			path = "N\A"
		End If
		Return path
	End Function

	Public Function OS_Installed_dotnet_FrameWorks() As String
		Dim installed_Frameworks As String = String.Empty

		Using regkey As RegistryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey("SOFTWARE\Microsoft\NET Framework Setup\NDP\")

			For Each versionKeyName As String In regkey.GetSubKeyNames()
				If versionKeyName.StartsWith("v") Then
					Dim versionKey As RegistryKey = regkey.OpenSubKey(versionKeyName)
					Dim name As String = CStr(versionKey.GetValue("Version", ""))
					Dim sp As String = versionKey.GetValue("SP", "").ToString
					Dim install As String = versionKey.GetValue("Install", "")
					If install = "" Then
						installed_Frameworks = installed_Frameworks & "\" & versionKeyName & " " & name
					Else
						If sp <> "" AndAlso install = "1" Then
							installed_Frameworks = installed_Frameworks & "\" & versionKeyName & " " & name & " :SP" & sp
						End If
					End If
					If name <> "" Then
						Continue For
					End If
					For Each subKeyName As String In versionKey.GetSubKeyNames()
						Dim subKey As RegistryKey = versionKey.OpenSubKey(subKeyName)
						name = CStr(subKey.GetValue("Version", ""))
						If name <> "" Then
							sp = subKey.GetValue("SP", "").ToString
						End If
						install = subKey.GetValue("Install", "").ToString
						If install = "" Then
							installed_Frameworks = installed_Frameworks & "/" & versionKeyName & " " & name

						Else
							If sp <> "" AndAlso install = "1" Then
								installed_Frameworks = installed_Frameworks & "/" & subKeyName.ToString & " " & name & " :SP" & sp
							ElseIf install = "1" Then
								installed_Frameworks = installed_Frameworks & "/" & subKeyName.ToString & " " & name
							End If

						End If
					Next subKeyName
				End If
			Next versionKeyName
		End Using
		Return installed_Frameworks
	End Function

#End Region

#Region " Time Zone "

	Dim timeKey As String = "Win32_TimeZone"

	Public Function time_Zone() As String
		Try
			Return (WMI_Single(timeKey, "Caption", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function time_DaylightName() As String
		Try
			Return (WMI_Single(timeKey, "DaylightName", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function time_Description() As String
		Try
			Return (WMI_Single(timeKey, "Description", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

#End Region

#Region " CPU "
	Dim CPU_Key As String = "Win32_Processor"

	Public Function CPU_Name() As String
		Try
			Return (WMI_Single(CPU_Key, "Name", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function CPU_Description() As String
		Try
			Return (WMI_Single(CPU_Key, "Description", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function CPU_Manufacturer() As String
		Try
			Return (WMI_Single(CPU_Key, "Manufacturer", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function
	''' <summary>
	''' Base clock in MHz
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function CPU_BusSpeed() As String
		Try
			Return (WMI_Single(CPU_Key, "ExtClock", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function
	''' <summary>
	''' ClockSpeed in MHz
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function CPU_CurrentClockSpeed() As String
		Try
			Return (WMI_Single(CPU_Key, "CurrentClockSpeed", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function CPU_Socket() As String
		Try
			Return (WMI_Single(CPU_Key, "SocketDesignation", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function CPU_ProcessorId() As String
		Try
			Return (WMI_Single(CPU_Key, "ProcessorId", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function CPU_Architecture() As String
		Try
			Return (WMI_Single(CPU_Key, "Architecture", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function CPU_AddressWidth() As String
		Try
			Return (WMI_Single(CPU_Key, "AddressWidth", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function CPU_DataWidth() As String
		Try
			Return (WMI_Single(CPU_Key, "DataWidth", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function CPU_NumberOfCores() As String
		Try
			Return (WMI_Single(CPU_Key, "NumberOfCores", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function CPU_NumberOfThreads() As String
		Try
			Return (WMI_Single(CPU_Key, "NumberOfLogicalProcessors", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function
	''' <summary>
	'''L2  Cache Size in Mb
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function CPU_L2CacheSize() As String
		Try
			Return (WMI_Single(CPU_Key, "L2CacheSize", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function
	''' <summary>
	''' L3  Cache Size in Mb
	''' </summary>
	''' <returns></returns>
	''' <remarks></remarks>
	Public Function CPU_L3CacheSize() As String
		Try
			Return (WMI_Single(CPU_Key, "L3CacheSize", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function
#End Region

#Region " RAM "
	''' <summary>
	''' Enter unit as  MB,GB or Default
	''' </summary>
	''' <param name="unit"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	''' 
	Public Function RAM_totalPhyMemory(ByVal unit As String) As String
		Try
			Dim totalPhisicalMemory As Double = My.Computer.Info.TotalPhysicalMemory
			Dim value As String = String.Empty
			If unit = "GB" Then
				value = CInt(totalPhisicalMemory / 1073741824) & " " & "GB"
			ElseIf unit = "MB" Then
				value = CInt(totalPhisicalMemory / 1048576) & " " & "MB"
			ElseIf unit = "Default" Then
				value = totalPhisicalMemory & " " & "bytes"
			End If

			Return value
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	''' <summary>
	''' Enter unit as  MB,GB or Default
	''' </summary>
	''' <param name="unit"></param>
	''' <returns></returns>
	''' <remarks></remarks>
	''' 
	Public Function RAM_totalVirlMemory(ByVal unit As String) As String
		Try
			Dim totalVirtualMemory As Double = My.Computer.Info.TotalVirtualMemory
			Dim value As String = String.Empty
			If unit = "GB" Then
				value = CInt(totalVirtualMemory / 1073741824) & " " & "GB"
			ElseIf unit = "MB" Then
				value = CInt(totalVirtualMemory / 1048576) & " " & "MB"
			ElseIf unit = "Default" Then
				value = totalVirtualMemory & " " & "bytes"
			End If

			Return value
		Catch ex As Exception
			Return "Error"
		End Try
	End Function
#End Region

#Region " MainBoard "
	Dim mainBoard_Key As String = "Win32_BaseBoard"

	Public Function baseBoard_Product() As String
		Try
			Return (WMI_Single(mainBoard_Key, "Product", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function baseBoard_Manufacturer() As String
		Try
			Return (WMI_Single(mainBoard_Key, "Manufacturer", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function baseBoard_SerialNumber() As String
		Try
			Return (WMI_Single(mainBoard_Key, "SerialNumber", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

	Public Function baseBoard_Version() As String
		Try
			Return (WMI_Single(mainBoard_Key, "Version", True))
		Catch ex As Exception
			Return "Error"
		End Try
	End Function

#End Region

End Class