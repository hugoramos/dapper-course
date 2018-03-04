using System;
using Dapper.Contrib.Extensions;

namespace dapperapi
{
    [Table("Manutencao")]
    public class Manutencao
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }
    }
}