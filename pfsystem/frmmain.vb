Public Class frmmain

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim dafen(XS - 1, PW - 1)       '���¶����ά�����Сʹ���ܴ����������
        ReDim defen(XS - 1)               '���¶���һά�����Сʹ���ܴ����������
        a = 0
        b = 0

    End Sub

    Private Sub btnExit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit2.Click
        frminit.Show()                       '����һ������������ʾ
        Me.Close()                           '��������ر�
    End Sub

    Private Sub btnOK2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK2.Click
        If Not txtscore.Text = "" Then                    '�ж������ı����Ƿ�Ϊ��
            If a < XS Then                               '�ж϶�ά�����Ƿ�û���
                If b < PW And b > -1 Then
                    dafen(a, b) = Val(txtscore.Text)      '��������ݴ�������
                    b = b + 1
                    txtscore.Text = ""
                    txtscore.Focus()                     'Ϊ��һ��������׼��
                    If b < PW Then                       '�жϵ�ǰѡ�ֵĵ÷��Ƿ�ȫ������
                        lblPW.Text = "��ί" & b + 1 & "�Ĵ��:"
                    Else                                 '�ڸ���һλѡ�ִ��֮ǰ����ѡ�ֵ÷ֽ����ʾ
                        lblPW.Text = "            "
                        b = b - 1
                        max = dafen(a, 0)
                        min = dafen(a, 0)
                        For i = 1 To b                   '�����ǰѡ�ֵ÷ֵ����ֵ����Сֵ
                            If dafen(a, i) > max Then
                                max = dafen(a, i)
                            End If
                            If dafen(a, i) < min Then
                                min = dafen(a, i)
                            End If
                        Next i
                        For i = 0 To b
                            defen(a) = defen(a) + dafen(a, i)
                        Next i
                        defen(a) = (defen(a) - max - min) / (PW - 2)    '�����ǰѡ�ֵ����÷�
                        lblTS.Text = a + 1 & "��ѡ�ֵĵ÷ֽ��"
                        lblJG.Text = "��ί��" & a + 1 & "��ѡ�ֵĴ�ֱַ�Ϊ:" & vbCrLf
                        For i = 0 To b
                            lblJG.Text = lblJG.Text & dafen(a, i) & "  " '��ʾ�÷ֽ��
                        Next i
                        lblJG.Text = lblJG.Text & vbCrLf & "��ͷ�Ϊ:" & vbCrLf & min & vbCrLf & "��߷�Ϊ:" & vbCrLf & max & vbCrLf & "���÷�Ϊ:" & defen(a) & vbCrLf
                        a = a + 1
                        b = -1
                        txtscore.Text = ""
                        txtscore.Focus()                               'Ϊ��һλѡ�ִ��׼��
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        If Not lblTS.Text = "�����������뷵���˳���" Then         '�жϱ����Ƿ����
            If a > XS - 1 Then                                  '�ж����������Ƿ��Ѿ��������
                Dim temp(XS - 1) As Integer                      '����һ�������������ڸ�ѡ������
                For i = 0 To XS - 1
                    temp(i) = i
                Next i
                For i = 1 To XS                                 'ʹ��ð�����򷽷���ѡ������
                    For j = 0 To XS - 1 - i
                        If defen(j) < defen(j + 1) Then
                            t = defen(j + 1)
                            defen(j + 1) = defen(j)
                            defen(j) = t
                            u = temp(j + 1)
                            temp(j + 1) = temp(j)
                            temp(j) = u
                        End If
                    Next j
                Next i
                lblJG.Text = "��ѡ�ֵĵ÷ֱַ�Ϊ:" & vbCrLf       '�������Ľ�����
                For i = 0 To XS - 1
                    lblJG.Text = lblJG.Text & temp(i) + 1 & "��ѡ�ֵ÷�Ϊ��" & defen(i) & vbCrLf
                Next i
                lblTS.Text = "�����������뷵���˳���"
            Else                                               '�������δ��������Ϊ��һ��������׼��
                b = 0
                lblJG.Text = ""
                lblTS.Text = "����ίΪ" & a + 1 & "��ѡ�ִ��!"
                lblPW.Text = "��ί" & b + 1 & "�Ĵ��:"
                txtscore.Focus()
            End If
        End If
    End Sub
End Class