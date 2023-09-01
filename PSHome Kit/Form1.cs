/**********************************************
 *         Program by Tustin                  *
 *         Written for PsHomeCentral          *
 *                                            *
 *                                            *
 *                                            *
 * ****************************************** */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS3Lib;

namespace PSHome_Kit
{
    public partial class Form1 : Form
    {
        
        CCAPI CCAPI = new CCAPI();
        int API;
        uint address = 0;
        public Form1()
        {
            InitializeComponent();
        }
        uint GetAddress()
        {
           if (API == 1)
           {
               byte[] pointer = PS3.GetMemory(0x104F7320, new byte[4]);
               Array.Reverse(pointer);
               address = BitConverter.ToUInt32(pointer, 0);
               return address;
           }
            if (API == 2)
            {
                byte[] pointer = CCAPI.GetBytes(0x104F7320, 4);
                Array.Reverse(pointer);
                address = BitConverter.ToUInt32(pointer, 0);
                return address;
            }
            return address;
        }
        string GetName()
        {
            if (API == 1)
            {
                byte[] getname = PS3.GetMemory(GetAddress() + 0x1488, new byte[10]);
                string name = Encoding.UTF8.GetString(getname);
                return name;
            }
            else if (API == 2)
            {
                byte[] getname = CCAPI.GetBytes(GetAddress() + 0x1488, 10);
                string name = Encoding.UTF8.GetString(getname);
                return name;
            }
            return "Error getting name";
        }
        void ActivateButtons(bool active)
        {
            admin.Enabled = active;
            wallhack.Enabled = active;
            console.Enabled = active;
            action.Enabled = active;
            namebox.Enabled = active;
            sendname.Enabled = active;
            channel.Enabled = active;
            size.Enabled = active;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nsTheme1_Click(object sender, EventArgs e)
        {

        }

        private void nsRadioButton2_CheckedChanged(object sender)
        {
            ipbox.Visible = true;
        }

        private void nsButton1_Click(object sender, EventArgs e)
        {
            if (ccapibutton.Checked)
            {
                try
                {
                    API = 2;
                    CCAPI.ConnectTarget(ipbox.Text);
                    CCAPI.AttachProcess();
                    GetAddress();
                    GetName();
                    namebox.Text = GetName();
                    ActivateButtons(true);
                    CCAPI.Notify(1, "Established connection to " +ipbox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to connect/attach!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tmapi.Checked)
            {
                try
                {
                    API = 1;
                    PS3.ConnectAttach();
                    GetAddress();
                    GetName();
                    namebox.Text = GetName();
                    ActivateButtons(true);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to connect/attach!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void wallhack_CheckedChanged(object sender)
        {
            if (API == 1)
            {
                if (wallhack.Checked)
                {
                    PS3.SetMemory(address + 0x1A8C, new byte[] { 0x00, 0x00, 0x00, 0x02 });
                }
                else
                {
                    PS3.SetMemory(address + 0x1A8C, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                }
            }
            else if (API == 2)
            {
                if (wallhack.Checked)
                {
                    CCAPI.SetMemory(address + 0x1A8C, new byte[] { 0x00, 0x00, 0x00, 0x02 });
                }
                else
                {
                    CCAPI.SetMemory(address + 0x1A8C, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                }
            }
        }

        private void nsButton1_Click_1(object sender, EventArgs e)
        {
            if (API == 1)
            {
                byte[] name = Encoding.ASCII.GetBytes(namebox.Text + "\0");
                PS3.SetMemory(address + 0x1488, name);
            }
            else if (API == 2)
            {
                byte[] name = Encoding.ASCII.GetBytes(namebox.Text + "\0");
                CCAPI.SetMemory(address + 0x1488, name);
            }
        }

        private void nsCheckBox1_CheckedChanged(object sender)
        {
            if (API == 1)
            {
                if (console.Checked)
                {
                    PS3.SetMemory(0x50A7DEEC, new byte[] { 0x10, 0x00, 0x00, 0x00 });
                }
                else
                {
                    PS3.SetMemory(0x50A7DEEC, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                }
            }
            else if (API == 2)
            {
                if (console.Checked)
                {
                    CCAPI.SetMemory(0x50A7DEEC, new byte[] { 0x10, 0x00, 0x00, 0x00 });
                }
                else
                {
                    CCAPI.SetMemory(0x50A7DEEC, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                }
            }
        }

        private void nsCheckBox1_CheckedChanged_1(object sender)
        {
          if (API == 1)
            {
                if (admin.Checked)
                {
                    PS3.SetMemory(0x104F7438, new byte[] { 0x00, 0x00, 0x00, 0x01 });
                }
                else
                {
                    PS3.SetMemory(0x104F7438, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                }
            }
          else if (API == 2)
          {
              if (admin.Checked)
              {
                  CCAPI.SetMemory(0x104F7438, new byte[] { 0x00, 0x00, 0x00, 0x01 });
              }
              else
              {
                  CCAPI.SetMemory(0x104F7438, new byte[] { 0x00, 0x00, 0x00, 0x00 });
              }
          }
        }

        private void nsCheckBox1_CheckedChanged_2(object sender)
        {
            if (API == 1)
            {
                if (action.Checked)
                {
                    PS3.SetMemory(0x1005A6E8, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
                else
                {
                    PS3.SetMemory(0x1005A6E8, new byte[] { 0x40, 0x40, 0x00, 0x00, 0x40, 0x40, 0x00, 0x00 });
                }
            }
            else if (API == 2)
            {
                if (action.Checked)
                {
                    CCAPI.SetMemory(0x1005A6E8, new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                }
                else
                {
                    CCAPI.SetMemory(0x1005A6E8, new byte[] { 0x40, 0x40, 0x00, 0x00, 0x40, 0x40, 0x00, 0x00 });
                }
            }
        }

        private void tmapi_CheckedChanged(object sender)
        {
            ipbox.Visible = false;
        }

        private void ccapibutton_CheckedChanged(object sender)
        {
            ipbox.Visible = true;
        }

        private void nsGroupBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nsCheckBox1_CheckedChanged_3(object sender)
        {
            if (API == 1)
            {
                if (channel.Checked)
                {
                    PS3.SetMemory(0x10636240, new byte[] { 0x01, 0x00, 0x00, 0x00 });
                }
                else
                {
                    PS3.SetMemory(0x10636240, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                }
            }
            else if (API == 2)
            {
                if (channel.Checked)
                {
                    CCAPI.SetMemory(0x10636240, new byte[] { 0x01, 0x00, 0x00, 0x00 });
                }
                else
                {
                    CCAPI.SetMemory(0x10636240, new byte[] { 0x00, 0x00, 0x00, 0x00 });
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            about about = new about();
            about.Show();
        }

        private void nsComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (API == 1)
            {
                if (size.SelectedIndex == 0)
                {
                    PS3.SetMemory(address + 0x1AF8, new byte[] { 0x3f, 0x80, 0x00, 0x00 });
                }
                if (size.SelectedIndex == 1)
                {
                    PS3.SetMemory(address + 0x1AF8, new byte[] { 0x41, 0x20, 0x00, 0x00 });
                }
                if (size.SelectedIndex == 2)
                {
                    PS3.SetMemory(address + 0x1AF8, new byte[] { 0x41, 0xa0, 0x00, 0x00 });
                }
                if (size.SelectedIndex == 3)
                {
                    PS3.SetMemory(address + 0x1AF8, new byte[] { 0x42, 0x48, 0x00, 0x00 });
                }
                if (size.SelectedIndex == 4)
                {
                    PS3.SetMemory(address + 0x1AF8, new byte[] { 0x42, 0xc8, 0x00, 0x00 });
                }
                else if (API == 2)
                {
                    if (size.SelectedIndex == 0)
                    {
                        CCAPI.SetMemory(address + 0x1AF8, new byte[] { 0x3f, 0x80, 0x00, 0x00 });
                    }
                    if (size.SelectedIndex == 1)
                    {
                        CCAPI.SetMemory(address + 0x1AF8, new byte[] { 0x41, 0x20, 0x00, 0x00 });
                    }
                    if (size.SelectedIndex == 2)
                    {
                        CCAPI.SetMemory(address + 0x1AF8, new byte[] { 0x41, 0xa0, 0x00, 0x00 });
                    }
                    if (size.SelectedIndex == 3)
                    {
                        CCAPI.SetMemory(address + 0x1AF8, new byte[] { 0x42, 0x48, 0x00, 0x00 });
                    }
                    if (size.SelectedIndex == 4)
                    {
                        CCAPI.SetMemory(address + 0x1AF8, new byte[] { 0x42, 0xc8, 0x00, 0x00 });
                    }
                }
            }
        }

        private void nsTrackBar1_Scroll(object sender)
        {
            if (API == 1)
            {
                if (chat.Value == 0)
                {
                    PS3.SetMemory(0x100BA304, new byte[] { 0x05 });
                }
                if (chat.Value == 1)
                {
                    PS3.SetMemory(0x100BA304, new byte[] { 0x04 });
                }
                if (chat.Value == 2)
                {
                    PS3.SetMemory(0x100BA304, new byte[] { 0x03 });
                }
            }
            else if (API == 2)
            {
                if (chat.Value == 0)
                {
                    CCAPI.SetMemory(0x100BA304, new byte[] { 0x05 });
                }
                if (chat.Value == 1)
                {
                    CCAPI.SetMemory(0x100BA304, new byte[] { 0x04 });
                }
                if (chat.Value == 2)
                {
                    CCAPI.SetMemory(0x100BA304, new byte[] { 0x03 });
                }
            }
        }
    }
}
