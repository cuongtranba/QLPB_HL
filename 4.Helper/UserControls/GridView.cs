using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Helper.UserControls
{
    public partial class GridView : DataGridView
    {
        public bool isFirstLoad = true;
        public GridView()
        {
            InitializeComponent();
        }

        private void GridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.Black))
            {
                string str = (e.RowIndex + 1).ToString().PadLeft(this.RowCount.ToString().Length, '0');
                e.Graphics.DrawString(str, this.Font, b, new Point(e.RowBounds.X + 10, e.RowBounds.Y + 4));
            }
        }
    }
}
