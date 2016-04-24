using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraBarcodeWF
{
    public partial class ResultPanel : UserControl
    {
        public ResultPanel()
        {
            InitializeComponent();

        }

        private void SetState(ScanResult result)
        {
            switch (result)
            {
                case ScanResult.Default:
                    imageGreenCheck.Visible = false;
                    imageRedX.Visible = false;
                    break;
                case ScanResult.Accept:
                    imageGreenCheck.Visible = true;
                    imageRedX.Visible = false;
                    break;
                case ScanResult.Deny:
                    imageGreenCheck.Visible = false;
                    imageRedX.Visible = true;
                    break;
                default:
                    break;
            }
        }

        public ScanResult result
        {
            set { SetState(value); }
        }

        public enum ScanResult
        {
            Default,
            Accept,
            Deny
        }
    }
}
