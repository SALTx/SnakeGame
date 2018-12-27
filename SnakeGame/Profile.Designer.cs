namespace SnakeGame
{
    partial class Profile
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
            this.label2 = new System.Windows.Forms.Label();
            this.profileHighscoreLBL = new System.Windows.Forms.Label();
            this.profileNameTB = new System.Windows.Forms.TextBox();
            this.updateBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Highscore:";
            // 
            // profileHighscoreLBL
            // 
            this.profileHighscoreLBL.AutoSize = true;
            this.profileHighscoreLBL.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileHighscoreLBL.Location = new System.Drawing.Point(130, 71);
            this.profileHighscoreLBL.Name = "profileHighscoreLBL";
            this.profileHighscoreLBL.Size = new System.Drawing.Size(20, 19);
            this.profileHighscoreLBL.TabIndex = 2;
            this.profileHighscoreLBL.Text = "0";
            // 
            // profileNameTB
            // 
            this.profileNameTB.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileNameTB.Location = new System.Drawing.Point(134, 25);
            this.profileNameTB.Name = "profileNameTB";
            this.profileNameTB.Size = new System.Drawing.Size(100, 26);
            this.profileNameTB.TabIndex = 3;
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(24, 119);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(75, 23);
            this.updateBTN.TabIndex = 4;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            // 
            // closeBTN
            // 
            this.closeBTN.Location = new System.Drawing.Point(149, 119);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 5;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(256, 160);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.profileNameTB);
            this.Controls.Add(this.profileHighscoreLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label profileHighscoreLBL;
        private System.Windows.Forms.TextBox profileNameTB;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button closeBTN;
    }
}