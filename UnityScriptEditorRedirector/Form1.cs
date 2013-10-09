using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnityScriptEditorRedirector
{
    public partial class Form1 : Form
    {
        private Config config;

        public Form1()
        {
            InitializeComponent();
            config = API.LoadConfigFromRegistry();
            PushConfig(config);
        }

        private void PushConfig(Config c)
        {
            ScriptEditorCommandTextBox.Text           = c.scriptEditorCommand;
            ScriptEditorArgumentsFilenameTextBox.Text = c.scriptEditorArgumentsFilename;
            ScriptEditorArgumentsLineTextBox.Text     = c.scriptEditorArgumentsLine;
        }

        private void PullConfig(Config c)
        {
            c.scriptEditorCommand           = ScriptEditorCommandTextBox.Text;
            c.scriptEditorArgumentsFilename = ScriptEditorArgumentsFilenameTextBox.Text;
            c.scriptEditorArgumentsLine     = ScriptEditorArgumentsLineTextBox.Text;
        }

        private bool IsChanged(Config c)
        {
            if (c.scriptEditorCommand != ScriptEditorCommandTextBox.Text
                || c.scriptEditorArgumentsFilename != ScriptEditorArgumentsFilenameTextBox.Text
                || c.scriptEditorArgumentsLine != ScriptEditorArgumentsLineTextBox.Text)
            {
                return true;
            }
            return false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (!IsChanged(config))
            {
                return;
            }

            string caption = Properties.Resources.SaveConfirm_Caption;
            string message = Properties.Resources.SaveConfirm_Message;
            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                PullConfig(config);
                API.SaveConfigToRegistry(config);
            }
        }

        private void SaveConfigButton_Click(object sender, EventArgs e)
        {
            PullConfig(config);
            API.SaveConfigToRegistry(config);
        }

        private void DeleteConfigButton_Click(object sender, EventArgs e)
        {
            string caption = Properties.Resources.DeleteConfirm_Caption;
            string message = Properties.Resources.DeleteConfirm_Message;
            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                API.DeleteConfigFromRegistry();

                // ■ 注意
                // 削除後は一切動作を行わせないため、
                // すぐにアプリケーションを終了する
                string deletedCaption = Properties.Resources.Deleted_Caption;
                string deletedMessage = Properties.Resources.Deleted_Message;
                MessageBox.Show(deletedMessage, deletedCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            PullConfig(config);
            API.SaveConfigToRegistry(config);
            string solution = OpenTestSolutionTextBox.Text;
            string filename = OpenTestFilenameTextBox.Text;
            string line     = OpenTestLineTextBox.Text;
            API.OpenScriptEditor(solution, filename, line);
        }

        private void ScriptEditorCommandTextBoxOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.FileName = "";
            //ofd.InitialDirectory = @"C:\";
            ofd.Filter = Properties.Resources.SelectEditor_Filter;
            ofd.FilterIndex = 1;
            ofd.Title = Properties.Resources.SelectEditor_Title;
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ScriptEditorCommandTextBox.Text = ofd.FileName;
            }
        }

        private void OpenTestSolutionTextBoxOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.FileName = "";
            //ofd.InitialDirectory = @"C:\";
            ofd.Filter = Properties.Resources.SelectTestSolution_Filter;
            ofd.FilterIndex = 1;
            ofd.Title = Properties.Resources.SelectTestSolution_Title;
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenTestSolutionTextBox.Text = ofd.FileName;
            }
        }

        private void OpenTestFilenameTextBoxOpenButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.FileName = "";
            //ofd.InitialDirectory = @"C:\";
            ofd.Filter = Properties.Resources.SelectTestFilename_Filter;
            ofd.FilterIndex = 1;
            ofd.Title = Properties.Resources.SelectTestFilename_Title;
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenTestFilenameTextBox.Text = ofd.FileName;
            }
        }


        public const string PRESETS_GVIM_COMMAND            = @"gvim.exe";
        public const string PRESETS_GVIM_ARGUMENTS_FILENAME = @"--remote-tab-silent ""{filename}""";
        public const string PRESETS_GVIM_ARGUMENTS_LINE     = @"--remote-tab-silent +{line} ""{filename}""";
        private void PresetsGvim_Click(object sender, EventArgs e)
        {
            if (ScriptEditorCommandTextBox.Text == "")
            {
                ScriptEditorCommandTextBox.Text = PRESETS_GVIM_COMMAND;
            }
            ScriptEditorArgumentsFilenameTextBox.Text = PRESETS_GVIM_ARGUMENTS_FILENAME;
            ScriptEditorArgumentsLineTextBox.Text     = PRESETS_GVIM_ARGUMENTS_LINE;
        }

        public const string PRESETS_MONODEVELOP_COMMAND = @"MonoDevelop.exe";
        public const string PRESETS_MONODEVELOP_ARGUMENTS_FILENAME = @"--nologo ""{solution}"" ""{filename}""";
        public const string PRESETS_MONODEVELOP_ARGUMENTS_LINE = @"--nologo ""{solution}"" ""{filename};{line}""";
        private void PresetsMonoDevelop_Click_1(object sender, EventArgs e)
        {
            if (ScriptEditorCommandTextBox.Text == "")
            {
                ScriptEditorCommandTextBox.Text = PRESETS_MONODEVELOP_COMMAND;
            }
            ScriptEditorArgumentsFilenameTextBox.Text = PRESETS_MONODEVELOP_ARGUMENTS_FILENAME;
            ScriptEditorArgumentsLineTextBox.Text = PRESETS_MONODEVELOP_ARGUMENTS_LINE;
        }
    }
}
