namespace ScreenResChanger
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
            this.dgvScreens = new System.Windows.Forms.DataGridView();
            this.ScreenNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScreenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResolutionX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResolutionY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetProfiles = new System.Windows.Forms.Button();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.ProfileNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setResolution = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.lblScreenName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSavedProfiles = new System.Windows.Forms.DataGridView();
            this.btnNewProfile = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavedProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvScreens
            // 
            this.dgvScreens.AllowUserToAddRows = false;
            this.dgvScreens.AllowUserToDeleteRows = false;
            this.dgvScreens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScreens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ScreenNumber,
            this.ScreenName,
            this.ResolutionX,
            this.ResolutionY});
            this.dgvScreens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvScreens.Location = new System.Drawing.Point(12, 25);
            this.dgvScreens.MultiSelect = false;
            this.dgvScreens.Name = "dgvScreens";
            this.dgvScreens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScreens.Size = new System.Drawing.Size(443, 150);
            this.dgvScreens.TabIndex = 0;
            // 
            // ScreenNumber
            // 
            this.ScreenNumber.HeaderText = "Screen Number";
            this.ScreenNumber.Name = "ScreenNumber";
            this.ScreenNumber.ReadOnly = true;
            // 
            // ScreenName
            // 
            this.ScreenName.HeaderText = "Screen Name";
            this.ScreenName.Name = "ScreenName";
            this.ScreenName.ReadOnly = true;
            // 
            // ResolutionX
            // 
            this.ResolutionX.HeaderText = "Resolution X";
            this.ResolutionX.Name = "ResolutionX";
            this.ResolutionX.ReadOnly = true;
            // 
            // ResolutionY
            // 
            this.ResolutionY.HeaderText = "Resolution Y";
            this.ResolutionY.Name = "ResolutionY";
            this.ResolutionY.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Screens";
            // 
            // btnGetProfiles
            // 
            this.btnGetProfiles.Location = new System.Drawing.Point(12, 181);
            this.btnGetProfiles.Name = "btnGetProfiles";
            this.btnGetProfiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGetProfiles.Size = new System.Drawing.Size(75, 23);
            this.btnGetProfiles.TabIndex = 2;
            this.btnGetProfiles.Text = "Get Profiles";
            this.btnGetProfiles.UseVisualStyleBackColor = true;
            this.btnGetProfiles.Click += new System.EventHandler(this.btnGetProfiles_Click);
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.AllowUserToAddRows = false;
            this.dgvProfiles.AllowUserToDeleteRows = false;
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileNumber,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Frequency});
            this.dgvProfiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProfiles.Location = new System.Drawing.Point(15, 237);
            this.dgvProfiles.MultiSelect = false;
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfiles.Size = new System.Drawing.Size(462, 438);
            this.dgvProfiles.TabIndex = 3;
            // 
            // ProfileNumber
            // 
            this.ProfileNumber.HeaderText = "Profile Number";
            this.ProfileNumber.Name = "ProfileNumber";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Resolution X";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Resolution Y";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // setResolution
            // 
            this.setResolution.Location = new System.Drawing.Point(483, 237);
            this.setResolution.Name = "setResolution";
            this.setResolution.Size = new System.Drawing.Size(160, 40);
            this.setResolution.TabIndex = 4;
            this.setResolution.Text = "Set Resolution";
            this.setResolution.UseVisualStyleBackColor = true;
            this.setResolution.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(483, 283);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(160, 40);
            this.btnSaveProfile.TabIndex = 5;
            this.btnSaveProfile.Text = "Save to Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblScreenName
            // 
            this.lblScreenName.AutoSize = true;
            this.lblScreenName.Location = new System.Drawing.Point(90, 221);
            this.lblScreenName.Name = "lblScreenName";
            this.lblScreenName.Size = new System.Drawing.Size(52, 13);
            this.lblScreenName.TabIndex = 6;
            this.lblScreenName.Text = "None Set";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Screen:";
            // 
            // dgvSavedProfiles
            // 
            this.dgvSavedProfiles.AllowUserToAddRows = false;
            this.dgvSavedProfiles.AllowUserToDeleteRows = false;
            this.dgvSavedProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavedProfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.DisplayFrequency});
            this.dgvSavedProfiles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSavedProfiles.Location = new System.Drawing.Point(649, 237);
            this.dgvSavedProfiles.MultiSelect = false;
            this.dgvSavedProfiles.Name = "dgvSavedProfiles";
            this.dgvSavedProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSavedProfiles.Size = new System.Drawing.Size(541, 438);
            this.dgvSavedProfiles.TabIndex = 9;
            // 
            // btnNewProfile
            // 
            this.btnNewProfile.Location = new System.Drawing.Point(483, 329);
            this.btnNewProfile.Name = "btnNewProfile";
            this.btnNewProfile.Size = new System.Drawing.Size(160, 40);
            this.btnNewProfile.TabIndex = 10;
            this.btnNewProfile.Text = "Create New Profile";
            this.btnNewProfile.UseVisualStyleBackColor = true;
            this.btnNewProfile.Click += new System.EventHandler(this.btnNewProfile_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Profile Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Screen Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Resolution X";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Resolution Y";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DisplayFrequency
            // 
            this.DisplayFrequency.HeaderText = "Display Frequency";
            this.DisplayFrequency.Name = "DisplayFrequency";
            this.DisplayFrequency.ReadOnly = true;
            this.DisplayFrequency.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 687);
            this.Controls.Add(this.btnNewProfile);
            this.Controls.Add(this.dgvSavedProfiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScreenName);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.setResolution);
            this.Controls.Add(this.dgvProfiles);
            this.Controls.Add(this.btnGetProfiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvScreens);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavedProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvScreens;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScreenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResolutionX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResolutionY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetProfiles;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.Button setResolution;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Label lblScreenName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSavedProfiles;
        private System.Windows.Forms.Button btnNewProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayFrequency;
    }
}

