using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomobileLibrary.BusinessObject;
using AutomobileLibrary.Repository;

namespace WindowsForm
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }

        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; } //False: insert, True: update
        public Car CarInfo {  get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car(int.Parse(txtCarID.Text), txtCarName.Text,cboManufacturer.Text, decimal.Parse(txtPrice.Text), int.Parse(txtReleaseYear.Text));
                if (InsertOrUpdate)
                {
                    CarRepository.updateCar(car);
                }
                else
                {
                    CarRepository.insertCar(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate ? "Update a car" : "Add a new car");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmCarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.ReleaseYear.ToString();
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
            }
        }
    }
}
