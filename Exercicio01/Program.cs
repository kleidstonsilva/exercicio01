using Exercicio01.Entities;
using Exercicio01.Repositories;
using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n -- Preencha os Dados abaixo -- \n");

            var funcionario = new Funcionario();

            funcionario.Id = Guid.NewGuid();

            Console.Write("Informe nome.............: " );
            funcionario.Nome = Console.ReadLine();

            Console.Write("Informe CPF.............: " );
            funcionario.Cpf = Console.ReadLine();

            Console.Write("Informe Matricula.............: " );
            funcionario.Matricula = Console.ReadLine();
            
            Console.Write("Informe Data Admissão.............: " );
            funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());
            
            Console.Write("Informe Cargo.............: " );
            funcionario.Cargo = Console.ReadLine();
            
            Console.Write("Informe Salario.............: " );
            funcionario.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nRegistro de Dados");
            Console.WriteLine("Id...............: " + funcionario.Id);
            Console.WriteLine("Nome.............: " + funcionario.Nome);
            Console.WriteLine("CPF..............: " + funcionario.Cpf);
            Console.WriteLine("Matricula........: " + funcionario.Matricula);
            Console.WriteLine("DataAdmissao.....: " + funcionario.DataAdmissao);
            Console.WriteLine("Cargo............: " + funcionario.Cargo);
            Console.WriteLine("Salario..........: " + funcionario.Salario);

            var funcionarioRepository = new FuncionarioRepository();

            try
            {
                funcionarioRepository.ExportarDados(funcionario);                
            }
            catch(Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
                       
        }
    }
}
