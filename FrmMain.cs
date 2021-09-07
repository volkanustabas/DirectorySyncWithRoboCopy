using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DirectorySyncWithRoboCopy
{
    public partial class Form1 : Form
    {
        private readonly string _logPath = AppDomain.CurrentDomain.BaseDirectory + @"\Log";
        private string _code;
        private string _destPath;
        private string _srcPath;


        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Directory.CreateDirectory(_logPath);
            pb_loading.Visible = false;
        }

        private void btn_browse_sourceDirectory_Click(object sender, EventArgs e)
        {
            var browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                _srcPath = browser.SelectedPath;
                lbl_info_sourceDirectory.Text = _srcPath;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_destinationDirectory.Text != "")
                lb_destinationDirectory.Items.Add(tb_destinationDirectory.Text);
            else
                MessageBox.Show(@"Destination not null!", @"Info");
        }

        private void btn_sync_Click(object sender, EventArgs e)
        {
            if (lb_destinationDirectory.Items.Count > 0)
            {
                bw_sync.RunWorkerAsync();
                btn_browse_sourceDirectory.Enabled = false;
                tb_destinationDirectory.Enabled = false;
                btn_add.Enabled = false;
                lb_destinationDirectory.Enabled = false;
                btn_sync.Enabled = false;
            }
            else
            {
                MessageBox.Show(@"Nothing!", @"Info");
            }
        }

        private void bw_sync_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke((MethodInvoker) delegate { pb_loading.Visible = true; });

            foreach (var lbItem in lb_destinationDirectory.Items)
            {
                _destPath = lbItem.ToString();

                _code = @"robocopy " + _srcPath + @" " + _destPath + @" /e /copy:DAT /PURGE /mt /z /LOG:" +
                        _logPath +
                        @"\_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".log";

                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = "cmd.exe", Arguments = "/C " + _code, WindowStyle = ProcessWindowStyle.Hidden
                    }
                };
                process.Start();
                process.WaitForExit();
            }
        }

        private void bw_sync_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pb_loading.Visible = false;
            btn_browse_sourceDirectory.Enabled = true;
            tb_destinationDirectory.Enabled = true;
            btn_add.Enabled = true;
            lb_destinationDirectory.Enabled = true;
            btn_sync.Enabled = true;
            MessageBox.Show(@"Sync Completed", @"Info");
        }
    }
}