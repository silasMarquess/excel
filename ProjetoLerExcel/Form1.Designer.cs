
namespace ProjetoLerExcel
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarArquivo = new System.Windows.Forms.Button();
            this.txtCaminhoEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePlanilha = new System.Windows.Forms.TextBox();
            this.btn_SelecionarPastaSaida = new System.Windows.Forms.Button();
            this.txtSaidaCaminho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeDaPlanilhaAnalise = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(427, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Rodar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planilha Entrada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscarArquivo
            // 
            this.btnBuscarArquivo.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArquivo.Location = new System.Drawing.Point(182, 25);
            this.btnBuscarArquivo.Name = "btnBuscarArquivo";
            this.btnBuscarArquivo.Size = new System.Drawing.Size(105, 23);
            this.btnBuscarArquivo.TabIndex = 2;
            this.btnBuscarArquivo.Text = "Selecionar XLSX";
            this.btnBuscarArquivo.UseVisualStyleBackColor = true;
            this.btnBuscarArquivo.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCaminhoEntrada
            // 
            this.txtCaminhoEntrada.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtCaminhoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoEntrada.ForeColor = System.Drawing.Color.White;
            this.txtCaminhoEntrada.Location = new System.Drawing.Point(12, 54);
            this.txtCaminhoEntrada.Name = "txtCaminhoEntrada";
            this.txtCaminhoEntrada.ReadOnly = true;
            this.txtCaminhoEntrada.Size = new System.Drawing.Size(432, 26);
            this.txtCaminhoEntrada.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(17, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pasta Saida";
            // 
            // txtNomePlanilha
            // 
            this.txtNomePlanilha.BackColor = System.Drawing.Color.Yellow;
            this.txtNomePlanilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePlanilha.Location = new System.Drawing.Point(162, 202);
            this.txtNomePlanilha.Name = "txtNomePlanilha";
            this.txtNomePlanilha.Size = new System.Drawing.Size(259, 27);
            this.txtNomePlanilha.TabIndex = 6;
            this.txtNomePlanilha.TextChanged += new System.EventHandler(this.txtNomePlanilha_TextChanged);
            // 
            // btn_SelecionarPastaSaida
            // 
            this.btn_SelecionarPastaSaida.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelecionarPastaSaida.Location = new System.Drawing.Point(144, 116);
            this.btn_SelecionarPastaSaida.Name = "btn_SelecionarPastaSaida";
            this.btn_SelecionarPastaSaida.Size = new System.Drawing.Size(114, 23);
            this.btn_SelecionarPastaSaida.TabIndex = 5;
            this.btn_SelecionarPastaSaida.Text = "Selecionar Pasta";
            this.btn_SelecionarPastaSaida.UseVisualStyleBackColor = true;
            this.btn_SelecionarPastaSaida.Click += new System.EventHandler(this.btn_SelecionarPastaSaida_Click);
            // 
            // txtSaidaCaminho
            // 
            this.txtSaidaCaminho.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtSaidaCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaidaCaminho.ForeColor = System.Drawing.Color.White;
            this.txtSaidaCaminho.Location = new System.Drawing.Point(13, 145);
            this.txtSaidaCaminho.Name = "txtSaidaCaminho";
            this.txtSaidaCaminho.ReadOnly = true;
            this.txtSaidaCaminho.Size = new System.Drawing.Size(660, 27);
            this.txtSaidaCaminho.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(21, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome da Planilha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(30, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Obrigatório)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(158, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "(Obs: não digite \'\\\', use \'-\')";
            // 
            // txtNomeDaPlanilhaAnalise
            // 
            this.txtNomeDaPlanilhaAnalise.BackColor = System.Drawing.Color.Yellow;
            this.txtNomeDaPlanilhaAnalise.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDaPlanilhaAnalise.Location = new System.Drawing.Point(450, 54);
            this.txtNomeDaPlanilhaAnalise.Name = "txtNomeDaPlanilhaAnalise";
            this.txtNomeDaPlanilhaAnalise.Size = new System.Drawing.Size(223, 27);
            this.txtNomeDaPlanilhaAnalise.TabIndex = 6;
            this.txtNomeDaPlanilhaAnalise.TextChanged += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(447, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome Planilha Análise";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(447, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Não digite:\"( , ),{,}\" ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(0, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 83);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem de Extração:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "1º Ordem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "2º Descricção";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "3º Tag";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "4º Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "5º Checklist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(685, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSaidaCaminho);
            this.Controls.Add(this.txtNomeDaPlanilhaAnalise);
            this.Controls.Add(this.txtNomePlanilha);
            this.Controls.Add(this.btn_SelecionarPastaSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminhoEntrada);
            this.Controls.Add(this.btnBuscarArquivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "FORMULARIO PRINCIPAL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePlanilha;
        private System.Windows.Forms.Button btn_SelecionarPastaSaida;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCaminhoEntrada;
        public System.Windows.Forms.Button btnBuscarArquivo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSaidaCaminho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeDaPlanilhaAnalise;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

