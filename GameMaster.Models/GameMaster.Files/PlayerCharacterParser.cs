using GameMaster.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace GameMaster.Files
{
    public class PlayerCharacterParser
    {
        public PlayerCharacter Parse(Campaign campaign, XPathNavigator node)
        {

            var nodes = node.Select("pc");

            while (nodes.MoveNext())
            {
                var currentNode = nodes.Current;

                var nameNode = currentNode.SelectSingleNode("name");

                //var playerCharacter = new PlayerCharacter
                //{
                //    Label = currentNode.SelectSingleNode("label").Value,
                //    //Id = currentNode.SelectSingleNode("uid").Value,
                //    //Label = currentNode.SelectSingleNode("label").Value,
                //    //Label = currentNode.SelectSingleNode("label").Value,
                //    //Label = currentNode.SelectSingleNode("label").Value,
                //    //Label = currentNode.SelectSingleNode("label").Value,
                //    //Label = currentNode.SelectSingleNode("label").Value,
                //    //Label = currentNode.SelectSingleNode("label").Value,
                //    //Label = currentNode.SelectSingleNode("label").Value,
                //    //Label = currentNode.SelectSingleNode("label").Value,
                //    //Label = currentNode.SelectSingleNode("label").Value,


                //};

                string outerXml = currentNode.OuterXml;

                //XmlRootAttribute xRoot = new XmlRootAttribute();
                //xRoot.ElementName = "pc";
                //xRoot.IsNullable = true;
                var serializer = new XmlSerializer(typeof(PlayerCharacter));

                using (var reader = new StringReader(outerXml))
                {
                    object player = serializer.Deserialize(reader);
                }
            }

            return null;
        }
    }
}
