using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

namespace Coursework_Kostin
{
    public partial class formUSB : Form
    {
        public string id = "";
        List<USBDeviceInfo> listDevices;
        static List<USBDeviceInfo> GetUSBDevices()
        {
            List<USBDeviceInfo> devices = new List<USBDeviceInfo>();

            ManagementObjectCollection collection;
            using (var searcher = new ManagementObjectSearcher(@"Select * From Win32_USBHub"))
                collection = searcher.Get();

            foreach (var device in collection)
            {
                devices.Add(new USBDeviceInfo(
                (string)device.GetPropertyValue("DeviceID"),
                (string)device.GetPropertyValue("PNPDeviceID"),
                (string)device.GetPropertyValue("Description")
                ));
            }

            collection.Dispose();
            return devices;
        }

        public formUSB()
        {
            InitializeComponent();
            listDevices = GetUSBDevices();
            for (int i = 0; i < listDevices.Count; i++)
            {
                listView1.Items.Add(listDevices[i].DeviceID);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                id = listDevices[listView1.SelectedIndices[0]].DeviceID;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Choose USB device!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
