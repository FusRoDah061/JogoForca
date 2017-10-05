using JogoForca.Classes;
using JogoForca.Controles;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoForca
{
    public partial class FrmCustomizarBoneco : Form
    {
        private ParteBoneco _cabeca;
        private ParteBoneco _torso;
        private ParteBoneco _bracoEsq;
        private ParteBoneco _bracoDir;
        private ParteBoneco _pernaDir;
        private ParteBoneco _pernaEsq;

        public List<Bitmap> Partes
        {
            get
            {
                return new List<Bitmap>(){
                    _cabeca.Desenhado,
                    _torso.Desenhado,
                    _bracoEsq.Desenhado,
                    _bracoDir.Desenhado,
                    _pernaDir.Desenhado,
                    _pernaDir.Desenhado
                };
            }
        }

        public FrmCustomizarBoneco()
        {
            InitializeComponent();
            
            _cabeca = new ParteBoneco(Boneco.ParteCorpo.CABECA);
            _cabeca.Location = new Point(5, 5);
            _cabeca.Size = new Size(tabCabeca.Width, tabCabeca.Height);
            _cabeca.CreateControl();

            _torso = new ParteBoneco(Boneco.ParteCorpo.CORPO);
            _torso.Location = new Point(5, 5);
            _torso.Size = new Size(tabTorso.Width, tabTorso.Height);
            _torso.CreateControl();
            
            _bracoEsq = new ParteBoneco(Boneco.ParteCorpo.BRACO_ESQ);
            _bracoEsq.Location = new Point(5, 5);
            _bracoEsq.Size = new Size(tabBracoEsquerdo.Width, tabBracoEsquerdo.Height);
            _bracoEsq.CreateControl();
            
            _bracoDir = new ParteBoneco(Boneco.ParteCorpo.BRACO_DIR);
            _bracoDir.Location = new Point(5, 5);
            _bracoDir.Size = new Size(tabBracoDireito.Width, tabBracoDireito.Height);
            _bracoDir.CreateControl();
            
            _pernaDir = new ParteBoneco(Boneco.ParteCorpo.PERNA_DIR);
            _pernaDir.Location = new Point(5, 5);
            _pernaDir.Size = new Size(tabPernaDireita.Width, tabPernaDireita.Height);
            _pernaDir.CreateControl();

            _pernaEsq = new ParteBoneco(Boneco.ParteCorpo.PERNA_ESQ);
            _pernaEsq.Location = new Point(5, 5);
            _pernaEsq.Size = new Size(tabPernaEsquerda.Width, tabPernaEsquerda.Height);
            _pernaEsq.CreateControl();
            

            tabCabeca.Controls.Add(_cabeca);
            _cabeca.Invalidate();

            tabTorso.Controls.Add(_torso);
            _torso.Invalidate();

            tabBracoEsquerdo.Controls.Add(_bracoEsq);
            _bracoEsq.Invalidate();

            tabBracoDireito.Controls.Add(_bracoDir);
            _bracoDir.Invalidate();

            tabPernaDireita.Controls.Add(_pernaDir);
            _pernaDir.Invalidate();

            tabPernaEsquerda.Controls.Add(_pernaEsq);
            _pernaEsq.Invalidate();

            panelCorSelecionada.BackColor = Color.Black;
            _atualizaCor();
        }

        private void btnPickCor_Click(object sender, System.EventArgs e)
        {
            colorDialog1.ShowDialog();
            panelCorSelecionada.BackColor = colorDialog1.Color;

            _atualizaCor();
        }

        private void _atualizaCor()
        {
            _cabeca.Cor = panelCorSelecionada.BackColor;
            _torso.Cor = panelCorSelecionada.BackColor;
            _pernaDir.Cor = panelCorSelecionada.BackColor;
            _pernaEsq.Cor = panelCorSelecionada.BackColor;
            _bracoDir.Cor = panelCorSelecionada.BackColor;
            _bracoEsq.Cor = panelCorSelecionada.BackColor;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        
    }
}
