Public Class frminit
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End                                  '�˳���ť
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If txtPW.Text = "" Or txtXS.Text = "" Then        '�ж������ı����Ƿ�Ϊ��
        Else
            PW = Val(txtPW.Text)                         '��ȡ��ί����
            XS = Val(txtXS.Text)                         '��ȡѡ������
            frmmain.Show()                               '���ڶ���������ʾ����
            Me.Hide()                                    '����������������
        End If
    End Sub

    Private Sub btnxg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXG.Click
        txtPW.Text = ""
        txtXS.Text = ""
        txtPW.Focus()                                    '��ȡ���뽹��
    End Sub
End Class
