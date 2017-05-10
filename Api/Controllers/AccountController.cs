using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class AccountController : ApiController
    {
        static IList<Account> _list = new List<Account>()
        {
            new Account() { Id=1,  Name= "Alpha", Location = "Plano"},
            new Account() { Id=2, Name= "Beta", Location = "McKinney"}
        };

        // GET api/account
        public IEnumerable<Account> Get()
        {
            return _list;
        }

        // GET api/account/5
        public Account Get(int id)
        {
            return _list.Where(item => item.Id == id).FirstOrDefault();
        }

        // POST api/account
        public void Post([FromBody]Account accont)
        {
            _list.Add(accont);
        }

        // PUT api/account/5
        public Account Put(int id, [FromBody]Account value)
        {
            var found = _list.Where(item => item.Id == id).FirstOrDefault();
            if (found != null)
            {
                found = value;
                return found;
            }
            return null;
        }

        // DELETE api/account/5
        public void Delete(int id)
        {
            _list.Remove(_list.Where(item => item.Id == id).FirstOrDefault());
        }
    }
}
