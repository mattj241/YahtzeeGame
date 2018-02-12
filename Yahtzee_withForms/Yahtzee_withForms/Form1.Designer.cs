namespace Yahtzee_withForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.Roll_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.AceLabel = new System.Windows.Forms.Label();
            this.TwoLabel = new System.Windows.Forms.Label();
            this.ThreeLabel = new System.Windows.Forms.Label();
            this.FourLabel = new System.Windows.Forms.Label();
            this.FiveLabel = new System.Windows.Forms.Label();
            this.SixLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Round_Label = new System.Windows.Forms.Label();
            this.Score_label = new System.Windows.Forms.Label();
            this.ThreeOfKindLabel = new System.Windows.Forms.Label();
            this.FourOfKindLabel = new System.Windows.Forms.Label();
            this.FullHouseLabel = new System.Windows.Forms.Label();
            this.SmlStraightLabel = new System.Windows.Forms.Label();
            this.LgStraightLabel = new System.Windows.Forms.Label();
            this.YahtzeeLabel = new System.Windows.Forms.Label();
            this.ChanceLabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bonus_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Score:";
            // 
            // Roll_button
            // 
            this.Roll_button.Location = new System.Drawing.Point(287, 288);
            this.Roll_button.Name = "Roll_button";
            this.Roll_button.Size = new System.Drawing.Size(75, 23);
            this.Roll_button.TabIndex = 11;
            this.Roll_button.Text = "Roll!";
            this.Roll_button.UseVisualStyleBackColor = true;
            this.Roll_button.Click += new System.EventHandler(this.Roll_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(46, 233);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Hold Slot 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(159, 233);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "Hold Slot 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(276, 233);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 17);
            this.checkBox3.TabIndex = 19;
            this.checkBox3.Text = "Hold Slot 3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(413, 233);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(78, 17);
            this.checkBox4.TabIndex = 20;
            this.checkBox4.Text = "Hold Slot 4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(541, 233);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 17);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Text = "Hold Slot 5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // AceLabel
            // 
            this.AceLabel.AutoSize = true;
            this.AceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AceLabel.Location = new System.Drawing.Point(764, 18);
            this.AceLabel.Name = "AceLabel";
            this.AceLabel.Size = new System.Drawing.Size(42, 16);
            this.AceLabel.TabIndex = 22;
            this.AceLabel.Text = "Aces:";
            this.AceLabel.Click += new System.EventHandler(this.AceLabel_Click);
            // 
            // TwoLabel
            // 
            this.TwoLabel.AutoSize = true;
            this.TwoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoLabel.Location = new System.Drawing.Point(762, 45);
            this.TwoLabel.Name = "TwoLabel";
            this.TwoLabel.Size = new System.Drawing.Size(44, 16);
            this.TwoLabel.TabIndex = 23;
            this.TwoLabel.Text = "Twos:";
            this.TwoLabel.Click += new System.EventHandler(this.TwoLabel_Click);
            // 
            // ThreeLabel
            // 
            this.ThreeLabel.AutoSize = true;
            this.ThreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeLabel.Location = new System.Drawing.Point(752, 73);
            this.ThreeLabel.Name = "ThreeLabel";
            this.ThreeLabel.Size = new System.Drawing.Size(54, 16);
            this.ThreeLabel.TabIndex = 24;
            this.ThreeLabel.Text = "Threes:";
            this.ThreeLabel.Click += new System.EventHandler(this.ThreeLabel_Click);
            // 
            // FourLabel
            // 
            this.FourLabel.AutoSize = true;
            this.FourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourLabel.Location = new System.Drawing.Point(762, 101);
            this.FourLabel.Name = "FourLabel";
            this.FourLabel.Size = new System.Drawing.Size(45, 16);
            this.FourLabel.TabIndex = 25;
            this.FourLabel.Text = "Fours:";
            this.FourLabel.Click += new System.EventHandler(this.FourLabel_Click);
            // 
            // FiveLabel
            // 
            this.FiveLabel.AutoSize = true;
            this.FiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveLabel.Location = new System.Drawing.Point(762, 128);
            this.FiveLabel.Name = "FiveLabel";
            this.FiveLabel.Size = new System.Drawing.Size(44, 16);
            this.FiveLabel.TabIndex = 26;
            this.FiveLabel.Text = "Fives:";
            this.FiveLabel.Click += new System.EventHandler(this.FiveLabel_Click);
            // 
            // SixLabel
            // 
            this.SixLabel.AutoSize = true;
            this.SixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixLabel.Location = new System.Drawing.Point(762, 158);
            this.SixLabel.Name = "SixLabel";
            this.SixLabel.Size = new System.Drawing.Size(44, 16);
            this.SixLabel.TabIndex = 27;
            this.SixLabel.Text = "Sixes:";
            this.SixLabel.Click += new System.EventHandler(this.SixLabel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Round:";
            // 
            // Round_Label
            // 
            this.Round_Label.AutoSize = true;
            this.Round_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Round_Label.Location = new System.Drawing.Point(136, 18);
            this.Round_Label.Name = "Round_Label";
            this.Round_Label.Size = new System.Drawing.Size(19, 20);
            this.Round_Label.TabIndex = 29;
            this.Round_Label.Text = "0";
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_label.Location = new System.Drawing.Point(637, 9);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(19, 20);
            this.Score_label.TabIndex = 30;
            this.Score_label.Text = "0";
            // 
            // ThreeOfKindLabel
            // 
            this.ThreeOfKindLabel.AutoSize = true;
            this.ThreeOfKindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeOfKindLabel.Location = new System.Drawing.Point(705, 197);
            this.ThreeOfKindLabel.Name = "ThreeOfKindLabel";
            this.ThreeOfKindLabel.Size = new System.Drawing.Size(101, 16);
            this.ThreeOfKindLabel.TabIndex = 31;
            this.ThreeOfKindLabel.Text = "Three of a Kind:";
            this.ThreeOfKindLabel.Click += new System.EventHandler(this.ThreeOfKindLabel_Click);
            // 
            // FourOfKindLabel
            // 
            this.FourOfKindLabel.AutoSize = true;
            this.FourOfKindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourOfKindLabel.Location = new System.Drawing.Point(714, 222);
            this.FourOfKindLabel.Name = "FourOfKindLabel";
            this.FourOfKindLabel.Size = new System.Drawing.Size(92, 16);
            this.FourOfKindLabel.TabIndex = 32;
            this.FourOfKindLabel.Text = "Four of a Kind:";
            this.FourOfKindLabel.Click += new System.EventHandler(this.FourOfKindLabel_Click);
            // 
            // FullHouseLabel
            // 
            this.FullHouseLabel.AutoSize = true;
            this.FullHouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullHouseLabel.Location = new System.Drawing.Point(731, 250);
            this.FullHouseLabel.Name = "FullHouseLabel";
            this.FullHouseLabel.Size = new System.Drawing.Size(75, 16);
            this.FullHouseLabel.TabIndex = 33;
            this.FullHouseLabel.Text = "Full House:";
            this.FullHouseLabel.Click += new System.EventHandler(this.FullHouseLabel_Click);
            // 
            // SmlStraightLabel
            // 
            this.SmlStraightLabel.AutoSize = true;
            this.SmlStraightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmlStraightLabel.Location = new System.Drawing.Point(713, 277);
            this.SmlStraightLabel.Name = "SmlStraightLabel";
            this.SmlStraightLabel.Size = new System.Drawing.Size(93, 16);
            this.SmlStraightLabel.TabIndex = 34;
            this.SmlStraightLabel.Text = "Small Straight:";
            this.SmlStraightLabel.Click += new System.EventHandler(this.SmlStraightLabel_Click);
            // 
            // LgStraightLabel
            // 
            this.LgStraightLabel.AutoSize = true;
            this.LgStraightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgStraightLabel.Location = new System.Drawing.Point(712, 307);
            this.LgStraightLabel.Name = "LgStraightLabel";
            this.LgStraightLabel.Size = new System.Drawing.Size(94, 16);
            this.LgStraightLabel.TabIndex = 35;
            this.LgStraightLabel.Text = "Large Straight:";
            this.LgStraightLabel.Click += new System.EventHandler(this.LgStraightLabel_Click);
            // 
            // YahtzeeLabel
            // 
            this.YahtzeeLabel.AutoSize = true;
            this.YahtzeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YahtzeeLabel.Location = new System.Drawing.Point(746, 334);
            this.YahtzeeLabel.Name = "YahtzeeLabel";
            this.YahtzeeLabel.Size = new System.Drawing.Size(60, 16);
            this.YahtzeeLabel.TabIndex = 36;
            this.YahtzeeLabel.Text = "Yahtzee:";
            this.YahtzeeLabel.Click += new System.EventHandler(this.YahtzeeLabel_Click);
            // 
            // ChanceLabel
            // 
            this.ChanceLabel.AutoSize = true;
            this.ChanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChanceLabel.Location = new System.Drawing.Point(746, 363);
            this.ChanceLabel.Name = "ChanceLabel";
            this.ChanceLabel.Size = new System.Drawing.Size(57, 16);
            this.ChanceLabel.TabIndex = 37;
            this.ChanceLabel.Text = "Chance:";
            this.ChanceLabel.Click += new System.EventHandler(this.ChanceLabel_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Yahtzee_withForms.Properties.Resources.X;
            this.pictureBox5.Location = new System.Drawing.Point(541, 125);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(76, 76);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Yahtzee_withForms.Properties.Resources.X;
            this.pictureBox4.Location = new System.Drawing.Point(413, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Yahtzee_withForms.Properties.Resources.X;
            this.pictureBox3.Location = new System.Drawing.Point(293, 128);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Yahtzee_withForms.Properties.Resources.X;
            this.pictureBox2.Location = new System.Drawing.Point(161, 125);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yahtzee_withForms.Properties.Resources.X;
            this.pictureBox1.Location = new System.Drawing.Point(46, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Bonus_label
            // 
            this.Bonus_label.AutoSize = true;
            this.Bonus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bonus_label.Location = new System.Drawing.Point(560, 45);
            this.Bonus_label.Name = "Bonus_label";
            this.Bonus_label.Size = new System.Drawing.Size(93, 18);
            this.Bonus_label.TabIndex = 38;
            this.Bonus_label.Text = "Bonus +35!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "Yahtzee";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bonus_label);
            this.Controls.Add(this.ChanceLabel);
            this.Controls.Add(this.YahtzeeLabel);
            this.Controls.Add(this.LgStraightLabel);
            this.Controls.Add(this.SmlStraightLabel);
            this.Controls.Add(this.FullHouseLabel);
            this.Controls.Add(this.FourOfKindLabel);
            this.Controls.Add(this.ThreeOfKindLabel);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.Round_Label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SixLabel);
            this.Controls.Add(this.FiveLabel);
            this.Controls.Add(this.FourLabel);
            this.Controls.Add(this.ThreeLabel);
            this.Controls.Add(this.TwoLabel);
            this.Controls.Add(this.AceLabel);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Roll_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Roll_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label AceLabel;
        private System.Windows.Forms.Label TwoLabel;
        private System.Windows.Forms.Label ThreeLabel;
        private System.Windows.Forms.Label FourLabel;
        private System.Windows.Forms.Label FiveLabel;
        private System.Windows.Forms.Label SixLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Round_Label;
        private System.Windows.Forms.Label Score_label;
        private System.Windows.Forms.Label ThreeOfKindLabel;
        private System.Windows.Forms.Label FourOfKindLabel;
        private System.Windows.Forms.Label FullHouseLabel;
        private System.Windows.Forms.Label SmlStraightLabel;
        private System.Windows.Forms.Label LgStraightLabel;
        private System.Windows.Forms.Label YahtzeeLabel;
        private System.Windows.Forms.Label ChanceLabel;
        private System.Windows.Forms.Label Bonus_label;
        private System.Windows.Forms.Label label2;
    }
}

