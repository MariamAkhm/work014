
namespace work014
{
    partial class horror
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
            this.horrorP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.horrorP)).BeginInit();
            this.SuspendLayout();
            // 
            // horrorP
            // 
            this.horrorP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.horrorP.Location = new System.Drawing.Point(-7, 12);
            this.horrorP.MaximumSize = new System.Drawing.Size(500, 343);
            this.horrorP.MinimumSize = new System.Drawing.Size(500, 343);
            this.horrorP.Name = "horrorP";
            this.horrorP.Size = new System.Drawing.Size(500, 343);
            this.horrorP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.horrorP.TabIndex = 0;
            this.horrorP.TabStop = false;
            this.horrorP.Click += new System.EventHandler(this.horrorP_Click);
            // 
            // horror
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.horrorP);
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "horror";
            this.Text = "horror";
            ((System.ComponentModel.ISupportInitialize)(this.horrorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox horrorP;
    }
}