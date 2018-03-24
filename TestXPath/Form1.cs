using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace TestXPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToXPath()
        {
            string html = @"<div id='demo'><p>1111</p><p>2222</p></div>";
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            //HtmlNode root = doc.DocumentNode;
            //HtmlNodeCollection hNodes = root.SelectNodes("//dl[@class='trademark-cat-item-r-con']//dd");

            XmlDocument document = new XmlDocument();
            document.LoadXml(doc.DocumentNode.InnerHtml);

            var nodes = document.SelectNodes(@"//div[@id='demo']//p");

            var lstText = new List<string>();
            for (var i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];
                lstText.Add(node.InnerText);
            }
             
            string aa = "";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ToXPath();
        }
    }
}
