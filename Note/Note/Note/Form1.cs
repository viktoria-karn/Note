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
        public static int count_planner = 0;
        public static string file_name;
        public static string help_file_name;
        
        public Form_main()
        {
            InitializeComponent();
            label_notes.Hide();
            button_create_note.Hide();
            button_create_important_note.Hide();
            button_create_planner_note.Hide();
        }

            private void Form_main_Load(object sender, EventArgs e)
            {
       
            label_about.Text += Environment.NewLine;
            label_about.Text += Environment.NewLine;
            label_about.Text += "В разделе \"Заметки\" Вы можете создавать обычные заметки,а также редактировать и удалять их" + Environment.NewLine;
            label_about.Text += Environment.NewLine;
            label_about.Text += "Важные заметки Вы можете создавать в отдельном разделе \"Важное\" " + Environment.NewLine;
            label_about.Text += Environment.NewLine;
            label_about.Text += "Если Вам нужно создать заметку,для которой предусмотрен срок выполнения,воспользуйтесь разделом \"Ежедневник\" " + Environment.NewLine;
        }

        
        private void заметкиToolStripMenuItem_Click(object sender, EventArgs e)
            {
            this.Size= new Size(816, 489);
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
            label_about.Hide();
            label_notes.Text = "Ваши заметки:";
                label_notes.Show();
                button_create_note.Show();
            button_create_important_note.Hide();
            button_create_planner_note.Hide();

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
                        tb[i].Width = 400;
                        tb[i].Height = 50;
                        tb[i].Font = new Font("Georgia", this.Height / 40);
                        tb[i].Tag = i;
                        Controls.Add(tb[i]);
                    tb[i].Click += new System.EventHandler(this.textBox_Click);
                        line = file.ReadLine();
                        tb[i].Text = line.ToString() + Environment.NewLine;
                        line = file.ReadLine();
                        tb[i].Text += "Дата создания заметки: "+line.ToString() + Environment.NewLine;
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
        private void textBox_planner_note_Click(object sender, EventArgs e)
        {
            this.Hide();
            number = Convert.ToInt32((sender as RichTextBox).Tag);
            Planner_note planner_note = new Planner_note();
            planner_note.Show();
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
            this.Size = new Size(816, 489);
            file_name = "important_note.txt";
            foreach (Control c in this.Controls)
            {
                if(c is RichTextBox)
                {
                    c.Hide();
                }
            }
           
            label_hello.Hide();
            label_about.Hide();
            label_notes.Text = "Ваши важные заметки:";
            label_notes.Show();
            button_create_note.Hide();
            button_create_important_note.Show();
            button_create_planner_note.Hide();
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
                    tb[i].Width = 400;
                    tb[i].Height = 50;
                    tb[i].Font = new Font("Georgia", this.Height / 40);
                    tb[i].Tag = i;
                    Controls.Add(tb[i]);
                    tb[i].Click += new System.EventHandler(this.textBox_Click);
                    line = file.ReadLine();
                    tb[i].Text = line.ToString() + Environment.NewLine;
                    line = file.ReadLine();
                    tb[i].Text += "Дата создания заметки: "+line.ToString() + Environment.NewLine;
                    while ((line = file.ReadLine()) != "---###---")
                    {

                    }
                }
                file.Close();
            }
        }

        private void ежедневникtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(816, 489);
            file_name = "planner.txt";
            foreach (Control c in this.Controls)
            {
                if (c is RichTextBox)
                {
                    c.Hide();
                }
            }
            label_hello.Hide();
            label_about.Hide();
            label_notes.Text = "Ежедневник:";
            label_notes.Show();
            button_create_note.Hide();
            button_create_important_note.Hide();
            button_create_planner_note.Show();
            count_planner = 0;
            StreamReader f = new StreamReader("planner.txt", Encoding.UTF8);
            while (!f.EndOfStream)
            {
                string line = f.ReadLine();
                if (line == "---###---")
                    ++count_planner;
            }
            f.Close();
            if (count_planner == 0)
            {
                MessageBox.Show("У Вас нет заметок в ежедневнике");
            }
            else
            {
                
                StreamReader file = new StreamReader("planner.txt", Encoding.UTF8);
                string line;
                RichTextBox[] tb = new RichTextBox[count_planner];
                for (int i = 0; i < tb.Length; ++i)
                {
                    tb[i] = new RichTextBox();
                    tb[i].Location = new Point(190, i * 50 + 70);
                    tb[i].Width = 400;
                    tb[i].Height = 60;
                    tb[i].Font = new Font("Georgia", this.Height / 40);
                    tb[i].Tag = i;
                    Controls.Add(tb[i]);
                    tb[i].Click += new EventHandler(this.textBox_planner_note_Click);
                    line = file.ReadLine();
                    tb[i].Text = line.ToString() + Environment.NewLine;
                    line = file.ReadLine();
                    tb[i].Text += "Дата создания заметки: "+line.ToString() + Environment.NewLine;
                    line = file.ReadLine();
                    tb[i].Text += "Срок выполнения: "+line.ToString() + Environment.NewLine;
                    while ((line = file.ReadLine()) != "---###---")
                    {

                    }
                }
                file.Close();
            }
        }

        private void button_create_planner_note_Click(object sender, EventArgs e)
        {
            this.Hide();
            New_planner_note new_planner_note = new New_planner_note();
            new_planner_note.Show();
        }
    }
}
