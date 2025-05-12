// See https://aka.ms/new-console-template for more information
using GestBanque.Models;

Personne johnDoe = new Personne();
johnDoe.nom = "Doe";
johnDoe.prenom = "John";
johnDoe.anniversaire = new DateTime(1970, 01, 01);

Courant courant = new Courant();
courant.numero = "Test001";
courant.titulaire = johnDoe;
courant.ligneDeCredit = 500;

courant.Depot(-500);
Console.WriteLine($"Nouveau solde : {courant.solde}");
courant.Depot(500);
Console.WriteLine($"Nouveau solde : {courant.solde}");
courant.Retrait(-100);
Console.WriteLine($"Nouveau solde : {courant.solde}");
courant.Retrait(100);
Console.WriteLine($"Nouveau solde : {courant.solde}");
courant.Retrait(900);
Console.WriteLine($"Nouveau solde : {courant.solde}");
courant.Retrait(100);
Console.WriteLine($"Nouveau solde : {courant.solde}");
