namespace Note
{
    partial class New_planner_note
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
            this.button_save_planner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_deadline = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(62, 61);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(134, 20);
            this.textBox_title.TabIndex = 0;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(68, 124);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(127, 20);
            this.textBox_date.TabIndex = 1;
            // 
            // textBox_text
            // 
            this.textBox_text.Location = new System.Drawing.Point(80, 260);
            this.textBox_text.Name = "textBox_text";
            this.textBox_text.Size = new System.Drawing.Size(115, 20);
            this.textBox_text.TabIndex = 3;
            // 
            // button_save_planner
            // 
            this.button_save_planner.Location = new System.Drawing.Point(474, 58);
            this.button_save_planner.Name = "button_save_planner";
            this.button_save_planner.Size = new System.Drawing.Size(139, 66);
            this.button_save_planner.TabIndex = 4;
            this.button_save_planner.Text = "Сохранить заметку в ежедневнике";
            this.button_save_planner.UseVisualStyleBackColor = true;
            this.button_save_planner.Click += new System.EventHandler(this.button_save_planner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заголовок заметки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата создания заметки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Срок выполнения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Текст заметки";
            // 
            // dateTimePicker_deadline
            // 
            this.dateTimePicker_deadline.Location = new System.Drawing.Point(70, 205);
            this.dateTimePicker_deadline.Name = "dateTimePicker_deadline";
            this.dateTimePicker_deadline.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker_deadline.TabIndex = 9;
            // 
            // New_planner_note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker_deadline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_save_planner);
            this.Controls.Add(this.textBox_text);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_title);
            this.Name = "New_planner_note";
            this.Text = "New_planner_note";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.New_planner_note_close);
            this.Load += new System.EventHandler(this.New_planner_note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_text;
        private System.Windows.Forms.Button button_save_planner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_deadline;
    }
}