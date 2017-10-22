using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public enum StatusType
    {
        [Description("PENDING")]
        PENDING = 0,
        [Description("ACTIVE")]
        ACTIVE = 1,
        [Description("SUSPENDED")]
        SUSPENDED = 2,
        [Description("CANCELLED")]
        CANCELLED = 3,
    }
    public enum Sexo
    {
        [Description("Masculino")]
        MASCULINO = 0,
        [Description("Femenino")]
        FEMENINO = 1,
    }
    public enum TipoMaquina
    {
        [Description("Automatica")]
        AUTOMATICA = 0,
        [Description("SemiAutomatica")]
        SEMIAUTOMATICA = 1,
        [Description("Mecanica")]
        MECANICA = 2,
    }
    public enum Combustible
    {
        [Description("Diesel")]
        DIESEL = 0,
        [Description("Especial")]
        ESPECIAL = 1,
        [Description("Super Especial")]
        SUPERESPECIAL = 2,
        [Description("Otro")]
        OTRO = 3,
    }
    public enum TipoMantenimiento
    {
        [Description("Preventivo")]
        PREVENTIVO = 0,
        [Description("Correctivo")]
        CORRECTIVO = 1, 
    }
    public enum EstadoMantenimiento
    {
        [Description("Programado")]
        PROGRAMADO = 0,
        [Description("En Proceso")]
        PROCESO = 1,
        [Description("En Pausa")]
        PAUSA = 2,
        [Description("Finalizado")]
        FINALIZADO = 3,
        [Description("Aprobado")]
        APROBADO = 4,
        [Description("Reprogramado")]
        REPROGRAMADO = 5,
    }
    public enum TipoNotificacion
    {
        [Description("Evento Proximo")]
        EVENTOPROXIMO = 0,
        [Description("Evento Reprogramado")]
        EVENTOREPROGRAMADO = 1,
        [Description("Evento Aprobado")]
        EVENTOAPROBADO = 2,
        [Description("Plan Finalizado")]
        PLANFINALIZADO = 3,
        [Description("Plan aprobado")]
        PLANAPROBADO = 4,
        [Description("Nueva Requisicion")]
        NUEVAREQUISICION = 5,
    }
}
