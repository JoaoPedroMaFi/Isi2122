using SoapDgs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoapDgs.Sevices
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Client" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Client.svc ou Client.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Client : IClient
    {
        public Infectado Get()
        {
            throw new NotImplementedException();
        }

        public List<Infectado> GetAll(int idPerson)
        {
            throw new NotImplementedException();
        }

        public void IndicateInfetion(string firstName, string lastName, int idEquipa)
        {
            InsertNewInfected(firstName, lastName, idEquipa);

        }

        public void IndicateInfetionList(List<Infectado> list)
        {
            throw new NotImplementedException();
        }

        private bool InsertNewInfected(string name, string lastname, int idEquipa)
        {

            return true;
        }
    }
}

