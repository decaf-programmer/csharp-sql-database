using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class DataAccess
    {
        public List<Person> GetPeople(string lastname)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                //var output = connection.Query<Person>($"select * from People where LastName = '{lastname}'").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastname }).ToList();
                return output;
            }
        }

        public void InsertPerson(string aaa)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("SampleDB")))
            {
                Person newPerson = new Person { FirstName = aaa };
                List<Person> people = new List<Person>();
                people.Add(newPerson);
                connection.Execute("dbo.People_Insert @FirstName", people);
            }
        }
    }
}
