using System.Collections.Generic;
using MvcProject.Models;

namespace MvcProject.Models.Interface
{
    public interface IAdvogadoRepositorio
    {
        void IncluirAdvogado(Advogado pObjAdvogado);
        void AtualizarAdvogado(Advogado pObjAdvogado);
        void ExcluirAdvogado(int pIntId);
        IEnumerable<Advogado> ListarAdvogados();
        Advogado ObterAdvogado(int pIntId);
        bool VerificarAdvogadoExiste(int pIntId);
    }
}
