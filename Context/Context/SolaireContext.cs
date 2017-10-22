using Context.Config;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Context
{

    //public class ApplicationUser : IdentityUser
    //{
    //    public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
    //    {
    //        // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
    //        var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
    //        // Add custom user claims here
    //        return userIdentity;
    //    }

     
    //}




    public class SolaireContext : IdentityDbContext<ApplicationUser>
    {

        public SolaireContext(): base("DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet <Area> Areas { get; set; }
        public DbSet<IdentityUserRole> UserRoles { get; set; }
        public DbSet<IdentityUserClaim> UserClaims { get; set; }
        public DbSet<Bitacora> Bitacoras { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<InsumoUtilizado> InsumoUtilizados { get; set; }
        public DbSet<Mantenimiento> Mantenimientos { get; set; }
        public DbSet<Maquinaria> Maquinarias { get; set; }
        public DbSet<MaquinariaContable> MaquinariaContables { get; set; }
        public DbSet<MaquinariaEspecificacion> MaquinariaEspecificaciones { get; set; }
        public DbSet<MaquinariaFabricante> MaquinariaFabricantes { get; set; }
        public DbSet<MenuOpcion> MenuOpciones { get; set; }
        public DbSet<MotivoReprogramacion> MotivoReprogramaciones { get; set; }
        public DbSet<Notificacion> Noificaciones { get; set; }
        public DbSet<Periodo> Periodos { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<Reprogramacion> Reprogramaciones { get; set; }
        public DbSet<RolUsuario> RolUsuarios { get; set; }
        public DbSet<RolOpcion> RolOpciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new AreaConfig());
            modelBuilder.Configurations.Add(new BitacoraConfig());
            modelBuilder.Configurations.Add(new DepartamentoConfig());
            modelBuilder.Configurations.Add(new EmpleadoConfig());
            modelBuilder.Configurations.Add(new EmpresaConfig());
            modelBuilder.Configurations.Add(new InsumoConfig());
            modelBuilder.Configurations.Add(new InsumoUtilizadoConfig());
            modelBuilder.Configurations.Add(new MantenimientoConfig());
            modelBuilder.Configurations.Add(new MaquinariaConfig());
            modelBuilder.Configurations.Add(new MotivoReprogramacionConfig());
            modelBuilder.Configurations.Add(new NotificacionConfig());
            modelBuilder.Configurations.Add(new PeriodoConfig());
            modelBuilder.Configurations.Add(new PlanConfig());
            modelBuilder.Configurations.Add(new ReprogramacionConfig());
            modelBuilder.Configurations.Add(new RolOpcionConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());

        }


        

        public static SolaireContext Create()
        {
            return new SolaireContext();
        }
    }
}
