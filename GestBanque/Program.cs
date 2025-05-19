// See https://aka.ms/new-console-template for more information
using GestBanque.Models;

Personne johnDoe = new Personne()
{
    Nom = "Doe",
    Prenom = "John",
    Anniversaire = new DateTime(1970, 01, 01)
};


Courant courant = new Courant("Test001", 500, johnDoe);

Epargne epargne = new Epargne("Test002", johnDoe);

List<Compte> _comptes = new List<Compte>() { courant, epargne };

Console.WriteLine($"Compte numéro '{courant.Numero}' de {courant.Titulaire.Prenom} {courant.Titulaire.Nom}");
courant.Depot(-500);
Console.WriteLine($"Solde : {courant.Solde}");
courant.Depot(500);
Console.WriteLine($"Solde : {courant.Solde}");
courant.Retrait(-100);
Console.WriteLine($"Solde : {courant.Solde}");
courant.Retrait(100);
Console.WriteLine($"Solde : {courant.Solde}");
courant.Retrait(900);
Console.WriteLine($"Solde : {courant.Solde}");
courant.Retrait(100);
Console.WriteLine($"Solde : {courant.Solde}");

Console.WriteLine();
Console.WriteLine($"Compte numéro '{epargne.Numero}' de {courant.Titulaire.Prenom} {courant.Titulaire.Nom}");
epargne.Depot(500);
Console.WriteLine($"Solde : {epargne.Solde}");
epargne.Retrait(100);
Console.WriteLine($"Solde : {epargne.Solde}");
epargne.Retrait(500);
Console.WriteLine($"Solde : {epargne.Solde}");

Console.WriteLine();
foreach (Compte compte in _comptes)
{
    Console.WriteLine($"Compte numéro '{compte.Numero}' de {compte.Titulaire.Prenom} {compte.Titulaire.Nom}");
    Console.Write($"Solde : {compte.Solde}");
    Console.Write($" - Intérêts : {compte.CalculInteret()}");

    switch (compte)
    {
        case Courant c:
            Console.WriteLine($" - Ligne de crédit : {c.LigneDeCredit}");
            break;
        case Epargne e:
            Console.WriteLine($" - Date de dernier retrait : {e.DernierRetrait:dd-MM-yyyy}");
            break;
    }
}