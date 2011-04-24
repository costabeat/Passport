using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace PassportLib
{
    public sealed class Passport
    {
        public List<PassportGroup> Groups = new List<PassportGroup>();

        private static bool Crypt(string fileName, string key, MemoryStream data)
        {
            try
            {
                SymmetricAlgorithm alg = Rijndael.Create();
                ICryptoTransform ctr = alg.CreateEncryptor(new PasswordDeriveBytes(key, null).GetBytes(16), new byte[16]);      
                FileStream fs = new FileStream(fileName, FileMode.Open);
                CryptoStream cs = new CryptoStream(fs, ctr, CryptoStreamMode.Write);
                cs.Write(data.ToArray(), 0, (int)data.Length);
                cs.FlushFinalBlock();
                return true;
            }
            catch
            { return false; }
        }

        private static StreamReader Decrypt(string fileName, string key)
        {
            try
            {       
                FileStream fs = new FileStream(fileName, FileMode.Open);
                SymmetricAlgorithm alg = Rijndael.Create();
                ICryptoTransform ctr = alg.CreateDecryptor(new PasswordDeriveBytes(key, null).GetBytes(16), new byte[16]);      
                CryptoStream cs = new CryptoStream(fs, ctr, CryptoStreamMode.Read);
                StreamReader reader = new StreamReader(cs);
                return reader;
            }
            catch
            { return null; }
        }

        public bool Load(string fileName, string passKey)
        {
            if (!File.Exists(fileName)) return false;
            StreamReader reader = Decrypt(fileName, passKey);
            if (reader == null) return false;
            try
            {
                XDocument doc = XDocument.Load(reader);
                var groups = from g in doc.Descendants("passwords").Descendants("group")
                             select g;
                foreach (var gItem in groups)
                {
                    if (gItem == null) continue;
                    PassportGroup group = new PassportGroup(Convert.ToString(gItem.Attribute("Name").Value));
                    Groups.Add(group);
                    var passcards = from c in gItem.Descendants("card")
                                    select c;
                    foreach (var cItem in passcards)
                    {
                        if (cItem == null) continue;
                        PassportCard card = new PassportCard(Convert.ToString(cItem.Attribute("Name").Value));
                        group.Cards.Add(card);
                        var passitems = from i in cItem.Descendants("item")
                                        select i;
                        foreach (var iItem in passitems)
                        {
                            if (iItem == null) continue;
                            PassportItem item = new PassportItem(Convert.ToString(iItem.Attribute("Param").Value), Convert.ToString(iItem.Attribute("Value").Value));
                            card.Items.Add(item);
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Save(string fileName, string passKey)
        {
            if (!File.Exists(fileName)) return false;
            try
            {
                XElement xPassport = new XElement("passwords");
                foreach (PassportGroup group in Groups)
                {
                    XElement xGroup = new XElement("group", new XAttribute("Name", group.Name));
                    xPassport.Add(xGroup);
                    foreach (PassportCard card in group.Cards)
                    {
                        XElement xCard = new XElement("card", new XAttribute("Name", card.Name));
                        xGroup.Add(xCard);
                        foreach (PassportItem item in card.Items)
                        {
                            XElement xItem = new XElement("item", new XAttribute("Param", item.Param), new XAttribute("Value", item.Value));
                            xCard.Add(xItem);
                        }
                    }
                }
                XDocument doc = new XDocument(new XElement("passport", xPassport));
                MemoryStream ms = new MemoryStream();
                doc.Save(ms);
                if (!Crypt(fileName, passKey, ms)) return false;
            }
            catch
            { return false; }
            return true;
        }

        public static string RandomValue(int size)
        {
            string value = string.Empty;
            Random gen = new Random();
            for (int i = 0; i < size; i++)
            {
                int t = gen.Next(3);
                switch (t)
                {
                    case 0: value += (char)(gen.Next(26) + 97); break;
                    case 1: value += gen.Next(10); break;
                    case 2: value += Char.ToUpper((char)(gen.Next(26) + 97)); break;
                }
            }
            return value;
        }

        public static int GetImageIndex(string param)
        {
            int index = 0;
            if (param == null) return index;
            switch (param)
            {
                case "Password": index = 0; break;
                case "Login": index = 1; break;
                case "URL": index = 2; break;
                case "Card Number": index = 3; break;
                case "Date": index = 4; break;
                case "Phone": index = 5; break;
                case "E-Mail": index = 6; break;
                case "ICQ": index = 7; break;
                case "Skype": index = 8; break;
                case "Jabber": index = 9; break;
                default: index = 10; break;
            }
            return index;
        }
    }
}
