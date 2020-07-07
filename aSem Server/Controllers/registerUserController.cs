using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class registerUserController : ApiController
    {
        public string Get(string login, string password)
        {
            OracleDataReader d = req.send("SELECT lab1.registerUser('" + login + "','" + password + "') as rez FROM DUAL");

            d.Read();
            return d.GetInt32(0).ToString();
        }
    }
}
