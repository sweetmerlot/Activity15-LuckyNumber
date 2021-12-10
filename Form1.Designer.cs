
namespace MagicNumber
{
    partial class MagicNumber
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.luckyButton = new System.Windows.Forms.Button();
            this.birthYearCombo = new System.Windows.Forms.ComboBox();
            this.birthMonthCombo = new System.Windows.Forms.ComboBox();
            this.birthDayCombo = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Birth Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Birth Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Your Birth Day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Your Favorite Color:";
            // 
            // luckyButton
            // 
            this.luckyButton.Location = new System.Drawing.Point(21, 241);
            this.luckyButton.Margin = new System.Windows.Forms.Padding(1);
            this.luckyButton.Name = "luckyButton";
            this.luckyButton.Size = new System.Drawing.Size(248, 40);
            this.luckyButton.TabIndex = 4;
            this.luckyButton.Text = "Get Your Lucky Number";
            this.luckyButton.UseVisualStyleBackColor = true;
            this.luckyButton.Click += new System.EventHandler(this.luckyButton_Click);
            // 
            // birthYearCombo
            // 
            this.birthYearCombo.FormattingEnabled = true;
            this.birthYearCombo.Location = new System.Drawing.Point(148, 29);
            this.birthYearCombo.Name = "birthYearCombo";
            this.birthYearCombo.Size = new System.Drawing.Size(121, 21);
            this.birthYearCombo.TabIndex = 6;
            this.birthYearCombo.Tag = "";
            // 
            // birthMonthCombo
            // 
            this.birthMonthCombo.FormattingEnabled = true;
            this.birthMonthCombo.Location = new System.Drawing.Point(148, 83);
            this.birthMonthCombo.Name = "birthMonthCombo";
            this.birthMonthCombo.Size = new System.Drawing.Size(121, 21);
            this.birthMonthCombo.TabIndex = 7;
            this.birthMonthCombo.SelectedIndexChanged += new System.EventHandler(this.birthMonthCombo_SelectedIndexChanged);
            // 
            // birthDayCombo
            // 
            this.birthDayCombo.FormattingEnabled = true;
            this.birthDayCombo.Location = new System.Drawing.Point(148, 133);
            this.birthDayCombo.Name = "birthDayCombo";
            this.birthDayCombo.Size = new System.Drawing.Size(121, 21);
            this.birthDayCombo.TabIndex = 8;
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(148, 177);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(121, 23);
            this.colorButton.TabIndex = 10;
            this.colorButton.Text = "Favorite Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // MagicNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(316, 297);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.birthDayCombo);
            this.Controls.Add(this.birthMonthCombo);
            this.Controls.Add(this.birthYearCombo);
            this.Controls.Add(this.luckyButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MagicNumber";
            this.Text = "Magic Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button luckyButton;
        private System.Windows.Forms.ComboBox birthYearCombo;
        private System.Windows.Forms.ComboBox birthMonthCombo;
        private System.Windows.Forms.ComboBox birthDayCombo;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorButton;
    }
}

