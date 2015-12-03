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
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Eating");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Slepping");
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Entertainment");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Private");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Health control");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Medical act");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Living", new System.Windows.Forms.TreeNode[] {
            treeNode71,
            treeNode72,
            treeNode73,
            treeNode74,
            treeNode75,
            treeNode76});
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Space suit");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Vehicule");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Exploration", new System.Windows.Forms.TreeNode[] {
            treeNode78,
            treeNode79});
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Briefing");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Debriefing");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Inside experiment");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Outside experiment");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Science", new System.Windows.Forms.TreeNode[] {
            treeNode80,
            treeNode81,
            treeNode82,
            treeNode83,
            treeNode84});
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Cleaning");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("LSS air system");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("LSS water system");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("LSS food system");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Power system");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Space suit");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Other");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Maintenance", new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode87,
            treeNode88,
            treeNode89,
            treeNode90,
            treeNode91,
            treeNode92});
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("Sending message");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("Receiving message");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("Communication", new System.Windows.Forms.TreeNode[] {
            treeNode94,
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("LSS");
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("Power systems");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("Communication systems");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("Propulsion systems");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("Habitat");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("Space suit");
            System.Windows.Forms.TreeNode treeNode103 = new System.Windows.Forms.TreeNode("Vehicule");
            System.Windows.Forms.TreeNode treeNode104 = new System.Windows.Forms.TreeNode("Repair", new System.Windows.Forms.TreeNode[] {
            treeNode97,
            treeNode98,
            treeNode99,
            treeNode100,
            treeNode101,
            treeNode102,
            treeNode103});
            System.Windows.Forms.TreeNode treeNode105 = new System.Windows.Forms.TreeNode("Emergency");
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
            treeNode71.Name = "Eating";
            treeNode71.Text = "Eating";
            treeNode72.Name = "Slepping";
            treeNode72.Text = "Slepping";
            treeNode73.Name = "Entertainment";
            treeNode73.Text = "Entertainment";
            treeNode74.Name = "Private";
            treeNode74.Text = "Private";
            treeNode75.Name = "Health control";
            treeNode75.Text = "Health control";
            treeNode76.Name = "Medical act";
            treeNode76.Text = "Medical act";
            treeNode77.Name = "Living";
            treeNode77.Text = "Living";
            treeNode78.Name = "Space suit";
            treeNode78.Text = "Space suit";
            treeNode79.Name = "Vehicule";
            treeNode79.Text = "Vehicule";
            treeNode80.Name = "Exploration";
            treeNode80.Text = "Exploration";
            treeNode81.Name = "Briefing";
            treeNode81.Text = "Briefing";
            treeNode82.Name = "Debriefing";
            treeNode82.Text = "Debriefing";
            treeNode83.Name = "Inside experiment";
            treeNode83.Text = "Inside experiment";
            treeNode84.Name = "Outside experiment";
            treeNode84.Text = "Outside experiment";
            treeNode85.Name = "Science";
            treeNode85.Text = "Science";
            treeNode86.Name = "Cleaning";
            treeNode86.Text = "Cleaning";
            treeNode87.Name = "LSS air system";
            treeNode87.Text = "LSS air system";
            treeNode88.Name = "LSS water system";
            treeNode88.Text = "LSS water system";
            treeNode89.Name = "LSS food system";
            treeNode89.Text = "LSS food system";
            treeNode90.Name = "Power system";
            treeNode90.Text = "Power system";
            treeNode91.Name = "Space suit";
            treeNode91.Text = "Space suit";
            treeNode92.Name = "Other";
            treeNode92.Text = "Other";
            treeNode93.Name = "Maintenance";
            treeNode93.Text = "Maintenance";
            treeNode94.Name = "Sending message";
            treeNode94.Text = "Sending message";
            treeNode95.Name = "Receiving message";
            treeNode95.Text = "Receiving message";
            treeNode96.Name = "Communication";
            treeNode96.Text = "Communication";
            treeNode97.Name = "LSS";
            treeNode97.Text = "LSS";
            treeNode98.Name = "Power systems";
            treeNode98.Text = "Power systems";
            treeNode99.Name = "Communication systems";
            treeNode99.Text = "Communication systems";
            treeNode100.Name = "Propulsion systems";
            treeNode100.Text = "Propulsion systems";
            treeNode101.Name = "Habitat";
            treeNode101.Text = "Habitat";
            treeNode102.Name = "Space suit";
            treeNode102.Text = "Space suit";
            treeNode103.Name = "Vehicule";
            treeNode103.Text = "Vehicule";
            treeNode104.Name = "Repair";
            treeNode104.Text = "Repair";
            treeNode105.Name = "Emergency";
            treeNode105.Text = "Emergency";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode77,
            treeNode85,
            treeNode93,
            treeNode96,
            treeNode104,
            treeNode105});
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
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(556, 226);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(63, 20);
            this.textBoxY.TabIndex = 29;
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
            this.ClientSize = new System.Drawing.Size(984, 912);
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