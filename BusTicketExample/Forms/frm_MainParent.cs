using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIV.Utils;

namespace BusTicketExample.Forms
{
    public partial class frm_MainParent : Form
    {
        public frm_MainParent()
        {
            InitializeComponent();
            var l = new List<string>()
            {
                "1", "2", "3", "4", "5",
                "6",
            };
            FormUtils.OpenForm<Frm_TicketSelection>(this).Initialize(l);
            FormUtils.OpenForm<frm_CreateBusLayout>(this);
        }

    }
}