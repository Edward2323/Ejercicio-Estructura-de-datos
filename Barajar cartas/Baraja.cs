namespace Ejercicio.Barajar_cartas
{
    public class Baraja
    {
        Carta[] cartas = new Carta[40];
        string palo = "";
        int numero = 1;

        public Baraja()
        {
            for (int i = 0; i < cartas.Length; i++)
            {

                if (i <= 9)
                    palo = "oro";

                if (i > 9 && i <= 19)
                    palo = "basto";

                if (i > 19 && i <= 29)
                    palo = "copa";

                if (i > 29 && i <= 39)
                    palo = "espada";

                if (numero > 12)
                    numero = 1;

                if (numero == 8)
                    numero = 10;

                cartas[i] = new Carta(numero, palo);
                numero++;
            }
        }

        public void Barajar()
        {
            Random rnd = new Random();

            for (int i = cartas.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1); 

                var temp = cartas[i];
                cartas[i] = cartas[j];
                cartas[j] = temp;
            }
        }

        public void Repartir(int jugadores)
        {
            List<Carta> listcartas = this.cartas.ToList();

            for (int i = 0; i <= jugadores - 1; i++)
            {
                Console.WriteLine("=================Jugador================ " + i + "\n");

                for (int j = 0; j <= 2; j++)
                {
                    Console.WriteLine(listcartas[0].palo +  ", " + listcartas[0].numero);
                    listcartas.Remove(listcartas[0]);
                }
            }

            Console.WriteLine("\n============================Palo triunfo: " + listcartas[0].palo + ", " + listcartas[0].numero);
            listcartas.Remove(listcartas[0]);

            Console.WriteLine("\n ================Baraja==============");
            foreach (Carta carta in listcartas)
            {
                Console.WriteLine(carta.palo + ", " + carta.numero);
            }

        }
    }
}
