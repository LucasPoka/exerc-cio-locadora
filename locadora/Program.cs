using locadora;
class Program
{
    static void Main(string[] args)
    {
        string controle = "s";
        int escolha;
        int dias;

        while (controle == "s" || controle == "S")
        {
            Console.WriteLine("Insira o tipo de veículo que deseja: [1] Carro, [2] Moto");
            escolha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira a quantidade de dias de aluguel do veículo: ");
            dias = Convert.ToInt32(Console.ReadLine());
            //recebe a quantidade de diárias informada pelo user, mas atende a parte B do enunciado

            switch (escolha)
            {
                case 1:
                    Carro gol = new Carro(50);
                    gol.CalcularValorTotal(dias);
                    break;
                case 2:
                    Moto hondaBiz = new Moto(25);
                    hondaBiz.CalcularValorTotal(dias);
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;

            }
            Console.WriteLine("Deseja efetuar um novo cálculo: (s/n)");
            controle = Console.ReadLine();
        }





    }
}