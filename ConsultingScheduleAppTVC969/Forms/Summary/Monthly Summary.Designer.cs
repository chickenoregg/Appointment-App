
namespace ConsultingScheduleApp.Forms
{
    partial class FormMonthlySummary
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
            this.dgMonthlySummaryView = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadMonthlySummary = new System.Windows.Forms.Button();
            this.cmbMontlySelection = new System.Windows.Forms.ComboBox();
            this.btnExitMonthlySummary = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMonthlySummaryView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMonthlySummaryView
            // 
            this.dgMonthlySummaryView.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgMonthlySummaryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMonthlySummaryView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Count});
            this.dgMonthlySummaryView.Location = new System.Drawing.Point(262, 88);
            this.dgMonthlySummaryView.Name = "dgMonthlySummaryView";
            this.dgMonthlySummaryView.RowHeadersWidth = 51;
            this.dgMonthlySummaryView.RowTemplate.Height = 24;
            this.dgMonthlySummaryView.Size = new System.Drawing.Size(471, 217);
            this.dgMonthlySummaryView.TabIndex = 0;
            this.dgMonthlySummaryView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Appointment Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // Count
            // 
            this.Count.HeaderText = "Number of Appointments";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.Width = 125;
            // 
            // btnLoadMonthlySummary
            // 
            this.btnLoadMonthlySummary.BackColor = System.Drawing.Color.Cyan;
            this.btnLoadMonthlySummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadMonthlySummary.Location = new System.Drawing.Point(360, 375);
            this.btnLoadMonthlySummary.Name = "btnLoadMonthlySummary";
            this.btnLoadMonthlySummary.Size = new System.Drawing.Size(120, 38);
            this.btnLoadMonthlySummary.TabIndex = 1;
            this.btnLoadMonthlySummary.Text = "Load";
            this.btnLoadMonthlySummary.UseVisualStyleBackColor = false;
            this.btnLoadMonthlySummary.Click += new System.EventHandler(this.btnLoadMonthlySummary_Click);
            // 
            // cmbMontlySelection
            // 
            this.cmbMontlySelection.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbMontlySelection.FormattingEnabled = true;
            this.cmbMontlySelection.Location = new System.Drawing.Point(583, 55);
            this.cmbMontlySelection.Name = "cmbMontlySelection";
            this.cmbMontlySelection.Size = new System.Drawing.Size(121, 24);
            this.cmbMontlySelection.TabIndex = 3;
            // 
            // btnExitMonthlySummary
            // 
            this.btnExitMonthlySummary.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExitMonthlySummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitMonthlySummary.Location = new System.Drawing.Point(552, 375);
            this.btnExitMonthlySummary.Name = "btnExitMonthlySummary";
            this.btnExitMonthlySummary.Size = new System.Drawing.Size(108, 38);
            this.btnExitMonthlySummary.TabIndex = 4;
            this.btnExitMonthlySummary.Text = "Exit";
            this.btnExitMonthlySummary.UseVisualStyleBackColor = false;
            this.btnExitMonthlySummary.Click += new System.EventHandler(this.btnExitMonthlySummary_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(268, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search Month for the Current Year";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormMonthlySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1099, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExitMonthlySummary);
            this.Controls.Add(this.cmbMontlySelection);
            this.Controls.Add(this.btnLoadMonthlySummary);
            this.Controls.Add(this.dgMonthlySummaryView);
            this.Name = "FormMonthlySummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormMonthlySummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMonthlySummaryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMonthlySummaryView;
        private System.Windows.Forms.Button btnLoadMonthlySummary;
        private System.Windows.Forms.ComboBox cmbMontlySelection;
        private System.Windows.Forms.Button btnExitMonthlySummary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Label label1;
    }
}