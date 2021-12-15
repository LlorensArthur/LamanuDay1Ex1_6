string Name;
string Surname;
int BirthYear;
Console.WriteLine("Veuillez indiquer votre nom de famille");
Name = Console.ReadLine();
Console.WriteLine("Veuillez indiquer votre prénom");
Surname = Console.ReadLine();
Console.WriteLine("Veuillez indiquer votre date de naissance");
while(!int.TryParse(Console.ReadLine(), out BirthYear)){
    Console.WriteLine("Veuillez entrer uniquement un nombre.");
}
BirthYear = DateTime.Now.Year - BirthYear;
Console.WriteLine("Appuyez sur entrée pour afficher votre fiche de renseignement");
Console.ReadLine();
Console.WriteLine($"Fiche de renseignement\n" +
    $"* Nom : {Name} \n" +
    $"* Prénom : {Surname} \n" +
    $"* Age : {BirthYear} ans");