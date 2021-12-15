string Name;
string Surname;
int BirthYear;
Console.WriteLine("Veuillez indiquer votre nom de famille");
Name = Console.ReadLine();
Console.WriteLine("Veuillez indiquer votre prénom");
Surname = Console.ReadLine();
Console.WriteLine("Veuillez indiquer votre date de naissance");
BirthYear = Int32.Parse(Console.ReadLine());
BirthYear = DateTime.Now.Year - BirthYear;
Console.WriteLine("Appuyez sur entrée pour afficher votre fiche de renseignement");
Console.ReadLine();
Console.WriteLine($"Fiche de renseignement\n" +
    $"* Nom : {Name} \n" +
    $"* Prénom : {Surname} \n" +
    $"* Age : {BirthYear} ans");