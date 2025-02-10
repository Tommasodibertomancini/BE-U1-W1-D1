
namespace BE_U1_W1_D1
{
    internal class Animale
    {
        public string FirstName { get; set; }
        public string Tipologia { get; set; }
        public string Razza { get; set; }
        public int Age { get; set; }

        public Animale(string firstName, string tipologia, string razza, int age)
        {
            FirstName = firstName;
            Tipologia = tipologia;
            Razza = razza;
            Age = age;
        }

        public void showAnimale()
        {
            Console.WriteLine("nome: " + FirstName + " " + "tipologia: " + Tipologia + " " + "razza: " + Razza + " " + "age: " + Age);
        }
    }


}

