using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }

        public int Checked
        {
            get
            {
                if (checkBox1.Checked)
                    return 1;
                else
                    return 0;
            }
            set
            {
                if (value == 1)
                {
                  
                    checkBox1.Checked = true;
                }
                else
                {
                 
                    checkBox1.Checked = false;


                }
            }
        }

        public int FieldIndex
        {
            set { lblindex.Text = value.ToString(); }
        }

        private void FormCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
