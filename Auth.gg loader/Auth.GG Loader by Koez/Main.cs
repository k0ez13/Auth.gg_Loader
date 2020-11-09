using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using ManualMapInjection.Injection;

namespace Auth.GG_Winform_Example
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; //bugs sometimes

            Process target = Process.GetProcessesByName("csgo").FirstOrDefault(); // csgo process check

            if (target != null) // check if csgo is open
            {
                try //try to do a function
                {
                    using (WebClient mac = new WebClient())
                    {
                        mac.Proxy = null;
                        mac.Headers.Add("agent_user", App.GrabVariable("agent_user var")); //add user-agent headers, should be Mozilla
                        byte[] injecter = mac.DownloadData(App.GrabVariable("download var")); //download the dll and save it to bytes, should be the download link
                        var injector = new ManualMapInjector(target) { AsyncInjection = true }; //initializing the injector
                        siticoneRoundedButton2.Text = $"hmodule = 0x{injector.Inject(injecter).ToInt64():x8}"; //inject the dll
                        siticoneRoundedButton2.Text = ("Success!!!");
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception happened : " + ex); //check some exceptions
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Please open CSGO"); //error open csgo
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {
            userid.Text = "ID: " + User.ID;
            username.Text = "Username: " + User.Username;
            email.Text = "Email: " + User.Email;
            hwid.Text = "HWID: " + User.HWID;
            uservariable.Text = "User Variable: " + User.UserVariable;
            userrank.Text = "Rank: " + User.Rank;
            ip.Text = "IP: " + User.IP;
            expiry.Text = "Expiry: " + User.Expiry;
            lastlogin.Text = "Last Login: " + User.LastLogin;
            registerdate.Text = "Register Date: " + User.RegisterDate;
        }

        private void email_Click(object sender, EventArgs e)
        {

        }
    }
}
