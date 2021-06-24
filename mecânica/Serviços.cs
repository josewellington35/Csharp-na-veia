using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mecânica
{
    public partial class Serviços : Form
    {
        public Serviços()
        {
            InitializeComponent();
        }

        private void btnGuncho_Click(object sender, EventArgs e)
        {
            Guincho newGu = new Guincho();
            newGu.ShowDialog();
        }
    }
}
