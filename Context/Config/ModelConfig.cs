using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Config
{

    public class AreaConfig : EntityTypeConfiguration<Area>
    {
        public AreaConfig()
        {
            HasRequired(p => p.Departamento).WithMany(p =>p.Areas).HasForeignKey(p => p.DeparatmentoId).WillCascadeOnDelete(false);
            //HasRequired(p => p.Encargado).WithOptional(p => p.Area).WillCascadeOnDelete(false);
        }
    }
    public class BitacoraConfig : EntityTypeConfiguration<Bitacora>
    {
        public BitacoraConfig()
        {
            //HasRequired(p => p.Maquinaria).WithOptional(p => p.Bitacora).WillCascadeOnDelete(false);
           // HasRequired(p => p.Periodo).WithOptional(p => p.Bitacora).WillCascadeOnDelete(false);
        }
    }

    public class DepartamentoConfig : EntityTypeConfiguration<Departamento>
    {
        public DepartamentoConfig()
        {
            //HasRequired(p => p.Maquinaria).WithOptional(p => p.Bitacora).WillCascadeOnDelete(false);  
        }
    }

    public class EmpleadoConfig : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoConfig()
        {
            //HasRequired(p => p.Departamento).WithOptional(p => p.Encargado).WillCascadeOnDelete(false);
            HasRequired(p => p.Departamento).WithMany(p => p.Empleados).HasForeignKey(p => p.DepartamentoId).WillCascadeOnDelete(false);
           // HasOptional(p => p.Area).WithOptionalDependent(p => p.Encargado).WillCascadeOnDelete(false);
        }
    }
    public class EmpresaConfig : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfig()
        {
            
        }
    }
    public class InsumoConfig : EntityTypeConfiguration<Insumo>
    {
        public InsumoConfig()
        {
            HasRequired(p => p.InsumoUtilizado).WithMany(p => p.Insumos).HasForeignKey(p => p.InsumoUtilizadoId).WillCascadeOnDelete(true);
        }
    }
    public class InsumoUtilizadoConfig : EntityTypeConfiguration<InsumoUtilizado>
    {
        public InsumoUtilizadoConfig()
        {  

        }
    }
    public class MantenimientoConfig : EntityTypeConfiguration<Mantenimiento>
    {
        public MantenimientoConfig()
        {
            HasRequired(p => p.InsumoUtilizado).WithMany(p => p.Mantenimientos).HasForeignKey(p => p.InsumoUtilizadoId).WillCascadeOnDelete(true);
            HasRequired(p => p.Bitacora).WithMany(p => p.Mantenimientos).HasForeignKey(p => p.BitacoraId).WillCascadeOnDelete(true);
            HasRequired(p => p.Plan).WithMany(p => p.Mantenimientos).HasForeignKey(p => p.PlanId).WillCascadeOnDelete(true);
            //HasOptional(p => p.AprobadoPor).WithOptionalDependent(p => p.Mantenimiento).WillCascadeOnDelete(false);
        }
    }
    public class MaquinariaConfig : EntityTypeConfiguration<Maquinaria>
    {
        public MaquinariaConfig()
        {
            HasRequired(p => p.Area).WithMany(p=>p.Maquinarias).HasForeignKey(p => p.AreaId).WillCascadeOnDelete(false);
            //HasRequired(p => p.Bitacora).WithOptional(p => p.Maquinaria).WillCascadeOnDelete(false);
            //HasRequired(p => p.MaquinariaContable).WithOptional(p => p.Maquinaria).WillCascadeOnDelete(false);
            //HasRequired(p => p.MaquinariaEspecificacion).WithOptional(p => p.Maquinaria).WillCascadeOnDelete(false);
            //HasRequired(p => p.MaquinariaFabricante).WithOptional(p => p.Maquinaria).WillCascadeOnDelete(false);
            HasRequired(p => p.Area).WithMany(p => p.Maquinarias).HasForeignKey(p=>p.AreaId).WillCascadeOnDelete(false);
        }
    }
    public class MunuOpcionConfig : EntityTypeConfiguration<MenuOpcion>
    {
        public MunuOpcionConfig()
        {
            HasRequired(p => p.OpcionesRol).WithMany(p => p.OpcionesMenu).HasForeignKey(p => p.OpcionesRolId).WillCascadeOnDelete(false);
        }
    }
    public class MotivoReprogramacionConfig : EntityTypeConfiguration<MotivoReprogramacion>
    {
        public MotivoReprogramacionConfig()
        {  
        }
    }
    public class NotificacionConfig : EntityTypeConfiguration<Notificacion>
    {
        public NotificacionConfig()
        {
        }
    }
    public class PeriodoConfig : EntityTypeConfiguration<Periodo>
    {
        public PeriodoConfig()
        {
        }
    }
    public class PlanConfig : EntityTypeConfiguration<Plan>
    {
        public PlanConfig()
        {
            //HasRequired(p => p.Periodo)..WithOptional(p => p.Plan).WillCascadeOnDelete(false);
        }
    }

    public class ReprogramacionConfig : EntityTypeConfiguration<Reprogramacion>
    {
        public ReprogramacionConfig()
        {
           // HasRequired(p => p.Motivo).WithOptional(p => p.Reprogramacion).WillCascadeOnDelete(false);
            HasRequired(p => p.Mantenimiento).WithMany(p => p.Reprogramaciones).HasForeignKey(p => p.MantenimientoId).WillCascadeOnDelete(false);
        }
    }
    public class RolOpcionConfig : EntityTypeConfiguration<RolOpcion>
    {
        public RolOpcionConfig()
        {    
            HasRequired(p => p.Rol).WithMany(p => p.OpcionesRol).HasForeignKey(p => p.RolId).WillCascadeOnDelete(false);
        }
    }
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            //HasRequired(p => p.Empleado).WithOptional(p => p.Usuario).WillCascadeOnDelete(false);
        }
    }

}
