namespace oroc
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.StartOptionsGroup = new System.Windows.Forms.GroupBox();
            this.SingleInstanceCheckBox = new System.Windows.Forms.CheckBox();
            this.StartMinimizedCheckBox = new System.Windows.Forms.CheckBox();
            this.SensuGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SensuTTLTextBox = new System.Windows.Forms.TextBox();
            this.SensuPortTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.SensuHostTextBox = new System.Windows.Forms.TextBox();
            this.HostLabel = new System.Windows.Forms.Label();
            this.SensuInterfaceEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.StartOptionsGroup.SuspendLayout();
            this.SensuGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartOptionsGroup
            // 
            this.StartOptionsGroup.Controls.Add(this.SingleInstanceCheckBox);
            this.StartOptionsGroup.Controls.Add(this.StartMinimizedCheckBox);
            this.StartOptionsGroup.Location = new System.Drawing.Point(16, 7);
            this.StartOptionsGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartOptionsGroup.Name = "StartOptionsGroup";
            this.StartOptionsGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartOptionsGroup.Size = new System.Drawing.Size(347, 95);
            this.StartOptionsGroup.TabIndex = 0;
            this.StartOptionsGroup.TabStop = false;
            this.StartOptionsGroup.Text = "Next time on start";
            // 
            // SingleInstanceCheckBox
            // 
            this.SingleInstanceCheckBox.AutoSize = true;
            this.SingleInstanceCheckBox.Location = new System.Drawing.Point(13, 57);
            this.SingleInstanceCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SingleInstanceCheckBox.Name = "SingleInstanceCheckBox";
            this.SingleInstanceCheckBox.Size = new System.Drawing.Size(204, 21);
            this.SingleInstanceCheckBox.TabIndex = 1;
            this.SingleInstanceCheckBox.Text = "Force single-instance mode";
            this.SingleInstanceCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartMinimizedCheckBox
            // 
            this.StartMinimizedCheckBox.AutoSize = true;
            this.StartMinimizedCheckBox.Location = new System.Drawing.Point(13, 28);
            this.StartMinimizedCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartMinimizedCheckBox.Name = "StartMinimizedCheckBox";
            this.StartMinimizedCheckBox.Size = new System.Drawing.Size(192, 21);
            this.StartMinimizedCheckBox.TabIndex = 0;
            this.StartMinimizedCheckBox.Text = "Start OpenRoC minimized";
            this.StartMinimizedCheckBox.UseVisualStyleBackColor = true;
            // 
            // SensuGroup
            // 
            this.SensuGroup.Controls.Add(this.label1);
            this.SensuGroup.Controls.Add(this.SensuTTLTextBox);
            this.SensuGroup.Controls.Add(this.SensuPortTextBox);
            this.SensuGroup.Controls.Add(this.PortLabel);
            this.SensuGroup.Controls.Add(this.SensuHostTextBox);
            this.SensuGroup.Controls.Add(this.HostLabel);
            this.SensuGroup.Controls.Add(this.SensuInterfaceEnabledCheckBox);
            this.SensuGroup.Location = new System.Drawing.Point(16, 110);
            this.SensuGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SensuGroup.Name = "SensuGroup";
            this.SensuGroup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SensuGroup.Size = new System.Drawing.Size(347, 95);
            this.SensuGroup.TabIndex = 2;
            this.SensuGroup.TabStop = false;
            this.SensuGroup.Text = "Sensu interface";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "TTL :";
            // 
            // SensuTTLTextBox
            // 
            this.SensuTTLTextBox.Location = new System.Drawing.Point(273, 25);
            this.SensuTTLTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SensuTTLTextBox.Name = "SensuTTLTextBox";
            this.SensuTTLTextBox.Size = new System.Drawing.Size(59, 22);
            this.SensuTTLTextBox.TabIndex = 1;
            // 
            // SensuPortTextBox
            // 
            this.SensuPortTextBox.Location = new System.Drawing.Point(273, 54);
            this.SensuPortTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SensuPortTextBox.Name = "SensuPortTextBox";
            this.SensuPortTextBox.Size = new System.Drawing.Size(59, 22);
            this.SensuPortTextBox.TabIndex = 3;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(227, 58);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(42, 17);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Port :";
            // 
            // SensuHostTextBox
            // 
            this.SensuHostTextBox.Location = new System.Drawing.Point(56, 54);
            this.SensuHostTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SensuHostTextBox.Name = "SensuHostTextBox";
            this.SensuHostTextBox.Size = new System.Drawing.Size(163, 22);
            this.SensuHostTextBox.TabIndex = 2;
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Location = new System.Drawing.Point(9, 58);
            this.HostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(45, 17);
            this.HostLabel.TabIndex = 1;
            this.HostLabel.Text = "Host :";
            // 
            // SensuInterfaceEnabledCheckBox
            // 
            this.SensuInterfaceEnabledCheckBox.AutoSize = true;
            this.SensuInterfaceEnabledCheckBox.Location = new System.Drawing.Point(13, 28);
            this.SensuInterfaceEnabledCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SensuInterfaceEnabledCheckBox.Name = "SensuInterfaceEnabledCheckBox";
            this.SensuInterfaceEnabledCheckBox.Size = new System.Drawing.Size(185, 21);
            this.SensuInterfaceEnabledCheckBox.TabIndex = 0;
            this.SensuInterfaceEnabledCheckBox.Text = "Enable Sensu interface :";
            this.SensuInterfaceEnabledCheckBox.UseVisualStyleBackColor = true;
            this.SensuInterfaceEnabledCheckBox.CheckedChanged += new System.EventHandler(this.OnSensuInterfaceEnabledCheckBoxCheckedChanged);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(379, 218);
            this.Controls.Add(this.SensuGroup);
            this.Controls.Add(this.StartOptionsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.StartOptionsGroup.ResumeLayout(false);
            this.StartOptionsGroup.PerformLayout();
            this.SensuGroup.ResumeLayout(false);
            this.SensuGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StartOptionsGroup;
        private System.Windows.Forms.CheckBox StartMinimizedCheckBox;
        private System.Windows.Forms.CheckBox SingleInstanceCheckBox;
        private System.Windows.Forms.GroupBox SensuGroup;
        private System.Windows.Forms.CheckBox SensuInterfaceEnabledCheckBox;
        private System.Windows.Forms.TextBox SensuPortTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox SensuHostTextBox;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SensuTTLTextBox;
    }
}