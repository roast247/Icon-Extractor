<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RoastingLabel = New System.Windows.Forms.Label()
        Me.Closebtn = New System.Windows.Forms.Button()
        Me.Selectfile = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Saveico = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.icoPic = New System.Windows.Forms.PictureBox()
        Me.RoastingPic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.icoPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.RoastingLabel)
        Me.Panel1.Controls.Add(Me.RoastingPic)
        Me.Panel1.Controls.Add(Me.Closebtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(266, 25)
        Me.Panel1.TabIndex = 0
        '
        'RoastingLabel
        '
        Me.RoastingLabel.AutoSize = True
        Me.RoastingLabel.Location = New System.Drawing.Point(31, 6)
        Me.RoastingLabel.Name = "RoastingLabel"
        Me.RoastingLabel.Size = New System.Drawing.Size(119, 14)
        Me.RoastingLabel.TabIndex = 2
        Me.RoastingLabel.Text = "Roasting Icon Extractor"
        '
        'Closebtn
        '
        Me.Closebtn.BackColor = System.Drawing.Color.Red
        Me.Closebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Closebtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.Closebtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Closebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Closebtn.Location = New System.Drawing.Point(241, 0)
        Me.Closebtn.Name = "Closebtn"
        Me.Closebtn.Size = New System.Drawing.Size(25, 25)
        Me.Closebtn.TabIndex = 0
        Me.Closebtn.Text = "X"
        Me.Closebtn.UseVisualStyleBackColor = False
        '
        'Selectfile
        '
        Me.Selectfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Selectfile.Location = New System.Drawing.Point(12, 40)
        Me.Selectfile.Name = "Selectfile"
        Me.Selectfile.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Selectfile.Size = New System.Drawing.Size(90, 39)
        Me.Selectfile.TabIndex = 1
        Me.Selectfile.Values.Text = "Select File"
        '
        'Saveico
        '
        Me.Saveico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Saveico.Location = New System.Drawing.Point(164, 40)
        Me.Saveico.Name = "Saveico"
        Me.Saveico.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.Saveico.Size = New System.Drawing.Size(90, 39)
        Me.Saveico.TabIndex = 3
        Me.Saveico.Values.Text = "Save Icon"
        '
        'icoPic
        '
        Me.icoPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.icoPic.InitialImage = Global.Roasting_Icon_Extractor.My.Resources.Resources.birdy
        Me.icoPic.Location = New System.Drawing.Point(108, 34)
        Me.icoPic.Name = "icoPic"
        Me.icoPic.Size = New System.Drawing.Size(50, 50)
        Me.icoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoPic.TabIndex = 2
        Me.icoPic.TabStop = False
        Me.icoPic.WaitOnLoad = True
        '
        'RoastingPic
        '
        Me.RoastingPic.BackColor = System.Drawing.Color.Black
        Me.RoastingPic.BackgroundImage = Global.Roasting_Icon_Extractor.My.Resources.Resources.projicon
        Me.RoastingPic.Image = Global.Roasting_Icon_Extractor.My.Resources.Resources.projicon
        Me.RoastingPic.Location = New System.Drawing.Point(0, 0)
        Me.RoastingPic.Name = "RoastingPic"
        Me.RoastingPic.Size = New System.Drawing.Size(25, 25)
        Me.RoastingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.RoastingPic.TabIndex = 1
        Me.RoastingPic.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(266, 96)
        Me.Controls.Add(Me.Saveico)
        Me.Controls.Add(Me.icoPic)
        Me.Controls.Add(Me.Selectfile)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.icoPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoastingPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Closebtn As Button
    Friend WithEvents RoastingLabel As Label
    Friend WithEvents RoastingPic As PictureBox
    Friend WithEvents Selectfile As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents icoPic As PictureBox
    Friend WithEvents Saveico As ComponentFactory.Krypton.Toolkit.KryptonButton
End Class
