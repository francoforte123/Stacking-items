Console.WriteLine("scegli le varie opzioni: \n1)Push;\n2)Pop;\n3)Peek.");

int Option = int.Parse(Console.ReadLine());

Stack<string> ListOfNames = new();
ListOfNames.Push("Marco");
ListOfNames.Push("Luca");
ListOfNames.Push("Anna");

if (Option == 1)
{
    Console.Write("inserisci un nuovo nome: ");
    string NewName = Console.ReadLine();

    ListOfNames.Push(NewName);

    Console.WriteLine("lista completa con il nuovo nome:");
    foreach (string names in ListOfNames)
    {
        Console.WriteLine(names);
    }
}
else if (Option == 2)
{
    string restOfList = ListOfNames.Pop();
    Console.WriteLine("sto rimuovendo l'ultimo nome dalla lista " + restOfList);
}
else if (Option == 3)
{
    string name = ListOfNames.Peek();
    Console.WriteLine("sto prendendo l'ultimo nome della lista " + name);
}