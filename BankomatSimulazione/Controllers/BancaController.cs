using BankomatSimulazione.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimulazione.Controllers
{
    public class BancaController
    {
        private readonly IDbRepository _repo;

        public BancaController(IDbRepository repo)
        {
            _repo = repo;
        }

        public void GetBanche()
        {
            _repo.GetBancheAsync();
        }

        public void GetUtenti()
        {
            _repo.GetUtentiAsync();
        }

        public void GetFunzionalità()
        {
            _repo.GetFunzionalitaAsync();
        }

        public async Task LoginAsync(int a)
        {
            var banca = await _repo.GetBancheById(a);
            Console.WriteLine("Inserire username e password:");
            string user = Console.ReadLine();
            string psw = Console.ReadLine();
            _repo.LoginAsync(user, psw);
        }
    }
}
