
namespace work014
{
    partial class start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.Label();
            this.nameT = new System.Windows.Forms.TextBox();
            this.startB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(41, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(39, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Имя";
            // 
            // nameT
            // 
            this.nameT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameT.Location = new System.Drawing.Point(154, 49);
            this.nameT.Name = "nameT";
            this.nameT.Size = new System.Drawing.Size(157, 27);
            this.nameT.TabIndex = 1;
            this.nameT.Click += new System.EventHandler(this.ClickT);
            this.nameT.TextChanged += new System.EventHandler(this.nameT_TextChanged);
            // 
            // startB
            // 
            this.startB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.startB.Location = new System.Drawing.Point(125, 197);
            this.startB.Name = "startB";
            this.startB.Size = new System.Drawing.Size(219, 66);
            this.startB.TabIndex = 2;
            this.startB.Text = "СТАРТ";
            this.startB.UseVisualStyleBackColor = true;
            this.startB.Click += new System.EventHandler(this.startB_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 303);
            this.Controls.Add(this.startB);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.name);
            this.MaximumSize = new System.Drawing.Size(500, 350);
            this.MinimumSize = new System.Drawing.Size(500, 350);
            this.Name = "start";
            this.Text = "Старт";
            this.Load += new System.EventHandler(this.start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.Button startB;
    }
}

