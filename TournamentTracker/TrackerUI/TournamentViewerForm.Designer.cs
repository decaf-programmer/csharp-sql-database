
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.unplayedonlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamoneName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamtwoScoreValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teamtwoName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.teamoneScoreValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(59, 43);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(133, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Tournament:";
            this.headerLabel.Click += new System.EventHandler(this.headerLabel_Click);
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.Location = new System.Drawing.Point(192, 43);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(84, 25);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Round";
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(134, 88);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(142, 21);
            this.roundDropdown.TabIndex = 3;
            // 
            // unplayedonlyCheckbox
            // 
            this.unplayedonlyCheckbox.AutoSize = true;
            this.unplayedonlyCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedonlyCheckbox.Location = new System.Drawing.Point(134, 139);
            this.unplayedonlyCheckbox.Name = "unplayedonlyCheckbox";
            this.unplayedonlyCheckbox.Size = new System.Drawing.Size(153, 28);
            this.unplayedonlyCheckbox.TabIndex = 4;
            this.unplayedonlyCheckbox.Text = "Unplayed Only";
            this.unplayedonlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.Location = new System.Drawing.Point(65, 210);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(211, 199);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamoneName
            // 
            this.teamoneName.AutoSize = true;
            this.teamoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamoneName.Location = new System.Drawing.Point(352, 210);
            this.teamoneName.Name = "teamoneName";
            this.teamoneName.Size = new System.Drawing.Size(111, 24);
            this.teamoneName.TabIndex = 6;
            this.teamoneName.Text = "<team one>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Score";
            // 
            // teamtwoScoreValue
            // 
            this.teamtwoScoreValue.AutoSize = true;
            this.teamtwoScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamtwoScoreValue.Location = new System.Drawing.Point(422, 368);
            this.teamtwoScoreValue.Name = "teamtwoScoreValue";
            this.teamtwoScoreValue.Size = new System.Drawing.Size(0, 24);
            this.teamtwoScoreValue.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(356, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Score";
            // 
            // teamtwoName
            // 
            this.teamtwoName.AutoSize = true;
            this.teamtwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamtwoName.Location = new System.Drawing.Point(352, 329);
            this.teamtwoName.Name = "teamtwoName";
            this.teamtwoName.Size = new System.Drawing.Size(107, 24);
            this.teamtwoName.TabIndex = 9;
            this.teamtwoName.Text = "<team two>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "- VS -";
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(517, 280);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(75, 23);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // teamoneScoreValue
            // 
            this.teamoneScoreValue.AutoSize = true;
            this.teamoneScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamoneScoreValue.Location = new System.Drawing.Point(422, 249);
            this.teamoneScoreValue.Name = "teamoneScoreValue";
            this.teamoneScoreValue.Size = new System.Drawing.Size(0, 24);
            this.teamoneScoreValue.TabIndex = 8;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 460);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teamtwoScoreValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teamtwoName);
            this.Controls.Add(this.teamoneScoreValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teamoneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedonlyCheckbox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.headerLabel);
            this.Name = "TournamentViewerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.CheckBox unplayedonlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamoneName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label teamtwoScoreValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label teamtwoName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Label teamoneScoreValue;
    }
}

