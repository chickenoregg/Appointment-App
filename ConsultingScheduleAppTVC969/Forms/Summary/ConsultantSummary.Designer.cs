
namespace ConsultingScheduleApp.Forms.Summary
{
    partial class FormConsultantSummary
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
            this.dgConsultantView = new System.Windows.Forms.DataGridView();
            this.lblConsultantAssignedSchedule = new System.Windows.Forms.Label();
            this.lblUserIDAssigned = new System.Windows.Forms.Label();
            this.cmbAssignedConsultant = new System.Windows.Forms.ComboBox();
            this.lblConsultantAssigned = new System.Windows.Forms.Label();
            this.btnLoadConsultantSummary = new System.Windows.Forms.Button();
            this.btnExitConsultantSummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultantView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgConsultantView
            // 
            this.dgConsultantView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgConsultantView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgConsultantView.Location = new System.Drawing.Point(24, 110);
            this.dgConsultantView.Name = "dgConsultantView";
            this.dgConsultantView.RowHeadersWidth = 51;
            this.dgConsultantView.RowTemplate.Height = 24;
            this.dgConsultantView.Size = new System.Drawing.Size(1141, 253);
            this.dgConsultantView.TabIndex = 0;
            this.dgConsultantView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgConsultantView_CellContentClick);
            // 
            // lblConsultantAssignedSchedule
            // 
            this.lblConsultantAssignedSchedule.AutoSize = true;
            this.lblConsultantAssignedSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultantAssignedSchedule.ForeColor = System.Drawing.Color.White;
            this.lblConsultantAssignedSchedule.Location = new System.Drawing.Point(379, 18);
            this.lblConsultantAssignedSchedule.Name = "lblConsultantAssignedSchedule";
            this.lblConsultantAssignedSchedule.Size = new System.Drawing.Size(365, 25);
            this.lblConsultantAssignedSchedule.TabIndex = 1;
            this.lblConsultantAssignedSchedule.Text = "Scheduled Appointments Per Consultant";
            this.lblConsultantAssignedSchedule.Click += new System.EventHandler(this.lblConsultantAssignedSchedule_Click);
            // 
            // lblUserIDAssigned
            // 
            this.lblUserIDAssigned.AutoSize = true;
            this.lblUserIDAssigned.Location = new System.Drawing.Point(56, 69);
            this.lblUserIDAssigned.Name = "lblUserIDAssigned";
            this.lblUserIDAssigned.Size = new System.Drawing.Size(0, 17);
            this.lblUserIDAssigned.TabIndex = 2;
            // 
            // cmbAssignedConsultant
            // 
            this.cmbAssignedConsultant.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbAssignedConsultant.FormattingEnabled = true;
            this.cmbAssignedConsultant.Location = new System.Drawing.Point(234, 66);
            this.cmbAssignedConsultant.Name = "cmbAssignedConsultant";
            this.cmbAssignedConsultant.Size = new System.Drawing.Size(162, 24);
            this.cmbAssignedConsultant.TabIndex = 3;
            this.cmbAssignedConsultant.SelectedIndexChanged += new System.EventHandler(this.cmbAssignedConsultant_SelectedIndexChanged);
            // 
            // lblConsultantAssigned
            // 
            this.lblConsultantAssigned.AutoSize = true;
            this.lblConsultantAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultantAssigned.ForeColor = System.Drawing.Color.White;
            this.lblConsultantAssigned.Location = new System.Drawing.Point(35, 66);
            this.lblConsultantAssigned.Name = "lblConsultantAssigned";
            this.lblConsultantAssigned.Size = new System.Drawing.Size(170, 20);
            this.lblConsultantAssigned.TabIndex = 4;
            this.lblConsultantAssigned.Text = "Choose a Consultant:";
            // 
            // btnLoadConsultantSummary
            // 
            this.btnLoadConsultantSummary.BackColor = System.Drawing.Color.Cyan;
            this.btnLoadConsultantSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadConsultantSummary.Location = new System.Drawing.Point(286, 369);
            this.btnLoadConsultantSummary.Name = "btnLoadConsultantSummary";
            this.btnLoadConsultantSummary.Size = new System.Drawing.Size(171, 39);
            this.btnLoadConsultantSummary.TabIndex = 5;
            this.btnLoadConsultantSummary.Text = "Load Summary";
            this.btnLoadConsultantSummary.UseVisualStyleBackColor = false;
            this.btnLoadConsultantSummary.Click += new System.EventHandler(this.btnLoadConsultantSummary_Click);
            // 
            // btnExitConsultantSummary
            // 
            this.btnExitConsultantSummary.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExitConsultantSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitConsultantSummary.Location = new System.Drawing.Point(559, 369);
            this.btnExitConsultantSummary.Name = "btnExitConsultantSummary";
            this.btnExitConsultantSummary.Size = new System.Drawing.Size(158, 39);
            this.btnExitConsultantSummary.TabIndex = 6;
            this.btnExitConsultantSummary.Text = "Exit";
            this.btnExitConsultantSummary.UseVisualStyleBackColor = false;
            this.btnExitConsultantSummary.Click += new System.EventHandler(this.btnExitConsultantSummary_Click);
            // 
            // FormConsultantSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1192, 501);
            this.Controls.Add(this.btnExitConsultantSummary);
            this.Controls.Add(this.btnLoadConsultantSummary);
            this.Controls.Add(this.lblConsultantAssigned);
            this.Controls.Add(this.cmbAssignedConsultant);
            this.Controls.Add(this.lblUserIDAssigned);
            this.Controls.Add(this.lblConsultantAssignedSchedule);
            this.Controls.Add(this.dgConsultantView);
            this.Name = "FormConsultantSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultant Summary";
            this.Load += new System.EventHandler(this.FormConsultantSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgConsultantView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgConsultantView;
        private System.Windows.Forms.Label lblConsultantAssignedSchedule;
        private System.Windows.Forms.Label lblUserIDAssigned;
        private System.Windows.Forms.ComboBox cmbAssignedConsultant;
        private System.Windows.Forms.Label lblConsultantAssigned;
        private System.Windows.Forms.Button btnLoadConsultantSummary;
        private System.Windows.Forms.Button btnExitConsultantSummary;
    }
}