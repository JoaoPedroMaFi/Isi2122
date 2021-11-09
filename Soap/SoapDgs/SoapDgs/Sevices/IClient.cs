using SoapDgs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapDgs.Sevices
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IClient" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IClient
    {
        /// <summary>
        /// Metodo para mostrar pessoas infetadas
        /// </summary>
        /// <returns>Todas as pessoas infetadas</returns>
        [OperationContract]
        Infectado Get();

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
        void IndicateInfetion(string firstName, string lastName, int idEquipa);

        /// <summary>
        /// Metodo para adicionar lista de pessoas que entraram em contacto com uma pessoa infetada
        /// </summary>
        /// <param name="idPerson"></param>
        /// <returns>Adiciona uma nova lista lista de pessoas que entraram em contacto com uma pessoa infetada</returns>
        [OperationContract]
        void IndicateInfetionList(List<Infectado> list);
    }
}
