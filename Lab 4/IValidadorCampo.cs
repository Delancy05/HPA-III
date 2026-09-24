using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    public interface IValidadorCampo
    {
        bool EsValido(string valor);
        string MensajeError { get; }
    }
}
