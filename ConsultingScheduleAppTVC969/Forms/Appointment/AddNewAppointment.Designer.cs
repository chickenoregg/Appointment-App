
namespace ConsultingScheduleApp.Forms.Appointment
{
    partial class FormAddNewAppointment
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
            this.lblAppointmentType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAppointmentStart = new System.Windows.Forms.Label();
            this.lblAppointmentEnd = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.txtAddNewAppointmentTitle = new System.Windows.Forms.TextBox();
            this.txtAddNewAppointmentClientId = new System.Windows.Forms.TextBox();
            this.txtAddNewAppointmentUserId = new System.Windows.Forms.TextBox();
            this.btnSaveNewAppointment = new System.Windows.Forms.Button();
            this.btnCancelNewAppointment = new System.Windows.Forms.Button();
            this.txtAddStartNewAppointmentHour = new System.Windows.Forms.TextBox();
            this.txtAddStartNewAppointmentMin = new System.Windows.Forms.TextBox();
            this.txtAddStartNewAppointmentSec = new System.Windows.Forms.TextBox();
            this.txtAddEndNewAppointmentHour = new System.Windows.Forms.TextBox();
            this.txtAddEndNewAppointmentMin = new System.Windows.Forms.TextBox();
            this.txtAddEndNewAppointmentSec = new System.Windows.Forms.TextBox();
            this.cmbAddNewAppointmentType = new System.Windows.Forms.ComboBox();
            this.txtAddNewYearAppointment = new System.Windows.Forms.TextBox();
            this.txtAddNewDayAppointment = new System.Windows.Forms.TextBox();
            this.txtAddNewMonthAppointment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAppointmentType
            // 
            this.lblAppointmentType.AutoSize = true;
            this.lblAppointmentType.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentType.Location = new System.Drawing.Point(163, 99);
            this.lblAppointmentType.Name = "lblAppointmentType";
            this.lblAppointmentType.Size = new System.Drawing.Size(117, 16);
            this.lblAppointmentType.TabIndex = 0;
            this.lblAppointmentType.Text = "Appointment Type";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(163, 143);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblAppointmentStart
            // 
            this.lblAppointmentStart.AutoSize = true;
            this.lblAppointmentStart.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentStart.Location = new System.Drawing.Point(163, 45);
            this.lblAppointmentStart.Name = "lblAppointmentStart";
            this.lblAppointmentStart.Size = new System.Drawing.Size(86, 16);
            this.lblAppointmentStart.TabIndex = 0;
            this.lblAppointmentStart.Text = "Session Start";
            // 
            // lblAppointmentEnd
            // 
            this.lblAppointmentEnd.AutoSize = true;
            this.lblAppointmentEnd.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentEnd.Location = new System.Drawing.Point(410, 45);
            this.lblAppointmentEnd.Name = "lblAppointmentEnd";
            this.lblAppointmentEnd.Size = new System.Drawing.Size(83, 16);
            this.lblAppointmentEnd.TabIndex = 0;
            this.lblAppointmentEnd.Text = "Session End";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.ForeColor = System.Drawing.Color.White;
            this.lblAppointmentDate.Location = new System.Drawing.Point(163, 183);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(36, 16);
            this.lblAppointmentDate.TabIndex = 0;
            this.lblAppointmentDate.Text = "Date";
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.ForeColor = System.Drawing.Color.White;
            this.lblClientId.Location = new System.Drawing.Point(163, 227);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(56, 16);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "Client ID";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.ForeColor = System.Drawing.Color.White;
            this.lblUserId.Location = new System.Drawing.Point(163, 280);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(52, 16);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User ID";
            // 
            // txtAddNewAppointmentTitle
            // 
            this.txtAddNewAppointmentTitle.Location = new System.Drawing.Point(364, 140);
            this.txtAddNewAppointmentTitle.Name = "txtAddNewAppointmentTitle";
            this.txtAddNewAppointmentTitle.Size = new System.Drawing.Size(147, 22);
            this.txtAddNewAppointmentTitle.TabIndex = 8;
            this.txtAddNewAppointmentTitle.TextChanged += new System.EventHandler(this.txtAddNewAppointmentTitle_TextChanged);
            // 
            // txtAddNewAppointmentClientId
            // 
            this.txtAddNewAppointmentClientId.Location = new System.Drawing.Point(364, 227);
            this.txtAddNewAppointmentClientId.Name = "txtAddNewAppointmentClientId";
            this.txtAddNewAppointmentClientId.Size = new System.Drawing.Size(81, 22);
            this.txtAddNewAppointmentClientId.TabIndex = 12;
            this.txtAddNewAppointmentClientId.TextChanged += new System.EventHandler(this.txtAddNewAppointmentClientId_TextChanged);
            // 
            // txtAddNewAppointmentUserId
            // 
            this.txtAddNewAppointmentUserId.Location = new System.Drawing.Point(364, 280);
            this.txtAddNewAppointmentUserId.Name = "txtAddNewAppointmentUserId";
            this.txtAddNewAppointmentUserId.Size = new System.Drawing.Size(81, 22);
            this.txtAddNewAppointmentUserId.TabIndex = 13;
            this.txtAddNewAppointmentUserId.TextChanged += new System.EventHandler(this.txtAddNewAppointmentUserId_TextChanged);
            // 
            // btnSaveNewAppointment
            // 
            this.btnSaveNewAppointment.BackColor = System.Drawing.Color.Cyan;
            this.btnSaveNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveNewAppointment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveNewAppointment.Location = new System.Drawing.Point(194, 352);
            this.btnSaveNewAppointment.Name = "btnSaveNewAppointment";
            this.btnSaveNewAppointment.Size = new System.Drawing.Size(128, 35);
            this.btnSaveNewAppointment.TabIndex = 14;
            this.btnSaveNewAppointment.Text = "Save";
            this.btnSaveNewAppointment.UseVisualStyleBackColor = false;
            this.btnSaveNewAppointment.Click += new System.EventHandler(this.btnSaveNewAppointment_Click);
            // 
            // btnCancelNewAppointment
            // 
            this.btnCancelNewAppointment.BackColor = System.Drawing.Color.Gray;
            this.btnCancelNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelNewAppointment.Location = new System.Drawing.Point(410, 352);
            this.btnCancelNewAppointment.Name = "btnCancelNewAppointment";
            this.btnCancelNewAppointment.Size = new System.Drawing.Size(101, 35);
            this.btnCancelNewAppointment.TabIndex = 15;
            this.btnCancelNewAppointment.Text = "Cancel";
            this.btnCancelNewAppointment.UseVisualStyleBackColor = false;
            this.btnCancelNewAppointment.Click += new System.EventHandler(this.btnCancelNewAppointment_Click);
            // 
            // txtAddStartNewAppointmentHour
            // 
            this.txtAddStartNewAppointmentHour.Location = new System.Drawing.Point(148, 65);
            this.txtAddStartNewAppointmentHour.Name = "txtAddStartNewAppointmentHour";
            this.txtAddStartNewAppointmentHour.Size = new System.Drawing.Size(50, 22);
            this.txtAddStartNewAppointmentHour.TabIndex = 1;
            this.txtAddStartNewAppointmentHour.Text = "hh";
            // 
            // txtAddStartNewAppointmentMin
            // 
            this.txtAddStartNewAppointmentMin.Location = new System.Drawing.Point(201, 65);
            this.txtAddStartNewAppointmentMin.Name = "txtAddStartNewAppointmentMin";
            this.txtAddStartNewAppointmentMin.Size = new System.Drawing.Size(47, 22);
            this.txtAddStartNewAppointmentMin.TabIndex = 2;
            this.txtAddStartNewAppointmentMin.Text = "mm";
            // 
            // txtAddStartNewAppointmentSec
            // 
            this.txtAddStartNewAppointmentSec.Location = new System.Drawing.Point(254, 65);
            this.txtAddStartNewAppointmentSec.Name = "txtAddStartNewAppointmentSec";
            this.txtAddStartNewAppointmentSec.Size = new System.Drawing.Size(47, 22);
            this.txtAddStartNewAppointmentSec.TabIndex = 3;
            this.txtAddStartNewAppointmentSec.Text = "ss";
            // 
            // txtAddEndNewAppointmentHour
            // 
            this.txtAddEndNewAppointmentHour.Location = new System.Drawing.Point(369, 65);
            this.txtAddEndNewAppointmentHour.Name = "txtAddEndNewAppointmentHour";
            this.txtAddEndNewAppointmentHour.Size = new System.Drawing.Size(47, 22);
            this.txtAddEndNewAppointmentHour.TabIndex = 4;
            this.txtAddEndNewAppointmentHour.Text = "hh";
            // 
            // txtAddEndNewAppointmentMin
            // 
            this.txtAddEndNewAppointmentMin.Location = new System.Drawing.Point(422, 65);
            this.txtAddEndNewAppointmentMin.Name = "txtAddEndNewAppointmentMin";
            this.txtAddEndNewAppointmentMin.Size = new System.Drawing.Size(47, 22);
            this.txtAddEndNewAppointmentMin.TabIndex = 5;
            this.txtAddEndNewAppointmentMin.Text = "mm";
            // 
            // txtAddEndNewAppointmentSec
            // 
            this.txtAddEndNewAppointmentSec.Location = new System.Drawing.Point(475, 65);
            this.txtAddEndNewAppointmentSec.Name = "txtAddEndNewAppointmentSec";
            this.txtAddEndNewAppointmentSec.Size = new System.Drawing.Size(47, 22);
            this.txtAddEndNewAppointmentSec.TabIndex = 6;
            this.txtAddEndNewAppointmentSec.Text = "ss";
            // 
            // cmbAddNewAppointmentType
            // 
            this.cmbAddNewAppointmentType.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbAddNewAppointmentType.FormattingEnabled = true;
            this.cmbAddNewAppointmentType.Items.AddRange(new object[] {
            "Oil Change",
            "AC and Heating System ",
            "Tire Services"});
            this.cmbAddNewAppointmentType.Location = new System.Drawing.Point(364, 99);
            this.cmbAddNewAppointmentType.Name = "cmbAddNewAppointmentType";
            this.cmbAddNewAppointmentType.Size = new System.Drawing.Size(147, 24);
            this.cmbAddNewAppointmentType.TabIndex = 7;
            this.cmbAddNewAppointmentType.SelectedIndexChanged += new System.EventHandler(this.cmbAddNewAppointmentType_SelectedIndexChanged);
            // 
            // txtAddNewYearAppointment
            // 
            this.txtAddNewYearAppointment.Location = new System.Drawing.Point(364, 183);
            this.txtAddNewYearAppointment.Name = "txtAddNewYearAppointment";
            this.txtAddNewYearAppointment.Size = new System.Drawing.Size(58, 22);
            this.txtAddNewYearAppointment.TabIndex = 9;
            this.txtAddNewYearAppointment.Text = "Year";
            // 
            // txtAddNewDayAppointment
            // 
            this.txtAddNewDayAppointment.Location = new System.Drawing.Point(555, 185);
            this.txtAddNewDayAppointment.Name = "txtAddNewDayAppointment";
            this.txtAddNewDayAppointment.Size = new System.Drawing.Size(58, 22);
            this.txtAddNewDayAppointment.TabIndex = 11;
            this.txtAddNewDayAppointment.Text = "Day";
            // 
            // txtAddNewMonthAppointment
            // 
            this.txtAddNewMonthAppointment.Location = new System.Drawing.Point(438, 183);
            this.txtAddNewMonthAppointment.Name = "txtAddNewMonthAppointment";
            this.txtAddNewMonthAppointment.Size = new System.Drawing.Size(100, 22);
            this.txtAddNewMonthAppointment.TabIndex = 10;
            this.txtAddNewMonthAppointment.Text = "MM";
            // 
            // FormAddNewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(670, 455);
            this.Controls.Add(this.txtAddNewMonthAppointment);
            this.Controls.Add(this.txtAddNewDayAppointment);
            this.Controls.Add(this.txtAddNewYearAppointment);
            this.Controls.Add(this.cmbAddNewAppointmentType);
            this.Controls.Add(this.txtAddEndNewAppointmentSec);
            this.Controls.Add(this.txtAddStartNewAppointmentSec);
            this.Controls.Add(this.txtAddEndNewAppointmentMin);
            this.Controls.Add(this.txtAddStartNewAppointmentMin);
            this.Controls.Add(this.txtAddEndNewAppointmentHour);
            this.Controls.Add(this.txtAddStartNewAppointmentHour);
            this.Controls.Add(this.btnCancelNewAppointment);
            this.Controls.Add(this.btnSaveNewAppointment);
            this.Controls.Add(this.txtAddNewAppointmentUserId);
            this.Controls.Add(this.txtAddNewAppointmentClientId);
            this.Controls.Add(this.txtAddNewAppointmentTitle);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblClientId);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.lblAppointmentEnd);
            this.Controls.Add(this.lblAppointmentStart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAppointmentType);
            this.Name = "FormAddNewAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppointmentType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAppointmentStart;
        private System.Windows.Forms.Label lblAppointmentEnd;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtAddNewAppointmentTitle;
        private System.Windows.Forms.TextBox txtAddNewAppointmentClientId;
        private System.Windows.Forms.TextBox txtAddNewAppointmentUserId;
        private System.Windows.Forms.Button btnSaveNewAppointment;
        private System.Windows.Forms.Button btnCancelNewAppointment;
        private System.Windows.Forms.TextBox txtAddStartNewAppointmentHour;
        private System.Windows.Forms.TextBox txtAddStartNewAppointmentMin;
        private System.Windows.Forms.TextBox txtAddStartNewAppointmentSec;
        private System.Windows.Forms.TextBox txtAddEndNewAppointmentHour;
        private System.Windows.Forms.TextBox txtAddEndNewAppointmentMin;
        private System.Windows.Forms.TextBox txtAddEndNewAppointmentSec;
        private System.Windows.Forms.ComboBox cmbAddNewAppointmentType;
        private System.Windows.Forms.TextBox txtAddNewYearAppointment;
        private System.Windows.Forms.TextBox txtAddNewDayAppointment;
        private System.Windows.Forms.TextBox txtAddNewMonthAppointment;
    }
}