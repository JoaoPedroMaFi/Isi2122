using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFSoap.DatabaseEntity;

namespace WCFSoap.Database
{
    public class DatabaseAcess
    {
        Mybd_soapEntities db = new Mybd_soapEntities();

        void InsertTeam(string name)
        {
            equipa equipaNova = new equipa();
            equipaNova.nome = name;
            db.equipas.Add(equipaNova);
            db.SaveChanges();
        }
        void InsertInfectedPerson(string namePerson, string lastNamePerson)
        {
            infetado infected = new infetado();
            infected.firstname = namePerson;
            infected.lastname = lastNamePerson;
            db.infetadoes.Add(infected);
            db.SaveChanges();
        }
    }
}