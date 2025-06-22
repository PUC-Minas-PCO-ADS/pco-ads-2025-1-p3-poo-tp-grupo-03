using ControleDeEnergia.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace ControleDeEnergia.Repositories
{
    public class RepositorioConta : IRepositorio<ContaDeEnergia>
    {
        private List<ContaDeEnergia> contas = new();
        private readonly string caminhoArquivo = "contas.json";

        public void Adicionar(ContaDeEnergia conta)
        {
            contas.Add(conta);
        }

        public ContaDeEnergia BuscarPorId(int id)
        {
            return contas.FirstOrDefault(c => c.Id == id);
        }

        public List<ContaDeEnergia> ListarTodos()
        {
            return new List<ContaDeEnergia>(contas);
        }

        public void SalvarArquivo()
        {
            var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
            var json = JsonSerializer.Serialize(contas, options);
            File.WriteAllText(caminhoArquivo, json);
        }

        public void CarregarArquivo()
        {
            if (File.Exists(caminhoArquivo))
            {
                var json = File.ReadAllText(caminhoArquivo);
                var options = new JsonSerializerOptions { IncludeFields = true };
                contas = JsonSerializer.Deserialize<List<ContaDeEnergia>>(json, options) ?? new();
            }
        }
    }
}
