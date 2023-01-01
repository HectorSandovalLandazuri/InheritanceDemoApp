// See https://aka.ms/new-console-template for more information
using InheritanceDemo;

Car car =new Car();
car.NumberOfDoors = 4;
car.NumberOfWheels = 4;
Corolla corolla = new Corolla();
Boat boat=new Boat();

List<Phone> phones = new List<Phone>();
phones.Add(new Cellphone());
phones.Add(new SmartPhone());
foreach(Phone phone in phones)
{
    if (phone is Cellphone cell)
    {
        cell.Carrier = "";
    }
    if (phone is SmartPhone smartphone)
    {
        smartphone.ConnectToInternet();
    }

}
