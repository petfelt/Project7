using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class PricesForm : Form
    {
        private string connectionString = "Data Source=(local); integrated security=SSPI; Database=Project6";
        private SqlConnection connection = new SqlConnection();
        public PricesForm()
        {
            InitializeComponent();

            try
            {
                connection.ConnectionString = connectionString;

                UpdatePrices();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdatePrices()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select * From Prices Where ID='0'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dt = dataSet.Tables[0];

            ChocolatePrice.Text = dt.Rows[0][0].ToString();
            VanillaPrice.Text = dt.Rows[0][1].ToString();
            StrawberryPrice.Text = dt.Rows[0][2].ToString();

            SprinklesPrice.Text = dt.Rows[0][3].ToString();
            ChoppedNutsPrice.Text = dt.Rows[0][4].ToString();
            CherryPrice.Text = dt.Rows[0][5].ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            decimal choc, van, straw, sprink, chop, cherry;
            decimal.TryParse(ChocolatePrice.Text, out choc);
            decimal.TryParse(VanillaPrice.Text, out van);
            decimal.TryParse(StrawberryPrice.Text, out straw);
            decimal.TryParse(SprinklesPrice.Text, out sprink);
            decimal.TryParse(ChoppedNutsPrice.Text, out chop);
            decimal.TryParse(CherryPrice.Text, out cherry);

            if (choc != 0 && van != 0 && straw != 0 && sprink != 0 && chop != 0 && cherry != 0)
            {
                connection.Open();
                string sqlString = "Update Prices Set ChocolatePrice ="
                    + "'" + choc + "'" + ", VanillaPrice = "
                    + "'" + van + "'" + ", StrawberryPrice = "
                    + "'" + straw + "'" + ", SprinklesPrice = "
                    + "'" + sprink + "'" + ", ChoppedNutsPrice = "
                    + "'" + chop + "'" + ", CherryPrice = "
                    + "'" + cherry + "' Where ID='0'";

                SqlCommand command = new SqlCommand(sqlString, connection);

                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Prices updated!");

                Close();
            }
            else
            {
                MessageBox.Show("Some prices are formatted incorrectly or are equal to zero. Try again!");
            }
        }
    }
}
