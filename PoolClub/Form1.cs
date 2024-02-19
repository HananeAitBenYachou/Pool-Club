using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolClub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ucPoolTable_OnTableReservationCompleted(object sender, ucPoolTable.TableReservationCompletedEventArgs e)
        {
            StringBuilder details = new StringBuilder();

            details.AppendLine($"Time consumed = {e.TotalTimeConsumedText} ,");
            details.AppendLine($"Total Seconds = {e.TimeInSeconds} sec ,");
            details.AppendLine($"Hourly Rate = {e.RatePerHour} MAD ,");
            details.AppendLine($"Total Fees = {e.TotalFees.ToString("F3")} MAD .");

            MessageBox.Show($"{details}", "Reservation is completed !", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
