using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace com.alexbnkz.Base
{
    public class TrackLoWayDataAccess
    {
        string ConnectionString = new ConnectionString().MsSqlServer();

        public string CreateTableCoordenadas()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" CREATE TABLE tlwCoordenadas(                           ");
                SQL.Append("    ID          int NOT NULL IDENTITY(1,1) PRIMARY KEY, ");
                SQL.Append("    Email       varchar(100) NOT NULL,                  ");
                SQL.Append("    Latitude    varchar(100),                           ");
                SQL.Append("    Longitude   varchar(30),                            ");
                SQL.Append("    Local       varchar(30),                            ");
                SQL.Append("    Data        datetime NOT NULL DEFAULT GETDATE())    ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Create Table tlwCoordenadas Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string DropTableCoordenadas()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" DROP TABLE tlwCoordenadas    ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Drop Table tlwCoordenadas Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string ListaCoordenadas()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    Email,                      ");
                SQL.Append("    Latitude,                   ");
                SQL.Append("    Longitude,                  ");
                SQL.Append("    Local,                      ");
                SQL.Append("    Data                        ");
                SQL.Append(" FROM tlwCoordenadas            ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno += "<table>";
                retorno += "<tr>";
                retorno += "<td>ID</td>";
                retorno += "<td>Email</td>";
                retorno += "<td>Latitude</td>";
                retorno += "<td>Longitude</td>";
                retorno += "<td>Local</td>";
                retorno += "<td>Data</td>";
                retorno += "</tr>";

                while (dr.Read())
                {
                    retorno += "<tr>";
                    retorno += "<td>" + dr["ID"] + "</td>";
                    retorno += "<td>" + dr["Email"] + "</td>";
                    retorno += "<td>" + dr["Latitude"] + "</td>";
                    retorno += "<td>" + dr["Longitude"] + "</td>";
                    retorno += "<td>" + dr["Local"] + "</td>";
                    retorno += "<td>" + dr["Data"] + "</td>";
                    retorno += "</tr>";
                }
                retorno += "<table>";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }

        public string SalvarCoordenadas(string Email, string Latitude, string Longitude, string Local)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" INSERT INTO tlwCoordenadas(    ");
                SQL.Append("    Email,                      ");
                SQL.Append("    Latitude,                   ");
                SQL.Append("    Longitude,                  ");
                SQL.Append("    Local)                      ");
                SQL.Append(" VALUES(                        ");
                SQL.Append("    '" + Email + "',            ");
                SQL.Append("    '" + Latitude + "',         ");
                SQL.Append("    '" + Longitude + "',        ");
                SQL.Append("    '" + Local + "')            ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }

    }
}
