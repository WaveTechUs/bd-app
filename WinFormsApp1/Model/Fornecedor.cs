using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Model
{
    class Fornecedor
    {
        [DisplayName("Nome do Fornecedor")]
        public string Nome { get; set; } = string.Empty;
    }
}
