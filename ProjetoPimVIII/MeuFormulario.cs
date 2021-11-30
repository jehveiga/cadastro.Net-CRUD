using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPimVIII
{
    // Classe para controlar a criação de Formulario para se ter somente um na abertura
    class MeuFormulario
    {
        public static FrmCadastroPessoas FormCadastro { get; set; }
        public static FrmConsultaPessoa FormConsulta { get; set; }
    }
}
