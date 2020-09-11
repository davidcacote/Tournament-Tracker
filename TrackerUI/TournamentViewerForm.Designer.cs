namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropBox = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckedBox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.scoreTeamOne = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.scoreTeamTwo = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.versusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            resources.ApplyResources(this.headerLabel, "headerLabel");
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.headerLabel.Name = "headerLabel";
            // 
            // tournamentName
            // 
            resources.ApplyResources(this.tournamentName, "tournamentName");
            this.tournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tournamentName.Name = "tournamentName";
            // 
            // roundLabel
            // 
            resources.ApplyResources(this.roundLabel, "roundLabel");
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.roundLabel.Name = "roundLabel";
            // 
            // roundDropBox
            // 
            this.roundDropBox.FormattingEnabled = true;
            resources.ApplyResources(this.roundDropBox, "roundDropBox");
            this.roundDropBox.Name = "roundDropBox";
            // 
            // unplayedOnlyCheckedBox
            // 
            resources.ApplyResources(this.unplayedOnlyCheckedBox, "unplayedOnlyCheckedBox");
            this.unplayedOnlyCheckedBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.unplayedOnlyCheckedBox.Name = "unplayedOnlyCheckedBox";
            this.unplayedOnlyCheckedBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            resources.ApplyResources(this.matchupListBox, "matchupListBox");
            this.matchupListBox.Name = "matchupListBox";
            // 
            // teamOneName
            // 
            resources.ApplyResources(this.teamOneName, "teamOneName");
            this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teamOneName.Name = "teamOneName";
            // 
            // scoreTeamOne
            // 
            resources.ApplyResources(this.scoreTeamOne, "scoreTeamOne");
            this.scoreTeamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.scoreTeamOne.Name = "scoreTeamOne";
            // 
            // teamOneScoreValue
            // 
            resources.ApplyResources(this.teamOneScoreValue, "teamOneScoreValue");
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            // 
            // teamTwoScoreValue
            // 
            resources.ApplyResources(this.teamTwoScoreValue, "teamTwoScoreValue");
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            // 
            // scoreTeamTwo
            // 
            resources.ApplyResources(this.scoreTeamTwo, "scoreTeamTwo");
            this.scoreTeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.scoreTeamTwo.Name = "scoreTeamTwo";
            // 
            // teamTwoName
            // 
            resources.ApplyResources(this.teamTwoName, "teamTwoName");
            this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teamTwoName.Name = "teamTwoName";
            // 
            // scoreButton
            // 
            this.scoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.scoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.scoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            resources.ApplyResources(this.scoreButton, "scoreButton");
            this.scoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // versusLabel
            // 
            resources.ApplyResources(this.versusLabel, "versusLabel");
            this.versusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.versusLabel.Name = "versusLabel";
            // 
            // TournamentViewerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.scoreTeamTwo);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.scoreTeamOne);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckedBox);
            this.Controls.Add(this.roundDropBox);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Name = "TournamentViewerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropBox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckedBox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label scoreTeamOne;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label scoreTeamTwo;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Label versusLabel;
    }
}

