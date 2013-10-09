namespace UnityScriptEditorRedirector
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ScriptEditorCommandLabel = new System.Windows.Forms.Label();
            this.ScriptEditorArgumentsFilenameLabel = new System.Windows.Forms.Label();
            this.ScriptEditorArgumentsLineLabel = new System.Windows.Forms.Label();
            this.ScriptEditorCommandTextBox = new System.Windows.Forms.TextBox();
            this.ScriptEditorArgumentsFilenameTextBox = new System.Windows.Forms.TextBox();
            this.ScriptEditorArgumentsLineTextBox = new System.Windows.Forms.TextBox();
            this.SaveConfigButton = new System.Windows.Forms.Button();
            this.DeleteConfigButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.OpenTestGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenTestSolutionTextBoxOpenButton = new System.Windows.Forms.Button();
            this.OpenTestSolutionTextBox = new System.Windows.Forms.TextBox();
            this.OpenTestSolutionLabel = new System.Windows.Forms.Label();
            this.OpenTestFilenameTextBoxOpenButton = new System.Windows.Forms.Button();
            this.OpenTestLineTextBox = new System.Windows.Forms.TextBox();
            this.OpenTestFilenameTextBox = new System.Windows.Forms.TextBox();
            this.OpenTestLineLabel = new System.Windows.Forms.Label();
            this.OpenTestFilenameLabel = new System.Windows.Forms.Label();
            this.ScriptEditorCommandTextBoxOpenButton = new System.Windows.Forms.Button();
            this.PresetsLabel = new System.Windows.Forms.Label();
            this.PresetsGvim = new System.Windows.Forms.Button();
            this.PresetsMonoDevelop = new System.Windows.Forms.Button();
            this.OpenTestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScriptEditorCommandLabel
            // 
            resources.ApplyResources(this.ScriptEditorCommandLabel, "ScriptEditorCommandLabel");
            this.ScriptEditorCommandLabel.Name = "ScriptEditorCommandLabel";
            // 
            // ScriptEditorArgumentsFilenameLabel
            // 
            resources.ApplyResources(this.ScriptEditorArgumentsFilenameLabel, "ScriptEditorArgumentsFilenameLabel");
            this.ScriptEditorArgumentsFilenameLabel.Name = "ScriptEditorArgumentsFilenameLabel";
            // 
            // ScriptEditorArgumentsLineLabel
            // 
            resources.ApplyResources(this.ScriptEditorArgumentsLineLabel, "ScriptEditorArgumentsLineLabel");
            this.ScriptEditorArgumentsLineLabel.Name = "ScriptEditorArgumentsLineLabel";
            // 
            // ScriptEditorCommandTextBox
            // 
            resources.ApplyResources(this.ScriptEditorCommandTextBox, "ScriptEditorCommandTextBox");
            this.ScriptEditorCommandTextBox.Name = "ScriptEditorCommandTextBox";
            // 
            // ScriptEditorArgumentsFilenameTextBox
            // 
            resources.ApplyResources(this.ScriptEditorArgumentsFilenameTextBox, "ScriptEditorArgumentsFilenameTextBox");
            this.ScriptEditorArgumentsFilenameTextBox.Name = "ScriptEditorArgumentsFilenameTextBox";
            // 
            // ScriptEditorArgumentsLineTextBox
            // 
            resources.ApplyResources(this.ScriptEditorArgumentsLineTextBox, "ScriptEditorArgumentsLineTextBox");
            this.ScriptEditorArgumentsLineTextBox.Name = "ScriptEditorArgumentsLineTextBox";
            // 
            // SaveConfigButton
            // 
            resources.ApplyResources(this.SaveConfigButton, "SaveConfigButton");
            this.SaveConfigButton.Name = "SaveConfigButton";
            this.SaveConfigButton.UseVisualStyleBackColor = true;
            this.SaveConfigButton.Click += new System.EventHandler(this.SaveConfigButton_Click);
            // 
            // DeleteConfigButton
            // 
            this.DeleteConfigButton.BackColor = System.Drawing.Color.Tomato;
            resources.ApplyResources(this.DeleteConfigButton, "DeleteConfigButton");
            this.DeleteConfigButton.Name = "DeleteConfigButton";
            this.DeleteConfigButton.UseVisualStyleBackColor = false;
            this.DeleteConfigButton.Click += new System.EventHandler(this.DeleteConfigButton_Click);
            // 
            // OpenButton
            // 
            resources.ApplyResources(this.OpenButton, "OpenButton");
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // OpenTestGroupBox
            // 
            this.OpenTestGroupBox.Controls.Add(this.OpenTestSolutionTextBoxOpenButton);
            this.OpenTestGroupBox.Controls.Add(this.OpenTestSolutionTextBox);
            this.OpenTestGroupBox.Controls.Add(this.OpenTestSolutionLabel);
            this.OpenTestGroupBox.Controls.Add(this.OpenTestFilenameTextBoxOpenButton);
            this.OpenTestGroupBox.Controls.Add(this.OpenTestLineTextBox);
            this.OpenTestGroupBox.Controls.Add(this.OpenTestFilenameTextBox);
            this.OpenTestGroupBox.Controls.Add(this.OpenTestLineLabel);
            this.OpenTestGroupBox.Controls.Add(this.OpenTestFilenameLabel);
            this.OpenTestGroupBox.Controls.Add(this.OpenButton);
            resources.ApplyResources(this.OpenTestGroupBox, "OpenTestGroupBox");
            this.OpenTestGroupBox.Name = "OpenTestGroupBox";
            this.OpenTestGroupBox.TabStop = false;
            // 
            // OpenTestSolutionTextBoxOpenButton
            // 
            resources.ApplyResources(this.OpenTestSolutionTextBoxOpenButton, "OpenTestSolutionTextBoxOpenButton");
            this.OpenTestSolutionTextBoxOpenButton.Name = "OpenTestSolutionTextBoxOpenButton";
            this.OpenTestSolutionTextBoxOpenButton.UseVisualStyleBackColor = true;
            this.OpenTestSolutionTextBoxOpenButton.Click += new System.EventHandler(this.OpenTestSolutionTextBoxOpenButton_Click);
            // 
            // OpenTestSolutionTextBox
            // 
            resources.ApplyResources(this.OpenTestSolutionTextBox, "OpenTestSolutionTextBox");
            this.OpenTestSolutionTextBox.Name = "OpenTestSolutionTextBox";
            // 
            // OpenTestSolutionLabel
            // 
            resources.ApplyResources(this.OpenTestSolutionLabel, "OpenTestSolutionLabel");
            this.OpenTestSolutionLabel.Name = "OpenTestSolutionLabel";
            // 
            // OpenTestFilenameTextBoxOpenButton
            // 
            resources.ApplyResources(this.OpenTestFilenameTextBoxOpenButton, "OpenTestFilenameTextBoxOpenButton");
            this.OpenTestFilenameTextBoxOpenButton.Name = "OpenTestFilenameTextBoxOpenButton";
            this.OpenTestFilenameTextBoxOpenButton.UseVisualStyleBackColor = true;
            this.OpenTestFilenameTextBoxOpenButton.Click += new System.EventHandler(this.OpenTestFilenameTextBoxOpenButton_Click_1);
            // 
            // OpenTestLineTextBox
            // 
            resources.ApplyResources(this.OpenTestLineTextBox, "OpenTestLineTextBox");
            this.OpenTestLineTextBox.Name = "OpenTestLineTextBox";
            // 
            // OpenTestFilenameTextBox
            // 
            resources.ApplyResources(this.OpenTestFilenameTextBox, "OpenTestFilenameTextBox");
            this.OpenTestFilenameTextBox.Name = "OpenTestFilenameTextBox";
            // 
            // OpenTestLineLabel
            // 
            resources.ApplyResources(this.OpenTestLineLabel, "OpenTestLineLabel");
            this.OpenTestLineLabel.Name = "OpenTestLineLabel";
            // 
            // OpenTestFilenameLabel
            // 
            resources.ApplyResources(this.OpenTestFilenameLabel, "OpenTestFilenameLabel");
            this.OpenTestFilenameLabel.Name = "OpenTestFilenameLabel";
            // 
            // ScriptEditorCommandTextBoxOpenButton
            // 
            resources.ApplyResources(this.ScriptEditorCommandTextBoxOpenButton, "ScriptEditorCommandTextBoxOpenButton");
            this.ScriptEditorCommandTextBoxOpenButton.Name = "ScriptEditorCommandTextBoxOpenButton";
            this.ScriptEditorCommandTextBoxOpenButton.UseVisualStyleBackColor = true;
            this.ScriptEditorCommandTextBoxOpenButton.Click += new System.EventHandler(this.ScriptEditorCommandTextBoxOpenButton_Click);
            // 
            // PresetsLabel
            // 
            resources.ApplyResources(this.PresetsLabel, "PresetsLabel");
            this.PresetsLabel.Name = "PresetsLabel";
            // 
            // PresetsGvim
            // 
            this.PresetsGvim.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.PresetsGvim, "PresetsGvim");
            this.PresetsGvim.Name = "PresetsGvim";
            this.PresetsGvim.UseVisualStyleBackColor = false;
            this.PresetsGvim.Click += new System.EventHandler(this.PresetsGvim_Click);
            // 
            // PresetsMonoDevelop
            // 
            this.PresetsMonoDevelop.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.PresetsMonoDevelop, "PresetsMonoDevelop");
            this.PresetsMonoDevelop.Name = "PresetsMonoDevelop";
            this.PresetsMonoDevelop.UseVisualStyleBackColor = false;
            this.PresetsMonoDevelop.Click += new System.EventHandler(this.PresetsMonoDevelop_Click_1);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PresetsMonoDevelop);
            this.Controls.Add(this.PresetsGvim);
            this.Controls.Add(this.PresetsLabel);
            this.Controls.Add(this.ScriptEditorCommandTextBoxOpenButton);
            this.Controls.Add(this.OpenTestGroupBox);
            this.Controls.Add(this.DeleteConfigButton);
            this.Controls.Add(this.SaveConfigButton);
            this.Controls.Add(this.ScriptEditorArgumentsLineTextBox);
            this.Controls.Add(this.ScriptEditorArgumentsFilenameTextBox);
            this.Controls.Add(this.ScriptEditorCommandTextBox);
            this.Controls.Add(this.ScriptEditorArgumentsLineLabel);
            this.Controls.Add(this.ScriptEditorArgumentsFilenameLabel);
            this.Controls.Add(this.ScriptEditorCommandLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.OpenTestGroupBox.ResumeLayout(false);
            this.OpenTestGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScriptEditorCommandLabel;
        private System.Windows.Forms.Label ScriptEditorArgumentsFilenameLabel;
        private System.Windows.Forms.Label ScriptEditorArgumentsLineLabel;
        protected internal System.Windows.Forms.TextBox ScriptEditorCommandTextBox;
        protected internal System.Windows.Forms.TextBox ScriptEditorArgumentsFilenameTextBox;
        protected internal System.Windows.Forms.TextBox ScriptEditorArgumentsLineTextBox;
        private System.Windows.Forms.Button SaveConfigButton;
        private System.Windows.Forms.Button DeleteConfigButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.GroupBox OpenTestGroupBox;
        protected internal System.Windows.Forms.TextBox OpenTestFilenameTextBox;
        private System.Windows.Forms.Label OpenTestLineLabel;
        private System.Windows.Forms.Label OpenTestFilenameLabel;
        protected internal System.Windows.Forms.TextBox OpenTestLineTextBox;
        private System.Windows.Forms.Button ScriptEditorCommandTextBoxOpenButton;
        private System.Windows.Forms.Button OpenTestFilenameTextBoxOpenButton;
        private System.Windows.Forms.Button OpenTestSolutionTextBoxOpenButton;
        protected internal System.Windows.Forms.TextBox OpenTestSolutionTextBox;
        private System.Windows.Forms.Label OpenTestSolutionLabel;
        private System.Windows.Forms.Label PresetsLabel;
        private System.Windows.Forms.Button PresetsGvim;
        private System.Windows.Forms.Button PresetsMonoDevelop;
    }
}

