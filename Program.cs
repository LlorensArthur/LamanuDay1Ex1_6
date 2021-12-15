string Name;
string Surname;
int BirthYear = 0;
Console.WriteLine("Veuillez indiquer votre nom de famille");
Name = Console.ReadLine();
Console.WriteLine("Veuillez indiquer votre prénom");
Surname = Console.ReadLine();
Console.WriteLine("Veuillez indiquer votre date de naissance");
bool yearIsValid = false;
while (!yearIsValid)
{
    yearIsValid = true;
    if (!int.TryParse(Console.ReadLine(), out BirthYear))
    {
        Console.WriteLine("Veuillez entrer uniquement un nombre.");
        yearIsValid = false;
    }
    if (BirthYear >= DateTime.Now.Year)
    {
        Console.WriteLine("Veuillez entrer uniquement une date de naissance valide.");
        yearIsValid = false;
    }
}
BirthYear = DateTime.Now.Year - BirthYear;
Console.WriteLine("Appuyez sur entrée pour afficher votre fiche de renseignement");
Console.ReadLine();
Console.WriteLine($"Fiche de renseignement\n" +
$"* Nom : {Name} \n" +
$"* Prénom : {Surname} \n" +
$"* Age : {BirthYear} ans");