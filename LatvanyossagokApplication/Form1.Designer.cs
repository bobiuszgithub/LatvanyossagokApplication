
namespace LatvanyossagokApplication
{
    partial class LatvanyossagokApplication
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
            this.text_nev = new System.Windows.Forms.TextBox();
            this.numeric_lakossag = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lnev = new System.Windows.Forms.TextBox();
            this.cbox_varos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_ar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_latvanyossag = new System.Windows.Forms.Button();
            this.txt_leiras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_lakossag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ar)).BeginInit();
            this.SuspendLayout();
            // 
            // text_nev
            // 
            this.text_nev.Location = new System.Drawing.Point(70, 12);
            this.text_nev.Name = "text_nev";
            this.text_nev.Size = new System.Drawing.Size(120, 20);
            this.text_nev.TabIndex = 0;
            // 
            // numeric_lakossag
            // 
            this.numeric_lakossag.Location = new System.Drawing.Point(70, 38);
            this.numeric_lakossag.Name = "numeric_lakossag";
            this.numeric_lakossag.Size = new System.Drawing.Size(120, 20);
            this.numeric_lakossag.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nev:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "lakossag:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(70, 64);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "város felvétele";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(211, 12);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(231, 121);
            this.lbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "látványosság név:";
            // 
            // txt_lnev
            // 
            this.txt_lnev.Location = new System.Drawing.Point(111, 274);
            this.txt_lnev.Name = "txt_lnev";
            this.txt_lnev.Size = new System.Drawing.Size(120, 20);
            this.txt_lnev.TabIndex = 8;
            // 
            // cbox_varos
            // 
            this.cbox_varos.FormattingEnabled = true;
            this.cbox_varos.Location = new System.Drawing.Point(110, 355);
            this.cbox_varos.Name = "cbox_varos";
            this.cbox_varos.Size = new System.Drawing.Size(121, 21);
            this.cbox_varos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "város:";
            // 
            // nud_ar
            // 
            this.nud_ar.Location = new System.Drawing.Point(111, 329);
            this.nud_ar.Name = "nud_ar";
            this.nud_ar.Size = new System.Drawing.Size(120, 20);
            this.nud_ar.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ár:";
            // 
            // btn_latvanyossag
            // 
            this.btn_latvanyossag.Location = new System.Drawing.Point(111, 382);
            this.btn_latvanyossag.Name = "btn_latvanyossag";
            this.btn_latvanyossag.Size = new System.Drawing.Size(120, 23);
            this.btn_latvanyossag.TabIndex = 14;
            this.btn_latvanyossag.Text = "látványosság felvétele";
            this.btn_latvanyossag.UseVisualStyleBackColor = true;
            this.btn_latvanyossag.Click += new System.EventHandler(this.btn_latvanyossag_Click);
            // 
            // txt_leiras
            // 
            this.txt_leiras.Location = new System.Drawing.Point(111, 303);
            this.txt_leiras.Name = "txt_leiras";
            this.txt_leiras.Size = new System.Drawing.Size(249, 20);
            this.txt_leiras.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "leírás:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(403, 273);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 160);
            this.listBox1.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(508, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(231, 121);
            this.listBox2.TabIndex = 18;
            // 
            // LatvanyossagokApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_leiras);
            this.Controls.Add(this.btn_latvanyossag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_ar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_varos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lnev);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_lakossag);
            this.Controls.Add(this.text_nev);
            this.Name = "LatvanyossagokApplication";
            this.Text = "LatvanyossagokApplication";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_lakossag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nev;
        private System.Windows.Forms.NumericUpDown numeric_lakossag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lnev;
        private System.Windows.Forms.ComboBox cbox_varos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_ar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_latvanyossag;
        private System.Windows.Forms.TextBox txt_leiras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

