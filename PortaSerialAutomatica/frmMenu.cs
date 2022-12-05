using Microsoft.Win32;
using System.Management;

namespace PortaSerialAutomatica
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnObterPorta_Click(object sender, EventArgs e)
        {
            // Open the subkey of HKLM (i.e., HARDWARE\DEVICEMAP\SERIALCOMM)
            var subkey = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DEVICEMAP\SERIALCOMM");

            // Get the value of \Device\gertec_usbcdc_AcmSerial0
            var value = subkey.GetValue(@"\Device\gertec_usbcdc_AcmSerial0");

            // I print the value "COM4" here, but you can use it however you need
            if (value != null)
                lblPortaCom.Text = value.ToString();
            else
                lblPortaCom.Text = "Pinpad não Conectado";
        }
    }
}
      