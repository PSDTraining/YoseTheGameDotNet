using Newtonsoft.Json;
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
        public object Get([FromUri]string number)
        {

            int userNumber = 0;
 

            if(!int.TryParse(number, out userNumber))
            {
                PrimeWithError pwr = new PrimeWithError();
                pwr.error = "not a number";
                pwr.number = number;
                //var serializeObject = JsonConvert.SerializeObject(pwr);
                return pwr;
            }

            PrimeWithResult newPrime = new PrimeWithResult();
            newPrime.number = number;
            newPrime.decomposition = new List<int>();

            while (userNumber >= 2)
            {
                newPrime.decomposition.Add(2);
                userNumber = userNumber / 2;
            }

            //var serializeObjectNum = JsonConvert.SerializeObject(newPrime);
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
           // int number = int.Parse(value);

           // Prime newPrime = new Prime();
           //// newPrime.number = number;
           // newPrime.decomposition = new List<int>();

           // while(number >= 0  )
           // {
           //     newPrime.decomposition.Add(2);
           // }
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



    }

    public class PrimeWithError : Prime
    {
        public string number;
        public string error;
    }

    public class PrimeWithResult : Prime
    {
        public string number;
        public List<int> decomposition;
    }
}
