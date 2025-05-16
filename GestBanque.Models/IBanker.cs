namespace GestBanque.Models
{
    public interface IBanker : ICustomer
    {
        string Numero { get; }
        Personne Titulaire { get; }

        double CalculInteret();
    }
}