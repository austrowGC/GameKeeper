using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GameKeeper.DAL
{
    class SqlDAL
    {
        private string dbString;
        private const string sqlCreatePlayer = @"insert into player (name) values (@name);";

        private const string sqlGetExistingPlayers = @"select * from player;";

        public SqlDAL(string dbConnectionString)  
        {
            dbString = dbConnectionString;
        }

        public Player CreatePlayerFromSql(SqlDataReader reader) 
        {
            string name = Convert.ToString(reader["name"]);
            Player player = new Player(name);
            return player;
        }

        public List<Player> GetExistingPlayers()    
        {
            List<Player> output = new List<Player>();

            using (SqlConnection bridge = new SqlConnection(this.dbString)) //  free resources when no longer connected
            {
                bridge.Open();  //  open the db connection

                SqlCommand cmd = new SqlCommand(sqlGetExistingPlayers, bridge);
                SqlDataReader rabbit = cmd.ExecuteReader();
                output.Add(CreatePlayerFromSql(rabbit));
            }
            return output;
        }

        public bool CreatePlayer(Player player)  
        {
            bool output = false;

            using (SqlConnection bridge = new SqlConnection(this.dbString)) //  free resources when no longer connected
            {
                bridge.Open();  //  open the db connection

                SqlCommand cmd = new SqlCommand(sqlCreatePlayer, bridge);
                cmd.Parameters.AddWithValue("@name", player.name);
                int rowAffect = cmd.ExecuteNonQuery();
                if (rowAffect > 0)
                {
                    output = true;
                }
            }

            return output;
        }
        // end block
    }
}
