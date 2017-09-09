using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Web.Mvc;
using System.Collections;

namespace WMTSWebAPI.Controllers
{
    public class WMTSController : ApiController
    {
        // GET: api/WMTS
        public string Get()
        {
            //return new string[] { "value1", "value2" };
            SqlConnection objCnn = new SqlConnection(@"Data Source = 'DESKTOP-L2APFIE\SQLEXPRESS01'; Initial Catalog = 'WMTS'; Integrated Security = True; MultipleActiveResultSets = True");

            objCnn.Open();

            SqlCommand objCmd = new SqlCommand("select id, firstname, lastname from student", objCnn);
            SqlDataReader dr = objCmd.ExecuteReader();

            ArrayList objs = new ArrayList();

            while (dr.Read())
            {
                objs.Add(new
                {
                    Id = dr["id"],
                    firstname = dr["firstname"].ToString().Trim(),
                    lastname = dr["lastname"].ToString().Trim()
                });
            }


            string strTemp1 = JsonConvert.SerializeObject(objs);

            objCnn.Close();
            return strTemp1; 
        }

        // GET: api/WMTS/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WMTS
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WMTS/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WMTS/5
        public void Delete(int id)
        {
        }
    }
}
