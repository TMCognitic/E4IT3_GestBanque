namespace GestBanque.Models
{
    public class Epargne : Compte
    {
        private DateTime _dernierRetrait;

        public DateTime DernierRetrait
        {
            get
            {
                return _dernierRetrait;
            }

            private set
            {
                _dernierRetrait = value;
            }
        }

        public Epargne(string numero, Personne titulaire)
            : base(numero, titulaire)
        {
        }

        public Epargne(string numero, Personne titulaire, double solde, DateTime dernierRetrait)
            : base(numero, titulaire, solde)
        {
            DernierRetrait = dernierRetrait;
        }

        public override double CalculInteret()
        {
            return Solde * .045;
        }

        public override void Retrait(double montant)
        {
            double oldSolde = Solde;
            base.Retrait(montant);

            if (Solde != oldSolde)
            {
                DernierRetrait = DateTime.Now;
            }
        }
    }
}
