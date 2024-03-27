using Class__inheritiance.Models;

namespace Class__inheritiance;


internal class Program
{
    static void Main(string[] args)
    {
        Person studentOne = new Person("Kamil", "Gahramanov", "AB106", 100);
        studentOne.GetInfo();
        studentOne.CheckGraduation();
        studentOne.GetDiplomDegree();

        Console.WriteLine();

        Person studentTwo = new Person("Anar", "Amanli", "AB106", 100);
        studentTwo.GetInfo();
        studentTwo.CheckGraduation();
        studentTwo.GetDiplomDegree();

        Person studentThree = new Person("Rauf", "Dostuyev", "AB106", 75);
        studentThree.GetInfo();
        studentThree.CheckGraduation();
        studentThree.GetDiplomDegree();

        Person studentFour = new Person("Sahib", "Memmedov", "AB106", 55);
        studentFour.GetInfo();
        studentFour.CheckGraduation();
        studentFour.GetDiplomDegree();
    }
}
