<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.picBx_windows = New System.Windows.Forms.PictureBox()
		Me.TabCntrl = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.GroupBox5 = New System.Windows.Forms.GroupBox()
		Me.lstBIOS = New System.Windows.Forms.ListView()
		Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.btnEnviVar = New System.Windows.Forms.Button()
		Me.btnInstalledPrograms = New System.Windows.Forms.Button()
		Me.btnSpecialFolders = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lstWindows = New System.Windows.Forms.ListView()
		Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.lstCPU = New System.Windows.Forms.ListView()
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.picBx_CPU = New System.Windows.Forms.PictureBox()
		Me.TabPage3 = New System.Windows.Forms.TabPage()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.txtV_RAM_Free = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.txtV_RAM_Used = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtP_RAM_Free = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtP_RAM_Used = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtPhysicalRAM = New System.Windows.Forms.TextBox()
		Me.txtVirtualRAM = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.lstRAMInfo = New System.Windows.Forms.ListView()
		Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.picBx_RAM = New System.Windows.Forms.PictureBox()
		Me.TabPage4 = New System.Windows.Forms.TabPage()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.lstMonitors = New System.Windows.Forms.ListView()
		Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.lstGraphicAdapter = New System.Windows.Forms.ListView()
		Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.picBx_GPU = New System.Windows.Forms.PictureBox()
		Me.TabPage5 = New System.Windows.Forms.TabPage()
		Me.btnControllers = New System.Windows.Forms.Button()
		Me.GroupBox6 = New System.Windows.Forms.GroupBox()
		Me.lstOptical = New System.Windows.Forms.ListView()
		Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.LstStorage = New System.Windows.Forms.ListView()
		Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.TabPage6 = New System.Windows.Forms.TabPage()
		Me.picBx_Multi = New System.Windows.Forms.PictureBox()
		Me.GroupBox7 = New System.Windows.Forms.GroupBox()
		Me.lstModem = New System.Windows.Forms.ListView()
		Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GroupBox8 = New System.Windows.Forms.GroupBox()
		Me.lstSound = New System.Windows.Forms.ListView()
		Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.cmdExit = New System.Windows.Forms.Button()
		Me.timer_RAM_use = New System.Windows.Forms.Timer(Me.components)
		Me.picBx_Storage = New System.Windows.Forms.PictureBox()
		CType(Me.picBx_windows, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabCntrl.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.GroupBox5.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		CType(Me.picBx_CPU, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage3.SuspendLayout()
		CType(Me.picBx_RAM, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage4.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.picBx_GPU, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TabPage5.SuspendLayout()
		Me.GroupBox6.SuspendLayout()
		Me.GroupBox4.SuspendLayout()
		Me.TabPage6.SuspendLayout()
		CType(Me.picBx_Multi, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox7.SuspendLayout()
		Me.GroupBox8.SuspendLayout()
		CType(Me.picBx_Storage, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picBx_windows
		'
		Me.picBx_windows.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picBx_windows.Location = New System.Drawing.Point(3, 6)
		Me.picBx_windows.Name = "picBx_windows"
		Me.picBx_windows.Size = New System.Drawing.Size(235, 567)
		Me.picBx_windows.TabIndex = 0
		Me.picBx_windows.TabStop = False
		'
		'TabCntrl
		'
		Me.TabCntrl.Controls.Add(Me.TabPage1)
		Me.TabCntrl.Controls.Add(Me.TabPage2)
		Me.TabCntrl.Controls.Add(Me.TabPage3)
		Me.TabCntrl.Controls.Add(Me.TabPage4)
		Me.TabCntrl.Controls.Add(Me.TabPage5)
		Me.TabCntrl.Controls.Add(Me.TabPage6)
		Me.TabCntrl.Location = New System.Drawing.Point(4, 2)
		Me.TabCntrl.Name = "TabCntrl"
		Me.TabCntrl.SelectedIndex = 0
		Me.TabCntrl.Size = New System.Drawing.Size(928, 605)
		Me.TabCntrl.TabIndex = 1
		'
		'TabPage1
		'
		Me.TabPage1.BackColor = System.Drawing.Color.White
		Me.TabPage1.Controls.Add(Me.GroupBox5)
		Me.TabPage1.Controls.Add(Me.btnEnviVar)
		Me.TabPage1.Controls.Add(Me.btnInstalledPrograms)
		Me.TabPage1.Controls.Add(Me.btnSpecialFolders)
		Me.TabPage1.Controls.Add(Me.GroupBox1)
		Me.TabPage1.Controls.Add(Me.picBx_windows)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(920, 579)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Windows"
		'
		'GroupBox5
		'
		Me.GroupBox5.Controls.Add(Me.lstBIOS)
		Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox5.Location = New System.Drawing.Point(244, 284)
		Me.GroupBox5.Name = "GroupBox5"
		Me.GroupBox5.Size = New System.Drawing.Size(659, 260)
		Me.GroupBox5.TabIndex = 2
		Me.GroupBox5.TabStop = False
		Me.GroupBox5.Text = "BIOS"
		'
		'lstBIOS
		'
		Me.lstBIOS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14})
		Me.lstBIOS.GridLines = True
		Me.lstBIOS.Location = New System.Drawing.Point(15, 21)
		Me.lstBIOS.Name = "lstBIOS"
		Me.lstBIOS.Size = New System.Drawing.Size(627, 228)
		Me.lstBIOS.TabIndex = 1
		Me.lstBIOS.UseCompatibleStateImageBehavior = False
		Me.lstBIOS.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader13
		'
		Me.ColumnHeader13.Text = ""
		Me.ColumnHeader13.Width = 200
		'
		'ColumnHeader14
		'
		Me.ColumnHeader14.Text = ""
		Me.ColumnHeader14.Width = 375
		'
		'btnEnviVar
		'
		Me.btnEnviVar.Location = New System.Drawing.Point(410, 550)
		Me.btnEnviVar.Name = "btnEnviVar"
		Me.btnEnviVar.Size = New System.Drawing.Size(140, 24)
		Me.btnEnviVar.TabIndex = 14
		Me.btnEnviVar.Text = "Environmental Variables"
		Me.btnEnviVar.UseVisualStyleBackColor = True
		'
		'btnInstalledPrograms
		'
		Me.btnInstalledPrograms.Location = New System.Drawing.Point(556, 550)
		Me.btnInstalledPrograms.Name = "btnInstalledPrograms"
		Me.btnInstalledPrograms.Size = New System.Drawing.Size(140, 24)
		Me.btnInstalledPrograms.TabIndex = 13
		Me.btnInstalledPrograms.Text = "Installed Programs"
		Me.btnInstalledPrograms.UseVisualStyleBackColor = True
		'
		'btnSpecialFolders
		'
		Me.btnSpecialFolders.Location = New System.Drawing.Point(264, 550)
		Me.btnSpecialFolders.Name = "btnSpecialFolders"
		Me.btnSpecialFolders.Size = New System.Drawing.Size(140, 24)
		Me.btnSpecialFolders.TabIndex = 12
		Me.btnSpecialFolders.Text = "Special Folders"
		Me.btnSpecialFolders.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lstWindows)
		Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.Location = New System.Drawing.Point(244, 6)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(659, 272)
		Me.GroupBox1.TabIndex = 1
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Windows"
		'
		'lstWindows
		'
		Me.lstWindows.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
		Me.lstWindows.GridLines = True
		Me.lstWindows.Location = New System.Drawing.Point(15, 21)
		Me.lstWindows.Name = "lstWindows"
		Me.lstWindows.Size = New System.Drawing.Size(627, 228)
		Me.lstWindows.TabIndex = 1
		Me.lstWindows.UseCompatibleStateImageBehavior = False
		Me.lstWindows.View = System.Windows.Forms.View.Details
		'
		'columnHeader1
		'
		Me.columnHeader1.Text = ""
		Me.columnHeader1.Width = 200
		'
		'columnHeader2
		'
		Me.columnHeader2.Text = ""
		Me.columnHeader2.Width = 375
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.lstCPU)
		Me.TabPage2.Controls.Add(Me.picBx_CPU)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(920, 579)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "CPU"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'lstCPU
		'
		Me.lstCPU.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
		Me.lstCPU.GridLines = True
		Me.lstCPU.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.lstCPU.Location = New System.Drawing.Point(288, 6)
		Me.lstCPU.Name = "lstCPU"
		Me.lstCPU.Size = New System.Drawing.Size(600, 567)
		Me.lstCPU.TabIndex = 2
		Me.lstCPU.UseCompatibleStateImageBehavior = False
		Me.lstCPU.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = ""
		Me.ColumnHeader3.Width = 200
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = ""
		Me.ColumnHeader4.Width = 375
		'
		'picBx_CPU
		'
		Me.picBx_CPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picBx_CPU.Location = New System.Drawing.Point(3, 6)
		Me.picBx_CPU.Name = "picBx_CPU"
		Me.picBx_CPU.Size = New System.Drawing.Size(235, 567)
		Me.picBx_CPU.TabIndex = 1
		Me.picBx_CPU.TabStop = False
		'
		'TabPage3
		'
		Me.TabPage3.Controls.Add(Me.Label7)
		Me.TabPage3.Controls.Add(Me.Label8)
		Me.TabPage3.Controls.Add(Me.txtV_RAM_Free)
		Me.TabPage3.Controls.Add(Me.Label9)
		Me.TabPage3.Controls.Add(Me.txtV_RAM_Used)
		Me.TabPage3.Controls.Add(Me.Label10)
		Me.TabPage3.Controls.Add(Me.Label6)
		Me.TabPage3.Controls.Add(Me.Label5)
		Me.TabPage3.Controls.Add(Me.txtP_RAM_Free)
		Me.TabPage3.Controls.Add(Me.Label4)
		Me.TabPage3.Controls.Add(Me.txtP_RAM_Used)
		Me.TabPage3.Controls.Add(Me.Label3)
		Me.TabPage3.Controls.Add(Me.txtPhysicalRAM)
		Me.TabPage3.Controls.Add(Me.txtVirtualRAM)
		Me.TabPage3.Controls.Add(Me.Label2)
		Me.TabPage3.Controls.Add(Me.Label1)
		Me.TabPage3.Controls.Add(Me.lstRAMInfo)
		Me.TabPage3.Controls.Add(Me.picBx_RAM)
		Me.TabPage3.Location = New System.Drawing.Point(4, 22)
		Me.TabPage3.Name = "TabPage3"
		Me.TabPage3.Size = New System.Drawing.Size(920, 579)
		Me.TabPage3.TabIndex = 2
		Me.TabPage3.Text = "RAM"
		Me.TabPage3.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(859, 483)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(22, 13)
		Me.Label7.TabIndex = 19
		Me.Label7.Text = "GB"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(704, 483)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(22, 13)
		Me.Label8.TabIndex = 18
		Me.Label8.Text = "GB"
		'
		'txtV_RAM_Free
		'
		Me.txtV_RAM_Free.Location = New System.Drawing.Point(772, 480)
		Me.txtV_RAM_Free.Name = "txtV_RAM_Free"
		Me.txtV_RAM_Free.ReadOnly = True
		Me.txtV_RAM_Free.Size = New System.Drawing.Size(81, 20)
		Me.txtV_RAM_Free.TabIndex = 17
		Me.txtV_RAM_Free.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(727, 483)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(39, 13)
		Me.Label9.TabIndex = 16
		Me.Label9.Text = "/  Free"
		'
		'txtV_RAM_Used
		'
		Me.txtV_RAM_Used.Location = New System.Drawing.Point(612, 480)
		Me.txtV_RAM_Used.Name = "txtV_RAM_Used"
		Me.txtV_RAM_Used.ReadOnly = True
		Me.txtV_RAM_Used.Size = New System.Drawing.Size(86, 20)
		Me.txtV_RAM_Used.TabIndex = 15
		Me.txtV_RAM_Used.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(523, 483)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(83, 13)
		Me.Label10.TabIndex = 14
		Me.Label10.Text = "/  Curent Usage"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(859, 454)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(22, 13)
		Me.Label6.TabIndex = 13
		Me.Label6.Text = "GB"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(704, 454)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(22, 13)
		Me.Label5.TabIndex = 12
		Me.Label5.Text = "GB"
		'
		'txtP_RAM_Free
		'
		Me.txtP_RAM_Free.Location = New System.Drawing.Point(772, 451)
		Me.txtP_RAM_Free.Name = "txtP_RAM_Free"
		Me.txtP_RAM_Free.ReadOnly = True
		Me.txtP_RAM_Free.Size = New System.Drawing.Size(81, 20)
		Me.txtP_RAM_Free.TabIndex = 11
		Me.txtP_RAM_Free.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(727, 454)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(39, 13)
		Me.Label4.TabIndex = 10
		Me.Label4.Text = "/  Free"
		'
		'txtP_RAM_Used
		'
		Me.txtP_RAM_Used.Location = New System.Drawing.Point(612, 451)
		Me.txtP_RAM_Used.Name = "txtP_RAM_Used"
		Me.txtP_RAM_Used.ReadOnly = True
		Me.txtP_RAM_Used.Size = New System.Drawing.Size(86, 20)
		Me.txtP_RAM_Used.TabIndex = 9
		Me.txtP_RAM_Used.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(523, 454)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(83, 13)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "/  Curent Usage"
		'
		'txtPhysicalRAM
		'
		Me.txtPhysicalRAM.Location = New System.Drawing.Point(425, 451)
		Me.txtPhysicalRAM.Name = "txtPhysicalRAM"
		Me.txtPhysicalRAM.ReadOnly = True
		Me.txtPhysicalRAM.Size = New System.Drawing.Size(78, 20)
		Me.txtPhysicalRAM.TabIndex = 7
		Me.txtPhysicalRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtVirtualRAM
		'
		Me.txtVirtualRAM.Location = New System.Drawing.Point(425, 480)
		Me.txtVirtualRAM.Name = "txtVirtualRAM"
		Me.txtVirtualRAM.ReadOnly = True
		Me.txtVirtualRAM.Size = New System.Drawing.Size(78, 20)
		Me.txtVirtualRAM.TabIndex = 6
		Me.txtVirtualRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(289, 480)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(103, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "Total Virtual Memory"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(289, 454)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(113, 13)
		Me.Label1.TabIndex = 4
		Me.Label1.Text = "Total Physical Memory"
		'
		'lstRAMInfo
		'
		Me.lstRAMInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.ColumnHeader6})
		Me.lstRAMInfo.GridLines = True
		Me.lstRAMInfo.Location = New System.Drawing.Point(261, 6)
		Me.lstRAMInfo.Name = "lstRAMInfo"
		Me.lstRAMInfo.Size = New System.Drawing.Size(600, 402)
		Me.lstRAMInfo.TabIndex = 3
		Me.lstRAMInfo.UseCompatibleStateImageBehavior = False
		Me.lstRAMInfo.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader5
		'
		Me.ColumnHeader5.Text = ""
		Me.ColumnHeader5.Width = 200
		'
		'ColumnHeader6
		'
		Me.ColumnHeader6.Text = ""
		Me.ColumnHeader6.Width = 375
		'
		'picBx_RAM
		'
		Me.picBx_RAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picBx_RAM.Location = New System.Drawing.Point(3, 6)
		Me.picBx_RAM.Name = "picBx_RAM"
		Me.picBx_RAM.Size = New System.Drawing.Size(235, 567)
		Me.picBx_RAM.TabIndex = 2
		Me.picBx_RAM.TabStop = False
		'
		'TabPage4
		'
		Me.TabPage4.Controls.Add(Me.GroupBox3)
		Me.TabPage4.Controls.Add(Me.GroupBox2)
		Me.TabPage4.Controls.Add(Me.picBx_GPU)
		Me.TabPage4.Location = New System.Drawing.Point(4, 22)
		Me.TabPage4.Name = "TabPage4"
		Me.TabPage4.Size = New System.Drawing.Size(920, 579)
		Me.TabPage4.TabIndex = 3
		Me.TabPage4.Text = "Graphics"
		Me.TabPage4.UseVisualStyleBackColor = True
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.lstMonitors)
		Me.GroupBox3.Location = New System.Drawing.Point(269, 257)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(636, 245)
		Me.GroupBox3.TabIndex = 6
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Monitors"
		'
		'lstMonitors
		'
		Me.lstMonitors.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10})
		Me.lstMonitors.GridLines = True
		Me.lstMonitors.Location = New System.Drawing.Point(16, 19)
		Me.lstMonitors.Name = "lstMonitors"
		Me.lstMonitors.Size = New System.Drawing.Size(605, 216)
		Me.lstMonitors.TabIndex = 4
		Me.lstMonitors.UseCompatibleStateImageBehavior = False
		Me.lstMonitors.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader9
		'
		Me.ColumnHeader9.Text = ""
		Me.ColumnHeader9.Width = 270
		'
		'ColumnHeader10
		'
		Me.ColumnHeader10.Text = ""
		Me.ColumnHeader10.Width = 304
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.lstGraphicAdapter)
		Me.GroupBox2.Location = New System.Drawing.Point(269, 6)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(636, 245)
		Me.GroupBox2.TabIndex = 5
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Graphic Adapters"
		'
		'lstGraphicAdapter
		'
		Me.lstGraphicAdapter.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8})
		Me.lstGraphicAdapter.GridLines = True
		Me.lstGraphicAdapter.Location = New System.Drawing.Point(16, 19)
		Me.lstGraphicAdapter.Name = "lstGraphicAdapter"
		Me.lstGraphicAdapter.Size = New System.Drawing.Size(605, 216)
		Me.lstGraphicAdapter.TabIndex = 4
		Me.lstGraphicAdapter.UseCompatibleStateImageBehavior = False
		Me.lstGraphicAdapter.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader7
		'
		Me.ColumnHeader7.Text = ""
		Me.ColumnHeader7.Width = 270
		'
		'ColumnHeader8
		'
		Me.ColumnHeader8.Text = ""
		Me.ColumnHeader8.Width = 304
		'
		'picBx_GPU
		'
		Me.picBx_GPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picBx_GPU.Location = New System.Drawing.Point(3, 6)
		Me.picBx_GPU.Name = "picBx_GPU"
		Me.picBx_GPU.Size = New System.Drawing.Size(235, 567)
		Me.picBx_GPU.TabIndex = 3
		Me.picBx_GPU.TabStop = False
		'
		'TabPage5
		'
		Me.TabPage5.Controls.Add(Me.picBx_Storage)
		Me.TabPage5.Controls.Add(Me.btnControllers)
		Me.TabPage5.Controls.Add(Me.GroupBox6)
		Me.TabPage5.Controls.Add(Me.GroupBox4)
		Me.TabPage5.Location = New System.Drawing.Point(4, 22)
		Me.TabPage5.Name = "TabPage5"
		Me.TabPage5.Size = New System.Drawing.Size(920, 579)
		Me.TabPage5.TabIndex = 4
		Me.TabPage5.Text = "Storage"
		Me.TabPage5.UseVisualStyleBackColor = True
		'
		'btnControllers
		'
		Me.btnControllers.Location = New System.Drawing.Point(285, 530)
		Me.btnControllers.Name = "btnControllers"
		Me.btnControllers.Size = New System.Drawing.Size(140, 24)
		Me.btnControllers.TabIndex = 13
		Me.btnControllers.Text = "Controllers"
		Me.btnControllers.UseVisualStyleBackColor = True
		'
		'GroupBox6
		'
		Me.GroupBox6.Controls.Add(Me.lstOptical)
		Me.GroupBox6.Location = New System.Drawing.Point(269, 301)
		Me.GroupBox6.Name = "GroupBox6"
		Me.GroupBox6.Size = New System.Drawing.Size(636, 198)
		Me.GroupBox6.TabIndex = 7
		Me.GroupBox6.TabStop = False
		Me.GroupBox6.Text = "Optical Devices"
		'
		'lstOptical
		'
		Me.lstOptical.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader15, Me.ColumnHeader16})
		Me.lstOptical.GridLines = True
		Me.lstOptical.Location = New System.Drawing.Point(16, 19)
		Me.lstOptical.Name = "lstOptical"
		Me.lstOptical.Size = New System.Drawing.Size(605, 163)
		Me.lstOptical.TabIndex = 4
		Me.lstOptical.UseCompatibleStateImageBehavior = False
		Me.lstOptical.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader15
		'
		Me.ColumnHeader15.Text = ""
		Me.ColumnHeader15.Width = 270
		'
		'ColumnHeader16
		'
		Me.ColumnHeader16.Text = ""
		Me.ColumnHeader16.Width = 304
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.LstStorage)
		Me.GroupBox4.Location = New System.Drawing.Point(269, 6)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(636, 289)
		Me.GroupBox4.TabIndex = 6
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "Storage Devices"
		'
		'LstStorage
		'
		Me.LstStorage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
		Me.LstStorage.GridLines = True
		Me.LstStorage.Location = New System.Drawing.Point(16, 19)
		Me.LstStorage.Name = "LstStorage"
		Me.LstStorage.Size = New System.Drawing.Size(605, 255)
		Me.LstStorage.TabIndex = 4
		Me.LstStorage.UseCompatibleStateImageBehavior = False
		Me.LstStorage.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader11
		'
		Me.ColumnHeader11.Text = ""
		Me.ColumnHeader11.Width = 270
		'
		'ColumnHeader12
		'
		Me.ColumnHeader12.Text = ""
		Me.ColumnHeader12.Width = 304
		'
		'TabPage6
		'
		Me.TabPage6.Controls.Add(Me.picBx_Multi)
		Me.TabPage6.Controls.Add(Me.GroupBox7)
		Me.TabPage6.Controls.Add(Me.GroupBox8)
		Me.TabPage6.Location = New System.Drawing.Point(4, 22)
		Me.TabPage6.Name = "TabPage6"
		Me.TabPage6.Size = New System.Drawing.Size(920, 579)
		Me.TabPage6.TabIndex = 5
		Me.TabPage6.Text = "Multimedia"
		Me.TabPage6.UseVisualStyleBackColor = True
		'
		'picBx_Multi
		'
		Me.picBx_Multi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picBx_Multi.Location = New System.Drawing.Point(3, 6)
		Me.picBx_Multi.Name = "picBx_Multi"
		Me.picBx_Multi.Size = New System.Drawing.Size(235, 567)
		Me.picBx_Multi.TabIndex = 10
		Me.picBx_Multi.TabStop = False
		'
		'GroupBox7
		'
		Me.GroupBox7.Controls.Add(Me.lstModem)
		Me.GroupBox7.Location = New System.Drawing.Point(269, 301)
		Me.GroupBox7.Name = "GroupBox7"
		Me.GroupBox7.Size = New System.Drawing.Size(636, 198)
		Me.GroupBox7.TabIndex = 9
		Me.GroupBox7.TabStop = False
		Me.GroupBox7.Text = "Modems"
		'
		'lstModem
		'
		Me.lstModem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader18})
		Me.lstModem.GridLines = True
		Me.lstModem.Location = New System.Drawing.Point(16, 19)
		Me.lstModem.Name = "lstModem"
		Me.lstModem.Size = New System.Drawing.Size(605, 163)
		Me.lstModem.TabIndex = 4
		Me.lstModem.UseCompatibleStateImageBehavior = False
		Me.lstModem.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader17
		'
		Me.ColumnHeader17.Text = ""
		Me.ColumnHeader17.Width = 270
		'
		'ColumnHeader18
		'
		Me.ColumnHeader18.Text = ""
		Me.ColumnHeader18.Width = 304
		'
		'GroupBox8
		'
		Me.GroupBox8.Controls.Add(Me.lstSound)
		Me.GroupBox8.Location = New System.Drawing.Point(269, 6)
		Me.GroupBox8.Name = "GroupBox8"
		Me.GroupBox8.Size = New System.Drawing.Size(636, 289)
		Me.GroupBox8.TabIndex = 8
		Me.GroupBox8.TabStop = False
		Me.GroupBox8.Text = "Sound"
		'
		'lstSound
		'
		Me.lstSound.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader19, Me.ColumnHeader20})
		Me.lstSound.GridLines = True
		Me.lstSound.Location = New System.Drawing.Point(16, 19)
		Me.lstSound.Name = "lstSound"
		Me.lstSound.Size = New System.Drawing.Size(605, 255)
		Me.lstSound.TabIndex = 4
		Me.lstSound.UseCompatibleStateImageBehavior = False
		Me.lstSound.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader19
		'
		Me.ColumnHeader19.Text = ""
		Me.ColumnHeader19.Width = 270
		'
		'ColumnHeader20
		'
		Me.ColumnHeader20.Text = ""
		Me.ColumnHeader20.Width = 304
		'
		'cmdExit
		'
		Me.cmdExit.Location = New System.Drawing.Point(861, 613)
		Me.cmdExit.Name = "cmdExit"
		Me.cmdExit.Size = New System.Drawing.Size(75, 23)
		Me.cmdExit.TabIndex = 2
		Me.cmdExit.Text = "Exit"
		Me.cmdExit.UseVisualStyleBackColor = True
		'
		'timer_RAM_use
		'
		Me.timer_RAM_use.Interval = 1000
		'
		'picBx_Storage
		'
		Me.picBx_Storage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.picBx_Storage.Location = New System.Drawing.Point(3, 6)
		Me.picBx_Storage.Name = "picBx_Storage"
		Me.picBx_Storage.Size = New System.Drawing.Size(235, 567)
		Me.picBx_Storage.TabIndex = 14
		Me.picBx_Storage.TabStop = False
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(948, 641)
		Me.Controls.Add(Me.cmdExit)
		Me.Controls.Add(Me.TabCntrl)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.Name = "frmMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Aurora Open System Information"
		CType(Me.picBx_windows, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabCntrl.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.GroupBox5.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		CType(Me.picBx_CPU, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage3.ResumeLayout(False)
		Me.TabPage3.PerformLayout()
		CType(Me.picBx_RAM, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage4.ResumeLayout(False)
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		CType(Me.picBx_GPU, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TabPage5.ResumeLayout(False)
		Me.GroupBox6.ResumeLayout(False)
		Me.GroupBox4.ResumeLayout(False)
		Me.TabPage6.ResumeLayout(False)
		CType(Me.picBx_Multi, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox7.ResumeLayout(False)
		Me.GroupBox8.ResumeLayout(False)
		CType(Me.picBx_Storage, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents picBx_windows As System.Windows.Forms.PictureBox
	Friend WithEvents TabCntrl As System.Windows.Forms.TabControl
	Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
	Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
	Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
	Friend WithEvents btnSpecialFolders As System.Windows.Forms.Button
	Private WithEvents lstWindows As System.Windows.Forms.ListView
	Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
	Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
	Friend WithEvents cmdExit As System.Windows.Forms.Button
	Friend WithEvents picBx_CPU As System.Windows.Forms.PictureBox
	Friend WithEvents btnInstalledPrograms As System.Windows.Forms.Button
	Friend WithEvents btnEnviVar As System.Windows.Forms.Button
	Private WithEvents lstCPU As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
	Friend WithEvents picBx_RAM As System.Windows.Forms.PictureBox
	Private WithEvents lstRAMInfo As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
	Friend WithEvents txtPhysicalRAM As System.Windows.Forms.TextBox
	Friend WithEvents txtVirtualRAM As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtP_RAM_Used As System.Windows.Forms.TextBox
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents timer_RAM_use As System.Windows.Forms.Timer
	Friend WithEvents txtP_RAM_Free As System.Windows.Forms.TextBox
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents Label5 As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents txtV_RAM_Free As System.Windows.Forms.TextBox
	Friend WithEvents Label9 As System.Windows.Forms.Label
	Friend WithEvents txtV_RAM_Used As System.Windows.Forms.TextBox
	Friend WithEvents Label10 As System.Windows.Forms.Label
	Friend WithEvents picBx_GPU As System.Windows.Forms.PictureBox
	Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
	Private WithEvents lstMonitors As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
	Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
	Private WithEvents lstGraphicAdapter As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
	Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Private WithEvents LstStorage As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
	Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
	Private WithEvents lstBIOS As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
	Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
	Private WithEvents lstOptical As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
	Friend WithEvents btnControllers As System.Windows.Forms.Button
	Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
	Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
	Private WithEvents lstModem As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
	Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
	Private WithEvents lstSound As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
	Friend WithEvents picBx_Multi As System.Windows.Forms.PictureBox
	Friend WithEvents picBx_Storage As System.Windows.Forms.PictureBox

End Class
