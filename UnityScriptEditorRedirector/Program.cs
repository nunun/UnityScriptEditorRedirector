using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using Microsoft.Win32;

namespace UnityScriptEditorRedirector
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ■ 注意
            // 言語設定
            CultureInfo ci = CultureInfo.InstalledUICulture;
            //CultureInfo ci = new CultureInfo(""); // "" or "ja-JP" ...
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;

            if (args.Length == 0)
            {
                Application.Run(new Form1());
                return;
            }

            //string message = string.Join(", ", args);
            //MessageBox.Show(message, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string solution = args[1];
            string filepath = args[2];
            int index = filepath.LastIndexOf(';');
            string filename, line;
            if (index >= 0)
            {
                filename = filepath.Substring(0, index);
                line = filepath.Substring(index + 1);
            } else {
                filename = filepath;
                line = "";
            }

            if (API.OpenScriptEditor(solution, filename, line) == false)
            {
                Process.Start(Process.GetCurrentProcess().MainModule.FileName);
            }
        }
    }

    public class Config
    {
        public string scriptEditorCommand           = "";
        public string scriptEditorArgumentsFilename = "";
        public string scriptEditorArgumentsLine     = "";
    }

    static class API
    {
        private const string REGISTRY_KEY = @"Software\UnityScriptEditorRedirector\Config";
        private const string DELETE_KEY   = @"Software\UnityScriptEditorRedirector";

        public static Config LoadConfigFromRegistry()
        {
            Config config = new Config();
            RegistryKey regkey = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY);
            config.scriptEditorCommand           = (string)regkey.GetValue("ScriptEditorCommand", "");
            config.scriptEditorArgumentsFilename = (string)regkey.GetValue("ScriptEditorArgumentsFilename", "");
            config.scriptEditorArgumentsLine     = (string)regkey.GetValue("ScriptEditorArgumentsLine", "");
            regkey.Close();
            return config;
        }

        public static bool SaveConfigToRegistry(Config config)
        {
            try
            {
                RegistryKey regkey = Registry.CurrentUser.CreateSubKey(REGISTRY_KEY);
                regkey.SetValue("ScriptEditorCommand",           config.scriptEditorCommand);
                regkey.SetValue("ScriptEditorArgumentsFilename", config.scriptEditorArgumentsFilename);
                regkey.SetValue("ScriptEditorArgumentsLine",     config.scriptEditorArgumentsLine);
                regkey.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool DeleteConfigFromRegistry()
        {
            try
            {
                Registry.CurrentUser.DeleteSubKeyTree(DELETE_KEY);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool OpenScriptEditor(string solution, string filename, string line)
        {
            Config config = LoadConfigFromRegistry();
            string arguments;

            // 引数調整
            if (filename == null || filename == string.Empty)
            {
                arguments = "";
            }
            else if (line == null || line == string.Empty)
            {
                arguments = config.scriptEditorArgumentsFilename
                             .Replace("{solution}", solution)
                             .Replace("{filename}", filename);
            }
            else
            {
                arguments = config.scriptEditorArgumentsLine
                            .Replace("{solution}", solution)
                            .Replace("{filename}", filename)
                            .Replace("{line}", line);
            }

            // 自分自身を起動しようとした!!
            if (config.scriptEditorCommand == Process.GetCurrentProcess().MainModule.FileName)
            {
                string caption = Properties.Resources.ExecuteMySelf_Caption;
                string message = Properties.Resources.ExecuteMySelf_Message;
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // 起動してみる
            try {
                Process.Start(config.scriptEditorCommand, arguments);
            } catch (Exception e) {
                MessageBox.Show(e.ToString(), "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
