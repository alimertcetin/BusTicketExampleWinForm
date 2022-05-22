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
        private ControlDragger controlDragger;
        private ControlSelector controlSelector;
        private ControlResizer controlResizer;
        private Size controlSize;
        private enum Mode
        {
            None = 0,
            Drag = 1,
            Size = 2,
            LenghtOfMode
        }
        private int currentMode;

        public frm_CreateBusLayout()
        {
            InitializeComponent();
            this.Select();
            controlSelector = new ControlSelector(this);
            controlDragger = new ControlDragger(this);
            controlResizer = new ControlResizer();
            controlSelector.SelectionChanged += HandleSelection;
            txt_Log.Text = nameof(Mode) + " : " + EnumUtils.GetNameByIndex<Mode>(currentMode);
        }

        private void frm_CreateBusLayout_KeyUp(object sender, KeyEventArgs e)
        {
            if (!this.CanFocus) return;

            if(e.KeyCode == Keys.A)
            {
                if (controlSize.Width == 0 || controlSize.Height == 0)
                {
                    MessageBox.Show("Apply a legit size");
                    return;
                }
                Button button = new Button();
                Controls.Add(button);
                button.Size = controlSize;
            }
            else if (e.KeyCode == Keys.F)
            {
                txt_Log.Clear();
            }
            else if (e.KeyCode == Keys.R)
            {
                // Go to next mode
                currentMode++;
                if(currentMode == (int)Mode.LenghtOfMode)
                {
                    currentMode = 0;
                }
                txt_Log.Text = nameof(Mode) + " : " +EnumUtils.GetNameByIndex<Mode>(currentMode);
                OnModeChanged(EnumUtils.GetValueByIndex<Mode>(currentMode));
            }
        }

        private void btn_ApplySize_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var buttonSize = button.Size;
            try
            {
                int x = int.Parse(txt_SizeX.Text);
                int y = int.Parse(txt_SizeY.Text);
                controlSize = new Size(x, y);
                FormUtils.SetSizeOfType<Button>(controlSize, this);
                button.Size = buttonSize;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HandleSelection(bool isSelected, ControlSelector controlSelector)
        {
            var current = EnumUtils.GetValueByIndex<Mode>(currentMode);
            if (!isSelected)
            {
                switch (current)
                {
                    case Mode.None:
                        break;
                    case Mode.Drag:
                        controlDragger.Remove(controlSelector.Selection);
                        break;
                    case Mode.Size:
                        controlResizer.Remove(controlSelector.Selection);
                        break;
                    case Mode.LenghtOfMode:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (current)
                {
                    case Mode.None:
                        break;
                    case Mode.Drag:
                        controlDragger.Add(controlSelector.Selection);
                        break;
                    case Mode.Size:
                        controlResizer.Add(controlSelector.Selection);
                        break;
                    case Mode.LenghtOfMode:
                        break;
                    default:
                        break;
                }
            }
        }

        private void ClearSelection()
        {
            controlDragger.Remove(controlSelector.Selection);
            controlResizer.Remove(controlSelector.Selection);
        }

        private void OnModeChanged(Mode currentMode)
        {
            ClearSelection();
            switch (currentMode)
            {
                case Mode.Drag:
                    controlDragger.Add(controlSelector.Selection);
                    break;
                case Mode.Size:
                    controlResizer.Add(controlSelector.Selection);
                    break;
                default:
                    break;
            }
        }
    }
}
