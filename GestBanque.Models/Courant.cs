namespace GestBanque.Models
{
    public class Courant : Compte
    {
        private double _ligneDeCredit;

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

        public Courant(string numero, Personne titulaire)
            : base(numero, titulaire)
        {
        }

        public Courant(string numero, Personne titulaire, double solde)
            : base(numero, titulaire, solde)
        {
        }

        public Courant(string numero, double ligneDeCredit, Personne titulaire)
            : base(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }

        public override double CalculInteret()
        {
            //opérateur ternaire ((condition) ? expr1 : expr2)
            return Solde * ((Solde < 0) ? 0.0975 : 0.03);
        }

        public override void Retrait(double montant)
        {
            Retrait(montant, LigneDeCredit);
        }
    }
}
