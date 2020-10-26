using GDSU.func;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDSU
{
    public partial class GDUSF : Form
    {
        private Functions Funcs;
        private bool mouseDown;
        private Point lastLocation;
        public GDUSF()
        {
            InitializeComponent();
        }
        private void T_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void T_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void T_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void GDUSF_Load(object sender, EventArgs e)
        {
            this.Funcs = new Functions();
            TopBarAnimation.StartColor = Color.FromArgb(94, 148, 255);
            TopBarAnimation.EndColor = Color.FromArgb(25, 25, 25);
            TopBarAnimation.Start();
        }

        private void googleWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WorkerArgs workerArgs = (WorkerArgs)e.Argument;
            string pageSource = Funcs.GetPageSource("http://www.google.com/search?num=100&q=\"" + workerArgs.query + "\"");
            try
            {
                IEnumerator enumerator = new Regex("url\\?q=(.*?)&").Matches(pageSource).GetEnumerator();
                while (enumerator.MoveNext())
                {
                    string str = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(enumerator.Current), (System.Type)null, "groups", new object[1]
                    {
            (object) 1
                    }, (string[])null, (System.Type[])null, (bool[])null), (System.Type)null, "Value", new object[0], (string[])null, (System.Type[])null, (bool[])null));
                    Console.WriteLine(str);
                    if (!str.Contains("googleusercontent") && !str.Contains("/settings/ads"))
                        AddToListBox(workerArgs.box, (object)WebUtility.HtmlDecode(str));
                }
            }
            finally
            {
            }
        }
        public void AddToListBox(ListBox g, object oo)
        {
            if (!this.InvokeRequired)
            {
                if (string.IsNullOrEmpty(Conversions.ToString(oo)))
                    return;
                g.Items.Add(RuntimeHelpers.GetObjectValue(oo));
            }
            else
                this.Invoke((Delegate)new Callback(AddToListBox), (object)g, oo);
        }
        public delegate void Callback(ListBox g, object oo);
        public class WorkerArgs
        {
            public string username;
            public string query;
            public ListBox box;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            UsernameSearchResults.Items.Clear();
            googleWorker.RunWorkerAsync(new WorkerArgs() { username = UsernameInput.Text, query = UsernameInput.Text, box = UsernameSearchResults });
        }

        private void SaveToFile_Click(object sender, EventArgs e)
        {
            string path = $"{AppDomain.CurrentDomain.BaseDirectory}\\{UsernameInput.Text}.txt";
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(path);
            foreach (var item in UsernameSearchResults.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
        }

        private void ChangeColors_Click(object sender, EventArgs e)
        {
            ColorDialog MD = new ColorDialog();
            MD.AllowFullOpen = true;
            MD.AnyColor = true;
            if (MD.ShowDialog() == DialogResult.OK)
            {
                TopBar.BackColor = MD.Color;
                Search.FillColor = MD.Color;
                SaveToFile.FillColor = MD.Color;
                ChangeColors.FillColor = MD.Color;
                TwitterLabel.ForeColor = MD.Color;
                GitHubLabel.ForeColor = MD.Color;
                ExitButton.HoverState.FillColor = MD.Color;
                TopBarAnimation.StartColor = MD.Color;
                UsernameInput.LineColor = MD.Color;
                UsernameInput.FocusedLineColor = MD.Color;
                TopBarAnimation.EndColor = Color.FromArgb(25, 25, 25);
            }
        }

        private void GitHubLabel_Click(object sender, EventArgs e) => Process.Start("https://github.com/necrophilic");
        private void TwitterLabel_Click(object sender, EventArgs e) => Process.Start("https://twitter.com/GrotesqueBodies");
        private void UsernameSearchResults_DoubleClick(object sender, EventArgs e) => Process.Start(UsernameSearchResults.SelectedItem.ToString());
    }
}