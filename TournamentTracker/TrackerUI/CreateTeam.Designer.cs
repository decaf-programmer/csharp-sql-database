
namespace TrackerUI
{
    partial class CreateTeam
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
            this.label1 = new System.Windows.Forms.Label();
            this.teamNameValue = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedTeamMemberValue = new System.Windows.Forms.MaskedTextBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstnameValue = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cellPhoneValue = new System.Windows.Forms.MaskedTextBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedTeamMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Team";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(49, 86);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(238, 20);
            this.teamNameValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Team Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Team Member";
            // 
            // selectedTeamMemberValue
            // 
            this.selectedTeamMemberValue.Location = new System.Drawing.Point(47, 152);
            this.selectedTeamMemberValue.Name = "selectedTeamMemberValue";
            this.selectedTeamMemberValue.Size = new System.Drawing.Size(240, 20);
            this.selectedTeamMemberValue.TabIndex = 3;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(124, 189);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(75, 23);
            this.addMemberButton.TabIndex = 5;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createMemberButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cellPhoneValue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.emailValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lastNameValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.firstnameValue);
            this.groupBox1.Location = new System.Drawing.Point(49, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 195);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "First Name";
            // 
            // firstnameValue
            // 
            this.firstnameValue.Location = new System.Drawing.Point(97, 31);
            this.firstnameValue.Name = "firstnameValue";
            this.firstnameValue.Size = new System.Drawing.Size(100, 20);
            this.firstnameValue.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Last Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(97, 57);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(100, 20);
            this.lastNameValue.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(97, 83);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(100, 20);
            this.emailValue.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cellphone";
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Location = new System.Drawing.Point(97, 109);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(100, 20);
            this.cellPhoneValue.TabIndex = 13;
            // 
            // createMemberButton
            // 
            this.createMemberButton.Location = new System.Drawing.Point(62, 155);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(105, 23);
            this.createMemberButton.TabIndex = 7;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.Location = new System.Drawing.Point(354, 86);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(204, 329);
            this.teamMembersListBox.TabIndex = 7;
            // 
            // deleteSelectedTeamMemberButton
            // 
            this.deleteSelectedTeamMemberButton.Location = new System.Drawing.Point(564, 249);
            this.deleteSelectedTeamMemberButton.Name = "deleteSelectedTeamMemberButton";
            this.deleteSelectedTeamMemberButton.Size = new System.Drawing.Size(98, 31);
            this.deleteSelectedTeamMemberButton.TabIndex = 8;
            this.deleteSelectedTeamMemberButton.Text = "Delete Selected";
            this.deleteSelectedTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.Location = new System.Drawing.Point(265, 444);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(110, 23);
            this.createTeamButton.TabIndex = 9;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 484);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedTeamMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedTeamMemberValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.label1);
            this.Name = "CreateTeam";
            this.Text = "CreateTeam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox teamNameValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox selectedTeamMemberValue;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox cellPhoneValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox emailValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox lastNameValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox firstnameValue;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedTeamMemberButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}