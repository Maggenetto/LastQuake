using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace QuakeHistory
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> regionCodes = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();

            {
                string jsonFilePath = "Kubun.json"; // JSONファイルのパスを指定してください
                string jsonContent = File.ReadAllText(jsonFilePath);

                // JSONデータを解析してDictionaryに格納
                JObject json = JObject.Parse(jsonContent);
                foreach (var region in json)
                {
                    string regionName = region.Value.ToString();
                    string regionCode = region.Key.ToString();
                    regionCodes.Add(regionName, regionCode);
                }
            }
        }

        private static PrivateFontCollection pfc = new PrivateFontCollection();
        private void Form1_Load(object sender, EventArgs e)
        {

            byte[] fontBuf2 = Properties.Resources.Koruri_Semibold;
            unsafe
            {
                fixed (byte* pFontBuf2 = fontBuf2)
                {
                    pfc.AddMemoryFont((IntPtr)pFontBuf2, fontBuf2.Length);
                }
            }
            Last.Font = new Font(pfc.Families[0], 18);
            Ndate.Font = new Font(pfc.Families[0], 18);
            Date.Font = new Font(pfc.Families[0], 27);
            Day.Font = new Font(pfc.Families[0], 36);
            label3.Font = new Font(pfc.Families[0], 18);

            QuinfoINtext();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            QuinfoINtext();
        }
    }
}
