using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using static System.Int32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QuảnLíChuyếnBay
{
    public partial class HeThong : Form
    {
        public HeThong()
        {
            InitializeComponent();
        }

<<<<<<< Updated upstream
=======
        private void HeThong_Load(object sender, EventArgs e)
        {

        }

        private void tabControl_Click(object sender, EventArgs e)
        {
        }

>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
        private void tabNhanVien_Click(object sender, EventArgs e)
        {
            List<NhanVien> list = new List<NhanVien>();


            dataNhanVien.DataSource = EmployeeServices.LoadEmployees();
        }
=======
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
            ///*Open PageEmployees*/
            //tabControl.SelectTab(pageEmployess);
            ///*Load Employees Data*/
            //List<Em> list = new List<NhanVien>();
            //dataNhanVien.DataSource = EmployeeServices.LoadEmployees();
        }


        private void btnFlight_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(pageFlight);
            var list = new List<Flight>();
            dataFlight.DataSource = FlightServices.LoadFlight();
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

        private void btn_AddFlight_Click(object sender, EventArgs e)
        {
            var flightId = Parse(textFlightID.Text);
            var planeId = Parse(textFLight_PlaneID.Text);
            var departure = textDepart.Text;
            var dateDeparture = dateTimeOfDepart.Value;
            var destination = textDesti.Text;
            var dateDestination = dateTimeOfDesti.Value;
            var airline = textAirline.Text;

            FlightServices.AddFlight(flightId, planeId, departure, dateDeparture, destination, dateDestination,
                airline);
            dataFlight.DataSource = FlightServices.LoadFlight();
        }

        private void btn_DelFlight_Click(object sender, EventArgs e)
        {
            int flightId = Parse(textFlightID.Text);
            FlightServices.DeleteFlight(flightId);
        }

        private void btn_EditFlight_Click(object sender, EventArgs e)
        {

        }

        private void dataFlight_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = this.dataFlight.Rows[e.RowIndex];
                textFlightID.Text = row.Cells[0].Value.ToString();
                textFLight_PlaneID.Text = row.Cells[1].Value.ToString();
                textDepart.Text = row.Cells[2].Value.ToString();
                dateTimeOfDepart.Text = row.Cells[3].Value.ToString();
                textDesti.Text = row.Cells[4].Value.ToString();
                dateTimeOfDesti.Text = row.Cells[5].Value.ToString();
                textAirline.Text = row.Cells[6].Value.ToString();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            textFlightID.Text = string.Empty;
            textFLight_PlaneID.Text = string.Empty;
            textDepart.Text = string.Empty;
            dateTimeOfDepart.Text = string.Empty;
            textDesti.Text = string.Empty;
            dateTimeOfDesti.Text = string.Empty;
            textAirline.Text = string.Empty;
        }

>>>>>>> Stashed changes
    }
}
