
namespace Card_Identifier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.Label();
            this.twoOfSpades = new System.Windows.Forms.PictureBox();
            this.sixOfDiamonds = new System.Windows.Forms.PictureBox();
            this.joker = new System.Windows.Forms.PictureBox();
            this.aceOfHearts = new System.Windows.Forms.PictureBox();
            this.kingOfSpades = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.twoOfSpades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixOfDiamonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingOfSpades)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HeaderLabel.Location = new System.Drawing.Point(344, 67);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(280, 24);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Click a Card to See It\'s Name";
            this.HeaderLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(302, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.Desktop;
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.outputBox.Location = new System.Drawing.Point(199, 322);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(555, 64);
            this.outputBox.TabIndex = 2;
            this.outputBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputBox.Click += new System.EventHandler(this.outputBox_Click);
            // 
            // twoOfSpades
            // 
            this.twoOfSpades.BackColor = System.Drawing.SystemColors.Control;
            this.twoOfSpades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoOfSpades.Image = ((System.Drawing.Image)(resources.GetObject("twoOfSpades.Image")));
            this.twoOfSpades.Location = new System.Drawing.Point(199, 147);
            this.twoOfSpades.Name = "twoOfSpades";
            this.twoOfSpades.Size = new System.Drawing.Size(52, 72);
            this.twoOfSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.twoOfSpades.TabIndex = 3;
            this.twoOfSpades.TabStop = false;
            this.twoOfSpades.Click += new System.EventHandler(this.twoOfSpades_Click);
            // 
            // sixOfDiamonds
            // 
            this.sixOfDiamonds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sixOfDiamonds.Image = ((System.Drawing.Image)(resources.GetObject("sixOfDiamonds.Image")));
            this.sixOfDiamonds.Location = new System.Drawing.Point(582, 147);
            this.sixOfDiamonds.Name = "sixOfDiamonds";
            this.sixOfDiamonds.Size = new System.Drawing.Size(52, 72);
            this.sixOfDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sixOfDiamonds.TabIndex = 4;
            this.sixOfDiamonds.TabStop = false;
            this.sixOfDiamonds.Click += new System.EventHandler(this.sixOfDiamonds_Click);
            // 
            // joker
            // 
            this.joker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joker.Image = ((System.Drawing.Image)(resources.GetObject("joker.Image")));
            this.joker.Location = new System.Drawing.Point(449, 147);
            this.joker.Name = "joker";
            this.joker.Size = new System.Drawing.Size(52, 72);
            this.joker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.joker.TabIndex = 5;
            this.joker.TabStop = false;
            this.joker.Click += new System.EventHandler(this.joker_Click);
            // 
            // aceOfHearts
            // 
            this.aceOfHearts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aceOfHearts.Image = ((System.Drawing.Image)(resources.GetObject("aceOfHearts.Image")));
            this.aceOfHearts.Location = new System.Drawing.Point(322, 147);
            this.aceOfHearts.Name = "aceOfHearts";
            this.aceOfHearts.Size = new System.Drawing.Size(52, 72);
            this.aceOfHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aceOfHearts.TabIndex = 6;
            this.aceOfHearts.TabStop = false;
            this.aceOfHearts.Click += new System.EventHandler(this.aceOfHearts_Click);
            // 
            // kingOfSpades
            // 
            this.kingOfSpades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kingOfSpades.Image = ((System.Drawing.Image)(resources.GetObject("kingOfSpades.Image")));
            this.kingOfSpades.Location = new System.Drawing.Point(702, 147);
            this.kingOfSpades.Name = "kingOfSpades";
            this.kingOfSpades.Size = new System.Drawing.Size(52, 72);
            this.kingOfSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.kingOfSpades.TabIndex = 7;
            this.kingOfSpades.TabStop = false;
            this.kingOfSpades.Click += new System.EventHandler(this.kingOfSpades_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitButton.Location = new System.Drawing.Point(423, 430);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 50);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1600, 831);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.kingOfSpades);
            this.Controls.Add(this.aceOfHearts);
            this.Controls.Add(this.joker);
            this.Controls.Add(this.sixOfDiamonds);
            this.Controls.Add(this.twoOfSpades);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Card Identifier";
            ((System.ComponentModel.ISupportInitialize)(this.twoOfSpades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sixOfDiamonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceOfHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingOfSpades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputBox;
        private System.Windows.Forms.PictureBox twoOfSpades;
        private System.Windows.Forms.PictureBox sixOfDiamonds;
        private System.Windows.Forms.PictureBox joker;
        private System.Windows.Forms.PictureBox aceOfHearts;
        private System.Windows.Forms.PictureBox kingOfSpades;
        private System.Windows.Forms.Button exitButton;
    }
}

