namespace Course.src.Entities
{
    class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Estudante(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}

/*
            Estudante[] estudante = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nAluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                estudante[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("\nQuartos ocupados: ");
            for (int i = 0; i < estudante.Length; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine($"{i}: {estudante[i]}");
                }
            }
*/