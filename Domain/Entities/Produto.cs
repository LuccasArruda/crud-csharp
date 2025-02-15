namespace CRUD.Domain.Entities;

public class Produto
{
    private int _id;
    private string _nome;
    private string _descricao;
    private double _valor;
    
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    
    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Descricao
    {
        get { return _descricao; }
        set { _descricao = value; }
    }

    public double Valor
    {
        get { return _valor; }
        set { _valor = value; }
    }

    public Produto(int id, string nome, string descricao, double valor)
    {
        this.Id = id;
        this.Nome = nome;
        this.Descricao = descricao;
        this.Valor = valor;
    }
}