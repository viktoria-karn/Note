namespace Note
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_text = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(57, 62);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.ReadOnly = true;
            this.textBox_title.Size = new System.Drawing.Size(240, 20);
            this.textBox_title.TabIndex = 0;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(57, 130);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.ReadOnly = true;
            this.textBox_date.Size = new System.Drawing.Size(179, 20);
            this.textBox_date.TabIndex = 1;
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_edit.Location = new System.Drawing.Point(569, 53);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(146, 61);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Редактировать заметку";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_delete.Location = new System.Drawing.Point(569, 130);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(146, 62);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Удалить заметку";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заголовок заметки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата создания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(48, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текст:";
            // 
            // richTextBox_text
            // 
            this.richTextBox_text.Location = new System.Drawing.Point(57, 206);
            this.richTextBox_text.Name = "richTextBox_text";
            this.richTextBox_text.ReadOnly = true;
            this.richTextBox_text.Size = new System.Drawing.Size(240, 143);
            this.richTextBox_text.TabIndex = 8;
            this.richTextBox_text.Text = "";
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Note";
            this.Text = "Заметка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_main_Closed);
            this.Load += new System.EventHandler(this.Note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_text;
    }
}