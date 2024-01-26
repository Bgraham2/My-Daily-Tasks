
namespace My_Daily_Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelSongTitle = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.buttonStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSongTitle
            // 
            this.labelSongTitle.AutoSize = true;
            this.labelSongTitle.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSongTitle.Location = new System.Drawing.Point(291, 9);
            this.labelSongTitle.Name = "labelSongTitle";
            this.labelSongTitle.Size = new System.Drawing.Size(130, 27);
            this.labelSongTitle.TabIndex = 0;
            this.labelSongTitle.Text = "Song Title";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Location = new System.Drawing.Point(260, 61);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(201, 45);
            this.trackBarVolume.TabIndex = 1;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(325, 125);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.labelSongTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Notifications";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSongTitle;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button buttonStop;
    }
}