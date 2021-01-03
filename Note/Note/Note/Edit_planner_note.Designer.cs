namespace Note
{
    partial class Edit_planner_note
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
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.button_save_edit_planner_note = new System.Windows.Forms.Button();
            this.dateTimePicker_deadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(50, 56);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(169, 20);
            this.textBox_title.TabIndex = 0;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(50, 124);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(162, 20);
            this.textBox_date.TabIndex = 1;
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(50, 279);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(190, 20);
            this.textBox_text.TabIndex = 3;
            // 
            // button_save_edit_planner_note
            // 
            this.button_save_edit_planner_note.Location = new System.Drawing.Point(507, 80);
            this.button_save_edit_planner_note.Name = "button_save_edit_planner_note";
            this.button_save_edit_planner_note.Size = new System.Drawing.Size(235, 64);
            this.button_save_edit_planner_note.TabIndex = 4;
            this.button_save_edit_planner_note.Text = "Сохранить отредактированную заметку в ежедневник";
            this.button_save_edit_planner_note.UseVisualStyleBackColor = true;
            this.button_save_edit_planner_note.Click += new System.EventHandler(this.button_save_edit_planner_note_Click);
            // 
            // dateTimePicker_deadline
            // 
            this.dateTimePicker_deadline.Location = new System.Drawing.Point(50, 200);
            this.dateTimePicker_deadline.Name = "dateTimePicker_deadline";
            this.dateTimePicker_deadline.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker_deadline.TabIndex = 5;
            // 
            // Edit_planner_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker_deadline);
            this.Controls.Add(this.button_save_edit_planner_note);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_title);
            this.Name = "Edit_planner_note";
            this.Text = "Edit_planner_note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_planner_note_close);
            this.Load += new System.EventHandler(this.Edit_planner_note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Button button_save_edit_planner_note;
        private System.Windows.Forms.DateTimePicker dateTimePicker_deadline;
    }
}