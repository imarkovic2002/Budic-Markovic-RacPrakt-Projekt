using System;

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
            dgDanasnjiPromet.DataSource = store.getDnevniIzvjestaj() ;
        }

        private void DnevniIzvjestajForm_Load(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
