using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Learn_code_with_S.A.C
{
    public partial class startup : Form
    {
        public startup()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "C#";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 b1 = new Form1();
            b1.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help a = new Help();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caidat c = new caidat();
            c.ShowDialog();
        }
        
    }
}
//https://www.youtube.com/watch?v=6BG2aqT23eY
//https://www.youtube.com/watch?v=nxF3CI5SYJs