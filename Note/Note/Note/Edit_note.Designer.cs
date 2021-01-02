namespace Note
{
    partial class Edit_note
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
            this.button_save_edit_note = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(48, 69);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(129, 20);
            this.textBox_title.TabIndex = 0;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(53, 135);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(124, 20);
            this.textBox_date.TabIndex = 1;
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(62, 223);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(115, 20);
            this.textBox_text.TabIndex = 2;
            // 
            // button_save_edit_note
            // 
            this.button_save_edit_note.Location = new System.Drawing.Point(479, 74);
            this.button_save_edit_note.Name = "button_save_edit_note";
            this.button_save_edit_note.Size = new System.Drawing.Size(111, 48);
            this.button_save_edit_note.TabIndex = 3;
            this.button_save_edit_note.Text = "Сохранить заметку";
            this.button_save_edit_note.UseVisualStyleBackColor = true;
            this.button_save_edit_note.Click += new System.EventHandler(this.button_save_edit_note_Click);
            // 
            // Edit_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_save_edit_note);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_title);
            this.Name = "Edit_note";
            this.Text = "Edit_note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Edit_note_Closed);
            this.Load += new System.EventHandler(this.Edit_note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Button button_save_edit_note;
    }
}