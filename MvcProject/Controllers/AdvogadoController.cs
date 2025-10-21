using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcProject.Models;
using MvcProject.Models.Interface;
using MvcProject.Models.Implementacao;

namespace MvcProject.Controllers
{
    public class AdvogadoController : Controller
    {
        private readonly IAdvogadoRepositorio _advogadoRepositorio;

        public AdvogadoController()
        {
            _advogadoRepositorio = new AdvogadoRepositorio();
        }

        public ActionResult Index()
        {
            var advogados = _advogadoRepositorio.ListarAdvogados();
            return View(advogados);
        }

        public ActionResult TestEncoding()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            var advogado = _advogadoRepositorio.ObterAdvogado(id);
            if (advogado == null)
            {
                return HttpNotFound();
            }

            var viewModel = new AdvogadoViewModel
            {
                Id = advogado.Id,
                Nome = advogado.Nome,
                Senioridade = advogado.Senioridade,
                Logradouro = advogado.Logradouro,
                Bairro = advogado.Bairro,
                Estado = advogado.Estado,
                Cep = advogado.Cep,
                Numero = advogado.Numero,
                Complemento = advogado.Complemento,
                DataCriacao = advogado.DataCriacao,
                DataAtualizacao = advogado.DataAtualizacao
            };

            return View(viewModel);
        }

        public ActionResult Create()
        {
            var viewModel = new AdvogadoViewModel();
            CarregarDropDowns(viewModel);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdvogadoViewModel pObjAdvogadoViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var advogado = new Advogado
                    {
                        Nome = pObjAdvogadoViewModel.Nome,
                        Senioridade = pObjAdvogadoViewModel.Senioridade,
                        Logradouro = pObjAdvogadoViewModel.Logradouro,
                        Bairro = pObjAdvogadoViewModel.Bairro,
                        Estado = pObjAdvogadoViewModel.Estado,
                        Cep = pObjAdvogadoViewModel.Cep,
                        Numero = pObjAdvogadoViewModel.Numero,
                        Complemento = pObjAdvogadoViewModel.Complemento
                    };

                    _advogadoRepositorio.IncluirAdvogado(advogado);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Erro ao criar advogado: " + ex.Message);
                }
            }

            CarregarDropDowns(pObjAdvogadoViewModel);
            return View(pObjAdvogadoViewModel);
        }

        public ActionResult Edit(int id)
        {
            var advogado = _advogadoRepositorio.ObterAdvogado(id);
            if (advogado == null)
            {
                return HttpNotFound();
            }

            var viewModel = new AdvogadoViewModel
            {
                Id = advogado.Id,
                Nome = advogado.Nome,
                Senioridade = advogado.Senioridade,
                Logradouro = advogado.Logradouro,
                Bairro = advogado.Bairro,
                Estado = advogado.Estado,
                Cep = advogado.Cep,
                Numero = advogado.Numero,
                Complemento = advogado.Complemento,
                DataCriacao = advogado.DataCriacao,
                DataAtualizacao = advogado.DataAtualizacao
            };

            CarregarDropDowns(viewModel);
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AdvogadoViewModel pObjAdvogadoViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var advogado = new Advogado
                    {
                        Id = pObjAdvogadoViewModel.Id,
                        Nome = pObjAdvogadoViewModel.Nome,
                        Senioridade = pObjAdvogadoViewModel.Senioridade,
                        Logradouro = pObjAdvogadoViewModel.Logradouro,
                        Bairro = pObjAdvogadoViewModel.Bairro,
                        Estado = pObjAdvogadoViewModel.Estado,
                        Cep = pObjAdvogadoViewModel.Cep,
                        Numero = pObjAdvogadoViewModel.Numero,
                        Complemento = pObjAdvogadoViewModel.Complemento
                    };

                    _advogadoRepositorio.AtualizarAdvogado(advogado);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Erro ao atualizar advogado: " + ex.Message);
                }
            }

            CarregarDropDowns(pObjAdvogadoViewModel);
            return View(pObjAdvogadoViewModel);
        }

        public ActionResult Delete(int id)
        {
            var advogado = _advogadoRepositorio.ObterAdvogado(id);
            if (advogado == null)
            {
                return HttpNotFound();
            }

            var viewModel = new AdvogadoViewModel
            {
                Id = advogado.Id,
                Nome = advogado.Nome,
                Senioridade = advogado.Senioridade,
                Logradouro = advogado.Logradouro,
                Bairro = advogado.Bairro,
                Estado = advogado.Estado,
                Cep = advogado.Cep,
                Numero = advogado.Numero,
                Complemento = advogado.Complemento,
                DataCriacao = advogado.DataCriacao,
                DataAtualizacao = advogado.DataAtualizacao
            };

            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _advogadoRepositorio.ExcluirAdvogado(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Erro ao excluir advogado: " + ex.Message);
                return RedirectToAction("Index");
            }
        }

        private void CarregarDropDowns(AdvogadoViewModel pObjAdvogadoViewModel)
        {
            // Estados brasileiros
            var estados = new List<SelectListItem>
            {
                new SelectListItem { Value = "AC", Text = "Acre" },
                new SelectListItem { Value = "AL", Text = "Alagoas" },
                new SelectListItem { Value = "AP", Text = "Amapá" },
                new SelectListItem { Value = "AM", Text = "Amazonas" },
                new SelectListItem { Value = "BA", Text = "Bahia" },
                new SelectListItem { Value = "CE", Text = "Ceará" },
                new SelectListItem { Value = "DF", Text = "Distrito Federal" },
                new SelectListItem { Value = "ES", Text = "Espírito Santo" },
                new SelectListItem { Value = "GO", Text = "Goiás" },
                new SelectListItem { Value = "MA", Text = "Maranhão" },
                new SelectListItem { Value = "MT", Text = "Mato Grosso" },
                new SelectListItem { Value = "MS", Text = "Mato Grosso do Sul" },
                new SelectListItem { Value = "MG", Text = "Minas Gerais" },
                new SelectListItem { Value = "PA", Text = "Pará" },
                new SelectListItem { Value = "PB", Text = "Paraíba" },
                new SelectListItem { Value = "PR", Text = "Paraná" },
                new SelectListItem { Value = "PE", Text = "Pernambuco" },
                new SelectListItem { Value = "PI", Text = "Piauí" },
                new SelectListItem { Value = "RJ", Text = "Rio de Janeiro" },
                new SelectListItem { Value = "RN", Text = "Rio Grande do Norte" },
                new SelectListItem { Value = "RS", Text = "Rio Grande do Sul" },
                new SelectListItem { Value = "RO", Text = "Rondônia" },
                new SelectListItem { Value = "RR", Text = "Roraima" },
                new SelectListItem { Value = "SC", Text = "Santa Catarina" },
                new SelectListItem { Value = "SP", Text = "São Paulo" },
                new SelectListItem { Value = "SE", Text = "Sergipe" },
                new SelectListItem { Value = "TO", Text = "Tocantins" }
            };

            pObjAdvogadoViewModel.Estados = new SelectList(estados, "Value", "Text", pObjAdvogadoViewModel.Estado);

            // Senioridades
            var senioridades = new List<SelectListItem>
            {
                new SelectListItem { Value = "1", Text = "Júnior" },
                new SelectListItem { Value = "2", Text = "Pleno" },
                new SelectListItem { Value = "3", Text = "Sênior" }
            };

            pObjAdvogadoViewModel.Senioridades = new SelectList(senioridades, "Value", "Text", (int)pObjAdvogadoViewModel.Senioridade);
        }
    }
}
