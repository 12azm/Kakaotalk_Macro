using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace kkk
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string ipclassname, string ipwindowname);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hwnd1, IntPtr hwnd2, string ipsz1, string ipsz2);

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int wmsg, int wparam, string iparam);

        [DllImport("user32.dll")]
        public static extern uint PostMessage(IntPtr hwnd, int wmsg, int wparam, int iparam);

        Thread mainthr;
        public Form1()
        {
            InitializeComponent();
        }

        private void thr()
        {
            for (; ; )
            {
                for (int i = 0; i < roomList.Items.Count; i++) //리스트박스에 있는 아이템의 개수 만큼.
                {
                    IntPtr kakaotalk = FindWindow(null, roomList.Items[i].ToString());
                    if (kakaotalk != IntPtr.Zero)
                    {
                        IntPtr sendBox = FindWindowEx(kakaotalk, IntPtr.Zero, "RICHEDIT50W", "");
                        if (sendBox != IntPtr.Zero)
                        {
                            SendMessage(sendBox, 0x000c, 0, Content.Text); //0x00c = set text
                            Thread.Sleep(10);
                            PostMessage(sendBox, 0x0100, 0xD, 0x0101); //0x0100 = keydown, 0xD = enter, 0x0101 = keyup
                        }
                    }

                }
                if (timeSelector.SelectedIndex == 0) //초
                    Thread.Sleep(Convert.ToInt32(time.Value * 1000));
                if (timeSelector.SelectedIndex == 1) //분
                    Thread.Sleep(Convert.ToInt32(time.Value * 1000 * 60));
                if (timeSelector.SelectedIndex == 2) //시
                    Thread.Sleep(Convert.ToInt32(time.Value * 1000 * 3600));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeSelector.SelectedIndex = 0;
        }

        private void imButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] list = File.ReadAllLines(ofd.FileName);
                for (int i = 0; i < list.Length; i++)
                {
                    roomList.Items.Add(list[i]);
                }
            }
        }

        private void sendButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sendButton.Checked)
            {
                mainthr = new Thread(thr) { IsBackground = true };
                mainthr.Start();
            }
            else
            {
                try
                {
                    mainthr.Abort();
                    mainthr.Join();
                }catch { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int num = 0; num < 6; num++)
            {
                for (int i = 0; i < roomList.Items.Count; i++) //리스트박스에 있는 아이템의 개수 만큼.
                {
                    IntPtr kakaotalk = FindWindow(null, roomList.Items[i].ToString());
                    if (kakaotalk != IntPtr.Zero)
                    {
                        IntPtr sendBox = FindWindowEx(kakaotalk, IntPtr.Zero, "RICHEDIT50W", "");
                        if (sendBox != IntPtr.Zero)
                        {
                            SendMessage(sendBox, 0x000c, 0, Content.Text); //0x00c = set text
                            Thread.Sleep(10);
                            PostMessage(sendBox, 0x0100, 0xD, 0x0101); //0x0100 = keydown, 0xD = enter, 0x0101 = keyup
                        }
                    }

                }
            }
        }
    }
}
