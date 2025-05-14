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

Epargne epargne = new Epargne()
{
    Numero = "Test002",
    Titulaire = johnDoe
};


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
