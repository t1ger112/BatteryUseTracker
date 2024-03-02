using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bet1
{
    public partial class AddDevice : Form
    {

        string connectionString = "Data Source=DESKTOP-ACMRQ8P;Initial Catalog=db_BatteryApp;Integrated Security=True;";

        public AddDevice()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            string deviceName = deviceNameTB.Text;

            string watt = batterySizeCB.SelectedItem.ToString();

            int lifetimeHours = int.Parse(lifetimeTB.Text);

            devices newDeviceAdded = new devices(deviceName, watt, lifetimeHours, null, null, null);


            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                cnn.Open();

                using(SqlCommand cmd = new SqlCommand("appendDevice", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@givenDeviceName", deviceName);
                    cmd.Parameters.AddWithValue("@givenBattery", watt);
                    cmd.Parameters.AddWithValue("@givenlifetime", lifetimeHours);

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                cnn.Close();
            }
            MessageBox.Show("Data has been added", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
