using System.Collections.Generic;
using System.Windows.Forms;

namespace BusTicketExample.Forms
{
    using XIV.Utils;

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