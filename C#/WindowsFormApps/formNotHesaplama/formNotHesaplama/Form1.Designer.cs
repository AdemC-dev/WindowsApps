
namespace WindowsFormsApp1
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
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelVize = new System.Windows.Forms.Label();
            this.textBoxVize = new System.Windows.Forms.TextBox();
            this.labeVizeY = new System.Windows.Forms.Label();
            this.textBoxVizeY = new System.Windows.Forms.TextBox();
            this.labelOrtalama = new System.Windows.Forms.Label();
            this.labelOrtValue = new System.Windows.Forms.Label();
            this.labelFinal = new System.Windows.Forms.Label();
            this.labelFinalY = new System.Windows.Forms.Label();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.textBoxFinalY = new System.Windows.Forms.TextBox();
            this.labelGecmeNotu = new System.Windows.Forms.Label();
            this.textBoxGecmeN = new System.Windows.Forms.TextBox();
            this.labelDurum = new System.Windows.Forms.Label();
            this.labelDurumValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCalc.Location = new System.Drawing.Point(393, 87);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(198, 100);
            this.buttonCalc.TabIndex = 0;
            this.buttonCalc.Text = "Hesapla";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // labelVize
            // 
            this.labelVize.AutoSize = true;
            this.labelVize.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelVize.Location = new System.Drawing.Point(116, 84);
            this.labelVize.Name = "labelVize";
            this.labelVize.Size = new System.Drawing.Size(72, 33);
            this.labelVize.TabIndex = 1;
            this.labelVize.Text = "Vize";
            // 
            // textBoxVize
            // 
            this.textBoxVize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxVize.Location = new System.Drawing.Point(201, 87);
            this.textBoxVize.Name = "textBoxVize";
            this.textBoxVize.Size = new System.Drawing.Size(100, 30);
            this.textBoxVize.TabIndex = 2;
            // 
            // labeVizeY
            // 
            this.labeVizeY.AutoSize = true;
            this.labeVizeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeVizeY.Location = new System.Drawing.Point(32, 154);
            this.labeVizeY.Name = "labeVizeY";
            this.labeVizeY.Size = new System.Drawing.Size(163, 33);
            this.labeVizeY.TabIndex = 3;
            this.labeVizeY.Text = "Vize Yüzde";
            // 
            // textBoxVizeY
            // 
            this.textBoxVizeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxVizeY.Location = new System.Drawing.Point(201, 157);
            this.textBoxVizeY.Name = "textBoxVizeY";
            this.textBoxVizeY.Size = new System.Drawing.Size(100, 30);
            this.textBoxVizeY.TabIndex = 4;
            // 
            // labelOrtalama
            // 
            this.labelOrtalama.AutoSize = true;
            this.labelOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrtalama.Location = new System.Drawing.Point(397, 278);
            this.labelOrtalama.Name = "labelOrtalama";
            this.labelOrtalama.Size = new System.Drawing.Size(161, 33);
            this.labelOrtalama.TabIndex = 5;
            this.labelOrtalama.Text = "Ortalama =";
            // 
            // labelOrtValue
            // 
            this.labelOrtValue.AutoSize = true;
            this.labelOrtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOrtValue.Location = new System.Drawing.Point(564, 278);
            this.labelOrtValue.Name = "labelOrtValue";
            this.labelOrtValue.Size = new System.Drawing.Size(31, 33);
            this.labelOrtValue.TabIndex = 6;
            this.labelOrtValue.Text = "0";
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFinal.Location = new System.Drawing.Point(116, 220);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(79, 33);
            this.labelFinal.TabIndex = 7;
            this.labelFinal.Text = "Final";
            // 
            // labelFinalY
            // 
            this.labelFinalY.AutoSize = true;
            this.labelFinalY.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFinalY.Location = new System.Drawing.Point(25, 279);
            this.labelFinalY.Name = "labelFinalY";
            this.labelFinalY.Size = new System.Drawing.Size(170, 33);
            this.labelFinalY.TabIndex = 8;
            this.labelFinalY.Text = "Final Yüzde";
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFinal.Location = new System.Drawing.Point(201, 223);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(100, 30);
            this.textBoxFinal.TabIndex = 9;
            // 
            // textBoxFinalY
            // 
            this.textBoxFinalY.Enabled = false;
            this.textBoxFinalY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFinalY.Location = new System.Drawing.Point(201, 282);
            this.textBoxFinalY.Name = "textBoxFinalY";
            this.textBoxFinalY.Size = new System.Drawing.Size(100, 30);
            this.textBoxFinalY.TabIndex = 10;
            // 
            // labelGecmeNotu
            // 
            this.labelGecmeNotu.AutoSize = true;
            this.labelGecmeNotu.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGecmeNotu.Location = new System.Drawing.Point(16, 336);
            this.labelGecmeNotu.Name = "labelGecmeNotu";
            this.labelGecmeNotu.Size = new System.Drawing.Size(179, 33);
            this.labelGecmeNotu.TabIndex = 11;
            this.labelGecmeNotu.Text = "Geçme Notu";
            // 
            // textBoxGecmeN
            // 
            this.textBoxGecmeN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGecmeN.Location = new System.Drawing.Point(201, 339);
            this.textBoxGecmeN.Name = "textBoxGecmeN";
            this.textBoxGecmeN.Size = new System.Drawing.Size(100, 30);
            this.textBoxGecmeN.TabIndex = 12;
            // 
            // labelDurum
            // 
            this.labelDurum.AutoSize = true;
            this.labelDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurum.Location = new System.Drawing.Point(397, 325);
            this.labelDurum.Name = "labelDurum";
            this.labelDurum.Size = new System.Drawing.Size(128, 33);
            this.labelDurum.TabIndex = 13;
            this.labelDurum.Text = "Durum =";
            // 
            // labelDurumValue
            // 
            this.labelDurumValue.AutoSize = true;
            this.labelDurumValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDurumValue.Location = new System.Drawing.Point(531, 325);
            this.labelDurumValue.Name = "labelDurumValue";
            this.labelDurumValue.Size = new System.Drawing.Size(25, 33);
            this.labelDurumValue.TabIndex = 14;
            this.labelDurumValue.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(201, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tam sayı değeri giriniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDurumValue);
            this.Controls.Add(this.labelDurum);
            this.Controls.Add(this.textBoxGecmeN);
            this.Controls.Add(this.labelGecmeNotu);
            this.Controls.Add(this.textBoxFinalY);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.labelFinalY);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.labelOrtValue);
            this.Controls.Add(this.labelOrtalama);
            this.Controls.Add(this.textBoxVizeY);
            this.Controls.Add(this.labeVizeY);
            this.Controls.Add(this.textBoxVize);
            this.Controls.Add(this.labelVize);
            this.Controls.Add(this.buttonCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelVize;
        private System.Windows.Forms.TextBox textBoxVize;
        private System.Windows.Forms.Label labeVizeY;
        private System.Windows.Forms.TextBox textBoxVizeY;
        private System.Windows.Forms.Label labelOrtalama;
        private System.Windows.Forms.Label labelOrtValue;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Label labelFinalY;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.TextBox textBoxFinalY;
        private System.Windows.Forms.Label labelGecmeNotu;
        private System.Windows.Forms.TextBox textBoxGecmeN;
        private System.Windows.Forms.Label labelDurum;
        private System.Windows.Forms.Label labelDurumValue;
        private System.Windows.Forms.Label label1;
    }
}

