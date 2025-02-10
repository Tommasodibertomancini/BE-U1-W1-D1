
namespace BE_U1_W1_D1
{
    internal class Atleta
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }

        public Atleta (string firstName, string lastName, int age, string sport)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Sport = sport;
        }

        public void showAthlete()
        {
            Console.WriteLine("nome: " +  FirstName +" "+ "cognome: " + LastName + " " + "age: " + Age + " " + "sport: " + Sport);        }
    }


}
