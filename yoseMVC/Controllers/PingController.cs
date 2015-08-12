using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace yoseMVC.Controllers
{
    public class PingController : ApiController
    {
        // GET api/ping
        public test Get()
        {
            test newTest = new test();
            newTest.alive = true;

            return newTest;
        }



        // GET api/ping/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/ping
        public test Post([FromBody]string value)
        {
            test newTest = new test();
            newTest.alive = true;

            return newTest;
        }

        // PUT api/ping/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/ping/5
        public void Delete(int id)
        {
        }
    }

       public class test
    {
        public bool alive;
    }
}

