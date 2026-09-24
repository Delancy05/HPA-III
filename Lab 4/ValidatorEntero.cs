using System;

namespace Lab_4
{
    public class ValidatorEntero : IValidadorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || !int.TryParse(valor, out int resultado) || resultado < 0)
            {
                MensajeError = "Debe ingresar un número entero válido.";
                return false;
            }
            return true;
        }
    }
}
