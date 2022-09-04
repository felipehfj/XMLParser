using System.Xml.Serialization;

namespace XMLParser.Componentes
{
    [XmlRoot(ElementName = "Endereco")]
    public class Endereco
    {

        [XmlElement(ElementName = "Logradouro")]
        public string Logradouro { get; set; }
        [XmlElement(ElementName = "Complemento")]
        public string Complemento { get; set; }
        [XmlElement(ElementName = "Bairro")]
        public string Bairro { get; set; }
        [XmlElement(ElementName = "Cidade")]
        public string Cidade { get; set; }
        [XmlElement(ElementName = "Uf")]
        public string Uf { get; set; }
        [XmlElement(ElementName = "Cep")]
        public string Cep { get; set; }
        [XmlElement(ElementName = "Pais")]
        public string Pais { get; set; }
    }
    [XmlRoot(ElementName = "Enderecos")]
    public class Enderecos
    {
        public Enderecos()
        {
            Endereco = new List<Endereco>();
        }
        [XmlElement(ElementName = "Endereco")]
        public List<Endereco> Endereco { get; set; }
    }
    [XmlRoot(ElementName = "Proposta")]
    public class Proposta
    {
        [XmlElement(ElementName = "AcaoMarketing")]
        public string AcaoMarketing { get; set; }
        [XmlElement(ElementName = "ModeloProposta")]
        public string ModeloProposta { get; set; }
        [XmlElement(ElementName = "ConvenioAdesao")]
        public string ConvenioAdesao { get; set; }
        [XmlElement(ElementName = "NumeroAlternativa")]
        public string NumeroAlternativa { get; set; }
        [XmlElement(ElementName = "TipoAngariacaoId")]
        public string TipoAngariacaoId { get; set; }
    }

    [XmlRoot(ElementName = "ProdutorParticipante")]
    public class ProdutorParticipante
    {
        [XmlElement(ElementName = "CodigoProdutor")]
        public string CodigoProdutor { get; set; }
        [XmlElement(ElementName = "TipoCodigo")]
        public string TipoCodigo { get; set; }
        [XmlElement(ElementName = "TipoProdutor")]
        public string TipoProdutor { get; set; }
        [XmlElement(ElementName = "PercentualDivisao")]
        public double PercentualDivisao { get; set; }
    }

    [XmlRoot(ElementName = "ProdutoresParticipantes")]
    public class ProdutoresParticipantes
    {
        [XmlElement(ElementName = "ProdutorParticipante")]
        public ProdutorParticipante ProdutorParticipante { get; set; }
    }

