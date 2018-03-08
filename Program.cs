using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Dapper.Contrib.Extensions;

namespace dapperapi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // getTickets();

            var manutencao = getTicket(5);
            
            var newid = insert(new Accent() { Teste = "TIPO NOVO 2018" });
            Console.WriteLine(newid);

            // Console.WriteLine(manutencao.Descricao);
            
            // manutencao.Descricao = "Nova descricao2";
            
            // updateTicket(manutencao);
            
            // var manutencao2 = getTicket(5);
            
            // Console.WriteLine(manutencao.Descricao);
        }

        static int insert(Accent accent) {
            var connection = Db.GetOpenConnection();
            {
                  return (int)connection.Insert(accent);
            }
        }

        static void updateTicket(Manutencao manutencao)
        {
            var connection = Db.GetOpenConnection();
            {
                connection.Update(manutencao);
            }
        }

        static void getTickets()
        {
            var connection = Db.GetOpenConnection();
            {
                const string conn = @"SELECT Codigo, Descricao FROM Manutencao LIMIT 10";

                var result = connection.Query(conn).AsList();

                foreach (var ticket in result)
                {
                    Console.WriteLine(ticket);
                }
            }
        }

        static Manutencao getTicket(int codigo)
        {
            var connection = Db.GetOpenConnection();
            {
                var manutencao = connection.Get<Manutencao>(codigo);

                return manutencao;
            }
        }

    }
}
