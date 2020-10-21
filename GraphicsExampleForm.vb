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

    Sub DrawSineWave()
        'Vi=Vp*sin(w*t+theta)+DC
        'w=2*pi*f
        'w=360*f
        Dim theta As Integer = 90I
        Dim vi As Double
        Dim vp As Integer = 100
        Dim oldVi As Double = Me.Height / 2
        Dim oldTheta As Integer

        For theta = 0 To 360 Step 1

            vi = vp * Sin((PI / 180) + theta)
            Console.WriteLine(vi)

            DrawLine(theta, oldTheta, CInt(vi), CInt(oldVi))
            oldTheta = theta
            oldVi = vi

        Next
    End Sub
End Class
