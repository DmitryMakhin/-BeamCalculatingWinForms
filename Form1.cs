using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sopromat
{
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }
        private void Main_Window_Load(object sender, EventArgs e)
        {
        
        }
        private void twoSupport_Button_Click(object sender, EventArgs e)
        {
            Calculation_2sb win = new Calculation_2sb();
            this.Hide();
            win.Show();
        }
    }
}
