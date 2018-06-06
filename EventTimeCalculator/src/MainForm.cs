using System;
using System.Windows.Forms;

namespace BladeAndSoul.EventTimeCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ActiveControl = label1; // To hide cursor
        }

        private void ShowNextEventTimes(object sender, EventArgs e)
        {
            var nextEventTimes = Calculator.GetNextEventTimes(
                    dateTimePicker.Value,
                    Decimal.ToUInt32(numericUpDown.Value)
            );

            var items = listBoxNextEventTimes.Items;
            items.Clear();
            foreach(var time in nextEventTimes)
            {
                items.Add(time.ToString() + " 出字");
            }
        }
    }
}
