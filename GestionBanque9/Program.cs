using GestionBanque9.Models;

// Création de ma personne
Personne personne = new Personne("Smith","Jhon",new DateTime(1955, 11, 08));

// création de plisueurs compte apartenant a la personne
Courant comptePersonne = new Courant( "000-000-000-01", personne);

Courant compte2Personne = new Courant(numero: "000-000-000-02", titulaire: personne);

Epargne compte3Personne = new Epargne("000-000-000-03",personne);

// Depot sur les différents comptes de la personne
comptePersonne.Depot(500);
compte2Personne.Depot(800);
compte3Personne.Depot(1200);
compte3Personne.Retrait(600);


// Création de la banque + ajout des compte de la personne
Banque banque = new Banque();

banque.Ajouter(comptePersonne);
banque.Ajouter(compte2Personne);

// Utilisation de la méthodes AvoirDesComptes pour avoir le total de tout les comptes => Avant Application interets
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Avant Application interets :");
Console.WriteLine($"Somme des avoir du compte de la personne : {banque.AvoirDesComptes(personne)} Eur.");
Console.WriteLine($"La date du dernier retrait du compte epargne est : {compte3Personne.DernierRetrait}");
Console.WriteLine("-----------------------------------------------------------");

// Application des interets  sur les comptes
foreach (KeyValuePair<string, Compte> item in banque.Comptes)
{
    item.Value.AppliquerInteret();
}

// Utilisation de la méthodes AvoirDesComptes pour avoir le total de tout les comptes => => Après Application interets
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Après Application interets :");
Console.WriteLine($"Somme des avoir du compte de la personne : {banque.AvoirDesComptes(personne)} Eur.");
Console.WriteLine($"La date du dernier retrait du compte epargne est : {compte3Personne.DernierRetrait}");
Console.WriteLine("-----------------------------------------------------------");
