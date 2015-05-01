<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpecialFolders
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
		Me.lstSpecialFolders = New System.Windows.Forms.ListView()
		Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SuspendLayout()
		'
		'lstSpecialFolders
		'
		Me.lstSpecialFolders.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2})
		Me.lstSpecialFolders.GridLines = True
		Me.lstSpecialFolders.Location = New System.Drawing.Point(6, 6)
		Me.lstSpecialFolders.Name = "lstSpecialFolders"
		Me.lstSpecialFolders.Size = New System.Drawing.Size(700, 500)
		Me.lstSpecialFolders.TabIndex = 2
		Me.lstSpecialFolders.UseCompatibleStateImageBehavior = False
		Me.lstSpecialFolders.View = System.Windows.Forms.View.Details
		'
		'columnHeader1
		'
		Me.columnHeader1.Text = "Label"
		Me.columnHeader1.Width = 200
		'
		'columnHeader2
		'
		Me.columnHeader2.Text = "Path"
		Me.columnHeader2.Width = 475
		'
		'frmSpecialFolders
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(712, 516)
		Me.Controls.Add(Me.lstSpecialFolders)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmSpecialFolders"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Special  Folders"
		Me.ResumeLayout(False)

	End Sub
	Private WithEvents lstSpecialFolders As System.Windows.Forms.ListView
	Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
	Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
End Class
