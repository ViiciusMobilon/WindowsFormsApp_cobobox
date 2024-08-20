namespace WindowsFormsApp_cobobox
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtinserir = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.Label();
            this.bntinserir = new System.Windows.Forms.Button();
            this.bntOrdenarcombo = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bntlimpar = new System.Windows.Forms.Button();
            this.lblquantidade = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.bntexibir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtinserir
            // 
            this.txtinserir.Location = new System.Drawing.Point(75, 59);
            this.txtinserir.Name = "txtinserir";
            this.txtinserir.Size = new System.Drawing.Size(172, 20);
            this.txtinserir.TabIndex = 0;
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(13, 62);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(34, 13);
            this.texto.TabIndex = 1;
            this.texto.Text = "Texto";
            // 
            // bntinserir
            // 
            this.bntinserir.Location = new System.Drawing.Point(16, 123);
            this.bntinserir.Name = "bntinserir";
            this.bntinserir.Size = new System.Drawing.Size(75, 23);
            this.bntinserir.TabIndex = 2;
            this.bntinserir.Text = "inserir";
            this.bntinserir.UseVisualStyleBackColor = true;
            this.bntinserir.Click += new System.EventHandler(this.bntinserir_Click);
            // 
            // bntOrdenarcombo
            // 
            this.bntOrdenarcombo.Location = new System.Drawing.Point(128, 123);
            this.bntOrdenarcombo.Name = "bntOrdenarcombo";
            this.bntOrdenarcombo.Size = new System.Drawing.Size(119, 23);
            this.bntOrdenarcombo.TabIndex = 3;
            this.bntOrdenarcombo.Text = "Ordenar o Combo\r\n";
            this.bntOrdenarcombo.UseVisualStyleBackColor = true;
            this.bntOrdenarcombo.Click += new System.EventHandler(this.bntOrdenarcombo_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(231, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // bntlimpar
            // 
            this.bntlimpar.Location = new System.Drawing.Point(56, 214);
            this.bntlimpar.Name = "bntlimpar";
            this.bntlimpar.Size = new System.Drawing.Size(134, 23);
            this.bntlimpar.TabIndex = 5;
            this.bntlimpar.Text = "Remover do Combo";
            this.bntlimpar.UseVisualStyleBackColor = true;
            this.bntlimpar.Click += new System.EventHandler(this.bntlimpar_Click);
            // 
            // lblquantidade
            // 
            this.lblquantidade.AutoSize = true;
            this.lblquantidade.Location = new System.Drawing.Point(16, 286);
            this.lblquantidade.Name = "lblquantidade";
            this.lblquantidade.Size = new System.Drawing.Size(108, 13);
            this.lblquantidade.TabIndex = 6;
            this.lblquantidade.Text = "Quantidade de intens";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(190, 286);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 13);
            this.lbltotal.TabIndex = 7;
            // 
            // bntexibir
            // 
            this.bntexibir.Location = new System.Drawing.Point(56, 350);
            this.bntexibir.Name = "bntexibir";
            this.bntexibir.Size = new System.Drawing.Size(134, 23);
            this.bntexibir.TabIndex = 8;
            this.bntexibir.Text = "Exibir dados do Combo";
            this.bntexibir.UseVisualStyleBackColor = true;
            this.bntexibir.Click += new System.EventHandler(this.bntexibir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Índice do Combo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Texto do Combo";
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(128, 392);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(172, 20);
            this.txtindice.TabIndex = 11;
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(128, 453);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(172, 20);
            this.txtConteudo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 535);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntexibir);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblquantidade);
            this.Controls.Add(this.bntlimpar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bntOrdenarcombo);
            this.Controls.Add(this.bntinserir);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.txtinserir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinserir;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.Button bntinserir;
        private System.Windows.Forms.Button bntOrdenarcombo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bntlimpar;
        private System.Windows.Forms.Label lblquantidade;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button bntexibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtConteudo;
    }
}

