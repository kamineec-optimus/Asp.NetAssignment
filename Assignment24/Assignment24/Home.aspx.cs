﻿using System;
using System.IO;
using System.Web;


namespace Assignment24
{
    public partial class Home : System.Web.UI.Page
    {
        /// <summary>
        /// object of XmlOperations class
        /// </summary>
        XmlOperations objXml = new XmlOperations();
        /// <summary>
        ///  save the path of file
        /// </summary>
        string ApplicationURL = "http://{0}:{1}";
        string NavigateURL = "http://{0}:{1}/Test.Xml";
        string FilePath = string.Format("http://{0}:{1}/Test.Xml", Assignment24.Properties.Settings.Default.HostName, Assignment24.Properties.Settings.Default.PortNo);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //objXml.CreateXmlFile(FilePath);
                

            }
            hlinkXML.NavigateUrl = string.Format(NavigateURL, Assignment24.Properties.Settings.Default.HostName, Assignment24.Properties.Settings.Default.PortNo);
     
            }

        protected void btnAddNode_Click(object sender, EventArgs e)
        {
            ///add node to the xml file
            objXml.AddNode(FilePath);
            
        }

        protected void btnFirstChild_Click(object sender, EventArgs e)
        {
            /// get first child of the node
            txtNode.Text = objXml.GetFirstChild(FilePath);
        }

        protected void btnInsertBefore_Click(object sender, EventArgs e)
        {
            ///insert node before given node
            objXml.InsertBefore(FilePath);

        }

        protected void btnRemoveNode_Click(object sender, EventArgs e)
        {
            ///remove node from the file
            objXml.RemoveNode(FilePath);
        }

        protected void btnChildNode_Click(object sender, EventArgs e)
        {
            ///get the child nodes
            txtNode.Text = objXml.GetChildNode(FilePath);

        }

        protected void btnReplace_Click(object sender, EventArgs e)
        {
            /// replace node with the given node
            objXml.ReplaceNode(FilePath);
        }

      }
}