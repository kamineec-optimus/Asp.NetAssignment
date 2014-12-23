using System.Xml;
using System.IO;
using System;

namespace Assignment24
{
    public class XmlOperations
    {
        /// <summary>
        /// object of XmlTextWriter to operate on xml file
        /// </summary>
        XmlTextWriter xmlWriter;        
        XmlDocument xmlDoc = new XmlDocument();           
       
        /// <summary>
        /// method to create xml file
        /// </summary>
        public void CreateXmlFile(string filePath)
        {
            try
            {
                ///Create a xml file
                xmlWriter = new XmlTextWriter(filePath, null);
                ///set the intending
                xmlWriter.Formatting = Formatting.Indented;
                /// create declaration to the xml
                xmlWriter.WriteStartDocument();
                ///add the root element to the document 
                xmlWriter.WriteStartElement("iCalibrator");
                ///add node (Training) 
                xmlWriter.WriteStartElement("Training");
                ///Add attributes of Training node
                xmlWriter.WriteAttributeString("day", "1");

                ///child elements
                xmlWriter.WriteElementString("Chapter", "XML-1");
                xmlWriter.WriteElementString("Chapter", "XML-2");

                ///close Training Node
                xmlWriter.WriteEndElement();
                ///close Document
                xmlWriter.WriteEndDocument();
            }
            catch (FileNotFoundException ex)
            {
                throw (ex);
            }

            finally
            {
                /// close the writer object
                xmlWriter.Close();
            }
        }

        /// <summary>
        /// methos to add Node to xml file
        /// </summary>
        public void AddNode(string filePath)
        {
            try
            {
                ///load xml document
                xmlDoc.Load(filePath);

                ///create an element assignment
                XmlElement assignmentElement = xmlDoc.CreateElement("assignment");
                ///set element's attributes
                assignmentElement.SetAttribute("Submitted", "Y");
                ///add number element to the node
                XmlElement num1Element = xmlDoc.CreateElement("number");
                num1Element.InnerText = "1";
                ///add inner element to the element
                assignmentElement.AppendChild(num1Element);
                ///add anothor number element to the node
                XmlElement num2Element = xmlDoc.CreateElement("number");
                num2Element.InnerText = "2";
                ///add inner element to the element
                assignmentElement.AppendChild(num2Element);
                ///add another inner element to the element
                xmlDoc.DocumentElement.AppendChild(assignmentElement);
                //save the document

                string uriPath = filePath;
                string localPath = new Uri(uriPath).LocalPath;
                xmlDoc.Save(localPath);
            }
            catch (FileNotFoundException ex)
            {
                throw (ex);
            }
           
        }

        /// <summary>
        /// method to get first child of node 
        /// </summary>
        /// <returns>string</returns>
        public string  GetFirstChild(string filePath)
        {
            try
            {
                ///load document     
                xmlDoc.Load(filePath);
                ///get element of document
                XmlElement xmlElement = xmlDoc.DocumentElement;
                ///return child nodes of the document
                return (xmlElement.FirstChild.Name.ToString());
            }
            catch (FileNotFoundException ex)
            {
                throw (ex);
            }
           
        }

        /// <summary>
        /// insert node before existing node
        /// </summary>
        public void InsertBefore(string filePath)
        {
            try
            {
                ///load document 
                xmlDoc.Load(filePath);

                ///insert node before this node
                XmlNode xmlNode = xmlDoc.SelectSingleNode("Training");
                ///node to be inserted
                XmlElement xmlNewChild = xmlDoc.CreateElement("testing");
                ///call method InsertAfter to insert the node
                xmlDoc.DocumentElement.InsertAfter(xmlNewChild, xmlNode);
                ///save the document
                xmlDoc.Save(filePath);
            }
            catch (FileNotFoundException ex)
            {
                throw (ex);
            }
           
        }

        /// <summary>
        /// method to remove node
        /// </summary>
        public void RemoveNode(string filePath)
        {
            try
            {
                ///load the document
                xmlDoc.Load(filePath);
                ///node to be removed
                XmlNodeList nodes = xmlDoc.GetElementsByTagName("assignment");
                ///remove all child node as well
                foreach (XmlNode node in nodes)
                {
                    node.RemoveAll();
                }
                /// save the doc
                xmlDoc.Save(filePath);
            }
            catch (FileNotFoundException ex)
            {
                throw (ex);
            }
           
        }

        /// <summary>
        /// method to get name of child nodes
        /// </summary>
        /// <returns>name of the nodes</returns>
        public string GetChildNode(string filePath)
        {
            try
            {
                ///variable to save node's name
                string NodeName = string.Empty;
                ///get the document
                XmlDocument xmlDoc = new XmlDocument();
                ///load the document
                xmlDoc.Load(filePath);
                ///get the fist child
                XmlNode root = xmlDoc.FirstChild;
                ///get the names of all the child nodes
                if (root.HasChildNodes)
                {
                    for (int i = 0; i < root.ChildNodes.Count; i++)
                    {
                        NodeName += root.ChildNodes[i].InnerText;
                    }
                }

                ///return node name
                return NodeName;
            }
            catch (FileNotFoundException ex)
            {
                throw (ex);
            }
            
        }

        /// <summary>
        /// method to replace node from the file
        /// </summary>
        public void ReplaceNode(string filePath)
        {
            try
            {
                ///load the document
                xmlDoc.Load(filePath);
                ///element to be replaced with
                XmlElement xmlelement = xmlDoc.CreateElement("Testing Over");
                ///get the node to be replace
                XmlNode root = xmlDoc.DocumentElement;
                ///replace the nodes
                root.ReplaceChild(xmlelement, root.FirstChild);
                ///save the file
                xmlDoc.Save(filePath);
            }
            catch (FileNotFoundException ex)
            {
                throw (ex);
            }
           
        }
    }
}