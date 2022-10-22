using System;
using System.Collections.Generic;

namespace EstudoNelio
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Estrutura Condicional (if - else)
            //int x = 10;

            ////Estrutura Condicional Simples
            //if (x / 2 == 5)
            //    Console.WriteLine($"{x} dividido por 2 é 5");

            ////Estrutura Condicional Composta
            //if (x == 10)
            //{
            //    Console.WriteLine("Parabéns");
            //    Console.WriteLine("Você tirou o valor 10");
            //}
            //else            
            //    Console.WriteLine("Tente novamente");

            ////Estrutura Condicional Encadeada
            //if (x < 12)
            //    Console.WriteLine("Bom dia");
            //else if (x < 18)
            //    Console.WriteLine("Boa tarde");
            //else
            //    Console.WriteLine("Boa Noite");
            #endregion

            #region Funções
            //    Console.WriteLine("Digite 3 números:");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());
            //    int c = Convert.ToInt32(Console.ReadLine());

            //    int resultado = Maior(a, b, c);
            //    Console.WriteLine($"O maior é {resultado}");
            //}
            //static int Maior(int a, int b, int c)

            //{
            //    int m = 0;
            //    if (a > b && a > c)
            //        m = a;
            //    else if (b > c)
            //        m = b;
            //    else
            //        m = c;
            //    return m;
            #endregion
            string tenantId = "57bf002600b4e11ab0e6074d";
            string projetoId = "journey-event-process-prod";
            
            string consultaSQL;
            DateTime StartDate = new DateTime(2021, 10, 03);
            DateTime EndDate = new DateTime(2021, 10, 05);

            foreach (DateTime tenantDay in EachDay(StartDate, EndDate))
            {                
                consultaSQL = $"CALL `{projetoId}.portoseguro.sp_merge_journey_customer`('{tenantId}', '{tenantDay.ToString("yyyy-MM-dd")}');\n"
                            + $"CALL `{projetoId}.portoseguro.sp_merge_journey_rate`('{tenantId}', '{tenantDay.ToString("yyyy-MM-dd")}');";
                Console.WriteLine(consultaSQL);

            }

            //metodo
            static IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
            {
                for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                    yield return day;
            }


            //journey -event-process-prod.portoseguro.sp_merge_journey_customer
            //    journey-event-process-prod.portoseguro.sp_merge_journey_rate

            //DECLARE p_tenant_id STRING DEFAULT "57bf002600b4e11ab0e6074d";
            //DECLARE ingestDate DEFAULT DATE "2021-09-19";
            //CALL `journey-event-process-prod.portoseguro.sp_merge_journey_customer`(p_tenant_id, ingestDate);
            //CALL `journey-event-process-prod.portoseguro.sp_merge_journey_rate`(p_tenant_id, ingestDate);

            //using CsvHelper;
            //using DirectOne.App.Journey.Enrich.Core.Models;
            //using DirectOne.App.Journey.Enrich.Core.Services;
            //using DirectOne.App.Journey.Enrich.Service.Repository;
            //using DirectOne.App.Journey.Enrich.Service.Services.Clients;
            //using DirectOne.App.Journey.Enrich.Service.Services.Extensions;
            //using DirectOne.App.Journey.Enrich.Tools.Migrate.Entities;
            //using DirectOne.App.Journey.Enrich.Tools.Migrate.Models;
            //using DirectOne.App.Journey.Enrich.Tools.Migrate.Models.DirectOne.App.Journey.Enrich.Core.Models;
            //using DirectOne.App.Journey.Enrich.Tools.Migrate.Services;
            //using DirectOne.App.Journey.Enrich.Tools.Services.Migrate;
            //using Google.Cloud.BigQuery.V2;
            //using Grpc.Net.Client;
            //using Microsoft.Extensions.Configuration;
            //using MongoDB.Bson;
            //using MongoDB.Driver;
            //using System;
            //using System.Collections.Generic;
            //using System.Diagnostics;
            //using System.Globalization;
            //using System.IO;
            //using System.Linq;
            //using System.Text.Json;
            //using System.Threading.Tasks;
            //using static Messages.DidaGrpcService;

            //namespace DirectOne.App.Journey.Enrich.Tools
            //{
            //    class Program
            //    {
            //        private static GrpcChannel channel;
            //        private static BigQueryClient client;
            //        private static EventRepository _enrichRepository;
            //        private static DidaGrpcServiceClient _didaClient;
            //        private static DidaService didaGRPCService;
            //        private static EnrichService enrichService;
            //        private static MigrateEventService _migrateService;
            //        private static MongoClient rootClient;
            //        private static EventRepository eventRepository;
            //        private static IConfigurationRoot config;

            //        private static string filesFolderPath = "";

            //        private static string mongoCnnRoot = "";
            //        private static string databaseConnectionName = "";
            //        private static string databaseJourneyName = "";
            //        private static string tenantId = "";
            //        private static string TenantExternalKey = "";
            //        private static string fileCountPath = "";

            //        static async Task Main(string[] args)
            //        {
            //            filesFolderPath = args[0];
            //            TenantExternalKey = args[1];
            //            mongoCnnRoot = args[2];
            //            databaseConnectionName = args[3];
            //            databaseJourneyName = args[4];
            //            tenantId = args[5];
            //            fileCountPath = args[6];

            //            Inicialize();

            //            Stopwatch stopWatchGeral = new Stopwatch();
            //            stopWatchGeral.Start();

            //            Stopwatch stopWatch1 = new Stopwatch();
            //            stopWatch1.Start();
            //            await MigrateEventsToJorneyV2Table();
            //            stopWatch1.Stop();

            //            TimeSpan ts = stopWatchGeral.Elapsed;

            //            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //            Console.WriteLine("Tempo total da migração dos arquivos " + elapsedTime);

            //            stopWatch1.Reset();

            //            stopWatch1.Start();
            //            await ReprocessLossEventsByDateRangeAsync();
            //            stopWatch1.Stop();

            //            ts = stopWatchGeral.Elapsed;

            //            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //            Console.WriteLine("Tempo total Importação Mongo " + elapsedTime);

            //            ts = stopWatchGeral.Elapsed;

            //            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}    ", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //            Console.WriteLine("Tempo total geral " + elapsedTime);
            //            Console.WriteLine("Total de Linhas Importadas " + CounterService.AllLines);
            //        }
            //        private static void Inicialize()
            //            {
            //                config = new ConfigurationBuilder()
            //                .SetBasePath(Directory.GetCurrentDirectory())
            //                .AddJsonFile("local.settings.json", false)
            //                .AddEnvironmentVariables()
            //                .Build();

            //                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", config.GetSection("GOOGLE_CREDENTIALS_PATH").Value);
            //                Environment.SetEnvironmentVariable("IsEnableJourneyEventV2", config.GetSection("IsEnableJourneyEventV2").Value);

            //                channel = GrpcChannel.ForAddress(config.GetSection("DIDAGRPC_URI").Value);
            //                client = BigQueryClient.CreateAsync(config.GetSection("PROJECT_ID").Value).GetAwaiter().GetResult();
            //                _enrichRepository = new EventRepository(client);
            //                _didaClient = new DidaGrpcServiceClient(channel);
            //                didaGRPCService = new DidaService(_didaClient);
            //                enrichService = new EnrichService(didaGRPCService, null, _enrichRepository, null);
            //                _migrateService = new MigrateEventService(didaGRPCService, _enrichRepository);
            //                rootClient = new MongoClient(mongoCnnRoot);
            //                eventRepository = new EventRepository(client);
            //            }


            //            DateTime startDate = new DateTime(2020, 01, 01);
            //            DateTime stopDate = new DateTime(2020, 12, 31);
            //            int interval = 1;

            //            for (DateTime dateTime = startDate;
            //                 dateTime <= stopDate;
            //                 dateTime += TimeSpan.FromDays(interval))
            //            {
            //                Console.WriteLine(dateTime);
        }
    }
}
