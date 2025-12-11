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
        box02 = New PictureBox()
        box12 = New PictureBox()
        box11 = New PictureBox()
        box10 = New PictureBox()
        box22 = New PictureBox()
        box21 = New PictureBox()
        box20 = New PictureBox()
        box01 = New PictureBox()
        Label1 = New Label()
        lblTurn = New Label()
        checkOnePlayer = New CheckBox()
        checkBeSecond = New CheckBox()
        Label2 = New Label()
        Label3 = New Label()
        lblCount_o = New Label()
        lblCount_x = New Label()
        CType(box00, ComponentModel.ISupportInitialize).BeginInit()
        CType(box02, ComponentModel.ISupportInitialize).BeginInit()
        CType(box12, ComponentModel.ISupportInitialize).BeginInit()
        CType(box11, ComponentModel.ISupportInitialize).BeginInit()
        CType(box10, ComponentModel.ISupportInitialize).BeginInit()
        CType(box22, ComponentModel.ISupportInitialize).BeginInit()
        CType(box21, ComponentModel.ISupportInitialize).BeginInit()
        CType(box20, ComponentModel.ISupportInitialize).BeginInit()
        CType(box01, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(155, 21)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(120, 44)
        btnStart.TabIndex = 0
        btnStart.Text = "Iniciar joc"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' box00
        ' 
        box00.BorderStyle = BorderStyle.FixedSingle
        box00.Location = New Point(36, 76)
        box00.Name = "box00"
        box00.Size = New Size(75, 72)
        box00.SizeMode = PictureBoxSizeMode.StretchImage
        box00.TabIndex = 1
        box00.TabStop = False
        box00.Tag = "0,0"
        ' 
        ' box02
        ' 
        box02.BorderStyle = BorderStyle.FixedSingle
        box02.Location = New Point(198, 76)
        box02.Name = "box02"
        box02.Size = New Size(75, 72)
        box02.SizeMode = PictureBoxSizeMode.StretchImage
        box02.TabIndex = 3
        box02.TabStop = False
        box02.Tag = "0,2"
        ' 
        ' box12
        ' 
        box12.BorderStyle = BorderStyle.FixedSingle
        box12.Location = New Point(198, 154)
        box12.Name = "box12"
        box12.Size = New Size(75, 72)
        box12.SizeMode = PictureBoxSizeMode.StretchImage
        box12.TabIndex = 6
        box12.TabStop = False
        box12.Tag = "1,2"
        ' 
        ' box11
        ' 
        box11.BorderStyle = BorderStyle.FixedSingle
        box11.Location = New Point(117, 154)
        box11.Name = "box11"
        box11.Size = New Size(75, 72)
        box11.SizeMode = PictureBoxSizeMode.StretchImage
        box11.TabIndex = 5
        box11.TabStop = False
        box11.Tag = "1,1"
        ' 
        ' box10
        ' 
        box10.BorderStyle = BorderStyle.FixedSingle
        box10.Location = New Point(36, 154)
        box10.Name = "box10"
        box10.Size = New Size(75, 72)
        box10.SizeMode = PictureBoxSizeMode.StretchImage
        box10.TabIndex = 4
        box10.TabStop = False
        box10.Tag = "1,0"
        ' 
        ' box22
        ' 
        box22.BorderStyle = BorderStyle.FixedSingle
        box22.Location = New Point(198, 232)
        box22.Name = "box22"
        box22.Size = New Size(75, 72)
        box22.SizeMode = PictureBoxSizeMode.StretchImage
        box22.TabIndex = 9
        box22.TabStop = False
        box22.Tag = "2,2"
        ' 
        ' box21
        ' 
        box21.BorderStyle = BorderStyle.FixedSingle
        box21.Location = New Point(117, 232)
        box21.Name = "box21"
        box21.Size = New Size(75, 72)
        box21.SizeMode = PictureBoxSizeMode.StretchImage
        box21.TabIndex = 8
        box21.TabStop = False
        box21.Tag = "2,1"
        ' 
        ' box20
        ' 
        box20.BorderStyle = BorderStyle.FixedSingle
        box20.Location = New Point(36, 232)
        box20.Name = "box20"
        box20.Size = New Size(75, 72)
        box20.SizeMode = PictureBoxSizeMode.StretchImage
        box20.TabIndex = 7
        box20.TabStop = False
        box20.Tag = "2,0"
        ' 
        ' box01
        ' 
        box01.BorderStyle = BorderStyle.FixedSingle
        box01.Location = New Point(117, 76)
        box01.Name = "box01"
        box01.Size = New Size(75, 72)
        box01.SizeMode = PictureBoxSizeMode.StretchImage
        box01.TabIndex = 10
        box01.TabStop = False
        box01.Tag = "0,1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(213, 325)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 15)
        Label1.TabIndex = 11
        Label1.Text = "Turn:"
        ' 
        ' lblTurn
        ' 
        lblTurn.BorderStyle = BorderStyle.FixedSingle
        lblTurn.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTurn.Location = New Point(252, 321)
        lblTurn.Name = "lblTurn"
        lblTurn.Size = New Size(23, 23)
        lblTurn.TabIndex = 12
        lblTurn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' checkOnePlayer
        ' 
        checkOnePlayer.AutoSize = True
        checkOnePlayer.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        checkOnePlayer.Location = New Point(38, 21)
        checkOnePlayer.Name = "checkOnePlayer"
        checkOnePlayer.Size = New Size(77, 19)
        checkOnePlayer.TabIndex = 13
        checkOnePlayer.Text = "1 Jugador"
        checkOnePlayer.UseVisualStyleBackColor = True
        ' 
        ' checkBeSecond
        ' 
        checkBeSecond.AutoSize = True
        checkBeSecond.Enabled = False
        checkBeSecond.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        checkBeSecond.Location = New Point(38, 46)
        checkBeSecond.Name = "checkBeSecond"
        checkBeSecond.Size = New Size(104, 19)
        checkBeSecond.TabIndex = 14
        checkBeSecond.Text = "Comenzar 2do"
        checkBeSecond.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 18)
        Label2.TabIndex = 15
        Label2.Text = "X :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(35, 337)
        Label3.Name = "Label3"
        Label3.Size = New Size(25, 18)
        Label3.TabIndex = 16
        Label3.Text = "O :"
        ' 
        ' lblCount_o
        ' 
        lblCount_o.AutoSize = True
        lblCount_o.Font = New Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCount_o.Location = New Point(62, 337)
        lblCount_o.Name = "lblCount_o"
        lblCount_o.Size = New Size(16, 18)
        lblCount_o.TabIndex = 17
        lblCount_o.Text = "0"
        ' 
        ' lblCount_x
        ' 
        lblCount_x.AutoSize = True
        lblCount_x.Font = New Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCount_x.Location = New Point(62, 319)
        lblCount_x.Name = "lblCount_x"
        lblCount_x.Size = New Size(16, 18)
        lblCount_x.TabIndex = 18
        lblCount_x.Text = "0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(313, 362)
        Controls.Add(lblCount_x)
        Controls.Add(lblCount_o)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(box11)
        Controls.Add(box00)
        Controls.Add(box10)
        Controls.Add(box20)
        Controls.Add(box21)
        Controls.Add(checkBeSecond)
        Controls.Add(box22)
        Controls.Add(checkOnePlayer)
        Controls.Add(box01)
        Controls.Add(lblTurn)
        Controls.Add(Label1)
        Controls.Add(box02)
        Controls.Add(btnStart)
        Controls.Add(box12)
        Name = "Form1"
        Text = "3 en ralla"
        CType(box00, ComponentModel.ISupportInitialize).EndInit()
        CType(box02, ComponentModel.ISupportInitialize).EndInit()
        CType(box12, ComponentModel.ISupportInitialize).EndInit()
        CType(box11, ComponentModel.ISupportInitialize).EndInit()
        CType(box10, ComponentModel.ISupportInitialize).EndInit()
        CType(box22, ComponentModel.ISupportInitialize).EndInit()
        CType(box21, ComponentModel.ISupportInitialize).EndInit()
        CType(box20, ComponentModel.ISupportInitialize).EndInit()
        CType(box01, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents box00 As PictureBox
    Friend WithEvents box02 As PictureBox
    Friend WithEvents box12 As PictureBox
    Friend WithEvents box11 As PictureBox
    Friend WithEvents box10 As PictureBox
    Friend WithEvents box22 As PictureBox
    Friend WithEvents box21 As PictureBox
    Friend WithEvents box20 As PictureBox
    Friend WithEvents box01 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTurn As Label
    Friend WithEvents checkOnePlayer As CheckBox
    Friend WithEvents checkBeSecond As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCount_o As Label
    Friend WithEvents lblCount_x As Label

End Class
