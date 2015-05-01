Imports System.Management

Public Class getFromWMI

	Public Sub InsertInfo(ByVal Key As String, ByRef lst As ListView, ByVal DontInsertNull As Boolean)

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
End Class