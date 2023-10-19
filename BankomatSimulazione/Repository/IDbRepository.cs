using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatSimulazione.Repository
{
    public interface IDbRepository
    {
        Task<ICollection<Banche>> GetBancheAsync();
        Task<Banche> GetBancheById(int id);
        Task<Funzionalita> LoginAsync(string username, string password);
        Task<ICollection<Utenti>> GetUtentiAsync();
        Task<Utenti> GetUtentiById(int id);
        Task<ICollection<Funzionalita>> GetFunzionalitaAsync();
    }
}
