Public Class GraphicsExampleForm

    Private Sub GraphicsExampleForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        'DrawLine()
        'DrawCircle()
        DrawRectangle()
    End Sub

    Sub DrawLine()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        g.DrawLine(pen, 0, 0, 150, 50)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawCircle()
        Dim g As Graphics = Me.CreateGraphics
        Dim pen As New Pen(Color.Green)
        g.DrawEllipse(pen, 20, 20, 100, 100)
        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawRectangle()
        Dim g As Graphics = Me.CreateGraphics
        Dim aBrush As New SolidBrush(Color.Red)
        Dim pen As New Pen(Color.Green)
        g.FillRectangle(aBrush, 20, 20, 100, 100)
        g.DrawRectangle(pen, 20, 20, 100, 100)
        pen.Dispose()
        aBrush.Dispose()
        g.Dispose()
    End Sub
End Class
