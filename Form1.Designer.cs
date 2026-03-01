namespace Slitter_Mater
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_status_usuario = new Label();
            bt_config = new Button();
            bt_relatorios = new Button();
            bt_plano_maq = new Button();
            bt_plano_corte = new Button();
            bt_necessidade_prod = new Button();
            panel_rodape = new Panel();
            panel_esquerda = new Panel();
            panel_central = new Panel();
            panel_esquerda.SuspendLayout();
            SuspendLayout();
            // 
            // lb_status_usuario
            // 
            lb_status_usuario.BorderStyle = BorderStyle.FixedSingle;
            lb_status_usuario.Location = new Point(3, 9);
            lb_status_usuario.Name = "lb_status_usuario";
            lb_status_usuario.Size = new Size(125, 81);
            lb_status_usuario.TabIndex = 5;
            lb_status_usuario.Text = "Usuário: ------\r\nPrivilégios: Admin";
            // 
            // bt_config
            // 
            bt_config.Location = new Point(3, 209);
            bt_config.Name = "bt_config";
            bt_config.Size = new Size(125, 23);
            bt_config.TabIndex = 4;
            bt_config.Text = "Configuração";
            bt_config.UseVisualStyleBackColor = true;
            // 
            // bt_relatorios
            // 
            bt_relatorios.Location = new Point(3, 180);
            bt_relatorios.Name = "bt_relatorios";
            bt_relatorios.Size = new Size(125, 23);
            bt_relatorios.TabIndex = 3;
            bt_relatorios.Text = "Relatórios";
            bt_relatorios.UseVisualStyleBackColor = true;
            // 
            // bt_plano_maq
            // 
            bt_plano_maq.Location = new Point(3, 151);
            bt_plano_maq.Name = "bt_plano_maq";
            bt_plano_maq.Size = new Size(125, 23);
            bt_plano_maq.TabIndex = 2;
            bt_plano_maq.Text = "Plano de Máquina";
            bt_plano_maq.UseVisualStyleBackColor = true;
            // 
            // bt_plano_corte
            // 
            bt_plano_corte.Location = new Point(3, 122);
            bt_plano_corte.Name = "bt_plano_corte";
            bt_plano_corte.Size = new Size(125, 23);
            bt_plano_corte.TabIndex = 1;
            bt_plano_corte.Text = "Plano de Corte";
            bt_plano_corte.UseVisualStyleBackColor = true;
            // 
            // bt_necessidade_prod
            // 
            bt_necessidade_prod.Location = new Point(3, 93);
            bt_necessidade_prod.Name = "bt_necessidade_prod";
            bt_necessidade_prod.Size = new Size(125, 23);
            bt_necessidade_prod.TabIndex = 0;
            bt_necessidade_prod.Text = "Necessidade";
            bt_necessidade_prod.UseVisualStyleBackColor = true;
            bt_necessidade_prod.Click += bt_necessidade_prod_Click;
            // 
            // panel_rodape
            // 
            panel_rodape.Dock = DockStyle.Bottom;
            panel_rodape.Location = new Point(0, 530);
            panel_rodape.Name = "panel_rodape";
            panel_rodape.Size = new Size(995, 32);
            panel_rodape.TabIndex = 2;
            // 
            // panel_esquerda
            // 
            panel_esquerda.Controls.Add(lb_status_usuario);
            panel_esquerda.Controls.Add(bt_config);
            panel_esquerda.Controls.Add(bt_necessidade_prod);
            panel_esquerda.Controls.Add(bt_relatorios);
            panel_esquerda.Controls.Add(bt_plano_corte);
            panel_esquerda.Controls.Add(bt_plano_maq);
            panel_esquerda.Dock = DockStyle.Left;
            panel_esquerda.Location = new Point(0, 0);
            panel_esquerda.Name = "panel_esquerda";
            panel_esquerda.Size = new Size(135, 530);
            panel_esquerda.TabIndex = 3;
            // 
            // panel_central
            // 
            panel_central.Dock = DockStyle.Fill;
            panel_central.Location = new Point(135, 0);
            panel_central.Name = "panel_central";
            panel_central.Size = new Size(860, 530);
            panel_central.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 562);
            Controls.Add(panel_central);
            Controls.Add(panel_esquerda);
            Controls.Add(panel_rodape);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Slitter Master";
            panel_esquerda.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button bt_necessidade_prod;
        private Button bt_relatorios;
        private Button bt_plano_maq;
        private Button bt_plano_corte;
        private Button bt_config;
        private Label lb_status_usuario;
        private Panel panel_rodape;
        private Panel panel_esquerda;
        private Panel panel_central;
    }
}
