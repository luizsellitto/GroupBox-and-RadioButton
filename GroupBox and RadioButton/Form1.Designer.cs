namespace GroupBox_and_RadioButton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.rb_mult = new System.Windows.Forms.RadioButton();
            this.rb_sub = new System.Windows.Forms.RadioButton();
            this.rb_soma = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_first = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_second = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_div);
            this.groupBox1.Controls.Add(this.rb_mult);
            this.groupBox1.Controls.Add(this.rb_sub);
            this.groupBox1.Controls.Add(this.rb_soma);
            this.groupBox1.Location = new System.Drawing.Point(146, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(16, 167);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(74, 20);
            this.rb_div.TabIndex = 3;
            this.rb_div.TabStop = true;
            this.rb_div.Text = "Divisão";
            this.rb_div.UseVisualStyleBackColor = true;
            // 
            // rb_mult
            // 
            this.rb_mult.AutoSize = true;
            this.rb_mult.Location = new System.Drawing.Point(16, 123);
            this.rb_mult.Name = "rb_mult";
            this.rb_mult.Size = new System.Drawing.Size(107, 20);
            this.rb_mult.TabIndex = 2;
            this.rb_mult.TabStop = true;
            this.rb_mult.Text = "Multiplicação";
            this.rb_mult.UseVisualStyleBackColor = true;
            // 
            // rb_sub
            // 
            this.rb_sub.AutoSize = true;
            this.rb_sub.Location = new System.Drawing.Point(16, 84);
            this.rb_sub.Name = "rb_sub";
            this.rb_sub.Size = new System.Drawing.Size(90, 20);
            this.rb_sub.TabIndex = 1;
            this.rb_sub.TabStop = true;
            this.rb_sub.Text = "Subtração";
            this.rb_sub.UseVisualStyleBackColor = true;
            // 
            // rb_soma
            // 
            this.rb_soma.AutoSize = true;
            this.rb_soma.Location = new System.Drawing.Point(16, 43);
            this.rb_soma.Name = "rb_soma";
            this.rb_soma.Size = new System.Drawing.Size(64, 20);
            this.rb_soma.TabIndex = 0;
            this.rb_soma.TabStop = true;
            this.rb_soma.Text = "Soma";
            this.rb_soma.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button1.Location = new System.Drawing.Point(498, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 104);
            this.label1.TabIndex = 2;
            this.label1.Text = "Matemática";
            // 
            // tb_first
            // 
            this.tb_first.Location = new System.Drawing.Point(446, 171);
            this.tb_first.Name = "tb_first";
            this.tb_first.Size = new System.Drawing.Size(175, 22);
            this.tb_first.TabIndex = 3;
            this.tb_first.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite o Primeiro Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Digite o segundo número:";
            // 
            // tb_second
            // 
            this.tb_second.Location = new System.Drawing.Point(446, 228);
            this.tb_second.Name = "tb_second";
            this.tb_second.Size = new System.Drawing.Size(175, 22);
            this.tb_second.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_second);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_first);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.RadioButton rb_mult;
        private System.Windows.Forms.RadioButton rb_sub;
        private System.Windows.Forms.RadioButton rb_soma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_first;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_second;
        private System.Windows.Forms.Label label4;
    }
}

