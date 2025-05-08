namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Family ivanovi = new Family();

            Person p=new Person("Ivan",22,"Adress 1");
            Person q = new Person("Kiko", 22, "Adress 2");

            ivanovi.AddMember(p);
            ivanovi.AddMember(q);

            ivanovi.Print();
        }
    }
}
