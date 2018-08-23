using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal.Model
{
    class PontosTuristicos
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
