<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnTurnOff = New System.Windows.Forms.Button()
        Me.btnOffAndLock = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTurnOff
        '
        Me.btnTurnOff.Location = New System.Drawing.Point(6, 6)
        Me.btnTurnOff.Name = "btnTurnOff"
        Me.btnTurnOff.Size = New System.Drawing.Size(160, 60)
        Me.btnTurnOff.TabIndex = 0
        Me.btnTurnOff.Text = "Monitor Off"
        Me.btnTurnOff.UseVisualStyleBackColor = True
        '
        'btnOffAndLock
        '
        Me.btnOffAndLock.Location = New System.Drawing.Point(6, 72)
        Me.btnOffAndLock.Name = "btnOffAndLock"
        Me.btnOffAndLock.Size = New System.Drawing.Size(160, 60)
        Me.btnOffAndLock.TabIndex = 1
        Me.btnOffAndLock.Text = "Turn Off and Lock"
        Me.btnOffAndLock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(172, 140)
        Me.Controls.Add(Me.btnOffAndLock)
        Me.Controls.Add(Me.btnTurnOff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "MONITOROFF"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTurnOff As Button
    Friend WithEvents btnOffAndLock As Button
End Class
