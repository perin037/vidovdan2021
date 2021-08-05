
namespace Semafor
{
    partial class FormPodesiImena
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
            this.labelDomacin = new System.Windows.Forms.Label();
            this.labelGost = new System.Windows.Forms.Label();
            this.tbDomacin = new System.Windows.Forms.TextBox();
            this.tbGost = new System.Windows.Forms.TextBox();
            this.btnSetuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDomacin
            // 
            this.labelDomacin.AutoSize = true;
            this.labelDomacin.Location = new System.Drawing.Point(73, 58);
            this.labelDomacin.Name = "labelDomacin";
            this.labelDomacin.Size = new System.Drawing.Size(60, 13);
            this.labelDomacin.TabIndex = 0;
            this.labelDomacin.Text = "DOMACIN:";
            // 
            // labelGost
            // 
            this.labelGost.AutoSize = true;
            this.labelGost.Location = new System.Drawing.Point(71, 109);
            this.labelGost.Name = "labelGost";
            this.labelGost.Size = new System.Drawing.Size(40, 13);
            this.labelGost.TabIndex = 1;
            this.labelGost.Text = "GOST:";
            // 
            // tbDomacin
            // 
            this.tbDomacin.Location = new System.Drawing.Point(156, 56);
            this.tbDomacin.Name = "tbDomacin";
            this.tbDomacin.Size = new System.Drawing.Size(177, 20);
            this.tbDomacin.TabIndex = 2;
            // 
            // tbGost
            // 
            this.tbGost.Location = new System.Drawing.Point(156, 106);
            this.tbGost.Name = "tbGost";
            this.tbGost.Size = new System.Drawing.Size(177, 20);
            this.tbGost.TabIndex = 3;
            // 
            // btnSetuj
            // 
            this.btnSetuj.Location = new System.Drawing.Point(74, 184);
            this.btnSetuj.Name = "btnSetuj";
            this.btnSetuj.Size = new System.Drawing.Size(259, 23);
            this.btnSetuj.TabIndex = 4;
            this.btnSetuj.Text = "PODESI";
            this.btnSetuj.UseVisualStyleBackColor = true;
            this.btnSetuj.Click += new System.EventHandler(this.btnSetuj_Click);
            // 
            // FormPodesiImena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 234);
            this.Controls.Add(this.btnSetuj);
            this.Controls.Add(this.tbGost);
            this.Controls.Add(this.tbDomacin);
            this.Controls.Add(this.labelGost);
            this.Controls.Add(this.labelDomacin);
            this.Name = "FormPodesiImena";
            this.Text = "FormPodesiImena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDomacin;
        private System.Windows.Forms.Label labelGost;
        private System.Windows.Forms.TextBox tbDomacin;
        private System.Windows.Forms.TextBox tbGost;
        private System.Windows.Forms.Button btnSetuj;
    }
}