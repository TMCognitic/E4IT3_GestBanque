// See https://aka.ms/new-console-template for more information
using GestBanque.Models;

Personne johnDoe = new Personne()
{
    Nom = "Doe",
    Prenom = "John",
    Anniversaire = new DateTime(1970, 01, 01)
};


Courant courant = new Courant()
{
    Numero = "Test001",
    Titulaire = johnDoe,
    LigneDeCredit = 500
};


Console.WriteLine($"Compte numéro '{courant.Numero}' de {courant.Titulaire.Prenom} {courant.Titulaire.Nom}");
courant.Depot(-500);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
courant.Depot(500);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
courant.Retrait(-100);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
courant.Retrait(100);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
courant.Retrait(900);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
courant.Retrait(100);
Console.WriteLine($"Nouveau solde : {courant.Solde}");
