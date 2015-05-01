<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
		Me.prograssBarLoading = New System.Windows.Forms.ProgressBar()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.timer_load = New System.Windows.Forms.Timer(Me.components)
		Me.lbl_loading = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'prograssBarLoading
		'
		Me.prograssBarLoading.Location = New System.Drawing.Point(12, 56)
		Me.prograssBarLoading.Name = "prograssBarLoading"
		Me.prograssBarLoading.Size = New System.Drawing.Size(365, 23)
		Me.prograssBarLoading.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(21, 20)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(83, 23)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Loading "
		'
		'timer_load
		'
		Me.timer_load.Enabled = True
		Me.timer_load.Interval = 500
		'
		'lbl_loading
		'
		Me.lbl_loading.AutoSize = True
		Me.lbl_loading.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbl_loading.ForeColor = System.Drawing.Color.White
		Me.lbl_loading.Location = New System.Drawing.Point(110, 20)
		Me.lbl_loading.Name = "lbl_loading"
		Me.lbl_loading.Size = New System.Drawing.Size(0, 23)
		Me.lbl_loading.TabIndex = 2
		'
		'frmLoading
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(398, 107)
		Me.Controls.Add(Me.lbl_loading)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.prograssBarLoading)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmLoading"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "frmLoading"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents prograssBarLoading As System.Windows.Forms.ProgressBar
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents timer_load As System.Windows.Forms.Timer
	Friend WithEvents lbl_loading As System.Windows.Forms.Label
End Class
