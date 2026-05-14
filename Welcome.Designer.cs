
namespace Presentation
{
    partial class Welcome
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnViewWorkShop = new System.Windows.Forms.Button();
            this.btnRegisterClient = new System.Windows.Forms.Button();
            this.btnAddWorkshop = new System.Windows.Forms.Button();
            this.btnCancelRegistrtion = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dvgWorkShops = new System.Windows.Forms.DataGridView();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblClientEmail = new System.Windows.Forms.Label();
            this.lblWorkshopID = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.txtWorkshopID = new System.Windows.Forms.TextBox();
            this.grpViewWorkshops = new System.Windows.Forms.GroupBox();
            this.grpRegisterClient = new System.Windows.Forms.GroupBox();
            this.grpSearchRegistration = new System.Windows.Forms.GroupBox();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.dgvRegistrations = new System.Windows.Forms.DataGridView();
            this.grpCancelRegistration = new System.Windows.Forms.GroupBox();
            this.txtRegistrationID = new System.Windows.Forms.TextBox();
            this.grpAddWorkshop = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.nudCapacity = new System.Windows.Forms.NumericUpDown();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtWorkshopTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgWorkShops)).BeginInit();
            this.grpViewWorkshops.SuspendLayout();
            this.grpRegisterClient.SuspendLayout();
            this.grpSearchRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).BeginInit();
            this.grpCancelRegistration.SuspendLayout();
            this.grpAddWorkshop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(26, 756);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 49);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnViewWorkShop
            // 
            this.btnViewWorkShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWorkShop.Location = new System.Drawing.Point(502, 376);
            this.btnViewWorkShop.Name = "btnViewWorkShop";
            this.btnViewWorkShop.Size = new System.Drawing.Size(139, 48);
            this.btnViewWorkShop.TabIndex = 1;
            this.btnViewWorkShop.Text = "View Workshops";
            this.btnViewWorkShop.UseVisualStyleBackColor = true;
            this.btnViewWorkShop.Click += new System.EventHandler(this.btnViewWorkShop_Click);
            // 
            // btnRegisterClient
            // 
            this.btnRegisterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterClient.Location = new System.Drawing.Point(314, 200);
            this.btnRegisterClient.Name = "btnRegisterClient";
            this.btnRegisterClient.Size = new System.Drawing.Size(128, 48);
            this.btnRegisterClient.TabIndex = 2;
            this.btnRegisterClient.Text = "Register Client";
            this.btnRegisterClient.UseVisualStyleBackColor = true;
            this.btnRegisterClient.Click += new System.EventHandler(this.btnRegisterClient_Click);
            // 
            // btnAddWorkshop
            // 
            this.btnAddWorkshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWorkshop.Location = new System.Drawing.Point(283, 204);
            this.btnAddWorkshop.Name = "btnAddWorkshop";
            this.btnAddWorkshop.Size = new System.Drawing.Size(153, 51);
            this.btnAddWorkshop.TabIndex = 5;
            this.btnAddWorkshop.Text = "Add New Workshop";
            this.btnAddWorkshop.UseVisualStyleBackColor = true;
            this.btnAddWorkshop.Click += new System.EventHandler(this.btnAddWorkshop_Click);
            // 
            // btnCancelRegistrtion
            // 
            this.btnCancelRegistrtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRegistrtion.ForeColor = System.Drawing.Color.Black;
            this.btnCancelRegistrtion.Location = new System.Drawing.Point(283, 97);
            this.btnCancelRegistrtion.Name = "btnCancelRegistrtion";
            this.btnCancelRegistrtion.Size = new System.Drawing.Size(138, 51);
            this.btnCancelRegistrtion.TabIndex = 6;
            this.btnCancelRegistrtion.Text = "Cancel Registration";
            this.btnCancelRegistrtion.UseVisualStyleBackColor = true;
            this.btnCancelRegistrtion.Click += new System.EventHandler(this.btnCancelRegistrtion_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(541, 193);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 54);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dvgWorkShops
            // 
            this.dvgWorkShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgWorkShops.Location = new System.Drawing.Point(15, 41);
            this.dvgWorkShops.Name = "dvgWorkShops";
            this.dvgWorkShops.RowHeadersWidth = 51;
            this.dvgWorkShops.RowTemplate.Height = 24;
            this.dvgWorkShops.Size = new System.Drawing.Size(635, 329);
            this.dvgWorkShops.TabIndex = 8;
            this.dvgWorkShops.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgWorkShops_CellContentClick);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(6, 43);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(119, 29);
            this.lblClientName.TabIndex = 10;
            this.lblClientName.Text = "Client Name";
            // 
            // lblClientEmail
            // 
            this.lblClientEmail.AutoSize = true;
            this.lblClientEmail.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientEmail.Location = new System.Drawing.Point(6, 100);
            this.lblClientEmail.Name = "lblClientEmail";
            this.lblClientEmail.Size = new System.Drawing.Size(115, 29);
            this.lblClientEmail.TabIndex = 11;
            this.lblClientEmail.Text = "Client Email";
            // 
            // lblWorkshopID
            // 
            this.lblWorkshopID.AutoSize = true;
            this.lblWorkshopID.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkshopID.Location = new System.Drawing.Point(6, 159);
            this.lblWorkshopID.Name = "lblWorkshopID";
            this.lblWorkshopID.Size = new System.Drawing.Size(126, 29);
            this.lblWorkshopID.TabIndex = 12;
            this.lblWorkshopID.Text = "Workshop ID";
            // 
            // txtClientName
            // 
            this.txtClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(145, 33);
            this.txtClientName.Multiline = true;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(297, 39);
            this.txtClientName.TabIndex = 13;
            this.txtClientName.TextChanged += new System.EventHandler(this.txtClientName_TextChanged);
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientEmail.Location = new System.Drawing.Point(145, 95);
            this.txtClientEmail.Multiline = true;
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(297, 39);
            this.txtClientEmail.TabIndex = 14;
            this.txtClientEmail.TextChanged += new System.EventHandler(this.txtClientEmail_TextChanged_1);
            // 
            // txtWorkshopID
            // 
            this.txtWorkshopID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkshopID.Location = new System.Drawing.Point(145, 154);
            this.txtWorkshopID.Multiline = true;
            this.txtWorkshopID.Name = "txtWorkshopID";
            this.txtWorkshopID.Size = new System.Drawing.Size(297, 40);
            this.txtWorkshopID.TabIndex = 15;
            this.txtWorkshopID.TextChanged += new System.EventHandler(this.txtClientEmail_TextChanged);
            // 
            // grpViewWorkshops
            // 
            this.grpViewWorkshops.BackColor = System.Drawing.Color.LightGray;
            this.grpViewWorkshops.Controls.Add(this.dvgWorkShops);
            this.grpViewWorkshops.Controls.Add(this.btnViewWorkShop);
            this.grpViewWorkshops.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViewWorkshops.Location = new System.Drawing.Point(485, 34);
            this.grpViewWorkshops.Name = "grpViewWorkshops";
            this.grpViewWorkshops.Size = new System.Drawing.Size(665, 440);
            this.grpViewWorkshops.TabIndex = 16;
            this.grpViewWorkshops.TabStop = false;
            this.grpViewWorkshops.Text = "View Workshops";
            // 
            // grpRegisterClient
            // 
            this.grpRegisterClient.BackColor = System.Drawing.Color.LightGray;
            this.grpRegisterClient.Controls.Add(this.txtClientEmail);
            this.grpRegisterClient.Controls.Add(this.lblClientName);
            this.grpRegisterClient.Controls.Add(this.txtWorkshopID);
            this.grpRegisterClient.Controls.Add(this.lblClientEmail);
            this.grpRegisterClient.Controls.Add(this.lblWorkshopID);
            this.grpRegisterClient.Controls.Add(this.btnRegisterClient);
            this.grpRegisterClient.Controls.Add(this.txtClientName);
            this.grpRegisterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRegisterClient.Location = new System.Drawing.Point(26, 34);
            this.grpRegisterClient.Name = "grpRegisterClient";
            this.grpRegisterClient.Size = new System.Drawing.Size(453, 260);
            this.grpRegisterClient.TabIndex = 17;
            this.grpRegisterClient.TabStop = false;
            this.grpRegisterClient.Text = "Register Client";
            // 
            // grpSearchRegistration
            // 
            this.grpSearchRegistration.BackColor = System.Drawing.Color.LightGray;
            this.grpSearchRegistration.Controls.Add(this.txtSearchEmail);
            this.grpSearchRegistration.Controls.Add(this.dgvRegistrations);
            this.grpSearchRegistration.Controls.Add(this.btnSearch);
            this.grpSearchRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchRegistration.Location = new System.Drawing.Point(485, 480);
            this.grpSearchRegistration.Name = "grpSearchRegistration";
            this.grpSearchRegistration.Size = new System.Drawing.Size(665, 260);
            this.grpSearchRegistration.TabIndex = 18;
            this.grpSearchRegistration.TabStop = false;
            this.grpSearchRegistration.Text = "Search Registrations";
            this.grpSearchRegistration.Enter += new System.EventHandler(this.grpSearchRegistration_Enter);
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmail.Location = new System.Drawing.Point(15, 206);
            this.txtSearchEmail.Multiline = true;
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(474, 38);
            this.txtSearchEmail.TabIndex = 16;
            this.txtSearchEmail.TextChanged += new System.EventHandler(this.txtSearchEmail_TextChanged);
            // 
            // dgvRegistrations
            // 
            this.dgvRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrations.Location = new System.Drawing.Point(15, 33);
            this.dgvRegistrations.Name = "dgvRegistrations";
            this.dgvRegistrations.RowHeadersWidth = 51;
            this.dgvRegistrations.RowTemplate.Height = 24;
            this.dgvRegistrations.Size = new System.Drawing.Size(626, 150);
            this.dgvRegistrations.TabIndex = 8;
            this.dgvRegistrations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistrations_CellContentClick);
            // 
            // grpCancelRegistration
            // 
            this.grpCancelRegistration.BackColor = System.Drawing.Color.LightGray;
            this.grpCancelRegistration.Controls.Add(this.txtRegistrationID);
            this.grpCancelRegistration.Controls.Add(this.btnCancelRegistrtion);
            this.grpCancelRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCancelRegistration.ForeColor = System.Drawing.Color.Red;
            this.grpCancelRegistration.Location = new System.Drawing.Point(26, 576);
            this.grpCancelRegistration.Name = "grpCancelRegistration";
            this.grpCancelRegistration.Size = new System.Drawing.Size(453, 164);
            this.grpCancelRegistration.TabIndex = 19;
            this.grpCancelRegistration.TabStop = false;
            this.grpCancelRegistration.Text = "Cancel Registration";
            // 
            // txtRegistrationID
            // 
            this.txtRegistrationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrationID.Location = new System.Drawing.Point(23, 42);
            this.txtRegistrationID.Multiline = true;
            this.txtRegistrationID.Name = "txtRegistrationID";
            this.txtRegistrationID.Size = new System.Drawing.Size(398, 40);
            this.txtRegistrationID.TabIndex = 16;
            this.txtRegistrationID.TextChanged += new System.EventHandler(this.txtRegistrationID_TextChanged);
            // 
            // grpAddWorkshop
            // 
            this.grpAddWorkshop.BackColor = System.Drawing.Color.LightGray;
            this.grpAddWorkshop.Controls.Add(this.label1);
            this.grpAddWorkshop.Controls.Add(this.lblCapacity);
            this.grpAddWorkshop.Controls.Add(this.lblCategory);
            this.grpAddWorkshop.Controls.Add(this.nudCapacity);
            this.grpAddWorkshop.Controls.Add(this.cmbCategory);
            this.grpAddWorkshop.Controls.Add(this.txtWorkshopTitle);
            this.grpAddWorkshop.Controls.Add(this.btnAddWorkshop);
            this.grpAddWorkshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddWorkshop.Location = new System.Drawing.Point(26, 300);
            this.grpAddWorkshop.Name = "grpAddWorkshop";
            this.grpAddWorkshop.Size = new System.Drawing.Size(453, 261);
            this.grpAddWorkshop.TabIndex = 20;
            this.grpAddWorkshop.TabStop = false;
            this.grpAddWorkshop.Text = "Add Workshop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Workshop Title";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(10, 157);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(88, 29);
            this.lblCapacity.TabIndex = 22;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(10, 93);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 29);
            this.lblCategory.TabIndex = 21;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // nudCapacity
            // 
            this.nudCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCapacity.Location = new System.Drawing.Point(183, 152);
            this.nudCapacity.Name = "nudCapacity";
            this.nudCapacity.Size = new System.Drawing.Size(253, 34);
            this.nudCapacity.TabIndex = 20;
            this.nudCapacity.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.ItemHeight = 29;
            this.cmbCategory.Items.AddRange(new object[] {
            "Technology",
            "Business",
            "Design",
            "Marketing",
            "Finance",
            "Leadership",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(183, 93);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(253, 37);
            this.cmbCategory.TabIndex = 18;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // txtWorkshopTitle
            // 
            this.txtWorkshopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkshopTitle.Location = new System.Drawing.Point(183, 30);
            this.txtWorkshopTitle.Multiline = true;
            this.txtWorkshopTitle.Name = "txtWorkshopTitle";
            this.txtWorkshopTitle.Size = new System.Drawing.Size(253, 39);
            this.txtWorkshopTitle.TabIndex = 16;
            this.txtWorkshopTitle.TextChanged += new System.EventHandler(this.txtWorkshopTitle_TextChanged);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1192, 810);
            this.Controls.Add(this.grpAddWorkshop);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpCancelRegistration);
            this.Controls.Add(this.grpSearchRegistration);
            this.Controls.Add(this.grpRegisterClient);
            this.Controls.Add(this.grpViewWorkshops);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgWorkShops)).EndInit();
            this.grpViewWorkshops.ResumeLayout(false);
            this.grpRegisterClient.ResumeLayout(false);
            this.grpRegisterClient.PerformLayout();
            this.grpSearchRegistration.ResumeLayout(false);
            this.grpSearchRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrations)).EndInit();
            this.grpCancelRegistration.ResumeLayout(false);
            this.grpCancelRegistration.PerformLayout();
            this.grpAddWorkshop.ResumeLayout(false);
            this.grpAddWorkshop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnViewWorkShop;
        private System.Windows.Forms.Button btnRegisterClient;
        private System.Windows.Forms.Button btnAddWorkshop;
        private System.Windows.Forms.Button btnCancelRegistrtion;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dvgWorkShops;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblClientEmail;
        private System.Windows.Forms.Label lblWorkshopID;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.TextBox txtWorkshopID;
        private System.Windows.Forms.GroupBox grpViewWorkshops;
        private System.Windows.Forms.GroupBox grpRegisterClient;
        private System.Windows.Forms.GroupBox grpSearchRegistration;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.DataGridView dgvRegistrations;
        private System.Windows.Forms.GroupBox grpCancelRegistration;
        private System.Windows.Forms.TextBox txtRegistrationID;
        private System.Windows.Forms.GroupBox grpAddWorkshop;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtWorkshopTitle;
        private System.Windows.Forms.NumericUpDown nudCapacity;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
    }
}

