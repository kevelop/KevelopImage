Public Class Form1
    Dim obmp As Bitmap

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obmp = New Bitmap(1400, 700)

        Dim g As Graphics = Graphics.FromImage(obmp)
        Dim bkgColor As Color = Color.FromArgb(255, 60, 60, 60)
        Dim invColor As Color = Color.FromArgb(bkgColor.ToArgb Xor &HFFFFFF)
        g.FillRectangle(New SolidBrush(bkgColor), 0, 0, 1401, 701)

        MediumK(obmp, invColor)

        g.RotateTransform(-10)
        g.DrawString("evelop", New Font(Me.Font.FontFamily, 200), New SolidBrush(invColor), 190, 270)
        g.ResetTransform()

        'Signature
        g.DrawString("Kevin Moens", New Font(Me.Font.FontFamily, 16), New SolidBrush(invColor), 1050, 550)
        PictureBox1.Image = obmp

        obmp.Save("Kevelop.tif", System.Drawing.Imaging.ImageFormat.Tiff)
		obmp.Save("Kevelop.jpg", System.Drawing.Imaging.ImageFormat.jpeg)
    End Sub

    Private Sub MediumK(ByRef obmp As Image, invColor As Color)

        Dim g As Graphics = Graphics.FromImage(obmp)

        Dim penLineRed = New Pen(Brushes.Red, 40)

        Dim penLinePurple As Pen
        penLinePurple = New Pen(New SolidBrush(Color.FromArgb(255, 128, 255)), 40)
        penLinePurple = New Pen(New SolidBrush(Color.Purple), 40)

        Dim penLineBlue = New Pen(Brushes.Blue, 40)
        Dim penLineGreen As Pen
        'penLineGreen = New Pen(Brushes.Green, 40)
        'penLineGreen = New Pen(New SolidBrush(Color.FromArgb(0, 192, 0)), 40)
        'penLineGreen = New Pen(New SolidBrush(Color.FromArgb(0, 255, 0)), 40)
        penLineGreen = New Pen(New SolidBrush(Color.FromArgb(0, 90, 0)), 40)

        Dim nodeBrushRed As Brush
        nodeBrushRed = New Drawing2D.LinearGradientBrush(New Rectangle(260, 100, 80, 80), Color.Red, Color.FromArgb(255, 255, 130, 130), Drawing2D.LinearGradientMode.Horizontal)


        Dim nodeBrushPurple As Brush
        nodeBrushPurple = New Drawing2D.LinearGradientBrush(New Rectangle(200, 100, 80, 80), Color.FromArgb(255, 128, 255), Color.FromArgb(128, 0, 128), Drawing2D.LinearGradientMode.Horizontal)
        'nodeBrushPurple = New Drawing2D.LinearGradientBrush(New Rectangle(260, 100, 80, 80), Color.Purple, Color.Purple, Drawing2D.LinearGradientMode.Horizontal)

        Dim nodeBrushGreen As Brush
        'nodeBrushGreen = New Drawing2D.LinearGradientBrush(New Rectangle(260, 100, 80, 80), Color.FromArgb(0, 192, 0), Color.FromArgb(0, 192, 0), Drawing2D.LinearGradientMode.Horizontal)
        'nodeBrushGreen = New Drawing2D.LinearGradientBrush(New Rectangle(260, 100, 80, 80), Color.FromArgb(0, 255, 0), Color.FromArgb(0, 255, 0), Drawing2D.LinearGradientMode.Horizontal)
        nodeBrushGreen = New Drawing2D.LinearGradientBrush(New Rectangle(200, 100, 80, 80), Color.FromArgb(0, 240, 0), Color.FromArgb(0, 90, 0), Drawing2D.LinearGradientMode.Horizontal)

        Dim nodeBrushBlue As Brush
        nodeBrushBlue = New Drawing2D.LinearGradientBrush(New Rectangle(220, 100, 80, 80), Color.FromArgb(255, 130, 130, 255), Color.Blue, Drawing2D.LinearGradientMode.Horizontal)

        Dim nodeBrushCenter As Brush
        nodeBrushCenter = New Drawing2D.LinearGradientBrush(New Rectangle(260, 100, 80, 80), Color.Red, Color.Blue, Drawing2D.LinearGradientMode.Horizontal)


        'Top Left to Middle
        g.DrawLine(penLinePurple, 140, 120, 140, 300)
        g.DrawLine(penLineRed, 140, 120, 140, 300)

        'MIddle to bottom Left 
        g.DrawLine(penLineRed, 140, 300, 140, 520)

        'Middle to top right
        g.DrawBezier(penLineGreen, 140, 300, 140, 200, 240, 200, 260, 120)
        g.DrawBezier(penLinePurple, 140, 300, 140, 200, 240, 200, 260, 120)

        'Center to Bottom Right Curve
        g.DrawBezier(penLineBlue, 140, 300, 140, 400, 240, 400, 260, 520)

        'Top Left circles
        g.FillEllipse(nodeBrushPurple, New Rectangle(100, 100, 80, 80))
        g.FillEllipse(nodeBrushRed, New Rectangle(100, 100, 80, 80))
        g.DrawEllipse(New Pen(New SolidBrush(invColor), 4), New Rectangle(100, 100, 80, 80))

        'Top Right circles
        g.FillEllipse(nodeBrushGreen, New Rectangle(200, 100, 80, 80))
        g.FillEllipse(nodeBrushPurple, New Rectangle(200, 100, 80, 80))
        g.DrawEllipse(New Pen(New SolidBrush(invColor), 4), New Rectangle(200, 100, 80, 80))



        'Middle Circle
        g.FillEllipse(nodeBrushCenter, 100, 300, 80, 80)
        g.DrawEllipse(New Pen(New SolidBrush(invColor), 4), 100, 300, 80, 80)



        'Bottom Left circles
        g.FillEllipse(nodeBrushRed, New Rectangle(100, 500, 80, 80))
        g.DrawEllipse(New Pen(New SolidBrush(invColor), 4), New Rectangle(100, 500, 80, 80))

        'Bottom Right circles
        g.FillEllipse(nodeBrushBlue, New Rectangle(220, 500, 80, 80))
        g.DrawEllipse(New Pen(New SolidBrush(invColor), 4), New Rectangle(220, 500, 80, 80))

    End Sub

End Class
