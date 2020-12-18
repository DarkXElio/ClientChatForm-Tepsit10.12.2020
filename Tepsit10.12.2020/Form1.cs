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
using System.Net.Sockets;


namespace Tepsit10._12._2020
{
    public partial class Form1 : Form
    {
        Socket client;
        IPAddress ipAddr = null;
        string strIPAddress = "";
        string strPort = "";
        int nPort = 0;
        string recvString = "";
        byte[] sendBuff = new byte[128];
        byte[] recvBuff = new byte[128];
        int recvBytes = 0;
        public Form1()
        {
            InitializeComponent();
            Size = new Size(344, 218);
            btn_Send.Visible = false;
            txt_mesaggio.Visible = false;
            Messagio.Visible = false;
            lstbox_messagio_server.Visible = false;
            btn_disconeti.Visible = false;


        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            strIPAddress = txt_severip.Text;
            strPort = txt_serverport.Text;
            if (!IPAddress.TryParse(strIPAddress.Trim(), out ipAddr))
            {
               errore.Text="IP non valido .";//se fallisco do il messaggio e chiudo il programma
                return;
            }
            // Provo a copiare la porta in forma di stringa nella varibile intera
            if (!int.TryParse(strPort, out nPort))
            {
                errore.Text = "Porta non valida ."; //se fallisco do il messaggio e chiudo il programma
                return;
            }
            // Controllo che la porta sia compresa fra 0 e 65535
            if (nPort <= 0 || nPort >= 65535)
            {
                errore.Text = "Porta non valida ."; //se fallisco do il messaggio e chiudo il programma
                return;
            }
            errore.Text = "Endpoint: " + ipAddr.ToString() + " " + nPort;

            // Connessione al server
            try
            {
                client.Connect(ipAddr, nPort);
                errore.Text = "Connection Succesfull;";
                btn_connect.Location = new Point(227, 68);


                txt_severip.Enabled = false;
                txt_serverport.Enabled = false;
                btn_connect.Enabled = false;
                btn_disconeti.Visible = true;
                Size = new Size(344, 454);
                btn_Send.Visible = true;
                txt_mesaggio.Visible = true;
                Messagio.Visible=true;
                lstbox_messagio_server.Visible = true;
                lstbox_messagio_server.Items.Add("Chatta con il server. ");

            }
            catch (Exception ex)
            {
                errore.Text = ex.Message;
            }

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {





                sendBuff = Encoding.ASCII.GetBytes(txt_mesaggio.Text);
            if (txt_mesaggio.Text.ToUpper().Trim() != "QUIT" && txt_mesaggio.Text.ToUpper().Trim() != "")
            {
                client.Send(sendBuff);
                // mi metto in ascolto del messaggio del server
                recvBytes = client.Receive(recvBuff);
                recvString = Encoding.ASCII.GetString(recvBuff);

                
                lstbox_messagio_server.Items.Add("Client: " + txt_mesaggio.Text);

                string[] subs = recvString.Split(';');
                foreach (string element in subs)
                {
                    lstbox_messagio_server.Items.Add("Server: " + element);
                }

                //lo scrivo a video


                    //Pulisco le variabili
                    Array.Clear(recvBuff, 0, recvBuff.Length);
                    Array.Clear(sendBuff, 0, sendBuff.Length);
                    recvString = "";
                    recvBytes = 0;
                    txt_mesaggio.Text = "";
               
            }

            if (txt_mesaggio.Text.ToUpper().Trim() == "QUIT")
            {
                btn_Send.Visible = false;
                txt_mesaggio.Visible = false;
                Messagio.Visible = false;
                lstbox_messagio_server.Visible = false;
                client.Send(sendBuff);
                client.Close();
                client.Dispose();
                errore.Text = "Ti sei disconneso :) ";
                Size = new Size(344, 218);

                txt_severip.Enabled = true;
                txt_serverport.Enabled = true;
                btn_connect.Enabled = true;
                btn_disconeti.Visible = false;
                btn_connect.Location = new Point(227, 89);

            }
            if (txt_mesaggio.Text.ToUpper().Trim() == "")
            {
                errore.Text = "Messagi vuoti non possono essere mandati :/ ";
            }



        }

        private void btn_disconeti_Click(object sender, EventArgs e)
        {
            sendBuff = Encoding.ASCII.GetBytes("QUIT");
            btn_Send.Visible = false;
            txt_mesaggio.Visible = false;
            Messagio.Visible = false;
            lstbox_messagio_server.Visible = false;
            btn_disconeti.Visible = false;
            client.Send(sendBuff);
            client.Close();
            client.Dispose();
            errore.Text = "Ti sei disconneso :)";
            Size = new Size(344, 218);

            txt_severip.Enabled = true;
            txt_serverport.Enabled = true;
            btn_connect.Enabled = true;
            btn_connect.Location = new Point(227,89);
        }
        private void Invia(object sender, EventArgs e)
        {
        
        }


    }
}
