using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace IQP_Tester
{
    public partial class Main : Form
    {
        delegate void VoidDelegate();

        KidsToys kidsToys;
        Food food;
        WhoCeascu whoCeascu;

        bool kidsToysShow = false;
        bool foodShow = false;
        bool whoCeascuShow = false;

        private System.Timers.Timer Timer;
        static uint tabTimeout = 10;
        uint lastOpenTime = 0;
        uint seconds = 0;

        public Main()
        {
            InitializeComponent();
            SetTimer();
        }

        private void SetTimer()
        {
            Timer = new System.Timers.Timer(1000);
            Timer.Elapsed += OnTimedEvent;
            Timer.AutoReset = true;
            Timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            seconds++;
            Invoke(new VoidDelegate(Second_Trigger));
            if (seconds == lastOpenTime + tabTimeout)
            {
                 Invoke(new VoidDelegate(CloseAllTabs));
            }
        }

        private void Second_Trigger()
        {
            lblUptime.Text = seconds.ToString();
        }

        private void KidsLifeToys_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            lastOpenTime = seconds;
            kidsToys = new KidsToys();
            kidsToys.Show();
            kidsToysShow = true;
        }

        private void KidsLifeFood_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            lastOpenTime = seconds;
            food = new Food();
            food.Show();
            foodShow = true;
        }

        private void HistoryCeasecu_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
            lastOpenTime = seconds;
            whoCeascu = new WhoCeascu();
            whoCeascu.Show();
            whoCeascuShow = true;
        }

        private void CloseAllTabs()
        {
            if (kidsToys != null)
            {
                kidsToys.Close();
            }
            
            if (food != null)
            {
                food.Close();
            }

            if (whoCeascu != null)
            {
                whoCeascu.Close();
            }
        }
    }
}
