
namespace ProjetoInicial
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
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n0 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.apagar = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.limparRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.Black;
            this.btnSoma.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.ForeColor = System.Drawing.Color.White;
            this.btnSoma.Location = new System.Drawing.Point(155, 219);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(40, 38);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.Black;
            this.btnSubtracao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.ForeColor = System.Drawing.Color.White;
            this.btnSubtracao.Location = new System.Drawing.Point(155, 175);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(40, 38);
            this.btnSubtracao.TabIndex = 1;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.Black;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicacao.Location = new System.Drawing.Point(155, 131);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(40, 38);
            this.btnMultiplicacao.TabIndex = 2;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.Black;
            this.btnDivisao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.ForeColor = System.Drawing.Color.White;
            this.btnDivisao.Location = new System.Drawing.Point(155, 87);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(40, 38);
            this.btnDivisao.TabIndex = 3;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // resultado
            // 
            this.resultado.BackColor = System.Drawing.Color.Black;
            this.resultado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.White;
            this.resultado.Location = new System.Drawing.Point(199, 175);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(53, 82);
            this.resultado.TabIndex = 7;
            this.resultado.Text = "=";
            this.resultado.UseVisualStyleBackColor = false;
            this.resultado.Click += new System.EventHandler(this.resultado_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(37, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(183, 27);
            this.title.TabIndex = 10;
            this.title.Text = "Calculadora Básica";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // n1
            // 
            this.n1.BackColor = System.Drawing.Color.Black;
            this.n1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1.ForeColor = System.Drawing.Color.White;
            this.n1.Location = new System.Drawing.Point(17, 175);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(40, 38);
            this.n1.TabIndex = 11;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            this.n1.Click += new System.EventHandler(this.n1_Click);
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.Black;
            this.n2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2.ForeColor = System.Drawing.Color.White;
            this.n2.Location = new System.Drawing.Point(63, 175);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(40, 38);
            this.n2.TabIndex = 12;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            this.n2.Click += new System.EventHandler(this.n2_Click);
            // 
            // n3
            // 
            this.n3.BackColor = System.Drawing.Color.Black;
            this.n3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3.ForeColor = System.Drawing.Color.White;
            this.n3.Location = new System.Drawing.Point(109, 175);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(40, 38);
            this.n3.TabIndex = 13;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = false;
            this.n3.Click += new System.EventHandler(this.n3_Click);
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.Black;
            this.n4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4.ForeColor = System.Drawing.Color.White;
            this.n4.Location = new System.Drawing.Point(17, 131);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(40, 38);
            this.n4.TabIndex = 14;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            this.n4.Click += new System.EventHandler(this.n4_Click);
            // 
            // n5
            // 
            this.n5.BackColor = System.Drawing.Color.Black;
            this.n5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5.ForeColor = System.Drawing.Color.White;
            this.n5.Location = new System.Drawing.Point(63, 131);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(40, 38);
            this.n5.TabIndex = 15;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = false;
            this.n5.Click += new System.EventHandler(this.n5_Click);
            // 
            // n6
            // 
            this.n6.BackColor = System.Drawing.Color.Black;
            this.n6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n6.ForeColor = System.Drawing.Color.White;
            this.n6.Location = new System.Drawing.Point(109, 131);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(40, 38);
            this.n6.TabIndex = 16;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = false;
            this.n6.Click += new System.EventHandler(this.n6_Click);
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.Black;
            this.n7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n7.ForeColor = System.Drawing.Color.White;
            this.n7.Location = new System.Drawing.Point(17, 87);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(40, 38);
            this.n7.TabIndex = 17;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            this.n7.Click += new System.EventHandler(this.n7_Click);
            // 
            // n8
            // 
            this.n8.BackColor = System.Drawing.Color.Black;
            this.n8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n8.ForeColor = System.Drawing.Color.White;
            this.n8.Location = new System.Drawing.Point(63, 87);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(40, 38);
            this.n8.TabIndex = 18;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = false;
            this.n8.Click += new System.EventHandler(this.n8_Click);
            // 
            // n9
            // 
            this.n9.BackColor = System.Drawing.Color.Black;
            this.n9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n9.ForeColor = System.Drawing.Color.White;
            this.n9.Location = new System.Drawing.Point(109, 87);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(40, 38);
            this.n9.TabIndex = 19;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = false;
            this.n9.Click += new System.EventHandler(this.n9_Click);
            // 
            // n0
            // 
            this.n0.BackColor = System.Drawing.Color.Black;
            this.n0.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n0.ForeColor = System.Drawing.Color.White;
            this.n0.Location = new System.Drawing.Point(17, 219);
            this.n0.Name = "n0";
            this.n0.Size = new System.Drawing.Size(86, 38);
            this.n0.TabIndex = 20;
            this.n0.Text = "0";
            this.n0.UseVisualStyleBackColor = false;
            this.n0.Click += new System.EventHandler(this.n0_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.White;
            this.txtResultado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(17, 46);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(234, 35);
            this.txtResultado.TabIndex = 22;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.White;
            this.lblOperacao.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.lblOperacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOperacao.Location = new System.Drawing.Point(30, 52);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 19);
            this.lblOperacao.TabIndex = 23;
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // apagar
            // 
            this.apagar.BackColor = System.Drawing.Color.DarkRed;
            this.apagar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apagar.ForeColor = System.Drawing.Color.White;
            this.apagar.Location = new System.Drawing.Point(199, 87);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(52, 38);
            this.apagar.TabIndex = 24;
            this.apagar.Text = "C";
            this.apagar.UseVisualStyleBackColor = false;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // virgula
            // 
            this.virgula.BackColor = System.Drawing.Color.Black;
            this.virgula.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.ForeColor = System.Drawing.Color.White;
            this.virgula.Location = new System.Drawing.Point(109, 219);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(40, 38);
            this.virgula.TabIndex = 25;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = false;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // limparRegistro
            // 
            this.limparRegistro.BackColor = System.Drawing.Color.DarkRed;
            this.limparRegistro.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparRegistro.ForeColor = System.Drawing.Color.White;
            this.limparRegistro.Location = new System.Drawing.Point(199, 131);
            this.limparRegistro.Name = "limparRegistro";
            this.limparRegistro.Size = new System.Drawing.Size(53, 38);
            this.limparRegistro.TabIndex = 26;
            this.limparRegistro.Text = "CE";
            this.limparRegistro.UseVisualStyleBackColor = false;
            this.limparRegistro.Click += new System.EventHandler(this.limparRegistro_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(264, 276);
            this.Controls.Add(this.limparRegistro);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.n0);
            this.Controls.Add(this.n9);
            this.Controls.Add(this.n8);
            this.Controls.Add(this.n7);
            this.Controls.Add(this.n6);
            this.Controls.Add(this.n5);
            this.Controls.Add(this.n4);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnSoma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hello;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button resultado;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n0;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button limparRegistro;
    }
}

