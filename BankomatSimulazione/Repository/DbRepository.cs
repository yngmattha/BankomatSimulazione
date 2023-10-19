using BankomatSimulazione.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimulazione
{
    public class DbRepository : IDbRepository
    {
        private Context _ctx;
        public DbRepository(Context ctx)
        {

            _ctx = ctx;

        }

        public List<Banche> banche { get; set; } = new List<Banche>();
        public List<Utenti> utenti { get; set; } = new List<Utenti>();
        public List<Funzionalita> funzionalità { get; set; } = new List<Funzionalita>();

        public async Task<ICollection<Banche>> GetBancheAsync()
        {
            banche = await _ctx.Banche.ToListAsync();
            foreach (var b in banche)
            {
                Console.WriteLine($"id: {b.Id}");
                Console.WriteLine($"nome: {b.Nome}");
            }
            return banche;
            

        }

        public async Task<Banche> GetBancheById(int id)
        {
            return await _ctx.Banche.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<ICollection<Funzionalita>> GetFunzionalitaAsync()
        {

            return await _ctx.Funzionalita.ToListAsync();
        }

        public async Task<ICollection<Utenti>> GetUtentiAsync()
        {
            utenti = await _ctx.Utenti.ToListAsync();
            foreach (var u in utenti)
            {
                Console.WriteLine($"id: {u.Id}");
                Console.WriteLine($"nome: {u.NomeUtente}");
            }
            return utenti;
        }

        public async Task<Utenti> GetUtentiById(int id)
        {
            return await _ctx.Utenti.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Funzionalita> LoginAsync(string username, string password)
        {
            banche = await _ctx.Banche.ToListAsync();
            utenti = await _ctx.Utenti.ToListAsync();
            //var banca = await _ctx.Banche.Where(funzionalitàFirstOrDefaultAsync();
            var utente = _ctx.Utenti.Where( u => u.NomeUtente.Equals(username)).FirstOrDefault();
            if (utente == null)
            {
                Console.WriteLine("utente inesistente");
            }

            if(utente.Password == password)
            {
                Console.WriteLine($"benvenuto{utente.NomeUtente}");
                
            }


            return null;
        }
    }
}
