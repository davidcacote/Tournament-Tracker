namespace TrackerUI
{
    partial class createTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createTeamForm));
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.groupAddMemberLabel = new System.Windows.Forms.GroupBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.phoneMemberValue = new System.Windows.Forms.TextBox();
            this.phoneMemberLabel = new System.Windows.Forms.Label();
            this.emailMemberValue = new System.Windows.Forms.TextBox();
            this.emailMemberLabel = new System.Windows.Forms.Label();
            this.LastNameMemberValue = new System.Windows.Forms.TextBox();
            this.lastNameMemberLabel = new System.Windows.Forms.Label();
            this.firstNameMemberValue = new System.Windows.Forms.TextBox();
            this.firstNameMemberLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.groupAddMemberLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(42, 162);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(479, 43);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.teamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teamNameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.teamNameLabel.Location = new System.Drawing.Point(34, 113);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(197, 46);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.headerLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.headerLabel.Location = new System.Drawing.Point(31, 31);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(276, 65);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(42, 277);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(479, 45);
            this.selectTeamMemberDropDown.TabIndex = 16;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.selectTeamMemberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(34, 228);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(335, 46);
            this.selectTeamMemberLabel.TabIndex = 15;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 37;
            this.teamMembersListBox.Location = new System.Drawing.Point(618, 113);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(429, 631);
            this.teamMembersListBox.TabIndex = 19;
            // 
            // groupAddMemberLabel
            // 
            this.groupAddMemberLabel.Controls.Add(this.scoreButton);
            this.groupAddMemberLabel.Controls.Add(this.phoneMemberValue);
            this.groupAddMemberLabel.Controls.Add(this.phoneMemberLabel);
            this.groupAddMemberLabel.Controls.Add(this.emailMemberValue);
            this.groupAddMemberLabel.Controls.Add(this.emailMemberLabel);
            this.groupAddMemberLabel.Controls.Add(this.LastNameMemberValue);
            this.groupAddMemberLabel.Controls.Add(this.lastNameMemberLabel);
            this.groupAddMemberLabel.Controls.Add(this.firstNameMemberValue);
            this.groupAddMemberLabel.Controls.Add(this.firstNameMemberLabel);
            this.groupAddMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupAddMemberLabel.Location = new System.Drawing.Point(42, 421);
            this.groupAddMemberLabel.Name = "groupAddMemberLabel";
            this.groupAddMemberLabel.Size = new System.Drawing.Size(479, 323);
            this.groupAddMemberLabel.TabIndex = 20;
            this.groupAddMemberLabel.TabStop = false;
            this.groupAddMemberLabel.Text = "Add Member";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.scoreButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.scoreButton.Location = new System.Drawing.Point(119, 267);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(239, 43);
            this.scoreButton.TabIndex = 29;
            this.scoreButton.Text = "Create Member";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // phoneMemberValue
            // 
            this.phoneMemberValue.Location = new System.Drawing.Point(193, 202);
            this.phoneMemberValue.Name = "phoneMemberValue";
            this.phoneMemberValue.Size = new System.Drawing.Size(271, 43);
            this.phoneMemberValue.TabIndex = 28;
            // 
            // phoneMemberLabel
            // 
            this.phoneMemberLabel.AutoSize = true;
            this.phoneMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.phoneMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.phoneMemberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.phoneMemberLabel.Location = new System.Drawing.Point(6, 199);
            this.phoneMemberLabel.Name = "phoneMemberLabel";
            this.phoneMemberLabel.Size = new System.Drawing.Size(115, 46);
            this.phoneMemberLabel.TabIndex = 27;
            this.phoneMemberLabel.Text = "Phone";
            // 
            // emailMemberValue
            // 
            this.emailMemberValue.Location = new System.Drawing.Point(193, 152);
            this.emailMemberValue.Name = "emailMemberValue";
            this.emailMemberValue.Size = new System.Drawing.Size(271, 43);
            this.emailMemberValue.TabIndex = 26;
            // 
            // emailMemberLabel
            // 
            this.emailMemberLabel.AutoSize = true;
            this.emailMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.emailMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.emailMemberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.emailMemberLabel.Location = new System.Drawing.Point(6, 149);
            this.emailMemberLabel.Name = "emailMemberLabel";
            this.emailMemberLabel.Size = new System.Drawing.Size(99, 46);
            this.emailMemberLabel.TabIndex = 25;
            this.emailMemberLabel.Text = "Email";
            // 
            // LastNameMemberValue
            // 
            this.LastNameMemberValue.Location = new System.Drawing.Point(193, 103);
            this.LastNameMemberValue.Name = "LastNameMemberValue";
            this.LastNameMemberValue.Size = new System.Drawing.Size(271, 43);
            this.LastNameMemberValue.TabIndex = 24;
            // 
            // lastNameMemberLabel
            // 
            this.lastNameMemberLabel.AutoSize = true;
            this.lastNameMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lastNameMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lastNameMemberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lastNameMemberLabel.Location = new System.Drawing.Point(6, 100);
            this.lastNameMemberLabel.Name = "lastNameMemberLabel";
            this.lastNameMemberLabel.Size = new System.Drawing.Size(177, 46);
            this.lastNameMemberLabel.TabIndex = 23;
            this.lastNameMemberLabel.Text = "Last Name";
            // 
            // firstNameMemberValue
            // 
            this.firstNameMemberValue.Location = new System.Drawing.Point(193, 54);
            this.firstNameMemberValue.Name = "firstNameMemberValue";
            this.firstNameMemberValue.Size = new System.Drawing.Size(271, 43);
            this.firstNameMemberValue.TabIndex = 22;
            // 
            // firstNameMemberLabel
            // 
            this.firstNameMemberLabel.AutoSize = true;
            this.firstNameMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.firstNameMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.firstNameMemberLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.firstNameMemberLabel.Location = new System.Drawing.Point(6, 51);
            this.firstNameMemberLabel.Name = "firstNameMemberLabel";
            this.firstNameMemberLabel.Size = new System.Drawing.Size(181, 46);
            this.firstNameMemberLabel.TabIndex = 21;
            this.firstNameMemberLabel.Text = "First Name";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addMemberButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addMemberButton.Location = new System.Drawing.Point(124, 330);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(239, 52);
            this.addMemberButton.TabIndex = 30;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.deleteSelectedMemberButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(1081, 330);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(137, 96);
            this.deleteSelectedMemberButton.TabIndex = 31;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.createTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.createTeamButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.createTeamButton.Location = new System.Drawing.Point(451, 799);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(299, 56);
            this.createTeamButton.TabIndex = 32;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // createTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 905);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.groupAddMemberLabel);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "createTeamForm";
            this.Text = "Create Team";
            this.groupAddMemberLabel.ResumeLayout(false);
            this.groupAddMemberLabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.GroupBox groupAddMemberLabel;
        private System.Windows.Forms.TextBox LastNameMemberValue;
        private System.Windows.Forms.Label lastNameMemberLabel;
        private System.Windows.Forms.TextBox firstNameMemberValue;
        private System.Windows.Forms.Label firstNameMemberLabel;
        private System.Windows.Forms.TextBox phoneMemberValue;
        private System.Windows.Forms.Label phoneMemberLabel;
        private System.Windows.Forms.TextBox emailMemberValue;
        private System.Windows.Forms.Label emailMemberLabel;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button deleteSelectedMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}