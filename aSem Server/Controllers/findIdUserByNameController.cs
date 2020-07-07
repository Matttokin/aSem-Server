using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class findIdUserByNameController : ApiController
    {
        public string Get(string login)
        {
            OracleDataReader d = req.send("SELECT lab1.findIdUserByName('" + login + "') FROM DUAL");

            d.Read();

            if (d.HasRows)
            {
                return d.GetInt32(0).ToString();
            }
            else
            {
                return (-1).ToString();
            }
        }
    }
}
