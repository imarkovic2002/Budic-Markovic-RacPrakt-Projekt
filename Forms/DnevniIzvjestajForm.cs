using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Blagajna.DB.Stores;

namespace Budić_Marković_RacPrakt_Projekt.Forms
{
    public partial class DnevniIzvjestajForm : Form
    {
        DnevniIzvjestajStore store;
        public DnevniIzvjestajForm()
        {
            InitializeComponent();
            if (store == null)
                store=new DnevniIzvjestajStore();
            dataGridView1.DataSource = store.getDnevniIzvjestaj() ;
        }

        private void DnevniIzvjestajForm_Load(object sender, EventArgs e)
        {

        }
    }
}
