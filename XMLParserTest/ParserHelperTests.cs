using XMLParser.Helpers;

namespace XMLParserTest
{
    public class ParserHelperTests
    {
        [Theory]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_1_End.xml")]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_2_Ends.xml")]
        public void ParseXML_PrecisaConterAtributoEnderecos(string uri)
        {

            string xml = File.ReadAllText(uri);

            var propostaCliente = xml.ParseXML<XMLParser.Componentes.Cliente>();

            Assert.NotNull(propostaCliente.Enderecos);

        }


        [Theory]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_1_End.json")]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_2_Ends.json")]
        public void ParseJSON_PrecisaConterAtributoEnderecos(string uri)
        {

            string json = File.ReadAllText(uri);

            var propostaCliente = json.ParseJSON<XMLParser.Componentes.Json.Root>();

            Assert.NotNull(propostaCliente.Cliente.Enderecos);

        }

        [Theory]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_1_End.json")]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_2_Ends.json")]
        public void ParseJSON_PrecisaConterAtributoEnderecosETerElemento(string uri)
        {

            string json = File.ReadAllText(uri);

            var propostaCliente = json.ParseJSON<XMLParser.Componentes.Json.Root>();

            Assert.NotNull(propostaCliente.Cliente.Enderecos);

            Assert.NotEmpty(propostaCliente.Cliente.Enderecos.Endereco);

        }

        [Theory]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_0_End.json")]
        [InlineData(@"C:\Users\felip\source\repos\XMLParser\XMLParser\Dados\Evento_0_Ends.json")]
        public void ParseJSON_PrecisaConterAtributoEnderecosESerNulo(string uri)
        {

            string json = File.ReadAllText(uri);

            var propostaCliente = json.ParseJSON<XMLParser.Componentes.Json.Root>();

            Assert.Null(propostaCliente.Cliente.Enderecos);

        }
    }
}