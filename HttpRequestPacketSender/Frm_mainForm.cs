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
using System.IO;
using System.Web;
namespace HttpRequestPacketSender
{
    public partial class Frm_mainForm : Form
    {
        public void GetRequest(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                if (Chk_SaveToFile.Checked)
                {
                    Rtb_output.Text = reader.ReadToEnd();
                }
                else
                {
                    Rtb_output.Text = reader.ReadToEnd();
                }
                 
            }
        }

        public Frm_mainForm()
        {
            InitializeComponent();
        }

        private void Frm_mainForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            //string uri = HttpUtility.UrlEncode(Txt_URI.Text);
            string url = "http://" + Txt_URI.Text;
            Console.WriteLine(url);
            GetRequest(url);
        }
    }
}
