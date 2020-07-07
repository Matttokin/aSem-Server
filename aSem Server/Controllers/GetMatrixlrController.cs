using Newtonsoft.Json;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace aSem_Server.Controllers
{
    public class GetMatrixlrController : ApiController
    {
        public string Get(string id)
        {
            OracleDataReader d = req.send("SELECT * FROM matrixlr WHERE matrixlr.idrole = (SELECT idrole FROM userrole WHERE iduser = " + id + ")");
            d.Read();

            string[] mt = new string[10];
            for(int i = 1; i < 10; i++)
            {
                mt[i] = d[i].ToString();
            }

           return JsonConvert.SerializeObject(mt);
        }
           
    }
}
