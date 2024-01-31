
namespace My_Daily_Tasks
{
    partial class AddTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            this.labelTaskName = new System.Windows.Forms.Label();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.checkBoxAllWeek = new System.Windows.Forms.CheckBox();
            this.groupBoxDays = new System.Windows.Forms.GroupBox();
            this.checkBoxSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxMonday = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTaskName.Location = new System.Drawing.Point(12, 9);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(149, 27);
            this.labelTaskName.TabIndex = 0;
            this.labelTaskName.Text = "Task Name:";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaskName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxTaskName.Location = new System.Drawing.Point(167, 5);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(195, 34);
            this.textBoxTaskName.TabIndex = 1;
            // 
            // checkBoxAllWeek
            // 
            this.checkBoxAllWeek.AutoSize = true;
            this.checkBoxAllWeek.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAllWeek.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxAllWeek.Location = new System.Drawing.Point(406, 8);
            this.checkBoxAllWeek.Name = "checkBoxAllWeek";
            this.checkBoxAllWeek.Size = new System.Drawing.Size(130, 31);
            this.checkBoxAllWeek.TabIndex = 2;
            this.checkBoxAllWeek.Text = "All Week";
            this.checkBoxAllWeek.UseVisualStyleBackColor = true;
            this.checkBoxAllWeek.CheckedChanged += new System.EventHandler(this.CheckBoxAllWeek_CheckedChanged);
            // 
            // groupBoxDays
            // 
            this.groupBoxDays.Controls.Add(this.checkBoxSunday);
            this.groupBoxDays.Controls.Add(this.checkBoxSaturday);
            this.groupBoxDays.Controls.Add(this.checkBoxFriday);
            this.groupBoxDays.Controls.Add(this.checkBoxThursday);
            this.groupBoxDays.Controls.Add(this.checkBoxWednesday);
            this.groupBoxDays.Controls.Add(this.checkBoxTuesday);
            this.groupBoxDays.Controls.Add(this.checkBoxMonday);
            this.groupBoxDays.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDays.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBoxDays.Location = new System.Drawing.Point(12, 45);
            this.groupBoxDays.Name = "groupBoxDays";
            this.groupBoxDays.Size = new System.Drawing.Size(800, 75);
            this.groupBoxDays.TabIndex = 3;
            this.groupBoxDays.TabStop = false;
            this.groupBoxDays.Text = "Week Days";
            // 
            // checkBoxSunday
            // 
            this.checkBoxSunday.AutoSize = true;
            this.checkBoxSunday.Location = new System.Drawing.Point(700, 29);
            this.checkBoxSunday.Name = "checkBoxSunday";
            this.checkBoxSunday.Size = new System.Drawing.Size(99, 25);
            this.checkBoxSunday.TabIndex = 6;
            this.checkBoxSunday.Text = "Sunday";
            this.checkBoxSunday.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaturday
            // 
            this.checkBoxSaturday.AutoSize = true;
            this.checkBoxSaturday.Location = new System.Drawing.Point(579, 29);
            this.checkBoxSaturday.Name = "checkBoxSaturday";
            this.checkBoxSaturday.Size = new System.Drawing.Size(115, 25);
            this.checkBoxSaturday.TabIndex = 5;
            this.checkBoxSaturday.Text = "Saturday";
            this.checkBoxSaturday.UseVisualStyleBackColor = true;
            // 
            // checkBoxFriday
            // 
            this.checkBoxFriday.AutoSize = true;
            this.checkBoxFriday.Location = new System.Drawing.Point(483, 29);
            this.checkBoxFriday.Name = "checkBoxFriday";
            this.checkBoxFriday.Size = new System.Drawing.Size(90, 25);
            this.checkBoxFriday.TabIndex = 4;
            this.checkBoxFriday.Text = "Friday";
            this.checkBoxFriday.UseVisualStyleBackColor = true;
            // 
            // checkBoxThursday
            // 
            this.checkBoxThursday.AutoSize = true;
            this.checkBoxThursday.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxThursday.Location = new System.Drawing.Point(361, 29);
            this.checkBoxThursday.Name = "checkBoxThursday";
            this.checkBoxThursday.Size = new System.Drawing.Size(116, 25);
            this.checkBoxThursday.TabIndex = 3;
            this.checkBoxThursday.Text = "Thursday";
            this.checkBoxThursday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWednesday
            // 
            this.checkBoxWednesday.AutoSize = true;
            this.checkBoxWednesday.Location = new System.Drawing.Point(225, 29);
            this.checkBoxWednesday.Name = "checkBoxWednesday";
            this.checkBoxWednesday.Size = new System.Drawing.Size(130, 25);
            this.checkBoxWednesday.TabIndex = 2;
            this.checkBoxWednesday.Text = "Wednesday";
            this.checkBoxWednesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxTuesday
            // 
            this.checkBoxTuesday.AutoSize = true;
            this.checkBoxTuesday.Location = new System.Drawing.Point(115, 29);
            this.checkBoxTuesday.Name = "checkBoxTuesday";
            this.checkBoxTuesday.Size = new System.Drawing.Size(104, 25);
            this.checkBoxTuesday.TabIndex = 1;
            this.checkBoxTuesday.Text = "Tuesday";
            this.checkBoxTuesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxMonday
            // 
            this.checkBoxMonday.AutoSize = true;
            this.checkBoxMonday.Location = new System.Drawing.Point(6, 29);
            this.checkBoxMonday.Name = "checkBoxMonday";
            this.checkBoxMonday.Size = new System.Drawing.Size(103, 25);
            this.checkBoxMonday.TabIndex = 0;
            this.checkBoxMonday.Text = "Monday";
            this.checkBoxMonday.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSave.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave.Location = new System.Drawing.Point(706, 126);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 45);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonClose.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClose.Location = new System.Drawing.Point(591, 126);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 45);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(818, 181);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBoxDays);
            this.Controls.Add(this.checkBoxAllWeek);
            this.Controls.Add(this.textBoxTaskName);
            this.Controls.Add(this.labelTaskName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTaskForm";
            this.Text = "Add Task";
            this.groupBoxDays.ResumeLayout(false);
            this.groupBoxDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.CheckBox checkBoxAllWeek;
        private System.Windows.Forms.GroupBox groupBoxDays;
        private System.Windows.Forms.CheckBox checkBoxSunday;
        private System.Windows.Forms.CheckBox checkBoxSaturday;
        private System.Windows.Forms.CheckBox checkBoxFriday;
        private System.Windows.Forms.CheckBox checkBoxThursday;
        private System.Windows.Forms.CheckBox checkBoxWednesday;
        private System.Windows.Forms.CheckBox checkBoxTuesday;
        private System.Windows.Forms.CheckBox checkBoxMonday;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClose;
    }
}