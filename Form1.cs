using Slitter_Mater.Necessidade_prod;

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
    }
}
