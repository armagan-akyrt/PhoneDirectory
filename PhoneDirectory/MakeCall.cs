using System;
using System.Windows.Forms;
using System.Runtime.InteropServices; 

namespace PhoneDirectory
{
    public partial class MakeCall : Form
    {
        public MakeCall()
        {
            InitializeComponent();
        }

        [DllImport("Tapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern long tapiRequestMakeCall(string DestAddress, string AppName, string CalledParty, string Comment);

        private void btnCall_Click(object sender, EventArgs e)
        {
            long result = tapiRequestMakeCall("+905323379170", null, null, null);

            if (result <= 0)
            {
                // Handle error
            }
            else
            {
                // Call succeeded
            }
        }
    }
}
