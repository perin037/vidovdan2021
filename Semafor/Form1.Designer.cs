
namespace Semafor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbSep1 = new System.Windows.Forms.Label();
            this.lbSec = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPauza = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPodesiImena = new System.Windows.Forms.Button();
            this.labelDomacin = new System.Windows.Forms.Label();
            this.labelGost = new System.Windows.Forms.Label();
            this.goloviDomacin = new System.Windows.Forms.Label();
            this.goloviGost = new System.Windows.Forms.Label();
            this.btnDomaciPlus = new System.Windows.Forms.Button();
            this.btnGostPlus = new System.Windows.Forms.Button();
            this.btnDomaciMinus = new System.Windows.Forms.Button();
            this.btnGostMinus = new System.Windows.Forms.Button();
            this.btnOduzmiDomacinuFaul = new System.Windows.Forms.Button();
            this.btnDodajDomacinuFaul = new System.Windows.Forms.Button();
            this.fauloviDomacin = new System.Windows.Forms.Label();
            this.btnOduzmiGostuFaul = new System.Windows.Forms.Button();
            this.btnDodajGostuFaul = new System.Windows.Forms.Button();
            this.fauloviGost = new System.Windows.Forms.Label();
            this.btnVratiPeriod = new System.Windows.Forms.Button();
            this.btnSledeciPeriod = new System.Windows.Forms.Button();
            this.period = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Font = new System.Drawing.Font("Sports World", 172F);
            this.lbMin.Location = new System.Drawing.Point(211, 31);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(421, 260);
            this.lbMin.TabIndex = 0;
            this.lbMin.Text = "00";
            // 
            // lbSep1
            // 
            this.lbSep1.AutoSize = true;
            this.lbSep1.Font = new System.Drawing.Font("Sports World", 172F);
            this.lbSep1.Location = new System.Drawing.Point(588, 9);
            this.lbSep1.Name = "lbSep1";
            this.lbSep1.Size = new System.Drawing.Size(173, 260);
            this.lbSep1.TabIndex = 1;
            this.lbSep1.Text = ":";
            // 
            // lbSec
            // 
            this.lbSec.AutoSize = true;
            this.lbSec.Font = new System.Drawing.Font("Sports World", 172F);
            this.lbSec.Location = new System.Drawing.Point(747, 31);
            this.lbSec.Name = "lbSec";
            this.lbSec.Size = new System.Drawing.Size(421, 260);
            this.lbSec.TabIndex = 2;
            this.lbSec.Text = "00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1186, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPauza
            // 
            this.btnPauza.Location = new System.Drawing.Point(1186, 181);
            this.btnPauza.Name = "btnPauza";
            this.btnPauza.Size = new System.Drawing.Size(75, 23);
            this.btnPauza.TabIndex = 4;
            this.btnPauza.Text = "Pauza";
            this.btnPauza.UseVisualStyleBackColor = true;
            this.btnPauza.Click += new System.EventHandler(this.btnPauza_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(632, 230);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPodesiImena
            // 
            this.btnPodesiImena.Location = new System.Drawing.Point(28, 22);
            this.btnPodesiImena.Name = "btnPodesiImena";
            this.btnPodesiImena.Size = new System.Drawing.Size(120, 23);
            this.btnPodesiImena.TabIndex = 6;
            this.btnPodesiImena.Text = "Podesi imena";
            this.btnPodesiImena.UseVisualStyleBackColor = true;
            this.btnPodesiImena.Click += new System.EventHandler(this.btnPodesiImena_Click);
            // 
            // labelDomacin
            // 
            this.labelDomacin.AutoSize = true;
            this.labelDomacin.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomacin.Location = new System.Drawing.Point(2, 269);
            this.labelDomacin.Name = "labelDomacin";
            this.labelDomacin.Size = new System.Drawing.Size(241, 61);
            this.labelDomacin.TabIndex = 7;
            this.labelDomacin.Text = "Domacin";
            // 
            // labelGost
            // 
            this.labelGost.AutoSize = true;
            this.labelGost.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.labelGost.Location = new System.Drawing.Point(668, 269);
            this.labelGost.Name = "labelGost";
            this.labelGost.Size = new System.Drawing.Size(145, 63);
            this.labelGost.TabIndex = 9;
            this.labelGost.Text = "Gost";
            // 
            // goloviDomacin
            // 
            this.goloviDomacin.AutoSize = true;
            this.goloviDomacin.Font = new System.Drawing.Font("Sports World", 188F, System.Drawing.FontStyle.Bold);
            this.goloviDomacin.Location = new System.Drawing.Point(170, 324);
            this.goloviDomacin.Name = "goloviDomacin";
            this.goloviDomacin.Size = new System.Drawing.Size(296, 284);
            this.goloviDomacin.TabIndex = 10;
            this.goloviDomacin.Text = "0";
            this.goloviDomacin.Click += new System.EventHandler(this.goloviDomacin_Click);
            // 
            // goloviGost
            // 
            this.goloviGost.AutoSize = true;
            this.goloviGost.Font = new System.Drawing.Font("Sports World", 188F, System.Drawing.FontStyle.Bold);
            this.goloviGost.Location = new System.Drawing.Point(788, 324);
            this.goloviGost.Name = "goloviGost";
            this.goloviGost.Size = new System.Drawing.Size(296, 284);
            this.goloviGost.TabIndex = 11;
            this.goloviGost.Text = "0";
            this.goloviGost.Click += new System.EventHandler(this.goloviGost_Click);
            // 
            // btnDomaciPlus
            // 
            this.btnDomaciPlus.Location = new System.Drawing.Point(141, 386);
            this.btnDomaciPlus.Name = "btnDomaciPlus";
            this.btnDomaciPlus.Size = new System.Drawing.Size(23, 23);
            this.btnDomaciPlus.TabIndex = 12;
            this.btnDomaciPlus.Text = "+";
            this.btnDomaciPlus.UseVisualStyleBackColor = true;
            this.btnDomaciPlus.Click += new System.EventHandler(this.btnDomaci_Click);
            // 
            // btnGostPlus
            // 
            this.btnGostPlus.Location = new System.Drawing.Point(1164, 372);
            this.btnGostPlus.Name = "btnGostPlus";
            this.btnGostPlus.Size = new System.Drawing.Size(23, 23);
            this.btnGostPlus.TabIndex = 13;
            this.btnGostPlus.Text = "+";
            this.btnGostPlus.UseVisualStyleBackColor = true;
            this.btnGostPlus.Click += new System.EventHandler(this.btnGosti_Click);
            // 
            // btnDomaciMinus
            // 
            this.btnDomaciMinus.Location = new System.Drawing.Point(106, 458);
            this.btnDomaciMinus.Name = "btnDomaciMinus";
            this.btnDomaciMinus.Size = new System.Drawing.Size(23, 23);
            this.btnDomaciMinus.TabIndex = 14;
            this.btnDomaciMinus.Text = "-";
            this.btnDomaciMinus.UseVisualStyleBackColor = true;
            this.btnDomaciMinus.Click += new System.EventHandler(this.btnDomaciMinus_Click);
            // 
            // btnGostMinus
            // 
            this.btnGostMinus.Location = new System.Drawing.Point(1164, 444);
            this.btnGostMinus.Name = "btnGostMinus";
            this.btnGostMinus.Size = new System.Drawing.Size(23, 23);
            this.btnGostMinus.TabIndex = 15;
            this.btnGostMinus.Text = "-";
            this.btnGostMinus.UseVisualStyleBackColor = true;
            this.btnGostMinus.Click += new System.EventHandler(this.btnGostaMinus_Click);
            // 
            // btnOduzmiDomacinuFaul
            // 
            this.btnOduzmiDomacinuFaul.Location = new System.Drawing.Point(57, 635);
            this.btnOduzmiDomacinuFaul.Name = "btnOduzmiDomacinuFaul";
            this.btnOduzmiDomacinuFaul.Size = new System.Drawing.Size(23, 23);
            this.btnOduzmiDomacinuFaul.TabIndex = 18;
            this.btnOduzmiDomacinuFaul.Text = "-";
            this.btnOduzmiDomacinuFaul.UseVisualStyleBackColor = true;
            this.btnOduzmiDomacinuFaul.Click += new System.EventHandler(this.btnOduzmiDomacinuFaul_Click);
            // 
            // btnDodajDomacinuFaul
            // 
            this.btnDodajDomacinuFaul.Location = new System.Drawing.Point(106, 585);
            this.btnDodajDomacinuFaul.Name = "btnDodajDomacinuFaul";
            this.btnDodajDomacinuFaul.Size = new System.Drawing.Size(23, 23);
            this.btnDodajDomacinuFaul.TabIndex = 17;
            this.btnDodajDomacinuFaul.Text = "+";
            this.btnDodajDomacinuFaul.UseVisualStyleBackColor = true;
            this.btnDodajDomacinuFaul.Click += new System.EventHandler(this.btnDodajDomacinuFaul_Click);
            // 
            // fauloviDomacin
            // 
            this.fauloviDomacin.AutoSize = true;
            this.fauloviDomacin.Font = new System.Drawing.Font("Sports World", 101F, System.Drawing.FontStyle.Bold);
            this.fauloviDomacin.Location = new System.Drawing.Point(192, 558);
            this.fauloviDomacin.Name = "fauloviDomacin";
            this.fauloviDomacin.Size = new System.Drawing.Size(160, 153);
            this.fauloviDomacin.TabIndex = 16;
            this.fauloviDomacin.Text = "0";
            // 
            // btnOduzmiGostuFaul
            // 
            this.btnOduzmiGostuFaul.Location = new System.Drawing.Point(1123, 667);
            this.btnOduzmiGostuFaul.Name = "btnOduzmiGostuFaul";
            this.btnOduzmiGostuFaul.Size = new System.Drawing.Size(23, 23);
            this.btnOduzmiGostuFaul.TabIndex = 21;
            this.btnOduzmiGostuFaul.Text = "-";
            this.btnOduzmiGostuFaul.UseVisualStyleBackColor = true;
            this.btnOduzmiGostuFaul.Click += new System.EventHandler(this.btnOduzmiGostuFaul_Click);
            // 
            // btnDodajGostuFaul
            // 
            this.btnDodajGostuFaul.Location = new System.Drawing.Point(1061, 585);
            this.btnDodajGostuFaul.Name = "btnDodajGostuFaul";
            this.btnDodajGostuFaul.Size = new System.Drawing.Size(23, 23);
            this.btnDodajGostuFaul.TabIndex = 20;
            this.btnDodajGostuFaul.Text = "+";
            this.btnDodajGostuFaul.UseVisualStyleBackColor = true;
            this.btnDodajGostuFaul.Click += new System.EventHandler(this.btnDodajGostuFaul_Click);
            // 
            // fauloviGost
            // 
            this.fauloviGost.AutoSize = true;
            this.fauloviGost.Font = new System.Drawing.Font("Sports World", 101F);
            this.fauloviGost.Location = new System.Drawing.Point(912, 558);
            this.fauloviGost.Name = "fauloviGost";
            this.fauloviGost.Size = new System.Drawing.Size(156, 153);
            this.fauloviGost.TabIndex = 19;
            this.fauloviGost.Text = "0";
            // 
            // btnVratiPeriod
            // 
            this.btnVratiPeriod.Location = new System.Drawing.Point(647, 635);
            this.btnVratiPeriod.Name = "btnVratiPeriod";
            this.btnVratiPeriod.Size = new System.Drawing.Size(23, 23);
            this.btnVratiPeriod.TabIndex = 24;
            this.btnVratiPeriod.Text = "-";
            this.btnVratiPeriod.UseVisualStyleBackColor = true;
            this.btnVratiPeriod.Click += new System.EventHandler(this.btnVratiPeriod_Click);
            // 
            // btnSledeciPeriod
            // 
            this.btnSledeciPeriod.Location = new System.Drawing.Point(584, 635);
            this.btnSledeciPeriod.Name = "btnSledeciPeriod";
            this.btnSledeciPeriod.Size = new System.Drawing.Size(23, 23);
            this.btnSledeciPeriod.TabIndex = 23;
            this.btnSledeciPeriod.Text = "+";
            this.btnSledeciPeriod.UseVisualStyleBackColor = true;
            this.btnSledeciPeriod.Click += new System.EventHandler(this.btnSledeciPeriod_Click);
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Sports World", 101F);
            this.period.Location = new System.Drawing.Point(558, 485);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(136, 153);
            this.period.TabIndex = 22;
            this.period.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(519, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 54);
            this.label1.TabIndex = 25;
            this.label1.Text = "ПЕРИОД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(333, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(735, 63);
            this.label2.TabIndex = 26;
            this.label2.Text = "ТУРНИР У ЋИЋЕВЦУ 2021";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVratiPeriod);
            this.Controls.Add(this.btnSledeciPeriod);
            this.Controls.Add(this.period);
            this.Controls.Add(this.btnOduzmiGostuFaul);
            this.Controls.Add(this.btnDodajGostuFaul);
            this.Controls.Add(this.fauloviGost);
            this.Controls.Add(this.btnOduzmiDomacinuFaul);
            this.Controls.Add(this.btnDodajDomacinuFaul);
            this.Controls.Add(this.fauloviDomacin);
            this.Controls.Add(this.btnGostMinus);
            this.Controls.Add(this.btnDomaciMinus);
            this.Controls.Add(this.btnGostPlus);
            this.Controls.Add(this.btnDomaciPlus);
            this.Controls.Add(this.goloviGost);
            this.Controls.Add(this.goloviDomacin);
            this.Controls.Add(this.labelGost);
            this.Controls.Add(this.labelDomacin);
            this.Controls.Add(this.btnPodesiImena);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPauza);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbSec);
            this.Controls.Add(this.lbSep1);
            this.Controls.Add(this.lbMin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbSep1;
        private System.Windows.Forms.Label lbSec;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPauza;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPodesiImena;
        
        public System.Windows.Forms.Label labelDomacin;
        public System.Windows.Forms.Label labelGost;
        private System.Windows.Forms.Label goloviDomacin;
        private System.Windows.Forms.Label goloviGost;
        private System.Windows.Forms.Button btnDomaciPlus;
        private System.Windows.Forms.Button btnGostPlus;
        private System.Windows.Forms.Button btnDomaciMinus;
        private System.Windows.Forms.Button btnGostMinus;
        private System.Windows.Forms.Button btnOduzmiDomacinuFaul;
        private System.Windows.Forms.Button btnDodajDomacinuFaul;
        private System.Windows.Forms.Label fauloviDomacin;
        private System.Windows.Forms.Button btnOduzmiGostuFaul;
        private System.Windows.Forms.Button btnDodajGostuFaul;
        private System.Windows.Forms.Label fauloviGost;
        private System.Windows.Forms.Button btnVratiPeriod;
        private System.Windows.Forms.Button btnSledeciPeriod;
        private System.Windows.Forms.Label period;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}

