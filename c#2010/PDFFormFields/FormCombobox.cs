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
    public partial class FormCombobox : Form
    {
        public FormCombobox()
        {
            InitializeComponent();
        }

        public int FieldIndex
        {
            set { lblindex.Text = value.ToString(); }
        }

        public int ComboBoxIndex
        {
            get { return Convert.ToInt32(txtcomboboxindex.Text); }
            set { txtcomboboxindex.Text = value.ToString(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormCombobox_Load(object sender, EventArgs e)
        {

        }
    }
}
