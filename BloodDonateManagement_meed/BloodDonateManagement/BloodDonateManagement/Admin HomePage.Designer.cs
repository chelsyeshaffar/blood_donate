namespace BloodDonateManagement
{
    partial class HomePage
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.donorStatusComboBox = new MetroFramework.Controls.MetroComboBox();
            this.bloodGroupCombo = new MetroFramework.Controls.MetroComboBox();
            this.genderComboBox = new MetroFramework.Controls.MetroComboBox();
            this.Update_btn = new MetroFramework.Controls.MetroButton();
            this.Create_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.PassLabel = new MetroFramework.Controls.MetroLabel();
            this.PassTxt = new MetroFramework.Controls.MetroTextBox();
            this.EmailLabel = new MetroFramework.Controls.MetroLabel();
            this.AreaLabel = new MetroFramework.Controls.MetroLabel();
            this.BloodGroupLabal = new MetroFramework.Controls.MetroLabel();
            this.AgeLabel = new MetroFramework.Controls.MetroLabel();
            this.NameLabel = new MetroFramework.Controls.MetroLabel();
            this.EmailTxt = new MetroFramework.Controls.MetroTextBox();
            this.AreaTxt = new MetroFramework.Controls.MetroTextBox();
            this.AgeTxt = new MetroFramework.Controls.MetroTextBox();
            this.SignNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.UserDataTable = new System.Windows.Forms.DataGridView();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminDataSet = new BloodDonateManagement.AdminDataSet();
            this.user_TableTableAdapter = new BloodDonateManagement.AdminDataSetTableAdapters.User_TableTableAdapter();
            this.DonorStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.donorStatusComboBox);
            this.metroPanel1.Controls.Add(this.bloodGroupCombo);
            this.metroPanel1.Controls.Add(this.genderComboBox);
            this.metroPanel1.Controls.Add(this.Update_btn);
            this.metroPanel1.Controls.Add(this.deleteButton);
            this.metroPanel1.Controls.Add(this.Create_btn);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.PassLabel);
            this.metroPanel1.Controls.Add(this.PassTxt);
            this.metroPanel1.Controls.Add(this.EmailLabel);
            this.metroPanel1.Controls.Add(this.AreaLabel);
            this.metroPanel1.Controls.Add(this.BloodGroupLabal);
            this.metroPanel1.Controls.Add(this.AgeLabel);
            this.metroPanel1.Controls.Add(this.NameLabel);
            this.metroPanel1.Controls.Add(this.EmailTxt);
            this.metroPanel1.Controls.Add(this.AreaTxt);
            this.metroPanel1.Controls.Add(this.AgeTxt);
            this.metroPanel1.Controls.Add(this.SignNameTxt);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(30, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(180, 336);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // donorStatusComboBox
            // 
            this.donorStatusComboBox.FormattingEnabled = true;
            this.donorStatusComboBox.ItemHeight = 23;
            this.donorStatusComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.donorStatusComboBox.Location = new System.Drawing.Point(93, 228);
            this.donorStatusComboBox.Name = "donorStatusComboBox";
            this.donorStatusComboBox.Size = new System.Drawing.Size(75, 29);
            this.donorStatusComboBox.TabIndex = 19;
            // 
            // bloodGroupCombo
            // 
            this.bloodGroupCombo.FormattingEnabled = true;
            this.bloodGroupCombo.ItemHeight = 23;
            this.bloodGroupCombo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.bloodGroupCombo.Location = new System.Drawing.Point(93, 64);
            this.bloodGroupCombo.Name = "bloodGroupCombo";
            this.bloodGroupCombo.Size = new System.Drawing.Size(75, 29);
            this.bloodGroupCombo.TabIndex = 19;
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.ItemHeight = 23;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(93, 187);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(75, 29);
            this.genderComboBox.TabIndex = 19;
            // 
            // Update_btn
            // 
            this.Update_btn.Location = new System.Drawing.Point(93, 267);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(75, 23);
            this.Update_btn.TabIndex = 18;
            this.Update_btn.Text = "Update";
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(6, 267);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(75, 23);
            this.Create_btn.TabIndex = 17;
            this.Create_btn.Text = "Insert";
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 235);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Donor?";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 187);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 16;
            this.metroLabel1.Text = "Gender";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(6, 152);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(63, 19);
            this.PassLabel.TabIndex = 16;
            this.PassLabel.Text = "Password";
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(93, 152);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(75, 23);
            this.PassTxt.TabIndex = 15;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(6, 123);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 19);
            this.EmailLabel.TabIndex = 14;
            this.EmailLabel.Text = "Email";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(6, 95);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(37, 19);
            this.AreaLabel.TabIndex = 12;
            this.AreaLabel.Text = "Area";
            // 
            // BloodGroupLabal
            // 
            this.BloodGroupLabal.AutoSize = true;
            this.BloodGroupLabal.Location = new System.Drawing.Point(6, 66);
            this.BloodGroupLabal.Name = "BloodGroupLabal";
            this.BloodGroupLabal.Size = new System.Drawing.Size(80, 19);
            this.BloodGroupLabal.TabIndex = 11;
            this.BloodGroupLabal.Text = "BloudGroup";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(6, 37);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(33, 19);
            this.AgeLabel.TabIndex = 10;
            this.AgeLabel.Text = "Age";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 19);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(93, 123);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(75, 23);
            this.EmailTxt.TabIndex = 8;
            // 
            // AreaTxt
            // 
            this.AreaTxt.Location = new System.Drawing.Point(93, 95);
            this.AreaTxt.Name = "AreaTxt";
            this.AreaTxt.Size = new System.Drawing.Size(75, 23);
            this.AreaTxt.TabIndex = 6;
            // 
            // AgeTxt
            // 
            this.AgeTxt.Location = new System.Drawing.Point(93, 37);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(75, 23);
            this.AgeTxt.TabIndex = 4;
            // 
            // SignNameTxt
            // 
            this.SignNameTxt.Location = new System.Drawing.Point(93, 8);
            this.SignNameTxt.Name = "SignNameTxt";
            this.SignNameTxt.Size = new System.Drawing.Size(75, 23);
            this.SignNameTxt.TabIndex = 3;
            // 
            // UserDataTable
            // 
            this.UserDataTable.AllowUserToDeleteRows = false;
            this.UserDataTable.AutoGenerateColumns = false;
            this.UserDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UserDataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UserDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Sex,
            this.DonorStatus});
            this.UserDataTable.DataSource = this.userTableBindingSource;
            this.UserDataTable.Location = new System.Drawing.Point(234, 110);
            this.UserDataTable.Name = "UserDataTable";
            this.UserDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataTable.Size = new System.Drawing.Size(416, 289);
            this.UserDataTable.TabIndex = 1;
            this.UserDataTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataTable_CellClick);
            this.UserDataTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataTable_CellDoubleClick);
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "User_Table";
            this.userTableBindingSource.DataSource = this.adminDataSet;
            // 
            // adminDataSet
            // 
            this.adminDataSet.DataSetName = "AdminDataSet";
            this.adminDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_TableTableAdapter
            // 
            this.user_TableTableAdapter.ClearBeforeFill = true;
            // 
            // DonorStatus
            // 
            this.DonorStatus.DataPropertyName = "DonorStatus";
            this.DonorStatus.HeaderText = "DonorStatus";
            this.DonorStatus.Name = "DonorStatus";
            this.DonorStatus.Width = 91;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sex";
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.Width = 50;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 57;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.ReadOnly = true;
            this.areaDataGridViewTextBoxColumn.Width = 54;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.bloodGroupDataGridViewTextBoxColumn.Width = 88;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 51;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(6, 300);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(162, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(234, 71);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Search";
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(288, 71);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(362, 23);
            this.txtSearchBox.TabIndex = 3;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 422);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.UserDataTable);
            this.Controls.Add(this.metroPanel1);
            this.Name = "HomePage";
            this.Text = "Admin HomePage";
            this.Load += new System.EventHandler(this.Admin_HomePage_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView UserDataTable;
        private MetroFramework.Controls.MetroTextBox SignNameTxt;
        private AdminDataSet adminDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private AdminDataSetTableAdapters.User_TableTableAdapter user_TableTableAdapter;
        private MetroFramework.Controls.MetroTextBox AgeTxt;
        private MetroFramework.Controls.MetroTextBox EmailTxt;
        private MetroFramework.Controls.MetroTextBox AreaTxt;
        private MetroFramework.Controls.MetroButton Create_btn;
        private MetroFramework.Controls.MetroLabel PassLabel;
        private MetroFramework.Controls.MetroTextBox PassTxt;
        private MetroFramework.Controls.MetroLabel EmailLabel;
        private MetroFramework.Controls.MetroLabel AreaLabel;
        private MetroFramework.Controls.MetroLabel BloodGroupLabal;
        private MetroFramework.Controls.MetroLabel AgeLabel;
        private MetroFramework.Controls.MetroLabel NameLabel;
        private MetroFramework.Controls.MetroButton Update_btn;
        private MetroFramework.Controls.MetroComboBox genderComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox donorStatusComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox bloodGroupCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorStatus;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtSearchBox;
    }
}