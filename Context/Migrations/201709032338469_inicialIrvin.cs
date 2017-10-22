namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicialIrvin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        DeparatmentoId = c.Int(nullable: false),
                        EncargadoId = c.Int(),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.DeparatmentoId)
                .ForeignKey("dbo.Empleado", t => t.EncargadoId)
                .Index(t => t.DeparatmentoId)
                .Index(t => t.EncargadoId);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        EncargadoId = c.Int(),
                        EmpresaId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empresa", t => t.EmpresaId, cascadeDelete: true)
                .ForeignKey("dbo.Empleado", t => t.EncargadoId)
                .Index(t => t.EncargadoId)
                .Index(t => t.EmpresaId);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Dui = c.String(),
                        TelefonoPrincipal = c.String(),
                        TelefonoSecundario = c.String(),
                        Especialidad = c.String(),
                        AreaExperiencia = c.String(),
                        Sexo = c.Int(nullable: false),
                        Direccion = c.String(),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DepartamentoId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoId)
                .Index(t => t.DepartamentoId);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Siglas = c.String(),
                        Logo = c.String(),
                        Direccion = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Maquinaria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Nombre = c.String(),
                        Marca = c.String(),
                        Modelo = c.String(),
                        Serie = c.String(),
                        Matricula = c.String(),
                        NombreTroquel = c.String(),
                        TipoMaquina = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        MaquinariaFabricanteId = c.Int(nullable: false),
                        MaquinariaEspecificacionId = c.Int(nullable: false),
                        MaquinariaContableId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Area", t => t.AreaId)
                .ForeignKey("dbo.MaquinariaContable", t => t.MaquinariaContableId, cascadeDelete: true)
                .ForeignKey("dbo.MaquinariaEspecificacion", t => t.MaquinariaEspecificacionId, cascadeDelete: true)
                .ForeignKey("dbo.MaquinariaFabricante", t => t.MaquinariaFabricanteId, cascadeDelete: true)
                .Index(t => t.AreaId)
                .Index(t => t.MaquinariaFabricanteId)
                .Index(t => t.MaquinariaEspecificacionId)
                .Index(t => t.MaquinariaContableId);
            
            CreateTable(
                "dbo.MaquinariaContable",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaCompra = c.DateTime(nullable: false),
                        VidaPromedio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PeriodoGarantia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaquinariaEspecificacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreaMin = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ancho = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Altura = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Peso = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VoltajeConexion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TemperaturaAmbiente = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Humedad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Potencia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AreaCorte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AnguloCorte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CapacidadCorte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FuerzaCorte = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FuerzaPiston = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MotorTipo = c.String(),
                        MotorRevoluciones = c.String(),
                        MotorNumero = c.String(),
                        VelocidadRotacion = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BombaHidraulica = c.Boolean(nullable: false),
                        BateriaMarca = c.String(),
                        CeldasBateria = c.String(),
                        TipoCombustible = c.Int(nullable: false),
                        CantidadCombustible = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoAceite = c.String(),
                        CantidadAceite = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FrecAnualMto = c.Int(nullable: false),
                        Manual = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaquinariaFabricante",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Telefono = c.String(),
                        Email = c.String(),
                        Asistencia = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bitacora",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaquinariaId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Maquinaria", t => t.MaquinariaId, cascadeDelete: true)
                .Index(t => t.MaquinariaId);
            
            CreateTable(
                "dbo.Mantenimiento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoMantenimiento = c.Int(nullable: false),
                        FechaInicioProgramada = c.DateTime(nullable: false),
                        HoraInicioProgramada = c.DateTime(nullable: false),
                        FechaFinProgramada = c.DateTime(nullable: false),
                        HoraFinProgramada = c.DateTime(nullable: false),
                        Estado = c.Int(nullable: false),
                        Observaciones = c.String(),
                        AprobadoPorId = c.Int(),
                        BitacoraId = c.Int(nullable: false),
                        PlanId = c.Int(nullable: false),
                        InsumoUtilizadoId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleado", t => t.AprobadoPorId)
                .ForeignKey("dbo.Bitacora", t => t.BitacoraId, cascadeDelete: true)
                .ForeignKey("dbo.InsumoUtilizado", t => t.InsumoUtilizadoId, cascadeDelete: true)
                .ForeignKey("dbo.Plan", t => t.PlanId, cascadeDelete: true)
                .Index(t => t.AprobadoPorId)
                .Index(t => t.BitacoraId)
                .Index(t => t.PlanId)
                .Index(t => t.InsumoUtilizadoId);
            
            CreateTable(
                "dbo.InsumoUtilizado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cantidad = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Insumo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        UnidadMedida = c.String(),
                        Descripcion = c.String(),
                        Marca = c.String(),
                        PrecioUnitario = c.String(),
                        InsumoUtilizadoId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.InsumoUtilizado", t => t.InsumoUtilizadoId, cascadeDelete: true)
                .Index(t => t.InsumoUtilizadoId);
            
            CreateTable(
                "dbo.Plan",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaElaboracion = c.DateTime(nullable: false),
                        FechaAprobacion = c.DateTime(nullable: false),
                        ElaboradoPorId = c.Int(),
                        AprobadoPorId = c.Int(),
                        PeriodoId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleado", t => t.AprobadoPorId)
                .ForeignKey("dbo.Empleado", t => t.ElaboradoPorId)
                .ForeignKey("dbo.Periodo", t => t.PeriodoId, cascadeDelete: true)
                .Index(t => t.ElaboradoPorId)
                .Index(t => t.AprobadoPorId)
                .Index(t => t.PeriodoId);
            
            CreateTable(
                "dbo.Periodo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaInicio = c.DateTime(nullable: false),
                        FechaFin = c.DateTime(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reprogramacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoMantenimiento = c.Int(nullable: false),
                        FechaReprogramacion = c.DateTime(nullable: false),
                        HoraReprogramaciona = c.DateTime(nullable: false),
                        Observaciones = c.String(),
                        MantenimientoId = c.Int(nullable: false),
                        MotivoId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mantenimiento", t => t.MantenimientoId)
                .ForeignKey("dbo.MotivoReprogramacion", t => t.MotivoId, cascadeDelete: true)
                .Index(t => t.MantenimientoId)
                .Index(t => t.MotivoId);
            
            CreateTable(
                "dbo.MotivoReprogramacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Codigo = c.String(),
                        Descripcion = c.String(),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuOpcion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Controller = c.String(),
                        Metodo = c.String(),
                        OpcionesRolId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RolOpcion", t => t.OpcionesRolId, cascadeDelete: true)
                .Index(t => t.OpcionesRolId);
            
            CreateTable(
                "dbo.RolOpcion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Habilitado = c.Boolean(nullable: false),
                        RolId = c.String(nullable: false, maxLength: 128),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetRoles", t => t.RolId)
                .Index(t => t.RolId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        EmpleadoId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoId, cascadeDelete: true)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex")
                .Index(t => t.EmpleadoId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Notificacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaEnvio = c.DateTime(nullable: false),
                        FechaLectura = c.DateTime(nullable: false),
                        TipoNotificacion = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        StatusType = c.Int(nullable: false),
                        LastLogin = c.DateTime(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        EmpleadoId = c.Int(nullable: false),
                        LastUpdate = c.DateTime(nullable: false),
                        ModifiedBy = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .ForeignKey("dbo.Empleado", t => t.EmpleadoId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.EmpleadoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "EmpleadoId", "dbo.Empleado");
            DropForeignKey("dbo.Usuario", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.RolOpcion", "RolId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetRoles", "EmpleadoId", "dbo.Empleado");
            DropForeignKey("dbo.MenuOpcion", "OpcionesRolId", "dbo.RolOpcion");
            DropForeignKey("dbo.Bitacora", "MaquinariaId", "dbo.Maquinaria");
            DropForeignKey("dbo.Reprogramacion", "MotivoId", "dbo.MotivoReprogramacion");
            DropForeignKey("dbo.Reprogramacion", "MantenimientoId", "dbo.Mantenimiento");
            DropForeignKey("dbo.Mantenimiento", "PlanId", "dbo.Plan");
            DropForeignKey("dbo.Plan", "PeriodoId", "dbo.Periodo");
            DropForeignKey("dbo.Plan", "ElaboradoPorId", "dbo.Empleado");
            DropForeignKey("dbo.Plan", "AprobadoPorId", "dbo.Empleado");
            DropForeignKey("dbo.Mantenimiento", "InsumoUtilizadoId", "dbo.InsumoUtilizado");
            DropForeignKey("dbo.Insumo", "InsumoUtilizadoId", "dbo.InsumoUtilizado");
            DropForeignKey("dbo.Mantenimiento", "BitacoraId", "dbo.Bitacora");
            DropForeignKey("dbo.Mantenimiento", "AprobadoPorId", "dbo.Empleado");
            DropForeignKey("dbo.Maquinaria", "MaquinariaFabricanteId", "dbo.MaquinariaFabricante");
            DropForeignKey("dbo.Maquinaria", "MaquinariaEspecificacionId", "dbo.MaquinariaEspecificacion");
            DropForeignKey("dbo.Maquinaria", "MaquinariaContableId", "dbo.MaquinariaContable");
            DropForeignKey("dbo.Maquinaria", "AreaId", "dbo.Area");
            DropForeignKey("dbo.Area", "EncargadoId", "dbo.Empleado");
            DropForeignKey("dbo.Area", "DeparatmentoId", "dbo.Departamento");
            DropForeignKey("dbo.Departamento", "EncargadoId", "dbo.Empleado");
            DropForeignKey("dbo.Departamento", "EmpresaId", "dbo.Empresa");
            DropForeignKey("dbo.Empleado", "DepartamentoId", "dbo.Departamento");
            DropIndex("dbo.Usuario", new[] { "EmpleadoId" });
            DropIndex("dbo.Usuario", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", new[] { "EmpleadoId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.RolOpcion", new[] { "RolId" });
            DropIndex("dbo.MenuOpcion", new[] { "OpcionesRolId" });
            DropIndex("dbo.Reprogramacion", new[] { "MotivoId" });
            DropIndex("dbo.Reprogramacion", new[] { "MantenimientoId" });
            DropIndex("dbo.Plan", new[] { "PeriodoId" });
            DropIndex("dbo.Plan", new[] { "AprobadoPorId" });
            DropIndex("dbo.Plan", new[] { "ElaboradoPorId" });
            DropIndex("dbo.Insumo", new[] { "InsumoUtilizadoId" });
            DropIndex("dbo.Mantenimiento", new[] { "InsumoUtilizadoId" });
            DropIndex("dbo.Mantenimiento", new[] { "PlanId" });
            DropIndex("dbo.Mantenimiento", new[] { "BitacoraId" });
            DropIndex("dbo.Mantenimiento", new[] { "AprobadoPorId" });
            DropIndex("dbo.Bitacora", new[] { "MaquinariaId" });
            DropIndex("dbo.Maquinaria", new[] { "MaquinariaContableId" });
            DropIndex("dbo.Maquinaria", new[] { "MaquinariaEspecificacionId" });
            DropIndex("dbo.Maquinaria", new[] { "MaquinariaFabricanteId" });
            DropIndex("dbo.Maquinaria", new[] { "AreaId" });
            DropIndex("dbo.Empleado", new[] { "DepartamentoId" });
            DropIndex("dbo.Departamento", new[] { "EmpresaId" });
            DropIndex("dbo.Departamento", new[] { "EncargadoId" });
            DropIndex("dbo.Area", new[] { "EncargadoId" });
            DropIndex("dbo.Area", new[] { "DeparatmentoId" });
            DropTable("dbo.Usuario");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.Notificacion");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.RolOpcion");
            DropTable("dbo.MenuOpcion");
            DropTable("dbo.MotivoReprogramacion");
            DropTable("dbo.Reprogramacion");
            DropTable("dbo.Periodo");
            DropTable("dbo.Plan");
            DropTable("dbo.Insumo");
            DropTable("dbo.InsumoUtilizado");
            DropTable("dbo.Mantenimiento");
            DropTable("dbo.Bitacora");
            DropTable("dbo.MaquinariaFabricante");
            DropTable("dbo.MaquinariaEspecificacion");
            DropTable("dbo.MaquinariaContable");
            DropTable("dbo.Maquinaria");
            DropTable("dbo.Empresa");
            DropTable("dbo.Empleado");
            DropTable("dbo.Departamento");
            DropTable("dbo.Area");
        }
    }
}
