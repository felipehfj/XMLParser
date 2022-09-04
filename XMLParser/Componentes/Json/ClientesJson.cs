namespace XMLParser.Componentes.Json
{
    public class Cliente
    {
        Endereco? _endereco;

        public Guid Identificador { get; set; }
        public string Matricula { get; set; }
        public int PessoaId { get; set; }
        public Enderecos? Enderecos { get; set; }
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
        public Coberturas? Coberturas { get; set; }
        public int TipoDocumentoId { get; set; }
        public long Documento { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Sexo { get; set; }
        public DateTime DataExecucaoEvento { get; set; }
        public int ProfissaoId { get; set; }
        public int IdentificadorNegocio { get; set; }
    }

    public class Endereco
    {

        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string Pais { get; set; }
    }

    public class Enderecos
    {
        public Enderecos()
        {
            Endereco = new List<Endereco>();
        }
        public List<Endereco> Endereco { get; set; }
    }

    public class CoberturaContratada
    {
        public string IdExterno { get; set; }
        public string InscricaoCertificado { get; set; }
        public string UnidadeProducao { get; set; }
        public string UnidadeFiscal { get; set; }
        public int ItemProdutoId { get; set; }
        public int FormaContratacaoId { get; set; }
        public int RelacaoSeguradoId { get; set; }
        public int TipoRendaId { get; set; }
        public DateTime? Assinatura { get; set; }
        public DateTime? Implantacao { get; set; }
        public DateTime? FimVigencia { get; set; }
        public DateTime InicioVigencia { get; set; }
        public int? PrazoContribuicao { get; set; }
        public int ParcelasPagas { get; set; }
        public string NumeroProposta { get; set; }
        public int FormaCobrancaId { get; set; }
        public DateTime DataEvento { get; set; }
        public Proposta Proposta { get; set; }
        public string CodigoParceiro { get; set; }
        public int TipoInscricaoId { get; set; }
        public int TipoRegimeIRId { get; set; }
        public double? Contribuicao { get; set; }
        public double? Beneficio { get; set; }
        public double? CapitalSegurado { get; set; }
        public ProdutoresParticipantes? ProdutoresParticipantes { get; set; }
        public int? ClasseRiscoId { get; set; }
        public double IOF { get; set; }
        public DateTime PrazoDecrescimo { get; set; }
        public int PeriodicidadePagamento { get; set; }
        public int? TempoPagamentoAntecipado { get; set; }
        public double CapitalSeguradoOriginal { get; set; }
    }

    public class Coberturas
    {
        public List<CoberturaContratada> CoberturaContratada { get; set; }
    }

    public class ProdutoresParticipantes
    {
        public ProdutorParticipante? ProdutorParticipante { get; set; }
    }

    public class ProdutorParticipante
    {
        public int CodigoProdutor { get; set; }
        public int TipoCodigo { get; set; }
        public int TipoProdutor { get; set; }
        public double PercentualDivisao { get; set; }
    }

    public class Proposta
    {
        public string AcaoMarketing { get; set; }
        public string ModeloProposta { get; set; }
        public string ConvenioAdesao { get; set; }
        public string NumeroAlternativa { get; set; }
        public int TipoAngariacaoId { get; set; }
    }

    public class Root
    {
        public Cliente Cliente { get; set; }
    }
}
