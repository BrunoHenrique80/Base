using Infra;
using System;
using System.Windows.Forms;

namespace UIPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaUsuário frm = new FormConsultaUsuário())
            {
                frm.ShowDialog();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
            Arquivo.GravarLog("Abriu a tela princial");
        }
    }
}
