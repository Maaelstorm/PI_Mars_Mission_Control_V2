namespace Mars_Mission_Control_Dev
{
    partial class Form3
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Eating");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Slepping");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Entertainment");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Private");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Health control");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Medical act");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Living", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Space suit");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Vehicule");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Exploration", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Briefing");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Debriefing");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Inside experiment");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Outside experiment");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Science", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Cleaning");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("LSS air system");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("LSS water system");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("LSS food system");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Power system");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Space suit");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Other");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Maintenance", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Sending message");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Receiving message");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Communication", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("LSS");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Power systems");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Communication systems");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Propulsion systems");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Habitat");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Space suit");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Vehicule");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Repair", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Emergency");
            this.label_acti = new System.Windows.Forms.Label();
            this.labelActi = new System.Windows.Forms.Label();
            this.jour_actuel = new System.Windows.Forms.Label();
            this.affichage_jour_actuel = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.heure_debut = new System.Windows.Forms.Label();
            this.minutes_debut = new System.Windows.Forms.Label();
            this.heure_fin = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.minutes_fin = new System.Windows.Forms.Label();
            this.descriptif = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.H_debut = new System.Windows.Forms.ComboBox();
            this.M_debut = new System.Windows.Forms.ComboBox();
            this.H_fin = new System.Windows.Forms.ComboBox();
            this.M_fin = new System.Windows.Forms.ComboBox();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.niveau3 = new System.Windows.Forms.Panel();
            this.nom_coord = new System.Windows.Forms.Label();
            this.nom_position = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_suppr = new System.Windows.Forms.Button();
            this.niveau3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_acti
            // 
            this.label_acti.AutoSize = true;
            this.label_acti.Location = new System.Drawing.Point(145, 55);
            this.label_acti.Name = "label_acti";
            this.label_acti.Size = new System.Drawing.Size(45, 13);
            this.label_acti.TabIndex = 11;
            this.label_acti.Text = "Activité ";
            // 
            // labelActi
            // 
            this.labelActi.AutoSize = true;
            this.labelActi.Location = new System.Drawing.Point(197, 55);
            this.labelActi.Name = "labelActi";
            this.labelActi.Size = new System.Drawing.Size(35, 13);
            this.labelActi.TabIndex = 12;
            this.labelActi.Text = "label2";
            // 
            // jour_actuel
            // 
            this.jour_actuel.AutoSize = true;
            this.jour_actuel.Location = new System.Drawing.Point(359, 55);
            this.jour_actuel.Name = "jour_actuel";
            this.jour_actuel.Size = new System.Drawing.Size(12, 13);
            this.jour_actuel.TabIndex = 14;
            this.jour_actuel.Text = "J";
            // 
            // affichage_jour_actuel
            // 
            this.affichage_jour_actuel.AutoSize = true;
            this.affichage_jour_actuel.Location = new System.Drawing.Point(283, 55);
            this.affichage_jour_actuel.Name = "affichage_jour_actuel";
            this.affichage_jour_actuel.Size = new System.Drawing.Size(69, 13);
            this.affichage_jour_actuel.TabIndex = 13;
            this.affichage_jour_actuel.Text = "Jour Actuel : ";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(13, 106);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(82, 13);
            this.type.TabIndex = 15;
            this.type.Text = "Type d\'activité :";
            // 
            // heure_debut
            // 
            this.heure_debut.AutoSize = true;
            this.heure_debut.Location = new System.Drawing.Point(283, 101);
            this.heure_debut.Name = "heure_debut";
            this.heure_debut.Size = new System.Drawing.Size(87, 13);
            this.heure_debut.TabIndex = 16;
            this.heure_debut.Text = "Heure de début :";
            // 
            // minutes_debut
            // 
            this.minutes_debut.AutoSize = true;
            this.minutes_debut.Location = new System.Drawing.Point(283, 131);
            this.minutes_debut.Name = "minutes_debut";
            this.minutes_debut.Size = new System.Drawing.Size(95, 13);
            this.minutes_debut.TabIndex = 17;
            this.minutes_debut.Text = "Minutes de début :";
            // 
            // heure_fin
            // 
            this.heure_fin.AutoSize = true;
            this.heure_fin.Location = new System.Drawing.Point(283, 161);
            this.heure_fin.Name = "heure_fin";
            this.heure_fin.Size = new System.Drawing.Size(71, 13);
            this.heure_fin.TabIndex = 18;
            this.heure_fin.Text = "Heure de fin :";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(283, 226);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(50, 13);
            this.position.TabIndex = 20;
            this.position.Text = "Position :";
            // 
            // minutes_fin
            // 
            this.minutes_fin.AutoSize = true;
            this.minutes_fin.Location = new System.Drawing.Point(283, 191);
            this.minutes_fin.Name = "minutes_fin";
            this.minutes_fin.Size = new System.Drawing.Size(79, 13);
            this.minutes_fin.TabIndex = 19;
            this.minutes_fin.Text = "Minutes de fin :";
            // 
            // descriptif
            // 
            this.descriptif.AutoSize = true;
            this.descriptif.Location = new System.Drawing.Point(283, 287);
            this.descriptif.Name = "descriptif";
            this.descriptif.Size = new System.Drawing.Size(66, 13);
            this.descriptif.TabIndex = 21;
            this.descriptif.Text = "Description :";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(101, 101);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Eating";
            treeNode1.Text = "Eating";
            treeNode2.Name = "Slepping";
            treeNode2.Text = "Slepping";
            treeNode3.Name = "Entertainment";
            treeNode3.Text = "Entertainment";
            treeNode4.Name = "Private";
            treeNode4.Text = "Private";
            treeNode5.Name = "Health control";
            treeNode5.Text = "Health control";
            treeNode6.Name = "Medical act";
            treeNode6.Text = "Medical act";
            treeNode7.Name = "Living";
            treeNode7.Text = "Living";
            treeNode8.Name = "Space suit";
            treeNode8.Text = "Space suit";
            treeNode9.Name = "Vehicule";
            treeNode9.Text = "Vehicule";
            treeNode10.Name = "Exploration";
            treeNode10.Text = "Exploration";
            treeNode11.Name = "Briefing";
            treeNode11.Text = "Briefing";
            treeNode12.Name = "Debriefing";
            treeNode12.Text = "Debriefing";
            treeNode13.Name = "Inside experiment";
            treeNode13.Text = "Inside experiment";
            treeNode14.Name = "Outside experiment";
            treeNode14.Text = "Outside experiment";
            treeNode15.Name = "Science";
            treeNode15.Text = "Science";
            treeNode16.Name = "Cleaning";
            treeNode16.Text = "Cleaning";
            treeNode17.Name = "LSS air system";
            treeNode17.Text = "LSS air system";
            treeNode18.Name = "LSS water system";
            treeNode18.Text = "LSS water system";
            treeNode19.Name = "LSS food system";
            treeNode19.Text = "LSS food system";
            treeNode20.Name = "Power system";
            treeNode20.Text = "Power system";
            treeNode21.Name = "Space suit";
            treeNode21.Text = "Space suit";
            treeNode22.Name = "Other";
            treeNode22.Text = "Other";
            treeNode23.Name = "Maintenance";
            treeNode23.Text = "Maintenance";
            treeNode24.Name = "Sending message";
            treeNode24.Text = "Sending message";
            treeNode25.Name = "Receiving message";
            treeNode25.Text = "Receiving message";
            treeNode26.Name = "Communication";
            treeNode26.Text = "Communication";
            treeNode27.Name = "LSS";
            treeNode27.Text = "LSS";
            treeNode28.Name = "Power systems";
            treeNode28.Text = "Power systems";
            treeNode29.Name = "Communication systems";
            treeNode29.Text = "Communication systems";
            treeNode30.Name = "Propulsion systems";
            treeNode30.Text = "Propulsion systems";
            treeNode31.Name = "Habitat";
            treeNode31.Text = "Habitat";
            treeNode32.Name = "Space suit";
            treeNode32.Text = "Space suit";
            treeNode33.Name = "Vehicule";
            treeNode33.Text = "Vehicule";
            treeNode34.Name = "Repair";
            treeNode34.Text = "Repair";
            treeNode35.Name = "Emergency";
            treeNode35.Text = "Emergency";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode15,
            treeNode23,
            treeNode26,
            treeNode34,
            treeNode35});
            this.treeView1.Size = new System.Drawing.Size(163, 369);
            this.treeView1.TabIndex = 22;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // H_debut
            // 
            this.H_debut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.H_debut.FormattingEnabled = true;
            this.H_debut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.H_debut.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.H_debut.Location = new System.Drawing.Point(424, 101);
            this.H_debut.Name = "H_debut";
            this.H_debut.Size = new System.Drawing.Size(121, 21);
            this.H_debut.TabIndex = 23;
            this.H_debut.SelectedIndexChanged += new System.EventHandler(this.H_debut_SelectedIndexChanged);
            // 
            // M_debut
            // 
            this.M_debut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.M_debut.FormattingEnabled = true;
            this.M_debut.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40"});
            this.M_debut.Location = new System.Drawing.Point(424, 129);
            this.M_debut.Name = "M_debut";
            this.M_debut.Size = new System.Drawing.Size(121, 21);
            this.M_debut.TabIndex = 24;
            // 
            // H_fin
            // 
            this.H_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.H_fin.FormattingEnabled = true;
            this.H_fin.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.H_fin.Location = new System.Drawing.Point(424, 157);
            this.H_fin.Name = "H_fin";
            this.H_fin.Size = new System.Drawing.Size(121, 21);
            this.H_fin.TabIndex = 25;
            this.H_fin.SelectedIndexChanged += new System.EventHandler(this.H_fin_SelectedIndexChanged);
            // 
            // M_fin
            // 
            this.M_fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.M_fin.FormattingEnabled = true;
            this.M_fin.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40"});
            this.M_fin.Location = new System.Drawing.Point(424, 185);
            this.M_fin.Name = "M_fin";
            this.M_fin.Size = new System.Drawing.Size(121, 21);
            this.M_fin.TabIndex = 26;
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.Location = new System.Drawing.Point(286, 423);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(132, 47);
            this.btn_confirmer.TabIndex = 27;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = true;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(424, 226);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(67, 20);
            this.textBoxX.TabIndex = 28;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBoxXY_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(556, 226);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(63, 20);
            this.textBoxY.TabIndex = 29;
            this.textBoxY.TextChanged += new System.EventHandler(this.textBoxXY_TextChanged);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(404, 229);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(14, 13);
            this.X.TabIndex = 30;
            this.X.Text = "X";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(531, 229);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(14, 13);
            this.Y.TabIndex = 31;
            this.Y.Text = "Y";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(424, 287);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(195, 96);
            this.description.TabIndex = 32;
            this.description.Text = "";
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(443, 423);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(129, 47);
            this.btn_annuler.TabIndex = 33;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // niveau3
            // 
            this.niveau3.Controls.Add(this.nom_coord);
            this.niveau3.Controls.Add(this.nom_position);
            this.niveau3.Controls.Add(this.M_fin);
            this.niveau3.Controls.Add(this.treeView1);
            this.niveau3.Controls.Add(this.type);
            this.niveau3.Controls.Add(this.btn_annuler);
            this.niveau3.Controls.Add(this.labelActi);
            this.niveau3.Controls.Add(this.affichage_jour_actuel);
            this.niveau3.Controls.Add(this.label_acti);
            this.niveau3.Controls.Add(this.description);
            this.niveau3.Controls.Add(this.jour_actuel);
            this.niveau3.Controls.Add(this.Y);
            this.niveau3.Controls.Add(this.heure_debut);
            this.niveau3.Controls.Add(this.X);
            this.niveau3.Controls.Add(this.minutes_debut);
            this.niveau3.Controls.Add(this.textBoxY);
            this.niveau3.Controls.Add(this.heure_fin);
            this.niveau3.Controls.Add(this.textBoxX);
            this.niveau3.Controls.Add(this.minutes_fin);
            this.niveau3.Controls.Add(this.btn_confirmer);
            this.niveau3.Controls.Add(this.position);
            this.niveau3.Controls.Add(this.descriptif);
            this.niveau3.Controls.Add(this.H_fin);
            this.niveau3.Controls.Add(this.H_debut);
            this.niveau3.Controls.Add(this.M_debut);
            this.niveau3.Location = new System.Drawing.Point(12, 12);
            this.niveau3.Name = "niveau3";
            this.niveau3.Size = new System.Drawing.Size(631, 508);
            this.niveau3.TabIndex = 34;
            // 
            // nom_coord
            // 
            this.nom_coord.AutoSize = true;
            this.nom_coord.Location = new System.Drawing.Point(284, 259);
            this.nom_coord.Name = "nom_coord";
            this.nom_coord.Size = new System.Drawing.Size(100, 13);
            this.nom_coord.TabIndex = 35;
            this.nom_coord.Text = "Nom de la position :";
            // 
            // nom_position
            // 
            this.nom_position.Location = new System.Drawing.Point(424, 253);
            this.nom_position.Name = "nom_position";
            this.nom_position.Size = new System.Drawing.Size(100, 20);
            this.nom_position.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mars_Mission_Control_Dev.Properties.Resources.nanedi_valles;
            this.pictureBox1.Location = new System.Drawing.Point(650, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 670);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_suppr
            // 
            this.btn_suppr.Location = new System.Drawing.Point(28, 538);
            this.btn_suppr.Name = "btn_suppr";
            this.btn_suppr.Size = new System.Drawing.Size(150, 70);
            this.btn_suppr.TabIndex = 36;
            this.btn_suppr.Text = "Supprimer l\'activité";
            this.btn_suppr.UseVisualStyleBackColor = true;
            this.btn_suppr.Click += new System.EventHandler(this.btn_suppr_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 750);
            this.Controls.Add(this.btn_suppr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.niveau3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.niveau3.ResumeLayout(false);
            this.niveau3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_acti;
        private System.Windows.Forms.Label labelActi;
        private System.Windows.Forms.Label jour_actuel;
        private System.Windows.Forms.Label affichage_jour_actuel;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label heure_debut;
        private System.Windows.Forms.Label minutes_debut;
        private System.Windows.Forms.Label heure_fin;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label minutes_fin;
        private System.Windows.Forms.Label descriptif;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox H_debut;
        private System.Windows.Forms.ComboBox M_debut;
        private System.Windows.Forms.ComboBox H_fin;
        private System.Windows.Forms.ComboBox M_fin;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Panel niveau3;
        private System.Windows.Forms.Label nom_coord;
        private System.Windows.Forms.TextBox nom_position;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_suppr;
    }
}