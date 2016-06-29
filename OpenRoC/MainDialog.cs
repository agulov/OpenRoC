﻿namespace oroc
{
    using System.IO;
    using System.Windows.Forms;

    public partial class MainDialog : Form
    {
        private ProcessDialog EditProcessForm;
        private ProcessDialog AddProcessForm;
        private SettingsDialog SettingsForm;
        private AboutDialog AboutForm;
        private LogsDialog LogsForm;
        private Settings Settings;

        public readonly ProcessManager ProcessManager;

        public MainDialog()
        {
            InitializeComponent();

            Settings = new Settings();

            ProcessManager = Settings.Read<ProcessManager>("ProcessManager");
            ProcessManager.Setup();

            ProcessListView.SetDoubleBuffered(true);

            ProcessManager.OnProcessAdded += fn => { UpdateSettings(); };
            ProcessManager.OnProcessEdited += fn => { UpdateSettings(); };
            ProcessManager.OnProcessDeleted += fn => { UpdateSettings(); };
        }

        private void UpdateSettings()
        {
            Settings.Write("ProcessManager", ProcessManager);
            Settings.Save();
        }

        private void DisposeAddedComponents()
        {
            if (ProcessManager != null)
                ProcessManager.Dispose();

            if (EditProcessForm != null)
                EditProcessForm.Dispose();

            if (AddProcessForm != null)
                AddProcessForm.Dispose();

            if (SettingsForm != null)
                SettingsForm.Dispose();

            if (AboutForm != null)
                AboutForm.Dispose();

            if (LogsForm != null)
                LogsForm.Dispose();
        }

        private void OnProcessListViewResize(object sender, System.EventArgs e)
        {
            if (ProcessListView.Columns.Count > 0)
                ProcessListView.AutoResizeColumn(
                    ProcessListView.Columns.Count - 1,
                    ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void HandleDialogRequest<T>(ref T host)
            where T : Form, new()
        {
            if (host == null || host.IsDisposed)
            {
                host = new T();
                host.Owner = this;
            }

            if (!host.Visible)
                host.Show();
            else
                host.Focus();
        }

        public void UpdateProcessList()
        {
            foreach (ListViewItem item in ProcessListView.Items)
                if (!ProcessManager.Contains(item.Text))
                    item.Remove();

            ProcessManager.ProcessList.ForEach(p =>
            {
                if (ProcessListView.Items.ContainsKey(p.ProcessOptions.Path))
                {
                    ProcessListView.Items[p.ProcessOptions.Path].Checked = p.State != ProcessRunner.Status.Disabled;
                    ProcessListView.Items[p.ProcessOptions.Path].SubItems[1].Text = p.GetStatusString();
                }
                else
                {
                    ListViewItem item = new ListViewItem();

                    item.Checked = p.State != ProcessRunner.Status.Disabled;
                    item.Text = p.ProcessOptions.Path;
                    item.Name = p.ProcessOptions.Path;
                    item.SubItems.Add(p.State.ToString());

                    ProcessListView.Items.Add(item);
                }
            });
        }

        private void OnSettingsButtonClick(object sender, System.EventArgs e)
        {
            HandleDialogRequest(ref SettingsForm);
        }

        private void OnAddButtonClick(object sender, System.EventArgs e)
        {
            HandleDialogRequest(ref AddProcessForm);
        }

        private void OnAboutButtonClick(object sender, System.EventArgs e)
        {
            HandleDialogRequest(ref AboutForm);
        }

        private void OnLogButtonClick(object sender, System.EventArgs e)
        {
            HandleDialogRequest(ref LogsForm);
        }

        private void OnContextMenuEditButtonClick(object sender, System.EventArgs e)
        {
            if (ProcessListView.FocusedItem == null)
                return;

            if (!ProcessManager.Contains(ProcessListView.FocusedItem.Text))
                return;

            ProcessRunner process = ProcessManager.Get(ProcessListView.FocusedItem.Text);

            if (EditProcessForm == null || EditProcessForm.IsDisposed)
            {
                EditProcessForm = new ProcessDialog(process.ProcessOptions.Clone() as ProcessOptions);
                EditProcessForm.Owner = this;
            }

            if (!EditProcessForm.Visible)
                EditProcessForm.Show();
            else
                EditProcessForm.Focus();
        }

        private void OnContextMenuDeleteButtonClick(object sender, System.EventArgs e)
        {
            if (ProcessListView.FocusedItem == null)
                return;

            ProcessManager.Delete(ProcessListView.FocusedItem.Text);
            UpdateProcessList();
        }

        private void OnDeleteButtonClick(object sender, System.EventArgs e)
        {
            foreach (ListViewItem item in ProcessListView.SelectedItems)
                ProcessManager.Delete(item.Text);

            UpdateProcessList();
        }

        private void OnContextMenuDisableButtonClick(object sender, System.EventArgs e)
        {
            if (ProcessListView.FocusedItem == null)
                return;

            ProcessManager.Get(ProcessListView.FocusedItem.Text).State = ProcessRunner.Status.Disabled;
        }

        private void OnProcessListViewItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!ProcessListView.Items.ContainsKey(e.Item.Text))
                return;

            if (e.Item.Checked)
                ProcessManager.Get(e.Item.Text).RestoreState();
            else
                ProcessManager.Get(e.Item.Text).State = ProcessRunner.Status.Disabled;
        }

        private void OnProcessListViewDragDrop(object sender, DragEventArgs e)
        {
            string[] dragged_files = e.Data.GetData(DataFormats.FileDrop, false) as string[];

            if (dragged_files == null)
                return;

            foreach(string dragged_file in dragged_files)
            {
                if (dragged_file.IsExecutable() &&
                    !ProcessManager.Contains(dragged_file))
                {
                    ProcessOptions opts = new ProcessOptions();

                    opts.Path = dragged_file;
                    opts.WorkingDirectory = Path.GetDirectoryName(opts.Path);

                    ProcessManager.Add(opts);
                }
            }

            UpdateProcessList();
        }

        private void OnProcessListViewDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void OnMainDialogUpdateTimerTick(object sender, System.EventArgs e)
        {
            ProcessManager.ProcessList.ForEach(p => p.Monitor());
            UpdateProcessList();
        }

        private void OnContextMenuShowClick(object sender, System.EventArgs e)
        {
            if (ProcessListView.FocusedItem == null)
                return;

            ProcessManager.Get(ProcessListView.FocusedItem.Text)
                .BringToFront(ProcessRunner.FocusMode.Normal);
        }

        private void OnContextMenuStopClick(object sender, System.EventArgs e)
        {
            if (ProcessListView.FocusedItem == null)
                return;

            ProcessManager.Get(ProcessListView.FocusedItem.Text).Stop();
        }

        private void OnContextMenuStartClick(object sender, System.EventArgs e)
        {
            if (ProcessListView.FocusedItem == null)
                return;

            ProcessRunner process = ProcessManager.Get(ProcessListView.FocusedItem.Text);

            if (process.State != ProcessRunner.Status.Running)
                process.Start();
        }
    }
}
