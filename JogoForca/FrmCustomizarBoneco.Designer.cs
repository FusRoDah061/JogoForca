namespace JogoForca
{
    partial class FrmCustomizarBoneco
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCabeca = new System.Windows.Forms.TabPage();
            this.tabTorso = new System.Windows.Forms.TabPage();
            this.tabBracos = new System.Windows.Forms.TabPage();
            this.tabPernas = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCabeca);
            this.tabControl1.Controls.Add(this.tabTorso);
            this.tabControl1.Controls.Add(this.tabBracos);
            this.tabControl1.Controls.Add(this.tabPernas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCabeca
            // 
            this.tabCabeca.Location = new System.Drawing.Point(4, 22);
            this.tabCabeca.Name = "tabCabeca";
            this.tabCabeca.Padding = new System.Windows.Forms.Padding(3);
            this.tabCabeca.Size = new System.Drawing.Size(492, 352);
            this.tabCabeca.TabIndex = 0;
            this.tabCabeca.Text = "Cabeça";
            this.tabCabeca.UseVisualStyleBackColor = true;
            // 
            // tabTorso
            // 
            this.tabTorso.Location = new System.Drawing.Point(4, 22);
            this.tabTorso.Name = "tabTorso";
            this.tabTorso.Padding = new System.Windows.Forms.Padding(3);
            this.tabTorso.Size = new System.Drawing.Size(492, 352);
            this.tabTorso.TabIndex = 1;
            this.tabTorso.Text = "Torso";
            this.tabTorso.UseVisualStyleBackColor = true;
            // 
            // tabBracos
            // 
            this.tabBracos.Location = new System.Drawing.Point(4, 22);
            this.tabBracos.Name = "tabBracos";
            this.tabBracos.Size = new System.Drawing.Size(492, 352);
            this.tabBracos.TabIndex = 2;
            this.tabBracos.Text = "Braços";
            this.tabBracos.UseVisualStyleBackColor = true;
            // 
            // tabPernas
            // 
            this.tabPernas.Location = new System.Drawing.Point(4, 22);
            this.tabPernas.Name = "tabPernas";
            this.tabPernas.Size = new System.Drawing.Size(492, 352);
            this.tabPernas.TabIndex = 3;
            this.tabPernas.Text = "Pernas";
            this.tabPernas.UseVisualStyleBackColor = true;
            // 
            // FrmCustomizarBoneco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 378);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCustomizarBoneco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customizar boneco";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCabeca;
        private System.Windows.Forms.TabPage tabTorso;
        private System.Windows.Forms.TabPage tabBracos;
        private System.Windows.Forms.TabPage tabPernas;
    }
}