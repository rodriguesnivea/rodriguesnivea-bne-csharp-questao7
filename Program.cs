using questao07;
using System;
class Program
{
    static void Main()
    {
        calculaEPrintaRendimento(1000.00, 0.03);
        calculaEPrintaRendimento(5500.00, 0.0248);
        calculaEPrintaRendimento(12000.00, 0.02);
    }

    private static void calculaEPrintaRendimento(double valorPresente, double taxaDeJuros)
    {
        Banco banco = new Banco(valorPresente, taxaDeJuros);
        banco.PrintaTabela();
        for (int i = 1; i <= 8; i++)
        {
            banco.RendeMes();
        }
        banco.RendePeriodo(10);
        
    }
}
