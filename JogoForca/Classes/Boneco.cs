using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JogoForca.Classes
{
    public class Boneco
    {
        /// <summary>
        /// Partes do corpo do boneco. ao alcançar a PERNA_ESQ, o jogo acaba
        /// </summary>
        public enum ParteCorpo { CABECA, CORPO, BRACO_DIR, BRACO_ESQ, PERNA_DIR, PERNA_ESQ, NENHUM }
        public enum Braco { ESQUERDO, DIREITO }
        public enum Perna { ESQUERDA, DIREITA }

        /// <summary>
        /// Desenha o boneco na tela
        /// </summary>
        /// <param name="gp">Objeto dos gráficos do elemento que receberá o boneco</param>
        /// <param name="parteCorpo">Parte do corpo atual. Entenda parte do corpo como o estágio atual do boneco</param>
        public void DesenhaBoneco(Graphics gp, ParteCorpo parteCorpo)
        {

            switch(parteCorpo){

                case ParteCorpo.CABECA:
                    _desenhaCabeca(gp);
                    break;

                case ParteCorpo.CORPO:
                    _desenhaCabeca(gp);
                    _desenhaCorpo(gp);
                    break;

                case ParteCorpo.BRACO_DIR:
                    _desenhaCabeca(gp);
                    _desenhaCorpo(gp);
                    _desenhaBraco(gp, Braco.DIREITO);
                    break;

                case ParteCorpo.BRACO_ESQ:
                    _desenhaCabeca(gp);
                    _desenhaCorpo(gp);
                    _desenhaBraco(gp, Braco.DIREITO);
                    _desenhaBraco(gp, Braco.ESQUERDO);
                    break;

                case ParteCorpo.PERNA_DIR:
                    _desenhaCabeca(gp);
                    _desenhaCorpo(gp);
                    _desenhaBraco(gp, Braco.DIREITO);
                    _desenhaBraco(gp, Braco.ESQUERDO);
                    _desenhaPerna(gp, Perna.DIREITA);
                    break;

                case ParteCorpo.PERNA_ESQ:
                    _desenhaCabeca(gp);
                    _desenhaCorpo(gp);
                    _desenhaBraco(gp, Braco.DIREITO);
                    _desenhaBraco(gp, Braco.ESQUERDO);
                    _desenhaPerna(gp, Perna.DIREITA);
                    _desenhaPerna(gp, Perna.ESQUERDA);
                    break;

            }
        }

        private Bitmap _carregaImagem(string arquivo, Size tamanho)
        {
            Bitmap img = new Bitmap(arquivo);
            Bitmap imgRedimensionada = new Bitmap(img, tamanho);

            //Clona a imagem para liberar o arquivo
            Bitmap retorno = (Bitmap) imgRedimensionada.Clone();

            img.Dispose();
            imgRedimensionada.Dispose();

            img = null;
            imgRedimensionada = null;

            return retorno;
        }

        /// <summary>
        /// Desenha a cabeça do boneco
        /// </summary>
        /// <param name="gp">Objeto dos gráficos do elemento que receberá o boneco</param>
        private void _desenhaCabeca(Graphics gp)
        {
            Rectangle cabeca = new Rectangle(new Point(105, 70), new Size(30, 30));

            if (File.Exists("CABECA.png"))
            {
                Bitmap img = _carregaImagem("CABECA.png", new Size(30, 30));
                gp.DrawImage(img, new Point(105, 70));
            }
            else
            {
                gp.FillEllipse(new SolidBrush(Color.NavajoWhite), cabeca);
            }
            
        }

        /// <summary>
        /// Desenha o corpo/torso do boneco
        /// </summary>
        /// <param name="gp">Objeto dos gráficos do elemento que receberá o boneco</param>
        private void _desenhaCorpo(Graphics gp)
        {
            if (File.Exists("CORPO.png"))
            {
                Bitmap img = _carregaImagem("CORPO.png", new Size(21, 70));
                gp.DrawImage(img, new Point(110, 100));
            }
            else
            {
                gp.DrawLine(new Pen(Color.NavajoWhite, 2), new Point(120, 100), new Point(120, 170));
            }
            
        }

        /// <summary>
        /// Desenha um braço do boneco
        /// </summary>
        /// <param name="gp">Objeto dos gráficos do elemento que receberá o boneco</param>
        /// <param name="braco">Qual braço desenhar</param>
        private void _desenhaBraco(Graphics gp, Braco braco)
        {
            switch (braco)
            {
                case Braco.ESQUERDO:
                    if (File.Exists("BRACO_ESQ.png"))
                    {
                        Bitmap img = _carregaImagem("BRACO_ESQ.png", new Size(15, 50));
                        gp.DrawImage(img, new Point(100, 110));
                    }
                    else
                    {
                        gp.DrawLine(new Pen(Color.NavajoWhite, 2), new Point(105, 160), new Point(120, 110));
                    }
                    break;

                case Braco.DIREITO:
                    if (File.Exists("BRACO_DIR.png"))
                    {
                        Bitmap img = _carregaImagem("BRACO_DIR.png", new Size(15, 50));
                        gp.DrawImage(img, new Point(125, 110));
                    }
                    else
                    {
                        gp.DrawLine(new Pen(Color.NavajoWhite, 2), new Point(135, 160), new Point(120, 110));
                    }
                    break;
            }
            
        }

        /// <summary>
        /// Desenha uma perna do boneco
        /// </summary>
        /// <param name="gp">Objeto dos gráficos do elemento que receberá o boneco</param>
        /// <param name="perna">Qual perna desenhar</param>
        private void _desenhaPerna(Graphics gp, Perna perna)
        {
            switch (perna)
            {
                case Perna.ESQUERDA:
                    if (File.Exists("PERNA_ESQ.png"))
                    {
                        Bitmap img = _carregaImagem("PERNA_ESQ.png", new Size(21, 70));
                        gp.DrawImage(img, new Point(100, 170));
                    }
                    else
                    {
                        gp.DrawLine(new Pen(Color.NavajoWhite, 2), new Point(105, 240), new Point(120, 170));
                    }
                    
                    break;

                case Perna.DIREITA:
                    if (File.Exists("PERNA_DIR.png"))
                    {
                        Bitmap img = _carregaImagem("PERNA_DIR.png", new Size(21, 70));
                        gp.DrawImage(img, new Point(125, 170));
                    }
                    else
                    {
                        gp.DrawLine(new Pen(Color.NavajoWhite, 2), new Point(135, 240), new Point(120, 170));
                    }
                    
                    break;
            }
        }

    }
}
