﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Droid.Infra.UI
{
    public partial class GitHubLogger : UserControl
    {
        #region Attribute
        private GitHubAdapter _gha;
        #endregion

        #region Properties
        public GitHubAdapter GitHubAdapter
        {
            get { return _gha; }
            set { _gha = value; }
        }
        #endregion

        #region Constructor
        public GitHubLogger()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods private
        private void Init()
        {
            textBoxLogin.Text = Environment.UserName;
            textBoxUrl.Text = "https://github.com";
        }
        private void Log()
        {
            if (_gha != null)
            {
                _gha.ConnectionFailled += _gha_ConnectionFailled;
                _gha.LogUser(textBoxLogin.Text, maskedTextBoxPWD.Text);
                _gha.ConnectionFailled -= _gha_ConnectionFailled;
            }
        }
        private void ChangeStatus(bool faillure)
        {
            if (faillure)
            {
                if (textBoxUrl.Width > 410)
                {
                    for (int i = textBoxUrl.Width; i > 410; i--)
                    {
                        textBoxUrl.Width = i;
                    }
                }
                labelConnectionFailled.Visible = true;
            }
            else
            {
                labelConnectionFailled.Visible = false;

                if (textBoxUrl.Width < 523)
                {
                    for (int i = textBoxUrl.Width; i < 523; i++)
                    {
                        textBoxUrl.Width = i;
                    }
                }
            }
        }
        #endregion

        #region Event
        private void buttonAutheticate_Click(object sender, EventArgs e)
        {
            ChangeStatus(false);
            Log();
        }
        private void _gha_ConnectionFailled()
        {
            ChangeStatus(true);
        }
        #endregion
    }
}