using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eleições
{
    public partial class Add : Form
    {
        public List<Candidatos> LCandidatos { get; set; }

        public Add()
        {
            InitializeComponent();
        }

        public Add(List<Candidatos> Lista)
        {
            InitializeComponent();
            LCandidatos = Lista;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            lblErro.Text = string.Empty;

        }

        private void radioPrefeito_CheckedChanged(object sender, EventArgs e)
        {


            ttbNumero.MaxLength = 2;


        }

        private void radioVereador_CheckedChanged(object sender, EventArgs e)
        {

            ttbNumero.Text = string.Empty;
            ttbNumero.MaxLength = 5;

        }

        private bool Validar()
        {
            bool retorno = true;

            if (!VerificaNumero())
                return false;

            if (string.IsNullOrEmpty(ttbNome.Text) ||
                string.IsNullOrEmpty(ttbNumero.Text) ||
                string.IsNullOrEmpty(ttbPartido.Text) ||
                !radioPrefeito.Checked && !radioVereador.Checked)
            { retorno = false; }

            if (!retorno)
                lblErro.Visible = true;
            else
                lblErro.Visible = false;

            return retorno;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (Validar())
            {
                Candidatos c = new Candidatos();
                if (radioVereador.Checked)
                {
                    c.Cargo = "Vereador";
                    c.Nome = ttbNome.Text;
                    c.Numero = int.Parse(ttbNumero.Text);
                    c.Partido = ttbPartido.Text.ToUpper();
                }

                else if (radioPrefeito.Checked)
                {
                    c.Cargo = "Prefeito";
                    c.Nome = ttbNome.Text;
                    c.Numero = int.Parse(ttbNumero.Text);
                    c.Partido = ttbPartido.Text.ToUpper();
                }
                               
                LCandidatos.Add(c);

                this.Close();

            }
        }

        private void ttbNome_Click(object sender, EventArgs e)
        {
            lblErro.Text = string.Empty;
        }

        public bool VerificaNumero()
        {

            foreach (Candidatos c in LCandidatos)
            {
                if (ttbNumero.Text == c.Numero.ToString())
                    return false;
            }

            return true;

        }

        private void ttbNumero_Leave(object sender, EventArgs e)
        {

            if (ttbNumero.Text.Length < 5 && radioVereador.Checked || ttbNumero.Text.Length < 2 && radioPrefeito.Checked)
            {
                ttbNumero.Text = string.Empty;
                lblErro.Text = "ERRO";
            }
            else
                lblErro.Text = string.Empty;
           
        }

        private void ttbNumero_Click(object sender, EventArgs e)
        {
            lblErro.Text = string.Empty;
        }

        private void ttbPartido_Click(object sender, EventArgs e)
        {
            lblErro.Text = string.Empty;
        }

    }
}
