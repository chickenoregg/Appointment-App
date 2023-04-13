
namespace ConsultingScheduleApp
{
    partial class FormDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.btnAddClient = new System.Windows.Forms.Button();
            this.dgClientView = new System.Windows.Forms.DataGridView();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.dgAppointmentView = new System.Windows.Forms.DataGridView();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.btnModifyClient = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnModifyAppointment = new System.Windows.Forms.Button();
            this.lblReportList = new System.Windows.Forms.Label();
            this.btnMonthlySummary = new System.Windows.Forms.Button();
            this.btnConsultantSummary = new System.Windows.Forms.Button();
            this.btnCumulativeCount = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalendarView = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointmentView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddClient.Location = new System.Drawing.Point(1594, 141);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(75, 34);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // dgClientView
            // 
            this.dgClientView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgClientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgClientView.Location = new System.Drawing.Point(527, 108);
            this.dgClientView.Name = "dgClientView";
            this.dgClientView.RowHeadersWidth = 51;
            this.dgClientView.RowTemplate.Height = 24;
            this.dgClientView.Size = new System.Drawing.Size(1011, 195);
            this.dgClientView.TabIndex = 1;
            this.dgClientView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientView_CellContentClick);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAppointment.Location = new System.Drawing.Point(1594, 545);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(75, 36);
            this.btnAddAppointment.TabIndex = 0;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // dgAppointmentView
            // 
            this.dgAppointmentView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgAppointmentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppointmentView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgAppointmentView.Location = new System.Drawing.Point(461, 518);
            this.dgAppointmentView.Name = "dgAppointmentView";
            this.dgAppointmentView.RowHeadersWidth = 51;
            this.dgAppointmentView.RowTemplate.Height = 24;
            this.dgAppointmentView.Size = new System.Drawing.Size(1111, 195);
            this.dgAppointmentView.TabIndex = 1;
            this.dgAppointmentView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAppointmentView_CellContentClick);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClient.ForeColor = System.Drawing.Color.White;
            this.lblClient.Location = new System.Drawing.Point(999, 65);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(79, 25);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Clients";
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.ForeColor = System.Drawing.Color.White;
            this.lblAppointments.Location = new System.Drawing.Point(959, 472);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(144, 25);
            this.lblAppointments.TabIndex = 3;
            this.lblAppointments.Text = "Appointments";
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteClient.Location = new System.Drawing.Point(1594, 255);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(75, 34);
            this.btnDeleteClient.TabIndex = 0;
            this.btnDeleteClient.Text = "Delete";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnModifyClient
            // 
            this.btnModifyClient.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModifyClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyClient.Location = new System.Drawing.Point(1594, 202);
            this.btnModifyClient.Name = "btnModifyClient";
            this.btnModifyClient.Size = new System.Drawing.Size(75, 34);
            this.btnModifyClient.TabIndex = 0;
            this.btnModifyClient.Text = "Edit";
            this.btnModifyClient.UseVisualStyleBackColor = false;
            this.btnModifyClient.Click += new System.EventHandler(this.btnModifyClient_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDeleteAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(1594, 661);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(75, 36);
            this.btnDeleteAppointment.TabIndex = 0;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = false;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnModifyAppointment
            // 
            this.btnModifyAppointment.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnModifyAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifyAppointment.Location = new System.Drawing.Point(1594, 600);
            this.btnModifyAppointment.Name = "btnModifyAppointment";
            this.btnModifyAppointment.Size = new System.Drawing.Size(75, 36);
            this.btnModifyAppointment.TabIndex = 0;
            this.btnModifyAppointment.Text = "Edit";
            this.btnModifyAppointment.UseVisualStyleBackColor = false;
            this.btnModifyAppointment.Click += new System.EventHandler(this.btnModifyAppointment_Click);
            // 
            // lblReportList
            // 
            this.lblReportList.AutoSize = true;
            this.lblReportList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportList.ForeColor = System.Drawing.Color.White;
            this.lblReportList.Location = new System.Drawing.Point(144, 9);
            this.lblReportList.Name = "lblReportList";
            this.lblReportList.Size = new System.Drawing.Size(149, 20);
            this.lblReportList.TabIndex = 4;
            this.lblReportList.Text = "Report Summary";
            // 
            // btnMonthlySummary
            // 
            this.btnMonthlySummary.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMonthlySummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlySummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMonthlySummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlySummary.Location = new System.Drawing.Point(38, 429);
            this.btnMonthlySummary.Name = "btnMonthlySummary";
            this.btnMonthlySummary.Size = new System.Drawing.Size(309, 135);
            this.btnMonthlySummary.TabIndex = 5;
            this.btnMonthlySummary.Text = "Monthly Summary Report";
            this.btnMonthlySummary.UseVisualStyleBackColor = false;
            this.btnMonthlySummary.Click += new System.EventHandler(this.btnMonthlySummary_Click);
            // 
            // btnConsultantSummary
            // 
            this.btnConsultantSummary.BackColor = System.Drawing.Color.Turquoise;
            this.btnConsultantSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultantSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultantSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultantSummary.Location = new System.Drawing.Point(47, 231);
            this.btnConsultantSummary.Name = "btnConsultantSummary";
            this.btnConsultantSummary.Size = new System.Drawing.Size(311, 151);
            this.btnConsultantSummary.TabIndex = 5;
            this.btnConsultantSummary.Text = "Consultant Summary Report";
            this.btnConsultantSummary.UseVisualStyleBackColor = false;
            this.btnConsultantSummary.Click += new System.EventHandler(this.btnConsultantSummary_Click);
            // 
            // btnCumulativeCount
            // 
            this.btnCumulativeCount.BackColor = System.Drawing.Color.Turquoise;
            this.btnCumulativeCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCumulativeCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCumulativeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCumulativeCount.Location = new System.Drawing.Point(38, 610);
            this.btnCumulativeCount.Name = "btnCumulativeCount";
            this.btnCumulativeCount.Size = new System.Drawing.Size(311, 169);
            this.btnCumulativeCount.TabIndex = 5;
            this.btnCumulativeCount.Text = "Full Summary Report";
            this.btnCumulativeCount.UseVisualStyleBackColor = false;
            this.btnCumulativeCount.Click += new System.EventHandler(this.btnCumulativeCount_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitApp.Location = new System.Drawing.Point(1571, 772);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(129, 44);
            this.btnExitApp.TabIndex = 8;
            this.btnExitApp.Text = "Exit";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.btnExitApp_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btnCalendarView);
            this.panel1.Controls.Add(this.btnMonthlySummary);
            this.panel1.Controls.Add(this.btnConsultantSummary);
            this.panel1.Controls.Add(this.btnCumulativeCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 853);
            this.panel1.TabIndex = 9;
            // 
            // btnCalendarView
            // 
            this.btnCalendarView.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCalendarView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendarView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalendarView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendarView.Location = new System.Drawing.Point(47, 76);
            this.btnCalendarView.Name = "btnCalendarView";
            this.btnCalendarView.Size = new System.Drawing.Size(311, 118);
            this.btnCalendarView.TabIndex = 11;
            this.btnCalendarView.Text = "View Calendar";
            this.btnCalendarView.UseVisualStyleBackColor = false;
            this.btnCalendarView.Click += new System.EventHandler(this.btnCalendarView_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Cyan;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Location = new System.Drawing.Point(927, 309);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(198, 50);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(927, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeMessage.Location = new System.Drawing.Point(461, 13);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(106, 25);
            this.lblWelcomeMessage.TabIndex = 12;
            this.lblWelcomeMessage.Text = "Welcome! ";
            this.lblWelcomeMessage.Click += new System.EventHandler(this.lblWelcomeMessage_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(870, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(362, 22);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.Text = "(ex: 01/01/2023)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1270, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_search);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(927, 746);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 50);
            this.button2.TabIndex = 15;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(ConsultingScheduleApp.Models.Client);
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1736, 853);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.lblReportList);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.dgAppointmentView);
            this.Controls.Add(this.dgClientView);
            this.Controls.Add(this.btnModifyAppointment);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.btnModifyClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnAddClient);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppointmentView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Button btnModifyClient;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnModifyAppointment;
        private System.Windows.Forms.Label lblReportList;
        private System.Windows.Forms.Button btnMonthlySummary;
        private System.Windows.Forms.Button btnConsultantSummary;
        private System.Windows.Forms.Button btnCumulativeCount;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Button btnLoad;
        public System.Windows.Forms.DataGridView dgClientView;
        public System.Windows.Forms.DataGridView dgAppointmentView;
        private System.Windows.Forms.Button btnCalendarView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}