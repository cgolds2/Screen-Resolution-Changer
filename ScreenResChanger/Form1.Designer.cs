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
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
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
            this.dgvProfiles.Location = new System.Drawing.Point(15, 210);
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
            this.setResolution.Location = new System.Drawing.Point(483, 210);
            this.setResolution.Name = "setResolution";
            this.setResolution.Size = new System.Drawing.Size(160, 40);
            this.setResolution.TabIndex = 4;
            this.setResolution.Text = "Set Resolution";
            this.setResolution.UseVisualStyleBackColor = true;
            this.setResolution.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 687);
            this.Controls.Add(this.setResolution);
            this.Controls.Add(this.dgvProfiles);
            this.Controls.Add(this.btnGetProfiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvScreens);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
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
    }
}

