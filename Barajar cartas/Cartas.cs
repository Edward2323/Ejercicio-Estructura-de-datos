﻿namespace Ejercicio
{
    public class Carta
    {
        public int numero {  get; }

        public string palo { get; }

        public Carta(int numero, string palo)
        {
            this.numero = numero;
            this.palo = palo;
        }
    }
}
