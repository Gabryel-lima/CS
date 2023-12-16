

class Program2 {
    static void Game() {
        Random random = new Random();
        int numero_r = random.Next(1,101);

        do {

            Console.Write("\nDigite um número entre 1 e 100: ");
            int chute = int.Parse(Console.ReadLine()!);

                if(chute == numero_r) {
                    Console.WriteLine("\nParabéns! Você acertou o número.");
                    break;

                } else if(chute < numero_r) {
                    Console.WriteLine("\nO número é maior.");

                } else {
                    Console.WriteLine("\nO número é menor.");
            }

        } while(true);
    }
    static void Main() {
        Game();
    }
}



