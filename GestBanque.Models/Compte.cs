
namespace GestBanque.Models
{
    public abstract class Compte : ICustomer, IBanker
    {
        private string _numero;
        private double _solde;
        private Personne _titulaire;

        public string Numero
        {
            get
            {
                return _numero;
            }

            private set
            {
                _numero = value;
            }
        }

        public double Solde
        {
            get
            {
                return _solde;
            }

            private set
            {
                _solde = value;
            }
        }

        public Personne Titulaire
        {
            get
            {
                return _titulaire;
            }

            private set
            {
                _titulaire = value;
            }
        }

        public void Depot(double montant)
        {
            Console.WriteLine($"Dépot de {montant} demandé...");
            if (montant <= 0)
            {
                Console.WriteLine("montant invalide");
                return;
            }

            Solde = Solde + montant;
        }

        protected Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }

        protected Compte(string numero, Personne titulaire, double solde)
            : this (numero, titulaire)
        {
            Solde = solde;
        }

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0);
        }

        protected void Retrait(double montant, double ligneDeCredit)
        {
            Console.WriteLine($"Retrait de {montant} demandé...");
            if (montant <= 0)
            {
                Console.WriteLine("Le montant est invalide");
                return;
            }

            if (Solde - montant < -ligneDeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                return;
            }

            Solde = Solde - montant;
        }

        public abstract double CalculInteret();
    }
}