using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace yoseMVC.Controllers
{
    public class primeFactorsController : ApiController
    {
        // GET api/primefactors
        public Prime Get([FromUri]string number)
        {

            int userNumber = int.Parse(number);

            Prime newPrime = new Prime();
            newPrime.number = userNumber;
            newPrime.decomposition = new List<int>();

            while (userNumber >= 2)
            {
                newPrime.decomposition.Add(2);
                userNumber = userNumber / 2;
            }

            return newPrime;
        }

        // GET api/primefactors/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/primefactors
        public void Post([FromBody]string value)
        {

            
            int number = int.Parse(value);

            Prime newPrime = new Prime();
            newPrime.number = number;
            newPrime.decomposition = new List<int>();

            while(number >= 0  )
            {
                newPrime.decomposition.Add(2);
            }
        }

        // PUT api/primefactors/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/primefactors/5
        public void Delete(int id)
        {
        }
    }

    public class Prime
    {
        public int number;
        public List<int> decomposition;
    }
}
