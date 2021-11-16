using SoapDgs.Models;
using SoapDgs.Database;
using System;
using System.Collections.Generic;
using SoapDgs.DatabaseEntity;

namespace SoapDgs.Sevices
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Client" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Client.svc ou Client.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Client : IClient
    {
        mybd_soapEntities1 db = new mybd_soapEntities1();
        public Infectado Get()
        {
            throw new NotImplementedException();
        }

        public List<Infectado> GetAll(int idPerson)
        {
            throw new NotImplementedException();
        }

        public void IndicateInfetion(string equipaName,string firstName, string lastName, int idEquipa)
        {
            //InsertNewInfected(firstName, lastName, idEquipa);

            //InsertTeam(equipaName);
            //InsertInfectedPerson(firstName, lastName);

            equipa equipaNova = new equipa();
            equipaNova.nome = equipaName;
            db.equipa.Add(equipaNova);
            db.SaveChanges();

            infetado infected = new infetado();
            infected.firstname = firstName;
            infected.lastname = lastName;
            db.infetado.Add(infected);
            db.SaveChanges();

        }
        public void IndicateInfetionList(List<Infectado> list)
        {
            throw new NotImplementedException();
        }

        public bool InsertNewInfectedClient(string name, string lastName, int idEquipa)
        {
            string name1, lastName1;
            int idEquipa1;
            name1 = name;
            lastName1 = lastName;
            idEquipa1 = idEquipa;
            //InsertNewInfected(name1, lastName1, idEquipa1);
            return true;
        }

        public void InsertNewSuspectClient(string name, string lastName, int id, int idInfetado)
        {
            string name1, lastName1;
            int id1;
            name1 = name;
            lastName1 = lastName;
            id1 = id;
            //InsertNewInfected(name1, lastName1, id1);
            
        }
    }
}

