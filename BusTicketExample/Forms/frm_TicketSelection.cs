using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XIV.Utils;

namespace BusTicketExample.Forms
{
    public partial class Frm_TicketSelection : Form
    {
        public const int buttonWidth = 46;
        public const int buttonHeight = 40;

        public Frm_TicketSelection()
        {
            InitializeComponent();
        }

        public void Initialize(List<string> seats)
        {
            FlpUtils.FillWithObject<Button, string>(flp_seats, seats);
            foreach (Button item in flp_seats.Controls)
            {
                item.Size = new Size(buttonWidth, buttonHeight);
                item.Click += OnSeatButtonClicked;
            }
        }

        private void OnSeatButtonClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            var button = (Button)sender;
            button.Click -= OnSeatButtonClicked;
            //button.Text // = seat number
        }
    }
}
