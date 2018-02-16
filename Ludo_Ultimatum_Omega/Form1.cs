using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ludo_Ultimatum_Omega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Color c = Color.FromArgb(123, 123, 123);

            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.BackColor = c;
            tableLayoutPanel_left.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel_right.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel_top.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel_bottom.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //tableLayoutPanel1.Height = this.Height;
            //tableLayoutPanel1.Width = this.Width;
        }

        private void tableLayoutPanel_left_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            if ((e.Row == 1))
            {           
                e.Graphics.FillRectangle(Brushes.Green, e.CellBounds);
            }
            if (e.Row == 0 && e.Column == 1)
            {
                e.Graphics.FillRectangle(Brushes.Green, e.CellBounds);
            }
            if (e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
        }

        private void tableLayoutPanel_right_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            if ((e.Row == 1) && (e.Column < 5))
            {
                e.Graphics.FillRectangle(Brushes.Blue, e.CellBounds);
            }
            if (e.Row == 2 && e.Column == 4)
            {
                e.Graphics.FillRectangle(Brushes.Blue, e.CellBounds);
            }
        }

        private void tableLayoutPanel_top_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            if ((e.Column == 1) && (e.Row > 0))
            {
                e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
            }
            if (e.Row == 1 && e.Column == 2)
            {
                e.Graphics.FillRectangle(Brushes.Red, e.CellBounds);
            }
        }

        private void tableLayoutPanel_bottom_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            if ((e.Column == 1 && (e.Row < 5)))
            {
                e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds);
            }
            if (e.Row == 4 && e.Column == 0)
            {
                e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds);
            }
            draw_pawn(1, e);
        }


        //-------------------------------------

        public void draw_pawn(int color, TableLayoutCellPaintEventArgs e)
        {
            SolidBrush solidBrush;
            Size size; Point point;
            Rectangle rectangle;

            Color r = Color.Red;     Color g = Color.Green;
            Color y = Color.Yellow;  Color b = Color.Blue;

            switch (color)
            {
                case 1:
                    solidBrush = new SolidBrush(r);
                    size = new Size(); size.Height = 10; size.Width = 10;
                    point = new Point(); point.X = 15; point.Y = 0;
                    rectangle = new Rectangle(point, size);
                    e.Graphics.FillEllipse(solidBrush, rectangle);
                break;
            }
        }

        public void test_pawn()
        {
            Color r = Color.Red;
            
        }
    }
}
