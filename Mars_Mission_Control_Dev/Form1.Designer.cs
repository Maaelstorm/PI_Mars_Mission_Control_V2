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
            this.cb_activitesExt = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_rechercheDsAct = new System.Windows.Forms.Label();
            this.tb_rechercheCR = new System.Windows.Forms.TextBox();
            this.tb_rechercheDescAct = new System.Windows.Forms.TextBox();
            this.lb_rechercheCR = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_jourDebut = new System.Windows.Forms.Label();
            this.tb_jourDebut = new System.Windows.Forms.TextBox();
            this.cb_activiteExt = new System.Windows.Forms.CheckBox();
            this.lb_jourFin = new System.Windows.Forms.Label();
            this.tb_jourFin = new System.Windows.Forms.TextBox();
            this.clb_activites = new System.Windows.Forms.CheckedListBox();
            this.btn_goRecherche = new System.Windows.Forms.Button();
            this.btn_leaveApp = new System.Windows.Forms.Button();
            this.lb_resultatsRecherche = new System.Windows.Forms.Label();
            this.btn_retour_recherche = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.cb_activitesExt.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Broadway", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mars Calendar\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 465);
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
            this.btn_jour_precedents.Location = new System.Drawing.Point(584, 465);
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
            this.label2.Location = new System.Drawing.Point(62, 54);
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
            this.listBox1.Location = new System.Drawing.Point(237, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 48);
            this.listBox1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 106);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cb_activitesExt
            // 
            this.cb_activitesExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cb_activitesExt.Controls.Add(this.panel3);
            this.cb_activitesExt.Controls.Add(this.panel2);
            this.cb_activitesExt.Controls.Add(this.btn_goRecherche);
            this.cb_activitesExt.Location = new System.Drawing.Point(13, 518);
            this.cb_activitesExt.Name = "cb_activitesExt";
            this.cb_activitesExt.Size = new System.Drawing.Size(865, 160);
            this.cb_activitesExt.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lb_rechercheDsAct);
            this.panel3.Controls.Add(this.tb_rechercheCR);
            this.panel3.Controls.Add(this.tb_rechercheDescAct);
            this.panel3.Controls.Add(this.lb_rechercheCR);
            this.panel3.Location = new System.Drawing.Point(320, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 139);
            this.panel3.TabIndex = 25;
            // 
            // lb_rechercheDsAct
            // 
            this.lb_rechercheDsAct.AutoSize = true;
            this.lb_rechercheDsAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_rechercheDsAct.Location = new System.Drawing.Point(20, 15);
            this.lb_rechercheDsAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rechercheDsAct.Name = "lb_rechercheDsAct";
            this.lb_rechercheDsAct.Size = new System.Drawing.Size(292, 18);
            this.lb_rechercheDsAct.TabIndex = 19;
            this.lb_rechercheDsAct.Text = "Rechercher dans la descripton de l\'activité :";
            // 
            // tb_rechercheCR
            // 
            this.tb_rechercheCR.Location = new System.Drawing.Point(20, 89);
            this.tb_rechercheCR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_rechercheCR.Name = "tb_rechercheCR";
            this.tb_rechercheCR.Size = new System.Drawing.Size(183, 20);
            this.tb_rechercheCR.TabIndex = 23;
            // 
            // tb_rechercheDescAct
            // 
            this.tb_rechercheDescAct.Location = new System.Drawing.Point(20, 36);
            this.tb_rechercheDescAct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_rechercheDescAct.Name = "tb_rechercheDescAct";
            this.tb_rechercheDescAct.Size = new System.Drawing.Size(183, 20);
            this.tb_rechercheDescAct.TabIndex = 20;
            this.tb_rechercheDescAct.TextChanged += new System.EventHandler(this.tb_rechercheDescAct_TextChanged);
            // 
            // lb_rechercheCR
            // 
            this.lb_rechercheCR.AutoSize = true;
            this.lb_rechercheCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lb_rechercheCR.Location = new System.Drawing.Point(20, 65);
            this.lb_rechercheCR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rechercheCR.Name = "lb_rechercheCR";
            this.lb_rechercheCR.Size = new System.Drawing.Size(327, 18);
            this.lb_rechercheCR.TabIndex = 22;
            this.lb_rechercheCR.Text = "Rechercher dans le compte rendu de la journée :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lb_jourDebut);
            this.panel2.Controls.Add(this.tb_jourDebut);
            this.panel2.Controls.Add(this.cb_activiteExt);
            this.panel2.Controls.Add(this.lb_jourFin);
            this.panel2.Controls.Add(this.tb_jourFin);
            this.panel2.Controls.Add(this.clb_activites);
            this.panel2.Location = new System.Drawing.Point(15, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 139);
            this.panel2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(19, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sélectionner une période :";
            // 
            // lb_jourDebut
            // 
            this.lb_jourDebut.AutoSize = true;
            this.lb_jourDebut.Location = new System.Drawing.Point(20, 44);
            this.lb_jourDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_jourDebut.Name = "lb_jourDebut";
            this.lb_jourDebut.Size = new System.Drawing.Size(78, 13);
            this.lb_jourDebut.TabIndex = 2;
            this.lb_jourDebut.Text = "Jour de début :";
            // 
            // tb_jourDebut
            // 
            this.tb_jourDebut.Location = new System.Drawing.Point(110, 44);
            this.tb_jourDebut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_jourDebut.Name = "tb_jourDebut";
            this.tb_jourDebut.Size = new System.Drawing.Size(24, 20);
            this.tb_jourDebut.TabIndex = 3;
            // 
            // cb_activiteExt
            // 
            this.cb_activiteExt.AutoSize = true;
            this.cb_activiteExt.Location = new System.Drawing.Point(22, 89);
            this.cb_activiteExt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_activiteExt.Name = "cb_activiteExt";
            this.cb_activiteExt.Size = new System.Drawing.Size(119, 17);
            this.cb_activiteExt.TabIndex = 21;
            this.cb_activiteExt.Text = "Activité en extérieur";
            this.cb_activiteExt.UseVisualStyleBackColor = true;
            this.cb_activiteExt.CheckedChanged += new System.EventHandler(this.cb_activiteExt_CheckedChanged);
            // 
            // lb_jourFin
            // 
            this.lb_jourFin.AutoSize = true;
            this.lb_jourFin.Location = new System.Drawing.Point(20, 64);
            this.lb_jourFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_jourFin.Name = "lb_jourFin";
            this.lb_jourFin.Size = new System.Drawing.Size(62, 13);
            this.lb_jourFin.TabIndex = 4;
            this.lb_jourFin.Text = "Jour de fin :";
            // 
            // tb_jourFin
            // 
            this.tb_jourFin.Location = new System.Drawing.Point(110, 64);
            this.tb_jourFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_jourFin.Name = "tb_jourFin";
            this.tb_jourFin.Size = new System.Drawing.Size(24, 20);
            this.tb_jourFin.TabIndex = 5;
            // 
            // clb_activites
            // 
            this.clb_activites.FormattingEnabled = true;
            this.clb_activites.Location = new System.Drawing.Point(21, 109);
            this.clb_activites.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clb_activites.Name = "clb_activites";
            this.clb_activites.Size = new System.Drawing.Size(183, 4);
            this.clb_activites.TabIndex = 18;
            this.clb_activites.SelectedIndexChanged += new System.EventHandler(this.clb_activites_SelectedIndexChanged);
            // 
            // btn_goRecherche
            // 
            this.btn_goRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goRecherche.Location = new System.Drawing.Point(738, 47);
            this.btn_goRecherche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_goRecherche.Name = "btn_goRecherche";
            this.btn_goRecherche.Size = new System.Drawing.Size(123, 50);
            this.btn_goRecherche.TabIndex = 12;
            this.btn_goRecherche.Text = "lancer la recherche";
            this.btn_goRecherche.UseVisualStyleBackColor = true;
            this.btn_goRecherche.Click += new System.EventHandler(this.btn_goRecherche_Click);
            // 
            // btn_leaveApp
            // 
            this.btn_leaveApp.BackColor = System.Drawing.Color.IndianRed;
            this.btn_leaveApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leaveApp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_leaveApp.Location = new System.Drawing.Point(50, 465);
            this.btn_leaveApp.Name = "btn_leaveApp";
            this.btn_leaveApp.Size = new System.Drawing.Size(151, 40);
            this.btn_leaveApp.TabIndex = 9;
            this.btn_leaveApp.Text = "Quitter l\'application";
            this.btn_leaveApp.UseVisualStyleBackColor = false;
            this.btn_leaveApp.Click += new System.EventHandler(this.btn_leaveApp_Click);
            // 
            // lb_resultatsRecherche
            // 
            this.lb_resultatsRecherche.AutoSize = true;
            this.lb_resultatsRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resultatsRecherche.Location = new System.Drawing.Point(30, 121);
            this.lb_resultatsRecherche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_resultatsRecherche.Name = "lb_resultatsRecherche";
            this.lb_resultatsRecherche.Size = new System.Drawing.Size(223, 24);
            this.lb_resultatsRecherche.TabIndex = 10;
            this.lb_resultatsRecherche.Text = "Résultats de la recherche";
            this.lb_resultatsRecherche.Visible = false;
            // 
            // btn_retour_recherche
            // 
            this.btn_retour_recherche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_retour_recherche.Location = new System.Drawing.Point(764, 127);
            this.btn_retour_recherche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_retour_recherche.Name = "btn_retour_recherche";
            this.btn_retour_recherche.Size = new System.Drawing.Size(74, 24);
            this.btn_retour_recherche.TabIndex = 11;
            this.btn_retour_recherche.Text = "retour";
            this.btn_retour_recherche.UseVisualStyleBackColor = true;
            this.btn_retour_recherche.Visible = false;
            this.btn_retour_recherche.Click += new System.EventHandler(this.btn_retour_recherche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 691);
            this.Controls.Add(this.btn_retour_recherche);
            this.Controls.Add(this.lb_resultatsRecherche);
            this.Controls.Add(this.btn_leaveApp);
            this.Controls.Add(this.cb_activitesExt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_jour_precedents);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cb_activitesExt.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_jour_precedents;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel cb_activitesExt;
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
        private System.Windows.Forms.TextBox tb_rechercheCR;
        private System.Windows.Forms.Label lb_rechercheCR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_leaveApp;
        private System.Windows.Forms.Label lb_resultatsRecherche;
        private System.Windows.Forms.Button btn_retour_recherche;

    }
}

