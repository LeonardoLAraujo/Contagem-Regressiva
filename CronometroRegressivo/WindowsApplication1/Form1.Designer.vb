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
        Me.components = New System.ComponentModel.Container()
        Me.TXT_TEMPO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_tempo = New System.Windows.Forms.Label()
        Me.BTN_INICIAR = New System.Windows.Forms.Button()
        Me.tmTempo = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TXT_TEMPO
        '
        Me.TXT_TEMPO.Location = New System.Drawing.Point(94, 55)
        Me.TXT_TEMPO.Name = "TXT_TEMPO"
        Me.TXT_TEMPO.Size = New System.Drawing.Size(139, 20)
        Me.TXT_TEMPO.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TEMPO:"
        '
        'lbl_tempo
        '
        Me.lbl_tempo.AutoSize = True
        Me.lbl_tempo.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tempo.Location = New System.Drawing.Point(89, 89)
        Me.lbl_tempo.Name = "lbl_tempo"
        Me.lbl_tempo.Size = New System.Drawing.Size(116, 26)
        Me.lbl_tempo.TabIndex = 2
        Me.lbl_tempo.Text = "Contagem"
        Me.lbl_tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN_INICIAR
        '
        Me.BTN_INICIAR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTN_INICIAR.BackColor = System.Drawing.Color.Lime
        Me.BTN_INICIAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_INICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_INICIAR.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_INICIAR.ForeColor = System.Drawing.Color.Black
        Me.BTN_INICIAR.Location = New System.Drawing.Point(12, 143)
        Me.BTN_INICIAR.Name = "BTN_INICIAR"
        Me.BTN_INICIAR.Size = New System.Drawing.Size(106, 36)
        Me.BTN_INICIAR.TabIndex = 3
        Me.BTN_INICIAR.Text = "Iniciar"
        Me.BTN_INICIAR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTN_INICIAR.UseVisualStyleBackColor = False
        '
        'tmTempo
        '
        Me.tmTempo.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cronometro Regressivo"
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(157, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Parar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(275, 199)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTN_INICIAR)
        Me.Controls.Add(Me.lbl_tempo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_TEMPO)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conometro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_TEMPO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_tempo As System.Windows.Forms.Label
    Friend WithEvents BTN_INICIAR As System.Windows.Forms.Button
    Friend WithEvents tmTempo As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
