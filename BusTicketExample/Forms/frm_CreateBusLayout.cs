using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XIV.Utils;

namespace BusTicketExample.Forms
{
    public partial class frm_CreateBusLayout : Form
    {
        private DragHelper dragHelper;
        private Point controlSize;

        public frm_CreateBusLayout()
        {
            InitializeComponent();
            this.Select();
            dragHelper = new DragHelper(txt_Log);
        }

        private void frm_CreateBusLayout_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                if (controlSize.X == 0 || controlSize.Y == 0)
                {
                    MessageBox.Show("Apply a legit size");
                    return;
                }
                Button button = FormUtils.CreateDraggableControl<Button>(this);
                button.Size = new Size(controlSize);
                this.dragHelper.Add(button);
                this.Controls.Add(button);
            }
            if (e.KeyCode == Keys.F) txt_Log.Clear();
        }

        private void btn_ApplySize_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txt_SizeX.Text);
                int y = int.Parse(txt_SizeY.Text);
                controlSize = new Point(x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
