using ControleDeEnergia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ControleDeEnergia.Repositories
{
    internal class RepositorioConsumidor : IRepositorio<Consumidor>
    {
        private List<Consumidor> consumidores = new();
        private readonly string caminhoArquivo = "consumidores.txt";

        public void Adicionar(Consumidor consumidor)
        {
            consumidores.Add(consumidor);
        }


        public List<Consumidor> ListarTodos()
        {
            return new List<Consumidor> (consumidores);
        }

        public void SalvarArquivo()
        {
            var options = new JsonSerializerOptions { WriteIndented = true, IncludeFields = true };
            var json = JsonSerializer.Serialize(consumidores, options);
            File.WriteAllText(caminhoArquivo, json);
        }
        public void CarregarArquivo()
        {
            if (File.Exists(caminhoArquivo))
            {
                var json = File.ReadAllText(caminhoArquivo);
                var options = new JsonSerializerOptions { IncludeFields = true };
                consumidores = JsonSerializer.Deserialize<List<Consumidor>>(json, options) ?? new();
            }
        }
    }
}
