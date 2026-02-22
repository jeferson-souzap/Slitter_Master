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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            dataGrid_necessidade_prod = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_necessidade_prod).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 46);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "..";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(950, 138);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = ".";
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
            // dataGrid_necessidade_prod
            // 
            dataGrid_necessidade_prod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_necessidade_prod.Dock = DockStyle.Fill;
            dataGrid_necessidade_prod.Location = new Point(0, 184);
            dataGrid_necessidade_prod.Name = "dataGrid_necessidade_prod";
            dataGrid_necessidade_prod.Size = new Size(950, 294);
            dataGrid_necessidade_prod.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 53);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Pasta Saida";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(616, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(616, 23);
            textBox2.TabIndex = 3;
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
            // button2
            // 
            button2.Location = new Point(719, 84);
            button2.Name = "button2";
            button2.Size = new Size(225, 27);
            button2.TabIndex = 5;
            button2.Text = "Exportar Resultado";
            button2.UseVisualStyleBackColor = true;
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
            // label7
            // 
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(12, 19);
            label7.Name = "label7";
            label7.Size = new Size(299, 24);
            label7.TabIndex = 2;
            label7.Text = "Usuário:";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_necessidade_prod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 538);
            Controls.Add(dataGrid_necessidade_prod);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_necessidade_prod";
            Text = "Necessidade de produção";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid_necessidade_prod).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
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
        private Label label7;
    }
}