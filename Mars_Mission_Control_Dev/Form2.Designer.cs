namespace Mars_Mission_Control_Dev
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tagjourSelec = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tagjourSelec2 = new System.Windows.Forms.Label();
            this.label_nom_acti = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.RichTextBox();
            this.tb_compteRendu = new System.Windows.Forms.RichTextBox();
            this.panelActivites = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.horaires = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelActivites2 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelActivites3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horaires)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(380, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Jour précédent";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.jourPrecedent_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(693, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Jour suivant";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.jourSuivant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jour Actuel : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tagjourSelec
            // 
            this.tagjourSelec.AutoSize = true;
            this.tagjourSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagjourSelec.Location = new System.Drawing.Point(130, 7);
            this.tagjourSelec.Name = "tagjourSelec";
            this.tagjourSelec.Size = new System.Drawing.Size(19, 24);
            this.tagjourSelec.TabIndex = 7;
            this.tagjourSelec.Text = "J";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(547, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Retour au calendrier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.retourCalendrier_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_insert.FlatAppearance.BorderSize = 2;
            this.btn_insert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(368, 496);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(140, 60);
            this.btn_insert.TabIndex = 38;
            this.btn_insert.Text = "Insérer une activité";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.inserer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Compte Rendu du Jour";
            // 
            // tagjourSelec2
            // 
            this.tagjourSelec2.AutoSize = true;
            this.tagjourSelec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagjourSelec2.Location = new System.Drawing.Point(180, 120);
            this.tagjourSelec2.Name = "tagjourSelec2";
            this.tagjourSelec2.Size = new System.Drawing.Size(17, 20);
            this.tagjourSelec2.TabIndex = 42;
            this.tagjourSelec2.Text = "J";
            // 
            // label_nom_acti
            // 
            this.label_nom_acti.AutoSize = true;
            this.label_nom_acti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nom_acti.Location = new System.Drawing.Point(7, 5);
            this.label_nom_acti.Name = "label_nom_acti";
            this.label_nom_acti.Size = new System.Drawing.Size(60, 20);
            this.label_nom_acti.TabIndex = 43;
            this.label_nom_acti.Text = "Activité";
            // 
            // tb_Description
            // 
            this.tb_Description.Enabled = false;
            this.tb_Description.Location = new System.Drawing.Point(7, 28);
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(225, 52);
            this.tb_Description.TabIndex = 44;
            this.tb_Description.Text = "";
            // 
            // tb_compteRendu
            // 
            this.tb_compteRendu.Location = new System.Drawing.Point(7, 145);
            this.tb_compteRendu.Name = "tb_compteRendu";
            this.tb_compteRendu.Size = new System.Drawing.Size(392, 123);
            this.tb_compteRendu.TabIndex = 45;
            this.tb_compteRendu.Text = "";
            this.tb_compteRendu.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // panelActivites
            // 
            this.panelActivites.Location = new System.Drawing.Point(51, 6);
            this.panelActivites.Name = "panelActivites";
            this.panelActivites.Size = new System.Drawing.Size(261, 844);
            this.panelActivites.TabIndex = 46;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(323, 842);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.horaires);
            this.tabPage1.Controls.Add(this.panelActivites);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(315, 816);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spationaute 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // horaires
            // 
            this.horaires.ErrorImage = ((System.Drawing.Image)(resources.GetObject("horaires.ErrorImage")));
            this.horaires.Image = global::Mars_Mission_Control_Dev.Properties.Resources.Horaires;
            this.horaires.InitialImage = ((System.Drawing.Image)(resources.GetObject("horaires.InitialImage")));
            this.horaires.Location = new System.Drawing.Point(4, 1);
            this.horaires.Name = "horaires";
            this.horaires.Size = new System.Drawing.Size(41, 807);
            this.horaires.TabIndex = 47;
            this.horaires.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.panelActivites2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(315, 816);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spationaute 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::Mars_Mission_Control_Dev.Properties.Resources.Horaires;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 807);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // panelActivites2
            // 
            this.panelActivites2.Location = new System.Drawing.Point(51, 6);
            this.panelActivites2.Name = "panelActivites2";
            this.panelActivites2.Size = new System.Drawing.Size(261, 803);
            this.panelActivites2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.panelActivites3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(315, 816);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Spationaute 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Mars_Mission_Control_Dev.Properties.Resources.Horaires;
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 807);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // panelActivites3
            // 
            this.panelActivites3.Location = new System.Drawing.Point(51, 6);
            this.panelActivites3.Name = "panelActivites3";
            this.panelActivites3.Size = new System.Drawing.Size(261, 810);
            this.panelActivites3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_nom_acti);
            this.panel1.Controls.Add(this.tb_compteRendu);
            this.panel1.Controls.Add(this.tagjourSelec2);
            this.panel1.Controls.Add(this.tb_Description);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(368, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 276);
            this.panel1.TabIndex = 49;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Mars_Mission_Control_Dev.Properties.Resources.transport1066;
            this.pictureBox3.Location = new System.Drawing.Point(673, 640);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(209, 214);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tagjourSelec);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(501, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 40);
            this.panel2.TabIndex = 51;
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = global::Mars_Mission_Control_Dev.Properties.Resources.space_ship29;
            this.pictureBox4.Image = global::Mars_Mission_Control_Dev.Properties.Resources.space_ship29;
            this.pictureBox4.InitialImage = global::Mars_Mission_Control_Dev.Properties.Resources.space_ship29;
            this.pictureBox4.Location = new System.Drawing.Point(501, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1006;
            this.pictureBox4.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 862);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.horaires)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tagjourSelec;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tagjourSelec2;
        private System.Windows.Forms.Label label_nom_acti;
        private System.Windows.Forms.RichTextBox tb_Description;
        private System.Windows.Forms.RichTextBox tb_compteRendu;
        private System.Windows.Forms.Panel panelActivites;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelActivites2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelActivites3;
        private System.Windows.Forms.PictureBox horaires;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;

        public System.EventHandler comboBox1_SelectedIndexChanged { get; set; }

        public System.EventHandler textBox2_TextChanged { get; set; }
    }
}