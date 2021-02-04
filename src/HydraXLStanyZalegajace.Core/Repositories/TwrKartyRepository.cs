#region using

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using HydraXLStanyZalegajace.Core.Models;

#endregion

namespace HydraXLStanyZalegajace.Core.Repositories
{
    public class TwrKartyRepository
    {
        public Exception TwrKartyRepositoryException { get; private set; }

        public bool HasException() => null != TwrKartyRepositoryException;

        public int GetTwrGIDNumerByTwrKod(SqlConnection sqlConnection, string twrKod) =>
            Task.Run(() =>
            {
                SqlCommand sqlCommand = null;
                SqlDataReader dataReader = null;
                var twrGidNumer = 0;
                try
                {
                    var twrKodSqlParameter = new SqlParameter("twrKod", SqlDbType.NChar) {Value = twrKod};
                    var sql =
                        $"SELECT Twr_GIDNumer FROM [CDN].[TwrKarty] WHERE [Twr_Kod] = N'{twrKodSqlParameter.Value}'"
                            .Trim();
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand(sql, sqlConnection);
                    dataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                    if (dataReader.Read())
                    {
                        twrGidNumer = Convert.ToInt32(dataReader["Twr_GIDNumer"]);
                    }

                    dataReader.Close();
                    sqlCommand.Connection.Close();
                }
                catch (Exception e)
                {
                    TwrKartyRepositoryException = e;
                    Console.WriteLine(e);
                }
                finally
                {
                    if (null != dataReader && !dataReader.IsClosed)
                    {
                        dataReader.Close();
                    }

                    if (null != sqlCommand?.Connection && sqlCommand?.Connection?.State == ConnectionState.Open)
                    {
                        sqlCommand.Connection.Close();
                    }
                }

                return twrGidNumer;
            }).Result;

        public List<StanyZalegajace>
            ISKZasobyNierotujaceZSOSStoredProcedure(SqlConnection sqlConnection, int twrGidNumer) =>
            Task.Run(() =>
            {
                SqlCommand sqlCommand = null;
                SqlDataReader dataReader = null;
                var stanyZalegajaceList = new List<StanyZalegajace>();
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("[CDN].[ISK_ZasobyNierotujace_ZS_OS]", sqlConnection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    sqlCommand.Parameters.Add(new SqlParameter("@id_towaru", SqlDbType.Int) {Value = twrGidNumer});
                    using (dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            var stanyZalegajace = new StanyZalegajace(
                                Convert.ToInt32(dataReader["TwZ_MagNumer"]),
                                Convert.ToString(dataReader["TwZ_MagKod"]),
                                Convert.ToString(dataReader["Mag_Nazwa"]),
                                Convert.ToInt32(dataReader["TwZ_TwrNumer"]),
                                Convert.ToString(dataReader["Twr_Kod"]),
                                Convert.ToString(dataReader["Twr_Nazwa"]),
                                Convert.ToDecimal(dataReader["TwZ_IlDok"])
                            );
                            stanyZalegajaceList.Add(stanyZalegajace);
                        }
                    }
                }
                catch (Exception e)
                {
                    TwrKartyRepositoryException = e;
                    Console.WriteLine(e);
                }
                finally
                {
                    if (null != dataReader && !dataReader.IsClosed)
                    {
                        dataReader.Close();
                    }

                    if (null != sqlCommand?.Connection && sqlCommand?.Connection?.State == ConnectionState.Open)
                    {
                        sqlCommand.Connection.Close();
                    }
                }

                return stanyZalegajaceList;
            }).Result;
    }
}
