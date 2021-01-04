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
    public partial class New_planner_note : Form
    {
        public New_planner_note()
        {
            InitializeComponent();
        }

        private void button_save_planner_Click(object sender, EventArgs e)
        {
            ++Form_main.count_planner;
            StreamWriter sw = new StreamWriter("new_note.txt", false, Encoding.UTF8);
            sw.WriteLine(textBox_title.Text);
            sw.WriteLine(textBox_date.Text);
            sw.WriteLine(dateTimePicker_deadline.Text);
            sw.WriteLine(richTextBox_text.Text);
            sw.WriteLine("---###---");
            textBox_title.Text = "";
            richTextBox_text.Text = "";
            StreamReader file = new StreamReader(Form_main.file_name, Encoding.UTF8);
            string line;
            while (!file.EndOfStream)
            {
                line = file.ReadLine();
                sw.WriteLine(line);
            }
            sw.Close();
            file.Close();
            StreamWriter new_file = new StreamWriter(Form_main.file_name, false, Encoding.UTF8);
            StreamReader new_edit_file = new StreamReader("new_note.txt", Encoding.UTF8);
            while (!new_edit_file.EndOfStream)
            {
                line = new_edit_file.ReadLine();
                new_file.WriteLine(line);
            }
            new_file.Close();
            new_edit_file.Close();
            File.Delete("new_note.txt");
            this.Hide();
            Form_main form = new Form_main();
            form.Show();
        }

        private void New_planner_note_Load(object sender, EventArgs e)
        {
            textBox_date.Text = DateTime.Now.ToLongDateString();
            textBox_title.Font = new Font("Georgia", this.Height / 40);
            textBox_date.Font = new Font("Georgia", this.Height / 40);
            dateTimePicker_deadline.Font = new Font("Georgia", this.Height / 40);
            richTextBox_text.Font = new Font("Georgia", this.Height / 40);

        }

        private void New_planner_note_close(object sender, FormClosedEventArgs e)
        {
            Form_main form = new Form_main();
            form.Show();
        }
    }
}
