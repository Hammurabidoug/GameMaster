using GameMaster.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace GameMaster.Files
{
    public class BackupReader
    {
        public GameData Read(string filePath)
        {
            XPathDocument document = new XPathDocument(filePath);
            XPathNavigator navigator = document.CreateNavigator();

            List<Campaign> campaigns = new List<Campaign>();

            var node = navigator.Select("/data");

            var serializer = new XmlSerializer(typeof(GameData));

            using (var reader = new StringReader(node.Current.OuterXml))
            {
                return (GameData)serializer.Deserialize(reader);
            }

        }
    }
}
