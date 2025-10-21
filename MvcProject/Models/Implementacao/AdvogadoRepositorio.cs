using System;
using System.Collections.Generic;
using System.Linq;
using MvcProject.Models;
using MvcProject.Models.Interface;

namespace MvcProject.Models.Implementacao
{
    public class AdvogadoRepositorio : IAdvogadoRepositorio
    {
        private static List<Advogado> _advogados = new List<Advogado>();
        private static int _proximoId = 1;

        static AdvogadoRepositorio()
        {
            // Inicializar com alguns dados de exemplo
            InicializarDadosExemplo();
        }

        private static void InicializarDadosExemplo()
        {
            _advogados.Add(new Advogado
            {
                Id = _proximoId++,
                Nome = "João Silva",
                Senioridade = Senioridade.Senior,
                Logradouro = "Rua das Flores, 123",
                Bairro = "Centro",
                Estado = "SP",
                Cep = "01234-567",
                Numero = "123",
                Complemento = "Sala 101",
                DataCriacao = DateTime.Now.AddDays(-30)
            });

            _advogados.Add(new Advogado
            {
                Id = _proximoId++,
                Nome = "Maria Santos",
                Senioridade = Senioridade.Junior,
                Logradouro = "Av. Paulista, 1000",
                Bairro = "Bela Vista",
                Estado = "SP",
                Cep = "01310-100",
                Numero = "1000",
                Complemento = "Apto 45",
                DataCriacao = DateTime.Now.AddDays(-15)
            });

            _advogados.Add(new Advogado
            {
                Id = _proximoId++,
                Nome = "Pedro Oliveira",
                Senioridade = Senioridade.Pleno,
                Logradouro = "Rua Augusta, 500",
                Bairro = "Consolação",
                Estado = "SP",
                Cep = "01305-000",
                Numero = "500",
                Complemento = null,
                DataCriacao = DateTime.Now.AddDays(-7)
            });
        }

        public void IncluirAdvogado(Advogado pObjAdvogado)
        {
            pObjAdvogado.Id = _proximoId++;
            pObjAdvogado.DataCriacao = DateTime.Now;
            _advogados.Add(pObjAdvogado);
        }

        public void AtualizarAdvogado(Advogado pObjAdvogado)
        {
            var advogadoExistente = _advogados.FirstOrDefault(a => a.Id == pObjAdvogado.Id);
            if (advogadoExistente != null)
            {
                advogadoExistente.Nome = pObjAdvogado.Nome;
                advogadoExistente.Senioridade = pObjAdvogado.Senioridade;
                advogadoExistente.Logradouro = pObjAdvogado.Logradouro;
                advogadoExistente.Bairro = pObjAdvogado.Bairro;
                advogadoExistente.Estado = pObjAdvogado.Estado;
                advogadoExistente.Cep = pObjAdvogado.Cep;
                advogadoExistente.Numero = pObjAdvogado.Numero;
                advogadoExistente.Complemento = pObjAdvogado.Complemento;
                advogadoExistente.DataAtualizacao = DateTime.Now;
            }
        }

        public void ExcluirAdvogado(int pIntId)
        {
            var advogado = _advogados.FirstOrDefault(a => a.Id == pIntId);
            if (advogado != null)
            {
                _advogados.Remove(advogado);
            }
        }

        public IEnumerable<Advogado> ListarAdvogados()
        {
            return _advogados.OrderBy(a => a.Nome).ToList();
        }

        public Advogado ObterAdvogado(int pIntId)
        {
            return _advogados.FirstOrDefault(a => a.Id == pIntId);
        }

        public bool VerificarAdvogadoExiste(int pIntId)
        {
            return _advogados.Any(a => a.Id == pIntId);
        }
    }
}
