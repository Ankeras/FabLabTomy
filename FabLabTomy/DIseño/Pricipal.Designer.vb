<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pricipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SdadsadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsdadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SadaToolStripMenuItem, Me.SdadsadToolStripMenuItem, Me.AsdadToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(651, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SadaToolStripMenuItem
        '
        Me.SadaToolStripMenuItem.Name = "SadaToolStripMenuItem"
        Me.SadaToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SadaToolStripMenuItem.Text = "sada"
        '
        'SdadsadToolStripMenuItem
        '
        Me.SdadsadToolStripMenuItem.Name = "SdadsadToolStripMenuItem"
        Me.SdadsadToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SdadsadToolStripMenuItem.Text = "sdadsad"
        '
        'AsdadToolStripMenuItem
        '
        Me.AsdadToolStripMenuItem.Name = "AsdadToolStripMenuItem"
        Me.AsdadToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AsdadToolStripMenuItem.Text = "asdad"
        '
        'Pricipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 352)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Pricipal"
        Me.Text = "Pricipal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SdadsadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsdadToolStripMenuItem As ToolStripMenuItem
End Class
