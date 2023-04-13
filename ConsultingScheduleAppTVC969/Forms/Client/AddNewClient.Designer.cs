
namespace ConsultingScheduleApp.Forms.Client
{
    partial class FormNewClient
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
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientAddress = new System.Windows.Forms.Label();
            this.lblClientPhoneNumber = new System.Windows.Forms.Label();
            this.lblClientCity = new System.Windows.Forms.Label();
            this.lblClientCountry = new System.Windows.Forms.Label();
            this.txtAddNewClientName = new System.Windows.Forms.TextBox();
            this.txtAddNewClientAddress = new System.Windows.Forms.TextBox();
            this.txtAddNewClientPhone = new System.Windows.Forms.TextBox();
            this.txtAddNewClientCity = new System.Windows.Forms.TextBox();
            this.txtAddNewClientCountry = new System.Windows.Forms.TextBox();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.btnClientCancel = new System.Windows.Forms.Button();
            this.dgAddNewClient = new System.Windows.Forms.DataGridView();
            this.btnReturnDashboard = new System.Windows.Forms.Button();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtAddNewClientZipCode = new System.Windows.Forms.TextBox();
            this.lblAddressTwo = new System.Windows.Forms.Label();
            this.txtAddNewClientAddressTwo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddNewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.Color.White;
            this.lblClientName.Location = new System.Drawing.Point(63, 82);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(58, 20);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "Name:";
            // 
            // lblClientAddress
            // 
            this.lblClientAddress.AutoSize = true;
            this.lblClientAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAddress.ForeColor = System.Drawing.Color.White;
            this.lblClientAddress.Location = new System.Drawing.Point(63, 126);
            this.lblClientAddress.Name = "lblClientAddress";
            this.lblClientAddress.Size = new System.Drawing.Size(76, 20);
            this.lblClientAddress.TabIndex = 2;
            this.lblClientAddress.Text = "Address:";
            // 
            // lblClientPhoneNumber
            // 
            this.lblClientPhoneNumber.AutoSize = true;
            this.lblClientPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblClientPhoneNumber.Location = new System.Drawing.Point(63, 206);
            this.lblClientPhoneNumber.Name = "lblClientPhoneNumber";
            this.lblClientPhoneNumber.Size = new System.Drawing.Size(125, 20);
            this.lblClientPhoneNumber.TabIndex = 3;
            this.lblClientPhoneNumber.Text = "Phone Number:";
            // 
            // lblClientCity
            // 
            this.lblClientCity.AutoSize = true;
            this.lblClientCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCity.ForeColor = System.Drawing.Color.White;
            this.lblClientCity.Location = new System.Drawing.Point(63, 260);
            this.lblClientCity.Name = "lblClientCity";
            this.lblClientCity.Size = new System.Drawing.Size(43, 20);
            this.lblClientCity.TabIndex = 4;
            this.lblClientCity.Text = "City:";
            // 
            // lblClientCountry
            // 
            this.lblClientCountry.AutoSize = true;
            this.lblClientCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCountry.ForeColor = System.Drawing.Color.White;
            this.lblClientCountry.Location = new System.Drawing.Point(63, 307);
            this.lblClientCountry.Name = "lblClientCountry";
            this.lblClientCountry.Size = new System.Drawing.Size(72, 20);
            this.lblClientCountry.TabIndex = 5;
            this.lblClientCountry.Text = "Country:";
            // 
            // txtAddNewClientName
            // 
            this.txtAddNewClientName.Location = new System.Drawing.Point(194, 82);
            this.txtAddNewClientName.Name = "txtAddNewClientName";
            this.txtAddNewClientName.Size = new System.Drawing.Size(210, 22);
            this.txtAddNewClientName.TabIndex = 1;
            this.txtAddNewClientName.TextChanged += new System.EventHandler(this.txtAddNewClientName_TextChanged);
            // 
            // txtAddNewClientAddress
            // 
            this.txtAddNewClientAddress.Location = new System.Drawing.Point(194, 126);
            this.txtAddNewClientAddress.Name = "txtAddNewClientAddress";
            this.txtAddNewClientAddress.Size = new System.Drawing.Size(210, 22);
            this.txtAddNewClientAddress.TabIndex = 2;
            this.txtAddNewClientAddress.TextChanged += new System.EventHandler(this.txtAddNewClientAddress_TextChanged);
            // 
            // txtAddNewClientPhone
            // 
            this.txtAddNewClientPhone.Location = new System.Drawing.Point(194, 206);
            this.txtAddNewClientPhone.Name = "txtAddNewClientPhone";
            this.txtAddNewClientPhone.Size = new System.Drawing.Size(210, 22);
            this.txtAddNewClientPhone.TabIndex = 4;
            this.txtAddNewClientPhone.TextChanged += new System.EventHandler(this.txtAddNewClientPhone_TextChanged);
            // 
            // txtAddNewClientCity
            // 
            this.txtAddNewClientCity.Location = new System.Drawing.Point(194, 260);
            this.txtAddNewClientCity.Name = "txtAddNewClientCity";
            this.txtAddNewClientCity.Size = new System.Drawing.Size(210, 22);
            this.txtAddNewClientCity.TabIndex = 5;
            this.txtAddNewClientCity.TextChanged += new System.EventHandler(this.txtAddNewClientCity_TextChanged);
            // 
            // txtAddNewClientCountry
            // 
            this.txtAddNewClientCountry.Location = new System.Drawing.Point(194, 307);
            this.txtAddNewClientCountry.Name = "txtAddNewClientCountry";
            this.txtAddNewClientCountry.Size = new System.Drawing.Size(210, 22);
            this.txtAddNewClientCountry.TabIndex = 6;
            this.txtAddNewClientCountry.TextChanged += new System.EventHandler(this.txtAddNewClientCountry_TextChanged);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.BackColor = System.Drawing.Color.Cyan;
            this.btnSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClient.Location = new System.Drawing.Point(108, 400);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(144, 38);
            this.btnSaveClient.TabIndex = 8;
            this.btnSaveClient.Text = "Save ";
            this.btnSaveClient.UseVisualStyleBackColor = false;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnClientCancel
            // 
            this.btnClientCancel.BackColor = System.Drawing.Color.Gray;
            this.btnClientCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientCancel.Location = new System.Drawing.Point(329, 400);
            this.btnClientCancel.Name = "btnClientCancel";
            this.btnClientCancel.Size = new System.Drawing.Size(117, 38);
            this.btnClientCancel.TabIndex = 9;
            this.btnClientCancel.Text = "Cancel";
            this.btnClientCancel.UseVisualStyleBackColor = false;
            this.btnClientCancel.Click += new System.EventHandler(this.btnClientCancel_Click);
            // 
            // dgAddNewClient
            // 
            this.dgAddNewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddNewClient.Location = new System.Drawing.Point(478, 53);
            this.dgAddNewClient.Name = "dgAddNewClient";
            this.dgAddNewClient.RowHeadersWidth = 51;
            this.dgAddNewClient.RowTemplate.Height = 24;
            this.dgAddNewClient.Size = new System.Drawing.Size(849, 305);
            this.dgAddNewClient.TabIndex = 8;
            this.dgAddNewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAddNewClient_CellContentClick);
            // 
            // btnReturnDashboard
            // 
            this.btnReturnDashboard.AutoSize = true;
            this.btnReturnDashboard.BackColor = System.Drawing.Color.Cyan;
            this.btnReturnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReturnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnReturnDashboard.Location = new System.Drawing.Point(700, 400);
            this.btnReturnDashboard.Name = "btnReturnDashboard";
            this.btnReturnDashboard.Size = new System.Drawing.Size(185, 70);
            this.btnReturnDashboard.TabIndex = 10;
            this.btnReturnDashboard.Text = "Go To Dashboard";
            this.btnReturnDashboard.UseVisualStyleBackColor = false;
            this.btnReturnDashboard.Click += new System.EventHandler(this.btnReturnDashboard_Click);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.ForeColor = System.Drawing.Color.White;
            this.lblZipCode.Location = new System.Drawing.Point(64, 353);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(69, 17);
            this.lblZipCode.TabIndex = 10;
            this.lblZipCode.Text = "Zip Code:";
            // 
            // txtAddNewClientZipCode
            // 
            this.txtAddNewClientZipCode.Location = new System.Drawing.Point(194, 353);
            this.txtAddNewClientZipCode.Name = "txtAddNewClientZipCode";
            this.txtAddNewClientZipCode.Size = new System.Drawing.Size(210, 22);
            this.txtAddNewClientZipCode.TabIndex = 7;
            // 
            // lblAddressTwo
            // 
            this.lblAddressTwo.AutoSize = true;
            this.lblAddressTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTwo.ForeColor = System.Drawing.Color.White;
            this.lblAddressTwo.Location = new System.Drawing.Point(67, 170);
            this.lblAddressTwo.Name = "lblAddressTwo";
            this.lblAddressTwo.Size = new System.Drawing.Size(85, 20);
            this.lblAddressTwo.TabIndex = 12;
            this.lblAddressTwo.Text = "Address2:";
            // 
            // txtAddNewClientAddressTwo
            // 
            this.txtAddNewClientAddressTwo.Location = new System.Drawing.Point(194, 164);
            this.txtAddNewClientAddressTwo.Name = "txtAddNewClientAddressTwo";
            this.txtAddNewClientAddressTwo.Size = new System.Drawing.Size(210, 22);
            this.txtAddNewClientAddressTwo.TabIndex = 3;
            // 
            // FormNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1404, 507);
            this.Controls.Add(this.txtAddNewClientAddressTwo);
            this.Controls.Add(this.lblAddressTwo);
            this.Controls.Add(this.txtAddNewClientZipCode);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.btnReturnDashboard);
            this.Controls.Add(this.dgAddNewClient);
            this.Controls.Add(this.btnClientCancel);
            this.Controls.Add(this.btnSaveClient);
            this.Controls.Add(this.txtAddNewClientCountry);
            this.Controls.Add(this.txtAddNewClientCity);
            this.Controls.Add(this.txtAddNewClientPhone);
            this.Controls.Add(this.txtAddNewClientAddress);
            this.Controls.Add(this.txtAddNewClientName);
            this.Controls.Add(this.lblClientCountry);
            this.Controls.Add(this.lblClientCity);
            this.Controls.Add(this.lblClientPhoneNumber);
            this.Controls.Add(this.lblClientAddress);
            this.Controls.Add(this.lblClientName);
            this.Name = "FormNewClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Client";
            this.Load += new System.EventHandler(this.frmNewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAddNewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientAddress;
        private System.Windows.Forms.Label lblClientPhoneNumber;
        private System.Windows.Forms.Label lblClientCity;
        private System.Windows.Forms.Label lblClientCountry;
        private System.Windows.Forms.TextBox txtAddNewClientName;
        private System.Windows.Forms.TextBox txtAddNewClientAddress;
        private System.Windows.Forms.TextBox txtAddNewClientPhone;
        private System.Windows.Forms.TextBox txtAddNewClientCity;
        private System.Windows.Forms.TextBox txtAddNewClientCountry;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Button btnClientCancel;
        private System.Windows.Forms.DataGridView dgAddNewClient;
        private System.Windows.Forms.Button btnReturnDashboard;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtAddNewClientZipCode;
        private System.Windows.Forms.Label lblAddressTwo;
        private System.Windows.Forms.TextBox txtAddNewClientAddressTwo;
    }
}