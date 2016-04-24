using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebEye;
using ZXing;

namespace CameraBarcodeWF
{

    public partial class Scanner : UserControl
    {
        public Scanner()
        {
            InitializeComponent();
            StartCamera();
            StartScanner();
        }

        private void StartCamera()
        {
            List<WebCameraId> cameras = new List<WebCameraId>(webCameraControl1.GetVideoCaptureDevices());
            cboCameras.Items.AddRange(cameras.Select(c => c.Name).ToArray());
            webCameraControl1.StartCapture(cameras[1]);
        }

        private async void StartScanner()
        {
            Progress<Result> progress = new Progress<Result>();
            progress.ProgressChanged += (progressSender, nextItem) => { ProcessScanResult(nextItem); };

            await Task.Run(() => ReadBarcode(progress));
        }

        public void ReadBarcode(IProgress<Result> progress)
        {
            IBarcodeReader reader = new BarcodeReader();

            while (true)
            {
                try
                {
                    using (Bitmap barcodeBitmap = webCameraControl1.GetCurrentImage())
                    {
                        Result result = reader.Decode(barcodeBitmap);

                        if (result != null)
                        {
                            progress.Report(result);
                        }
                    }
                }
                catch 
                {
                    // This is the simplified version of a cancellation token for the form close.
                    break;
                }
            }
        }

        private void ProcessScanResult(Result result)
        {
            // We already know that result is not going to be null.
            if(result.Text.Trim().ToLower() == "code 39")
            {
                resultPanel1.Visible = true;
                laserBar.Visible = false;
                resultPanel1.result = ResultPanel.ScanResult.Accept;
            }
            else
            {
                resultPanel1.Visible = true;
                laserBar.Visible = false;
                resultPanel1.result = ResultPanel.ScanResult.Deny;
            }

            webCameraControl1.Visible = false;
            txtName.Text = "New Result";
            txtBadgeID.Text = result.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            resultPanel1.Visible = false;
            webCameraControl1.Visible = true;
            laserBar.Visible = true;
            txtBadgeID.Text = string.Empty;
            txtName.Text = string.Empty;
        }

    }
}
