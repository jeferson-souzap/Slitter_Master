using Slitter_Mater.Necessidade_prod;
using Slitter_Mater.Plano_corte;
using Slitter_Mater.Config;

namespace Slitter_Mater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Abrir_janelas(object formularios)
        {
            if (this.panel_central.Controls.Count > 0)
                this.panel_central.Controls.RemoveAt(0);

            Form janela = (Form)formularios;
            janela.TopLevel = false;
            janela.Dock = DockStyle.Fill;
            this.panel_central.Controls.Add(janela);
            this.panel_central.Tag = janela;
            janela.Show();

        }

        private void bt_necessidade_prod_Click(object sender, EventArgs e)
        {
            Abrir_janelas(new Form_necessidade_prod());
        }

        private void bt_plano_corte_Click(object sender, EventArgs e)
        {
            Abrir_janelas(new Form_plano_corte());
        }

        private void bt_config_Click(object sender, EventArgs e)
        {
            Abrir_janelas(new Form_config());
        }
    }
}
