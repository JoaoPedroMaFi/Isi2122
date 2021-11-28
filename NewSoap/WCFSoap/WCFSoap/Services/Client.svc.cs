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
                infetadoClasse.Idpessoa = inf.idinfetado;
                infetadoClasse.Firstname = inf.firstname;
                infetadoClasse.Laststname = inf.lastname;
                infetadoClasse.Idequipa = inf.idequipa;
                infetados.Add(infetadoClasse);

            }

            return infetados;

           
        }

        /// <summary>
        /// Indica um infetado
        /// </summary>
        /// <returns></returns>
        public void IndicateInfetion( Infectado infectado)
        {
         
            infetado infected = new infetado();
            //infected.idinfetado = infectado.Idpessoa;
            infected.firstname = infectado.Firstname;
            infected.lastname = infectado.Laststname;
            infected.idequipa = infectado.Idequipa;
            db.infetadoes.Add(infected);
            db.SaveChanges();
           
        }
        /// <summary>
        /// Indica um suspeito
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Cria uma equipa
        /// </summary>
        /// <param name="equipa"></param>
        public void CreateTeam(Equipa equipa)
        {
            equipa equipaNova = new equipa();
            equipaNova.nome = equipa.Nome;
            //equipaNova.idequipa = equipa.Idequipa;
            db.equipas.Add(equipaNova);
            db.SaveChanges();
        }

        /// <summary>
        /// Lista todas as equipas
        /// </summary>
        /// <returns></returns>
        public List<Equipa> ShowTeams()
        {
            List<Equipa> equipaList = new List<Equipa>();
            List<equipa> equipadb = db.equipas.ToList();
            foreach (equipa equi in equipadb)
            {

                Equipa equipaClasse = new Equipa();
                equipaClasse.Idequipa = equi.idequipa;
                equipaClasse.Nome = equi.nome;
                equipaList.Add(equipaClasse);

            }

            return equipaList;
        }
    }
}
