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
        Me.ListBox_Items = New System.Windows.Forms.ListBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.TextBox_Description = New System.Windows.Forms.TextBox()
        Me.Button_About = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Button_Launch = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox_Items
        '
        Me.ListBox_Items.FormattingEnabled = True
        Me.ListBox_Items.Items.AddRange(New Object() {"Dictionary", "Encyclopedia"})
        Me.ListBox_Items.Location = New System.Drawing.Point(8, 8)
        Me.ListBox_Items.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox_Items.Name = "ListBox_Items"
        Me.ListBox_Items.Size = New System.Drawing.Size(116, 277)
        Me.ListBox_Items.TabIndex = 0
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.Title.Location = New System.Drawing.Point(138, 8)
        Me.Title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(0, 46)
        Me.Title.TabIndex = 1
        '
        'TextBox_Description
        '
        Me.TextBox_Description.Location = New System.Drawing.Point(146, 83)
        Me.TextBox_Description.Name = "TextBox_Description"
        Me.TextBox_Description.ReadOnly = True
        Me.TextBox_Description.Size = New System.Drawing.Size(337, 20)
        Me.TextBox_Description.TabIndex = 2
        '
        'Button_About
        '
        Me.Button_About.Location = New System.Drawing.Point(446, 257)
        Me.Button_About.Name = "Button_About"
        Me.Button_About.Size = New System.Drawing.Size(75, 23)
        Me.Button_About.TabIndex = 4
        Me.Button_About.Text = "About"
        Me.Button_About.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(423, 13)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(98, 64)
        Me.PictureBox.TabIndex = 3
        Me.PictureBox.TabStop = False
        '
        'Button_Launch
        '
        Me.Button_Launch.Location = New System.Drawing.Point(130, 257)
        Me.Button_Launch.Name = "Button_Launch"
        Me.Button_Launch.Size = New System.Drawing.Size(75, 23)
        Me.Button_Launch.TabIndex = 5
        Me.Button_Launch.Text = "Launch"
        Me.Button_Launch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.Button_Launch)
        Me.Controls.Add(Me.Button_About)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.TextBox_Description)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ListBox_Items)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_Items As ListBox
    Friend WithEvents Title As Label
    Friend WithEvents TextBox_Description As TextBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Button_About As Button
    Friend WithEvents Button_Launch As Button
End Class
