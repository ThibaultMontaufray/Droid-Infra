﻿using System.Globalization;
using System.Windows;
using System.Windows.Forms;

namespace Droid.Infra
{
    class RTLMessageBox
    {
        private RTLMessageBox() { }

        public static DialogResult Show(IWin32Window owner, string text,
            MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton,
            MessageBoxIcon icon)
        {
            return Show(owner, text, "OpenVPN Manager", buttons, icon,
                defaultButton, (MessageBoxOptions) 0);
        }

        public static DialogResult Show(string text, MessageBoxIcon icon)
        {
            return Show(null, text, "OpenVPN Manager", MessageBoxButtons.OK, icon,
                MessageBoxDefaultButton.Button1, (MessageBoxOptions)0);
        }

        public static DialogResult Show(IWin32Window owner, string text,
            MessageBoxIcon icon)
        {
            return Show(owner, text, "OpenVPN Manager", MessageBoxButtons.OK, icon, 
                MessageBoxDefaultButton.Button1, (MessageBoxOptions) 0);
        }

        public static DialogResult Show(IWin32Window owner, string text, 
            string caption, MessageBoxButtons buttons, MessageBoxIcon icon, 
            MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
        {
            return DialogResult.OK;
            //return MessageBox.Show(owner, text, caption,
            //    buttons, icon, defaultButton, getDefaultOptions(owner) | options);
        }

        private static MessageBoxOptions getDefaultOptions(IWin32Window owner)
        {
            if (IsRightToLeft(owner))
            {
                return MessageBoxOptions.RtlReading |
                    MessageBoxOptions.RightAlign;
            } 
            else
            {
                return (MessageBoxOptions) 0;
            }
        }

        private static bool IsRightToLeft(IWin32Window owner)
        {
            Control control = owner as Control;

            if (control != null)
            {
                return control.RightToLeft == RightToLeft.Yes;
            } else
                return CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft;
        }
    }
}
