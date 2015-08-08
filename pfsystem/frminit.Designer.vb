<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frminit
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
        Me.lblinit = New System.Windows.Forms.Label
        Me.lblpwsl = New System.Windows.Forms.Label
        Me.lblxssl = New System.Windows.Forms.Label
        Me.txtPW = New System.Windows.Forms.TextBox
        Me.txtXS = New System.Windows.Forms.TextBox
        Me.btnXG = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblinit
        '
        Me.lblinit.AutoSize = True
        Me.lblinit.Font = New System.Drawing.Font("宋体", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblinit.Location = New System.Drawing.Point(57, 41)
        Me.lblinit.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblinit.Name = "lblinit"
        Me.lblinit.Size = New System.Drawing.Size(502, 35)
        Me.lblinit.TabIndex = 0
        Me.lblinit.Text = "欢迎使用歌曲大奖赛评分系统!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblpwsl
        '
        Me.lblpwsl.AutoSize = True
        Me.lblpwsl.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblpwsl.Location = New System.Drawing.Point(61, 204)
        Me.lblpwsl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblpwsl.Name = "lblpwsl"
        Me.lblpwsl.Size = New System.Drawing.Size(239, 29)
        Me.lblpwsl.TabIndex = 1
        Me.lblpwsl.Text = "请输入评委数量:"
        '
        'lblxssl
        '
        Me.lblxssl.AutoSize = True
        Me.lblxssl.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblxssl.Location = New System.Drawing.Point(61, 291)
        Me.lblxssl.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblxssl.Name = "lblxssl"
        Me.lblxssl.Size = New System.Drawing.Size(223, 29)
        Me.lblxssl.TabIndex = 2
        Me.lblxssl.Text = "请输入选手数量"
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPW.Location = New System.Drawing.Point(295, 204)
        Me.txtPW.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(264, 41)
        Me.txtPW.TabIndex = 4
        '
        'txtXS
        '
        Me.txtXS.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtXS.Location = New System.Drawing.Point(295, 291)
        Me.txtXS.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtXS.Name = "txtXS"
        Me.txtXS.Size = New System.Drawing.Size(264, 41)
        Me.txtXS.TabIndex = 5
        '
        'btnXG
        '
        Me.btnXG.BackColor = System.Drawing.Color.Blue
        Me.btnXG.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnXG.Location = New System.Drawing.Point(64, 469)
        Me.btnXG.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnXG.Name = "btnXG"
        Me.btnXG.Size = New System.Drawing.Size(143, 40)
        Me.btnXG.TabIndex = 6
        Me.btnXG.Text = "修改"
        Me.btnXG.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Blue
        Me.btnOK.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOK.Location = New System.Drawing.Point(260, 469)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(143, 40)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "确定"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Blue
        Me.btnExit.Font = New System.Drawing.Font("宋体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.Location = New System.Drawing.Point(455, 469)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 40)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "退出"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frminit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(638, 572)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnXG)
        Me.Controls.Add(Me.txtXS)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.lblxssl)
        Me.Controls.Add(Me.lblpwsl)
        Me.Controls.Add(Me.lblinit)
        Me.Font = New System.Drawing.Font("宋体", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frminit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "歌曲大奖赛评分系统"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinit As System.Windows.Forms.Label
    Friend WithEvents lblpwsl As System.Windows.Forms.Label
    Friend WithEvents lblxssl As System.Windows.Forms.Label
    Friend WithEvents txtPW As System.Windows.Forms.TextBox
    Friend WithEvents txtXS As System.Windows.Forms.TextBox
    Friend WithEvents btnXG As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
