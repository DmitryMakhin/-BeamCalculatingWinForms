using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BeamTest;
using ISopromat;

namespace Sopromat
{
    public partial class Calculation_2sb : Form
    {
        public Calculation_2sb()
        {
            InitializeComponent();
        }
        public TextBox Beam_Length { get => beam_length; }
        public TextBox HingeFixedCoordinate { get => hingeFixedCoordinate; }
        public TextBox HingeNonFixedCoordinate { get => hingeNonFixedCoordinate; }
        public Beam Beam { get; set; }
        private void Calculation_2sb_Load(object sender, EventArgs e)
        {

        }

        private void loadsFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadsForm loads = new LoadsForm(this);
            loads.Show();
        }
    }
}
