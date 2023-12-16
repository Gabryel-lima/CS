// struct Lista1 {
//     public string JS;
//     public string CSharp;
//     public string Java;

//     public Lista1(string js, string cSharp, string java)
//     {
//         JS = js;
//         CSharp = cSharp;
//         Java = java;
//     }
// }

class Program1 {
    static void Nota() {
        System.Console.Write("\nDigite um número: ");
        string NotaMedia = System.Console.ReadLine()!;
        int Nota = int.Parse(NotaMedia);

        switch (Nota) {
            case >= 5:
                System.Console.WriteLine("Nota suficiente para aprovação!");
                break;
            default:
                System.Console.WriteLine("Tu é idiota!");
                break;
        }   
    }

    static void Main() {
        Nota();
    }
}
