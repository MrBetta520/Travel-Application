using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightForm1;

namespace Trvel
{
    public partial class form2 : Form
    {
        Flight1 flight;
        public form2()
        {
            InitializeComponent();
        }

        private void btnFlight_Click(object sender, EventArgs e)
        {
            groupBoxFlight.Visible = true;
        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            flight = new Flight1();
            flight.From = (string)comboBoxFrom.SelectedItem;
            flight.To = (string)comboBoxTo.SelectedItem;
            flight.Class = (string)comboBoxClass.SelectedItem;
            flight.Passenger = (string)comboBoxPassenger.SelectedItem;
            flight.Type = radioButtonRound.Checked ? radioButtonRound.Text : radioButtonOne.Text;
            flight.DepartDate = dateTimePickerDepart.Value.ToShortDateString();
            flight.ReturnDate = dateTimePickerReturn.Value.ToShortDateString();

            groupBoxFlight.Visible = false;

            // Pop out a message box once customer's booking successful.
            MessageBox.Show($"Dear customer:\nYour booking information is being processed. Here is your booking information:\n" +
                $"Your flight type is: {flight.Type}.\nFrom: {flight.From}\n" +
                $"To: {flight.To}\nClass: {flight.Class}\nPassenger number: {flight.Passenger}\n" +
                $"Depart Date: {flight.DepartDate}\nReturn Date: {flight.ReturnDate}\n" +
                $"If any information is incorrect, please contact our customer service.");

            // Generate a file, that contains customer booking information.
            string path = @"C:\Users\Yang Yu\Desktop\MSSA\PACD5\Practice\Trvel\Customer Booking Info.txt";
            string data = $"**************************************************\n" +
                $"Flight type: {flight.Type}.\nFrom: {flight.From}\n" +
                $"To: {flight.To}\nClass: {flight.Class}\nPassenger number: {flight.Passenger}\n" +
                $"Depart Date: {flight.DepartDate}\nReturn Date: {flight.ReturnDate}\n";
            File.AppendAllText(path, data);
        }

        private void btnBlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            Blog blog = new Blog();
            blog.Show();
        }

        private void form2_Load(object sender, EventArgs e)
        {
            groupBoxFlight.Visible = false;
        }
    }
}
