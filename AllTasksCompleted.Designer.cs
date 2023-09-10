
namespace My_Daily_Tasks
{
    partial class AllTasksCompleted
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTasksCompleted));
            this.pictureBoxConfetti = new System.Windows.Forms.PictureBox();
            this.labelComplete = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfetti)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxConfetti
            // 
            this.pictureBoxConfetti.Image = global::My_Daily_Tasks.Properties.Resources.confetti;
            this.pictureBoxConfetti.Location = new System.Drawing.Point(-1, -2);
            this.pictureBoxConfetti.Name = "pictureBoxConfetti";
            this.pictureBoxConfetti.Size = new System.Drawing.Size(607, 306);
            this.pictureBoxConfetti.TabIndex = 0;
            this.pictureBoxConfetti.TabStop = false;
            // 
            // labelComplete
            // 
            this.labelComplete.AutoSize = true;
            this.labelComplete.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplete.Location = new System.Drawing.Point(55, 33);
            this.labelComplete.Name = "labelComplete";
            this.labelComplete.Size = new System.Drawing.Size(482, 36);
            this.labelComplete.TabIndex = 1;
            this.labelComplete.Text = "Congrats All Tasks Completed! ";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(249, 254);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(113, 37);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AllTasksCompleted
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(605, 303);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelComplete);
            this.Controls.Add(this.pictureBoxConfetti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AllTasksCompleted";
            this.Text = "All Tasks Completed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConfetti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxConfetti;
        private System.Windows.Forms.Label labelComplete;
        private System.Windows.Forms.Button buttonClose;
    }
}