namespace Note
{
    partial class Planner_note
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
            this.textBox_deadline = new System.Windows.Forms.TextBox();
            this.textBox_text = new System.Windows.Forms.TextBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(60, 39);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(144, 20);
            this.textBox_title.TabIndex = 0;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(57, 96);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(147, 20);
            this.textBox_date.TabIndex = 1;
            // 
            // textBox_deadline
            // 
            this.textBox_deadline.Location = new System.Drawing.Point(57, 163);
            this.textBox_deadline.Name = "textBox_deadline";
            this.textBox_deadline.Size = new System.Drawing.Size(147, 20);
            this.textBox_deadline.TabIndex = 2;
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(60, 245);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(200, 20);
            this.textBox_text.TabIndex = 3;
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(554, 56);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(145, 33);
            this.button_edit.TabIndex = 4;
            this.button_edit.Text = "Редактировать заметку";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(554, 112);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(145, 33);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Удалить заметку";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // Planner_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.textBox_deadline);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_title);
            this.Name = "Planner_note";
            this.Text = "Planner_note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Planner_note_closed);
            this.Load += new System.EventHandler(this.Planner_note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_deadline;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
    }
}