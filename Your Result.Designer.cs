
namespace MagicNumber
{
    partial class result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(result));
            this.magicNumberResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // magicNumberResultLabel
            // 
            this.magicNumberResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.magicNumberResultLabel.BackColor = System.Drawing.Color.Transparent;
            this.magicNumberResultLabel.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicNumberResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.magicNumberResultLabel.Location = new System.Drawing.Point(110, 109);
            this.magicNumberResultLabel.Margin = new System.Windows.Forms.Padding(0);
            this.magicNumberResultLabel.Name = "magicNumberResultLabel";
            this.magicNumberResultLabel.Size = new System.Drawing.Size(98, 68);
            this.magicNumberResultLabel.TabIndex = 1;
            this.magicNumberResultLabel.Text = "17";
            this.magicNumberResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(302, 310);
            this.Controls.Add(this.magicNumberResultLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "result";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Your Result";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label magicNumberResultLabel;
    }
}