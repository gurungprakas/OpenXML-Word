using System;
using System.Collections.Generic;
using System.Text;

namespace OpenXML.Models
{
    public class Constants
    {

        public readonly Student Student = new Student { StudentId = "200427531", FirstName = "Prakash", LastName = "Gurung" };


        public class FTP
        {
            public const string UserName = @"bdat100119f\bdat1001";
            public const string Password = "bdat1001";

            public const string BaseUrl = "ftp://waws-prod-dm1-127.ftp.azurewebsites.windows.net/bdat1001-20914";

            public const int OperationPauseTime = 10000;
        }
    }
}
