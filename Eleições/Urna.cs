using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Serialization;
namespace Eleições
{
    public partial class Urna : Form
    {
        public Urna()
        {
            InitializeComponent();
        }

        float num1;
        int cargo = 0;
        List<Candidatos> LCandidatos;


        private void Urna_Load(object sender, EventArgs e)
        {
            panel.Hide();
            LCandidatos = new List<Candidatos>();
            LCandidatos = LerListaCandidatos();

            if (cargo == 0)
            {
                lbl1.Text = "Vereador";
            }

        }

        #region Botões

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 1;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 2;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 3;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 4;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 5;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 6;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 7;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 8;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 9;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 5 && lbl1.Text == "Vereador" || textBox1.Text.Length < 2 && lbl1.Text == "Prefeito")
            {
                textBox1.Text += 0;
                TocaTeclas();
            }
            branco.Enabled = false;
        }

        private void corrige_Click(object sender, EventArgs e)
        {

            if (num1 == 0 && textBox1.TextLength > 0)
            { num1 = 0; textBox1.Clear(); }
            else if (num1 > 0 && textBox1.TextLength > 0)
            { textBox1.Clear(); }
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn0.Enabled = true;
            branco.Enabled = true;
            TocaTeclas();
            lblNome.Text = string.Empty;
            lblPartido.Text = string.Empty;
            foto.ImageLocation = "";

        }

        private void branco_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && textBox1.TextLength > 0)
            { num1 = 0; textBox1.Clear(); }
            else if (num1 > 0 && textBox1.TextLength > 0)
            { textBox1.Clear(); }

            textBox1.Text = "Branco";
            TocaTeclas();
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btn0.Enabled = false;

            lblNome.Text = "Branco";
            lblPartido.Text = "Branco";
            foto.ImageLocation = "";
        }

        private void confirma_Click(object sender, EventArgs e)
        {
            branco.Enabled = true;
            if (textBox1.Text == "Branco")
            {
                foto.ImageLocation = "";
                VotaBranco(lblNome.Text);
                SalvarLista();
                TrocarVotacao();
                lblNome.Text = string.Empty;
                lblPartido.Text = string.Empty;
                

            }

            else if (textBox1.Text == "Nulo")
            {
                foto.ImageLocation = "";
                VotaNulo(lblNome.Text);
                SalvarLista();
                TrocarVotacao();
                lblNome.Text = string.Empty;
                lblPartido.Text = string.Empty;
            }

            else if (textBox1.Text.Length == 5 && lbl1.Text == "Vereador" || textBox1.Text.Length == 2 && lbl1.Text == "Prefeito")
            {
                try
                {
                    Vota(int.Parse(textBox1.Text));

                    SalvarLista();
                    TrocarVotacao();

                    lblNome.Text = string.Empty;
                    lblPartido.Text = string.Empty;
                    foto.ImageLocation = "";
                }
                catch (Exception) { }
            }

        }

        #endregion

        #region Funçoes

        public void TocaFim()
        {
            SoundPlayer tocaFim = new SoundPlayer(Environment.CurrentDirectory + @"\audio\fim.wav");
            tocaFim.Play();

        }

        private void TocaTeclas()
        {
            //SystemSounds.Beep.Play();
            SoundPlayer tocaTeclas = new SoundPlayer(Environment.CurrentDirectory + @"\audio\teclando.wav");
            tocaTeclas.Play();
        }

        private void TocaMudanca()
        {

            SoundPlayer tocaMudanca = new SoundPlayer(Environment.CurrentDirectory + @"\audio\mudando.wav");
            tocaMudanca.Play();

        }

        private void SalvarLista()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Candidatos>));
                FileStream fs = new FileStream("Candidatos.xml", FileMode.Create);
                serializer.Serialize(fs, LCandidatos);
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ": " + ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public List<Candidatos> LerListaCandidatos()
        {
            List<Candidatos> candidatos = new List<Candidatos>();
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Candidatos>));
                FileStream fs = new FileStream("Candidatos.xml", FileMode.Open);
                candidatos = (List<Candidatos>)serializer.Deserialize(fs);
                fs.Close();
                return candidatos;
            }
            catch (Exception)
            {
                return candidatos;
            }
        }

        public void TrocarVotacao()
        {
            if (cargo == 0)
            {
                cargo = 1;
                TocaMudanca();
                lbl1.Text = "Prefeito";
                textBox1.Text = string.Empty;
                
            }
            else
            {
                Fim();
                cargo = 0;
                lbl1.Text = "Vereador";
                textBox1.Text = string.Empty;
            }

        }

        public void Vota(int numero)
        {
            Candidatos c = new Candidatos();
            c = LCandidatos.First(cand => cand.Numero.Equals(numero));
            c.Votos++;
            int i = LCandidatos.FindIndex(cand => cand.Numero.Equals(numero));
            LCandidatos[i] = c;
        }

        public void VotaBranco(string nome)
        {
            Candidatos c = new Candidatos();
            c = LCandidatos.First(cand => cand.Nome.Equals(nome));
            c.Votos++;
            int i = LCandidatos.FindIndex(cand => cand.Nome.Equals(nome));
            LCandidatos[i] = c;

        }

        public void VotaNulo(string nome)
        {
            Candidatos c = new Candidatos();
            c = LCandidatos.First(cand => cand.Nome.Equals(nome));
            c.Votos++;
            int i = LCandidatos.FindIndex(cand => cand.Nome.Equals(nome));
            LCandidatos[i] = c;
        }

        public void Fim()
        {
            TocaFim();
            panel.Show();
            Thread.Sleep(3000);
            panel.Hide();

        }

        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nome = "";
            string partido = "";
            int numero;

            if (textBox1.Text.Length == 5 && lbl1.Text == "Vereador" || textBox1.Text.Length == 2 && lbl1.Text == "Prefeito")
            {
                foreach (Candidatos c in LCandidatos)
                {
                    if (textBox1.Text == c.Numero.ToString())
                    {
                        nome = c.Nome;
                        partido = c.Partido;
                        numero = c.Numero;
                        foto.ImageLocation = Environment.CurrentDirectory + @"\img" + @"\"+ numero +".gif";
                    }
                }

                if (string.IsNullOrEmpty(nome))
                {
                    nome = "Nulo";
                    partido = "Nulo";
                    textBox1.Text = "Nulo";

                }

                lblNome.Text = nome;
                lblPartido.Text = partido;


            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Relacao form = new Relacao(LCandidatos);
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
        }

        private void Urna_FormClosed(object sender, FormClosedEventArgs e)
        {
            SalvarLista();
        }

    }
}