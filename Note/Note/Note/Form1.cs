using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Note
{
    public partial class Form_main : Form
    {
        public static int number = 0;
        public static int count_notes = 0;
        public static int count_important_notes = 0;
        public static string file_name;
        public static string help_file_name;
        
        public Form_main()
        {
            InitializeComponent();
            label_notes.Hide();
            button_create_note.Hide();
            button_create_important_note.Hide();
        }

            private void Form_main_Load(object sender, EventArgs e)
            {
            }

        
        private void заметкиToolStripMenuItem_Click(object sender, EventArgs e)
            {
            file_name = "note.txt";
            foreach (Control c in this.Controls)
            {
                if (c is RichTextBox)
                {
                    c.Hide();
                }
            }
            file_name = "note.txt";
            count_notes = 0;
            StreamReader f = new StreamReader(file_name, Encoding.UTF8);
            while (!f.EndOfStream)
            {
                string line = f.ReadLine();
                if (line == "---###---")
                    ++count_notes;
            }
            f.Close();

            label_hello.Hide();
                label_notes.Text = "Ваши заметки:";
                label_notes.Show();
                button_create_note.Show();
            button_create_important_note.Hide();

            if (count_notes == 0)
                {
                    MessageBox.Show("У Вас нет созданных заметок");
                }
                else
                {
                    StreamReader file = new StreamReader(file_name, Encoding.UTF8);
                    string line;
                RichTextBox[] tb = new RichTextBox[count_notes];
                for (int i = 0; i < tb.Length; ++i)
                    {
                        tb[i] = new RichTextBox();
                        tb[i].Location = new Point(190, i * 50 + 70);
                        tb[i].Width = 200;
                        tb[i].Height = 50;
                        tb[i].Font = new Font("Georgia", this.Height / 45);
                        tb[i].Tag = i;
                        Controls.Add(tb[i]);
                    tb[i].Click += new System.EventHandler(this.textBox_Click);
                        line = file.ReadLine();
                        tb[i].Text = line.ToString() + Environment.NewLine;
                        line = file.ReadLine();
                        tb[i].Text += line.ToString() + Environment.NewLine;
                        while ((line = file.ReadLine()) != "---###---")
                        {

                        }
                    }
                    file.Close();
                }
            }
            private void textBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            number = Convert.ToInt32((sender as RichTextBox).Tag);
            Note note = new Note();
            note.Show();
        }
            private void button_create_note_Click(object sender, EventArgs e)
            {
            file_name = "note.txt";
            this.Hide();
            New_Note new_note = new New_Note();
                new_note.Show();    
            }
        private void button_create_important_note_Click(object sender, EventArgs e)
        {
            file_name = "important_note.txt";
            this.Hide();
            New_Note new_note = new New_Note();
            new_note.Show();
        }

        private void важноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file_name = "important_note.txt";
            foreach (Control c in this.Controls)
            {
                if(c is RichTextBox)
                {
                    c.Hide();
                }
            }
           
            label_hello.Hide();
            label_notes.Text = "Ваши важные заметки:";
            label_notes.Show();
            button_create_note.Hide();
            button_create_important_note.Show();
            count_important_notes = 0;
            StreamReader f = new StreamReader("important_note.txt", Encoding.UTF8);
            while (!f.EndOfStream)
            {
                string line = f.ReadLine();
                if (line == "---###---")
                    ++count_important_notes;
            }
            f.Close();
            if (count_important_notes == 0)
            {
                MessageBox.Show("У Вас нет созданных важных заметок");
            }
            else
            {
                StreamReader file = new StreamReader("important_note.txt", Encoding.UTF8);
                string line;
                RichTextBox[] tb = new RichTextBox[count_important_notes];
                for (int i = 0; i < tb.Length; ++i)
                {
                    tb[i] = new RichTextBox();
                    tb[i].Location = new Point(190, i * 50 + 70);
                    tb[i].Width = 200;
                    tb[i].Height = 50;
                    tb[i].Font = new Font("Georgia", this.Height / 45);
                    tb[i].Tag = i;
                    Controls.Add(tb[i]);
                    tb[i].Click += new System.EventHandler(this.textBox_Click);
                    line = file.ReadLine();
                    tb[i].Text = line.ToString() + Environment.NewLine;
                    line = file.ReadLine();
                    tb[i].Text += line.ToString() + Environment.NewLine;
                    while ((line = file.ReadLine()) != "---###---")
                    {

                    }
                }
                file.Close();
            }
        }
    }
}
