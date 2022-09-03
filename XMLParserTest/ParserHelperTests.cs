using XMLParser.Componentes;
using XMLParser.Helpers;

namespace XMLParserTest
{
    public class ParserHelperTests
    {
        [Theory]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_15576357.xml")]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_15576352.xml")]        
        public void ParseXML_PrecisaConterAtributoEnderecos(string uri)
        {

            string xml = File.ReadAllText(uri);            

            var propostaCliente = xml.ParseXML<Cliente>();

            Assert.NotNull(propostaCliente.Enderecos);

        }
    }
}