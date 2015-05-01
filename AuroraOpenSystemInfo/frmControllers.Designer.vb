<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControllers
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
		Me.GroupBox4 = New System.Windows.Forms.GroupBox()
		Me.lstIDE = New System.Windows.Forms.ListView()
		Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.lstUSB = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.GroupBox4.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox4
		'
		Me.GroupBox4.Controls.Add(Me.lstIDE)
		Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox4.Name = "GroupBox4"
		Me.GroupBox4.Size = New System.Drawing.Size(670, 230)
		Me.GroupBox4.TabIndex = 7
		Me.GroupBox4.TabStop = False
		Me.GroupBox4.Text = "IDE Controllers"
		'
		'lstIDE
		'
		Me.lstIDE.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12})
		Me.lstIDE.GridLines = True
		Me.lstIDE.Location = New System.Drawing.Point(6, 19)
		Me.lstIDE.Name = "lstIDE"
		Me.lstIDE.Size = New System.Drawing.Size(658, 192)
		Me.lstIDE.TabIndex = 4
		Me.lstIDE.UseCompatibleStateImageBehavior = False
		Me.lstIDE.View = System.Windows.Forms.View.Details
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
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.lstUSB)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 248)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(670, 230)
		Me.GroupBox1.TabIndex = 8
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "USB Controllers"
		'
		'lstUSB
		'
		Me.lstUSB.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
		Me.lstUSB.GridLines = True
		Me.lstUSB.Location = New System.Drawing.Point(6, 19)
		Me.lstUSB.Name = "lstUSB"
		Me.lstUSB.Size = New System.Drawing.Size(658, 192)
		Me.lstUSB.TabIndex = 4
		Me.lstUSB.UseCompatibleStateImageBehavior = False
		Me.lstUSB.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = ""
		Me.ColumnHeader1.Width = 270
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = ""
		Me.ColumnHeader2.Width = 304
		'
		'frmControllers
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(694, 497)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.GroupBox4)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmControllers"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Controllers"
		Me.GroupBox4.ResumeLayout(False)
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
	Private WithEvents lstIDE As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Private WithEvents lstUSB As System.Windows.Forms.ListView
	Private WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
	Private WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
End Class
