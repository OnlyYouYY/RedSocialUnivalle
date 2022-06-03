using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace RedSocialUnivalle
{
    public partial class ChatMasServidor : Form
    {
        static private NetworkStream stream;
        static private StreamWriter streamw;
        static private StreamReader streamr;
        static private TcpClient client = new TcpClient();
        

        private delegate void DaddItem(string s);
        private void AddItem(string s)
        {
            lbChat.Items.Add(s);    
        }
        public ChatMasServidor()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            streamw.WriteLine(tbEnviarMsg.Texts);
            streamw.Flush();
            tbEnviarMsg.Texts = "";
        }

        public void Listen()
        {
            while (client.Connected)
            {
                try
                {
                    this.Invoke(new DaddItem(AddItem), streamr.ReadLine());
                }
                catch
                {
                    MessageBox.Show("No se a podido conectar al servidor");
                }
            }
        }

    }
}
