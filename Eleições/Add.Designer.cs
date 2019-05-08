namespace Eleições
{
    partial class Add
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioPrefeito = new System.Windows.Forms.RadioButton();
            this.radioVereador = new System.Windows.Forms.RadioButton();
            this.ttbNumero = new System.Windows.Forms.TextBox();
            this.ttbPartido = new System.Windows.Forms.TextBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Partido";
            // 
            // radioPrefeito
            // 
            this.radioPrefeito.AutoSize = true;
            this.radioPrefeito.Location = new System.Drawing.Point(17, 12);
            this.radioPrefeito.Name = "radioPrefeito";
            this.radioPrefeito.Size = new System.Drawing.Size(61, 17);
            this.radioPrefeito.TabIndex = 0;
            this.radioPrefeito.TabStop = true;
            this.radioPrefeito.Text = "Prefeito\r\n";
            this.radioPrefeito.UseVisualStyleBackColor = true;
            this.radioPrefeito.CheckedChanged += new System.EventHandler(this.radioPrefeito_CheckedChanged);
            // 
            // radioVereador
            // 
            this.radioVereador.AutoSize = true;
            this.radioVereador.Location = new System.Drawing.Point(95, 12);
            this.radioVereador.Name = "radioVereador";
            this.radioVereador.Size = new System.Drawing.Size(68, 17);
            this.radioVereador.TabIndex = 0;
            this.radioVereador.TabStop = true;
            this.radioVereador.Text = "Vereador";
            this.radioVereador.UseVisualStyleBackColor = true;
            this.radioVereador.CheckedChanged += new System.EventHandler(this.radioVereador_CheckedChanged);
            // 
            // ttbNumero
            // 
            this.ttbNumero.Location = new System.Drawing.Point(53, 68);
            this.ttbNumero.Name = "ttbNumero";
            this.ttbNumero.Size = new System.Drawing.Size(100, 20);
            this.ttbNumero.TabIndex = 2;
            this.ttbNumero.Click += new System.EventHandler(this.ttbNumero_Click);
            this.ttbNumero.Leave += new System.EventHandler(this.ttbNumero_Leave);
            // 
            // ttbPartido
            // 
            this.ttbPartido.Location = new System.Drawing.Point(53, 94);
            this.ttbPartido.Name = "ttbPartido";
            this.ttbPartido.Size = new System.Drawing.Size(100, 20);
            this.ttbPartido.TabIndex = 3;
            this.ttbPartido.Click += new System.EventHandler(this.ttbPartido_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(14, 137);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(26, 13);
            this.lblErro.TabIndex = 5;
            this.lblErro.Text = "Erro";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(197, 127);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(53, 42);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(100, 20);
            this.ttbNome.TabIndex = 1;
            this.ttbNome.Click += new System.EventHandler(this.ttbNome_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.ttbPartido);
            this.Controls.Add(this.ttbNome);
            this.Controls.Add(this.ttbNumero);
            this.Controls.Add(this.radioVereador);
            this.Controls.Add(this.radioPrefeito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioPrefeito;
        private System.Windows.Forms.RadioButton radioVereador;
        private System.Windows.Forms.TextBox ttbNumero;
        private System.Windows.Forms.TextBox ttbPartido;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox ttbNome;
    }
}