using JogoForca.Classes;
using JogoForca.Controles;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class FrmCustomizarBoneco : Form
    {
        /// <summary>
        /// Partes do corpo do boneco
        /// </summary>
        private ParteBoneco[] _partes = new ParteBoneco[6];

        public List<Bitmap> Partes
        {
            get
            {
                return new List<Bitmap>(){
                    _partes[(int) Boneco.ParteCorpo.CABECA].Desenhado,
                    _partes[(int) Boneco.ParteCorpo.CORPO].Desenhado,
                    _partes[(int) Boneco.ParteCorpo.BRACO_ESQ].Desenhado,
                    _partes[(int) Boneco.ParteCorpo.BRACO_DIR].Desenhado,
                    _partes[(int) Boneco.ParteCorpo.PERNA_DIR].Desenhado,
                    _partes[(int) Boneco.ParteCorpo.PERNA_ESQ].Desenhado
                };
            }
        }

        public FrmCustomizarBoneco()
        {
            InitializeComponent();
            
            //Inicializa todas as partes do corpo
            _partes[(int) Boneco.ParteCorpo.CABECA] = new ParteBoneco(Boneco.ParteCorpo.CABECA);
            _partes[(int) Boneco.ParteCorpo.CABECA].Location = new Point(5, 5);
            _partes[(int) Boneco.ParteCorpo.CABECA].Size = new Size(tabCabeca.Width, tabCabeca.Height);
            _partes[(int) Boneco.ParteCorpo.CABECA].CreateControl();

            _partes[(int)Boneco.ParteCorpo.CORPO] = new ParteBoneco(Boneco.ParteCorpo.CORPO);
            _partes[(int)Boneco.ParteCorpo.CORPO].Location = new Point(5, 5);
            _partes[(int)Boneco.ParteCorpo.CORPO].Size = new Size(tabTorso.Width, tabTorso.Height);
            _partes[(int)Boneco.ParteCorpo.CORPO].CreateControl();

            _partes[(int)Boneco.ParteCorpo.BRACO_ESQ] = new ParteBoneco(Boneco.ParteCorpo.BRACO_ESQ);
            _partes[(int)Boneco.ParteCorpo.BRACO_ESQ].Location = new Point(5, 5);
            _partes[(int)Boneco.ParteCorpo.BRACO_ESQ].Size = new Size(tabBracoEsquerdo.Width, tabBracoEsquerdo.Height);
            _partes[(int)Boneco.ParteCorpo.BRACO_ESQ].CreateControl();

            _partes[(int)Boneco.ParteCorpo.BRACO_DIR] = new ParteBoneco(Boneco.ParteCorpo.BRACO_DIR);
            _partes[(int)Boneco.ParteCorpo.BRACO_DIR].Location = new Point(5, 5);
            _partes[(int)Boneco.ParteCorpo.BRACO_DIR].Size = new Size(tabBracoDireito.Width, tabBracoDireito.Height);
            _partes[(int)Boneco.ParteCorpo.BRACO_DIR].CreateControl();

            _partes[(int)Boneco.ParteCorpo.PERNA_DIR] = new ParteBoneco(Boneco.ParteCorpo.PERNA_DIR);
            _partes[(int)Boneco.ParteCorpo.PERNA_DIR].Location = new Point(5, 5);
            _partes[(int)Boneco.ParteCorpo.PERNA_DIR].Size = new Size(tabPernaDireita.Width, tabPernaDireita.Height);
            _partes[(int)Boneco.ParteCorpo.PERNA_DIR].CreateControl();

            _partes[(int)Boneco.ParteCorpo.PERNA_ESQ] = new ParteBoneco(Boneco.ParteCorpo.PERNA_ESQ);
            _partes[(int)Boneco.ParteCorpo.PERNA_ESQ].Location = new Point(5, 5);
            _partes[(int)Boneco.ParteCorpo.PERNA_ESQ].Size = new Size(tabPernaEsquerda.Width, tabPernaEsquerda.Height);
            _partes[(int)Boneco.ParteCorpo.PERNA_ESQ].CreateControl();

            //Adiciona as partes ás respectivas guias do tabcontrol
            tabCabeca.Controls.Add(_partes[(int)Boneco.ParteCorpo.CABECA]);
            _partes[(int)Boneco.ParteCorpo.CABECA].Invalidate();

            tabTorso.Controls.Add(_partes[(int)Boneco.ParteCorpo.CORPO]);
            _partes[(int)Boneco.ParteCorpo.CORPO].Invalidate();

            tabBracoEsquerdo.Controls.Add(_partes[(int)Boneco.ParteCorpo.BRACO_ESQ]);
            _partes[(int)Boneco.ParteCorpo.BRACO_ESQ].Invalidate();

            tabBracoDireito.Controls.Add(_partes[(int)Boneco.ParteCorpo.BRACO_DIR]);
            _partes[(int)Boneco.ParteCorpo.BRACO_DIR].Invalidate();

            tabPernaDireita.Controls.Add(_partes[(int)Boneco.ParteCorpo.PERNA_DIR]);
            _partes[(int)Boneco.ParteCorpo.PERNA_DIR].Invalidate();

            tabPernaEsquerda.Controls.Add(_partes[(int)Boneco.ParteCorpo.PERNA_ESQ]);
            _partes[(int)Boneco.ParteCorpo.PERNA_ESQ].Invalidate();
            
            panelCorSelecionada.BackColor = Color.Black;

            _atualizaCor();

            _atualizaTamanhoPincel();
        }

        private void btnPickCor_Click(object sender, System.EventArgs e)
        {
            //Exibe a caixa de seleção de cor
            colorDialog1.ShowDialog();
            //salva a cor em um panel para usá-la depois
            panelCorSelecionada.BackColor = colorDialog1.Color;

            _atualizaCor();
        }

        /// <summary>
        /// Atualiza a cor do pincel em todas as partes do corpo que foram criadas
        /// </summary>
        private void _atualizaCor()
        {
            ParteBoneco.Cor = panelCorSelecionada.BackColor;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Salva todas as partes do corpo para o disco. Essa imagens serão carregadas na hora de desenhar o boneco
        /// </summary>
        private void _salvarPartesCorpo()
        {
            for (byte i = 0; i < _partes.Length; i++)
            {                
                _partes[i].SalvaImagem(_obtemNomeArquivo(i) + ".png");
            }
        }

        /// <summary>
        /// Obtém o nome do arquivo de acordo com a parte do corpo
        /// </summary>
        /// <param name="i">Parte do corpo(Boneco.ParteCorpo)</param>
        /// <returns>string com o nome do arquivo</returns>
        private string _obtemNomeArquivo(byte i)
        {
            switch (i)
            {
                case (int)Boneco.ParteCorpo.CABECA:
                    return "CABECA";

                case (int)Boneco.ParteCorpo.CORPO:
                    return "CORPO";

                case (int)Boneco.ParteCorpo.BRACO_DIR:
                    return "BRACO_DIR";

                case (int)Boneco.ParteCorpo.BRACO_ESQ:
                    return "BRACO_ESQ";

                case (int)Boneco.ParteCorpo.PERNA_DIR:
                    return "PERNA_DIR";

                case (int)Boneco.ParteCorpo.PERNA_ESQ:
                    return "PERNA_ESQ";
            }

            return null;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            _salvarPartesCorpo();
        }

        private void trackTamPincel_Scroll(object sender, System.EventArgs e)
        {
            _atualizaTamanhoPincel();
        }

        /// <summary>
        /// Atualiza o tamanho do pincel do usuário em todas as partes do corpo
        /// </summary>
        private void _atualizaTamanhoPincel()
        {
            ParteBoneco.TamanhoPincel = trackTamPincel.Value;
        }

        
    }
}
