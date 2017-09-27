using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace OcrFunction
{
    public static class OcrFunc
    {
        [FunctionName("OcrFunc")]
        public static void Run([BlobTrigger("image-drops/{name}", Connection = "AzureWebJobsConnection")]Stream myBlob, string name, TraceWriter log)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
