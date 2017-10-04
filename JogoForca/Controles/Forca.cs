using JogoForca.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoForca.Controles
{
    class Forca : PictureBox
    {
        /// <summary>
        /// Evento disparado quando o boneco está completo, indicando a derrota do jogador
        /// </summary>
        public event EventHandler Derrota;

        public enum Finalizacao { NENHUM, VITORIA, DERROTA }

        /// <summary>
        /// Boneco que será desenhado na forca
        /// </summary>
        private Boneco _enforcado;

        /// <summary>
        /// Parte do corpo/estágio atual do boneco
        /// </summary>
        private Boneco.ParteCorpo _parteCorpo = Boneco.ParteCorpo.NENHUM;

        /// <summary>
        /// Indica se o jogador perdeu, ou seja, o jogo foi finalizado
        /// </summary>
        public bool Perdeu { get; private set; }

        public Forca()
        {
            this.Size = new Size(205, 300);
            //Adiciona um listener para o evento OnPaint
            this.Paint += _pintaGraficos;
            _enforcado = new Boneco();
            Perdeu = false;
        }

        /// <summary>
        /// Escreve o texto de finalização da tela (vitória ou derrota)
        /// </summary>
        /// <param name="fim">Indica qual texto desenhar</param>
        public void EscreveFinalizacao(Finalizacao fim)
        {
            string texto = "";
            Color cor = Color.Transparent;

            switch (fim)
            {
                case Finalizacao.VITORIA:
                    texto = "VITORIA!";
                    cor = Color.Green;
                    break;

                case Finalizacao.DERROTA:
                    texto = "DERROTA!";
                    cor = Color.Red;
                    break;
            }

            Graphics g = this.CreateGraphics();
            //Centraliza o ponto âncora gráfico (canto superior esquerdo)
            g.TranslateTransform(this.Width / 2, this.Height / 2);
            //Gira o gráfico 60 graus no sentido anti-horário
            g.RotateTransform(-60);

            //Define o modo de suavização do gráfico. AntiAlias torna as curvas mais suaves
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //Cria e desenha o texto

            Font f = new Font("Arial", 30);
            SizeF tamTexo = g.MeasureString(texto, f);

            g.DrawString(texto, f, new SolidBrush(cor), -(tamTexo.Width / 2), -(tamTexo.Height / 2));

            //Remove o listener do OnPaint para não apagar o texto desenhado agora
            this.Paint -= _pintaGraficos;
        }

        /// <summary>
        /// Pinta o estado atual do boneco e a forca. Chamado sempre no OnPaint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _pintaGraficos(object sender, PaintEventArgs e)
        {
            //Define o modo de suavização do gráfico. AntiAlias torna as curvas mais suaves
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            _desenhaForca(e.Graphics);
            _desenhaBoneco(e.Graphics);
        }

        /// <summary>
        /// Desenha a forca
        /// </summary>
        /// <param name="gp">Objeto de gráficos do elemento que receberá a forca</param>
        private void _desenhaForca(Graphics gp)
        {
            Pen lapisMadeira = new Pen(Color.Brown, 3);
            Pen lapisCorda = new Pen(Color.DarkKhaki, 2);
            SolidBrush pincelGrama = new SolidBrush(Color.LimeGreen);

            //Grama
            gp.FillRectangle(pincelGrama, new Rectangle(new Point(0, this.Height - 16), new Size(250, 16)));
            //Base da forca
            gp.DrawLine(lapisMadeira, new Point(5, this.Height - 15), new Point(70, this.Height - 15));
            //Braços da base da forca
            gp.DrawLine(lapisMadeira, new Point(5, this.Height - 15), new Point(30, this.Height - 60));
            gp.DrawLine(lapisMadeira, new Point(70, this.Height - 15), new Point(30, this.Height - 70));
            //Pilar da forca
            gp.DrawLine(lapisMadeira, new Point(30, this.Height - 15), new Point(30, 30));
            //Topo da forca
            gp.DrawLine(lapisMadeira, new Point(30, 30), new Point(120, 30));
            //Corda
            gp.DrawLine(lapisCorda, new Point(120, 30), new Point(120, 71));
            
        }

        /// <summary>
        /// Redefine a forca para o seu estado inicial
        /// </summary>
        public void Recomeca()
        {
            Perdeu = false;
            _parteCorpo = Boneco.ParteCorpo.NENHUM;
            this.Paint += _pintaGraficos;
            this.Invalidate();
        }

        /// <summary>
        /// Altera o estado atual do boneco
        /// </summary>
        /// <param name="parteCorpo">Parte do corpo em que o jogador se encontra</param>
        public void AtualizaBoneco(Boneco.ParteCorpo parteCorpo)
        {
            Perdeu = (parteCorpo == Boneco.ParteCorpo.PERNA_ESQ);

            _parteCorpo = parteCorpo;
            this.Invalidate();

            if (Perdeu)
            {
                OnDerrota();
            }
        }

        /// <summary>
        /// Desenha o boneco na forca. Use AtualizaBoneco(...) para alterar o estágio atual do jogo
        /// </summary>
        /// <param name="gp"></param>
        private void _desenhaBoneco(Graphics gp)
        {
            if(_enforcado != null)
            {
                _enforcado.DesenhaBoneco(gp, _parteCorpo);
            }
        }

        /// <summary>
        /// Dispara quando o boneco é completo, ou seja, o jogador perde
        /// </summary>
        public virtual void OnDerrota()
        {
            EventHandler handler = Derrota;

            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

    }
}
