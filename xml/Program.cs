using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace xml
{
   
    static class Program
    {
        public static Exhibition LoadXml(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            if (!File.Exists(path))
            {
                Console.WriteLine("Нет доступа к файлу {0}", path);
                return null;
            }
            else
            {
                Console.WriteLine("Началась обработка данных");
            }
            try
            {
                MemoryStream datareader = new MemoryStream(File.ReadAllBytes(path));
                path = "C:\\Users\\talda\\source\\repos\\classwork180322\\xml\\bin\\Debug\\exhibition.xml";
                XmlSerializer xmls = new XmlSerializer(typeof(Exhibition));
                var xmlList = (Exhibition)xmls.Deserialize(datareader);

                Console.WriteLine("xml обработан");
                return xmlList;
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка обработки данных xml");
                return null;
            }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string path = "C:\\Users\\talda\\source\\repos\\classwork180322\\xml\\bin\\Debug\\exhibition.txt";
            //за путь файла извиняюсь
            var result = LoadXml(path);
        }
    }
}
