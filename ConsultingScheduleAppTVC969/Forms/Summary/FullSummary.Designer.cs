
namespace ConsultingScheduleApp.Forms.Summary
{
    partial class FormCumulativeSummary
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
            this.dgCumulativeTotalCount = new System.Windows.Forms.DataGridView();
            this.OverAllCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCumulativeAppointmentCount = new System.Windows.Forms.Label();
            this.btnExitCumulativeCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCumulativeTotalCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCumulativeTotalCount
            // 
            this.dgCumulativeTotalCount.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgCumulativeTotalCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCumulativeTotalCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OverAllCount,
            this.TotalCount});
            this.dgCumulativeTotalCount.Location = new System.Drawing.Point(157, 105);
            this.dgCumulativeTotalCount.Name = "dgCumulativeTotalCount";
            this.dgCumulativeTotalCount.RowHeadersWidth = 51;
            this.dgCumulativeTotalCount.RowTemplate.Height = 24;
            this.dgCumulativeTotalCount.Size = new System.Drawing.Size(485, 225);
            this.dgCumulativeTotalCount.TabIndex = 0;
            this.dgCumulativeTotalCount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCumulativeTotalCount_CellContentClick);
            // 
            // OverAllCount
            // 
            this.OverAllCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OverAllCount.HeaderText = "Cumulative Appointment:";
            this.OverAllCount.MinimumWidth = 6;
            this.OverAllCount.Name = "OverAllCount";
            // 
            // TotalCount
            // 
            this.TotalCount.HeaderText = "Total Count";
            this.TotalCount.MinimumWidth = 6;
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Width = 125;
            // 
            // lblCumulativeAppointmentCount
            // 
            this.lblCumulativeAppointmentCount.AutoSize = true;
            this.lblCumulativeAppointmentCount.BackColor = System.Drawing.Color.White;
            this.lblCumulativeAppointmentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumulativeAppointmentCount.Location = new System.Drawing.Point(144, 41);
            this.lblCumulativeAppointmentCount.Name = "lblCumulativeAppointmentCount";
            this.lblCumulativeAppointmentCount.Size = new System.Drawing.Size(498, 25);
            this.lblCumulativeAppointmentCount.TabIndex = 1;
            this.lblCumulativeAppointmentCount.Text = "OverAll Count of All Appointments For The Current Year";
            this.lblCumulativeAppointmentCount.Click += new System.EventHandler(this.lblCumulativeAppointmentCount_Click);
            // 
            // btnExitCumulativeCount
            // 
            this.btnExitCumulativeCount.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExitCumulativeCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitCumulativeCount.Location = new System.Drawing.Point(521, 369);
            this.btnExitCumulativeCount.Name = "btnExitCumulativeCount";
            this.btnExitCumulativeCount.Size = new System.Drawing.Size(121, 43);
            this.btnExitCumulativeCount.TabIndex = 3;
            this.btnExitCumulativeCount.Text = "Exit";
            this.btnExitCumulativeCount.UseVisualStyleBackColor = false;
            this.btnExitCumulativeCount.Click += new System.EventHandler(this.btnExitCumulativeCount_Click);
            // 
            // FormCumulativeSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitCumulativeCount);
            this.Controls.Add(this.lblCumulativeAppointmentCount);
            this.Controls.Add(this.dgCumulativeTotalCount);
            this.Name = "FormCumulativeSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cumulative Summary";
            this.Load += new System.EventHandler(this.FormCumulativeSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCumulativeTotalCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCumulativeTotalCount;
        private System.Windows.Forms.Label lblCumulativeAppointmentCount;
        private System.Windows.Forms.Button btnExitCumulativeCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverAllCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCount;
    }
}