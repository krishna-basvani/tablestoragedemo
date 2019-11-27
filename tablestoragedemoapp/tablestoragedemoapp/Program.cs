using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace tablestoragedemoapp
{
    class Program
    {
        static void Main(string[] args)
        {
            CloudStorageAccount sa = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=krishnasademo;AccountKey=tImhMEV5Q+nu+MKDo5P9ycUXzXnwUUlO63sjrmdrrOXsTcLYunOIyZu/Bmw8IMUeKumaqfXMpE/roFcMdAklnw==;EndpointSuffix=core.windows.net");
            CloudTableClient tableClient = sa.CreateCloudTableClient();
            CloudTable table = tableClient.GetTableReference("employee");


        }
    }


}
