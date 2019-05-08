using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Eleições
{
    public partial class Relacao : Form
    {
        public List<Candidatos> LCandidatos { get; set; }


        public Relacao()
        {
            InitializeComponent();
            
        }

        public Relacao(List<Candidatos> Lista)
        {
            InitializeComponent();
            LCandidatos = Lista;
            
        }

        private void Relacao_Load(object sender, EventArgs e)
        {
            CarregarValoresGrid();
        }

        private void CarregarValoresGrid()
        {
            Grid.Rows.Clear();
            foreach (Candidatos c in LCandidatos)
            {
                Grid.Rows.Add(c.Nome, c.Numero, c.Partido, c.Cargo, c.Votos);

            }
        }

        private void Zerar_Click(object sender, EventArgs e)
        {
            foreach (Candidatos c in LCandidatos)
            {
                c.Votos = 0;
            }
            CarregarValoresGrid();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add form = new Add(LCandidatos);
            this.Visible = false;
            form.ShowDialog();
            this.Visible = true;
            CarregarValoresGrid();
        }

    }
}
