Public Class frmmain

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim dafen(XS - 1, PW - 1)       '重新定义二维数组大小使其能存放所有数据
        ReDim defen(XS - 1)               '重新定义一维数组大小使其能存放所有数据
        a = 0
        b = 0

    End Sub

    Private Sub btnExit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit2.Click
        frminit.Show()                       '将第一个窗体重新显示
        Me.Close()                           '将本窗体关闭
    End Sub

    Private Sub btnOK2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK2.Click
        If Not txtscore.Text = "" Then                    '判断输入文本框是否为空
            If a < XS Then                               '判断二维数据是否该换行
                If b < PW And b > -1 Then
                    dafen(a, b) = Val(txtscore.Text)      '将打分数据存入数组
                    b = b + 1
                    txtscore.Text = ""
                    txtscore.Focus()                     '为下一次输入做准备
                    If b < PW Then                       '判断当前选手的得分是否全部输完
                        lblPW.Text = "评委" & b + 1 & "的打分:"
                    Else                                 '在给下一位选手打分之前将本选手得分结果显示
                        lblPW.Text = "            "
                        b = b - 1
                        max = dafen(a, 0)
                        min = dafen(a, 0)
                        For i = 1 To b                   '求出当前选手得分的最大值和最小值
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
                        defen(a) = (defen(a) - max - min) / (PW - 2)    '求出当前选手的最后得分
                        lblTS.Text = a + 1 & "号选手的得分结果"
                        lblJG.Text = "评委给" & a + 1 & "号选手的打分分别为:" & vbCrLf
                        For i = 0 To b
                            lblJG.Text = lblJG.Text & dafen(a, i) & "  " '显示得分结果
                        Next i
                        lblJG.Text = lblJG.Text & vbCrLf & "最低分为:" & vbCrLf & min & vbCrLf & "最高分为:" & vbCrLf & max & vbCrLf & "最后得分为:" & defen(a) & vbCrLf
                        a = a + 1
                        b = -1
                        txtscore.Text = ""
                        txtscore.Focus()                               '为下一位选手打分准备
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click
        If Not lblTS.Text = "比赛结束，请返回退出！" Then         '判断比赛是否结束
            If a > XS - 1 Then                                  '判断所有数据是否已经输入完毕
                Dim temp(XS - 1) As Integer                      '定义一个辅肋数组用于给选手排序
                For i = 0 To XS - 1
                    temp(i) = i
                Next i
                For i = 1 To XS                                 '使用冒泡排序方法给选手排序
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
                lblJG.Text = "各选手的得分分别为:" & vbCrLf       '将排序后的结果输出
                For i = 0 To XS - 1
                    lblJG.Text = lblJG.Text & temp(i) + 1 & "号选手得分为：" & defen(i) & vbCrLf
                Next i
                lblTS.Text = "比赛结束，请返回退出！"
            Else                                               '如果比赛未结束，则为下一次输入做准备
                b = 0
                lblJG.Text = ""
                lblTS.Text = "请评委为" & a + 1 & "号选手打分!"
                lblPW.Text = "评委" & b + 1 & "的打分:"
                txtscore.Focus()
            End If
        End If
    End Sub
End Class