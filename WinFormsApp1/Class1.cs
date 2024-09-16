using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
namespace WindowsFormsApplication1
{
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width+10, ClientSize.Height+10);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}