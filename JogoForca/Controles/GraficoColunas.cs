using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoForca.Controles
{
    class GraficoColunas : PictureBox
    {

        public List<GraficoSet> Dados = new List<GraficoSet>();

        public int Total { get; set; }

        private int _limiteRotulosBarras;

        public void AddSet(string rotulo, int valor, Color cor)
        {
            Dados.Add(new GraficoSet(rotulo, valor, cor));
        }

        public bool AtualizaSet(string rotuloAlvo, int novoValor, Color novaCor)
        {
            bool atualizou = false;

            for (int i = 0; i < Dados.Count; i++)
            {
                if (Dados[i].Rotulo.Equals(rotuloAlvo))
                {
                    Dados[i].Valor = novoValor;
                    Dados[i].Cor = novaCor;

                    atualizou = true;
                }
            }

            this.Invalidate();

            return atualizou;
        }

        public void IniciaPlot()
        {
            this.Paint += _plotaGrafico;
        }

        /// <summary>
        /// Desenha o gráfico na tela. Disparado sempre no OnPaint do componente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _plotaGrafico(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            _desenhaRotulos(e.Graphics);
            _desenhaBarras(e.Graphics);
        }

        /// <summary>
        /// Desenha as barras do gráfico
        /// </summary>
        /// <param name="gp">Objeto de gráficos do elemento que receberá o gráfico</param>
        private void _desenhaBarras(Graphics gp)
        {
            //Obtém a altura das linhas que serão desenhadas
            int altLinha = this.Height / Dados.Count;

            //Calcula 10% de margem vertical para a barra
            int margemBarra = (int)Math.Round(this.Height * 0.1);

            //Calcula a altura da barra descontando a margem
            int alturaBarra = altLinha - margemBarra;

            //Calcula o incremento do gráfico. Quant uma barra anda para cada unidade do seu valor.
            //Será multiplicado pela porcentagem da barra ao criá-la.
            int step = (int)Math.Round((double) (this.Width - _limiteRotulosBarras) / 100);

            for (int i = 0; i < Dados.Count; i++)
            {
                GraficoSet set = Dados[i];
                int linhaAtual = i;

                //Cria a barra
                Rectangle barra = new Rectangle(new Point(_limiteRotulosBarras, (int) Math.Round((double) altLinha * linhaAtual + (margemBarra / 2))), new Size(_calculaLarguraBarra(set.Valor) * step , alturaBarra));
                //Desenha a barra
                gp.FillRectangle(new SolidBrush(set.Cor), barra);
            }

        }

        /// <summary>
        /// Obtém a porcentagem que a barra representa em relação ao valor total
        /// </summary>
        /// <param name="barraValor">Valor da barra/rotulo</param>
        /// <returns>porcentagem da barra</returns>
        private int _calculaLarguraBarra(double barraValor)
        {
            return (int)Math.Round( (barraValor * 100) / Total);
        }

        /// <summary>
        /// Desenha os rótulos das barras do gráfico
        /// </summary>
        /// <param name="gp">Objeto de gráficos do elemento que receberá o gráfico</param>
        private void _desenhaRotulos(Graphics gp)
        {
            //Obtém a altura das linhas que serão desenhadas
            int altLinha = this.Height / Dados.Count;

            //Armazena a largura da maior string dos rotulos, para depois desenhar uma linha dividindo os rotulos e as barras do gráfico
            int textoMaiorLargura = 0;

            //Margem do texto. Para margem horizontal/vertical, multiplicar por 2
            int textoMargem = 5;

            for (int i = 0; i < Dados.Count; i++)
            {
                GraficoSet set = Dados[i];
                int linhaAtual = i;
                
                Font f = new Font("Arial", 8);
                SizeF tamTexo = gp.MeasureString(set.Rotulo, f);

                if(tamTexo.Width > textoMaiorLargura)
                {
                    //Salva a maior largura do texto encontrada
                    textoMaiorLargura = (int)Math.Round(tamTexo.Width);
                }

                gp.DrawString(set.Rotulo, f, new SolidBrush(Color.Black), new Point(textoMargem, (int) Math.Round( (altLinha * linhaAtual) + ( (altLinha / 2) - (tamTexo.Height / 2) ) ) ) );

                if (linhaAtual > 0)
                {
                    gp.DrawLine(new Pen(Color.Gray), new Point(0, altLinha * linhaAtual), new Point(this.Width, altLinha * linhaAtual));
                }

            }

            _limiteRotulosBarras = textoMaiorLargura + textoMargem * 2;
            //Desenha uma linha dividindo as linhas do gráfico
            gp.DrawLine(new Pen(Color.Gray), new Point(_limiteRotulosBarras, 0), new Point(_limiteRotulosBarras, this.Height));
        }

    }

    /// <summary>
    /// Representa um conjunto de valores do gráfico, com o rótulo da barra, o valor da barra e sua cor.
    /// </summary>
    public class GraficoSet
    {
        /// <summary>
        /// Rótulo do conjunto
        /// </summary>
        public string Rotulo { get; set; }

        /// <summary>
        /// Valor do conjunto
        /// </summary>
        public double Valor { get; set; }

        /// <summary>
        /// Cor do conjunto (cor da barra que será mostrada no gráfico)
        /// </summary>
        public Color Cor { get; set; }

        public GraficoSet(string rotulo, int valor, Color cor)
        {
            Rotulo = rotulo;
            Valor = valor;
            Cor = cor;
        }
    }

}
