<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmView
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
        Me.txtAsset = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtAsset
        '
        Me.txtAsset.AcceptsTab = True
        Me.txtAsset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAsset.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsset.Location = New System.Drawing.Point(0, 0)
        Me.txtAsset.Multiline = True
        Me.txtAsset.Name = "txtAsset"
        Me.txtAsset.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAsset.Size = New System.Drawing.Size(498, 397)
        Me.txtAsset.TabIndex = 0
        Me.txtAsset.WordWrap = False
        '
        'frmView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 397)
        Me.Controls.Add(Me.txtAsset)
        Me.Name = "frmView"
        Me.Text = "asset viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAsset As System.Windows.Forms.TextBox
End Class
