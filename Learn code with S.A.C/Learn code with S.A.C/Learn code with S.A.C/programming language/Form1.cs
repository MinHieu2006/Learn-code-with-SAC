using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Learn_code_with_S.A.C
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flyoutPanelControl1_DragDrop(object sender, DragEventArgs e)
        {
            Control ctrl = e.Data.GetData(e.Data.GetFormats()[0]) as Control;
            if (ctrl != null)
            {
                ctrl.Location = this.flyoutPanelControl1.PointToClient(new Point(e.X, e.Y));
                this.flyoutPanelControl1.Controls.Add(ctrl);

            }

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.DoDragDrop(button1, DragDropEffects.Copy);
        }

        private void flyoutPanelControl1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        
    }
}