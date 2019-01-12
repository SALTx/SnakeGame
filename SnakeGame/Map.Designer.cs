namespace SnakeGame
{
    partial class Map
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
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prevBTN = new System.Windows.Forms.Button();
            this.nextBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // previewBox
            // 
            this.previewBox.BackgroundImage = global::SnakeGame.Resources1.grassBackground_01;
            this.previewBox.Location = new System.Drawing.Point(12, 14);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(425, 400);
            this.previewBox.TabIndex = 0;
            this.previewBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map: Grass";
            // 
            // prevBTN
            // 
            this.prevBTN.Location = new System.Drawing.Point(241, 431);
            this.prevBTN.Name = "prevBTN";
            this.prevBTN.Size = new System.Drawing.Size(75, 23);
            this.prevBTN.TabIndex = 2;
            this.prevBTN.Text = "◄ Previous";
            this.prevBTN.UseVisualStyleBackColor = true;
            this.prevBTN.Click += new System.EventHandler(this.prevBTN_Click);
            // 
            // nextBTN
            // 
            this.nextBTN.Location = new System.Drawing.Point(362, 431);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(75, 23);
            this.nextBTN.TabIndex = 3;
            this.nextBTN.Text = "Next ►";
            this.nextBTN.UseVisualStyleBackColor = true;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(302, 471);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(75, 23);
            this.updateBTN.TabIndex = 5;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 506);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.prevBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.previewBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Map";
            this.Text = "Map";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prevBTN;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.Button updateBTN;
    }
}