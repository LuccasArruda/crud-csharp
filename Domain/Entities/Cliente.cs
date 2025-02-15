namespace CRUD.Domain.Entities;

public class Cliente
{
    private string _nome; 
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }
    
    private string _email;
    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    private string _telefone;
    private string Telefone
    {
        get { return _telefone; }
        set { _telefone = value; }
    }

    private Produto[] carrinho;

    public Produto[] Carrinho
    {
        get { return carrinho; }
    }

    public Cliente(string nome, string email, string telefone)
    {
        this._nome = nome;
        this._email = email;
        this._telefone = telefone;
        this.carrinho = [];
    }

    public void DescreverCliente()
    {
        Console.WriteLine($"Nome: {this._nome};\nEmail: {this._email};\nTelefone: {this._telefone}");
    }

    public void AdicionarNoCarrinho(Produto produto)
    {
        if (!carrinho.Contains(produto))
        {
            carrinho.Add(produto);
        }
        else
        {
            Console.WriteLine($"O produto {produto.Nome} já está no carrinho.");
        }
    }
}