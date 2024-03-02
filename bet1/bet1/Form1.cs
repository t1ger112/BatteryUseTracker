using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bet1
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source=DESKTOP-ACMRQ8P;Initial Catalog=db_BatteryApp;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
            loaddataviewer();
        }




        private void loaddataviewer()
        {

            DataTable dataTable = new DataTable();

            string query = "SELECT * FROM tbl_device";

            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);

                // Open the connection
                cnn.Open();

                // Fill the DataTable with the data from the query
                adapter.Fill(dataTable);
            }
            dataviewer.DataSource = dataTable;
        }

        private void addDevice_Click(object sender, EventArgs e)
        {
            //addDevicePanel.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            //addDevicePanel.Visible = false;


        }

        private void addBatteryBTN_Click(object sender, EventArgs e)
        {
            AddDevice addDevice = new AddDevice();
            addDevice.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataviewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Check if the clicked cell is valid
            {

                DataGridViewRow selectedRow = dataviewer.Rows[e.RowIndex];
                var ee = selectedRow.Cells[0].Value.ToString();
                var name = selectedRow.Cells[1].Value.ToString();
                var batterySize = selectedRow.Cells[2].Value.ToString();
                var lifetime = selectedRow.Cells[3].Value.ToString();
                var ee4 = selectedRow.Cells[4].Value.ToString();
                var ee5 = selectedRow.Cells[5].Value.ToString();
                var ee6 = selectedRow.Cells[6].Value.ToString();

                nameTBPro.Text = name;
                lifetimeTBPro.Text = lifetime;
                batteryTBPro.Text = batterySize;




            }
        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            loaddataviewer();
        }

        private void SignBTN_Click(object sender, EventArgs e)
        {

            // Takes the timestamp the device was signed out and then finds the time when it is signed back in
            // and then will add this to the total time the battery every has been used

            var timestamp = DateTime.Now.Minute;

            var timestampout = DateTime.Now.Minute;

            var eee = timestamp - timestampout;
        }
    }
}
