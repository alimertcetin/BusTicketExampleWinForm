
namespace BusTicketExample.Forms
{
    partial class frm_CreateBusLayout
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
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.lbl_SizeX = new System.Windows.Forms.Label();
            this.lbl_SizeY = new System.Windows.Forms.Label();
            this.txt_SizeX = new System.Windows.Forms.TextBox();
            this.txt_SizeY = new System.Windows.Forms.TextBox();
            this.btn_ApplySize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(547, 12);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(240, 191);
            this.txt_Log.TabIndex = 0;
            // 
            // lbl_SizeX
            // 
            this.lbl_SizeX.AutoSize = true;
            this.lbl_SizeX.Location = new System.Drawing.Point(547, 222);
            this.lbl_SizeX.Name = "lbl_SizeX";
            this.lbl_SizeX.Size = new System.Drawing.Size(37, 15);
            this.lbl_SizeX.TabIndex = 1;
            this.lbl_SizeX.Text = "Size X";
            // 
            // lbl_SizeY
            // 
            this.lbl_SizeY.AutoSize = true;
            this.lbl_SizeY.Location = new System.Drawing.Point(626, 222);
            this.lbl_SizeY.Name = "lbl_SizeY";
            this.lbl_SizeY.Size = new System.Drawing.Size(37, 15);
            this.lbl_SizeY.TabIndex = 2;
            this.lbl_SizeY.Text = "Size Y";
            // 
            // txt_SizeX
            // 
            this.txt_SizeX.Location = new System.Drawing.Point(547, 240);
            this.txt_SizeX.Name = "txt_SizeX";
            this.txt_SizeX.Size = new System.Drawing.Size(53, 23);
            this.txt_SizeX.TabIndex = 3;
            // 
            // txt_SizeY
            // 
            this.txt_SizeY.Location = new System.Drawing.Point(626, 240);
            this.txt_SizeY.Name = "txt_SizeY";
            this.txt_SizeY.Size = new System.Drawing.Size(53, 23);
            this.txt_SizeY.TabIndex = 4;
            // 
            // btn_ApplySize
            // 
            this.btn_ApplySize.Location = new System.Drawing.Point(698, 222);
            this.btn_ApplySize.Name = "btn_ApplySize";
            this.btn_ApplySize.Size = new System.Drawing.Size(89, 47);
            this.btn_ApplySize.TabIndex = 5;
            this.btn_ApplySize.Text = "Apply Size";
            this.btn_ApplySize.UseVisualStyleBackColor = true;
            this.btn_ApplySize.Click += new System.EventHandler(this.btn_ApplySize_Click);
            // 
            // frm_CreateBusLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 404);
            this.Controls.Add(this.btn_ApplySize);
            this.Controls.Add(this.txt_SizeY);
            this.Controls.Add(this.txt_SizeX);
            this.Controls.Add(this.lbl_SizeY);
            this.Controls.Add(this.lbl_SizeX);
            this.Controls.Add(this.txt_Log);
            this.KeyPreview = true;
            this.Name = "frm_CreateBusLayout";
            this.Text = "frm_CreateBusLayout";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_CreateBusLayout_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.Label lbl_SizeX;
        private System.Windows.Forms.Label lbl_SizeY;
        private System.Windows.Forms.TextBox txt_SizeX;
        private System.Windows.Forms.TextBox txt_SizeY;
        private System.Windows.Forms.Button btn_ApplySize;
    }
}