Public Class frmSlotMachine

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
        lblSlot1.Text = Int(3 * Rnd() + 1)
        lblSlot2.Text = Int(3 * Rnd() + 1)
        lblSlot3.Text = Int(3 * Rnd() + 1)

        lblSpinNum.Text = lblSpinNum.Text - 1

        If lblSlot1.Text = lblSlot2.Text And lblSlot1.Text = lblSlot3.Text Then
            lblSpinPoint.Text = lblSpinPoint.Text + 1
            MsgBox("Hooray! You hit the guess.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Slot Machine")
        End If

        If (lblSpinNum.Text = 0) Then
            If (lblSpinPoint.Text = 0) Then
                MsgBox("Sorry, out of the guesses. Better luck next time.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Slot Machine")
            Else
                MsgBox("Congratulations, You have won the game " & lblSpinPoint.Text & " time(s).", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Slot Machine")
            End If
            btnSpin.Enabled = False
            btnReset.Enabled = True
        End If
    End Sub

    Private Sub frmSlotMachine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        lblSpinNum.Text = 10
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblSlot1.Text = 0
        lblSlot2.Text = 0
        lblSlot3.Text = 0

        lblSpinNum.Text = 10
        lblSpinPoint.Text = 0

        btnSpin.Enabled = True
        btnReset.Enabled = False
    End Sub
End Class
