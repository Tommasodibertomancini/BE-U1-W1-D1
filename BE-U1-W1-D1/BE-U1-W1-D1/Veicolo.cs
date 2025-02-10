
namespace BE_U1_W1_D1
{
    internal class Veicolo
    {
        public string Marca { get; set; }
        public string Modello { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Veicolo(string marca, string modello, int year, string color)
        {
            Marca = marca;
            Modello = modello;  
            Year = year;
            Color = color;

        }

        public void showVeicolo()
        {
            Console.WriteLine("marca: " + Marca + " " + "modello: " + Modello + " " + "year: " + Year + " " + "color: " + Color);
        }
    }


}
