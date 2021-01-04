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
    public partial class New_Note : Form
    {
        public New_Note()
        {
            InitializeComponent();
        }

        private void New_Note_Load(object sender, EventArgs e)
        {
            textBox_date.Text = DateTime.Now.ToLongDateString();
            textBox_title.Font = new Font("Georgia", this.Height / 40);
            textBox_date.Font = new Font("Georgia", this.Height / 40);
            richTextBox_text.Font = new Font("Georgia", this.Height / 40);

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            ++Form_main.count_notes;
            StreamWriter sw = new StreamWriter("new_note.txt", false, Encoding.UTF8);
            sw.WriteLine(textBox_title.Text);
            sw.WriteLine(textBox_date.Text);
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

        private void New_Note_Closed(object sender, FormClosedEventArgs e)
        {
            Form_main form = new Form_main();
            form.Show();
        }
    }
}
