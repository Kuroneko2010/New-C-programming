using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29.Phonebook_I
{
    public partial class User_Interface : UserControl
    {
        private Form1 parentForm;
        public User_Interface(Info profile, Form1 parent)
        {
            InitializeComponent();
            parentForm = parent;

        }

        private void User_Interface_Load(object sender, EventArgs e)
        {

        }

        public class Info
        {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Address { get; set; }
            public string Relationship { get; set; }
        }
    }
}
