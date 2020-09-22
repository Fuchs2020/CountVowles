using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountVowles
{
    public partial class windowMain : Form
    {
        public windowMain()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            String Paragraph = txtBoxEntry.Text.ToLower();
            int vowelCount =0;

            for(int i = 0; i<Paragraph.Length; i++)
            {
                if(Paragraph[i] == 'a' || Paragraph[i] == 'e' || Paragraph[i] == 'i' || Paragraph[i] == 'o' || Paragraph[i] == 'u')
                {
                    vowelCount++;
                }
            }

            txtCountAns.Text = Convert.ToString(vowelCount);

        }

        private void txtBoxEntry_TextChanged(object sender, EventArgs e)
        {

            txtCountAns.Text = Convert.ToString(' ');

        }
    }
}
