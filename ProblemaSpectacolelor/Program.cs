using System;
using System.IO;
using System.Collections.Generic;

namespace ProblemaSpectacolelor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Spectacol> lista=new List<Spectacol>();
            TextReader load = new StreamReader(@"C:\Users\Nicu\source\repos\AlgoritmiFundmentaliExamen\ProblemaSpectacolelor\TextFile1.txt");
            string buffer;
            while (( buffer=load.ReadLine())!=null)
            {
                int start=int.Parse(buffer.Split(' ')[0]);
                int end=int.Parse(buffer.Split(' ')[1]);
                lista.Add(new Spectacol(start,end));
            }
            // sortam  lista
            for (int i = 0; i < lista.Count-1; i++)
            {
                for (int j = 1+i; j < lista.Count; j++)
                {
                    if (lista[i].start>lista[j].start)
                    {
                        (lista[i], lista[j]) = (lista[j], lista[i]);
                    }
                }
            }
            // determinam numarul maxim de spectacole
            int nrmax = 0;
            List<Spectacol> listaFinala=new List<Spectacol>();
            listaFinala.Add(lista[0]);
            for (int i = 1; i < lista.Count; i++)
            {
                if (listaFinala[nrmax].end<=lista[i].start)
                {
                    listaFinala.Add(lista[i]);
                    nrmax++;
                }
            }
            nrmax++;


            //lista ordonata
            Console.WriteLine("Lista initiala ordonata:");
            foreach (var item in lista)
            {
                item.View();
            }
            //lista de spectacole
            Console.WriteLine("Lista finala de spectacole:");
            foreach (var item in listaFinala)
            {
                item.View();
            }
            //nr max
            Console.WriteLine("nr max : " + nrmax);
        }
    }
    public class Spectacol
    {
        public int start;
        public int end;
        public Spectacol(int start, int end)
        {
            this.start = start;
            this.end = end;
        }
        public void View()
        {
            Console.WriteLine(start + " "+ end);
        }
    }
}
