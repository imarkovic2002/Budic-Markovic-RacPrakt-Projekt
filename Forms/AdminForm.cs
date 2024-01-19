using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budić_Marković_RacPrakt_Projekt
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBlagajna_Click(object sender, EventArgs e)
        {
            BlagajnaForm blagajnaForm = new BlagajnaForm();
            blagajnaForm.ShowDialog();
        }
    }
}
