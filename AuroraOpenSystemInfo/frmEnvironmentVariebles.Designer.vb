<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvironmentVariebles
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
		Me.lstEnvironmentVariebles = New System.Windows.Forms.ListView()
		Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SuspendLayout()
		'
		'lstEnvironmentVariebles
		'
		Me.lstEnvironmentVariebles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
		Me.lstEnvironmentVariebles.GridLines = True
		Me.lstEnvironmentVariebles.Location = New System.Drawing.Point(6, 6)
		Me.lstEnvironmentVariebles.Name = "lstEnvironmentVariebles"
		Me.lstEnvironmentVariebles.Size = New System.Drawing.Size(700, 500)
		Me.lstEnvironmentVariebles.TabIndex = 4
		Me.lstEnvironmentVariebles.UseCompatibleStateImageBehavior = False
		Me.lstEnvironmentVariebles.View = System.Windows.Forms.View.Details
		'
		'columnHeader1
		'
		Me.columnHeader1.Text = ""
		Me.columnHeader1.Width = 200
		'
		'columnHeader2
		'
		Me.columnHeader2.Text = ""
		Me.columnHeader2.Width = 475
		'
		'frmEnvironmentVariebles
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(712, 516)
		Me.Controls.Add(Me.lstEnvironmentVariebles)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmEnvironmentVariebles"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Environment Variebles"
		Me.ResumeLayout(False)

	End Sub
	Public WithEvents lstEnvironmentVariebles As System.Windows.Forms.ListView
	Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
	Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
End Class
