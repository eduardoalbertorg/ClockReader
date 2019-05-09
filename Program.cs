using System;
using System.Xml;

namespace FileReader {
    class Program {
        static void Main(string[] args) {
        	using (XmlReader reader = XmlReader.Create(@"model/Biometrics.xml")) {
        		while (reader.Read()) {
        			if (reader.IsStartElement()) {
        				switch (reader.Name.ToString()) {
        					case "IP":
        						Console.WriteLine("IP is " + reader.ReadString());
        						break;
        				}
        			}
        		}
        	}
        	Console.ReadKey();
        }
    }
}
