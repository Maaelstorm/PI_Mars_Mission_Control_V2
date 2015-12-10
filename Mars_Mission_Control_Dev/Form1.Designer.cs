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
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
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
			this.label1.Click += new System.EventHandler(this.label1_Click);
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
			this.listBox1.Size = new System.Drawing.Size(120, 48);
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
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(13, 521);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(865, 329);
			this.panel2.TabIndex = 8;
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
			this.ClientSize = new System.Drawing.Size(894, 862);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_jour_precedents);
			this.Controls.Add(this.button2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}

