using PrototypeMethod.VirusLibrary;

Virus fileInfector = new Virus("Wlndows", 273, "Boot Sector", null!);

VirusChild child1 = new VirusChild("not_virus__dont_delete", 50, 
    "Resident", null, DateTime.Now, fileInfector);
VirusChild child2 = new VirusChild("fkdl345&$%#@", 42, 
    "Polymorphic", null, DateTime.Now, fileInfector);

fileInfector.Children = new List<VirusChild> { child1, child2 };

Console.WriteLine(fileInfector);

Virus fileInfectorCopy = (fileInfector.Clone() as Virus)!;
fileInfector.Children.Clear();
fileInfector.Name = "wlndows_origin";
fileInfectorCopy.Name = "wlndows_copy";
Console.WriteLine(fileInfector);
Console.WriteLine(fileInfectorCopy);