    [XmlRoot(ElementName = "CoberturaContratada")]
    public class CoberturaContratada
    {
        [XmlElement(ElementName = "IdExterno")]
        public string IdExterno { get; set; }
        [XmlElement(ElementName = "InscricaoCertificado")]
        public string InscricaoCertificado { get; set; }
        [XmlElement(ElementName = "UnidadeProducao")]
        public string UnidadeProducao { get; set; }
        [XmlElement(ElementName = "UnidadeFiscal")]
        public string UnidadeFiscal { get; set; }
        [XmlElement(ElementName = "ItemProdutoId")]
        public int? ItemProdutoId { get; set; }
        [XmlElement(ElementName = "FormaContratacaoId")]
        public int? FormaContratacaoId { get; set; }
        [XmlElement(ElementName = "RelacaoSeguradoId")]
        public int? RelacaoSeguradoId { get; set; }
        [XmlElement(ElementName = "TipoRendaId")]
        public int? TipoRendaId { get; set; }
        [XmlElement(ElementName = "Assinatura")]
        public DateTime? Assinatura { get; set; }
        [XmlElement(ElementName = "Implantacao")]
        public DateTime Implantacao { get; set; }
        [XmlElement(ElementName = "FimVigencia")]
        public DateTime? FimVigencia { get; set; }
        [XmlElement(ElementName = "InicioVigencia")]
        public DateTime InicioVigencia { get; set; }
        [XmlElement(ElementName = "PrazoContribuicao")]
        public int? PrazoContribuicao { get; set; }
        [XmlElement(ElementName = "ParcelasPagas")]
        public int ParcelasPagas { get; set; }
        [XmlElement(ElementName = "NumeroProposta")]
        public string NumeroProposta { get; set; }
        [XmlElement(ElementName = "FormaCobrancaId")]
        public int FormaCobrancaId { get; set; }
        [XmlElement(ElementName = "DataEvento")]
        public DateTime DataEvento { get; set; }
        [XmlElement(ElementName = "Proposta")]
        public Proposta Proposta { get; set; }
        [XmlElement(ElementName = "CodigoParceiro")]
        public string CodigoParceiro { get; set; }
        [XmlElement(ElementName = "TipoInscricaoId")]
        public int TipoInscricaoId { get; set; }
        [XmlElement(ElementName = "TipoRegimeIRId")]
        public int TipoRegimeIRId { get; set; }
        [XmlElement(ElementName = "Contribuicao")]
        public double Contribuicao { get; set; }
        [XmlElement(ElementName = "Beneficio")]
        public double Beneficio { get; set; }
        [XmlElement(ElementName = "CapitalSegurado")]
        public double? CapitalSegurado { get; set; }
        [XmlElement(ElementName = "ProdutoresParticipantes")]
        public ProdutoresParticipantes ProdutoresParticipantes { get; set; }
        [XmlElement(ElementName = "IOF")]
        public double IOF { get; set; }
        [XmlElement(ElementName = "PrazoDecrescimo")]
        public DateTime? PrazoDecrescimo { get; set; }
        [XmlElement(ElementName = "PeriodicidadePagamento")]
        public int? PeriodicidadePagamento { get; set; }
        [XmlElement(ElementName = "TempoPagamentoAntecipado")]
        public int? TempoPagamentoAntecipado { get; set; }
        [XmlElement(ElementName = "CapitalSeguradoOriginal")]
        public double CapitalSeguradoOriginal { get; set; }
        [XmlElement(ElementName = "ClasseRiscoId")]
        public int? ClasseRiscoId { get; set; }
    }

    [XmlRoot(ElementName = "Coberturas")]
    public class Coberturas
    {
        [XmlElement(ElementName = "CoberturaContratada")]
        public List<CoberturaContratada> CoberturaContratada { get; set; }
    }

    [XmlRoot(ElementName = "Cliente")]
    public class Cliente
    {
        Endereco? _endereco;


        [XmlElement(ElementName = "Identificador")]
        public Guid Identificador { get; set; }
        [XmlElement(ElementName = "Matricula")]
        public string Matricula { get; set; }
        [XmlElement(ElementName = "PessoaId")]
        public int PessoaId { get; set; }
        [XmlElement(ElementName = "Enderecos")]
        public Enderecos? Enderecos { get; set; }
        [XmlElement(ElementName = "Endereco")]
        public Endereco? Endereco
        {
            get { return _endereco; }
            set
            {
                if (value != null)
                {
                    if (Enderecos == null)
                    {
                        Enderecos = new Enderecos();
                    }
                    Enderecos.Endereco.Add(value);
                }

                _endereco = value;
            }
        }
        [XmlElement(ElementName = "Coberturas")]
        public Coberturas Coberturas { get; set; }
        [XmlElement(ElementName = "TipoDocumentoId")]
        public int TipoDocumentoId { get; set; }
        [XmlElement(ElementName = "Documento")]
        public string Documento { get; set; }
        [XmlElement(ElementName = "Nome")]
        public string Nome { get; set; }
        [XmlElement(ElementName = "DataNascimento")]
        public DateTime DataNascimento { get; set; }
        [XmlElement(ElementName = "Sexo")]
        public string Sexo { get; set; }
        [XmlElement(ElementName = "DataExecucaoEvento")]
        public DateTime? DataExecucaoEvento { get; set; }
        [XmlElement(ElementName = "ProfissaoId")]
        public int ProfissaoId { get; set; }
        [XmlElement(ElementName = "IdentificadorNegocio")]
        public string IdentificadorNegocio { get; set; }
    }
}
