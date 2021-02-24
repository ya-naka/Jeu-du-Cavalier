
namespace Cavalier_V1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMarcheArriere = new System.Windows.Forms.Button();
            this.buttonAbandoner = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.règleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentçaMarcheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "A vous de jouer ! ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nouvelle partie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMarcheArriere
            // 
            this.buttonMarcheArriere.Location = new System.Drawing.Point(501, 271);
            this.buttonMarcheArriere.Name = "buttonMarcheArriere";
            this.buttonMarcheArriere.Size = new System.Drawing.Size(94, 23);
            this.buttonMarcheArriere.TabIndex = 2;
            this.buttonMarcheArriere.Text = "Marche Arrière";
            this.buttonMarcheArriere.UseVisualStyleBackColor = true;
            this.buttonMarcheArriere.Visible = false;
            this.buttonMarcheArriere.Click += new System.EventHandler(this.buttonMarcheArriere_Click);
            // 
            // buttonAbandoner
            // 
            this.buttonAbandoner.Location = new System.Drawing.Point(501, 346);
            this.buttonAbandoner.Name = "buttonAbandoner";
            this.buttonAbandoner.Size = new System.Drawing.Size(94, 23);
            this.buttonAbandoner.TabIndex = 3;
            this.buttonAbandoner.Text = "Abandonner";
            this.buttonAbandoner.UseVisualStyleBackColor = true;
            this.buttonAbandoner.Visible = false;
            this.buttonAbandoner.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(475, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliquez sur une case de votre choix pour commencer ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 20F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(203, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 33);
            this.label3.TabIndex = 5;
            this.label3.Text = "IMPASSE !!";
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
            this.menuStrip1.TabIndex = 10;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 577);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAbandoner);
            this.Controls.Add(this.buttonMarcheArriere);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(673, 616);
            this.MinimumSize = new System.Drawing.Size(673, 616);
            this.Name = "Form3";
            this.Text = "Jeu";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMarcheArriere;
        private System.Windows.Forms.Button buttonAbandoner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem règleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentçaMarcheToolStripMenuItem;
    }
}