
namespace controle_de_semaforo
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbA3 = new System.Windows.Forms.RadioButton();
            this.rdbA2 = new System.Windows.Forms.RadioButton();
            this.rdbA1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbB3 = new System.Windows.Forms.RadioButton();
            this.rdbB2 = new System.Windows.Forms.RadioButton();
            this.rdbB1 = new System.Windows.Forms.RadioButton();
            this.picRua1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picRua2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbA3);
            this.groupBox1.Controls.Add(this.rdbA2);
            this.groupBox1.Controls.Add(this.rdbA1);
            this.groupBox1.Location = new System.Drawing.Point(46, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rua 1";
            // 
            // rdbA3
            // 
            this.rdbA3.AutoSize = true;
            this.rdbA3.Location = new System.Drawing.Point(7, 68);
            this.rdbA3.Name = "rdbA3";
            this.rdbA3.Size = new System.Drawing.Size(78, 17);
            this.rdbA3.TabIndex = 2;
            this.rdbA3.TabStop = true;
            this.rdbA3.Tag = "3";
            this.rdbA3.Text = "Sinal verde";
            this.rdbA3.UseVisualStyleBackColor = true;
            this.rdbA3.CheckedChanged += new System.EventHandler(this.ChangedEstado);
            // 
            // rdbA2
            // 
            this.rdbA2.AutoSize = true;
            this.rdbA2.Location = new System.Drawing.Point(7, 44);
            this.rdbA2.Name = "rdbA2";
            this.rdbA2.Size = new System.Drawing.Size(88, 17);
            this.rdbA2.TabIndex = 1;
            this.rdbA2.TabStop = true;
            this.rdbA2.Tag = "2";
            this.rdbA2.Text = "Sinal amarelo";
            this.rdbA2.UseVisualStyleBackColor = true;
            this.rdbA2.CheckedChanged += new System.EventHandler(this.ChangedEstado);
            // 
            // rdbA1
            // 
            this.rdbA1.AutoSize = true;
            this.rdbA1.Checked = true;
            this.rdbA1.Location = new System.Drawing.Point(7, 20);
            this.rdbA1.Name = "rdbA1";
            this.rdbA1.Size = new System.Drawing.Size(94, 17);
            this.rdbA1.TabIndex = 0;
            this.rdbA1.TabStop = true;
            this.rdbA1.Tag = "1";
            this.rdbA1.Text = "Sinal vermelho";
            this.rdbA1.UseVisualStyleBackColor = true;
            this.rdbA1.CheckedChanged += new System.EventHandler(this.ChangedEstado);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbB3);
            this.groupBox2.Controls.Add(this.rdbB2);
            this.groupBox2.Controls.Add(this.rdbB1);
            this.groupBox2.Location = new System.Drawing.Point(381, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rua 2";
            // 
            // rdbB3
            // 
            this.rdbB3.AutoSize = true;
            this.rdbB3.Checked = true;
            this.rdbB3.Location = new System.Drawing.Point(6, 67);
            this.rdbB3.Name = "rdbB3";
            this.rdbB3.Size = new System.Drawing.Size(78, 17);
            this.rdbB3.TabIndex = 5;
            this.rdbB3.TabStop = true;
            this.rdbB3.Tag = "6";
            this.rdbB3.Text = "Sinal verde";
            this.rdbB3.UseVisualStyleBackColor = true;
            this.rdbB3.CheckedChanged += new System.EventHandler(this.ChangedEstado);
            // 
            // rdbB2
            // 
            this.rdbB2.AutoSize = true;
            this.rdbB2.Location = new System.Drawing.Point(6, 43);
            this.rdbB2.Name = "rdbB2";
            this.rdbB2.Size = new System.Drawing.Size(88, 17);
            this.rdbB2.TabIndex = 4;
            this.rdbB2.TabStop = true;
            this.rdbB2.Tag = "5";
            this.rdbB2.Text = "Sinal amarelo";
            this.rdbB2.UseVisualStyleBackColor = true;
            this.rdbB2.CheckedChanged += new System.EventHandler(this.ChangedEstado);
            // 
            // rdbB1
            // 
            this.rdbB1.AutoSize = true;
            this.rdbB1.Location = new System.Drawing.Point(6, 19);
            this.rdbB1.Name = "rdbB1";
            this.rdbB1.Size = new System.Drawing.Size(94, 17);
            this.rdbB1.TabIndex = 3;
            this.rdbB1.TabStop = true;
            this.rdbB1.Tag = "4";
            this.rdbB1.Text = "Sinal vermelho";
            this.rdbB1.UseVisualStyleBackColor = true;
            this.rdbB1.CheckedChanged += new System.EventHandler(this.ChangedEstado);
            // 
            // picRua1
            // 
            this.picRua1.Image = global::controle_de_semaforo.Properties.Resources.sinal_vermelho;
            this.picRua1.Location = new System.Drawing.Point(78, 227);
            this.picRua1.Name = "picRua1";
            this.picRua1.Size = new System.Drawing.Size(101, 169);
            this.picRua1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRua1.TabIndex = 2;
            this.picRua1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(272, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Timer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "PROJETO SEMÁFORO";
            // 
            // picRua2
            // 
            this.picRua2.Image = global::controle_de_semaforo.Properties.Resources.sinal_verde;
            this.picRua2.Location = new System.Drawing.Point(439, 227);
            this.picRua2.Name = "picRua2";
            this.picRua2.Size = new System.Drawing.Size(101, 169);
            this.picRua2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRua2.TabIndex = 7;
            this.picRua2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picRua2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picRua1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRua1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRua2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbA3;
        private System.Windows.Forms.RadioButton rdbA2;
        private System.Windows.Forms.RadioButton rdbA1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picRua1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbB3;
        private System.Windows.Forms.RadioButton rdbB2;
        private System.Windows.Forms.RadioButton rdbB1;
        private System.Windows.Forms.PictureBox picRua2;
        private System.Windows.Forms.Label label2;
    }
}

