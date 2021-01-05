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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_planner_note));
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.button_save_edit_planner_note = new System.Windows.Forms.Button();
            this.dateTimePicker_deadline = new System.Windows.Forms.DateTimePicker();
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(57, 62);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(240, 20);
            this.textBox_title.TabIndex = 0;
            // 
            // button_save_edit_planner_note
            // 
            this.button_save_edit_planner_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_save_edit_planner_note.Location = new System.Drawing.Point(511, 62);
            this.button_save_edit_planner_note.Name = "button_save_edit_planner_note";
            this.button_save_edit_planner_note.Size = new System.Drawing.Size(235, 77);
            this.button_save_edit_planner_note.TabIndex = 4;
            this.button_save_edit_planner_note.Text = "Сохранить отредактированную заметку в ежедневник";
            this.button_save_edit_planner_note.UseVisualStyleBackColor = true;
            this.button_save_edit_planner_note.Click += new System.EventHandler(this.button_save_edit_planner_note_Click);
            // 
            // dateTimePicker_deadline
            // 
            this.dateTimePicker_deadline.Location = new System.Drawing.Point(57, 200);
            this.dateTimePicker_deadline.Name = "dateTimePicker_deadline";
            this.dateTimePicker_deadline.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker_deadline.TabIndex = 5;
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Location = new System.Drawing.Point(57, 267);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.Size = new System.Drawing.Size(203, 107);
            this.richTextBox_text.TabIndex = 6;
            this.richTextBox_text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Заголовок заметки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(48, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата создания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(48, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Срок выполнения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(48, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Текст:";
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(57, 130);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.ReadOnly = true;
            this.textBox_date.Size = new System.Drawing.Size(190, 20);
            this.textBox_date.TabIndex = 12;
            // 
            // Edit_planner_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_text);
            this.Controls.Add(this.dateTimePicker_deadline);
            this.Controls.Add(this.button_save_edit_planner_note);
            this.Controls.Add(this.textBox_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Edit_planner_note";
            this.Text = "Редактирование заметки в ежедневнике";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_planner_note_close);
            this.Load += new System.EventHandler(this.Edit_planner_note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Button button_save_edit_planner_note;
        private System.Windows.Forms.DateTimePicker dateTimePicker_deadline;
        private System.Windows.Forms.RichTextBox richTextBox_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_date;
    }
}