namespace SnakeGame
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.appearanceGB = new System.Windows.Forms.GroupBox();
            this.foodColorCB = new System.Windows.Forms.ComboBox();
            this.bodyColorCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.headColorCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.applyBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.shapeGB = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.foodShapeSquare = new System.Windows.Forms.RadioButton();
            this.foodShapeCircle = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.snakeShapeSquare = new System.Windows.Forms.RadioButton();
            this.snakeShapeCircle = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.difficultyGB = new System.Windows.Forms.GroupBox();
            this.hardRadio = new System.Windows.Forms.RadioButton();
            this.mediumRadio = new System.Windows.Forms.RadioButton();
            this.easyRadio = new System.Windows.Forms.RadioButton();
            this.miscGB = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.appearanceGB.SuspendLayout();
            this.shapeGB.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.difficultyGB.SuspendLayout();
            this.miscGB.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // appearanceGB
            // 
            this.appearanceGB.Controls.Add(this.foodColorCB);
            this.appearanceGB.Controls.Add(this.bodyColorCB);
            this.appearanceGB.Controls.Add(this.label4);
            this.appearanceGB.Controls.Add(this.headColorCB);
            this.appearanceGB.Controls.Add(this.label2);
            this.appearanceGB.Controls.Add(this.label1);
            this.appearanceGB.Location = new System.Drawing.Point(12, 22);
            this.appearanceGB.Name = "appearanceGB";
            this.appearanceGB.Size = new System.Drawing.Size(200, 121);
            this.appearanceGB.TabIndex = 0;
            this.appearanceGB.TabStop = false;
            this.appearanceGB.Text = "Colors";
            // 
            // foodColorCB
            // 
            this.foodColorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.foodColorCB.FormattingEnabled = true;
            this.foodColorCB.Location = new System.Drawing.Point(72, 86);
            this.foodColorCB.Name = "foodColorCB";
            this.foodColorCB.Size = new System.Drawing.Size(121, 21);
            this.foodColorCB.TabIndex = 7;
            // 
            // bodyColorCB
            // 
            this.bodyColorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bodyColorCB.FormattingEnabled = true;
            this.bodyColorCB.Location = new System.Drawing.Point(72, 59);
            this.bodyColorCB.Name = "bodyColorCB";
            this.bodyColorCB.Size = new System.Drawing.Size(121, 21);
            this.bodyColorCB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Food Color:";
            // 
            // headColorCB
            // 
            this.headColorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.headColorCB.FormattingEnabled = true;
            this.headColorCB.Location = new System.Drawing.Point(73, 29);
            this.headColorCB.Name = "headColorCB";
            this.headColorCB.Size = new System.Drawing.Size(121, 21);
            this.headColorCB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Body Color: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Head Color: ";
            // 
            // applyBTN
            // 
            this.applyBTN.Location = new System.Drawing.Point(220, 22);
            this.applyBTN.Name = "applyBTN";
            this.applyBTN.Size = new System.Drawing.Size(75, 23);
            this.applyBTN.TabIndex = 1;
            this.applyBTN.Text = "Apply";
            this.applyBTN.UseVisualStyleBackColor = true;
            this.applyBTN.Click += new System.EventHandler(this.applyBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBTN.Location = new System.Drawing.Point(220, 51);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 2;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // shapeGB
            // 
            this.shapeGB.Controls.Add(this.panel2);
            this.shapeGB.Controls.Add(this.panel1);
            this.shapeGB.Location = new System.Drawing.Point(12, 149);
            this.shapeGB.Name = "shapeGB";
            this.shapeGB.Size = new System.Drawing.Size(200, 100);
            this.shapeGB.TabIndex = 3;
            this.shapeGB.TabStop = false;
            this.shapeGB.Text = "Shape";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.foodShapeSquare);
            this.panel2.Controls.Add(this.foodShapeCircle);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(6, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 35);
            this.panel2.TabIndex = 5;
            // 
            // foodShapeSquare
            // 
            this.foodShapeSquare.AutoSize = true;
            this.foodShapeSquare.Location = new System.Drawing.Point(105, 10);
            this.foodShapeSquare.Name = "foodShapeSquare";
            this.foodShapeSquare.Size = new System.Drawing.Size(59, 17);
            this.foodShapeSquare.TabIndex = 4;
            this.foodShapeSquare.Text = "Square";
            this.foodShapeSquare.UseVisualStyleBackColor = true;
            // 
            // foodShapeCircle
            // 
            this.foodShapeCircle.AutoSize = true;
            this.foodShapeCircle.Checked = true;
            this.foodShapeCircle.Location = new System.Drawing.Point(47, 10);
            this.foodShapeCircle.Name = "foodShapeCircle";
            this.foodShapeCircle.Size = new System.Drawing.Size(51, 17);
            this.foodShapeCircle.TabIndex = 3;
            this.foodShapeCircle.TabStop = true;
            this.foodShapeCircle.Text = "Circle";
            this.foodShapeCircle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Food:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.snakeShapeSquare);
            this.panel1.Controls.Add(this.snakeShapeCircle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 35);
            this.panel1.TabIndex = 4;
            // 
            // snakeShapeSquare
            // 
            this.snakeShapeSquare.AutoSize = true;
            this.snakeShapeSquare.Location = new System.Drawing.Point(105, 9);
            this.snakeShapeSquare.Name = "snakeShapeSquare";
            this.snakeShapeSquare.Size = new System.Drawing.Size(59, 17);
            this.snakeShapeSquare.TabIndex = 4;
            this.snakeShapeSquare.Text = "Square";
            this.snakeShapeSquare.UseVisualStyleBackColor = true;
            // 
            // snakeShapeCircle
            // 
            this.snakeShapeCircle.AutoSize = true;
            this.snakeShapeCircle.Checked = true;
            this.snakeShapeCircle.Location = new System.Drawing.Point(47, 9);
            this.snakeShapeCircle.Name = "snakeShapeCircle";
            this.snakeShapeCircle.Size = new System.Drawing.Size(51, 17);
            this.snakeShapeCircle.TabIndex = 3;
            this.snakeShapeCircle.TabStop = true;
            this.snakeShapeCircle.Text = "Circle";
            this.snakeShapeCircle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Snake:";
            // 
            // difficultyGB
            // 
            this.difficultyGB.Controls.Add(this.hardRadio);
            this.difficultyGB.Controls.Add(this.mediumRadio);
            this.difficultyGB.Controls.Add(this.easyRadio);
            this.difficultyGB.Location = new System.Drawing.Point(222, 91);
            this.difficultyGB.Name = "difficultyGB";
            this.difficultyGB.Size = new System.Drawing.Size(73, 153);
            this.difficultyGB.TabIndex = 4;
            this.difficultyGB.TabStop = false;
            this.difficultyGB.Text = "Difficulty";
            // 
            // hardRadio
            // 
            this.hardRadio.AutoSize = true;
            this.hardRadio.Location = new System.Drawing.Point(6, 101);
            this.hardRadio.Name = "hardRadio";
            this.hardRadio.Size = new System.Drawing.Size(48, 17);
            this.hardRadio.TabIndex = 2;
            this.hardRadio.Text = "Hard";
            this.hardRadio.UseVisualStyleBackColor = true;
            // 
            // mediumRadio
            // 
            this.mediumRadio.AutoSize = true;
            this.mediumRadio.Checked = true;
            this.mediumRadio.Location = new System.Drawing.Point(6, 63);
            this.mediumRadio.Name = "mediumRadio";
            this.mediumRadio.Size = new System.Drawing.Size(62, 17);
            this.mediumRadio.TabIndex = 1;
            this.mediumRadio.TabStop = true;
            this.mediumRadio.Text = "Medium";
            this.mediumRadio.UseVisualStyleBackColor = true;
            // 
            // easyRadio
            // 
            this.easyRadio.AutoSize = true;
            this.easyRadio.Location = new System.Drawing.Point(6, 25);
            this.easyRadio.Name = "easyRadio";
            this.easyRadio.Size = new System.Drawing.Size(48, 17);
            this.easyRadio.TabIndex = 0;
            this.easyRadio.Text = "Easy";
            this.easyRadio.UseVisualStyleBackColor = true;
            // 
            // miscGB
            // 
            this.miscGB.Controls.Add(this.panel4);
            this.miscGB.Controls.Add(this.panel3);
            this.miscGB.Location = new System.Drawing.Point(12, 255);
            this.miscGB.Name = "miscGB";
            this.miscGB.Size = new System.Drawing.Size(283, 61);
            this.miscGB.TabIndex = 5;
            this.miscGB.TabStop = false;
            this.miscGB.Text = "Misc";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton5);
            this.panel4.Controls.Add(this.radioButton6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(155, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 39);
            this.panel4.TabIndex = 7;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(5, 18);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(39, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "On";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(50, 18);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(39, 17);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.Text = "Off";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Power Ups";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(25, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 40);
            this.panel3.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "On";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(50, 18);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Off";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enemies";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.applyBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.closeBTN;
            this.ClientSize = new System.Drawing.Size(306, 328);
            this.Controls.Add(this.miscGB);
            this.Controls.Add(this.difficultyGB);
            this.Controls.Add(this.shapeGB);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.applyBTN);
            this.Controls.Add(this.appearanceGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.appearanceGB.ResumeLayout(false);
            this.appearanceGB.PerformLayout();
            this.shapeGB.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.difficultyGB.ResumeLayout(false);
            this.difficultyGB.PerformLayout();
            this.miscGB.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox appearanceGB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyBTN;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.GroupBox shapeGB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton foodShapeSquare;
        private System.Windows.Forms.RadioButton foodShapeCircle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton snakeShapeSquare;
        private System.Windows.Forms.RadioButton snakeShapeCircle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox difficultyGB;
        private System.Windows.Forms.RadioButton hardRadio;
        private System.Windows.Forms.RadioButton mediumRadio;
        private System.Windows.Forms.RadioButton easyRadio;
        private System.Windows.Forms.ComboBox headColorCB;
        private System.Windows.Forms.ComboBox foodColorCB;
        private System.Windows.Forms.ComboBox bodyColorCB;
        private System.Windows.Forms.GroupBox miscGB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label6;
    }
}