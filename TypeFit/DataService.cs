using Microsoft.EntityFrameworkCore;

namespace TypeFit
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext context;

        public DataService(ApplicationContext context)
        {
            this.context = context;
        }

        public void InicializaDb()
        {
            context.Database.Migrate();
        }
    }
}