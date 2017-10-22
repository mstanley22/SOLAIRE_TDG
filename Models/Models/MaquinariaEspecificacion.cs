using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class MaquinariaEspecificacion:BaseModel
    {
        [Display(Name = "AreaMin", Prompt = "Area Minima de Trabajo")]
        public decimal AreaMin { get; set; }

        [Display(Name = "Ancho", Prompt = "Ancho")]
        public decimal Ancho { get; set; }

        [Display(Name = "Altura", Prompt = "Altura")]
        public decimal Altura { get; set; }

        [Display(Name = "Peso", Prompt = "Peso")]
        public decimal Peso { get; set; }

        [Display(Name = "VoltajeConexion", Prompt = "Voltaje de Conexion")]
        public decimal VoltajeConexion { get; set; }

        [Display(Name = "TemperaturaAmbiente", Prompt = "Temperatura del Ambiente")]
        public decimal TemperaturaAmbiente { get; set; }

        [Display(Name = "Humedad", Prompt = "Humedad Ambiental")]
        public decimal Humedad { get; set; }

        [Display(Name = "Potencia", Prompt = "Potencia")]
        public decimal Potencia { get; set; }

        [Display(Name = "AreaCorte", Prompt = "Area de Corte")]
        public decimal AreaCorte { get; set; }

        [Display(Name = "AnguloCorte", Prompt = "Angulo de Corte")]
        public decimal AnguloCorte { get; set; }

        [Display(Name = "CapacidadCorte", Prompt = "Capacidad de Corte")]
        public decimal CapacidadCorte { get; set; }

        [Display(Name = "FuerzaCorte ", Prompt = "Fuerza de Corte")]
        public decimal FuerzaCorte { get; set; }

        [Display(Name = "FuerzaPiston ", Prompt = "Fuerza del Piston")]
        public decimal FuerzaPiston { get; set; }

        [Display(Name = "MotorTipo ", Prompt = "Motor Tipo")]
        public string  MotorTipo { get; set; }

        [Display(Name = "RevolucionesMotor", Prompt = "Revoluciones del Motor")]
        public string MotorRevoluciones { get; set; }

        [Display(Name = "MotorNumero", Prompt = "Motor Numero")]
        public string  MotorNumero { get; set; }

        [Display(Name = "VelocidadRotacion", Prompt = "Velocidad de Rotacion")]
        public decimal VelocidadRotacion { get; set; }

        [Display(Name = "BombaHidraulica", Prompt = "Bomba Hidraulica")]
        public bool BombaHidraulica { get; set; }

        [Display(Name = "Bateria", Prompt = "Marca de Bateria")]
        public string BateriaMarca { get; set; }

        [Display(Name = "CeldasBateria", Prompt = "Numero de Celdas de la Bateria")]
        public string CeldasBateria { get; set; }

        [Display(Name = "TipoCombustible", Prompt = "Tipo de Combustible")]
        public Combustible TipoCombustible { get; set; }

        [Display(Name = "CantidadCombustible", Prompt = "Tamaño Tanque de Combustible")]
        public decimal CantidadCombustible { get; set; }

        [Display(Name = "TipoAceite", Prompt = "Tipo de Aceite")]
        public string TipoAceite { get; set; }

        [Display(Name = "CantidadAceite", Prompt = "Cantidad de Aceite")]
        public decimal CantidadAceite { get; set; }

        [Display(Name = "FrecAnualMto", Prompt = "Frecuencia Anual de Mantenimiento")]
        public int FrecAnualMto { get; set; }

        [Display(Name = "Manual", Prompt = "Manual")]
        public string Manual { get; set; }

        ////Maquinaria 1:1
        //public Maquinaria Maquinaria { get; set; }
        //public int MaquinariaId { get; set; }
    }
}
