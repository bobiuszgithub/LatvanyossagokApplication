
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
            this.btn_addvaros = new System.Windows.Forms.Button();
            this.lbox_varosok = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lnev = new System.Windows.Forms.TextBox();
            this.cbox_varos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_ar = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_latvanyossag = new System.Windows.Forms.Button();
            this.txt_leiras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbox_varos_latvanyossagok = new System.Windows.Forms.ListBox();
            this.btn_varos_edit = new System.Windows.Forms.Button();
            this.btn_varos_delete = new System.Windows.Forms.Button();
            this.teszt = new System.Windows.Forms.Label();
            this.nup_test = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_lakossag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_test)).BeginInit();
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
            // btn_addvaros
            // 
            this.btn_addvaros.Location = new System.Drawing.Point(70, 64);
            this.btn_addvaros.Name = "btn_addvaros";
            this.btn_addvaros.Size = new System.Drawing.Size(120, 23);
            this.btn_addvaros.TabIndex = 6;
            this.btn_addvaros.Text = "város felvétele";
            this.btn_addvaros.UseVisualStyleBackColor = true;
            this.btn_addvaros.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbox_varosok
            // 
            this.lbox_varosok.FormattingEnabled = true;
            this.lbox_varosok.Location = new System.Drawing.Point(211, 12);
            this.lbox_varosok.Name = "lbox_varosok";
            this.lbox_varosok.Size = new System.Drawing.Size(231, 121);
            this.lbox_varosok.TabIndex = 7;
            this.lbox_varosok.SelectedIndexChanged += new System.EventHandler(this.lbox_varosok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "látványosság név:";
            // 
            // txt_lnev
            // 
            this.txt_lnev.Location = new System.Drawing.Point(111, 191);
            this.txt_lnev.Name = "txt_lnev";
            this.txt_lnev.Size = new System.Drawing.Size(120, 20);
            this.txt_lnev.TabIndex = 8;
            // 
            // cbox_varos
            // 
            this.cbox_varos.FormattingEnabled = true;
            this.cbox_varos.Location = new System.Drawing.Point(110, 272);
            this.cbox_varos.Name = "cbox_varos";
            this.cbox_varos.Size = new System.Drawing.Size(121, 21);
            this.cbox_varos.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "város:";
            // 
            // nud_ar
            // 
            this.nud_ar.Location = new System.Drawing.Point(111, 246);
            this.nud_ar.Name = "nud_ar";
            this.nud_ar.Size = new System.Drawing.Size(120, 20);
            this.nud_ar.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ár:";
            // 
            // btn_latvanyossag
            // 
            this.btn_latvanyossag.Location = new System.Drawing.Point(111, 299);
            this.btn_latvanyossag.Name = "btn_latvanyossag";
            this.btn_latvanyossag.Size = new System.Drawing.Size(120, 23);
            this.btn_latvanyossag.TabIndex = 14;
            this.btn_latvanyossag.Text = "látványosság felvétele";
            this.btn_latvanyossag.UseVisualStyleBackColor = true;
            this.btn_latvanyossag.Click += new System.EventHandler(this.btn_latvanyossag_Click);
            // 
            // txt_leiras
            // 
            this.txt_leiras.Location = new System.Drawing.Point(111, 220);
            this.txt_leiras.Name = "txt_leiras";
            this.txt_leiras.Size = new System.Drawing.Size(249, 20);
            this.txt_leiras.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "leírás:";
            // 
            // lbox_varos_latvanyossagok
            // 
            this.lbox_varos_latvanyossagok.FormattingEnabled = true;
            this.lbox_varos_latvanyossagok.Location = new System.Drawing.Point(469, 12);
            this.lbox_varos_latvanyossagok.Name = "lbox_varos_latvanyossagok";
            this.lbox_varos_latvanyossagok.Size = new System.Drawing.Size(231, 121);
            this.lbox_varos_latvanyossagok.TabIndex = 18;
            // 
            // btn_varos_edit
            // 
            this.btn_varos_edit.Location = new System.Drawing.Point(70, 122);
            this.btn_varos_edit.Name = "btn_varos_edit";
            this.btn_varos_edit.Size = new System.Drawing.Size(120, 23);
            this.btn_varos_edit.TabIndex = 19;
            this.btn_varos_edit.Text = "város módosítása";
            this.btn_varos_edit.UseVisualStyleBackColor = true;
            this.btn_varos_edit.Click += new System.EventHandler(this.btn_varos_edit_Click);
            // 
            // btn_varos_delete
            // 
            this.btn_varos_delete.Location = new System.Drawing.Point(70, 93);
            this.btn_varos_delete.Name = "btn_varos_delete";
            this.btn_varos_delete.Size = new System.Drawing.Size(120, 23);
            this.btn_varos_delete.TabIndex = 20;
            this.btn_varos_delete.Text = "város törlése";
            this.btn_varos_delete.UseVisualStyleBackColor = true;
            this.btn_varos_delete.Click += new System.EventHandler(this.btn_varos_delete_Click);
            // 
            // teszt
            // 
            this.teszt.AutoSize = true;
            this.teszt.Location = new System.Drawing.Point(522, 153);
            this.teszt.Name = "teszt";
            this.teszt.Size = new System.Drawing.Size(29, 13);
            this.teszt.TabIndex = 22;
            this.teszt.Text = "teszt";
            // 
            // nup_test
            // 
            this.nup_test.Location = new System.Drawing.Point(557, 151);
            this.nup_test.Name = "nup_test";
            this.nup_test.Size = new System.Drawing.Size(120, 20);
            this.nup_test.TabIndex = 23;
            this.nup_test.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LatvanyossagokApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nup_test);
            this.Controls.Add(this.teszt);
            this.Controls.Add(this.btn_varos_delete);
            this.Controls.Add(this.btn_varos_edit);
            this.Controls.Add(this.lbox_varos_latvanyossagok);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_leiras);
            this.Controls.Add(this.btn_latvanyossag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_ar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbox_varos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_lnev);
            this.Controls.Add(this.lbox_varosok);
            this.Controls.Add(this.btn_addvaros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeric_lakossag);
            this.Controls.Add(this.text_nev);
            this.Name = "LatvanyossagokApplication";
            this.Text = "LatvanyossagokApplication";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_lakossag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nev;
        private System.Windows.Forms.NumericUpDown numeric_lakossag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_addvaros;
        private System.Windows.Forms.ListBox lbox_varosok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lnev;
        private System.Windows.Forms.ComboBox cbox_varos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_ar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_latvanyossag;
        private System.Windows.Forms.TextBox txt_leiras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbox_varos_latvanyossagok;
        private System.Windows.Forms.Button btn_varos_edit;
        private System.Windows.Forms.Button btn_varos_delete;
        private System.Windows.Forms.Label teszt;
        private System.Windows.Forms.NumericUpDown nup_test;
    }
}

