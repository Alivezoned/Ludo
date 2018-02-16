using System;
using System.Drawing;
using System.Windows.Forms;

// Alivezoned.com
namespace Ludo_Ultimatum_Omega
{
    public partial class LudoNew : Form
    {
        public LudoNew()
        {
            InitializeComponent();
            set_border_tables();
            create_path();
        }

        #region Table Painting (Cell Paint)
        private void table_panel_top_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
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
        private void table_panel_right_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
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
        private void table_panel_left_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
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
        private void table_panel_bottom_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
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
        }
        public void set_border_tables()
        {
            table_panel_left.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            table_panel_right.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            table_panel_top.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            table_panel_bottom.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
        }        
        private void table_green_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Brush b = Brushes.Green;
            if (e.Column == 1 && e.Row == 0)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 0 && e.Row == 1)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 1 && e.Row == 2)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 2 && e.Row == 1)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }
        private void table_red_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Brush b = Brushes.Red;
            if (e.Column == 1 && e.Row == 0)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 0 && e.Row == 1)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 1 && e.Row == 2)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 2 && e.Row == 1)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }
        private void table_blue_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Brush b = Brushes.Blue;
            if (e.Column == 1 && e.Row == 0)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 0 && e.Row == 1)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 1 && e.Row == 2)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 2 && e.Row == 1)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }
        private void table_yellow_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Brush b = Brushes.Yellow;
            if (e.Column == 1 && e.Row == 0)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 0 && e.Row == 1)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 1 && e.Row == 2)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
            if (e.Column == 2 && e.Row == 1)
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            painting(e);
        }
        void painting(TableLayoutCellPaintEventArgs e)
        {

            Brush r = Brushes.Red;
            Brush g = Brushes.Green;
            Brush b = Brushes.Blue;
            Brush y = Brushes.Yellow;
            int row = 0, col = 0;
            
            // Green Color
            while (row < 4)
            {
                if (e.Row == row && e.Column == col)
                {
                    e.Graphics.FillRectangle(g, e.CellBounds);
                }
                if (e.Column == 2 && e.Row > 1 && e.Row < 7)
                {
                    e.Graphics.FillRectangle(g, e.CellBounds);
                }
                if (e.Column == 1 && e.Row > 1 && e.Row < 8)
                {
                    e.Graphics.FillRectangle(g, e.CellBounds);
                }
                if (e.Column == 0 && e.Row > 0 && e.Row < 9)
                {
                    e.Graphics.FillRectangle(g, e.CellBounds);
                }
                row++; col++;
            }
            while (row <= 10 && row >= 0)
            {
                if (e.Row == row && e.Column == col)
                {
                    e.Graphics.FillRectangle(g, e.CellBounds);
                }
                row++; col--;
            }
        }
        #endregion


        PathList blue_path = new PathList();
        PathList red_path = new PathList();
        PathList green_path = new PathList();
        PathList yellow_path = new PathList();

        void create_path()
        {
            
            // Yellow Path
            yellow_path.path = Generate_Path(1, 15, 51, 0, "y");

            // Red Path
            red_path.path = Generate_Path(27, 1, 52, 25, "r");

            // Blue Path
            blue_path.path = Generate_Path(40, 1, 52, 38, "b");

            // Green Path
            green_path.path = Generate_Path(14, 1, 52, 12, "g");
    

        }
        PictureBox[] Generate_Path(int count, int b_count, int count_less_than_equal, int b_count_less_than_equal, string color)
        {
            PictureBox[] path = new PictureBox[57];
            int safe_box = 5;
            for (int i = 1; i < path.Length; i++)
            {
                if (count <= count_less_than_equal)
                {
                    path[i] = (PictureBox)Controls.Find("c_" + count.ToString(), true)[0];
                    count++;
                }
                else if (b_count <= b_count_less_than_equal)
                {
                    path[i] = (PictureBox)Controls.Find("c_" + b_count.ToString(), true)[0];
                    b_count++;
                }
                else
                {
                    if (safe_box > 0)
                    {
                        path[i] = (PictureBox)Controls.Find(color+"_" + safe_box, true)[0];
                        safe_box--;
                    }
                }
            }

            return path;
        }
        void move(PictureBox[] p, Image img, ref int i)
        {
            if (i < p.Length)
            {
                if (i > 0)
                {
                    try
                    {
                        p[i - 1].Image = null;
                    } catch (Exception ex) { }
                }
                PictureBox pp = p[i];
                pp.Image = img;
                i++;
            }
        }
        int a = 1, b = 1, c = 1, d = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            move(red_path.path, Properties.Resources.peg, ref a);
            move(blue_path.path, Properties.Resources.peg_blue, ref b);
            move(yellow_path.path, Properties.Resources.peg_yellow, ref c);
            move(green_path.path, Properties.Resources.peg_green, ref d);
        }
    }
}
