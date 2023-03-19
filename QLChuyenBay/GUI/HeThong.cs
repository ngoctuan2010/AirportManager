using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;


namespace QuảnLíChuyếnBay
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

        private void HeThong_Load(object sender, EventArgs e)
        {
      
        }

        private void tabControll_Click(object sender, EventArgs e)
        {
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        /*EMPLOYEES CONTROLLER*/
        private void AddEmployee_Click(object sender, EventArgs e)
        {   
            
        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void btnClearEmployee_Click(object sender, EventArgs e)
        {

        }
        private void btnEmployess_Click(object sender, EventArgs e)
        {   
            /*Open PageEmployees*/
            tabControl.SelectTab(pageEmployess);
            /*Load Employees Data*/
            List<NhanVien> list = new List<NhanVien>();
            dataNhanVien.DataSource = EmployeeServices.LoadEmployees();
        }
       

        /*FLIGHT CONTROLLER*/
        private void btnFlight_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(pageFlight);
           
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(pageTickets);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(pageCustomers);
        }

        private void btnPlane_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(pagePlane);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(pageReport);
        }

        private void btnCloseSystem_Click(object sender, EventArgs e)
        {
            Close();
        }

     
    }
}
