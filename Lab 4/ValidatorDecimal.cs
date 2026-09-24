using System;

namespace Lab_4
{
    public class ValidatorDecimal : IValidadorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || !decimal.TryParse(valor, out decimal resultado) || resultado < 0)
            {
                MensajeError = "Debe ingresar un número decimal válido.";
                return false;
            }
            return true;
        }
    }
}
