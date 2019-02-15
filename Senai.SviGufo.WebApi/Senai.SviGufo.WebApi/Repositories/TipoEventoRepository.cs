using Senai.SviGufo.WebApi.Interfaces;
using Senai.SviGufo.WebApi.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.SviGufo.WebApi.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private string StringConexao = @"Data Source=.\SqlExpress;initial catalog=SENAI_SVIGUFO_TARDE;User Id=sa;Password=132";

        public void Cadastrar(TipoEventoDomain tipoEvento)
        {
            throw new NotImplementedException();
        }

        public List<TipoEventoDomain> listar()
        {
            //objeto que ira retornar na chamada do metodo
            List<TipoEventoDomain> tiposEventos = new List<TipoEventoDomain>();
            //Define a conexão passando a string de conexão
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string QuerySelect = " SELECT ID,TITULO FROM TIPOS_EVENTOS";
                // define o comando que será executado, no construtor
                //passa a query e a conexão
                using (SqlCommand CMD = new SqlCommand(QuerySelect, con))
                {
                    //Abre a conexão com a DB
                    con.Open();

                    // objeto que armazena os dados retornados
                    SqlDataReader rdr = CMD.ExecuteReader();

                    // Perorre todos os dados do objeto
                    while (rdr.Read())
                    {
                        TipoEventoDomain tipoEvento = new TipoEventoDomain
                        {
                            ID = Convert.ToInt32(rdr["ID"]),
                            Nome = rdr["TITULO"].ToString()
                        };

                        // Adiciona o objeto na lista de tipo de eventos
                        tiposEventos.Add(tipoEvento);
                    }
                }
                return tiposEventos;
            }

        void ITipoEventoRepository.Cadastrar(TipoEventoDomain tipoEvento)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                String QueryInsert = $@"INSERT INTO TIPO_EVENTOS(TITULO) VALUES (@TITULO) ";

                SqlCommand cmd = new SqlCommand(QueryInsert, con)
                            };
        }
    }
}

        }
    }
}
