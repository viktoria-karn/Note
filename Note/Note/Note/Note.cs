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


            StreamReader fi = new StreamReader("note.txt", true);
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
    }
}
