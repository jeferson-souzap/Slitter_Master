namespace Slitter_Mater.Necessidade_prod
{
    partial class Form_necessidade_prod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            button3 = new Button();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGrid_necessidade_prod = new DataGridView();
            bt_fechar = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_necessidade_prod).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(bt_fechar);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(950, 138);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = ".";
            // 
            // button3
            // 
            button3.Location = new Point(374, 84);
            button3.Name = "button3";
            button3.Size = new Size(225, 27);
            button3.TabIndex = 7;
            button3.Text = "Exportar Resultado";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(6, 120);
            label6.Name = "label6";
            label6.Size = new Size(245, 15);
            label6.TabIndex = 6;
            label6.Text = "RESUMO DA NECESSIDADE DE PRODUÇÃO";
            // 
            // button2
            // 
            button2.Location = new Point(719, 84);
            button2.Name = "button2";
            button2.Size = new Size(225, 27);
            button2.TabIndex = 5;
            button2.Text = "Atualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 84);
            button1.Name = "button1";
            button1.Size = new Size(225, 27);
            button1.TabIndex = 4;
            button1.Text = "Carregar Arquivos";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(616, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(616, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Pasta Saida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Pasta entrada";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 478);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(950, 60);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Status";
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(713, 19);
            label5.Name = "label5";
            label5.Size = new Size(225, 32);
            label5.TabIndex = 3;
            label5.Text = "Não Atende:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(349, 19);
            label4.Name = "label4";
            label4.Size = new Size(225, 32);
            label4.TabIndex = 2;
            label4.Text = "Atende:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(225, 32);
            label3.TabIndex = 1;
            label3.Text = "Total de linhas:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGrid_necessidade_prod
            // 
            dataGrid_necessidade_prod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_necessidade_prod.Dock = DockStyle.Fill;
            dataGrid_necessidade_prod.Location = new Point(0, 138);
            dataGrid_necessidade_prod.Name = "dataGrid_necessidade_prod";
            dataGrid_necessidade_prod.Size = new Size(950, 340);
            dataGrid_necessidade_prod.TabIndex = 2;
            // 
            // bt_fechar
            // 
            bt_fechar.Location = new Point(881, 16);
            bt_fechar.Name = "bt_fechar";
            bt_fechar.Size = new Size(63, 27);
            bt_fechar.TabIndex = 8;
            bt_fechar.Text = "SAIR";
            bt_fechar.UseVisualStyleBackColor = true;
            bt_fechar.Click += bt_fechar_Click;
            // 
            // Form_necessidade_prod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 538);
            Controls.Add(dataGrid_necessidade_prod);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_necessidade_prod";
            Text = "Necessidade de produção";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_necessidade_prod).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGrid_necessidade_prod;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button1;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button3;
        private Button bt_fechar;
    }
}