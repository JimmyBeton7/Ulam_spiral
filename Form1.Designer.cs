namespace Ulam_spiral
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generuj_btn = new System.Windows.Forms.Button();
            this.zamknij_btn = new System.Windows.Forms.Button();
            this.zapisz_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.prime_only_btn = new System.Windows.Forms.RadioButton();
            this.all_btn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.density_cb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.all_prime_red_btn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.density_cb);
            this.groupBox1.Controls.Add(this.zapisz_btn);
            this.groupBox1.Controls.Add(this.zamknij_btn);
            this.groupBox1.Controls.Add(this.generuj_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 700);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(17, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter n";
            // 
            // generuj_btn
            // 
            this.generuj_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generuj_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generuj_btn.Location = new System.Drawing.Point(406, 20);
            this.generuj_btn.Name = "generuj_btn";
            this.generuj_btn.Size = new System.Drawing.Size(200, 48);
            this.generuj_btn.TabIndex = 2;
            this.generuj_btn.Text = "Generate spiral";
            this.generuj_btn.UseVisualStyleBackColor = true;
            this.generuj_btn.Click += new System.EventHandler(this.generuj_btn_Click);
            // 
            // zamknij_btn
            // 
            this.zamknij_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zamknij_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zamknij_btn.Location = new System.Drawing.Point(816, 18);
            this.zamknij_btn.Name = "zamknij_btn";
            this.zamknij_btn.Size = new System.Drawing.Size(178, 50);
            this.zamknij_btn.TabIndex = 3;
            this.zamknij_btn.Text = "Exit";
            this.zamknij_btn.UseVisualStyleBackColor = true;
            this.zamknij_btn.Click += new System.EventHandler(this.zamknij_btn_Click);
            // 
            // zapisz_btn
            // 
            this.zapisz_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zapisz_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapisz_btn.Location = new System.Drawing.Point(621, 19);
            this.zapisz_btn.Name = "zapisz_btn";
            this.zapisz_btn.Size = new System.Drawing.Size(178, 49);
            this.zapisz_btn.TabIndex = 4;
            this.zapisz_btn.Text = "Save as PNG";
            this.zapisz_btn.UseVisualStyleBackColor = true;
            this.zapisz_btn.Click += new System.EventHandler(this.zapisz_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 730);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // prime_only_btn
            // 
            this.prime_only_btn.AutoSize = true;
            this.prime_only_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prime_only_btn.Location = new System.Drawing.Point(6, 20);
            this.prime_only_btn.Name = "prime_only_btn";
            this.prime_only_btn.Size = new System.Drawing.Size(181, 20);
            this.prime_only_btn.TabIndex = 3;
            this.prime_only_btn.Text = "Show prime numbers only";
            this.prime_only_btn.UseVisualStyleBackColor = true;
            this.prime_only_btn.CheckedChanged += new System.EventHandler(this.prime_only_btn_CheckedChanged);
            // 
            // all_btn
            // 
            this.all_btn.AutoSize = true;
            this.all_btn.Checked = true;
            this.all_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.all_btn.Location = new System.Drawing.Point(6, 106);
            this.all_btn.Name = "all_btn";
            this.all_btn.Size = new System.Drawing.Size(133, 20);
            this.all_btn.TabIndex = 4;
            this.all_btn.TabStop = true;
            this.all_btn.Text = "Show all numbers";
            this.all_btn.UseVisualStyleBackColor = true;
            this.all_btn.CheckedChanged += new System.EventHandler(this.all_btn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.all_prime_red_btn);
            this.groupBox3.Controls.Add(this.all_btn);
            this.groupBox3.Controls.Add(this.prime_only_btn);
            this.groupBox3.Location = new System.Drawing.Point(729, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 132);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // density_cb
            // 
            this.density_cb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.density_cb.FormattingEnabled = true;
            this.density_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.density_cb.Location = new System.Drawing.Point(253, 40);
            this.density_cb.Name = "density_cb";
            this.density_cb.Size = new System.Drawing.Size(121, 28);
            this.density_cb.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(250, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Density";
            // 
            // all_prime_red_btn
            // 
            this.all_prime_red_btn.AutoSize = true;
            this.all_prime_red_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.all_prime_red_btn.Location = new System.Drawing.Point(6, 63);
            this.all_prime_red_btn.Name = "all_prime_red_btn";
            this.all_prime_red_btn.Size = new System.Drawing.Size(214, 20);
            this.all_prime_red_btn.TabIndex = 6;
            this.all_prime_red_btn.Text = "Show all numbers (prime in red)";
            this.all_prime_red_btn.UseVisualStyleBackColor = true;
            this.all_prime_red_btn.CheckedChanged += new System.EventHandler(this.all_prime_red_btn_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.linkLabel1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(729, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 218);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 107);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 190);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(246, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://en.wikipedia.org/wiki/Ulam_spiral";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Learn more here:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 871);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ulam spiral generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button generuj_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button zapisz_btn;
        private System.Windows.Forms.Button zamknij_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton prime_only_btn;
        private System.Windows.Forms.RadioButton all_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox density_cb;
        private System.Windows.Forms.RadioButton all_prime_red_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
    }
}

