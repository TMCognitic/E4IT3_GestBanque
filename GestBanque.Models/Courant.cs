namespace GestBanque.Models
{
    public class Courant
    {
        private string _numero;
        private double _solde;
        private double _ligneDeCredit;
        private Personne _titulaire;

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
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

        public double LigneDeCredit
        {
            get
            {
                return _ligneDeCredit;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Valeur incorrecte pour la Ligne de crédit");
                    return;
                }

                _ligneDeCredit = value;
            }
        }

        public Personne Titulaire
        {
            get
            {
                return _titulaire;
            }

            set
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

        public void Retrait(double montant)
        {
            Console.WriteLine($"Retrait de {montant} demandé...");
            if (montant <= 0)
            {
                Console.WriteLine("Le montant est invalide");
                return;
            }

            if (Solde - montant < -LigneDeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                return;
            }

            Solde = Solde - montant;
        }
    }
}
