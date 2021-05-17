namespace WindowsFormsApp3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.Button();
            this.butonmo = new System.Windows.Forms.Button();
            this.butonln = new System.Windows.Forms.Button();
            this.butonsq = new System.Windows.Forms.Button();
            this.butondi = new System.Windows.Forms.Button();
            this.butoneg = new System.Windows.Forms.Button();
            this.butonin = new System.Windows.Forms.Button();
            this.buton0 = new System.Windows.Forms.Button();
            this.butonfa = new System.Windows.Forms.Button();
            this.butonmi = new System.Windows.Forms.Button();
            this.buton9 = new System.Windows.Forms.Button();
            this.buton8 = new System.Windows.Forms.Button();
            this.buton7 = new System.Windows.Forms.Button();
            this.butonpl = new System.Windows.Forms.Button();
            this.buton6 = new System.Windows.Forms.Button();
            this.buton5 = new System.Windows.Forms.Button();
            this.buton4 = new System.Windows.Forms.Button();
            this.butonof = new System.Windows.Forms.Button();
            this.buton3 = new System.Windows.Forms.Button();
            this.buton2 = new System.Windows.Forms.Button();
            this.buton1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.text);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(438, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.Black;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(12, 9);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(443, 76);
            this.text.TabIndex = 0;
            this.text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button);
            this.panel2.Controls.Add(this.butonmo);
            this.panel2.Controls.Add(this.butonln);
            this.panel2.Controls.Add(this.butonsq);
            this.panel2.Controls.Add(this.butondi);
            this.panel2.Controls.Add(this.butoneg);
            this.panel2.Controls.Add(this.butonin);
            this.panel2.Controls.Add(this.buton0);
            this.panel2.Controls.Add(this.butonfa);
            this.panel2.Controls.Add(this.butonmi);
            this.panel2.Controls.Add(this.buton9);
            this.panel2.Controls.Add(this.buton8);
            this.panel2.Controls.Add(this.buton7);
            this.panel2.Controls.Add(this.butonpl);
            this.panel2.Controls.Add(this.buton6);
            this.panel2.Controls.Add(this.buton5);
            this.panel2.Controls.Add(this.buton4);
            this.panel2.Controls.Add(this.butonof);
            this.panel2.Controls.Add(this.buton3);
            this.panel2.Controls.Add(this.buton2);
            this.panel2.Controls.Add(this.buton1);
            this.panel2.Location = new System.Drawing.Point(0, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 461);
            this.panel2.TabIndex = 1;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.LightSalmon;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(454, 451);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(10, 10);
            this.button.TabIndex = 20;
            this.button.UseVisualStyleBackColor = false;
            this.button.Visible = false;
            // 
            // butonmo
            // 
            this.butonmo.BackColor = System.Drawing.Color.Orange;
            this.butonmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonmo.Location = new System.Drawing.Point(249, 381);
            this.butonmo.Name = "butonmo";
            this.butonmo.Size = new System.Drawing.Size(75, 71);
            this.butonmo.TabIndex = 19;
            this.butonmo.Text = "%";
            this.butonmo.UseVisualStyleBackColor = false;
            this.butonmo.Click += new System.EventHandler(this.butonmo_Click);
            // 
            // butonln
            // 
            this.butonln.BackColor = System.Drawing.Color.DimGray;
            this.butonln.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonln.Location = new System.Drawing.Point(136, 381);
            this.butonln.Name = "butonln";
            this.butonln.Size = new System.Drawing.Size(75, 71);
            this.butonln.TabIndex = 18;
            this.butonln.Text = ".";
            this.butonln.UseVisualStyleBackColor = false;
            this.butonln.Click += new System.EventHandler(this.butonln_Click);
            // 
            // butonsq
            // 
            this.butonsq.BackColor = System.Drawing.Color.Orange;
            this.butonsq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonsq.Location = new System.Drawing.Point(28, 381);
            this.butonsq.Name = "butonsq";
            this.butonsq.Size = new System.Drawing.Size(75, 71);
            this.butonsq.TabIndex = 17;
            this.butonsq.Text = "SQRT";
            this.butonsq.UseVisualStyleBackColor = false;
            this.butonsq.Click += new System.EventHandler(this.butonsq_Click);
            // 
            // butondi
            // 
            this.butondi.BackColor = System.Drawing.Color.Orange;
            this.butondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butondi.Location = new System.Drawing.Point(249, 297);
            this.butondi.Name = "butondi";
            this.butondi.Size = new System.Drawing.Size(75, 71);
            this.butondi.TabIndex = 16;
            this.butondi.Text = "/";
            this.butondi.UseVisualStyleBackColor = false;
            this.butondi.Click += new System.EventHandler(this.butondi_Click);
            // 
            // butoneg
            // 
            this.butoneg.BackColor = System.Drawing.Color.Orange;
            this.butoneg.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butoneg.Location = new System.Drawing.Point(365, 297);
            this.butoneg.Name = "butoneg";
            this.butoneg.Size = new System.Drawing.Size(75, 71);
            this.butoneg.TabIndex = 15;
            this.butoneg.Text = "=";
            this.butoneg.UseVisualStyleBackColor = false;
            this.butoneg.Click += new System.EventHandler(this.butoneg_Click);
            // 
            // butonin
            // 
            this.butonin.BackColor = System.Drawing.Color.Orange;
            this.butonin.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonin.Location = new System.Drawing.Point(365, 381);
            this.butonin.Name = "butonin";
            this.butonin.Size = new System.Drawing.Size(75, 71);
            this.butonin.TabIndex = 14;
            this.butonin.Text = "*";
            this.butonin.UseVisualStyleBackColor = false;
            this.butonin.Click += new System.EventHandler(this.butonin_Click);
            // 
            // buton0
            // 
            this.buton0.BackColor = System.Drawing.Color.DimGray;
            this.buton0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buton0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton0.Location = new System.Drawing.Point(136, 297);
            this.buton0.Name = "buton0";
            this.buton0.Size = new System.Drawing.Size(75, 71);
            this.buton0.TabIndex = 13;
            this.buton0.Text = "0";
            this.buton0.UseVisualStyleBackColor = false;
            this.buton0.Click += new System.EventHandler(this.buton0_Click);
            // 
            // butonfa
            // 
            this.butonfa.BackColor = System.Drawing.Color.Orange;
            this.butonfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonfa.Location = new System.Drawing.Point(28, 297);
            this.butonfa.Name = "butonfa";
            this.butonfa.Size = new System.Drawing.Size(75, 71);
            this.butonfa.TabIndex = 12;
            this.butonfa.Text = "!";
            this.butonfa.UseVisualStyleBackColor = false;
            this.butonfa.Click += new System.EventHandler(this.butonfa_Click);
            // 
            // butonmi
            // 
            this.butonmi.BackColor = System.Drawing.Color.Orange;
            this.butonmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonmi.Location = new System.Drawing.Point(365, 204);
            this.butonmi.Name = "butonmi";
            this.butonmi.Size = new System.Drawing.Size(75, 71);
            this.butonmi.TabIndex = 11;
            this.butonmi.Text = "-";
            this.butonmi.UseVisualStyleBackColor = false;
            this.butonmi.Click += new System.EventHandler(this.butonmi_Click);
            // 
            // buton9
            // 
            this.buton9.BackColor = System.Drawing.Color.DimGray;
            this.buton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton9.Location = new System.Drawing.Point(249, 204);
            this.buton9.Name = "buton9";
            this.buton9.Size = new System.Drawing.Size(75, 71);
            this.buton9.TabIndex = 10;
            this.buton9.Text = "9";
            this.buton9.UseVisualStyleBackColor = false;
            this.buton9.Click += new System.EventHandler(this.buton9_Click);
            // 
            // buton8
            // 
            this.buton8.BackColor = System.Drawing.Color.DimGray;
            this.buton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton8.Location = new System.Drawing.Point(136, 204);
            this.buton8.Name = "buton8";
            this.buton8.Size = new System.Drawing.Size(75, 71);
            this.buton8.TabIndex = 9;
            this.buton8.Text = "8";
            this.buton8.UseVisualStyleBackColor = false;
            this.buton8.Click += new System.EventHandler(this.buton8_Click);
            // 
            // buton7
            // 
            this.buton7.BackColor = System.Drawing.Color.DimGray;
            this.buton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton7.Location = new System.Drawing.Point(28, 204);
            this.buton7.Name = "buton7";
            this.buton7.Size = new System.Drawing.Size(75, 71);
            this.buton7.TabIndex = 8;
            this.buton7.Text = "7";
            this.buton7.UseVisualStyleBackColor = false;
            this.buton7.Click += new System.EventHandler(this.buton7_Click);
            // 
            // butonpl
            // 
            this.butonpl.BackColor = System.Drawing.Color.Orange;
            this.butonpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonpl.Location = new System.Drawing.Point(365, 109);
            this.butonpl.Name = "butonpl";
            this.butonpl.Size = new System.Drawing.Size(75, 71);
            this.butonpl.TabIndex = 7;
            this.butonpl.Text = "+";
            this.butonpl.UseVisualStyleBackColor = false;
            this.butonpl.Click += new System.EventHandler(this.butonpl_Click);
            // 
            // buton6
            // 
            this.buton6.BackColor = System.Drawing.Color.DimGray;
            this.buton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton6.Location = new System.Drawing.Point(249, 109);
            this.buton6.Name = "buton6";
            this.buton6.Size = new System.Drawing.Size(75, 71);
            this.buton6.TabIndex = 6;
            this.buton6.Text = "6";
            this.buton6.UseVisualStyleBackColor = false;
            this.buton6.Click += new System.EventHandler(this.buton6_Click);
            // 
            // buton5
            // 
            this.buton5.BackColor = System.Drawing.Color.DimGray;
            this.buton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton5.Location = new System.Drawing.Point(136, 109);
            this.buton5.Name = "buton5";
            this.buton5.Size = new System.Drawing.Size(75, 71);
            this.buton5.TabIndex = 5;
            this.buton5.Text = "5";
            this.buton5.UseVisualStyleBackColor = false;
            this.buton5.Click += new System.EventHandler(this.buton5_Click);
            // 
            // buton4
            // 
            this.buton4.BackColor = System.Drawing.Color.DimGray;
            this.buton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton4.Location = new System.Drawing.Point(28, 109);
            this.buton4.Name = "buton4";
            this.buton4.Size = new System.Drawing.Size(75, 71);
            this.buton4.TabIndex = 4;
            this.buton4.Text = "4";
            this.buton4.UseVisualStyleBackColor = false;
            this.buton4.Click += new System.EventHandler(this.buton4_Click);
            // 
            // butonof
            // 
            this.butonof.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonof.Location = new System.Drawing.Point(365, 15);
            this.butonof.Name = "butonof";
            this.butonof.Size = new System.Drawing.Size(75, 71);
            this.butonof.TabIndex = 3;
            this.butonof.Text = "ON/OF";
            this.butonof.UseVisualStyleBackColor = true;
            this.butonof.Click += new System.EventHandler(this.butonof_Click);
            // 
            // buton3
            // 
            this.buton3.BackColor = System.Drawing.Color.DimGray;
            this.buton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton3.Location = new System.Drawing.Point(249, 15);
            this.buton3.Name = "buton3";
            this.buton3.Size = new System.Drawing.Size(75, 71);
            this.buton3.TabIndex = 2;
            this.buton3.Text = "3";
            this.buton3.UseVisualStyleBackColor = false;
            this.buton3.Click += new System.EventHandler(this.buton3_Click);
            // 
            // buton2
            // 
            this.buton2.BackColor = System.Drawing.Color.DimGray;
            this.buton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton2.Location = new System.Drawing.Point(136, 15);
            this.buton2.Name = "buton2";
            this.buton2.Size = new System.Drawing.Size(75, 71);
            this.buton2.TabIndex = 1;
            this.buton2.Text = "2";
            this.buton2.UseVisualStyleBackColor = false;
            this.buton2.Click += new System.EventHandler(this.buton2_Click);
            // 
            // buton1
            // 
            this.buton1.BackColor = System.Drawing.Color.DimGray;
            this.buton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buton1.Location = new System.Drawing.Point(28, 15);
            this.buton1.Name = "buton1";
            this.buton1.Size = new System.Drawing.Size(75, 71);
            this.buton1.TabIndex = 0;
            this.buton1.Text = "1";
            this.buton1.UseVisualStyleBackColor = false;
            this.buton1.Click += new System.EventHandler(this.buton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butoneg;
        private System.Windows.Forms.Button butonin;
        private System.Windows.Forms.Button buton0;
        private System.Windows.Forms.Button butonfa;
        private System.Windows.Forms.Button butonmi;
        private System.Windows.Forms.Button buton9;
        private System.Windows.Forms.Button buton8;
        private System.Windows.Forms.Button buton7;
        private System.Windows.Forms.Button butonpl;
        private System.Windows.Forms.Button buton6;
        private System.Windows.Forms.Button buton5;
        private System.Windows.Forms.Button buton4;
        private System.Windows.Forms.Button butonof;
        private System.Windows.Forms.Button buton3;
        private System.Windows.Forms.Button buton2;
        private System.Windows.Forms.Button buton1;
        private System.Windows.Forms.Button butonmo;
        private System.Windows.Forms.Button butonln;
        private System.Windows.Forms.Button butonsq;
        private System.Windows.Forms.Button butondi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button;
    }
}

