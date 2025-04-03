namespace lesson         //tipo Cartella 
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)       //metodo static,metodo richiamato dalla classe in automatico
                                                    //quando ce static messo da qualche parte, vuol dire che la funzione(metodo)
                                                    //e' divisa tra tutte le istanze della classe
        {
            //Esercizio();
            //Esercizio2();
            Esercizio3();
        }

        /// <summary>
        /// Visualizzare 100 numeri pari partendo dal numero 2
        /// </summary>
        private static void Esercizio()          //private non e' visibile negli altri file, privato tutto quello private in classe prgram

        {
            for (int c = 2; c <= 200; c+=2)
            {
                //Console.WriteLine(c.ToString());
                //Console.WriteLine($"{c}");
                Console.WriteLine(c);

            }
        }
        /// <summary>
        /// Calcolare il fattoriale di un numero n in ingresso
        /// </summary>
        private static int Esercizio2() 
        {
            int n,n2;
            int fat=1;
            Console.Write("Inserire il numero di cui devo calcolare il fattoriale: ");
            try
            {
                n=Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Input non valido");
                return 1;
            }

            n2 = n;
            while ((n)>1)
            {
                fat *= n;
                n -= 1;
            }
            if (n2 >= 0)
                Console.WriteLine($"Il fattoriale del numero {n2} e' {fat}");
            if (n2 < 0)
                Console.WriteLine($"Il fattoriale del numero {n2} non e' permesso");
            return 0;
        }
        /// <summary>
        /// Converte un numero binario nel numero intero decimale corrispondente
        /// </summary>
        private static void Esercizio3()
        {

            Console.Write("Inserisci numero binario: ");
            string line=(Console.ReadLine());
            double result=0;
            for (int c=0;c<line.Length;c++)
            {
                int currentExp = Convert.ToInt32(line[c]-'0');
                if (currentExp==1)
                    result += currentExp * (Math.Pow(2, line.Length - c - 1));
            }
            Console.WriteLine($"Il decimale del numero binario inserito e': {result}");
        }
        
    }
}
