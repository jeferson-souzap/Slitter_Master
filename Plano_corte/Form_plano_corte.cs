using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Slitter_Mater.Plano_corte
{
    public partial class Form_plano_corte : Form
    {
        public Form_plano_corte()
        {
            InitializeComponent();
        }

        #region Area de botões
        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
