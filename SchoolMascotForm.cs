using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotFinnD
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void mniImmaculata_Click(object sender, EventArgs e)
        {
            lblSchool.Text = "Immaculata";
            lblMascot.Text = "Saints";
        }
    }
}
