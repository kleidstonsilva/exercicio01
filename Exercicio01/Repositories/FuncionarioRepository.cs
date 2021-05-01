using Exercicio01.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Exercicio01.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            var colaborador = $"c:\\temp\\funcionario_{funcionario.Id}.txt";

            var streamWriter = new StreamWriter(colaborador);

            streamWriter.WriteLine("Id..............: " + funcionario.Id);
            streamWriter.WriteLine("Nome..............: " + funcionario.Nome);
            streamWriter.WriteLine("CPF..............: " + funcionario.Cpf);
            streamWriter.WriteLine("Matricula..............: " + funcionario.Matricula);
            streamWriter.WriteLine("Data Admissao..............: " + funcionario.DataAdmissao);
            streamWriter.WriteLine("Cargo..............: " + funcionario.Cargo);
            streamWriter.WriteLine("Salario..............: " + funcionario.Salario);

            streamWriter.Close();
        }
    }
}
