using AppExam;
using AppExam.Authentication;
using AppExam.Helpers;
using AppExam.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppExam.Services
{
    public class AzureDataService<T> : AzureService
    {
        public Task<IEnumerable<T>> GetTable()
        {
            return Client.GetTable<T>().ToEnumerableAsync();
        }
    }
}
