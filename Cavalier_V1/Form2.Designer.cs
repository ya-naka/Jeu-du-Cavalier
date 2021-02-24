
namespace Cavalier_V1
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
            this.label1 = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb64 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentçaMarcheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNouvellePartie = new System.Windows.Forms.Button();
            this.btnRejouer = new System.Windows.Forms.Button();
            this.btnAléatoire = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.lblImpasse = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(6, 19);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(31, 17);
            this.rb1.TabIndex = 3;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(43, 19);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(31, 17);
            this.rb5.TabIndex = 4;
            this.rb5.TabStop = true;
            this.rb5.Text = "5";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb64
            // 
            this.rb64.AutoSize = true;
            this.rb64.Location = new System.Drawing.Point(80, 19);
            this.rb64.Name = "rb64";
            this.rb64.Size = new System.Drawing.Size(62, 17);
            this.rb64.TabIndex = 5;
            this.rb64.TabStop = true;
            this.rb64.Text = "Aucune";
            this.rb64.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.rb64);
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Location = new System.Drawing.Point(91, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 40);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enjambée";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(67, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(268, 458);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 40);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Temps entre chaque enjambée";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.règleToolStripMenuItem,
            this.commentçaMarcheToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // règleToolStripMenuItem
            // 
            this.règleToolStripMenuItem.Name = "règleToolStripMenuItem";
            this.règleToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.règleToolStripMenuItem.Text = "Règle";
            this.règleToolStripMenuItem.Click += new System.EventHandler(this.règleToolStripMenuItem_Click);
            // 
            // commentçaMarcheToolStripMenuItem
            // 
            this.commentçaMarcheToolStripMenuItem.Name = "commentçaMarcheToolStripMenuItem";
            this.commentçaMarcheToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.commentçaMarcheToolStripMenuItem.Text = "Comment ça marche ? ";
            this.commentçaMarcheToolStripMenuItem.Click += new System.EventHandler(this.commentçaMarcheToolStripMenuItem_Click);
            // 
            // btnNouvellePartie
            // 
            this.btnNouvellePartie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouvellePartie.Location = new System.Drawing.Point(482, 259);
            this.btnNouvellePartie.Name = "btnNouvellePartie";
            this.btnNouvellePartie.Size = new System.Drawing.Size(139, 23);
            this.btnNouvellePartie.TabIndex = 10;
            this.btnNouvellePartie.Text = "Nouvelle partie ";
            this.btnNouvellePartie.UseVisualStyleBackColor = true;
            this.btnNouvellePartie.Click += new System.EventHandler(this.nouvellePartie);
            // 
            // btnRejouer
            // 
            this.btnRejouer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRejouer.Location = new System.Drawing.Point(482, 288);
            this.btnRejouer.Name = "btnRejouer";
            this.btnRejouer.Size = new System.Drawing.Size(139, 23);
            this.btnRejouer.TabIndex = 11;
            this.btnRejouer.Text = "Rejouer ";
            this.btnRejouer.UseVisualStyleBackColor = true;
            this.btnRejouer.Visible = false;
            this.btnRejouer.Click += new System.EventHandler(this.rejouer);
            // 
            // btnAléatoire
            // 
            this.btnAléatoire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAléatoire.Location = new System.Drawing.Point(171, 513);
            this.btnAléatoire.Name = "btnAléatoire";
            this.btnAléatoire.Size = new System.Drawing.Size(185, 23);
            this.btnAléatoire.TabIndex = 12;
            this.btnAléatoire.Text = "Aléatoire";
            this.btnAléatoire.UseVisualStyleBackColor = true;
            this.btnAléatoire.Click += new System.EventHandler(this.commencerPartie);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.Location = new System.Drawing.Point(482, 368);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(139, 23);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.pause);
            // 
            // lblImpasse
            // 
            this.lblImpasse.AutoSize = true;
            this.lblImpasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpasse.Location = new System.Drawing.Point(480, 170);
            this.lblImpasse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImpasse.Name = "lblImpasse";
            this.lblImpasse.Size = new System.Drawing.Size(158, 31);
            this.lblImpasse.TabIndex = 14;
            this.lblImpasse.Text = "IMPASSE !";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 577);
            this.Controls.Add(this.lblImpasse);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnAléatoire);
            this.Controls.Add(this.btnRejouer);
            this.Controls.Add(this.btnNouvellePartie);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(673, 616);
            this.MinimumSize = new System.Drawing.Size(673, 616);
            this.Name = "Form2";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb64;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem règleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentçaMarcheToolStripMenuItem;
        private System.Windows.Forms.Button btnNouvellePartie;
        private System.Windows.Forms.Button btnRejouer;
        private System.Windows.Forms.Button btnAléatoire;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Label lblImpasse;
    }
}