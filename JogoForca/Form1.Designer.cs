namespace JogoForca
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblLetrasIncorretas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnRecomecar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQtdLetras = new System.Windows.Forms.Label();
            this.lblVitorias = new System.Windows.Forms.Label();
            this.lblDerrotas = new System.Windows.Forms.Label();
            this.lblPartida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCustomizar = new System.Windows.Forms.Button();
            this.btnResetarBoneco = new System.Windows.Forms.Button();
            this.graficoColunas1 = new JogoForca.Controles.GraficoColunas();
            this.forca1 = new JogoForca.Controles.Forca();
            this.palavraControl = new JogoForca.Controles.PalavraControl();
            ((System.ComponentModel.ISupportInitialize)(this.graficoColunas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forca1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Letras incorretas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLetrasIncorretas
            // 
            this.lblLetrasIncorretas.AutoSize = true;
            this.lblLetrasIncorretas.Font = new System.Drawing.Font("Calibri", 13F);
            this.lblLetrasIncorretas.Location = new System.Drawing.Point(223, 92);
            this.lblLetrasIncorretas.Name = "lblLetrasIncorretas";
            this.lblLetrasIncorretas.Size = new System.Drawing.Size(19, 22);
            this.lblLetrasIncorretas.TabIndex = 3;
            this.lblLetrasIncorretas.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Categoria:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calibri", 15F);
            this.lblCategoria.Location = new System.Drawing.Point(222, 32);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(20, 24);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "~";
            // 
            // btnRecomecar
            // 
            this.btnRecomecar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecomecar.Enabled = false;
            this.btnRecomecar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecomecar.Location = new System.Drawing.Point(226, 289);
            this.btnRecomecar.Name = "btnRecomecar";
            this.btnRecomecar.Size = new System.Drawing.Size(82, 23);
            this.btnRecomecar.TabIndex = 7;
            this.btnRecomecar.TabStop = false;
            this.btnRecomecar.Text = "Recomeçar";
            this.btnRecomecar.UseMnemonic = false;
            this.btnRecomecar.UseVisualStyleBackColor = true;
            this.btnRecomecar.Click += new System.EventHandler(this.btnRecomecar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(314, 289);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(82, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "Sair";
            this.btnSair.UseMnemonic = false;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade de letras:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdLetras
            // 
            this.lblQtdLetras.AutoSize = true;
            this.lblQtdLetras.Font = new System.Drawing.Font("Calibri", 13F);
            this.lblQtdLetras.Location = new System.Drawing.Point(223, 146);
            this.lblQtdLetras.Name = "lblQtdLetras";
            this.lblQtdLetras.Size = new System.Drawing.Size(19, 22);
            this.lblQtdLetras.TabIndex = 10;
            this.lblQtdLetras.Text = "~";
            // 
            // lblVitorias
            // 
            this.lblVitorias.AutoSize = true;
            this.lblVitorias.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitorias.Location = new System.Drawing.Point(333, 189);
            this.lblVitorias.Name = "lblVitorias";
            this.lblVitorias.Size = new System.Drawing.Size(63, 15);
            this.lblVitorias.TabIndex = 11;
            this.lblVitorias.Text = "Vitorias: 0";
            this.lblVitorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDerrotas
            // 
            this.lblDerrotas.AutoSize = true;
            this.lblDerrotas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerrotas.Location = new System.Drawing.Point(449, 189);
            this.lblDerrotas.Name = "lblDerrotas";
            this.lblDerrotas.Size = new System.Drawing.Size(69, 15);
            this.lblDerrotas.TabIndex = 12;
            this.lblDerrotas.Text = "Derrotas: 0";
            this.lblDerrotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartida.Location = new System.Drawing.Point(229, 189);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(60, 15);
            this.lblPartida.TabIndex = 13;
            this.lblPartida.Text = "Partida: 0";
            this.lblPartida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(-1, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Desenvolvido por Allex Rodrigues";
            // 
            // btnCustomizar
            // 
            this.btnCustomizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomizar.Location = new System.Drawing.Point(12, 347);
            this.btnCustomizar.Name = "btnCustomizar";
            this.btnCustomizar.Size = new System.Drawing.Size(205, 23);
            this.btnCustomizar.TabIndex = 16;
            this.btnCustomizar.TabStop = false;
            this.btnCustomizar.Text = "Customizar boneco";
            this.btnCustomizar.UseMnemonic = false;
            this.btnCustomizar.UseVisualStyleBackColor = true;
            this.btnCustomizar.Click += new System.EventHandler(this.btnCustomizar_Click);
            // 
            // btnResetarBoneco
            // 
            this.btnResetarBoneco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetarBoneco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetarBoneco.Location = new System.Drawing.Point(12, 318);
            this.btnResetarBoneco.Name = "btnResetarBoneco";
            this.btnResetarBoneco.Size = new System.Drawing.Size(205, 23);
            this.btnResetarBoneco.TabIndex = 17;
            this.btnResetarBoneco.TabStop = false;
            this.btnResetarBoneco.Text = "Resetar boneco";
            this.btnResetarBoneco.UseMnemonic = false;
            this.btnResetarBoneco.UseVisualStyleBackColor = true;
            this.btnResetarBoneco.Click += new System.EventHandler(this.btnResetarBoneco_Click);
            // 
            // graficoColunas1
            // 
            this.graficoColunas1.Location = new System.Drawing.Point(226, 213);
            this.graficoColunas1.Name = "graficoColunas1";
            this.graficoColunas1.Size = new System.Drawing.Size(346, 70);
            this.graficoColunas1.TabIndex = 14;
            this.graficoColunas1.TabStop = false;
            this.graficoColunas1.Total = 0;
            // 
            // forca1
            // 
            this.forca1.Location = new System.Drawing.Point(12, 12);
            this.forca1.Name = "forca1";
            this.forca1.Size = new System.Drawing.Size(205, 300);
            this.forca1.TabIndex = 1;
            this.forca1.TabStop = false;
            this.forca1.Derrota += new System.EventHandler(this.forca1_Derrota);
            // 
            // palavraControl
            // 
            this.palavraControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palavraControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.palavraControl.Location = new System.Drawing.Point(12, 379);
            this.palavraControl.Name = "palavraControl";
            this.palavraControl.QtdLetras = 0;
            this.palavraControl.Size = new System.Drawing.Size(560, 39);
            this.palavraControl.TabIndex = 0;
            this.palavraControl.Text = "_  _  _  _  _";
            this.palavraControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.palavraControl.Vitoria += new System.EventHandler(this.palavraControl_Vitoria);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 440);
            this.Controls.Add(this.btnResetarBoneco);
            this.Controls.Add(this.btnCustomizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.graficoColunas1);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.lblDerrotas);
            this.Controls.Add(this.lblVitorias);
            this.Controls.Add(this.lblQtdLetras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRecomecar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLetrasIncorretas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forca1);
            this.Controls.Add(this.palavraControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forca";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.graficoColunas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forca1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.PalavraControl palavraControl;
        private Controles.Forca forca1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLetrasIncorretas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnRecomecar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQtdLetras;
        private System.Windows.Forms.Label lblVitorias;
        private System.Windows.Forms.Label lblDerrotas;
        private System.Windows.Forms.Label lblPartida;
        private Controles.GraficoColunas graficoColunas1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCustomizar;
        private System.Windows.Forms.Button btnResetarBoneco;
    }
}

