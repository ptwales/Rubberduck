﻿using System.ComponentModel;
using System.Windows.Forms;

namespace Rubberduck.UI.CodeExplorer
{
    partial class CodeExplorerWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeExplorerWindow));
            this.CodeExplorerToolbar = new System.Windows.Forms.ToolStrip();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.ShowFoldersToggleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ShowDesignerButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddClassButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStdModuleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFormButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTestModuleButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplayModeButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.DisplayMemberNamesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DisplaySignaturesButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedNodeLabel = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SolutionTree = new System.Windows.Forms.TreeView();
            this.CodeExplorerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClassContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStdModuleContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFormContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.AddTestModuleContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigateContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FindAllReferencesContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FindAllImplementationsContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowDesignerContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.InspectContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RunAllTestsContextButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeNodeIcons = new System.Windows.Forms.ImageList(this.components);
            this.CodeExplorerToolbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CodeExplorerContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeExplorerToolbar
            // 
            this.CodeExplorerToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CodeExplorerToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshButton,
            this.ShowFoldersToggleButton,
            this.toolStripSeparator2,
            this.ShowDesignerButton,
            this.toolStripSeparator3,
            this.AddButton,
            this.DisplayModeButton,
            this.SelectedNodeLabel});
            this.CodeExplorerToolbar.Location = new System.Drawing.Point(0, 0);
            this.CodeExplorerToolbar.Name = "CodeExplorerToolbar";
            this.CodeExplorerToolbar.Size = new System.Drawing.Size(280, 25);
            this.CodeExplorerToolbar.TabIndex = 0;
            this.CodeExplorerToolbar.Text = "toolStrip1";
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::Rubberduck.Properties.Resources.arrow_circle_double;
            this.RefreshButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshButton.ToolTipText = "Refresh";
            // 
            // ShowFoldersToggleButton
            // 
            this.ShowFoldersToggleButton.Checked = true;
            this.ShowFoldersToggleButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowFoldersToggleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowFoldersToggleButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowFoldersToggleButton.Image")));
            this.ShowFoldersToggleButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowFoldersToggleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowFoldersToggleButton.Name = "ShowFoldersToggleButton";
            this.ShowFoldersToggleButton.Size = new System.Drawing.Size(23, 22);
            this.ShowFoldersToggleButton.ToolTipText = "Toggle folders";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ShowDesignerButton
            // 
            this.ShowDesignerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowDesignerButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowDesignerButton.Image")));
            this.ShowDesignerButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDesignerButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowDesignerButton.Name = "ShowDesignerButton";
            this.ShowDesignerButton.Size = new System.Drawing.Size(23, 22);
            this.ShowDesignerButton.ToolTipText = "Open designer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // AddButton
            // 
            this.AddButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClassButton,
            this.AddStdModuleButton,
            this.AddFormButton,
            this.toolStripSeparator1,
            this.AddTestModuleButton});
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(44, 22);
            this.AddButton.Text = "New";
            this.AddButton.ToolTipText = "Add a component to the active project";
            // 
            // AddClassButton
            // 
            this.AddClassButton.Image = ((System.Drawing.Image)(resources.GetObject("AddClassButton.Image")));
            this.AddClassButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddClassButton.Name = "AddClassButton";
            this.AddClassButton.Size = new System.Drawing.Size(197, 22);
            this.AddClassButton.Text = "&Class module (.cls)";
            // 
            // AddStdModuleButton
            // 
            this.AddStdModuleButton.Image = ((System.Drawing.Image)(resources.GetObject("AddStdModuleButton.Image")));
            this.AddStdModuleButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddStdModuleButton.Name = "AddStdModuleButton";
            this.AddStdModuleButton.Size = new System.Drawing.Size(197, 22);
            this.AddStdModuleButton.Text = "&Standard module (.bas)";
            // 
            // AddFormButton
            // 
            this.AddFormButton.Image = ((System.Drawing.Image)(resources.GetObject("AddFormButton.Image")));
            this.AddFormButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddFormButton.Name = "AddFormButton";
            this.AddFormButton.Size = new System.Drawing.Size(197, 22);
            this.AddFormButton.Text = "User &form";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // AddTestModuleButton
            // 
            this.AddTestModuleButton.Name = "AddTestModuleButton";
            this.AddTestModuleButton.Size = new System.Drawing.Size(197, 22);
            this.AddTestModuleButton.Text = "&Test module";
            // 
            // DisplayModeButton
            // 
            this.DisplayModeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DisplayModeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DisplayMemberNamesButton,
            this.DisplaySignaturesButton});
            this.DisplayModeButton.Image = ((System.Drawing.Image)(resources.GetObject("DisplayModeButton.Image")));
            this.DisplayModeButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DisplayModeButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DisplayModeButton.Name = "DisplayModeButton";
            this.DisplayModeButton.Size = new System.Drawing.Size(29, 22);
            this.DisplayModeButton.Text = "toolStripSplitButton1";
            this.DisplayModeButton.ToolTipText = "Display style";
            // 
            // DisplayMemberNamesButton
            // 
            this.DisplayMemberNamesButton.Checked = true;
            this.DisplayMemberNamesButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DisplayMemberNamesButton.Image = ((System.Drawing.Image)(resources.GetObject("DisplayMemberNamesButton.Image")));
            this.DisplayMemberNamesButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DisplayMemberNamesButton.Name = "DisplayMemberNamesButton";
            this.DisplayMemberNamesButton.Size = new System.Drawing.Size(198, 22);
            this.DisplayMemberNamesButton.Text = "Display member &names";
            // 
            // DisplaySignaturesButton
            // 
            this.DisplaySignaturesButton.Image = ((System.Drawing.Image)(resources.GetObject("DisplaySignaturesButton.Image")));
            this.DisplaySignaturesButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DisplaySignaturesButton.ImageTransparentColor = System.Drawing.Color.White;
            this.DisplaySignaturesButton.Name = "DisplaySignaturesButton";
            this.DisplaySignaturesButton.Size = new System.Drawing.Size(198, 22);
            this.DisplaySignaturesButton.Text = "Display full &signatures";
            // 
            // SelectedNodeLabel
            // 
            this.SelectedNodeLabel.Enabled = false;
            this.SelectedNodeLabel.Name = "SelectedNodeLabel";
            this.SelectedNodeLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SolutionTree);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 343);
            this.panel1.TabIndex = 1;
            // 
            // SolutionTree
            // 
            this.SolutionTree.ContextMenuStrip = this.CodeExplorerContextMenu;
            this.SolutionTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolutionTree.Location = new System.Drawing.Point(0, 0);
            this.SolutionTree.Name = "SolutionTree";
            this.SolutionTree.Size = new System.Drawing.Size(280, 343);
            this.SolutionTree.TabIndex = 0;
            // 
            // CodeExplorerContextMenu
            // 
            this.CodeExplorerContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CodeExplorerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshContextButton,
            this.newToolStripMenuItem,
            this.toolStripSeparator4,
            this.NavigateContextButton,
            this.FindAllReferencesContextButton,
            this.FindAllImplementationsContextButton,
            this.RenameContextButton,
            this.ShowDesignerContextButton,
            this.toolStripSeparator5,
            this.InspectContextButton,
            this.RunAllTestsContextButton});
            this.CodeExplorerContextMenu.Name = "CodeExplorerContextMenu";
            this.CodeExplorerContextMenu.Size = new System.Drawing.Size(215, 214);
            // 
            // RefreshContextButton
            // 
            this.RefreshContextButton.Image = global::Rubberduck.Properties.Resources.arrow_circle_double;
            this.RefreshContextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshContextButton.Name = "RefreshContextButton";
            this.RefreshContextButton.Size = new System.Drawing.Size(214, 22);
            this.RefreshContextButton.Text = "Refresh";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClassContextButton,
            this.AddStdModuleContextButton,
            this.AddFormContextButton,
            this.toolStripSeparator6,
            this.AddTestModuleContextButton});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // AddClassContextButton
            // 
            this.AddClassContextButton.Image = ((System.Drawing.Image)(resources.GetObject("AddClassContextButton.Image")));
            this.AddClassContextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddClassContextButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.AddClassContextButton.Name = "AddClassContextButton";
            this.AddClassContextButton.Size = new System.Drawing.Size(165, 22);
            this.AddClassContextButton.Text = "&Class module";
            // 
            // AddStdModuleContextButton
            // 
            this.AddStdModuleContextButton.Image = ((System.Drawing.Image)(resources.GetObject("AddStdModuleContextButton.Image")));
            this.AddStdModuleContextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddStdModuleContextButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.AddStdModuleContextButton.Name = "AddStdModuleContextButton";
            this.AddStdModuleContextButton.Size = new System.Drawing.Size(165, 22);
            this.AddStdModuleContextButton.Text = "Standard &module";
            // 
            // AddFormContextButton
            // 
            this.AddFormContextButton.Image = ((System.Drawing.Image)(resources.GetObject("AddFormContextButton.Image")));
            this.AddFormContextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddFormContextButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.AddFormContextButton.Name = "AddFormContextButton";
            this.AddFormContextButton.Size = new System.Drawing.Size(165, 22);
            this.AddFormContextButton.Text = "User &form";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(162, 6);
            // 
            // AddTestModuleContextButton
            // 
            this.AddTestModuleContextButton.Name = "AddTestModuleContextButton";
            this.AddTestModuleContextButton.Size = new System.Drawing.Size(165, 22);
            this.AddTestModuleContextButton.Text = "&Test module";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(211, 6);
            // 
            // NavigateContextButton
            // 
            this.NavigateContextButton.Name = "NavigateContextButton";
            this.NavigateContextButton.Size = new System.Drawing.Size(214, 22);
            this.NavigateContextButton.Text = "Navi&gate";
            // 
            // FindAllReferencesContextButton
            // 
            this.FindAllReferencesContextButton.Name = "FindAllReferencesContextButton";
            this.FindAllReferencesContextButton.Size = new System.Drawing.Size(214, 22);
            this.FindAllReferencesContextButton.Text = "&Find all references...";
            // 
            // FindAllImplementationsContextButton
            // 
            this.FindAllImplementationsContextButton.Name = "FindAllImplementationsContextButton";
            this.FindAllImplementationsContextButton.Size = new System.Drawing.Size(214, 22);
            this.FindAllImplementationsContextButton.Text = "Find all &implementations...";
            // 
            // RenameContextButton
            // 
            this.RenameContextButton.Name = "RenameContextButton";
            this.RenameContextButton.Size = new System.Drawing.Size(214, 22);
            this.RenameContextButton.Text = "Re&name";
            // 
            // ShowDesignerContextButton
            // 
            this.ShowDesignerContextButton.Enabled = false;
            this.ShowDesignerContextButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowDesignerContextButton.Image")));
            this.ShowDesignerContextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ShowDesignerContextButton.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ShowDesignerContextButton.Name = "ShowDesignerContextButton";
            this.ShowDesignerContextButton.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.ShowDesignerContextButton.Size = new System.Drawing.Size(214, 22);
            this.ShowDesignerContextButton.Text = "Show &designer";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(211, 6);
            // 
            // InspectContextButton
            // 
            this.InspectContextButton.Image = global::Rubberduck.Properties.Resources.light_bulb_code;
            this.InspectContextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.InspectContextButton.Name = "InspectContextButton";
            this.InspectContextButton.Size = new System.Drawing.Size(214, 22);
            this.InspectContextButton.Text = "&Inspect";
            // 
            // RunAllTestsContextButton
            // 
            this.RunAllTestsContextButton.Name = "RunAllTestsContextButton";
            this.RunAllTestsContextButton.Size = new System.Drawing.Size(214, 22);
            this.RunAllTestsContextButton.Text = "&Run all tests";
            // 
            // TreeNodeIcons
            // 
            this.TreeNodeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TreeNodeIcons.ImageStream")));
            this.TreeNodeIcons.TransparentColor = System.Drawing.Color.Fuchsia;
            this.TreeNodeIcons.Images.SetKeyName(0, "ClosedFolder");
            this.TreeNodeIcons.Images.SetKeyName(1, "OpenFolder");
            this.TreeNodeIcons.Images.SetKeyName(2, "Form");
            this.TreeNodeIcons.Images.SetKeyName(3, "ClassModule");
            this.TreeNodeIcons.Images.SetKeyName(4, "PrivateClass");
            this.TreeNodeIcons.Images.SetKeyName(5, "Option");
            this.TreeNodeIcons.Images.SetKeyName(6, "Implements");
            this.TreeNodeIcons.Images.SetKeyName(7, "StandardModule");
            this.TreeNodeIcons.Images.SetKeyName(8, "PrivateModule");
            this.TreeNodeIcons.Images.SetKeyName(9, "PublicField");
            this.TreeNodeIcons.Images.SetKeyName(10, "PrivateField");
            this.TreeNodeIcons.Images.SetKeyName(11, "FriendField");
            this.TreeNodeIcons.Images.SetKeyName(12, "PublicMethod");
            this.TreeNodeIcons.Images.SetKeyName(13, "FriendMethod");
            this.TreeNodeIcons.Images.SetKeyName(14, "PrivateMethod");
            this.TreeNodeIcons.Images.SetKeyName(15, "TestMethod");
            this.TreeNodeIcons.Images.SetKeyName(16, "PublicProperty");
            this.TreeNodeIcons.Images.SetKeyName(17, "FriendProperty");
            this.TreeNodeIcons.Images.SetKeyName(18, "PrivateProperty");
            this.TreeNodeIcons.Images.SetKeyName(19, "PublicConst");
            this.TreeNodeIcons.Images.SetKeyName(20, "FriendConst");
            this.TreeNodeIcons.Images.SetKeyName(21, "PrivateConst");
            this.TreeNodeIcons.Images.SetKeyName(22, "PublicEnum");
            this.TreeNodeIcons.Images.SetKeyName(23, "FriendEnum");
            this.TreeNodeIcons.Images.SetKeyName(24, "PrivateEnum");
            this.TreeNodeIcons.Images.SetKeyName(25, "EnumItem");
            this.TreeNodeIcons.Images.SetKeyName(26, "PublicEvent");
            this.TreeNodeIcons.Images.SetKeyName(27, "FriendEvent");
            this.TreeNodeIcons.Images.SetKeyName(28, "PrivateEvent");
            this.TreeNodeIcons.Images.SetKeyName(29, "PublicType");
            this.TreeNodeIcons.Images.SetKeyName(30, "FriendType");
            this.TreeNodeIcons.Images.SetKeyName(31, "PrivateType");
            this.TreeNodeIcons.Images.SetKeyName(32, "Operation");
            this.TreeNodeIcons.Images.SetKeyName(33, "CodeBlock");
            this.TreeNodeIcons.Images.SetKeyName(34, "Identifier");
            this.TreeNodeIcons.Images.SetKeyName(35, "Parameter");
            this.TreeNodeIcons.Images.SetKeyName(36, "Assignment");
            this.TreeNodeIcons.Images.SetKeyName(37, "PublicInterface");
            this.TreeNodeIcons.Images.SetKeyName(38, "PrivateInterface");
            this.TreeNodeIcons.Images.SetKeyName(39, "Label");
            this.TreeNodeIcons.Images.SetKeyName(40, "Hourglass");
            this.TreeNodeIcons.Images.SetKeyName(41, "Locked");
            this.TreeNodeIcons.Images.SetKeyName(42, "OfficeDocument");
            // 
            // CodeExplorerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CodeExplorerToolbar);
            this.Name = "CodeExplorerWindow";
            this.Size = new System.Drawing.Size(280, 368);
            this.CodeExplorerToolbar.ResumeLayout(false);
            this.CodeExplorerToolbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.CodeExplorerContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip CodeExplorerToolbar;
        private Panel panel1;
        private ToolStripButton RefreshButton;
        public TreeView SolutionTree;
        private ImageList TreeNodeIcons;
        private ToolStripButton ShowFoldersToggleButton;
        public ToolStripButton ShowDesignerButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripDropDownButton AddButton;
        private ToolStripMenuItem AddClassButton;
        private ToolStripMenuItem AddStdModuleButton;
        private ToolStripMenuItem AddFormButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem AddTestModuleButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton DisplayModeButton;
        private ToolStripMenuItem DisplayMemberNamesButton;
        private ToolStripMenuItem DisplaySignaturesButton;
        private ContextMenuStrip CodeExplorerContextMenu;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem NavigateContextButton;
        private ToolStripMenuItem ShowDesignerContextButton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem RunAllTestsContextButton;
        private ToolStripLabel SelectedNodeLabel;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem AddClassContextButton;
        private ToolStripMenuItem AddStdModuleContextButton;
        private ToolStripMenuItem AddFormContextButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem AddTestModuleContextButton;
        private ToolStripMenuItem RefreshContextButton;
        private ToolStripMenuItem InspectContextButton;
        private ToolStripMenuItem RenameContextButton;
        private ToolStripMenuItem FindAllReferencesContextButton;
        private ToolStripMenuItem FindAllImplementationsContextButton;
    }
}
