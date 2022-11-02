using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Globalization;

namespace questao07
{
    internal class Banco
    {
        private double _valorInvestido;
        private double _taxaDeJuros;
        private double _mes;
        private double _valorAtual;
        private double _rendimentoMensal;
        private double _resgate;
        private double _rendaLiquida;

        public Banco(double valorInvestido, double taxaDeJuros)
        {
            _valorInvestido = valorInvestido;
            _taxaDeJuros = taxaDeJuros;
            _mes = 0;
            _valorAtual = valorInvestido;
            _rendimentoMensal = 0.0;
            _resgate = 0.0;
            _rendaLiquida = 0.0;
        }

        public void RendeMes()
        {
            _mes++;
            CalculoRendimento();
        }

        public void RendePeriodo(double dias)
        {
            double periodo = dias / 30;
            _valorAtual *= Math.Pow((1 + _taxaDeJuros), periodo);
            _rendimentoMensal = _valorAtual - _valorInvestido - _rendaLiquida;
            _rendaLiquida += _rendimentoMensal;
            _mes += periodo;
            Console.WriteLine(this);
        }

        private void CalculoRendimento()
        {
            _valorAtual *= (1 + _taxaDeJuros);
            _rendimentoMensal = _valorAtual - _valorInvestido - _rendaLiquida;
            _rendaLiquida += _rendimentoMensal;
            if (_mes == 5)
            {
                _resgate = _rendimentoMensal;
                _rendaLiquida -= _resgate;
                _valorAtual -= _resgate;
            }
            Console.WriteLine(this);
            _resgate = 0.0;
     
        }

        public void PrintaTabela()
        {
            Console.WriteLine(" ____________________________________________________________________________________________________________________________________");
            Console.WriteLine("| valor Investido | Taxa de Juros    | Periodo(a.m)    |  Valor Atual       | Rendimento(a.m)  |  Resgate        |  RendaL(a.m)       |");
            Console.WriteLine("|_________________|__________________|_________________|____________________|__________________|_________________|____________________|");

        }
        public override string ToString()
        {
            return
                "|______"
                 + _valorInvestido.ToString("#,##")
                 + "______|______ "
                 + _taxaDeJuros.ToString("F2", CultureInfo.InvariantCulture)
                 + "%______|______ "
                 + _mes.ToString("F2", CultureInfo.InvariantCulture)
                 + "______|______ "
                 + _valorAtual.ToString("F2", CultureInfo.InvariantCulture)
                 + "______|______ "
                 + _rendimentoMensal.ToString("F2", CultureInfo.InvariantCulture)
                 + "______|______ "
                 + _resgate.ToString("F2", CultureInfo.InvariantCulture)
                 + "______|______ "
                 + _rendaLiquida.ToString("F2", CultureInfo.InvariantCulture)
                 + "______|"
                 + " ";
        }


    }
}