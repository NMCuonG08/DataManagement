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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }
        public void ShowForm(Form form)
        {

            form.MdiParent = this;
            form.Show();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
        }
        FEmployee fEmployee;

        private void FAdmin_Load(object sender, EventArgs e)
        {
           
            fEmployee = new FEmployee();
            fEmployee.FormClosed += FEmployee_FormClosed;
            ShowForm(fEmployee);
         
        }

        private void FEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            fEmployee = null;
        }
        FSalaryInfor fSalaryInfor;
        private void btn_salary_Click(object sender, EventArgs e)
        {
          
                fSalaryInfor = new FSalaryInfor();
                fSalaryInfor.FormClosed += FSalaryInfor_FormClosed;
                ShowForm(fSalaryInfor);

        }

        private void FSalaryInfor_FormClosed(object sender, FormClosedEventArgs e)
        {
            fSalaryInfor = null;
        }

        FEmployeeDepartment fChangeDepartment;
        private void btn_change_Click(object sender, EventArgs e)
        {
            
                fChangeDepartment = new FEmployeeDepartment();
                fChangeDepartment.FormClosed += FChangeDepartment_FormClosed; ;
                ShowForm(fChangeDepartment);

           
        }

        private void FChangeDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            fChangeDepartment = null;
        }
        
        private void btn_employee_Management_Click(object sender, EventArgs e)
        {
            FAdmin_Load(sender,e);
        }
        FConfirmLeave confirmLeave;
        private void btn_leave_Click(object sender, EventArgs e)
        {
                confirmLeave = new FConfirmLeave();
                confirmLeave.FormClosed += ConfirmLeave_FormClosed;
                ShowForm(confirmLeave);

           

        }

        private void ConfirmLeave_FormClosed(object sender, FormClosedEventArgs e)
        {
            confirmLeave = null;
        }
        FDepartmentManagement fDepartment;
        private void btn_department_Click(object sender, EventArgs e)
        {
           
                fDepartment = new FDepartmentManagement();
                fDepartment.FormClosed += FDepartment_FormClosed; ;
                ShowForm(fDepartment);

        }

        private void FDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            fDepartment = null;
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {

        }
    }
}
