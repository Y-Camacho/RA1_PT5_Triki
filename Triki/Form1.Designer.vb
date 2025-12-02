<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnStart = New Button()
        box00 = New PictureBox()
        box01 = New PictureBox()
        box02 = New PictureBox()
        box12 = New PictureBox()
        box11 = New PictureBox()
        box10 = New PictureBox()
        box22 = New PictureBox()
        box21 = New PictureBox()
        box20 = New PictureBox()
        CType(box00, ComponentModel.ISupportInitialize).BeginInit()
        CType(box01, ComponentModel.ISupportInitialize).BeginInit()
        CType(box02, ComponentModel.ISupportInitialize).BeginInit()
        CType(box12, ComponentModel.ISupportInitialize).BeginInit()
        CType(box11, ComponentModel.ISupportInitialize).BeginInit()
        CType(box10, ComponentModel.ISupportInitialize).BeginInit()
        CType(box22, ComponentModel.ISupportInitialize).BeginInit()
        CType(box21, ComponentModel.ISupportInitialize).BeginInit()
        CType(box20, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(98, 21)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(120, 44)
        btnStart.TabIndex = 0
        btnStart.Text = "Iniciar joc"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' box00
        ' 
        box00.BorderStyle = BorderStyle.FixedSingle
        box00.Location = New Point(38, 81)
        box00.Name = "box00"
        box00.Size = New Size(75, 72)
        box00.TabIndex = 1
        box00.TabStop = False
        ' 
        ' box01
        ' 
        box01.BorderStyle = BorderStyle.FixedSingle
        box01.Location = New Point(119, 81)
        box01.Name = "box01"
        box01.Size = New Size(75, 72)
        box01.TabIndex = 2
        box01.TabStop = False
        ' 
        ' box02
        ' 
        box02.BorderStyle = BorderStyle.FixedSingle
        box02.Location = New Point(200, 81)
        box02.Name = "box02"
        box02.Size = New Size(75, 72)
        box02.TabIndex = 3
        box02.TabStop = False
        ' 
        ' box12
        ' 
        box12.BorderStyle = BorderStyle.FixedSingle
        box12.Location = New Point(200, 159)
        box12.Name = "box12"
        box12.Size = New Size(75, 72)
        box12.TabIndex = 6
        box12.TabStop = False
        ' 
        ' box11
        ' 
        box11.BorderStyle = BorderStyle.FixedSingle
        box11.Location = New Point(119, 159)
        box11.Name = "box11"
        box11.Size = New Size(75, 72)
        box11.TabIndex = 5
        box11.TabStop = False
        ' 
        ' box10
        ' 
        box10.BorderStyle = BorderStyle.FixedSingle
        box10.Location = New Point(38, 159)
        box10.Name = "box10"
        box10.Size = New Size(75, 72)
        box10.TabIndex = 4
        box10.TabStop = False
        ' 
        ' box22
        ' 
        box22.BorderStyle = BorderStyle.FixedSingle
        box22.Location = New Point(200, 237)
        box22.Name = "box22"
        box22.Size = New Size(75, 72)
        box22.TabIndex = 9
        box22.TabStop = False
        ' 
        ' box21
        ' 
        box21.BorderStyle = BorderStyle.FixedSingle
        box21.Location = New Point(119, 237)
        box21.Name = "box21"
        box21.Size = New Size(75, 72)
        box21.TabIndex = 8
        box21.TabStop = False
        ' 
        ' box20
        ' 
        box20.BorderStyle = BorderStyle.FixedSingle
        box20.Location = New Point(38, 237)
        box20.Name = "box20"
        box20.Size = New Size(75, 72)
        box20.TabIndex = 7
        box20.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(313, 358)
        Controls.Add(box22)
        Controls.Add(box21)
        Controls.Add(box20)
        Controls.Add(box12)
        Controls.Add(box11)
        Controls.Add(box10)
        Controls.Add(box02)
        Controls.Add(box01)
        Controls.Add(box00)
        Controls.Add(btnStart)
        Name = "Form1"
        Text = "3 en ralla"
        CType(box00, ComponentModel.ISupportInitialize).EndInit()
        CType(box01, ComponentModel.ISupportInitialize).EndInit()
        CType(box02, ComponentModel.ISupportInitialize).EndInit()
        CType(box12, ComponentModel.ISupportInitialize).EndInit()
        CType(box11, ComponentModel.ISupportInitialize).EndInit()
        CType(box10, ComponentModel.ISupportInitialize).EndInit()
        CType(box22, ComponentModel.ISupportInitialize).EndInit()
        CType(box21, ComponentModel.ISupportInitialize).EndInit()
        CType(box20, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents box00 As PictureBox
    Friend WithEvents box01 As PictureBox
    Friend WithEvents box02 As PictureBox
    Friend WithEvents box12 As PictureBox
    Friend WithEvents box11 As PictureBox
    Friend WithEvents box10 As PictureBox
    Friend WithEvents box22 As PictureBox
    Friend WithEvents box21 As PictureBox
    Friend WithEvents box20 As PictureBox

End Class
