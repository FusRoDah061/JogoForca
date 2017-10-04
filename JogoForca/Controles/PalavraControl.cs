using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CsvHelper;
using System.IO;

namespace JogoForca.Controles
{
    class PalavraControl : Label
    {

        public event EventHandler Vitoria;
        
        /// <summary>
        /// Inidica se o jogador ganhou, ou seja, o jogo foi finalizado
        /// </summary>
        public bool Ganhou { get; private set; }

        /// <summary>
        /// Armazena a quantidade de letras da palavra atual
        /// </summary>
        public int QtdLetras { get; set; }

        /// <summary>
        /// Amrazena a categoria de palavra selecionada
        /// </summary>
        public string Categoria { get; private set; }

        /// <summary>
        /// Array com os caracteres atuais sendo exibidos na tela.
        /// Usado para controlar o que o jogador entra e comparar com a palavra sorteada.
        /// Sempre irá refletir o que o jogador está vendo na tela.
        /// </summary>
        private char[] _palavraAtual;

        /// <summary>
        /// Palavra sorteada que o jogador deve acertar
        /// </summary>
        private string _palavra;
        public string Palavra 
        {
            get{
                return _palavra;
            }

            private set{
                if (value != null)
                {
                    _palavra = value.ToUpperInvariant();
                    _geraPalavra();
                }
            }
        }

        public PalavraControl()
        {
            this.Font = new Font(this.Font.Name, 50);
        }

        /// <summary>
        /// Remove todos os espaços de uma string qualquer
        /// </summary>
        /// <param name="str">string que terá os espaços removidos</param>
        /// <returns>a string de entrada sem os espaços</returns>
        private string _removerEspacos(string str)
        {
            string novaStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    novaStr += str[i];
                }
            }

            return novaStr;
        }

        /// <summary>
        /// Sorteia uma palavra do banco de palavras (arquivo .csv)
        /// </summary>
        /// <returns>a palavra sorteada</returns>
        private string _sorteiaPalavra()
        {
            using (CsvReader csv = new CsvReader(new StringReader(JogoForca.Properties.Resources.palavras)))
            {
                Random rnd = new Random();

                //Obtém os cabeçalhos do CSV (que são as categorias de palavras)
                csv.ReadHeader();
                string[] categorias = csv.FieldHeaders;

                //Sorteia uma categoria dentre as lidas
                int categoriaSorteada = rnd.Next(0, categorias.Length);

                //Salva a categoria sorteada
                Categoria = categorias[categoriaSorteada];

                //Cria uma lista que armazenará as palavras da categoria sorteada
                List<string> palavrasCat = new List<string>();

                while(csv.Read()){
                    //Percorre todo o arquivo e armazena em palavrasCat as palavras pertencentes à categoria sorteada
                    string[] linha = csv.CurrentRecord;
                    palavrasCat.Add(linha[categoriaSorteada]);
                        
                }

                //Sorteia e retorna uma palavra dentre as obtidas da categoria sorteada
                int palavraSorteada = rnd.Next(0, palavrasCat.Count);
                return palavrasCat[palavraSorteada].Trim();

            }
        }

        /// <summary>
        /// Gera a represenatação na tela de uma palavra sorteada
        /// </summary>
        private void _geraPalavra()
        {
            //Sorteia a palavra
            _palavra = _removerEspacos(_sorteiaPalavra());

            QtdLetras = _palavra.Length;
            //Cria o array que armazenará os caracteres em exibição para o jogador
            _palavraAtual = new char[_palavra.Length];
            //Exibe na tela os underlines referentes à palavra sorteada
            this.Text = _geraPlaceholder();
            
        }

        /// <summary>
        /// Cria a string de underlines que será exibida para o jogador
        /// </summary>
        /// <returns></returns>
        private string _geraPlaceholder()
        {
            string placeholder = "";

            for (byte i = 0; i < _palavra.Length; i++)
            {
                placeholder += "_  ";

                //Adiciona o caracter no array de caracteres.
                _palavraAtual[i] = '_';
            }

            return placeholder.Trim();
        }

        /// <summary>
        /// Atualiza a palavra. Significa que o usuário entrou com alguma letra. 
        /// </summary>
        /// <param name="letra">letra entrada pelo jogador</param>
        private void _atualizaPalavra(char letra)
        {
            string texto = "";

            //Percorre toda a palavra sorteada para atualizar o array dos caracteres com a letra digitada
            for (byte i = 0; i < _palavra.Length; i++)
            {
                //Verifica se a letra atual é igual à letra entrada pelo jogador
                if (_palavra[i] == letra)
                {
                    //Substitui o underline pela letra
                    _palavraAtual[i] = letra;

                }
            }

            //Atualiza o texto que é mostrado ao usuário com base nos caracteres salvos e atualizados acima
            foreach (char l in _palavraAtual)
            {
                texto += l.ToString() + "  ";
            }
           
            this.Text = texto.Trim();
            
        }

        /// <summary>
        /// Atualiza a palavra. Significa que o usuário entrou com alguma letra. 
        /// </summary>
        /// <param name="entrada">letra entrada pelo jogador</param>
        public bool AtualizaPalavra(char entrada)
        {
            string entradaStr = entrada.ToString();
            //Verifica se a palavra contém a letra entrada
            bool contem = _palavra.Contains(entradaStr.ToUpperInvariant());

            if(contem){
                //Atualiza a plavra em meória e na tela caso positivo
                _atualizaPalavra(entrada);

                //Verifica se a palavra em exibição ainda contém letras ocultas (underline), para determinar se o jogador ganhou ou ainda não
                Ganhou = !this.Text.Contains("_");

                if (Ganhou)
                {
                    //Dispara o evento de vitória
                    OnVitoria();
                }
            }

            return contem;
        }

        /// <summary>
        /// Redefine a palavra para seu estado inicial
        /// </summary>
        public void Recomeca()
        {
            Ganhou = false;
            _palavraAtual = null;
            _geraPalavra();
        }

        public virtual void OnVitoria()
        {
            EventHandler handler = Vitoria;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

    }
}
