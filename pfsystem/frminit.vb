Public Class frminit
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End                                  '退出按钮
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtPW.Text = "" Or txtXS.Text = "" Then        '判断输入文本框是否为空
        Else
            PW = Val(txtPW.Text)                         '获取评委数量
            XS = Val(txtXS.Text)                         '获取选手数量
            frmmain.Show()                               '将第二个窗体显示出来
            Me.Hide()                                    '将本窗体隐藏起来
        End If
    End Sub

    Private Sub btnxg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXG.Click
        txtPW.Text = ""
        txtXS.Text = ""
        txtPW.Focus()                                    '获取输入焦点
    End Sub
End Class
