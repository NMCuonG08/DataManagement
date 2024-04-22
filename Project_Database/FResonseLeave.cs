using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Database
{
    public partial class FResonseLeave : Form
    {
        int DateOffID;
        public string confirmLeave= "";
        public FResonseLeave(int dateOffID)
        {
            InitializeComponent();
            this.DateOffID = dateOffID;
        }

        public delegate void Confirm(int dateoffID,string  response,string confirm);
        public Confirm confirm;


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            confirm(DateOffID,txb_feedback.Text, confirmLeave);
            this.Close();
        }
    }
}
