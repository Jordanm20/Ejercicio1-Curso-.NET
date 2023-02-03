using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace Ejercicio1_Curso_.NET.Models.DataModels
{
    public enum Nivel
    {
        Básico,
        Intermedio,
        Avanzado
    }

    public class Cursos:BaseEntity
    {
        [Required, StringLength(280)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string Description_Corta { get; set; } = string.Empty;
        [Required]
        public string Description_Larga { get; set; } = string.Empty;
        [Required]
        public string Publico_objetivo { get; set; } = string.Empty;
        [Required]
        public string Objetivos { get; set; } = string.Empty;
        [Required]
        public string Requisitos { get; set; } = string.Empty;
        [Required]
        public Nivel Nivel { get; set; }
    }
}
