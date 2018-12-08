using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gameoflife
{
    public class GraphicalDisplay : Form
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            using (Pen selPen = new Pen(Color.Blue))
            {
                g.DrawRectangle(selPen, 10, 10, 50, 50);
            }
        }
    }
}
