namespace Mars_Mission_Control_Dev
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_jour_precedents = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_activitesExt = new System.Windows.Forms.Panel();
            this.cb_activiteExt = new System.Windows.Forms.CheckBox();
            this.tb_rechercheDescAct = new System.Windows.Forms.TextBox();
            this.lb_rechercheDsAct = new System.Windows.Forms.Label();
            this.clb_activites = new System.Windows.Forms.CheckedListBox();
            this.btn_goRecherche = new System.Windows.Forms.Button();
            this.tb_jourFin = new System.Windows.Forms.TextBox();
            this.lb_jourFin = new System.Windows.Forms.Label();
            this.tb_jourDebut = new System.Windows.Forms.TextBox();
            this.lb_jourDebut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cb_activitesExt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Broadway", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mars Calendar\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(725, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Jours suivants";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.joursSuivants_Click);
            // 
            // btn_jour_precedents
            // 
            this.btn_jour_precedents.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_jour_precedents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_jour_precedents.Location = new System.Drawing.Point(43, 465);
            this.btn_jour_precedents.Name = "btn_jour_precedents";
            this.btn_jour_precedents.Size = new System.Drawing.Size(130, 40);
            this.btn_jour_precedents.TabIndex = 3;
            this.btn_jour_precedents.Text = "Jours précédents";
            this.btn_jour_precedents.UseVisualStyleBackColor = true;
            this.btn_jour_precedents.Click += new System.EventHandler(this.joursPrecedents_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Une mission avec :";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Neil Armstrong",
            "Edwin Aldrin",
            "Pete Conrad"});
            this.listBox1.Location = new System.Drawing.Point(237, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 32);
            this.listBox1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 131);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::Mars_Mission_Control_Dev.Properties.Resources.space_ship29;
            this.pictureBox2.Image = global::Mars_Mission_Control_Dev.Properties.Resources.space_ship29;
            this.pictureBox2.InitialImage = global::Mars_Mission_Control_Dev.Properties.Resources.space_ship29;
            this.pictureBox2.Location = new System.Drawing.Point(802, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Mars_Mission_Control_Dev.Properties.Resources.image_mars;
            this.pictureBox1.Image = global::Mars_Mission_Control_Dev.Properties.Resources.image_mars;
            this.pictureBox1.InitialImage = global::Mars_Mission_Control_Dev.Properties.Resources.image_mars;
            this.pictureBox1.Location = new System.Drawing.Point(734, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cb_activitesExt
            // 
            this.cb_activitesExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cb_activitesExt.Controls.Add(this.cb_activiteExt);
            this.cb_activitesExt.Controls.Add(this.tb_rechercheDescAct);
            this.cb_activitesExt.Controls.Add(this.lb_rechercheDsAct);
            this.cb_activitesExt.Controls.Add(this.clb_activites);
            this.cb_activitesExt.Controls.Add(this.btn_goRecherche);
            this.cb_activitesExt.Controls.Add(this.tb_jourFin);
            this.cb_activitesExt.Controls.Add(this.lb_jourFin);
            this.cb_activitesExt.Controls.Add(this.tb_jourDebut);
            this.cb_activitesExt.Controls.Add(this.lb_jourDebut);
            this.cb_activitesExt.Controls.Add(this.label4);
            this.cb_activitesExt.Controls.Add(this.label3);
            this.cb_activitesExt.Location = new System.Drawing.Point(13, 521);
            this.cb_activitesExt.Name = "cb_activitesExt";
            this.cb_activitesExt.Size = new System.Drawing.Size(865, 329);
            this.cb_activitesExt.TabIndex = 8;
            this.cb_activitesExt.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cb_activiteExt
            // 
            this.cb_activiteExt.AutoSize = true;
            this.cb_activiteExt.Location = new System.Drawing.Point(19, 107);
            this.cb_activiteExt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_activiteExt.Name = "cb_activiteExt";
            this.cb_activiteExt.Size = new System.Drawing.Size(123, 17);
            this.cb_activiteExt.TabIndex = 21;
            this.cb_activiteExt.Text = "activites en exterieur";
            this.cb_activiteExt.UseVisualStyleBackColor = true;
            // 
            // tb_rechercheDescAct
            // 
            this.tb_rechercheDescAct.Location = new System.Drawing.Point(18, 200);
            this.tb_rechercheDescAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_rechercheDescAct.Multiline = true;
            this.tb_rechercheDescAct.Name = "tb_rechercheDescAct";
            this.tb_rechercheDescAct.Size = new System.Drawing.Size(183, 36);
            this.tb_rechercheDescAct.TabIndex = 20;
            this.tb_rechercheDescAct.TextChanged += new System.EventHandler(this.tb_rechercheDescAct_TextChanged);
            // 
            // lb_rechercheDsAct
            // 
            this.lb_rechercheDsAct.AutoSize = true;
            this.lb_rechercheDsAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_rechercheDsAct.Location = new System.Drawing.Point(17, 178);
            this.lb_rechercheDsAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rechercheDsAct.Name = "lb_rechercheDsAct";
            this.lb_rechercheDsAct.Size = new System.Drawing.Size(278, 18);
            this.lb_rechercheDsAct.TabIndex = 19;
            this.lb_rechercheDsAct.Text = "rechercher dans la descripton de l\'activité";
            // 
            // clb_activites
            // 
            this.clb_activites.FormattingEnabled = true;
            this.clb_activites.Location = new System.Drawing.Point(19, 134);
            this.clb_activites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clb_activites.Name = "clb_activites";
            this.clb_activites.Size = new System.Drawing.Size(183, 19);
            this.clb_activites.TabIndex = 18;
            // 
            // btn_goRecherche
            // 
            this.btn_goRecherche.Location = new System.Drawing.Point(88, 252);
            this.btn_goRecherche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_goRecherche.Name = "btn_goRecherche";
            this.btn_goRecherche.Size = new System.Drawing.Size(32, 19);
            this.btn_goRecherche.TabIndex = 12;
            this.btn_goRecherche.Text = "GO";
            this.btn_goRecherche.UseVisualStyleBackColor = true;
            this.btn_goRecherche.Click += new System.EventHandler(this.btn_goRecherche_Click);
            // 
            // tb_jourFin
            // 
            this.tb_jourFin.Location = new System.Drawing.Point(177, 84);
            this.tb_jourFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_jourFin.Name = "tb_jourFin";
            this.tb_jourFin.Size = new System.Drawing.Size(24, 20);
            this.tb_jourFin.TabIndex = 5;
            // 
            // lb_jourFin
            // 
            this.lb_jourFin.AutoSize = true;
            this.lb_jourFin.Location = new System.Drawing.Point(117, 84);
            this.lb_jourFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_jourFin.Name = "lb_jourFin";
            this.lb_jourFin.Size = new System.Drawing.Size(53, 13);
            this.lb_jourFin.TabIndex = 4;
            this.lb_jourFin.Text = "jour de fin";
            // 
            // tb_jourDebut
            // 
            this.tb_jourDebut.Location = new System.Drawing.Point(88, 84);
            this.tb_jourDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_jourDebut.Name = "tb_jourDebut";
            this.tb_jourDebut.Size = new System.Drawing.Size(24, 20);
            this.tb_jourDebut.TabIndex = 3;
            // 
            // lb_jourDebut
            // 
            this.lb_jourDebut.AutoSize = true;
            this.lb_jourDebut.Location = new System.Drawing.Point(18, 84);
            this.lb_jourDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_jourDebut.Name = "lb_jourDebut";
            this.lb_jourDebut.Size = new System.Drawing.Size(69, 13);
            this.lb_jourDebut.TabIndex = 2;
            this.lb_jourDebut.Text = "jour de début";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(15, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "sélection periode";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Recherches";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 849);
            this.Controls.Add(this.cb_activitesExt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_jour_precedents);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cb_activitesExt.ResumeLayout(false);
            this.cb_activitesExt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_jour_precedents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel cb_activitesExt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_jourFin;
        private System.Windows.Forms.Label lb_jourFin;
        private System.Windows.Forms.TextBox tb_jourDebut;
        private System.Windows.Forms.Label lb_jourDebut;
        private System.Windows.Forms.Button btn_goRecherche;
        private System.Windows.Forms.CheckedListBox clb_activites;
        private System.Windows.Forms.TextBox tb_rechercheDescAct;
        private System.Windows.Forms.Label lb_rechercheDsAct;
        private System.Windows.Forms.CheckBox cb_activiteExt;
    }
}

