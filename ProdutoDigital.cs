class ProdutoDigital : Produto, IExpiravel
{
    private string linkDownload;

    public DateTime DataCompra { get; }
    public ProdutoDigital(string nome, string descricao, decimal preco, string imagem, string linkdDownload) : base(nome, descricao, preco, imagem)
    {
        this.LinkDownload = linkdDownload;
        this.DataCompra = DateTime.Now;
    }

    public string LinkDownload
    {
        get
        {
            return linkDownload;
        }
        set
        {
            if (value.Length > 0)
            {
                linkDownload = value;
            }

        }
    }

    public bool EstaExpirado() 
    {
        return DateTime.Now > DataCompra.AddYears(2);
    }
}
