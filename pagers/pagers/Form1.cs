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
        class Pager
        {
            public string Id;
            public string notifyBar;
            public string letterBar;
            public Pager(string _id, string _notify, string _letter)
            {
                Id = _id;
                notifyBar = _notify;
                letterBar = _letter;
            }
            public string getData(string[] myIcons)
            {
                return $"{this.Id}{Environment.NewLine}{this.notifyBar}{Environment.NewLine}{this.letterBar}{Environment.NewLine}" +
                            $"{myIcons[3]}{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second} " +
                            $"{myIcons[4]}{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year - 2000}";
            }
        }
        class Letter
        {
            public int id;
            public string text;
            public string time;
            public Letter(int _id, string _text, string _time)
            {
                id = _id;
                text = _text;   
                time = _time;
            }
            public string getData()
            {
                return $"{this.text}{Environment.NewLine}{Environment.NewLine}{this.time}";
            }

        }
        int scrolli = 1;
        string pagerId = "";
        int msgPage = 0;
        List<Letter> msg = new List<Letter>();
        Pager pager;
        WebSocket ws = new WebSocket("ws://localhost:3000");

        string[] myIcons = { "✉️", "📪", "📬", "🕒", "📅" };

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
                    result = result.Replace("\\n", Environment.NewLine);
                    pager.notifyBar = myIcons[0];
                    pager.letterBar = myIcons[2];
                    msg.Add(new Letter(msg.Count, result, $"{DateTime.Now.Hour}:{DateTime.Now.Minute}" +
                                                          $" {DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year - 2000}"));
                    msgPage = msg.Count - 1;
                }
            };
            ws.Connect();
            InitializeComponent();
            pager = new Pager(pagerId, "", myIcons[1]);
            if (!ws.IsAlive)
            {
                pager.notifyBar = "error...";
            }
            watchButton.Click += (s,e) =>
            {
                if(msg.Count > 0)
                    timer1.Enabled = !timer1.Enabled;
                LoadMsg();
            };
            deleteButton.Click += (s, e) =>
            {
                DeleteMsg();
                timer1.Start();
            };
            leftButton.Click += (s, e) =>
            {
                LoadMsg(0);
            };
            rightButton.Click += (s, e) =>
            {
                LoadMsg(1);
            };
            upButton.Click += (s, e) =>
            {
                scrollPage(false);
            };
            downButton.Click += (s, e) =>
            {
                scrollPage(true);
            };
        }

        void scrollPage(bool down)
        {
            int old = 0;
            try
            {
                old = scrolli;
                textBox1.Select(textBox1.GetFirstCharIndexFromLine(down ? ++scrolli : --scrolli), 0);
            }
            catch (Exception)
            {
                scrolli = old;
            }
            textBox1.ScrollToCaret();
        }

        public void LoadInterface()
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = pager.getData(myIcons);
        }

        public void LoadMsg(int add = 2)
        {
            if (!timer1.Enabled)
            {
                if (add == 1 && msgPage < msg.Count - 1)
                    msgPage++;
                else if (add == 0 && msgPage > 0)
                    msgPage--;
                string result = (msg.Count > 1) ? (msgPage + 1) + "/" + (msg.Count) + ": " + Environment.NewLine : "";
                if (msg.Count > 0)
                {
                    pager.notifyBar = "";
                    textBox1.TextAlign = HorizontalAlignment.Left;
                    textBox1.Text = $"{result}{msg[msgPage].getData()}";
                }
            }
        }
        public void DeleteMsg()
        {
            if (msg.Count > 0 && !timer1.Enabled)
            {
                msg.RemoveAt(msgPage);
                msgPage = msg.Count - 1;
                if (msg.Count == 0)
                    pager.letterBar = myIcons[1];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadInterface();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && msg.Count >0 && timer1.Enabled)
            {
                timer1.Stop();
            }
            else if (e.KeyCode == Keys.Enter && !timer1.Enabled)
            {
                timer1.Start();
            }
            else if (e.KeyCode == Keys.Left && !timer1.Enabled)
            {
                LoadMsg(1);
            }
            else if (e.KeyCode == Keys.Right && !timer1.Enabled)
            {
                LoadMsg(0);
            }
            else if (e.KeyCode == Keys.Delete && !timer1.Enabled)
            {
                DeleteMsg();
                timer1.Start();
            }
        }
    }
}
