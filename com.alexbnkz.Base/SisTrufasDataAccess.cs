using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace com.alexbnkz.Base
{
    public class SisTrufasDataAccess
    {
        string ConnectionString = new ConnectionString().MsSqlServer();

        public string execSQL(string SQL)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                new SqlCommand(SQL, conn).ExecuteNonQuery();

                retorno = "OK ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = SQL + "\n Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }

        // Trufas
        public string CreateTableTrufas()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" CREATE TABLE stTrufa(                                  ");
                SQL.Append("    ID          int NOT NULL IDENTITY(1,1) PRIMARY KEY, ");
                SQL.Append("    Recheio     varchar(100) NOT NULL,                  ");
                SQL.Append("    Foto        varchar(200),                           ");
                SQL.Append("    Descricao   varchar(200))                           ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Create Table stTrufa Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string DropTableTrufas()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" DROP TABLE stTrufa    ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Drop Table stTrufa Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public DataTable ListaTrufas()
        {
            try
            {
                DataTable retorno = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    Recheio,                    ");
                SQL.Append("    Foto,                       ");
                SQL.Append("    Descricao                   ");
                SQL.Append(" FROM stTrufa                   ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno.Load(dr);

                conn.Close();

                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string ListaTrufasCombo()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    Recheio,                    ");
                SQL.Append("    Foto,                       ");
                SQL.Append("    Descricao                   ");
                SQL.Append(" FROM stTrufa                   ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                while (dr.Read())
                {
                    retorno += "<option value=\""+ dr["ID"] + "\">" + dr["Recheio"] + "</option>";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string IncluirTrufas(string Recheio, string Foto, string Descricao)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" INSERT INTO stTrufa(           ");
                SQL.Append("    Recheio,                    ");
                SQL.Append("    Foto,                       ");
                SQL.Append("    Descricao)                  ");
                SQL.Append(" VALUES(                        ");
                SQL.Append("    '" + Recheio + "',          ");
                SQL.Append("    '" + Foto + "',             ");
                SQL.Append("    '" + Descricao + "')        ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }

        // Formas de Pagamento
        public string CreateTablePagamento()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" CREATE TABLE stPagamento(                              ");
                SQL.Append("    ID          int NOT NULL IDENTITY(1,1) PRIMARY KEY, ");
                SQL.Append("    Nome        varchar(100) NOT NULL)                  ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Create Table stPagamento Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string DropTablePagamento()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" DROP TABLE stPagamento    ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Drop Table stPagamento Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public DataTable ListaPagamento()
        {
            try
            {
                DataTable retorno = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    Nome                        ");
                SQL.Append(" FROM stPagamento               ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno.Load(dr);

                conn.Close();

                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ListaPagamento(string ID)
        {
            try
            {
                DataTable retorno = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    Nome                        ");
                SQL.Append(" FROM stPagamento               ");
                SQL.Append(" WHERE ID = " + ID + "          ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno.Load(dr);

                conn.Close();

                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string ListaPagamentoCombo()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    Nome                        ");
                SQL.Append(" FROM stPagamento               ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                while (dr.Read())
                {
                    retorno += "\n<option value=\"" + dr["ID"] + "\">" + dr["Nome"] + "</option>";
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string IncluirPagamento(string Nome)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" INSERT INTO stPagamento(Nome)  ");
                SQL.Append(" VALUES('" + Nome + "')         ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }

        // Solicitacao
        public string CreateTableSolicitacao()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" CREATE TABLE stSolicitacao(                            ");
                SQL.Append("    ID          int NOT NULL IDENTITY(1,1) PRIMARY KEY, ");
                SQL.Append("    WhatsApp    varchar(15) NOT NULL,                   ");
                SQL.Append("    Total       decimal(5,2) NOT NULL DEFAULT 0,        ");
                SQL.Append("    Pago        int NOT NULL DEFAULT 0,                 ");
                SQL.Append("    TipoPagamento int NOT NULL DEFAULT 0,               ");
                SQL.Append("    Finalizado  int NOT NULL DEFAULT 0,                 ");
                SQL.Append("    Cancelado   int NOT NULL DEFAULT 0,                 ");
                SQL.Append("    Data        datetime NOT NULL DEFAULT GETDATE())    ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Create Table stSolicitacao Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string DropTableSolicitacao()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" DROP TABLE stSolicitacao    ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Drop Table stSolicitacao Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public bool ExisteSolicitacao(string WhatsApp)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Total,                      ");
                SQL.Append("    Pago,                       ");
                SQL.Append("    Data                        ");
                SQL.Append(" FROM stSolicitacao             ");
                SQL.Append(" WHERE                          ");
                SQL.Append("    WhatsApp = '" + WhatsApp + "' ");
                SQL.Append("    AND Finalizado = 0          ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                return (dr.Read());
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable ListaSolicitacao()
        {
            try
            {
                DataTable retorno = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Total,                      ");
                SQL.Append("    Pago,                       ");
                SQL.Append("    TipoPagamento,              ");
                SQL.Append("    Finalizado,                 ");
                SQL.Append("    Data                        ");
                SQL.Append(" FROM stSolicitacao             ");
                SQL.Append(" WHERE                          ");
                SQL.Append("    Finalizado = 0              ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno.Load(dr);

                conn.Close();

                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ListaSolicitacao(string WhatsApp)
        {
            try
            {
                DataTable retorno = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Total,                      ");
                SQL.Append("    Pago,                       ");
                SQL.Append("    TipoPagamento,              ");
                SQL.Append("    Finalizado,                 ");
                SQL.Append("    Data                        ");
                SQL.Append(" FROM stSolicitacao             ");
                SQL.Append(" WHERE                          ");
                SQL.Append("    WhatsApp = '" + WhatsApp + "' ");
                SQL.Append("    AND Finalizado = 0          ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();
                
                retorno.Load(dr);

                conn.Close();

                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ListaSolicitacaoPendente()
        {
            try
            {
                DataTable retorno = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT TOP 10                  ");
                SQL.Append("    ID,                         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Total,                      ");
                SQL.Append("    Pago,                       ");
                SQL.Append("    TipoPagamento,              ");
                SQL.Append("    Finalizado,                 ");
                SQL.Append("    Data                        ");
                SQL.Append(" FROM stSolicitacao             ");
                SQL.Append(" WHERE                          ");
                SQL.Append("    Finalizado = 1              ");
                SQL.Append(" AND Pago = 0                   ");
                SQL.Append(" AND Cancelado = 0              ");
                SQL.Append(" ORDER BY                       ");
                SQL.Append("    Data DESC                   ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno.Load(dr);

                conn.Close();

                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ListaSolicitacaoCliente(string WhatsApp)
        {
            try
            {
                DataTable retorno = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Total,                      ");
                SQL.Append("    Pago,                       ");
                SQL.Append("    TipoPagamento,              ");
                SQL.Append("    Finalizado,                 ");
                SQL.Append("    Data                        ");
                SQL.Append(" FROM stSolicitacao             ");
                SQL.Append(" WHERE                          ");
                SQL.Append("    WhatsApp = '" + WhatsApp + "' ");
                SQL.Append(" AND Finalizado = 1             ");
                SQL.Append(" OR Cancelado = 1               ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno.Load(dr);

                conn.Close();

                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string IncluirSolicitacao(string WhatsApp, string Total, string Pago)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" INSERT                         ");
                SQL.Append(" INTO stSolicitacao(WhatsApp)   ");
                SQL.Append(" VALUES('" + WhatsApp + "')     ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string AtualizaTotalSolicitacao(string ID, string Total)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" UPDATE stSolicitacao SET           ");
                SQL.Append("    Total = " + Total + ",          ");
                SQL.Append("    Data = GETDATE()                ");
                SQL.Append(" WHERE                              ");
                SQL.Append("    ID = " + ID + "                 ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string AtualizaPagoOkSolicitacao(string ID)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" UPDATE stSolicitacao SET           ");
                SQL.Append("    Pago = 1                        ");
                SQL.Append(" WHERE ID = " + ID + "              ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string AtualizaPagamentoSolicitacao(string ID, string TipoPagamento)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" UPDATE stSolicitacao SET           ");
                SQL.Append("    TipoPagamento = " + TipoPagamento + " ");
                SQL.Append(" WHERE ID = " + ID + "              ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string FinalizarSolicitacao(string ID)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" UPDATE stSolicitacao SET           ");
                SQL.Append("    Finalizado = 1                  ");
                SQL.Append(" WHERE ID = " + ID + "              ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string CancelarSolicitacao(string ID)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" UPDATE stSolicitacao SET           ");
                SQL.Append("    Cancelado = 1                  ");
                SQL.Append(" WHERE ID = " + ID + "              ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }

        // Item
        public string CreateTableItemSolicitacao()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" CREATE TABLE stItemSolicitacao(                            ");
                SQL.Append("    ID              int NOT NULL IDENTITY(1,1) PRIMARY KEY, ");
                SQL.Append("    IdSolicitacao   int NOT NULL,                           ");
                SQL.Append("    IdTrufa         int NOT NULL,                           ");
                SQL.Append("    Quantidade      int NOT NULL)                           ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Create Table stItemSolicitacao Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string DropTableItemSolicitacao()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" DROP TABLE stItemSolicitacao    ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Drop Table stItemSolicitacao Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public bool ExisteItemSolicitacao(string IdSolicitacao)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                                         ");
                SQL.Append("    Item.ID,                                    ");
                SQL.Append("    ROW_NUMBER() OVER (ORDER BY Item.ID) AS NUM,     ");
                SQL.Append("    Item.IdSolicitacao,                         ");
                SQL.Append("    Item.IdTrufa,                               ");
                SQL.Append("    Trufa.Recheio,                              ");
                SQL.Append("    Item.Quantidade,                            ");
                SQL.Append("    Convert(Decimal(5,2), Item.Quantidade*2) AS Valor   ");
                SQL.Append(" FROM                                           ");
                SQL.Append("    stItemSolicitacao Item                      ");
                SQL.Append(" INNER JOIN stTrufa Trufa ON                    ");
                SQL.Append("    Trufa.ID = Item.IdTrufa                     ");
                SQL.Append(" WHERE                                          ");
                SQL.Append("    Item.IDSolicitacao = " + IdSolicitacao + "  ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                return dr.Read();
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable ListaItemSolicitacao(string IdSolicitacao)
        {
            DataTable retorno = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                                         ");
                SQL.Append("    Item.ID,                                    ");
                SQL.Append("    ROW_NUMBER() OVER (ORDER BY Item.ID) AS NUM,     ");
                SQL.Append("    Item.IdSolicitacao,                         ");
                SQL.Append("    Item.IdTrufa,                               ");
                SQL.Append("    Trufa.Recheio,                              ");
                SQL.Append("    Item.Quantidade,                            ");
                SQL.Append("    Convert(Decimal(10,2), Item.Quantidade*2) AS Valor   ");
                SQL.Append(" FROM                                           ");
                SQL.Append("    stItemSolicitacao Item                      ");
                SQL.Append(" INNER JOIN stTrufa Trufa ON                    ");
                SQL.Append("    Trufa.ID = Item.IdTrufa                     ");
                SQL.Append(" WHERE                                          ");
                SQL.Append("    Item.IDSolicitacao = " + IdSolicitacao + "  ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno.Load(dr);

                conn.Close();
            }
            catch (Exception)
            {
                return null;
            }
            return retorno;            
        }
        public string IncluirItemSolicitacao(string IdSolicitacao, string IdTrufa, string Quantidade)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" INSERT INTO stItemSolicitacao( ");
                SQL.Append("    IdSolicitacao,              ");
                SQL.Append("    IdTrufa,                    ");
                SQL.Append("    Quantidade)                 ");
                SQL.Append(" VALUES(                        ");
                SQL.Append("    " + IdSolicitacao + ",      ");
                SQL.Append("    " + IdTrufa + ",            ");
                SQL.Append("    " + Quantidade + ")         ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string DeletarItemSolicitacao(string ID)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" DELETE FROM stItemSolicitacao WHERE ID = " + ID);

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }

        // Usuario
        public string CreateTableUsuario()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" CREATE TABLE stUsuario(                                ");
                SQL.Append("    ID          int NOT NULL IDENTITY(1,1) PRIMARY KEY, ");
                SQL.Append("    WhatsApp    varchar(15) NOT NULL,                   ");
                SQL.Append("    Nome        varchar(50) NOT NULL,                   ");
                SQL.Append("    Email       varchar(100) NOT NULL,                  ");
                SQL.Append("    Senha       varchar(32) NOT NULL,                   ");
                SQL.Append("    Privilegio  varchar(1) NOT NULL DEFAULT 'C')        "); 

                // A Administrador
                // V Vendedor
                // C Cliente
                // I Inativo

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Create Table stUsuario Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string DropTableUsuario()
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" DROP TABLE stUsuario    ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "Drop Table stUsuario Success ! ";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public bool AutenticaUsuario(string WhatsApp, string Senha)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Nome,                       ");
                SQL.Append("    Email                       ");
                SQL.Append(" FROM stUsuario                 ");
                SQL.Append(" WHERE                          ");
                SQL.Append("    WhatsApp = '" + WhatsApp + "' ");
                SQL.Append(" AND Senha = '" + Senha + "'    ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                return (dr.Read());
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ExisteUsuario(string WhatsApp)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Nome,                       ");
                SQL.Append("    Email                       ");
                SQL.Append(" FROM stUsuario                 ");
                SQL.Append(" WHERE                          ");
                SQL.Append("    WhatsApp = '" + WhatsApp + "' ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                return (dr.Read());
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable ListaUsuario()
        {
            try
            {
                DataTable retorno = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Nome,                       ");
                SQL.Append("    Email                       ");
                SQL.Append(" FROM stUsuario                 ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno.Load(dr);

                conn.Close();

                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ListaUsuario(string WhatsApp)
        {
            try
            {
                DataTable retorno = new DataTable();
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" SELECT                         ");
                SQL.Append("    ID,                         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Nome,                       ");
                SQL.Append("    Email,                      ");
                SQL.Append("    Privilegio                  ");
                SQL.Append(" FROM stUsuario                 ");
                SQL.Append(" WHERE                          ");
                SQL.Append("    WhatsApp = '" + WhatsApp + "' ");

                SqlDataReader dr = new SqlCommand(SQL.ToString(), conn).ExecuteReader();

                retorno.Load(dr);

                conn.Close();

                return retorno;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public string IncluirUsuario(string WhatsApp, string Nome, string Email, string Senha)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" INSERT INTO stUsuario(         ");
                SQL.Append("    WhatsApp,                   ");
                SQL.Append("    Nome,                       ");
                SQL.Append("    Email,                      ");
                SQL.Append("    Senha)                      ");
                SQL.Append(" VALUES(                        ");
                SQL.Append("    '" + WhatsApp + "',         ");
                SQL.Append("    '" + Nome + "',             ");
                SQL.Append("    '" + Email + "',            ");
                SQL.Append("    '" + Senha + "')            ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string AtualizaUsuario(string WhatsApp, string Nome, string Email, string Senha)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" UPDATE stUsuario SET               ");
                SQL.Append("    Nome = '" + Nome + "',          ");
                SQL.Append("    Email = '" + Email + "',        ");
                SQL.Append("    Senha = '" + Senha + "'         ");
                SQL.Append(" WHERE                              ");
                SQL.Append("    WhatsApp = '" + WhatsApp + "'   ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string AtualizaPrivilegioUsuario(string WhatsApp, string Privilegio)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" UPDATE stUsuario SET               ");
                SQL.Append("    Privilegio = '" + Privilegio+ "' ");
                SQL.Append(" WHERE                              ");
                SQL.Append("    WhatsApp = '" + WhatsApp + "'   ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

                conn.Close();
            }
            catch (Exception ex)
            {
                retorno = "Sorry, an exception occurred ! " + ex.Message;
            }

            return retorno;
        }
        public string AtualizaSenhaUsuario(string WhatsApp, string Senha)
        {
            string retorno = "";

            try
            {
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();

                StringBuilder SQL = new StringBuilder();
                SQL.Append(" UPDATE stUsuario SET               ");
                SQL.Append("    Senha = '" + Senha + "'         ");
                SQL.Append(" WHERE                              ");
                SQL.Append("    WhatsApp = '" + WhatsApp + "'   ");

                new SqlCommand(SQL.ToString(), conn).ExecuteNonQuery();

                retorno = "OK!";

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
