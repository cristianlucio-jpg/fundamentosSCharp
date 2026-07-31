namespace MyApp;

/// <summary>
/// Clase que representa la operación de multiplicación.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>

class operacionMultiplicacion : operacion
{
    /// <summary>
    /// Calcula la multiplicación de los dos operandos.
    /// </summary>
    /// <returns>Resultado de operandoUno * operandoDos.</returns>
    public override double calcularOperacion()
    {
        return operandoUno * operandoDos;
    }
}
