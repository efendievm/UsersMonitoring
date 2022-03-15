using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace UsersMonitoring
{
    public class DBUsersContext
    {
        private string connectionString { get; set; } = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\UsersDB.mdf;Integrated Security=True";
        public DataTable GetUsers()
        {
            DataTable res = new DataTable();
            res.Columns.Add("ID", typeof(int));
            res.Columns.Add("Fio", typeof(string));
            res.Columns.Add("Groups", typeof(string));
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var querry = @"
                    select u.ID_User as ID, u.Fio, g.[Desc] as Groups
                    from 
                        Users u 
                        left join UsersGroup ug on u.ID_User = ug.ID_User 
                        left join Groups g on ug.ID_Group = g.ID_Group
                    order by u.ID_User, g.[Desc]
                ";
                var comm = new SqlCommand(querry, conn);
                var adapter = new SqlDataAdapter(comm);
                adapter.Fill(res);
                var grouped = res.AsEnumerable()
                    .Select(r => new { ID = Convert.ToInt32(r["ID"]), Fio = Convert.ToString(r["Fio"]), Groups = Convert.ToString(r["Groups"]) })
                    .GroupBy(r => new { r.ID, r.Fio })
                    .OrderBy(r => r.Key.ID)
                    .ToList();
                res.Clear();
                foreach (var group in grouped)
                {
                    var row = res.NewRow();
                    row["ID"] = group.Key.ID;
                    row["Fio"] = group.Key.Fio;
                    row["Groups"] = group.Select(r => r.Groups).Aggregate((g1, g2) => $"{g1}; {g2}");
                    res.Rows.Add(row);
                }
            }
            return res;
        }
        public List<Group> GetGroups()
        {
            var res = new List<Group>();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var comm = new SqlCommand("select * from Groups", conn))
                {
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            res.Add(new Group()
                            {
                                ID = Convert.ToInt32(reader["ID_Group"]),
                                Desc = Convert.ToString(reader["Desc"])
                            });
                        }
                    }
                }
            }
            return res;
        }
        public DataTable GetGroupsStatistics()
        {
            var res = new DataTable();
            res.Columns.Add("ID_Group", typeof(string));
            res.Columns.Add("Desc", typeof(string));
            res.Columns.Add("UsersCount", typeof(int));
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                var querry = @"
                    select g.ID_Group, g.[Desc], count(ug.ID_Group) as UsersCount
                    from Groups g left join UsersGroup ug on g.ID_Group = ug.ID_Group
                    group by g.ID_Group, g.[Desc]
                    order by g.ID_Group
                ";
                using (var comm = new SqlCommand(querry, conn))
                {
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = res.NewRow();
                            row["ID_Group"] = Convert.ToInt32(reader["ID_Group"]);
                            row["Desc"] = Convert.ToString(reader["Desc"]);
                            row["UsersCount"] = Convert.ToInt32(reader["UsersCount"]);
                            res.Rows.Add(row);
                        }
                    }
                }
            }
            return res;
        }
        public void AddGroup(string Desc)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var comm = new SqlCommand("insert into Groups ([Desc]) values (@Desc)", conn))
                {
                    comm.Parameters.AddWithValue("@Desc", Desc);
                    comm.ExecuteNonQuery();
                }
            }
        }
        public void AddUser(string Fio, List<Group> Groups)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                int ID_User = 0;
                using (var comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = "insert into Users (Fio) values (@Fio); select scope_identity()";
                    comm.Parameters.AddWithValue("@Fio", Fio);
                    ID_User = Convert.ToInt32(comm.ExecuteScalar());
                    
                    comm.CommandText = "insert into UsersGroup (ID_User, ID_Group) values (@ID_User, @ID_Group)";
                    comm.Parameters.AddWithValue("@ID_User", ID_User);
                    var IDGroupParameter = comm.Parameters.Add("@ID_Group", SqlDbType.Int);
                    foreach (var group in Groups)
                    {
                        IDGroupParameter.Value = group.ID;
                        comm.ExecuteNonQuery();
                    }
                }
            }
        }
        public void DeleteUser(int ID_User)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = "delete Users where ID_User = @ID_User; delete UsersGroup where ID_User = @ID_User";
                    comm.Parameters.AddWithValue("@ID_User", ID_User);
                    comm.ExecuteNonQuery();
                }
            }
        }
        public void DeleteGroup(int ID_Group)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = "delete Groups where ID_Group = @ID_Group; delete UsersGroup where ID_Group = @ID_Group";
                    comm.Parameters.AddWithValue("@ID_Group", ID_Group);
                    comm.ExecuteNonQuery();
                }
            }
        }
    }

    public class User
    {
        public int ID { get; set; }
        public string Fio { get; set; }
    }
    public class Group
    {
        public int ID { get; set; }
        public string Desc { get; set; }
    }
}
