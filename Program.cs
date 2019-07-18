
using System.Threading.Tasks;

namespace MyAudit
{
    class Program
    {
        static async Task Main(string[] args)
        {
           await AuditRunner.ExecuteAuditAsync("19272", 2);
        }
    }
}

