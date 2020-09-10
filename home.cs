using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using IWshRuntimeLibrary;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guild_X.DiscordRpcDemo;
using Microsoft.Win32;

namespace Guild_X
{
    public partial class home : Form
    {

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        public home()
        {
            InitializeComponent();
            CreateShortcut();
        }

        private void CreateShortcut()
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut((string)shell.SpecialFolders.Item(ref shDesktop) + @"\Guild X.lnk");
            shortcut.TargetPath = AppDomain.CurrentDomain.BaseDirectory + @"\Guild X.exe";
            shortcut.Save();
        }

        private void home_Load(object sender, EventArgs e)
        {

            browser.Navigate("https://guild-x.glitch.me/");
            //browser.Navigate("https://google.com/");
            time.Text = DateTime.Now.ToString();


            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("753679484397289473", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("753679484397289473", ref this.handlers, true, null);
            this.presence.details = "Coded by ItzPLAYZ";
            this.presence.state = "https://github.com/itzplayz0001";
            this.presence.largeImageKey = "oraandrrfuad";
            this.presence.smallImageKey = "";
            this.presence.largeImageText = "Guild X";
            DiscordRpc.UpdatePresence(ref this.presence);

            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("Guild X", Application.ExecutablePath.ToString());

        }

        private void browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            string msg = e.Url.ToString() + "Is Loading..";
            Console.WriteLine(msg);
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/itzplayz0001");
        }

        private void manualStartup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://guild-x.glitch.me/");
        }

        private void console_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
