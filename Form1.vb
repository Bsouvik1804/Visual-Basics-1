Public Class Form1
    Private Sub cmbshape_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbshape.SelectedIndexChanged
        If cmbshape.Text = "Circle" Then
            lblradius.Visible = True
            txtradius.Visible = True
            lbllength.Visible = False
            txtlength.Visible = False
            lblbreadth.Visible = False
            txtbreadth.Visible = False
            RectangleShape1.Visible = False
            OvalShape1.Visible = True

        Else cmbshape.Text = "Rectangle"
            lblradius.Visible = False
            txtradius.Visible = False
            lbllength.Visible = True
            txtlength.Visible = True
            lblbreadth.Visible = True
            txtbreadth.Visible = True
            RectangleShape1.Visible = True
            OvalShape1.Visible = False
        End If
    End Sub

    Private Sub btnarea_Click(sender As Object, e As EventArgs) Handles btnarea.Click
        Dim a As Double
        If cmbshape.Text = "Circle" Then
            a = 3.14 * CDbl(txtradius.Text) * CDbl(txtradius.Text)
            MsgBox("Area" & a)
        Else
            a = CDbl(txtlength.Text) * CDbl(txtbreadth.Text)
            MsgBox("Area" & a)
        End If
    End Sub
End Class