﻿namespace oroc
{
    partial class ProcessDialog
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
                DisposeAddedComponents();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcessDialog));
            this.MonitorThisProcessGroup = new System.Windows.Forms.GroupBox();
            this.SelectWorkingDirectory = new System.Windows.Forms.Button();
            this.SelectExecutablePath = new System.Windows.Forms.Button();
            this.ProcessWorkingDirectoryLabel = new System.Windows.Forms.Label();
            this.ProcessExecutablePathLabel = new System.Windows.Forms.Label();
            this.ProcessOptionWorkingDirectoryControl = new System.Windows.Forms.TextBox();
            this.ProcessOptionPathControl = new System.Windows.Forms.TextBox();
            this.ProcessCrashAssumptionsGroup = new System.Windows.Forms.GroupBox();
            this.PostCrashWaitEnabledLabel = new System.Windows.Forms.Label();
            this.PostCrashCheckEnabledLabel = new System.Windows.Forms.Label();
            this.ProcessOptionGracePeriodDurationControl = new System.Windows.Forms.TextBox();
            this.ProcessOptionDoubleCheckDurationControl = new System.Windows.Forms.TextBox();
            this.ProcessOptionGracePeriodEnabledControl = new System.Windows.Forms.CheckBox();
            this.ProcessOptionDoubleCheckEnabledControl = new System.Windows.Forms.CheckBox();
            this.ProcessOptionCrashedIfUnresponsiveControl = new System.Windows.Forms.CheckBox();
            this.ProcessOptionCrashedIfNotRunningControl = new System.Windows.Forms.CheckBox();
            this.ProcessPreStartGroup = new System.Windows.Forms.GroupBox();
            this.ProcessOptionPreLaunchScriptButton = new System.Windows.Forms.Button();
            this.ProcessOptionPreLaunchScriptPathControl = new System.Windows.Forms.TextBox();
            this.ProcessOptionPreLaunchScriptEnabledControl = new System.Windows.Forms.CheckBox();
            this.PostCrashGroup = new System.Windows.Forms.GroupBox();
            this.ProcessOptionAggressiveCleanupEnabledControl = new System.Windows.Forms.CheckBox();
            this.ProcessOptionPostCrashScriptButton = new System.Windows.Forms.Button();
            this.ProcessOptionPostCrashScriptPathControl = new System.Windows.Forms.TextBox();
            this.ProcessOptionPostCrashScriptEnabledControl = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartupStateDisabledControl = new System.Windows.Forms.RadioButton();
            this.StartupStateRunningControl = new System.Windows.Forms.RadioButton();
            this.StartupStateStoppedControl = new System.Windows.Forms.RadioButton();
            this.StartupStateLabel = new System.Windows.Forms.Label();
            this.ProcessOptionsCancelButton = new System.Windows.Forms.Button();
            this.ProcessOptionsSaveButton = new System.Windows.Forms.Button();
            this.EnvironmentVariableFormatLabel = new System.Windows.Forms.Label();
            this.OpenScreenshotDirectoryButton = new System.Windows.Forms.Button();
            this.ProcessOptionEnvironmentVariablesControl = new System.Windows.Forms.TextBox();
            this.ProcessOptionEnvironmentVariablesEnabledControl = new System.Windows.Forms.CheckBox();
            this.ProcessOptionCommandLineControl = new System.Windows.Forms.TextBox();
            this.ProcessOptionCommandLineEnabledControl = new System.Windows.Forms.CheckBox();
            this.ProcessOptionAlwaysOnTopEnabledControl = new System.Windows.Forms.CheckBox();
            this.ProcessOptionScreenshotEnabledControl = new System.Windows.Forms.CheckBox();
            this.MonitorThisProcessGroup.SuspendLayout();
            this.ProcessCrashAssumptionsGroup.SuspendLayout();
            this.ProcessPreStartGroup.SuspendLayout();
            this.PostCrashGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MonitorThisProcessGroup
            // 
            this.MonitorThisProcessGroup.Controls.Add(this.SelectWorkingDirectory);
            this.MonitorThisProcessGroup.Controls.Add(this.SelectExecutablePath);
            this.MonitorThisProcessGroup.Controls.Add(this.ProcessWorkingDirectoryLabel);
            this.MonitorThisProcessGroup.Controls.Add(this.ProcessExecutablePathLabel);
            this.MonitorThisProcessGroup.Controls.Add(this.ProcessOptionWorkingDirectoryControl);
            this.MonitorThisProcessGroup.Controls.Add(this.ProcessOptionPathControl);
            this.MonitorThisProcessGroup.Location = new System.Drawing.Point(16, 7);
            this.MonitorThisProcessGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonitorThisProcessGroup.Name = "MonitorThisProcessGroup";
            this.MonitorThisProcessGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MonitorThisProcessGroup.Size = new System.Drawing.Size(613, 143);
            this.MonitorThisProcessGroup.TabIndex = 0;
            this.MonitorThisProcessGroup.TabStop = false;
            this.MonitorThisProcessGroup.Text = "Monitor this process";
            // 
            // SelectWorkingDirectory
            // 
            this.SelectWorkingDirectory.Location = new System.Drawing.Point(208, 97);
            this.SelectWorkingDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectWorkingDirectory.Name = "SelectWorkingDirectory";
            this.SelectWorkingDirectory.Size = new System.Drawing.Size(197, 28);
            this.SelectWorkingDirectory.TabIndex = 5;
            this.SelectWorkingDirectory.Text = "Select Working Directory";
            this.SelectWorkingDirectory.UseVisualStyleBackColor = true;
            this.SelectWorkingDirectory.Click += new System.EventHandler(this.OnSelectWorkingDirectoryClick);
            // 
            // SelectExecutablePath
            // 
            this.SelectExecutablePath.Location = new System.Drawing.Point(416, 97);
            this.SelectExecutablePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectExecutablePath.Name = "SelectExecutablePath";
            this.SelectExecutablePath.Size = new System.Drawing.Size(187, 28);
            this.SelectExecutablePath.TabIndex = 4;
            this.SelectExecutablePath.Text = "Select Executable Path";
            this.SelectExecutablePath.UseVisualStyleBackColor = true;
            this.SelectExecutablePath.Click += new System.EventHandler(this.OnFileDialogRequested);
            // 
            // ProcessWorkingDirectoryLabel
            // 
            this.ProcessWorkingDirectoryLabel.AutoSize = true;
            this.ProcessWorkingDirectoryLabel.Location = new System.Drawing.Point(9, 65);
            this.ProcessWorkingDirectoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcessWorkingDirectoryLabel.Name = "ProcessWorkingDirectoryLabel";
            this.ProcessWorkingDirectoryLabel.Size = new System.Drawing.Size(121, 17);
            this.ProcessWorkingDirectoryLabel.TabIndex = 3;
            this.ProcessWorkingDirectoryLabel.Text = "Working Directory";
            // 
            // ProcessExecutablePathLabel
            // 
            this.ProcessExecutablePathLabel.AutoSize = true;
            this.ProcessExecutablePathLabel.Location = new System.Drawing.Point(9, 30);
            this.ProcessExecutablePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProcessExecutablePathLabel.Name = "ProcessExecutablePathLabel";
            this.ProcessExecutablePathLabel.Size = new System.Drawing.Size(110, 17);
            this.ProcessExecutablePathLabel.TabIndex = 2;
            this.ProcessExecutablePathLabel.Text = "Executable Path";
            // 
            // ProcessOptionWorkingDirectoryControl
            // 
            this.ProcessOptionWorkingDirectoryControl.Location = new System.Drawing.Point(136, 62);
            this.ProcessOptionWorkingDirectoryControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionWorkingDirectoryControl.Name = "ProcessOptionWorkingDirectoryControl";
            this.ProcessOptionWorkingDirectoryControl.Size = new System.Drawing.Size(464, 22);
            this.ProcessOptionWorkingDirectoryControl.TabIndex = 1;
            // 
            // ProcessOptionPathControl
            // 
            this.ProcessOptionPathControl.Location = new System.Drawing.Point(136, 25);
            this.ProcessOptionPathControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionPathControl.Name = "ProcessOptionPathControl";
            this.ProcessOptionPathControl.Size = new System.Drawing.Size(464, 22);
            this.ProcessOptionPathControl.TabIndex = 0;
            // 
            // ProcessCrashAssumptionsGroup
            // 
            this.ProcessCrashAssumptionsGroup.Controls.Add(this.PostCrashWaitEnabledLabel);
            this.ProcessCrashAssumptionsGroup.Controls.Add(this.PostCrashCheckEnabledLabel);
            this.ProcessCrashAssumptionsGroup.Controls.Add(this.ProcessOptionGracePeriodDurationControl);
            this.ProcessCrashAssumptionsGroup.Controls.Add(this.ProcessOptionDoubleCheckDurationControl);
            this.ProcessCrashAssumptionsGroup.Controls.Add(this.ProcessOptionGracePeriodEnabledControl);
            this.ProcessCrashAssumptionsGroup.Controls.Add(this.ProcessOptionDoubleCheckEnabledControl);
            this.ProcessCrashAssumptionsGroup.Controls.Add(this.ProcessOptionCrashedIfUnresponsiveControl);
            this.ProcessCrashAssumptionsGroup.Controls.Add(this.ProcessOptionCrashedIfNotRunningControl);
            this.ProcessCrashAssumptionsGroup.Location = new System.Drawing.Point(16, 156);
            this.ProcessCrashAssumptionsGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessCrashAssumptionsGroup.Name = "ProcessCrashAssumptionsGroup";
            this.ProcessCrashAssumptionsGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessCrashAssumptionsGroup.Size = new System.Drawing.Size(613, 155);
            this.ProcessCrashAssumptionsGroup.TabIndex = 1;
            this.ProcessCrashAssumptionsGroup.TabStop = false;
            this.ProcessCrashAssumptionsGroup.Text = "Assume process has crashed or hung when";
            // 
            // PostCrashWaitEnabledLabel
            // 
            this.PostCrashWaitEnabledLabel.AutoSize = true;
            this.PostCrashWaitEnabledLabel.Location = new System.Drawing.Point(184, 114);
            this.PostCrashWaitEnabledLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostCrashWaitEnabledLabel.Name = "PostCrashWaitEnabledLabel";
            this.PostCrashWaitEnabledLabel.Size = new System.Drawing.Size(331, 17);
            this.PostCrashWaitEnabledLabel.TabIndex = 7;
            this.PostCrashWaitEnabledLabel.Text = "seconds after a crash before attempting a relaunch";
            // 
            // PostCrashCheckEnabledLabel
            // 
            this.PostCrashCheckEnabledLabel.AutoSize = true;
            this.PostCrashCheckEnabledLabel.Location = new System.Drawing.Point(184, 86);
            this.PostCrashCheckEnabledLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostCrashCheckEnabledLabel.Name = "PostCrashCheckEnabledLabel";
            this.PostCrashCheckEnabledLabel.Size = new System.Drawing.Size(277, 17);
            this.PostCrashCheckEnabledLabel.TabIndex = 6;
            this.PostCrashCheckEnabledLabel.Text = "seconds and double check if unresponsive";
            // 
            // ProcessOptionGracePeriodDurationControl
            // 
            this.ProcessOptionGracePeriodDurationControl.Location = new System.Drawing.Point(76, 112);
            this.ProcessOptionGracePeriodDurationControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionGracePeriodDurationControl.Name = "ProcessOptionGracePeriodDurationControl";
            this.ProcessOptionGracePeriodDurationControl.Size = new System.Drawing.Size(99, 22);
            this.ProcessOptionGracePeriodDurationControl.TabIndex = 5;
            // 
            // ProcessOptionDoubleCheckDurationControl
            // 
            this.ProcessOptionDoubleCheckDurationControl.Location = new System.Drawing.Point(76, 82);
            this.ProcessOptionDoubleCheckDurationControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionDoubleCheckDurationControl.Name = "ProcessOptionDoubleCheckDurationControl";
            this.ProcessOptionDoubleCheckDurationControl.Size = new System.Drawing.Size(99, 22);
            this.ProcessOptionDoubleCheckDurationControl.TabIndex = 3;
            // 
            // ProcessOptionGracePeriodEnabledControl
            // 
            this.ProcessOptionGracePeriodEnabledControl.AutoSize = true;
            this.ProcessOptionGracePeriodEnabledControl.Location = new System.Drawing.Point(13, 113);
            this.ProcessOptionGracePeriodEnabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionGracePeriodEnabledControl.Name = "ProcessOptionGracePeriodEnabledControl";
            this.ProcessOptionGracePeriodEnabledControl.Size = new System.Drawing.Size(58, 21);
            this.ProcessOptionGracePeriodEnabledControl.TabIndex = 4;
            this.ProcessOptionGracePeriodEnabledControl.Text = "Wait";
            this.ProcessOptionGracePeriodEnabledControl.UseVisualStyleBackColor = true;
            this.ProcessOptionGracePeriodEnabledControl.CheckedChanged += new System.EventHandler(this.OnProcessOptionGracePeriodEnabledControlCheckedChanged);
            // 
            // ProcessOptionDoubleCheckEnabledControl
            // 
            this.ProcessOptionDoubleCheckEnabledControl.AutoSize = true;
            this.ProcessOptionDoubleCheckEnabledControl.Location = new System.Drawing.Point(13, 85);
            this.ProcessOptionDoubleCheckEnabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionDoubleCheckEnabledControl.Name = "ProcessOptionDoubleCheckEnabledControl";
            this.ProcessOptionDoubleCheckEnabledControl.Size = new System.Drawing.Size(58, 21);
            this.ProcessOptionDoubleCheckEnabledControl.TabIndex = 2;
            this.ProcessOptionDoubleCheckEnabledControl.Text = "Wait";
            this.ProcessOptionDoubleCheckEnabledControl.UseVisualStyleBackColor = true;
            this.ProcessOptionDoubleCheckEnabledControl.CheckedChanged += new System.EventHandler(this.OnProcessOptionDoubleCheckEnabledControlCheckedChanged);
            // 
            // ProcessOptionCrashedIfUnresponsiveControl
            // 
            this.ProcessOptionCrashedIfUnresponsiveControl.AutoSize = true;
            this.ProcessOptionCrashedIfUnresponsiveControl.Location = new System.Drawing.Point(13, 57);
            this.ProcessOptionCrashedIfUnresponsiveControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionCrashedIfUnresponsiveControl.Name = "ProcessOptionCrashedIfUnresponsiveControl";
            this.ProcessOptionCrashedIfUnresponsiveControl.Size = new System.Drawing.Size(438, 21);
            this.ProcessOptionCrashedIfUnresponsiveControl.TabIndex = 1;
            this.ProcessOptionCrashedIfUnresponsiveControl.Text = "It\'s not responding to Windows messages (unresponsive window)";
            this.ProcessOptionCrashedIfUnresponsiveControl.UseVisualStyleBackColor = true;
            // 
            // ProcessOptionCrashedIfNotRunningControl
            // 
            this.ProcessOptionCrashedIfNotRunningControl.AutoSize = true;
            this.ProcessOptionCrashedIfNotRunningControl.Location = new System.Drawing.Point(13, 28);
            this.ProcessOptionCrashedIfNotRunningControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionCrashedIfNotRunningControl.Name = "ProcessOptionCrashedIfNotRunningControl";
            this.ProcessOptionCrashedIfNotRunningControl.Size = new System.Drawing.Size(312, 21);
            this.ProcessOptionCrashedIfNotRunningControl.TabIndex = 0;
            this.ProcessOptionCrashedIfNotRunningControl.Text = "It\'s not running (e.g after a Computer restart)";
            this.ProcessOptionCrashedIfNotRunningControl.UseVisualStyleBackColor = true;
            // 
            // ProcessPreStartGroup
            // 
            this.ProcessPreStartGroup.Controls.Add(this.ProcessOptionPreLaunchScriptButton);
            this.ProcessPreStartGroup.Controls.Add(this.ProcessOptionPreLaunchScriptPathControl);
            this.ProcessPreStartGroup.Controls.Add(this.ProcessOptionPreLaunchScriptEnabledControl);
            this.ProcessPreStartGroup.Location = new System.Drawing.Point(16, 318);
            this.ProcessPreStartGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessPreStartGroup.Name = "ProcessPreStartGroup";
            this.ProcessPreStartGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessPreStartGroup.Size = new System.Drawing.Size(613, 101);
            this.ProcessPreStartGroup.TabIndex = 2;
            this.ProcessPreStartGroup.TabStop = false;
            this.ProcessPreStartGroup.Text = "Before process starts";
            // 
            // ProcessOptionPreLaunchScriptButton
            // 
            this.ProcessOptionPreLaunchScriptButton.Location = new System.Drawing.Point(556, 57);
            this.ProcessOptionPreLaunchScriptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionPreLaunchScriptButton.Name = "ProcessOptionPreLaunchScriptButton";
            this.ProcessOptionPreLaunchScriptButton.Size = new System.Drawing.Size(45, 28);
            this.ProcessOptionPreLaunchScriptButton.TabIndex = 2;
            this.ProcessOptionPreLaunchScriptButton.Text = "...";
            this.ProcessOptionPreLaunchScriptButton.UseVisualStyleBackColor = true;
            this.ProcessOptionPreLaunchScriptButton.Click += new System.EventHandler(this.OnFileDialogRequested);
            // 
            // ProcessOptionPreLaunchScriptPathControl
            // 
            this.ProcessOptionPreLaunchScriptPathControl.Location = new System.Drawing.Point(13, 58);
            this.ProcessOptionPreLaunchScriptPathControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionPreLaunchScriptPathControl.Name = "ProcessOptionPreLaunchScriptPathControl";
            this.ProcessOptionPreLaunchScriptPathControl.Size = new System.Drawing.Size(531, 22);
            this.ProcessOptionPreLaunchScriptPathControl.TabIndex = 1;
            // 
            // ProcessOptionPreLaunchScriptEnabledControl
            // 
            this.ProcessOptionPreLaunchScriptEnabledControl.AutoSize = true;
            this.ProcessOptionPreLaunchScriptEnabledControl.Location = new System.Drawing.Point(13, 28);
            this.ProcessOptionPreLaunchScriptEnabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionPreLaunchScriptEnabledControl.Name = "ProcessOptionPreLaunchScriptEnabledControl";
            this.ProcessOptionPreLaunchScriptEnabledControl.Size = new System.Drawing.Size(260, 21);
            this.ProcessOptionPreLaunchScriptEnabledControl.TabIndex = 0;
            this.ProcessOptionPreLaunchScriptEnabledControl.Text = "Execute a command (ShellExecute) :";
            this.ProcessOptionPreLaunchScriptEnabledControl.UseVisualStyleBackColor = true;
            this.ProcessOptionPreLaunchScriptEnabledControl.CheckedChanged += new System.EventHandler(this.OnProcessOptionPreLaunchScriptEnabledControlCheckedChanged);
            // 
            // PostCrashGroup
            // 
            this.PostCrashGroup.Controls.Add(this.ProcessOptionAggressiveCleanupEnabledControl);
            this.PostCrashGroup.Controls.Add(this.ProcessOptionPostCrashScriptButton);
            this.PostCrashGroup.Controls.Add(this.ProcessOptionPostCrashScriptPathControl);
            this.PostCrashGroup.Controls.Add(this.ProcessOptionPostCrashScriptEnabledControl);
            this.PostCrashGroup.Location = new System.Drawing.Point(16, 426);
            this.PostCrashGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostCrashGroup.Name = "PostCrashGroup";
            this.PostCrashGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostCrashGroup.Size = new System.Drawing.Size(613, 129);
            this.PostCrashGroup.TabIndex = 3;
            this.PostCrashGroup.TabStop = false;
            this.PostCrashGroup.Text = "After process stops (crashes or hangs)";
            // 
            // ProcessOptionAggressiveCleanupEnabledControl
            // 
            this.ProcessOptionAggressiveCleanupEnabledControl.AutoSize = true;
            this.ProcessOptionAggressiveCleanupEnabledControl.Location = new System.Drawing.Point(13, 28);
            this.ProcessOptionAggressiveCleanupEnabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionAggressiveCleanupEnabledControl.Name = "ProcessOptionAggressiveCleanupEnabledControl";
            this.ProcessOptionAggressiveCleanupEnabledControl.Size = new System.Drawing.Size(543, 21);
            this.ProcessOptionAggressiveCleanupEnabledControl.TabIndex = 0;
            this.ProcessOptionAggressiveCleanupEnabledControl.Text = "Perform an aggressive cleanup ( useful if process spawns another child process )";
            this.ProcessOptionAggressiveCleanupEnabledControl.UseVisualStyleBackColor = true;
            // 
            // ProcessOptionPostCrashScriptButton
            // 
            this.ProcessOptionPostCrashScriptButton.Location = new System.Drawing.Point(556, 85);
            this.ProcessOptionPostCrashScriptButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionPostCrashScriptButton.Name = "ProcessOptionPostCrashScriptButton";
            this.ProcessOptionPostCrashScriptButton.Size = new System.Drawing.Size(45, 28);
            this.ProcessOptionPostCrashScriptButton.TabIndex = 5;
            this.ProcessOptionPostCrashScriptButton.Text = "...";
            this.ProcessOptionPostCrashScriptButton.UseVisualStyleBackColor = true;
            this.ProcessOptionPostCrashScriptButton.Click += new System.EventHandler(this.OnFileDialogRequested);
            // 
            // ProcessOptionPostCrashScriptPathControl
            // 
            this.ProcessOptionPostCrashScriptPathControl.Location = new System.Drawing.Point(13, 86);
            this.ProcessOptionPostCrashScriptPathControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionPostCrashScriptPathControl.Name = "ProcessOptionPostCrashScriptPathControl";
            this.ProcessOptionPostCrashScriptPathControl.Size = new System.Drawing.Size(531, 22);
            this.ProcessOptionPostCrashScriptPathControl.TabIndex = 4;
            // 
            // ProcessOptionPostCrashScriptEnabledControl
            // 
            this.ProcessOptionPostCrashScriptEnabledControl.AutoSize = true;
            this.ProcessOptionPostCrashScriptEnabledControl.Location = new System.Drawing.Point(13, 57);
            this.ProcessOptionPostCrashScriptEnabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionPostCrashScriptEnabledControl.Name = "ProcessOptionPostCrashScriptEnabledControl";
            this.ProcessOptionPostCrashScriptEnabledControl.Size = new System.Drawing.Size(260, 21);
            this.ProcessOptionPostCrashScriptEnabledControl.TabIndex = 3;
            this.ProcessOptionPostCrashScriptEnabledControl.Text = "Execute a command (ShellExecute) :";
            this.ProcessOptionPostCrashScriptEnabledControl.UseVisualStyleBackColor = true;
            this.ProcessOptionPostCrashScriptEnabledControl.CheckedChanged += new System.EventHandler(this.OnProcessOptionPostCrashScriptEnabledControlCheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StartupStateDisabledControl);
            this.groupBox1.Controls.Add(this.StartupStateRunningControl);
            this.groupBox1.Controls.Add(this.StartupStateStoppedControl);
            this.groupBox1.Controls.Add(this.StartupStateLabel);
            this.groupBox1.Controls.Add(this.ProcessOptionsCancelButton);
            this.groupBox1.Controls.Add(this.ProcessOptionsSaveButton);
            this.groupBox1.Controls.Add(this.EnvironmentVariableFormatLabel);
            this.groupBox1.Controls.Add(this.OpenScreenshotDirectoryButton);
            this.groupBox1.Controls.Add(this.ProcessOptionEnvironmentVariablesControl);
            this.groupBox1.Controls.Add(this.ProcessOptionEnvironmentVariablesEnabledControl);
            this.groupBox1.Controls.Add(this.ProcessOptionCommandLineControl);
            this.groupBox1.Controls.Add(this.ProcessOptionCommandLineEnabledControl);
            this.groupBox1.Controls.Add(this.ProcessOptionAlwaysOnTopEnabledControl);
            this.groupBox1.Controls.Add(this.ProcessOptionScreenshotEnabledControl);
            this.groupBox1.Location = new System.Drawing.Point(16, 562);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(613, 299);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miscellaneous options";
            // 
            // StartupStateDisabledControl
            // 
            this.StartupStateDisabledControl.AutoSize = true;
            this.StartupStateDisabledControl.Location = new System.Drawing.Point(400, 224);
            this.StartupStateDisabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartupStateDisabledControl.Name = "StartupStateDisabledControl";
            this.StartupStateDisabledControl.Size = new System.Drawing.Size(84, 21);
            this.StartupStateDisabledControl.TabIndex = 9;
            this.StartupStateDisabledControl.Text = "Disabled";
            this.StartupStateDisabledControl.UseVisualStyleBackColor = true;
            // 
            // StartupStateRunningControl
            // 
            this.StartupStateRunningControl.AutoSize = true;
            this.StartupStateRunningControl.Location = new System.Drawing.Point(304, 224);
            this.StartupStateRunningControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartupStateRunningControl.Name = "StartupStateRunningControl";
            this.StartupStateRunningControl.Size = new System.Drawing.Size(82, 21);
            this.StartupStateRunningControl.TabIndex = 8;
            this.StartupStateRunningControl.Text = "Running";
            this.StartupStateRunningControl.UseVisualStyleBackColor = true;
            // 
            // StartupStateStoppedControl
            // 
            this.StartupStateStoppedControl.AutoSize = true;
            this.StartupStateStoppedControl.Checked = true;
            this.StartupStateStoppedControl.Location = new System.Drawing.Point(208, 224);
            this.StartupStateStoppedControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartupStateStoppedControl.Name = "StartupStateStoppedControl";
            this.StartupStateStoppedControl.Size = new System.Drawing.Size(82, 21);
            this.StartupStateStoppedControl.TabIndex = 7;
            this.StartupStateStoppedControl.TabStop = true;
            this.StartupStateStoppedControl.Text = "Stopped";
            this.StartupStateStoppedControl.UseVisualStyleBackColor = true;
            this.StartupStateStoppedControl.CheckedChanged += new System.EventHandler(this.OnStartupStateRadioGroupCheckedChanged);
            // 
            // StartupStateLabel
            // 
            this.StartupStateLabel.AutoSize = true;
            this.StartupStateLabel.Location = new System.Drawing.Point(9, 224);
            this.StartupStateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartupStateLabel.Name = "StartupStateLabel";
            this.StartupStateLabel.Size = new System.Drawing.Size(189, 17);
            this.StartupStateLabel.TabIndex = 13;
            this.StartupStateLabel.Text = "Initially add this process as : ";
            // 
            // ProcessOptionsCancelButton
            // 
            this.ProcessOptionsCancelButton.Location = new System.Drawing.Point(392, 257);
            this.ProcessOptionsCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionsCancelButton.Name = "ProcessOptionsCancelButton";
            this.ProcessOptionsCancelButton.Size = new System.Drawing.Size(100, 28);
            this.ProcessOptionsCancelButton.TabIndex = 11;
            this.ProcessOptionsCancelButton.Text = "Cancel";
            this.ProcessOptionsCancelButton.UseVisualStyleBackColor = true;
            this.ProcessOptionsCancelButton.Click += new System.EventHandler(this.OnProcessOptionsCancelButtonClick);
            // 
            // ProcessOptionsSaveButton
            // 
            this.ProcessOptionsSaveButton.Location = new System.Drawing.Point(500, 257);
            this.ProcessOptionsSaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionsSaveButton.Name = "ProcessOptionsSaveButton";
            this.ProcessOptionsSaveButton.Size = new System.Drawing.Size(100, 28);
            this.ProcessOptionsSaveButton.TabIndex = 10;
            this.ProcessOptionsSaveButton.Text = "Save";
            this.ProcessOptionsSaveButton.UseVisualStyleBackColor = true;
            this.ProcessOptionsSaveButton.Click += new System.EventHandler(this.OnProcessOptionsSaveButtonClick);
            // 
            // EnvironmentVariableFormatLabel
            // 
            this.EnvironmentVariableFormatLabel.AutoSize = true;
            this.EnvironmentVariableFormatLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnvironmentVariableFormatLabel.Location = new System.Drawing.Point(403, 116);
            this.EnvironmentVariableFormatLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnvironmentVariableFormatLabel.Name = "EnvironmentVariableFormatLabel";
            this.EnvironmentVariableFormatLabel.Size = new System.Drawing.Size(192, 17);
            this.EnvironmentVariableFormatLabel.TabIndex = 10;
            this.EnvironmentVariableFormatLabel.Text = "var1=value1;var2=value2";
            // 
            // OpenScreenshotDirectoryButton
            // 
            this.OpenScreenshotDirectoryButton.Location = new System.Drawing.Point(388, 21);
            this.OpenScreenshotDirectoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenScreenshotDirectoryButton.Name = "OpenScreenshotDirectoryButton";
            this.OpenScreenshotDirectoryButton.Size = new System.Drawing.Size(212, 28);
            this.OpenScreenshotDirectoryButton.TabIndex = 1;
            this.OpenScreenshotDirectoryButton.Text = "Open Screenshot Directory";
            this.OpenScreenshotDirectoryButton.UseVisualStyleBackColor = true;
            this.OpenScreenshotDirectoryButton.Click += new System.EventHandler(this.OnOpenScreenshotDirectoryButtonClick);
            // 
            // ProcessOptionEnvironmentVariablesControl
            // 
            this.ProcessOptionEnvironmentVariablesControl.Location = new System.Drawing.Point(13, 143);
            this.ProcessOptionEnvironmentVariablesControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionEnvironmentVariablesControl.Multiline = true;
            this.ProcessOptionEnvironmentVariablesControl.Name = "ProcessOptionEnvironmentVariablesControl";
            this.ProcessOptionEnvironmentVariablesControl.Size = new System.Drawing.Size(585, 69);
            this.ProcessOptionEnvironmentVariablesControl.TabIndex = 6;
            // 
            // ProcessOptionEnvironmentVariablesEnabledControl
            // 
            this.ProcessOptionEnvironmentVariablesEnabledControl.AutoSize = true;
            this.ProcessOptionEnvironmentVariablesEnabledControl.Location = new System.Drawing.Point(13, 113);
            this.ProcessOptionEnvironmentVariablesEnabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionEnvironmentVariablesEnabledControl.Name = "ProcessOptionEnvironmentVariablesEnabledControl";
            this.ProcessOptionEnvironmentVariablesEnabledControl.Size = new System.Drawing.Size(387, 21);
            this.ProcessOptionEnvironmentVariablesEnabledControl.TabIndex = 5;
            this.ProcessOptionEnvironmentVariablesEnabledControl.Text = "Merge listed variables with system environment variables";
            this.ProcessOptionEnvironmentVariablesEnabledControl.UseVisualStyleBackColor = true;
            this.ProcessOptionEnvironmentVariablesEnabledControl.CheckedChanged += new System.EventHandler(this.OnProcessOptionEnvironmentVariablesEnabledControlCheckedChanged);
            // 
            // ProcessOptionCommandLineControl
            // 
            this.ProcessOptionCommandLineControl.Location = new System.Drawing.Point(177, 82);
            this.ProcessOptionCommandLineControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionCommandLineControl.Name = "ProcessOptionCommandLineControl";
            this.ProcessOptionCommandLineControl.Size = new System.Drawing.Size(421, 22);
            this.ProcessOptionCommandLineControl.TabIndex = 4;
            // 
            // ProcessOptionCommandLineEnabledControl
            // 
            this.ProcessOptionCommandLineEnabledControl.AutoSize = true;
            this.ProcessOptionCommandLineEnabledControl.Location = new System.Drawing.Point(13, 85);
            this.ProcessOptionCommandLineEnabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionCommandLineEnabledControl.Name = "ProcessOptionCommandLineEnabledControl";
            this.ProcessOptionCommandLineEnabledControl.Size = new System.Drawing.Size(160, 21);
            this.ProcessOptionCommandLineEnabledControl.TabIndex = 3;
            this.ProcessOptionCommandLineEnabledControl.Text = "Pass command line :";
            this.ProcessOptionCommandLineEnabledControl.UseVisualStyleBackColor = true;
            this.ProcessOptionCommandLineEnabledControl.CheckedChanged += new System.EventHandler(this.OnProcessOptionCommandLineEnabledControlCheckedChanged);
            // 
            // ProcessOptionAlwaysOnTopEnabledControl
            // 
            this.ProcessOptionAlwaysOnTopEnabledControl.AutoSize = true;
            this.ProcessOptionAlwaysOnTopEnabledControl.Location = new System.Drawing.Point(13, 57);
            this.ProcessOptionAlwaysOnTopEnabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionAlwaysOnTopEnabledControl.Name = "ProcessOptionAlwaysOnTopEnabledControl";
            this.ProcessOptionAlwaysOnTopEnabledControl.Size = new System.Drawing.Size(586, 21);
            this.ProcessOptionAlwaysOnTopEnabledControl.TabIndex = 2;
            this.ProcessOptionAlwaysOnTopEnabledControl.Text = "Keep process always on top (experimental, conflicts with other always-on-top proc" +
    "esses)";
            this.ProcessOptionAlwaysOnTopEnabledControl.UseVisualStyleBackColor = true;
            // 
            // ProcessOptionScreenshotEnabledControl
            // 
            this.ProcessOptionScreenshotEnabledControl.AutoSize = true;
            this.ProcessOptionScreenshotEnabledControl.Location = new System.Drawing.Point(13, 28);
            this.ProcessOptionScreenshotEnabledControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessOptionScreenshotEnabledControl.Name = "ProcessOptionScreenshotEnabledControl";
            this.ProcessOptionScreenshotEnabledControl.Size = new System.Drawing.Size(329, 21);
            this.ProcessOptionScreenshotEnabledControl.TabIndex = 0;
            this.ProcessOptionScreenshotEnabledControl.Text = "Take a screenshot of the main display on crash";
            this.ProcessOptionScreenshotEnabledControl.UseVisualStyleBackColor = true;
            // 
            // ProcessDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(645, 875);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PostCrashGroup);
            this.Controls.Add(this.ProcessPreStartGroup);
            this.Controls.Add(this.ProcessCrashAssumptionsGroup);
            this.Controls.Add(this.MonitorThisProcessGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ProcessDialog";
            this.Text = "Process Options";
            this.MonitorThisProcessGroup.ResumeLayout(false);
            this.MonitorThisProcessGroup.PerformLayout();
            this.ProcessCrashAssumptionsGroup.ResumeLayout(false);
            this.ProcessCrashAssumptionsGroup.PerformLayout();
            this.ProcessPreStartGroup.ResumeLayout(false);
            this.ProcessPreStartGroup.PerformLayout();
            this.PostCrashGroup.ResumeLayout(false);
            this.PostCrashGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MonitorThisProcessGroup;
        private System.Windows.Forms.TextBox ProcessOptionPathControl;
        private System.Windows.Forms.TextBox ProcessOptionWorkingDirectoryControl;
        private System.Windows.Forms.Label ProcessExecutablePathLabel;
        private System.Windows.Forms.Label ProcessWorkingDirectoryLabel;
        private System.Windows.Forms.Button SelectExecutablePath;
        private System.Windows.Forms.Button SelectWorkingDirectory;
        private System.Windows.Forms.GroupBox ProcessCrashAssumptionsGroup;
        private System.Windows.Forms.CheckBox ProcessOptionCrashedIfNotRunningControl;
        private System.Windows.Forms.CheckBox ProcessOptionCrashedIfUnresponsiveControl;
        private System.Windows.Forms.CheckBox ProcessOptionDoubleCheckEnabledControl;
        private System.Windows.Forms.CheckBox ProcessOptionGracePeriodEnabledControl;
        private System.Windows.Forms.TextBox ProcessOptionDoubleCheckDurationControl;
        private System.Windows.Forms.TextBox ProcessOptionGracePeriodDurationControl;
        private System.Windows.Forms.GroupBox ProcessPreStartGroup;
        private System.Windows.Forms.CheckBox ProcessOptionPreLaunchScriptEnabledControl;
        private System.Windows.Forms.Button ProcessOptionPreLaunchScriptButton;
        private System.Windows.Forms.TextBox ProcessOptionPreLaunchScriptPathControl;
        private System.Windows.Forms.GroupBox PostCrashGroup;
        private System.Windows.Forms.Button ProcessOptionPostCrashScriptButton;
        private System.Windows.Forms.TextBox ProcessOptionPostCrashScriptPathControl;
        private System.Windows.Forms.CheckBox ProcessOptionPostCrashScriptEnabledControl;
        private System.Windows.Forms.CheckBox ProcessOptionAggressiveCleanupEnabledControl;
        private System.Windows.Forms.Label PostCrashCheckEnabledLabel;
        private System.Windows.Forms.Label PostCrashWaitEnabledLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ProcessOptionScreenshotEnabledControl;
        private System.Windows.Forms.CheckBox ProcessOptionAlwaysOnTopEnabledControl;
        private System.Windows.Forms.CheckBox ProcessOptionCommandLineEnabledControl;
        private System.Windows.Forms.TextBox ProcessOptionCommandLineControl;
        private System.Windows.Forms.CheckBox ProcessOptionEnvironmentVariablesEnabledControl;
        private System.Windows.Forms.TextBox ProcessOptionEnvironmentVariablesControl;
        private System.Windows.Forms.Button OpenScreenshotDirectoryButton;
        private System.Windows.Forms.Label EnvironmentVariableFormatLabel;
        private System.Windows.Forms.Button ProcessOptionsSaveButton;
        private System.Windows.Forms.Button ProcessOptionsCancelButton;
        private System.Windows.Forms.RadioButton StartupStateDisabledControl;
        private System.Windows.Forms.RadioButton StartupStateRunningControl;
        private System.Windows.Forms.RadioButton StartupStateStoppedControl;
        private System.Windows.Forms.Label StartupStateLabel;
    }
}