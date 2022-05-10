
namespace BusTicketExample.Forms
{
    partial class Frm_TicketSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.flp_seats = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.Location = new System.Drawing.Point(526, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Seat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // flp_seats
            // 
            this.flp_seats.Location = new System.Drawing.Point(12, 12);
            this.flp_seats.Name = "flp_seats";
            this.flp_seats.Size = new System.Drawing.Size(589, 136);
            this.flp_seats.TabIndex = 1;
            // 
            // Frm_TicketSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 215);
            this.Controls.Add(this.flp_seats);
            this.Controls.Add(this.button1);
            this.Name = "Frm_TicketSelection";
            this.Text = "Frm_TicketSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flp_seats;
    }
}