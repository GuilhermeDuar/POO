using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteOO.Prova_02._07
{
    
    public class EntradaCinema
    {
        public double ValorDaEntrada { get; private set; }
        public string NomeDoFilme { get; private set; }
        public int CodigoDaCadeira { get; private set; }
        public double DuracaoDoFilme { get; set; }
        
        public EntradaCinema(string nome, double valorEntrada, int cadeira, double duracao)
        {
            this.NomeDoFilme = nome;
            this.ValorDaEntrada = valorEntrada;
            this.CodigoDaCadeira = cadeira;
            this.DuracaoDoFilme = duracao;
        }

        public double CalcularValorAPagar(int idade)
        {
            double valor = this.ValorDaEntrada;
            if (idade < 12 )
            {
                valor = this.ValorDaEntrada * 0.5;
            }
            else if (idade < 16)
            {
                valor = this.ValorDaEntrada * 0.7;
            }

            if (this.DuracaoDoFilme > 3)
            {
                valor = this.ValorDaEntrada * 1.1;
            }

            return valor;
        }

    }


    class Aluno
    {
        public string NumeroMatricula { get; set; }
        public string Idade { get; set; }
        public string CPF { get; set; }
    }

    class ValidaAluno
    {
        public string Validar(Aluno aluno)
        {
            string erros = "";
            if (double.Parse(aluno.NumeroMatricula) < 2000 || double.Parse(aluno.NumeroMatricula) > 5000)
            {
                erros += "Número de matrícula inválido. \r\n";
            }
            if (double.Parse(aluno.Idade) < 16)
            {
                erros += "Idade inválida. \r\n";
            }
            if (String.IsNullOrWhiteSpace(aluno.CPF))
            {
                erros += "CPF deve ser informado. \r\n";
            }
            if (erros != "")
            {
                return erros;
            }
            return "Validado com sucesso!.";
        }
    }

    class Retangulo
    {
        public double Altura { get; set; }
        public double Base { get; set; }

        public double CalcularArea()
        {
            if (this.Altura <= 0 || this.Base <= 0)
            {
                return 0;
            }
            return this.Altura * this.Base;
        }
    }

    class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        public virtual string ImprimirDetalhes()
        {
            return this.ID + " - " + this.Nome;
        }
    }

    class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public override string ImprimirDetalhes()
        {
            return this.ID + this.CPF + this.Nome;
        }

    }

    class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public override string ImprimirDetalhes()
        {
            return this.ID + this.CNPJ + this.Nome;
        }
    }

    class A
    {
        public string Metodo()
        {
            return "Eu sou A";
        }
    }

    class B : A
    {
        public string Metodo()
        {
            return "Eu sou B";
        }
    }
}
