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
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //File.Create("note.txt");
            ++Form_main.number;
            StreamWriter sw = new StreamWriter("new_note.txt", false, Encoding.UTF8);
            sw.WriteLine(textBox_title.Text);
            sw.WriteLine(textBox_date.Text);
            sw.WriteLine(textBox_text.Text);
            sw.WriteLine("---###---");
            textBox_title.Text = "";
            textBox_text.Text = "";
            StreamReader file = new StreamReader("note.txt", Encoding.UTF8);
            string line;
            while (!file.EndOfStream)
            {
                line = file.ReadLine();
                sw.WriteLine(line);
            }
            sw.Close();
            file.Close();
            StreamWriter new_file = new StreamWriter("note.txt", false, Encoding.UTF8);
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
    }
}
