using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class settings : Form
    {
        private List<string> _items = new List<string>();
        private System.Collections.Generic.List<ControlSettings> Elements = new System.Collections.Generic.List<ControlSettings>();
        private readonly string settingsfilename = "settings.xml";

        public settings()
        {
            InitializeComponent();

            //_items.Add("randy@192.168.6.85");
            //_items.Add("randy@192.168.3.85");

            Elements.Add(new ControlSettings("192.168.6.85","randy","17784290", "SJMM"));
            Elements.Add(new ControlSettings("192.168.3.85", "randy", "17784290", "URREA"));

            this.listBox1.DataSource = _items;

            if (!System.IO.File.Exists(settingsfilename))
                saveXml();
        }

        public void saveXml()
        {
            ControlSettings mycs;
            using (System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(settingsfilename))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Settings");

                for (int i = 0; i < Elements.Count; i++)
                {
                    writer.WriteStartElement("Setting");

                    mycs = (ControlSettings)Elements[i];

                    writer.WriteElementString("hostname", mycs.Addr.ToString());
                    writer.WriteElementString("username", mycs.Username);
                    writer.WriteElementString("password", mycs.Password);
                    writer.WriteElementString("label", mycs.Label);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }

    public class ControlSettings
    {
        string _label;
        System.Net.IPAddress _addrRdb;
        string _username;
        string _password;

        public ControlSettings(string HostName, string username, string password, string label)
        {
            System.Net.IPAddress[] addr = new System.Net.IPAddress[1];
            System.Net.IPAddress.TryParse(HostName, out _addrRdb);
            this._username = username;
            this._password = password;
            this._label = label;
        }

        public System.Net.IPAddress Addr { get { return _addrRdb; } }
        public string Username { get { return _username; } }
        public string Password { get { return _password; } }
        public string Label { get { return _label; } }
    }
}
