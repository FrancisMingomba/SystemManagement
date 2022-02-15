using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace AppUtilities
{
   public class ConfigurationManager
    {
        private const string configFile = @"C:\Users\mingo\Desktop\SystemManagement\AppUtilities\Config.xml";

        public void setCulture()
        {
            try
            {
                var doc = readConfig();

                string xmlKey = "config/internationalization";
                XmlNode node = doc.DocumentElement.SelectSingleNode(xmlKey);

                if (node == null)
                {
                    throw new Exception("Could not find value for " + xmlKey);
                }
                if (isSupported(node.InnerText))
                {
                    Resource.Culture = new CultureInfo(node.InnerText);
                }
                else
                {
                    throw new Exception("Invalid configuration [ " + node.InnerText + " ] ");
                }
            }
            catch
            {
                throw;
            }
        }
        public bool setCulture(string userCulture)
        {
            if (!isSupported(userCulture))
            {
                Console.WriteLine("Invalid configuration [ " + userCulture + " ] ");
                return false;

            }

            const string nodePath = "/setting/config/internationalization";
            bool writeSuccess = writeToConfigFile(nodePath, userCulture);

            if(!writeSuccess)
            {
                Console.WriteLine("Error during write of configuration");
                return false;
            }

            try
            {
                setCulture();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }
        private XmlDocument readConfig()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(configFile);
            return doc;
        }
        private bool writeToConfigFile(string nodePath, string value)
        {
            bool success = false;
            try
            {
                // instantiate XmlDocument and load XML from file
                XmlDocument doc = new XmlDocument();
                doc.Load(configFile);

                // get a list of nodes
                XmlNode node = doc.SelectSingleNode(nodePath);
                node.InnerText = value;

                // save the XmlDocument back to disk
                doc.Save(configFile);

                success = true;

            }
            catch (XmlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return success;
        }       
        private bool isSupported(string configValue)
        {
            List<string> supported = new List<string> { "en-US", "fr", "zh_TW", "es" };
            return supported.Contains(configValue);
        }
        
    }
}
