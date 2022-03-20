using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace xml
{
    [System.Xml.Serialization.XmlRoot("Exhibition")]
    public class Exhibition
    {
        [System.Xml.Serialization.XmlElement("paintings")]
        public Paintings paintings { get; set; }
        [System.Xml.Serialization.XmlElement("Visitors")]
        public Visitors Visitors { get; set; }
        [System.Xml.Serialization.XmlElement("Kritik")]
        public Kritiks Kritiks{ get; set; }
    }
    public class Paintings
    {
        [System.Xml.Serialization.XmlElement("Paintings")]
        public Paintings[] PaintingsArray { get; set; }
    }
    public class Painting
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int id { get; set; }
        [System.Xml.Serialization.XmlElement("nameothepainting", Namespace = "")]
        public string nameofthepainting { get; set; }
        [System.Xml.Serialization.XmlElement("author", Namespace = "")]
        public string author { get; set; }
        [System.Xml.Serialization.XmlElement("yearofmastering", Namespace = "")]
        public int yearofmastering { get; set; }
    }
    public class Visitors
    {
        [System.Xml.Serialization.XmlElement("Visitors")]
        public Visitor[] VisitorsArray { get; set; }
    }
    public class Visitor
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int id { get; set; }
        [System.Xml.Serialization.XmlElement("nameofthevisitor", Namespace = "")]
        public string name { get; set; }
        [System.Xml.Serialization.XmlElement("age", Namespace = "")]
        public int age { get; set; }
        [System.Xml.Serialization.XmlElement("score", Namespace = "")]
        public int score { get; set; }
    }
    public class Kritiks
    {
        [System.Xml.Serialization.XmlElement("Kritiks")]
        public Kritik[] KritiksArray { get; set; }
    }
    public class Kritik
    {
        [System.Xml.Serialization.XmlAttribute("id", Namespace = "")]
        public int kid { get; set; }
        [System.Xml.Serialization.XmlElement("nameofthekritik", Namespace = "")]
        public string kname { get; set; }
        [System.Xml.Serialization.XmlElement("procentofalcoholizm", Namespace = "")]
        public int procent { get; set; }
        [System.Xml.Serialization.XmlElement("review", Namespace = "")]
        public string review { get; set; }
    }
  
}

