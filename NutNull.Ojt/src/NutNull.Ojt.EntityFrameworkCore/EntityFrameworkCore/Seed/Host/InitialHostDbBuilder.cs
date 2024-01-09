namespace NutNull.Ojt.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly OjtDbContext _context;

        public InitialHostDbBuilder(OjtDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
