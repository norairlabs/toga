namespace TOGA
{
    partial class OpeningSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpeningSplash));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            LoadingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(914, 800);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(0, 803);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(914, 29);
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 2;
            progressBar1.UseWaitCursor = true;
            // 
            // LoadingLabel
            // 
            LoadingLabel.BackColor = System.Drawing.Color.Transparent;
            LoadingLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            LoadingLabel.Location = new System.Drawing.Point(287, 644);
            LoadingLabel.Name = "LoadingLabel";
            LoadingLabel.Size = new System.Drawing.Size(324, 23);
            LoadingLabel.TabIndex = 3;
            LoadingLabel.Text = "Loading";
            LoadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            LoadingLabel.UseWaitCursor = true;
            // 
            // OpeningSplash
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(914, 833);
            Controls.Add(LoadingLabel);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OpeningSplash";
            Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Loading...";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label LoadingLabel;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
