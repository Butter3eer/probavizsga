using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookclub_desktop
{
    internal class Statisztika
    {
        public static List<Member> Beolvasas()
        {
            var list = new List<Member>();
            using var conn = new MySqlConnection("Server=localhost;Database=probavizsga;Uid=root;Pwd=;");
            conn.Open();

            var comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM members";
            var results = comm.ExecuteReader();

            while (results.Read())
            {
                var m = new Member();
                m.ID = results.GetInt32("id");
                m.Name = results.GetString("name");
                m.BirthDate = results.GetDateTime("birth_date");
                m.Gender = results.IsDBNull(2) ? null : results.GetString("gender");
                m.Banned = results.GetBoolean("banned");
                list.Add(m);
            }

            return list;
        }
    }
}
