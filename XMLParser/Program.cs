using System.Xml.Linq;
using XMLParser.Componentes;
using XMLParser.Helpers;

namespace XMLParser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xmlUri0end = @"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_0_End.xml";
            var xmlUri0ends = @"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_0_Ends.xml";
            var xmlUri1end = @"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_1_End.xml";
            var xmlUri2end = @"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_2_Ends.xml";

            string xml1 = File.ReadAllText(xmlUri0end);
            string xml2 = File.ReadAllText(xmlUri0ends);
            string xml3 = File.ReadAllText(xmlUri1end);
            string xml4 = File.ReadAllText(xmlUri2end);

            var propostaCliente1 = xml1.ParseXML<Cliente>();
            var propostaCliente2 = xml2.ParseXML<Cliente>();
            var propostaCliente3 = xml3.ParseXML<Cliente>();
            var propostaCliente4 = xml4.ParseXML<Cliente>();

            Console.Write(propostaCliente1);
        }
    }
}