using System;
using Google.Apis.Bigquery.v2;
using Google.Apis.Bigquery.v2.Data;
using Google.Cloud.BigQuery.V2;

namespace ToolBigQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CursoBQCSharp001();
            CursoBQCSharp002();

            Console.WriteLine("Hello World!");
        }

        // Acesso ao Big Query
        static void CursoBQCSharp001()
        {
            // Tenant
            string projetoId = "journey-event-process-dev";  

            var client = BigQueryClient.Create(projetoId);
            Console.WriteLine($"Conexão como o projeto {projetoId} realizado com sucesso.");
        }
        static void CursoBQCSharp002()
        {
            // Tenant
            string projetoId = "acme";

            var client = BigQueryClient.Create(projetoId);
            Console.WriteLine($"Conexão como o projeto {projetoId} realizado com sucesso.");
            string consultaSQL = "SELECT * FROM `journey-event-process-dev.acme.journey_event_v2``";
            var resultadoSQL = client.ExecuteQuery(consultaSQL, null);
            Console.WriteLine("Sucesso");
        }

    }
}
