
namespace TrackStudyTime
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.obiettivo = new System.Windows.Forms.NumericUpDown();
            this.ore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.pausa = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minuti = new System.Windows.Forms.Label();
            this.secondi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pasto = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.durataTotaleP = new System.Windows.Forms.Label();
            this.timePausebtn = new System.Windows.Forms.Button();
            this.Amici = new System.Windows.Forms.Button();
            this.emailText = new System.Windows.Forms.TextBox();
            this.pausaAttualeLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.showGrafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.obiettivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(63, 4);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 22);
            this.nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Obiettivo ore:";
            // 
            // obiettivo
            // 
            this.obiettivo.Location = new System.Drawing.Point(300, 7);
            this.obiettivo.Name = "obiettivo";
            this.obiettivo.Size = new System.Drawing.Size(60, 22);
            this.obiettivo.TabIndex = 3;
            // 
            // ore
            // 
            this.ore.AutoSize = true;
            this.ore.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ore.Location = new System.Drawing.Point(88, 164);
            this.ore.Name = "ore";
            this.ore.Size = new System.Drawing.Size(53, 38);
            this.ore.TabIndex = 4;
            this.ore.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(149, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 38);
            this.label7.TabIndex = 8;
            this.label7.Text = ":";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // play
            // 
            this.play.Location = new System.Drawing.Point(125, 241);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 32);
            this.play.TabIndex = 11;
            this.play.Text = "play";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(213, 241);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 32);
            this.pause.TabIndex = 12;
            this.pause.Text = "pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // pausa
            // 
            this.pausa.Location = new System.Drawing.Point(300, 38);
            this.pausa.Name = "pausa";
            this.pausa.Size = new System.Drawing.Size(60, 22);
            this.pausa.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Massima pausa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pausa);
            this.panel1.Controls.Add(this.obiettivo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 75);
            this.panel1.TabIndex = 17;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(435, 9);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "mail";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(73, 43);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "salva";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 43);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 17);
            this.label22.TabIndex = 33;
            this.label22.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "min";
            // 
            // minuti
            // 
            this.minuti.AutoSize = true;
            this.minuti.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuti.Location = new System.Drawing.Point(181, 164);
            this.minuti.Name = "minuti";
            this.minuti.Size = new System.Drawing.Size(53, 38);
            this.minuti.TabIndex = 18;
            this.minuti.Text = "00";
            // 
            // secondi
            // 
            this.secondi.AutoSize = true;
            this.secondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondi.Location = new System.Drawing.Point(267, 164);
            this.secondi.Name = "secondi";
            this.secondi.Size = new System.Drawing.Size(53, 38);
            this.secondi.TabIndex = 19;
            this.secondi.Text = "00";
            this.secondi.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(242, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 38);
            this.label8.TabIndex = 21;
            this.label8.Text = ":";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(410, 164);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 276);
            this.listBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Durata pause";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Durata studio";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(629, 164);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(219, 276);
            this.listBox2.TabIndex = 26;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pasto
            // 
            this.pasto.Location = new System.Drawing.Point(8, 417);
            this.pasto.Name = "pasto";
            this.pasto.Size = new System.Drawing.Size(97, 29);
            this.pasto.TabIndex = 28;
            this.pasto.Text = "pausa pasto";
            this.pasto.UseVisualStyleBackColor = true;
            this.pasto.Click += new System.EventHandler(this.pasto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Creato da Nicola Calvio ©";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "Visit my site";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // durataTotaleP
            // 
            this.durataTotaleP.AutoSize = true;
            this.durataTotaleP.Location = new System.Drawing.Point(693, 52);
            this.durataTotaleP.Name = "durataTotaleP";
            this.durataTotaleP.Size = new System.Drawing.Size(31, 17);
            this.durataTotaleP.TabIndex = 31;
            this.durataTotaleP.Text = "00s";
            // 
            // timePausebtn
            // 
            this.timePausebtn.Location = new System.Drawing.Point(590, 6);
            this.timePausebtn.Name = "timePausebtn";
            this.timePausebtn.Size = new System.Drawing.Size(163, 36);
            this.timePausebtn.TabIndex = 32;
            this.timePausebtn.Text = "mostra tempo pausa";
            this.timePausebtn.UseVisualStyleBackColor = true;
            this.timePausebtn.Click += new System.EventHandler(this.timePausebtn_Click);
            // 
            // Amici
            // 
            this.Amici.Location = new System.Drawing.Point(759, 7);
            this.Amici.Name = "Amici";
            this.Amici.Size = new System.Drawing.Size(116, 35);
            this.Amici.TabIndex = 33;
            this.Amici.Text = "Gestione Amici";
            this.Amici.UseVisualStyleBackColor = true;
            this.Amici.Click += new System.EventHandler(this.Amici_Click);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(0, 0);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 22);
            this.emailText.TabIndex = 0;
            // 
            // pausaAttualeLabel
            // 
            this.pausaAttualeLabel.AutoSize = true;
            this.pausaAttualeLabel.Location = new System.Drawing.Point(693, 82);
            this.pausaAttualeLabel.Name = "pausaAttualeLabel";
            this.pausaAttualeLabel.Size = new System.Drawing.Size(31, 17);
            this.pausaAttualeLabel.TabIndex = 34;
            this.pausaAttualeLabel.Text = "00s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(590, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "pausa totale";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(590, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "pausa attuale";
            // 
            // showGrafico
            // 
            this.showGrafico.Location = new System.Drawing.Point(149, 300);
            this.showGrafico.Name = "showGrafico";
            this.showGrafico.Size = new System.Drawing.Size(107, 53);
            this.showGrafico.TabIndex = 37;
            this.showGrafico.Text = "Mostra grafico";
            this.showGrafico.UseVisualStyleBackColor = true;
            this.showGrafico.Click += new System.EventHandler(this.showGrafico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.showGrafico);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pausaAttualeLabel);
            this.Controls.Add(this.Amici);
            this.Controls.Add(this.timePausebtn);
            this.Controls.Add(this.durataTotaleP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pasto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.secondi);
            this.Controls.Add(this.minuti);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obiettivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown obiettivo;
        private System.Windows.Forms.Label ore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pause;
        //private System.Windows.Forms.Button salva;
        private System.Windows.Forms.NumericUpDown pausa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label minuti;
        private System.Windows.Forms.Label secondi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button pasto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label durataTotaleP;
        private System.Windows.Forms.Button timePausebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button Amici;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label pausaAttualeLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button showGrafico;
    }
}

