using Part_1.Classes;

Dog Vucko = new Dog("Bucko", 6, "male", "black");
Vucko.PrintAnimal();
Vucko.Bark();
string VuckoInfo = Vucko.PrintAnimal();
Console.WriteLine(VuckoInfo);

Cat Satan = new Cat("Satan", 2, "female", "red");
Satan.PrintAnimal();
Satan.Eat("people");
string SatanInfo = Satan.PrintAnimal();
Console.WriteLine(SatanInfo);