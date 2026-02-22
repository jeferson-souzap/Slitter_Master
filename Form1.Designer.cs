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
            groupBox_rodape = new GroupBox();
            groupBox_laterial = new GroupBox();
            groupBox_centro = new GroupBox();
            SuspendLayout();
            // 
            // groupBox_rodape
            // 
            groupBox_rodape.Dock = DockStyle.Bottom;
            groupBox_rodape.Location = new Point(0, 512);
            groupBox_rodape.Name = "groupBox_rodape";
            groupBox_rodape.Size = new Size(995, 50);
            groupBox_rodape.TabIndex = 0;
            groupBox_rodape.TabStop = false;
            groupBox_rodape.Text = "Status";
            // 
            // groupBox_laterial
            // 
            groupBox_laterial.Dock = DockStyle.Left;
            groupBox_laterial.Location = new Point(0, 0);
            groupBox_laterial.Name = "groupBox_laterial";
            groupBox_laterial.Size = new Size(137, 512);
            groupBox_laterial.TabIndex = 1;
            groupBox_laterial.TabStop = false;
            groupBox_laterial.Text = "Menu";
            // 
            // groupBox_centro
            // 
            groupBox_centro.Dock = DockStyle.Fill;
            groupBox_centro.Location = new Point(137, 0);
            groupBox_centro.Name = "groupBox_centro";
            groupBox_centro.Size = new Size(858, 512);
            groupBox_centro.TabIndex = 2;
            groupBox_centro.TabStop = false;
            groupBox_centro.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 562);
            Controls.Add(groupBox_centro);
            Controls.Add(groupBox_laterial);
            Controls.Add(groupBox_rodape);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Slitter Master";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_rodape;
        private GroupBox groupBox_laterial;
        private GroupBox groupBox_centro;
    }
}
