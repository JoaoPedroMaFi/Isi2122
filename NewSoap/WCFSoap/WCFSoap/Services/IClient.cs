using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFSoap.DatabaseEntity;
using WCFSoap.Models;

namespace WCFSoap.Services
{

    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IClient" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IClient
    {
        /// <summary>
        /// Metodo para mostrar todas as pessoas infetadas
        /// </summary>
        /// <returns>Todas as pessoas infetadas</returns>
        [OperationContract]
        List<Infectado> GetAllInfected();

        /// <summary>
        /// Metodo para mostrar todas as pessoas suspeitas
        /// </summary>
        /// <returns>Todas as pessoas infetadas</returns>
        [OperationContract]
        List<Suspeito> GetAllSuspects();


        /// <summary>
        /// Metodo para adicionar pessoa infetada
        /// </summary>
        /// <param name="idPerson"></param>
        /// <returns>Adiciona uma nova pessoa infetada</returns>
        [OperationContract]
        void IndicateInfetion( Infectado infectado);        


        /// <summary>
        /// Inserir um novo suspeito na base de dados
        /// </summary>
        /// <param name="idequipa"></param>
        /// <param name="suspeitoObj"></param>
        [OperationContract]
        void IndicateSuspect(string idequipa, Suspeito suspeitoObj);

        /// <summary>
        /// Cria uma equipa
        /// </summary>
        /// <param name="equipa"></param>
        [OperationContract]
        void CreateTeam(Equipa equipa);

        /// <summary>
        /// Lista todas as equipas
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<Equipa> ShowTeams();
    }


}
