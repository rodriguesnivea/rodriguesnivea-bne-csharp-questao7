using questao07;
using System;
class Program
{
    static void Main()
    {
        calculaEPrintaRendimento(1000.00, 3.00);
        calculaEPrintaRendimento(5500.00, 2.48);
        calculaEPrintaRendimento(12000.00, 2.00);
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
