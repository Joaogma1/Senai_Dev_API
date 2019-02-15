using Senai.SviGufo.WebApi.Properties.Domains;
using System.Collections.Generic;

namespace Senai.SviGufo.WebApi.Interfaces
{
   public interface ITipoEventoRepository
    {
        /// <summary>
        /// Lista todos os tipos de eventos
        /// </summary>
        /// <returns></returns>
        List<TipoEventoDomain> listar();

        /// <summary>
        ///  Cadastra um tipo de evento
        /// </summary>
        /// <param name="tipoEvento"></param>
        void Cadastrar(TipoEventoDomain tipoEvento);
    }
}
