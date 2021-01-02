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
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        private void Note_Load(object sender, EventArgs e)
        {
            textBox_title.Font = new Font("Georgia", this.Height / 25);
            textBox_date.Font = new Font("Georgia", this.Height / 25);
            textBox_text.Font = new Font("Georgia", this.Height / 25);


            StreamReader fi = new StreamReader(Form_main.file_name, true);
            string line;
            int in_number = 0;

            for (in_number = 0; in_number <= Form_main.number; ++in_number)
            {
                line = fi.ReadLine();
                textBox_title.Text = line.ToString() + System.Environment.NewLine;
                line = fi.ReadLine();
                textBox_date.Text = line.ToString() + System.Environment.NewLine;
                while ((line = fi.ReadLine()) != "---###---")
                {
                    if (in_number == Form_main.number)
                        textBox_text.Text += line.ToString() + System.Environment.NewLine;
                }
            }
            fi.Close();
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Edit_note edit_note = new Edit_note();
            edit_note.ShowDialog();
            this.Hide();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(this, "Вы действительно хотите удалить заметку?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                int count = Form_main.number;
                StreamReader file = new StreamReader(Form_main.file_name);
                StreamWriter new_file = new StreamWriter("new_note.txt", false);
                string line;
                for (int i = 0; i < count; ++i)
                {
                    line = file.ReadLine();
                    new_file.WriteLine(line);
                    line = file.ReadLine();
                    new_file.WriteLine(line);
                    while (line != "---###---")
                    {
                        line = file.ReadLine();
                        new_file.WriteLine(line);
                    }
                }
                line = file.ReadLine();
                line = file.ReadLine();
                while (line != "---###---")
                {
                    line = file.ReadLine();
                }
                while (!file.EndOfStream)
                {
                    line = file.ReadLine();
                    new_file.WriteLine(line);
                }
                new_file.Close();
                file.Close();
                StreamWriter file_edit = new StreamWriter(Form_main.file_name, false);
                StreamReader new_file_edit = new StreamReader("new_note.txt");
                while (!new_file_edit.EndOfStream)
                {
                    line = new_file_edit.ReadLine();
                    file_edit.WriteLine(line);

                }
                file_edit.Close();
                new_file_edit.Close();
                --Form_main.count_notes;
            }
            this.Hide();
            Form_main form = new Form_main();
            form.Show();
        }

        private void Form_main_Closed(object sender, FormClosedEventArgs e)
        {
            Form_main form = new Form_main();
            form.Show();
        }
    }
}
