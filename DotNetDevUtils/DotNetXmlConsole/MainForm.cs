﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetXmlConsole
{
    public partial class MainForm : Ults.Windows.Forms.MainFormBase
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxXPath.GotFocus += (s, e) => { comboBoxXPath.SelectAll(); };
        }

        private void buttonDoFilter_Click(object sender, EventArgs e)
        {
            try
            {
                var xml = new System.Xml.XmlDocument();
                xml.LoadXml(textBoxExInput.Text);

                var xnm = new System.Xml.XmlNamespaceManager(xml.NameTable);

                var result = xml.SelectNodes(comboBoxXPath.Text, xnm);
                textBoxExOutput.Text = string.Join("\r\n\r\n--------------------\r\n\r\n", result.Cast<System.Xml.XmlNode>().Select(f => FormatXmlDocument(f.OuterXml)));
                if (textBoxExOutput.Text.Length == 0)
                    textBoxExOutput.Text = "No results.";
            }
            catch (System.Exception ex)
            {
                textBoxExOutput.Text = string.Format("[{0}]\r\n{1}", ex.GetType().Name, ex.Message);
            }
        }

        public static string FormatXmlDocument(string xml)
        {
            var xmlDocument = new System.Xml.XmlDocument();
            xmlDocument.LoadXml(xml);

            var stream = new System.IO.MemoryStream();
            var writer = new System.Xml.XmlTextWriter(stream, Encoding.Unicode);

            // indent setting
            writer.Formatting = System.Xml.Formatting.Indented;
            writer.Indentation = 2; // indent length
            writer.IndentChar = ' '; // indent character

            // formatting write
            xmlDocument.WriteContentTo(writer);
            writer.Flush();
            stream.Flush();
            stream.Position = 0;

            // to string
            var reader = new System.IO.StreamReader(stream);
            string formattedXml = reader.ReadToEnd();

            return formattedXml;
        }

        private void buttonOpenRead_Click(object sender, EventArgs e)
        {
            using(var dlg = new System.Windows.Forms.OpenFileDialog())
            {
                dlg.InitialDirectory = Properties.Settings.Default.FileReadInitialDirectory;
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;

                textBoxExInput.Text = System.IO.File.ReadAllText(dlg.FileName);
                Properties.Settings.Default.FileReadInitialDirectory = System.IO.Path.GetDirectoryName(dlg.FileName);
                Properties.Settings.Default.Save();
            }
        }
    }
}
