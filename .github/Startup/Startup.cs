using System;

namespace Aplicacion.App.Dominio
{
    public class Startup
    {
        private IConfiguration _configuration;

        public object configuration {get; private set;}

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AddDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("ConexionSQL")));
            services.AddMvc(options =>
            {
                var policy = new AutorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                options.Filters.Add(new AuthorizeFilter(policy));

            }).AddXmlSerializerFormatters();
            services.AddScoped<IE-migranAlmacen;SQLE-migrantRepositorio>
            services.AddIdentity<UsuarioAplicacion, IdentityRoles>(options => { }).AddErrorDescriber<ErroresCastellano>().
            AddEntityFrameworkStores<AppDbContext>();

            services.configureAplicationCookie(options =>
            {
                options.LoginPath = "/Cuentas/Login";
                options.AccessDeniedPath = "/Cuentas/AccesoDenegado";
            });

            services.AddAuthentication().AddGoogle(opciones =>
            {
                opciones.IdCliente777728189931-tgetjaonklhk2v78u6gp584cup2hftnn.apps.googleusercontent.com;
                opciones.SecretoClienteGOCSPX-KDGSvNsHH1jAuwxu-Ncfkw6RXJrE;
            });

            services.Configure<IdentityOptions>(opciones =>
            {
                opciones.Password.RequiredLength = 8;
                opciones.Password.RequiredUniqueChars = 3;
                opciones.Password.RequireNonAlphanumeric = false;
        });
        }
    }
}
