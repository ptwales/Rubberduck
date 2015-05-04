﻿using System;
using System.Windows.Forms;
using Rubberduck.Parsing.Symbols;

namespace Rubberduck.UI.Refactorings.Rename
{
    public partial class RenameDialog : Form, IRenameView
    {
        public RenameDialog()
        {
            InitializeComponent();
            OkButton.Click += OkButtonClick;
            Shown += RenameDialog_Shown;
            NewNameBox.TextChanged += NewNameBox_TextChanged;
        }

        private void NewNameBox_TextChanged(object sender, EventArgs e)
        {
            NewName = NewNameBox.Text;
        }

        private void RenameDialog_Shown(object sender, EventArgs e)
        {
            NewNameBox.SelectAll();
            NewNameBox.Focus();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            OnOkButtonClicked();
        }

        public event EventHandler CancelButtonClicked;
        public void OnCancelButtonClicked()
        {
            Hide();
        }

        public event EventHandler OkButtonClicked;
        public void OnOkButtonClicked()
        {
            var handler = OkButtonClicked;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        private Declaration _target;

        public Declaration Target
        {
            get { return _target; }
            set
            {
                _target = value;
                if (_target == null)
                {
                    return;
                }

                NewName = _target.IdentifierName;
                var declarationType = RubberduckUI.ResourceManager.GetString("DeclarationType_" + _target.DeclarationType);
                InstructionsLabel.Text = string.Format(RubberduckUI.RenameDialog_InstructionsLabelText, declarationType, _target.IdentifierName);
            }
        }

        public string NewName
        {
            get { return NewNameBox.Text; }
            set
            {
                NewNameBox.Text = value;
                ValidateNewName();
            }
        }

        private void ValidateNewName()
        {
            OkButton.Enabled = (NewName != Target.IdentifierName) 
                && !string.IsNullOrWhiteSpace(NewName)
                && !NewName.StartsWith("_"); // also invalid if it starts with a number...

            InvalidNameValidationIcon.Visible = !OkButton.Enabled;
        }
    }
}
