using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    private int cornerRadius = 20;

    public int CornerRadius
    {
        get { return cornerRadius; }
        set { cornerRadius = value; this.Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        GraphicsPath graphicsPath = new GraphicsPath();
        Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
        int radius = cornerRadius;

        graphicsPath.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
        graphicsPath.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
        graphicsPath.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
        graphicsPath.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
        graphicsPath.CloseAllFigures();

        this.Region = new Region(graphicsPath);

        using (Pen pen = new Pen(Color.Transparent, 0))
        {
            pevent.Graphics.DrawPath(pen, graphicsPath);
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Invalidate();
    }
}
