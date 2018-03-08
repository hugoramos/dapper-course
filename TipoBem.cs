using System;
using Dapper.Contrib.Extensions;

namespace dapperapi
{
    [Table("TipoBem")]
    public class TipoBem
    {
        [Key]
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }
}