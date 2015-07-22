using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PortableKnowledge.Logging;

namespace LoggingTester
{
    public partial class formLoggingTester : Form
    {
        ListBoxLogListener listBoxListener = null;

        public formLoggingTester()
        {
            InitializeComponent();

            GlobalLog.loggingEnabled = true;
            listBoxListener = new ListBoxLogListener(GlobalLog.Instance, lstListBoxLog);
        }

        LogLevel GetLogLevelFromListBox(CheckedListBox lstBox)
        {
            LogLevel level = LogLevel.None;

            foreach (String strLevel in lstBox.CheckedItems)
                level = level | (LogLevel)Enum.Parse(typeof(LogLevel),
                                                     strLevel.Replace(" ", ""));

            return level;
        }

        private void btnCreateLogMessage_Click(object sender, EventArgs e)
        {
            LogItem item = new LogItem(this,
                                        GetLogLevelFromListBox(lstLogMessageLevel),
                                        txtLogMessage.Text);
            GlobalLog.Instance.Add(item);
        }

        private void lstListBoxListenerFilter_Leave(object sender, EventArgs e)
        {
            listBoxListener.LevelFilter = GetLogLevelFromListBox(lstListBoxListenerFilter);
        }
    }
}
