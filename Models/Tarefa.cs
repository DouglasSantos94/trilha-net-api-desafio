using System;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TrilhaApiDesafio.Models
{
    public class Tarefa
    {
        
        [SwaggerSchema(ReadOnly = true)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusTarefa Status { get; set; }
    }
}