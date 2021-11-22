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

    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Client" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Client.svc ou Client.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Client : IClient
    {

        Mybd_soapEntities db = new Mybd_soapEntities();
        /// <summary>
        /// Retorna uma lista de todos os infetados
        /// </summary>
        /// <returns></returns>
        public List<Infectado> GetAllInfected()
        {
            List<Infectado> infetados = new List<Infectado>();
            List<infetado> isolados = db.infetadoes.ToList();
            foreach (infetado inf in isolados)
            {
                
                Infectado infetadoClasse = new Infectado();
                infetadoClasse.Firstname = inf.firstname;
                infetadoClasse.Laststname = inf.lastname;
                infetados.Add(infetadoClasse);

            }

            return infetados;

            //var list = from inf in db.infetadoes
            //           select new
            //           {
            //               inf.firstname,
            //               inf.lastname
            //           };
            //return list.ToList();
        }

        public List<Infectado> GetAll(int idPerson)
        {
            throw new NotImplementedException();
        }

        // Indica uma equipa e um infetado
        public void IndicateInfetion(Equipa equipa, Infectado infectado)
        {
            equipa equipaNova = new equipa();
            equipaNova.nome = equipa.Nome;
            equipaNova.idequipa = equipa.Idequipa;
            db.equipas.Add(equipaNova);
            db.SaveChanges();

            infetado infected = new infetado();
            infected.idinfetado = infectado.Idpessoa;
            infected.firstname = infectado.Firstname;
            infected.lastname = infectado.Laststname;
            infected.idequipa = infectado.Idequipa;
            db.infetadoes.Add(infected);
            db.SaveChanges();

        }

        // indica um suspeito
        public void IndicateSuspect(string idequipa, Suspeito suspeitoObj)
        {
            
            suspeito suspeitoDb = new suspeito();
            suspeitoDb.firstname = suspeitoObj.Firstname;
            suspeitoDb.lastname = suspeitoObj.Laststname;
            suspeitoDb.idinfetado = Int32.Parse(idequipa);
            db.suspeitoes.Add(suspeitoDb);
            db.SaveChanges();

        }
        /// <summary>
        /// Retorna uma lista de todos os suspeitos
        /// </summary>
        /// <returns></returns>
        public List<Suspeito> GetAllSuspects()
        {
            List<Suspeito> suspeitoList = new List<Suspeito>();
            List<suspeito> suspeitoDB = db.suspeitoes.ToList();
            foreach (suspeito inf in suspeitoDB)
            {

                Suspeito suspeitoClasse = new Suspeito();
                suspeitoClasse.Firstname = inf.firstname;
                suspeitoClasse.Laststname = inf.lastname;
                suspeitoList.Add(suspeitoClasse);

            }

            return suspeitoList;

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
