
using System;
using Dapper.Contrib.Extensions;

namespace dapperapi
{
    [Table("Accent")]
    public class Accent
    {
        [Key]
        public int Codigo { get; set; }
        public string Teste { get; set; }
    }
}