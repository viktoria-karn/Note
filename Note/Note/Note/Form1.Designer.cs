namespace Note
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.заметкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.важноеtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label_hello = new System.Windows.Forms.Label();
            this.button_create_note = new System.Windows.Forms.Button();
            this.label_notes = new System.Windows.Forms.Label();
            this.button_create_important_note = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заметкиToolStripMenuItem,
            this.важноеtoolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(156, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // заметкиToolStripMenuItem
            // 
            this.заметкиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.заметкиToolStripMenuItem.Name = "заметкиToolStripMenuItem";
            this.заметкиToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.заметкиToolStripMenuItem.Text = "Заметки";
            this.заметкиToolStripMenuItem.Click += new System.EventHandler(this.заметкиToolStripMenuItem_Click);
            // 
            // важноеtoolStripMenuItem1
            // 
            this.важноеtoolStripMenuItem1.Name = "важноеtoolStripMenuItem1";
            this.важноеtoolStripMenuItem1.Size = new System.Drawing.Size(143, 34);
            this.важноеtoolStripMenuItem1.Text = "Важные";
            this.важноеtoolStripMenuItem1.Click += new System.EventHandler(this.важноеToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 34);
            this.toolStripMenuItem2.Text = "Ежедневник";
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_hello.Location = new System.Drawing.Point(289, 36);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(323, 26);
            this.label_hello.TabIndex = 1;
            this.label_hello.Text = "Добро пожаловать в MyNotes!";
            // 
            // button_create_note
            // 
            this.button_create_note.Location = new System.Drawing.Point(650, 85);
            this.button_create_note.Name = "button_create_note";
            this.button_create_note.Size = new System.Drawing.Size(118, 73);
            this.button_create_note.TabIndex = 2;
            this.button_create_note.Text = "Создать заметку";
            this.button_create_note.UseVisualStyleBackColor = true;
            this.button_create_note.Click += new System.EventHandler(this.button_create_note_Click);
            // 
            // label_notes
            // 
            this.label_notes.AutoSize = true;
            this.label_notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_notes.Location = new System.Drawing.Point(225, 30);
            this.label_notes.Name = "label_notes";
            this.label_notes.Size = new System.Drawing.Size(70, 26);
            this.label_notes.TabIndex = 3;
            this.label_notes.Text = "label1";
            // 
            // button_create_important_note
            // 
            this.button_create_important_note.Location = new System.Drawing.Point(650, 97);
            this.button_create_important_note.Name = "button_create_important_note";
            this.button_create_important_note.Size = new System.Drawing.Size(118, 61);
            this.button_create_important_note.TabIndex = 4;
            this.button_create_important_note.Text = "Создать важную заметку";
            this.button_create_important_note.UseVisualStyleBackColor = true;
            this.button_create_important_note.Click += new System.EventHandler(this.button_create_important_note_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_create_important_note);
            this.Controls.Add(this.label_notes);
            this.Controls.Add(this.button_create_note);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "MyNotes";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem заметкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem важноеtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.Button button_create_note;
        private System.Windows.Forms.Label label_notes;
        private System.Windows.Forms.Button button_create_important_note;
    }
}

