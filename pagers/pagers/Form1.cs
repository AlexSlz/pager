using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace pagers
{
    public partial class Form1 : Form
    {
        public class Letter
        {
            public string Text { get; set; }
            public string Time { get; set; }

            public Letter(string t, string time)
            {

            }
        }
        string pagerId = "";
        string notifiBar = "";
        string letterBar = "📪";
        int msgPage = 0;
        List<string> msg = new List<string>();
        WebSocket ws = new WebSocket("ws://localhost:3000");
        public Form1()
        {
            ws.OnMessage += (s, e) =>
            {
                string result = Encoding.UTF8.GetString(e.RawData);
                if (result.Contains("id:"))
                {
                    pagerId = result.Replace("id: ", "");
                }
                else
                {
                    notifiBar = "✉️";
                    letterBar = "📬";
                    msg.Add(result + $"{Environment.NewLine}{DateTime.Now.Hour}:{DateTime.Now.Minute}" +
                                     $" {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year - 2000}");
                    msgPage = msg.Count - 1;
                }
            };
            ws.Connect();
            InitializeComponent();
            if(!ws.IsAlive)
            {
                notifiBar = "error...";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void LoadInterface()
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = $"{pagerId}{Environment.NewLine}{notifiBar}{Environment.NewLine}" +
                            $"{DateTime.Now.Hour}:{DateTime.Now.Minute} {letterBar} " +
                            $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year - 2000}";
        }
        public void LoadMsg()
        {
            if (msg.Count > 0)
            {
                notifiBar = "";
                textBox1.TextAlign = HorizontalAlignment.Left;
                textBox1.Text = $"{msgPage + 1}: {msg[msgPage]}";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadInterface();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && timer1.Enabled)
            {
                timer1.Stop();
            }else if(e.KeyCode == Keys.Back && !timer1.Enabled)
            {
                timer1.Start();
            }
            else if (e.KeyCode == Keys.Left && !timer1.Enabled)
            {
                if (msgPage > 0)
                    msgPage--;
            }
            else if (e.KeyCode == Keys.Right && !timer1.Enabled)
            {
                if (msgPage < msg.Count - 1)
                    msgPage++;
            }else if(e.KeyCode == Keys.Delete && !timer1.Enabled)
            {
                if (msg.Count > 0)
                {
                    msg.RemoveAt(msgPage);
                    msgPage = msg.Count - 1;
                    if (msg.Count == 0)
                        letterBar = "📪";
                    timer1.Start();
                }
            }
            if (!timer1.Enabled)
            {
                LoadMsg();
            }
        }
    }
}
