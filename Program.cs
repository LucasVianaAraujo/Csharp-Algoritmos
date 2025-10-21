namespace CsharpAD04;

class Program
{
    static void Main(string[] args)
    {
        ApresentarPrograma();

        Calculo();
    }

    public static void ApresentarPrograma()
    {
        Console.WriteLine("-- PROGRAMA DO ORÇAMENTO FAMILIAR --");
    }

    public static void Calculo()
    {
        Console.WriteLine("Informe o total de ganhos");
        int Ganhos = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe o total de gastos");
        int Gasto = Convert.ToInt32(Console.ReadLine());

        double CalcularPorcentagem = ((double)Gasto / Ganhos) * 100;

        if (Gasto >= Ganhos)
        {
            Console.WriteLine("Orçamento comprometido! Hora de rever seus gastos!");
        }

        else if (CalcularPorcentagem >= 81 && CalcularPorcentagem <= 100)
        {
            Console.WriteLine("Cuidado, seu orçamento pode ficar comprometido!");
        }

        else if (CalcularPorcentagem >= 51 && CalcularPorcentagem <= 80)
        {
            Console.WriteLine("Atenção, melhor conter os gastos!");
        }

        else if (CalcularPorcentagem >= 21 && CalcularPorcentagem <= 50)
        {
            Console.WriteLine("Muito bem, seus gastos não ultrapassam metade dos ganhos!");
        }

        else if (CalcularPorcentagem >= 0 && CalcularPorcentagem <= 20)
        {
            Console.WriteLine("Parabéns, está gerenciando bem seu orçamento!");
        }

    }
}