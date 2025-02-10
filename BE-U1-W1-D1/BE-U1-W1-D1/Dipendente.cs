


namespace BE_U1_W1_D1
{
    internal class Dipendente
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }

        public Dipendente(string firstName, string lastName, int age, string job)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Job = job;
        }

        public void showDipendente()
        {
            Console.WriteLine("nome: " + FirstName + " " + "cognome: " + LastName + " " + "age: " + Age + " " + "job: " + Job);
        }
    }


}

