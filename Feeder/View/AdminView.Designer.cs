﻿namespace View
{
    partial class AdminView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.userSelect = new System.Windows.Forms.ComboBox();
            this.feederNameInput = new System.Windows.Forms.TextBox();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.userList = new System.Windows.Forms.DataGridView();
            this.addFeeder = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.logPage = new System.Windows.Forms.TabPage();
            this.logs = new System.Windows.Forms.DataGridView();
            this.exportLog = new System.Windows.Forms.Button();
            this.requestPage = new System.Windows.Forms.TabPage();
            this.rejectRequest = new System.Windows.Forms.Button();
            this.acceptRequest = new System.Windows.Forms.Button();
            this.requestsList = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
            this.logPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logs)).BeginInit();
            this.requestPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.logPage);
            this.tabControl1.Controls.Add(this.requestPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 342);
            this.tabControl1.TabIndex = 0;
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.userSelect);
            this.mainPage.Controls.Add(this.feederNameInput);
            this.mainPage.Controls.Add(this.userNameInput);
            this.mainPage.Controls.Add(this.dataGridView3);
            this.mainPage.Controls.Add(this.userList);
            this.mainPage.Controls.Add(this.addFeeder);
            this.mainPage.Controls.Add(this.addUser);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainPage.Size = new System.Drawing.Size(502, 316);
            this.mainPage.TabIndex = 0;
            this.mainPage.Text = "Register and add feeders";
            this.mainPage.UseVisualStyleBackColor = true;
            this.mainPage.Click += new System.EventHandler(this.mainPage_Click);
            // 
            // userSelect
            // 
            this.userSelect.FormattingEnabled = true;
            this.userSelect.Location = new System.Drawing.Point(209, 266);
            this.userSelect.Name = "userSelect";
            this.userSelect.Size = new System.Drawing.Size(121, 21);
            this.userSelect.TabIndex = 10;
            this.userSelect.SelectedIndexChanged += new System.EventHandler(this.userSelect_SelectedIndexChanged);
            // 
            // feederNameInput
            // 
            this.feederNameInput.Location = new System.Drawing.Point(101, 267);
            this.feederNameInput.Name = "feederNameInput";
            this.feederNameInput.Size = new System.Drawing.Size(100, 20);
            this.feederNameInput.TabIndex = 9;
            // 
            // userNameInput
            // 
            this.userNameInput.Location = new System.Drawing.Point(162, 100);
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(100, 20);
            this.userNameInput.TabIndex = 8;
            this.userNameInput.TextChanged += new System.EventHandler(this.userNameInput_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(162, 148);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(177, 110);
            this.dataGridView3.TabIndex = 7;
            // 
            // userList
            // 
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userList.Location = new System.Drawing.Point(162, 6);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(177, 77);
            this.userList.TabIndex = 6;
            // 
            // addFeeder
            // 
            this.addFeeder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFeeder.Location = new System.Drawing.Point(336, 266);
            this.addFeeder.Name = "addFeeder";
            this.addFeeder.Size = new System.Drawing.Size(59, 21);
            this.addFeeder.TabIndex = 5;
            this.addFeeder.Text = "Add";
            this.addFeeder.UseVisualStyleBackColor = true;
            this.addFeeder.Click += new System.EventHandler(this.button3_Click);
            // 
            // addUser
            // 
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.Location = new System.Drawing.Point(264, 100);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(75, 20);
            this.addUser.TabIndex = 1;
            this.addUser.Text = "Register";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // logPage
            // 
            this.logPage.Controls.Add(this.logs);
            this.logPage.Controls.Add(this.exportLog);
            this.logPage.Location = new System.Drawing.Point(4, 22);
            this.logPage.Name = "logPage";
            this.logPage.Padding = new System.Windows.Forms.Padding(3);
            this.logPage.Size = new System.Drawing.Size(502, 316);
            this.logPage.TabIndex = 1;
            this.logPage.Text = "Log";
            this.logPage.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logs.Location = new System.Drawing.Point(131, 22);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(240, 150);
            this.logs.TabIndex = 2;
            // 
            // exportLog
            // 
            this.exportLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportLog.Location = new System.Drawing.Point(197, 187);
            this.exportLog.Name = "exportLog";
            this.exportLog.Size = new System.Drawing.Size(104, 33);
            this.exportLog.TabIndex = 1;
            this.exportLog.Text = "Export log";
            this.exportLog.UseVisualStyleBackColor = true;
            this.exportLog.Click += new System.EventHandler(this.button4_Click);
            // 
            // requestPage
            // 
            this.requestPage.Controls.Add(this.rejectRequest);
            this.requestPage.Controls.Add(this.acceptRequest);
            this.requestPage.Controls.Add(this.requestsList);
            this.requestPage.Location = new System.Drawing.Point(4, 22);
            this.requestPage.Name = "requestPage";
            this.requestPage.Padding = new System.Windows.Forms.Padding(3);
            this.requestPage.Size = new System.Drawing.Size(502, 316);
            this.requestPage.TabIndex = 2;
            this.requestPage.Text = "Requests";
            this.requestPage.UseVisualStyleBackColor = true;
            // 
            // rejectRequest
            // 
            this.rejectRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rejectRequest.Location = new System.Drawing.Point(408, 75);
            this.rejectRequest.Name = "rejectRequest";
            this.rejectRequest.Size = new System.Drawing.Size(86, 34);
            this.rejectRequest.TabIndex = 2;
            this.rejectRequest.Text = "Reject";
            this.rejectRequest.UseVisualStyleBackColor = true;
            // 
            // acceptRequest
            // 
            this.acceptRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.acceptRequest.Location = new System.Drawing.Point(408, 17);
            this.acceptRequest.Name = "acceptRequest";
            this.acceptRequest.Size = new System.Drawing.Size(86, 34);
            this.acceptRequest.TabIndex = 1;
            this.acceptRequest.Text = "Accept";
            this.acceptRequest.UseVisualStyleBackColor = true;
            // 
            // requestsList
            // 
            this.requestsList.FormattingEnabled = true;
            this.requestsList.Location = new System.Drawing.Point(8, 6);
            this.requestsList.Name = "requestsList";
            this.requestsList.Size = new System.Drawing.Size(394, 304);
            this.requestsList.TabIndex = 0;
            this.requestsList.SelectedIndexChanged += new System.EventHandler(this.requestsList_SelectedIndexChanged);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 342);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminView";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            this.logPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logs)).EndInit();
            this.requestPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.TabPage logPage;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button addFeeder;
        private System.Windows.Forms.Button exportLog;
        private System.Windows.Forms.DataGridView logs;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView userList;
        private System.Windows.Forms.TextBox feederNameInput;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.ComboBox userSelect;
        private System.Windows.Forms.TabPage requestPage;
        private System.Windows.Forms.Button rejectRequest;
        private System.Windows.Forms.Button acceptRequest;
        private System.Windows.Forms.CheckedListBox requestsList;
    }
}