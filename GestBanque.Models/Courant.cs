namespace GestBanque.Models
{
    public class Courant
    {
        public string numero;
        public double solde;
        public double ligneDeCredit;
        public Personne titulaire;

        public void Depot(double montant)
        {
            Console.WriteLine($"Dépot de {montant} demandé...");
            if(montant <= 0)
            {
                Console.WriteLine("montant invalide");
                return;
            }
            
            solde = solde + montant;            
        }

        public void Retrait(double montant)
        {
            Console.WriteLine($"Retrait de {montant} demandé...");
            if (montant <= 0)
            {
                Console.WriteLine("Le montant est invalide");
                return;
            }

            if(solde - montant < -ligneDeCredit)
            {
                Console.WriteLine("Solde insuffisant");
                return;
            }
            
            solde = solde - montant;            
        }
    }
}
