namespace CRUD.Domain.Entities;

public class Fornecedor
{
    public string Nome {get; set;}

    public string Cnpj {get; set;}
    
    public string Telefone {get; set;}
    
    public string Email {get; set;}

    public string Cep {get; set;}

    public Fornecedor(string nome, string cnpj, string telefone, string email, string cep){
        this.Nome = nome;
        this.Cnpj = cnpj;
        this.Telefone = telefone;
        this.Email = email;
        this.Cep = cep;
    }
    
    public void CadastrarFornecedor(){}
}