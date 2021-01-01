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
        public Form_main()
        {

            InitializeComponent();
            label_notes.Hide();
            button_create_note.Hide();
                StreamReader file = new StreamReader("note.txt", Encoding.UTF8);
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    if (line == "---###---")
                        ++number;
                }
                file.Close();
        }

            private void Form_main_Load(object sender, EventArgs e)
            {
               
               
            }

            private void toolStripMenuItem1_Click(object sender, EventArgs e)
            {

            }

            private void заметкиToolStripMenuItem_Click(object sender, EventArgs e)
            {
                label_hello.Hide();
                label_notes.Text = "Ваши заметки:";
                label_notes.Show();
                button_create_note.Show();
                if (number == 0)
                {
                    MessageBox.Show("У Вас нет созданных заметок");
                }
                else
                {
                    StreamReader file = new StreamReader("note.txt", Encoding.UTF8);
                    string line;
                    RichTextBox[] tb = new RichTextBox[number];

                    for (int i = 0; i < tb.Length; ++i)
                    {
                        tb[i] = new RichTextBox();
                        tb[i].Location = new Point(190, i * 50 + 70);
                        tb[i].Width = 200;
                        tb[i].Height = 50;
                        tb[i].Font = new Font("Georgia", this.Height / 45);
                        Controls.Add(tb[i]);
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

            private void button_create_note_Click(object sender, EventArgs e)
            {
                this.Hide();
                New_Note new_note = new New_Note();
                new_note.Show();    
            }   
    }
}
