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
    public partial class Planner_note : Form
    {
        public Planner_note()
        {
            InitializeComponent();
        }

        private void Planner_note_Load(object sender, EventArgs e)
        {
            textBox_title.Font = new Font("Georgia", this.Height / 25);
            textBox_date.Font = new Font("Georgia", this.Height / 25);
            textBox_deadline.Font = new Font("Georgia", this.Height / 25);
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
                line = fi.ReadLine();
                textBox_deadline.Text = line.ToString() + System.Environment.NewLine;
                while ((line = fi.ReadLine()) != "---###---")
                {
                    if (in_number == Form_main.number)
                        textBox_text.Text += line.ToString() + System.Environment.NewLine;
                }
            }
            fi.Close();
        }

        private void Planner_note_closed(object sender, FormClosedEventArgs e)
        {
            Form_main form = new Form_main();
            form.Show();
        }
    }
}
