using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c3pochallenge
{
    class Program
    {
        public static void Main(string[] args) {

            Program p = new Program();


            Console.WriteLine("Digite 1: ");
            Console.WriteLine("Calcule a soma dos números de 1 a 1000 que sejam divisíveis por 3 ou 5");
            Console.WriteLine("Digite 2: ");
            Console.WriteLine("Monte um dicionário com a chave do tipo int e valor do tipo List<int>");
            Console.WriteLine("Digite 3: ");
            Console.WriteLine("Projete o código que verifica se a pessoa é maior de idade");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    p.calcSum();
                    break;
                case "2":
                    p.dictionary();
                    break;
                case "3":
                    p.calcAge();
                    break;
            }
        }

        public void calcSum() {

            int aux = 0;

            for (int i = 1; i < 1001; i++)
            {

                if (i % 3 == 0 || i % 5 == 0)
                {
                    aux = aux + i;
                }

            }

            Console.WriteLine("Soma de todos divisores de 3 e 5 ate 1000: " + aux);
            Console.ReadLine();

        }

        public void dictionary() {

            Dictionary<int, List<int>> elements = new Dictionary<int, List<int>>();

            int aux = 0;

            for (int i = 0; i < 1000; i++) {
                

                elements.Add(i, new List<int>{aux, ++aux, ++aux});
                aux = aux + 2;
                
            }

            foreach (int key in elements.Keys)
            {
                Console.Write("{0} ,", key);
                foreach (int item in elements[key])
                {
                    Console.Write("{0}, ", item);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
           

        }

        public void calcAge() {
            DateTime birthdate;
            Console.WriteLine("Digite a data de nascimento no formato: 01/01/2000: ");
            string input = Console.ReadLine();



            while (!DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out birthdate))
            {

                Console.WriteLine("Data inválida, digite novamente");
                input = Console.ReadLine();
            }

            int age = DateTime.Now.Year - birthdate.Year;

            if (birthdate > DateTime.Now.AddYears(-age)) {
                age--;
            }

            if (age > 17)
            {
                Console.WriteLine("Permitido entrar no cinema pois é maior de idade");
                Console.ReadLine();
            }else{
                Console.WriteLine("Proíbido entrar no cinema pois é menor de idade.");
                Console.ReadLine();
            }

        }
    }
}
