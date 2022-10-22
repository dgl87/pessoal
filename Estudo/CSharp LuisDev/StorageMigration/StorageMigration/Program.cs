using System;

namespace StorageMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string tenantId = "5b27bcb80829731a00b48f94";
            string CorrelationId = "BOLETO_SINAF_100_03032022_1012_00578_8331741";
            string StoragePath = "/sinafseguros/boleto/03032022_00578/boleto_sinaf_100_03032022_1012_00578_8331741.pdf";
            string hash1 = tenantId.Substring(0, 12);
            string hash = tenantId.Substring(12);

            //var storageCorrelationId = ($"{tenantId.Substring(0, 12)}{CorrelationId}{tenantId.Substring(12)}{StoragePath}", Hashes.HashType.SHA256);
           // var storage = await _storageClient.GetStatusAsync(storageCorrelationId, cancellationToken)

            //var storageCorrelationId = StorageHash.GetHashString($"{tenantId.Substring(0, 12)}{item.CorrelationId}{tenantId.Substring(12)}{item.StoragePath}", Hashes.HashType.SHA256);
            //var storage = await _storageClient.GetStatusAsync(storageCorrelationId, cancellationToken)
        }
    }
}
