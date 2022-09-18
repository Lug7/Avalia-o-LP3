namespace Av1.ViewModels;

public class Estabelecimento
{
    public int Id { get; set; }
    public int Piso { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public string Email { get; set; }
    public bool Tipo { get; set; }

    public Estabelecimento(int id, int piso, string nome, string descricao, string email, bool tipo)
    {
        Id = id;
        Piso = piso;
        Nome = nome;
        Descricao = descricao;
        Email = email;
        Tipo = tipo;
    }

}