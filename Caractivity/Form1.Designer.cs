namespace Caractivity
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
            this.button1 = new System.Windows.Forms.Button();
            this.BMWPicture = new System.Windows.Forms.PictureBox();
            this.ToyotaPicture = new System.Windows.Forms.PictureBox();
            this.MercedesPicture = new System.Windows.Forms.PictureBox();
            this.LexusPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BMWPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercedesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexusPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = " Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BMWPicture
            // 
            this.BMWPicture.Image = global::Caractivity.Resource1.BMW;
            this.BMWPicture.Location = new System.Drawing.Point(188, 12);
            this.BMWPicture.Name = "BMWPicture";
            this.BMWPicture.Size = new System.Drawing.Size(93, 63);
            this.BMWPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BMWPicture.TabIndex = 3;
            this.BMWPicture.TabStop = false;
            // 
            // ToyotaPicture
            // 
            this.ToyotaPicture.Image = global::Caractivity.Resource1.Toyota;
            this.ToyotaPicture.Location = new System.Drawing.Point(363, 12);
            this.ToyotaPicture.Name = "ToyotaPicture";
            this.ToyotaPicture.Size = new System.Drawing.Size(93, 63);
            this.ToyotaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ToyotaPicture.TabIndex = 2;
            this.ToyotaPicture.TabStop = false;
            // 
            // MercedesPicture
            // 
            this.MercedesPicture.Image = global::Caractivity.Resource1.Mercedes;
            this.MercedesPicture.Location = new System.Drawing.Point(542, 12);
            this.MercedesPicture.Name = "MercedesPicture";
            this.MercedesPicture.Size = new System.Drawing.Size(93, 63);
            this.MercedesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MercedesPicture.TabIndex = 1;
            this.MercedesPicture.TabStop = false;
            // 
            // LexusPicture
            // 
            this.LexusPicture.Image = global::Caractivity.Resource1.Lexus;
            this.LexusPicture.Location = new System.Drawing.Point(12, 12);
            this.LexusPicture.Name = "LexusPicture";
            this.LexusPicture.Size = new System.Drawing.Size(93, 63);
            this.LexusPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LexusPicture.TabIndex = 0;
            this.LexusPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BMWPicture);
            this.Controls.Add(this.ToyotaPicture);
            this.Controls.Add(this.MercedesPicture);
            this.Controls.Add(this.LexusPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BMWPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToyotaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MercedesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexusPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox LexusPicture;
        private System.Windows.Forms.PictureBox MercedesPicture;
        private System.Windows.Forms.PictureBox ToyotaPicture;
        private System.Windows.Forms.PictureBox BMWPicture;
        private System.Windows.Forms.Button button1;
    }
}

