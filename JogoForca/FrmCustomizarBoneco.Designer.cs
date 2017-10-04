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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabBracoEsquerdo = new System.Windows.Forms.TabPage();
            this.tabBracoDireito = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPernaEsquerda = new System.Windows.Forms.TabPage();
            this.tabPernaDireita = new System.Windows.Forms.TabPage();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelCorSelecionada = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPickCor = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBracos.SuspendLayout();
            this.tabPernas.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCabeca);
            this.tabControl1.Controls.Add(this.tabTorso);
            this.tabControl1.Controls.Add(this.tabBracos);
            this.tabControl1.Controls.Add(this.tabPernas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCabeca
            // 
            this.tabCabeca.Location = new System.Drawing.Point(4, 22);
            this.tabCabeca.Name = "tabCabeca";
            this.tabCabeca.Padding = new System.Windows.Forms.Padding(3);
            this.tabCabeca.Size = new System.Drawing.Size(316, 352);
            this.tabCabeca.TabIndex = 0;
            this.tabCabeca.Text = "Cabeça";
            this.tabCabeca.UseVisualStyleBackColor = true;
            // 
            // tabTorso
            // 
            this.tabTorso.Location = new System.Drawing.Point(4, 22);
            this.tabTorso.Name = "tabTorso";
            this.tabTorso.Padding = new System.Windows.Forms.Padding(3);
            this.tabTorso.Size = new System.Drawing.Size(316, 352);
            this.tabTorso.TabIndex = 1;
            this.tabTorso.Text = "Torso";
            this.tabTorso.UseVisualStyleBackColor = true;
            // 
            // tabBracos
            // 
            this.tabBracos.Controls.Add(this.tabControl2);
            this.tabBracos.Location = new System.Drawing.Point(4, 22);
            this.tabBracos.Name = "tabBracos";
            this.tabBracos.Size = new System.Drawing.Size(316, 352);
            this.tabBracos.TabIndex = 2;
            this.tabBracos.Text = "Braços";
            this.tabBracos.UseVisualStyleBackColor = true;
            // 
            // tabPernas
            // 
            this.tabPernas.Controls.Add(this.tabControl3);
            this.tabPernas.Location = new System.Drawing.Point(4, 22);
            this.tabPernas.Name = "tabPernas";
            this.tabPernas.Size = new System.Drawing.Size(316, 352);
            this.tabPernas.TabIndex = 3;
            this.tabPernas.Text = "Pernas";
            this.tabPernas.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabBracoEsquerdo);
            this.tabControl2.Controls.Add(this.tabBracoDireito);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(316, 352);
            this.tabControl2.TabIndex = 0;
            // 
            // tabBracoEsquerdo
            // 
            this.tabBracoEsquerdo.Location = new System.Drawing.Point(4, 22);
            this.tabBracoEsquerdo.Name = "tabBracoEsquerdo";
            this.tabBracoEsquerdo.Padding = new System.Windows.Forms.Padding(3);
            this.tabBracoEsquerdo.Size = new System.Drawing.Size(308, 326);
            this.tabBracoEsquerdo.TabIndex = 0;
            this.tabBracoEsquerdo.Text = "Esquerdo";
            this.tabBracoEsquerdo.UseVisualStyleBackColor = true;
            // 
            // tabBracoDireito
            // 
            this.tabBracoDireito.Location = new System.Drawing.Point(4, 22);
            this.tabBracoDireito.Name = "tabBracoDireito";
            this.tabBracoDireito.Padding = new System.Windows.Forms.Padding(3);
            this.tabBracoDireito.Size = new System.Drawing.Size(484, 326);
            this.tabBracoDireito.TabIndex = 1;
            this.tabBracoDireito.Text = "Direito";
            this.tabBracoDireito.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPernaEsquerda);
            this.tabControl3.Controls.Add(this.tabPernaDireita);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(0, 0);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(316, 352);
            this.tabControl3.TabIndex = 1;
            // 
            // tabPernaEsquerda
            // 
            this.tabPernaEsquerda.Location = new System.Drawing.Point(4, 22);
            this.tabPernaEsquerda.Name = "tabPernaEsquerda";
            this.tabPernaEsquerda.Padding = new System.Windows.Forms.Padding(3);
            this.tabPernaEsquerda.Size = new System.Drawing.Size(308, 326);
            this.tabPernaEsquerda.TabIndex = 0;
            this.tabPernaEsquerda.Text = "Esquerda";
            this.tabPernaEsquerda.UseVisualStyleBackColor = true;
            // 
            // tabPernaDireita
            // 
            this.tabPernaDireita.Location = new System.Drawing.Point(4, 22);
            this.tabPernaDireita.Name = "tabPernaDireita";
            this.tabPernaDireita.Padding = new System.Windows.Forms.Padding(3);
            this.tabPernaDireita.Size = new System.Drawing.Size(484, 326);
            this.tabPernaDireita.TabIndex = 1;
            this.tabPernaDireita.Text = "Direita";
            this.tabPernaDireita.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(331, 322);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(158, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseMnemonic = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // panelCorSelecionada
            // 
            this.panelCorSelecionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCorSelecionada.Location = new System.Drawing.Point(331, 22);
            this.panelCorSelecionada.Name = "panelCorSelecionada";
            this.panelCorSelecionada.Size = new System.Drawing.Size(20, 20);
            this.panelCorSelecionada.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cor selecionada";
            // 
            // btnPickCor
            // 
            this.btnPickCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickCor.Location = new System.Drawing.Point(331, 48);
            this.btnPickCor.Name = "btnPickCor";
            this.btnPickCor.Size = new System.Drawing.Size(157, 23);
            this.btnPickCor.TabIndex = 20;
            this.btnPickCor.TabStop = false;
            this.btnPickCor.Text = "Selecionar cor...";
            this.btnPickCor.UseMnemonic = false;
            this.btnPickCor.UseVisualStyleBackColor = true;
            this.btnPickCor.Click += new System.EventHandler(this.btnPickCor_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(331, 351);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseMnemonic = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCustomizarBoneco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 378);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPickCor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelCorSelecionada);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCustomizarBoneco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customizar boneco";
            this.tabControl1.ResumeLayout(false);
            this.tabBracos.ResumeLayout(false);
            this.tabPernas.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCabeca;
        private System.Windows.Forms.TabPage tabTorso;
        private System.Windows.Forms.TabPage tabBracos;
        private System.Windows.Forms.TabPage tabPernas;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabBracoEsquerdo;
        private System.Windows.Forms.TabPage tabBracoDireito;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPernaEsquerda;
        private System.Windows.Forms.TabPage tabPernaDireita;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelCorSelecionada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPickCor;
        private System.Windows.Forms.Button btnCancelar;
    }
}