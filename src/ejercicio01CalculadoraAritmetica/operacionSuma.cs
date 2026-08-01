namespace MyApp;

/// <summary>
/// Clase que representa la operación de suma.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>

class operacionSuma : IOperacion
{
    /// <summary>
    /// Calcula la suma de los dos operandos.
    /// </summary>
    /// <returns>Resultado de operandoUno + operandoDos.</returns>
    public override double calcularOperacion()
    {
        return operandoUno + operandoDos;
    }
}