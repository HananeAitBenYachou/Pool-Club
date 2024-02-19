using PoolClub.Properties;
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
    public partial class ucPoolTable : UserControl
    {
        private struct stTimer
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            public stTimer(int hours, int minutes, int seconds)
            {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }

            public override string ToString()
            {
                return string.Format("{0:D2}:{1:D2}:{2:D2}", this.Hours, this.Minutes, this.Seconds);
            }

        }
        public class TableReservationCompletedEventArgs : EventArgs
        {
            public int TimeInSeconds { get; }

            public string TotalTimeConsumedText { get; }

            public double RatePerHour { get; }

            public double TotalFees { get; }

            public TableReservationCompletedEventArgs(int timeInSeconds, string totalTimeConsumedText, double ratePerHour, double totalFees)
            {
                TimeInSeconds = timeInSeconds;
                TotalTimeConsumedText = totalTimeConsumedText;
                RatePerHour = ratePerHour;
                TotalFees = totalFees;
            }

        }


        public event EventHandler<TableReservationCompletedEventArgs> TableReservationCompleted;
        private void OnTableReservationCompleted()
        {
            OnTableReservationCompleted(new TableReservationCompletedEventArgs
                (_GetTotalTimeConsumedInSeconds(), _Timer.ToString(), _HourlyRate, _GetTotalFees()));
        }
        protected virtual void OnTableReservationCompleted(TableReservationCompletedEventArgs e)
        {
            TableReservationCompleted?.Invoke(this, e);
        }


        private stTimer _Timer;

        private bool _IsTableReserved = false;


        #region Pool Table Config

        private string _TablePlayerName = "Table";

        private string _TableTitle = "Player";

        private double _HourlyRate = 10.0;

        [
           Category("Pool Config"),
           Description("The player name.")
        ]
        public string TablePlayerName
        {
            get
            {
                return _TablePlayerName;
            }

            set
            {
                _TablePlayerName = value;
                lblPlayerName.Text = value;

                Invalidate();
            }
        }


        [
           Category("Pool Config"),
           Description("The table name.")
        ]
        public string TableTitle
        {
            get
            {
                return _TableTitle;
            }

            set
            {
                _TableTitle = value;
                gbPoolTable.Text = value;

                Invalidate();
            }
        }


        [
           Category("Pool Config"),
           Description("The rate per hour.")
        ]
        public double HourlyRate
        {
            get
            {
                return _HourlyRate;
            }

            set
            {
                _HourlyRate = value;
            }
        }

        #endregion

        public ucPoolTable()
        {
            InitializeComponent();
            btnEnd.Enabled = false;
        }

        private void _ResetToDefault()
        {
            btnStartStop.Text = "Start";

            TableTitle = "Table";
            TablePlayerName = "Player";
            HourlyRate = 10;

            _IsTableReserved = false;
            btnEnd.Enabled = false;

            _Timer = new stTimer(0,0,0);
            lblTime.Text = _Timer.ToString();
        }

        private void _ReserveTheTable()
        {
            _IsTableReserved = true;
            btnEnd.Enabled = true;

            _Timer = new stTimer(0, 0, 0);
            gameTimer.Start();
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!_IsTableReserved)
                _ReserveTheTable();

            if (btnStartStop.Text == "Stop")
            {              
                btnStartStop.Text = "Start";
                gameTimer.Stop();
            }

            else
            {
                btnStartStop.Text = "Stop";
                gameTimer.Start();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            gameTimer.Stop();
            OnTableReservationCompleted();
            _ResetToDefault();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            _IncrementTimer();
            lblTime.Text = _Timer.ToString();
        }

        private void btnStartStop_TextChanged(object sender, EventArgs e)
        {
            btnStartStop.Image = btnStartStop.Text == "Start" ? Resources.start : Resources.stop;
        }

        private void _IncrementTimer()
        {
            _Timer.Seconds++;

            if (_Timer.Seconds == 60)
            {
                _Timer.Seconds = 0;
                _Timer.Minutes++;
            }

            if (_Timer.Minutes == 60)
            {
                _Timer.Seconds = 0;
                _Timer.Minutes = 0;
                _Timer.Hours++;
            }          
        }

        private double _GetTotalFees()
        {
            double totalFees = (_GetTotalTimeConsumedInSeconds() / 3600.0)  * _HourlyRate;
            return totalFees;
        }

        private int _GetTotalTimeConsumedInSeconds()
        {
            int totalMinutes = _Timer.Minutes + _Timer.Hours * 60;
            int totalSeconds = _Timer.Seconds + totalMinutes * 60;

            return totalSeconds;
        }
    }
}
