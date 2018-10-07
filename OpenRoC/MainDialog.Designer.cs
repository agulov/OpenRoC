﻿namespace oroc
{
    partial class MainDialog
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
                DisposeAddedComponents();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDialog));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip = new System.Windows.Forms.ToolStrip();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.SettingsButton = new System.Windows.Forms.ToolStripButton();
            this.LogsButton = new System.Windows.Forms.ToolStripButton();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.ProcessListView = new System.Windows.Forms.ListView();
            this.Process = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightClickContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContextMenuAddButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuEditButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuDeleteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuDisableButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MainDialogUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.TaskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TaskbarContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TaskbarContextMenuToggleViewButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskbarContextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.TaskbarContextMenuExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MetricsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SensuInterfaceUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.StatusStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.RightClickContextMenuStrip.SuspendLayout();
            this.TaskbarContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetricsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.StatusStrip.Location = new System.Drawing.Point(0, 466);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip.Size = new System.Drawing.Size(665, 25);
            this.StatusStrip.TabIndex = 0;
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(46, 20);
            this.StatusText.Text = "ready";
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddButton,
            this.DeleteButton,
            this.SettingsButton,
            this.LogsButton,
            this.AboutButton});
            this.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(665, 27);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "toolStrip1";
            // 
            // AddButton
            // 
            this.AddButton.AutoToolTip = false;
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(41, 24);
            this.AddButton.Text = "Add";
            this.AddButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoToolTip = false;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(57, 24);
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.OnContextMenuDeleteButtonClick);
            // 
            // SettingsButton
            // 
            this.SettingsButton.AutoToolTip = false;
            this.SettingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(66, 24);
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.OnSettingsButtonClick);
            // 
            // LogsButton
            // 
            this.LogsButton.AutoToolTip = false;
            this.LogsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LogsButton.Image = ((System.Drawing.Image)(resources.GetObject("LogsButton.Image")));
            this.LogsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LogsButton.Name = "LogsButton";
            this.LogsButton.Size = new System.Drawing.Size(44, 24);
            this.LogsButton.Text = "Logs";
            this.LogsButton.Click += new System.EventHandler(this.OnLogButtonClick);
            // 
            // AboutButton
            // 
            this.AboutButton.AutoToolTip = false;
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(54, 24);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.OnAboutButtonClick);
            // 
            // ProcessListView
            // 
            this.ProcessListView.AllowDrop = true;
            this.ProcessListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessListView.CheckBoxes = true;
            this.ProcessListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Process,
            this.Status});
            this.ProcessListView.ContextMenuStrip = this.RightClickContextMenuStrip;
            this.ProcessListView.FullRowSelect = true;
            this.ProcessListView.GridLines = true;
            this.ProcessListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ProcessListView.Location = new System.Drawing.Point(0, 27);
            this.ProcessListView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessListView.Name = "ProcessListView";
            this.ProcessListView.ShowGroups = false;
            this.ProcessListView.Size = new System.Drawing.Size(664, 282);
            this.ProcessListView.TabIndex = 2;
            this.ProcessListView.UseCompatibleStateImageBehavior = false;
            this.ProcessListView.View = System.Windows.Forms.View.Details;
            this.ProcessListView.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnProcessListViewItemCheck);
            this.ProcessListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.OnProcessListViewItemChecked);
            this.ProcessListView.SizeChanged += new System.EventHandler(this.OnProcessListViewResize);
            this.ProcessListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnProcessListViewDragDrop);
            this.ProcessListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnProcessListViewDragEnter);
            this.ProcessListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnContextMenuEditButtonClick);
            this.ProcessListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnProcessListViewMouseDown);
            this.ProcessListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnProcessListViewMouseUp);
            // 
            // Process
            // 
            this.Process.Text = "Process";
            this.Process.Width = 320;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 175;
            // 
            // RightClickContextMenuStrip
            // 
            this.RightClickContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RightClickContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuAddButton,
            this.ContextMenuEditButton,
            this.ContextMenuSeparator1,
            this.ContextMenuDeleteButton,
            this.ContextMenuDisableButton,
            this.ContextMenuSeparator2,
            this.ContextMenuStart,
            this.ContextMenuStop,
            this.ContextMenuShow});
            this.RightClickContextMenuStrip.Name = "ContextMenuStrip";
            this.RightClickContextMenuStrip.ShowImageMargin = false;
            this.RightClickContextMenuStrip.Size = new System.Drawing.Size(165, 184);
            // 
            // ContextMenuAddButton
            // 
            this.ContextMenuAddButton.Name = "ContextMenuAddButton";
            this.ContextMenuAddButton.Size = new System.Drawing.Size(164, 24);
            this.ContextMenuAddButton.Text = "Add";
            this.ContextMenuAddButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // ContextMenuEditButton
            // 
            this.ContextMenuEditButton.Name = "ContextMenuEditButton";
            this.ContextMenuEditButton.Size = new System.Drawing.Size(164, 24);
            this.ContextMenuEditButton.Text = "Edit";
            this.ContextMenuEditButton.Click += new System.EventHandler(this.OnContextMenuEditButtonClick);
            // 
            // ContextMenuSeparator1
            // 
            this.ContextMenuSeparator1.Name = "ContextMenuSeparator1";
            this.ContextMenuSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // ContextMenuDeleteButton
            // 
            this.ContextMenuDeleteButton.Name = "ContextMenuDeleteButton";
            this.ContextMenuDeleteButton.Size = new System.Drawing.Size(164, 24);
            this.ContextMenuDeleteButton.Text = "Delete";
            this.ContextMenuDeleteButton.Click += new System.EventHandler(this.OnContextMenuDeleteButtonClick);
            // 
            // ContextMenuDisableButton
            // 
            this.ContextMenuDisableButton.Name = "ContextMenuDisableButton";
            this.ContextMenuDisableButton.Size = new System.Drawing.Size(164, 24);
            this.ContextMenuDisableButton.Text = "Disable";
            this.ContextMenuDisableButton.Click += new System.EventHandler(this.OnContextMenuDisableButtonClick);
            // 
            // ContextMenuSeparator2
            // 
            this.ContextMenuSeparator2.Name = "ContextMenuSeparator2";
            this.ContextMenuSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // ContextMenuStart
            // 
            this.ContextMenuStart.Name = "ContextMenuStart";
            this.ContextMenuStart.Size = new System.Drawing.Size(164, 24);
            this.ContextMenuStart.Text = "Start Process(es)";
            this.ContextMenuStart.Click += new System.EventHandler(this.OnContextMenuStartClick);
            // 
            // ContextMenuStop
            // 
            this.ContextMenuStop.Name = "ContextMenuStop";
            this.ContextMenuStop.Size = new System.Drawing.Size(164, 24);
            this.ContextMenuStop.Text = "Stop Process(es)";
            this.ContextMenuStop.Click += new System.EventHandler(this.OnContextMenuStopClick);
            // 
            // ContextMenuShow
            // 
            this.ContextMenuShow.Name = "ContextMenuShow";
            this.ContextMenuShow.Size = new System.Drawing.Size(164, 24);
            this.ContextMenuShow.Text = "Show Window(s)";
            this.ContextMenuShow.Click += new System.EventHandler(this.OnContextMenuShowClick);
            // 
            // MainDialogUpdateTimer
            // 
            this.MainDialogUpdateTimer.Enabled = true;
            this.MainDialogUpdateTimer.Tick += new System.EventHandler(this.OnMainDialogUpdateTimerTick);
            // 
            // TaskbarIcon
            // 
            this.TaskbarIcon.ContextMenuStrip = this.TaskbarContextMenuStrip;
            this.TaskbarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TaskbarIcon.Icon")));
            this.TaskbarIcon.Text = "OpenRoc";
            this.TaskbarIcon.Visible = true;
            this.TaskbarIcon.Click += new System.EventHandler(this.OnTaskbarContextMenuToggleViewButtonClick);
            // 
            // TaskbarContextMenuStrip
            // 
            this.TaskbarContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TaskbarContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TaskbarContextMenuToggleViewButton,
            this.TaskbarContextMenuSeparator,
            this.TaskbarContextMenuExitButton});
            this.TaskbarContextMenuStrip.Name = "TaskbarContextMenuStrip";
            this.TaskbarContextMenuStrip.ShowImageMargin = false;
            this.TaskbarContextMenuStrip.Size = new System.Drawing.Size(129, 58);
            // 
            // TaskbarContextMenuToggleViewButton
            // 
            this.TaskbarContextMenuToggleViewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskbarContextMenuToggleViewButton.Name = "TaskbarContextMenuToggleViewButton";
            this.TaskbarContextMenuToggleViewButton.Size = new System.Drawing.Size(128, 24);
            this.TaskbarContextMenuToggleViewButton.Text = "Show/Hide";
            this.TaskbarContextMenuToggleViewButton.Click += new System.EventHandler(this.OnTaskbarContextMenuToggleViewButtonClick);
            // 
            // TaskbarContextMenuSeparator
            // 
            this.TaskbarContextMenuSeparator.Name = "TaskbarContextMenuSeparator";
            this.TaskbarContextMenuSeparator.Size = new System.Drawing.Size(125, 6);
            // 
            // TaskbarContextMenuExitButton
            // 
            this.TaskbarContextMenuExitButton.Name = "TaskbarContextMenuExitButton";
            this.TaskbarContextMenuExitButton.Size = new System.Drawing.Size(128, 24);
            this.TaskbarContextMenuExitButton.Text = "Exit";
            this.TaskbarContextMenuExitButton.Click += new System.EventHandler(this.OnTaskbarContextMenuExitButtonClick);
            // 
            // MetricsChart
            // 
            this.MetricsChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricsChart.BorderlineWidth = 0;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.Snow;
            chartArea1.BorderColor = System.Drawing.Color.DarkGray;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 100F;
            chartArea1.InnerPlotPosition.Width = 100F;
            chartArea1.Name = "metricsChartArea";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.MetricsChart.ChartAreas.Add(chartArea1);
            legend1.DockedToChartArea = "metricsChartArea";
            legend1.IsTextAutoFit = false;
            legend1.Name = "metricsLegend";
            this.MetricsChart.Legends.Add(legend1);
            this.MetricsChart.Location = new System.Drawing.Point(0, 309);
            this.MetricsChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MetricsChart.Name = "MetricsChart";
            this.MetricsChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.MetricsChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.DarkSeaGreen};
            series1.BorderWidth = 2;
            series1.ChartArea = "metricsChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.IsXValueIndexed = true;
            series1.Legend = "metricsLegend";
            series1.LegendText = "% cpu usage";
            series1.Name = "CpuChart";
            series2.BorderWidth = 2;
            series2.ChartArea = "metricsChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.IsXValueIndexed = true;
            series2.Legend = "metricsLegend";
            series2.LegendText = "% ram usage";
            series2.Name = "RamChart";
            series3.BorderWidth = 2;
            series3.ChartArea = "metricsChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.IsXValueIndexed = true;
            series3.Legend = "metricsLegend";
            series3.LegendText = "% gpu usage";
            series3.Name = "GpuChart";
            this.MetricsChart.Series.Add(series1);
            this.MetricsChart.Series.Add(series2);
            this.MetricsChart.Series.Add(series3);
            this.MetricsChart.Size = new System.Drawing.Size(665, 155);
            this.MetricsChart.TabIndex = 0;
            this.MetricsChart.TabStop = false;
            this.MetricsChart.Text = "Machine Metrics";
            // 
            // MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(665, 491);
            this.Controls.Add(this.MetricsChart);
            this.Controls.Add(this.ProcessListView);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.StatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainDialog";
            this.Text = "OpenRoC";
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.RightClickContextMenuStrip.ResumeLayout(false);
            this.TaskbarContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetricsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
        private System.Windows.Forms.ToolStrip MenuStrip;
        private System.Windows.Forms.ListView ProcessListView;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton DeleteButton;
        private System.Windows.Forms.ToolStripButton SettingsButton;
        private System.Windows.Forms.ToolStripButton LogsButton;
        private System.Windows.Forms.ToolStripButton AboutButton;
        private System.Windows.Forms.ColumnHeader Process;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ContextMenuStrip RightClickContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuAddButton;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDeleteButton;
        private System.Windows.Forms.ToolStripSeparator ContextMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuEditButton;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuDisableButton;
        private System.Windows.Forms.Timer MainDialogUpdateTimer;
        private System.Windows.Forms.ToolStripSeparator ContextMenuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStart;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuStop;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuShow;
        private System.Windows.Forms.NotifyIcon TaskbarIcon;
        private System.Windows.Forms.ContextMenuStrip TaskbarContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TaskbarContextMenuToggleViewButton;
        private System.Windows.Forms.ToolStripSeparator TaskbarContextMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem TaskbarContextMenuExitButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart MetricsChart;
        private System.Windows.Forms.Timer SensuInterfaceUpdateTimer;
    }
}

