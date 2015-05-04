﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Rubberduck.UI.SourceControl
{
    partial class DummyGitView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Commit = new System.Windows.Forms.Button();
            this.Push = new System.Windows.Forms.Button();
            this.Pull = new System.Windows.Forms.Button();
            this.Fetch = new System.Windows.Forms.Button();
            this.NewBranch = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.Merge = new System.Windows.Forms.Button();
            this.SourceBranch = new System.Windows.Forms.ComboBox();
            this.DestinationBranch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Undo = new System.Windows.Forms.Button();
            this.Revert = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Button();
            this.StatusResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StatusResults)).BeginInit();
            this.SuspendLayout();
            // 
            // Commit
            // 
            this.Commit.Location = new System.Drawing.Point(37, 34);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(75, 23);
            this.Commit.TabIndex = 0;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // Push
            // 
            this.Push.Location = new System.Drawing.Point(37, 64);
            this.Push.Name = "Push";
            this.Push.Size = new System.Drawing.Size(75, 23);
            this.Push.TabIndex = 1;
            this.Push.Text = "Push";
            this.Push.UseVisualStyleBackColor = true;
            this.Push.Click += new System.EventHandler(this.Push_Click);
            // 
            // Pull
            // 
            this.Pull.Location = new System.Drawing.Point(37, 94);
            this.Pull.Name = "Pull";
            this.Pull.Size = new System.Drawing.Size(75, 23);
            this.Pull.TabIndex = 2;
            this.Pull.Text = "Pull";
            this.Pull.UseVisualStyleBackColor = true;
            this.Pull.Click += new System.EventHandler(this.Pull_Click);
            // 
            // Fetch
            // 
            this.Fetch.Location = new System.Drawing.Point(37, 124);
            this.Fetch.Name = "Fetch";
            this.Fetch.Size = new System.Drawing.Size(75, 23);
            this.Fetch.TabIndex = 3;
            this.Fetch.Text = "Fetch";
            this.Fetch.UseVisualStyleBackColor = true;
            this.Fetch.Click += new System.EventHandler(this.Fetch_Click);
            // 
            // NewBranch
            // 
            this.NewBranch.Location = new System.Drawing.Point(37, 154);
            this.NewBranch.Name = "NewBranch";
            this.NewBranch.Size = new System.Drawing.Size(75, 23);
            this.NewBranch.TabIndex = 4;
            this.NewBranch.Text = "New Branch";
            this.NewBranch.UseVisualStyleBackColor = true;
            this.NewBranch.Click += new System.EventHandler(this.NewBranch_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(37, 184);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(75, 23);
            this.Checkout.TabIndex = 5;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // Merge
            // 
            this.Merge.Location = new System.Drawing.Point(37, 214);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(75, 23);
            this.Merge.TabIndex = 6;
            this.Merge.Text = "Merge";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.Merge_Click);
            // 
            // SourceBranch
            // 
            this.SourceBranch.FormattingEnabled = true;
            this.SourceBranch.Items.AddRange(new object[] {
            "master",
            "testbranch"});
            this.SourceBranch.Location = new System.Drawing.Point(119, 214);
            this.SourceBranch.Name = "SourceBranch";
            this.SourceBranch.Size = new System.Drawing.Size(104, 21);
            this.SourceBranch.TabIndex = 7;
            // 
            // DestinationBranch
            // 
            this.DestinationBranch.FormattingEnabled = true;
            this.DestinationBranch.Items.AddRange(new object[] {
            "master",
            "testbranch"});
            this.DestinationBranch.Location = new System.Drawing.Point(229, 214);
            this.DestinationBranch.Name = "DestinationBranch";
            this.DestinationBranch.Size = new System.Drawing.Size(104, 21);
            this.DestinationBranch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination";
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(233, 34);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(75, 23);
            this.Undo.TabIndex = 11;
            this.Undo.Text = "Undo";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Revert
            // 
            this.Revert.Location = new System.Drawing.Point(233, 64);
            this.Revert.Name = "Revert";
            this.Revert.Size = new System.Drawing.Size(75, 23);
            this.Revert.TabIndex = 12;
            this.Revert.Text = "Revert";
            this.Revert.UseVisualStyleBackColor = true;
            this.Revert.Click += new System.EventHandler(this.Revert_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(37, 243);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(75, 23);
            this.Status.TabIndex = 14;
            this.Status.Text = "Status";
            this.Status.UseVisualStyleBackColor = true;
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // StatusResults
            // 
            this.StatusResults.AllowUserToAddRows = false;
            this.StatusResults.AllowUserToDeleteRows = false;
            this.StatusResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatusResults.Location = new System.Drawing.Point(37, 272);
            this.StatusResults.Name = "StatusResults";
            this.StatusResults.ReadOnly = true;
            this.StatusResults.Size = new System.Drawing.Size(292, 171);
            this.StatusResults.TabIndex = 15;
            // 
            // DummyGitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 455);
            this.Controls.Add(this.StatusResults);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Revert);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestinationBranch);
            this.Controls.Add(this.SourceBranch);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.NewBranch);
            this.Controls.Add(this.Fetch);
            this.Controls.Add(this.Pull);
            this.Controls.Add(this.Push);
            this.Controls.Add(this.Commit);
            this.Name = "DummyGitView";
            this.Text = "GitView";
            ((System.ComponentModel.ISupportInitialize)(this.StatusResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Commit;
        private Button Push;
        private Button Pull;
        private Button Fetch;
        private Button NewBranch;
        private Button Checkout;
        private Button Merge;
        private ComboBox SourceBranch;
        private ComboBox DestinationBranch;
        private Label label1;
        private Label label2;
        private Button Undo;
        private Button Revert;
        private Button Status;
        private DataGridView StatusResults;
    }
}