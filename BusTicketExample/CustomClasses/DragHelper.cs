using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BusTicketExample.Forms
{
    public class DragHelper
    {
        private Control selectedControl;
        private Point previousLocation;

        private List<Control> controls = new List<Control>();
        private TextBox txt_Log;

        public DragHelper(TextBox txt_Log)
        {
            this.txt_Log = txt_Log;
        }

        public DragHelper()
        {

        }

        public void Add(Control control)
        {
            if (!controls.Contains(control))
            {
                control.MouseDown += OnDragStarted;
                control.MouseUp += OnDragEnded;
                control.MouseMove += OnDrag;
                controls.Add(control);
            }
        }

        private void OnDragStarted(object sender, MouseEventArgs e)
        {
            SetControl((Control)sender, e.Location);
            for (int i = 0; i < 10; i++)
            {
                Log("OnDragStarted");
            }
        }

        private void OnDragEnded(object sender, MouseEventArgs e)
        {
            Release();
            for (int i = 0; i < 10; i++)
            {
                Log("OnDragEnded");
            }
        }

        private void OnDrag(object sender, MouseEventArgs e)
        {
            Update(e.Location);
            Log(e.Location.ToString());
        }

        public void SetControl(Control control, Point mousePos)
        {
            this.previousLocation = mousePos;
            this.selectedControl = control;
        }

        public void Release() => selectedControl = null;

        public void Update(Point position)
        {
            if (selectedControl != null)
            {
                var location = selectedControl.Location;
                location.Offset(position.X - previousLocation.X, position.Y - previousLocation.Y);
                selectedControl.Location = location;
            }
        }

        List<string> logList = new List<string>();
        private void Log(string s)
        {
            if (txt_Log == null) return;

            logList.Add(s + Environment.NewLine);
            txt_Log.Clear();
            for (int i = 0; i < logList.Count; i++)
            {
                txt_Log.Text += logList[i];
            }
            if (logList.Count > 10)
            {
                logList.RemoveAt(0);
            }
        }
    }
}
