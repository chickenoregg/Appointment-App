
namespace ConsultingScheduleApp.Forms
{
    partial class FormCalendarView
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
            this.dgCalendarViewWeekMonth = new System.Windows.Forms.DataGridView();
            this.rbtnCalendarWeeklyView = new System.Windows.Forms.RadioButton();
            this.rbtnCalendarMonthlyView = new System.Windows.Forms.RadioButton();
            this.lblCalendarView = new System.Windows.Forms.Label();
            this.btnExitCalendar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCalendarViewWeekMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCalendarViewWeekMonth
            // 
            this.dgCalendarViewWeekMonth.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgCalendarViewWeekMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCalendarViewWeekMonth.Location = new System.Drawing.Point(162, 66);
            this.dgCalendarViewWeekMonth.Name = "dgCalendarViewWeekMonth";
            this.dgCalendarViewWeekMonth.RowHeadersWidth = 51;
            this.dgCalendarViewWeekMonth.RowTemplate.Height = 24;
            this.dgCalendarViewWeekMonth.Size = new System.Drawing.Size(1139, 378);
            this.dgCalendarViewWeekMonth.TabIndex = 0;
            // 
            // rbtnCalendarWeeklyView
            // 
            this.rbtnCalendarWeeklyView.AutoSize = true;
            this.rbtnCalendarWeeklyView.BackColor = System.Drawing.Color.Cyan;
            this.rbtnCalendarWeeklyView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnCalendarWeeklyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCalendarWeeklyView.ForeColor = System.Drawing.Color.Black;
            this.rbtnCalendarWeeklyView.Location = new System.Drawing.Point(23, 137);
            this.rbtnCalendarWeeklyView.Name = "rbtnCalendarWeeklyView";
            this.rbtnCalendarWeeklyView.Size = new System.Drawing.Size(126, 28);
            this.rbtnCalendarWeeklyView.TabIndex = 1;
            this.rbtnCalendarWeeklyView.TabStop = true;
            this.rbtnCalendarWeeklyView.Text = "View Week";
            this.rbtnCalendarWeeklyView.UseVisualStyleBackColor = false;
            this.rbtnCalendarWeeklyView.CheckedChanged += new System.EventHandler(this.rbtnCalendarWeeklyView_CheckedChanged);
            // 
            // rbtnCalendarMonthlyView
            // 
            this.rbtnCalendarMonthlyView.AutoSize = true;
            this.rbtnCalendarMonthlyView.BackColor = System.Drawing.Color.Cyan;
            this.rbtnCalendarMonthlyView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnCalendarMonthlyView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCalendarMonthlyView.ForeColor = System.Drawing.Color.Black;
            this.rbtnCalendarMonthlyView.Location = new System.Drawing.Point(23, 259);
            this.rbtnCalendarMonthlyView.Name = "rbtnCalendarMonthlyView";
            this.rbtnCalendarMonthlyView.Size = new System.Drawing.Size(130, 28);
            this.rbtnCalendarMonthlyView.TabIndex = 1;
            this.rbtnCalendarMonthlyView.TabStop = true;
            this.rbtnCalendarMonthlyView.Text = "View Month";
            this.rbtnCalendarMonthlyView.UseVisualStyleBackColor = false;
            this.rbtnCalendarMonthlyView.CheckedChanged += new System.EventHandler(this.rbtnCalendarMonthlyView_CheckedChanged);
            // 
            // lblCalendarView
            // 
            this.lblCalendarView.AutoSize = true;
            this.lblCalendarView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarView.ForeColor = System.Drawing.Color.White;
            this.lblCalendarView.Location = new System.Drawing.Point(520, 18);
            this.lblCalendarView.Name = "lblCalendarView";
            this.lblCalendarView.Size = new System.Drawing.Size(324, 25);
            this.lblCalendarView.TabIndex = 2;
            this.lblCalendarView.Text = "Calendar View For The Curent Year";
            // 
            // btnExitCalendar
            // 
            this.btnExitCalendar.BackColor = System.Drawing.Color.White;
            this.btnExitCalendar.Location = new System.Drawing.Point(626, 462);
            this.btnExitCalendar.Name = "btnExitCalendar";
            this.btnExitCalendar.Size = new System.Drawing.Size(122, 41);
            this.btnExitCalendar.TabIndex = 3;
            this.btnExitCalendar.Text = "Exit";
            this.btnExitCalendar.UseVisualStyleBackColor = false;
            this.btnExitCalendar.Click += new System.EventHandler(this.btnExitCalendar_Click);
            // 
            // FormCalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1358, 569);
            this.Controls.Add(this.btnExitCalendar);
            this.Controls.Add(this.lblCalendarView);
            this.Controls.Add(this.rbtnCalendarMonthlyView);
            this.Controls.Add(this.rbtnCalendarWeeklyView);
            this.Controls.Add(this.dgCalendarViewWeekMonth);
            this.Name = "FormCalendarView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar View";
            this.Load += new System.EventHandler(this.FormCalendarView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCalendarViewWeekMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCalendarViewWeekMonth;
        private System.Windows.Forms.RadioButton rbtnCalendarWeeklyView;
        private System.Windows.Forms.RadioButton rbtnCalendarMonthlyView;
        private System.Windows.Forms.Label lblCalendarView;
        private System.Windows.Forms.Button btnExitCalendar;
    }
}