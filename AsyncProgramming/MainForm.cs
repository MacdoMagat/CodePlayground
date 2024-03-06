using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncProgramming
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;
        public MainForm()
        {
            InitializeComponent();
        }

        private async void btnStartProcess_Click(object sender, EventArgs e)
        {
            btnStartProcess.Enabled = false;
            pbrProgress.Value = 0;

            var progressText = new Progress<string>(details =>
            {
                txtTextArea.Text = details + System.Environment.NewLine;
                txtTextArea.SelectionStart = txtTextArea.Text.Length;
                txtTextArea.SelectionLength = 0;
            });
            var progress = new Progress<int>();
            progress.ProgressChanged += Progress_ProgressChanged;

            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;

            cancellationToken.Register(() => txtTextArea.Text += "Cancelled");

            string message = await DoLongProcess(progress, progressText, cancellationToken);
            cancellationTokenSource = null;
            MessageBox.Show(message);
            btnStartProcess.Enabled = true;
        }

        private async Task<string> DoLongProcess(IProgress<int> progress, IProgress<string> progressText, CancellationToken cancellationToken)
        {
            var itemsProcessed = await Task.Run(() =>
            {
                int x = 0;
                for (int i = 1; i <= 100; i++)
                {
                    if (cancellationToken.IsCancellationRequested) { break; }
                    Thread.Sleep(100);
                    progress.Report(i);
                    progressText.Report(i.ToString());
                    x++;
                }
                return x;
            });
            return $"Done processing {itemsProcessed} items.";
        }

        private void Progress_ProgressChanged(object sender, int percent)
        {
            pbrProgress.Value = percent;
        }

        private void btnCancelProcess_Click(object sender, EventArgs e)
        {
            if(cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                cancellationTokenSource = null;
            }
        }
    }
}
