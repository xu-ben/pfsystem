<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTS = New System.Windows.Forms.Label
        Me.lblPW = New System.Windows.Forms.Label
        Me.txtscore = New System.Windows.Forms.TextBox
        Me.btnOK2 = New System.Windows.Forms.Button
        Me.btnExit2 = New System.Windows.Forms.Button
        Me.lblJG = New System.Windows.Forms.Label
        Me.btnContinue = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblTS
        '
        Me.lblTS.AutoSize = True
        Me.lblTS.Font = New System.Drawing.Font("宋体", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTS.Location = New System.Drawing.Point(12, 15)
        Me.lblTS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTS.Name = "lblTS"
        Me.lblTS.Size = New System.Drawing.Size(394, 35)
        Me.lblTS.TabIndex = 0
        Me.lblTS.Text = "请评委为1号选手打分！"
        '
        'lblPW
        '
        Me.lblPW.AutoSize = True
        Me.lblPW.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPW.Location = New System.Drawing.Point(13, 142)
        Me.lblPW.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPW.Name = "lblPW"
        Me.lblPW.Size = New System.Drawing.Size(140, 19)
        Me.lblPW.TabIndex = 1
        Me.lblPW.Text = "评委1的打分："
        '
        'txtscore
        '
        Me.txtscore.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtscore.Location = New System.Drawing.Point(161, 139)
        Me.txtscore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtscore.Name = "txtscore"
        Me.txtscore.Size = New System.Drawing.Size(320, 29)
        Me.txtscore.TabIndex = 2
        '
        'btnOK2
        '
        Me.btnOK2.BackColor = System.Drawing.Color.Blue
        Me.btnOK2.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOK2.Location = New System.Drawing.Point(161, 259)
        Me.btnOK2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK2.Name = "btnOK2"
        Me.btnOK2.Size = New System.Drawing.Size(87, 31)
        Me.btnOK2.TabIndex = 3
        Me.btnOK2.Text = "输入"
        Me.btnOK2.UseVisualStyleBackColor = False
        '
        'btnExit2
        '
        Me.btnExit2.BackColor = System.Drawing.Color.Blue
        Me.btnExit2.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit2.Location = New System.Drawing.Point(394, 259)
        Me.btnExit2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.Size = New System.Drawing.Size(87, 31)
        Me.btnExit2.TabIndex = 5
        Me.btnExit2.Text = "返回"
        Me.btnExit2.UseVisualStyleBackColor = False
        '
        'lblJG
        '
        Me.lblJG.AutoSize = True
        Me.lblJG.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblJG.Location = New System.Drawing.Point(95, 335)
        Me.lblJG.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJG.Name = "lblJG"
        Me.lblJG.Size = New System.Drawing.Size(0, 21)
        Me.lblJG.TabIndex = 6
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Blue
        Me.btnContinue.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(275, 259)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(87, 31)
        Me.btnContinue.TabIndex = 7
        Me.btnContinue.Text = "继续"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(632, 544)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblJG)
        Me.Controls.Add(Me.btnExit2)
        Me.Controls.Add(Me.btnOK2)
        Me.Controls.Add(Me.txtscore)
        Me.Controls.Add(Me.lblPW)
        Me.Controls.Add(Me.lblTS)
        Me.Font = New System.Drawing.Font("黑体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "歌曲大奖赛评分系统"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTS As System.Windows.Forms.Label
    Friend WithEvents lblPW As System.Windows.Forms.Label
    Friend WithEvents txtscore As System.Windows.Forms.TextBox
    Friend WithEvents btnOK2 As System.Windows.Forms.Button
    Friend WithEvents btnExit2 As System.Windows.Forms.Button
    Friend WithEvents lblJG As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
End Class
