namespace Backoffice
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblinfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.ListBox();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.lbtime = new System.Windows.Forms.ListBox();
            this.btnshiporder = new System.Windows.Forms.Button();
            this.btnupdateorder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblinfo);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 31);
            this.panel1.TabIndex = 0;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(3, 6);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 18);
            this.lblinfo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(26, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 27);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Orded Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(176, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 27);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time Ordered";
            // 
            // lbid
            // 
            this.lbid.FormattingEnabled = true;
            this.lbid.Location = new System.Drawing.Point(26, 90);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(134, 121);
            this.lbid.TabIndex = 3;
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(64, 96);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(8, 8);
            this.printPreviewControl1.TabIndex = 4;
            // 
            // lbtime
            // 
            this.lbtime.FormattingEnabled = true;
            this.lbtime.Location = new System.Drawing.Point(176, 96);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(138, 121);
            this.lbtime.TabIndex = 5;
            // 
            // btnshiporder
            // 
            this.btnshiporder.Location = new System.Drawing.Point(44, 234);
            this.btnshiporder.Name = "btnshiporder";
            this.btnshiporder.Size = new System.Drawing.Size(111, 23);
            this.btnshiporder.TabIndex = 6;
            this.btnshiporder.Text = "Ship Order";
            this.btnshiporder.UseVisualStyleBackColor = true;
            this.btnshiporder.Click += new System.EventHandler(this.btnshiporder_Click);
            // 
            // btnupdateorder
            // 
            this.btnupdateorder.Location = new System.Drawing.Point(191, 234);
            this.btnupdateorder.Name = "btnupdateorder";
            this.btnupdateorder.Size = new System.Drawing.Size(111, 23);
            this.btnupdateorder.TabIndex = 7;
            this.btnupdateorder.Text = "Update Order";
            this.btnupdateorder.UseVisualStyleBackColor = true;
            this.btnupdateorder.Click += new System.EventHandler(this.btnupdateorder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 266);
            this.Controls.Add(this.btnupdateorder);
            this.Controls.Add(this.btnshiporder);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.Button btnshiporder;
        private System.Windows.Forms.Button btnupdateorder;
        public System.Windows.Forms.ListBox lbid;
        public System.Windows.Forms.ListBox lbtime;
    }
}

