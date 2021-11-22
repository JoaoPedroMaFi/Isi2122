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
        /// Metodo para mostrar pessoas que entararm em contaco com pessoas infetadas
        /// </summary>
        /// <param name="idPerson"></param>
        /// <returns>Lista de pessoas infetadas por uma determinada pessoa</returns>
        [OperationContract]
        List<Infectado> GetAll(int idPerson);

        /// <summary>
        /// Metodo para adicionar pessoa infetada
        /// </summary>
        /// <param name="idPerson"></param>
        /// <returns>Adiciona uma nova pessoa infetada</returns>
        [OperationContract]
        void IndicateInfetion(Equipa equipa, Infectado infectado);

        /// <summary>
        /// Metodo para adicionar lista de pessoas que entraram em contacto com uma pessoa infetada
        /// </summary>
        /// <param name="idPerson"></param>
        /// <returns>Adiciona uma nova lista lista de pessoas que entraram em contacto com uma pessoa infetada</returns>
        [OperationContract]
        void IndicateInfetionList(List<Infectado> list);

        /// <summary>
        /// Inserir um novo infetado na base de dados
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="idEquipa"></param>
        [OperationContract]
        bool InsertNewInfectedClient(string firstName, string lastName, int idEquipa);

        /// <summary>
        /// Inserir um novo suspeito na base de dados
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="id"></param>
        /// <param name="idInfetado"></param>
        [OperationContract]
        void InsertNewSuspectClient(string firstName, string lastName, int id, int idInfetado);

        /// <summary>
        /// Inserir um novo suspeito na base de dados
        /// </summary>
        /// <param name="idequipa"></param>
        /// <param name="suspeitoObj"></param>
        [OperationContract]
        void IndicateSuspect(string idequipa, Suspeito suspeitoObj);
    }


}
