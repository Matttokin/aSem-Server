using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class getPasswordByIdController : ApiController
    {
        public string Get(string idUser)
        {
            OracleDataReader d = req.send("SELECT lab1.getPasswordById('" + idUser + "') as rez FROM DUAL");

            d.Read();

            return d.GetString(0);         
        }
    }
}
