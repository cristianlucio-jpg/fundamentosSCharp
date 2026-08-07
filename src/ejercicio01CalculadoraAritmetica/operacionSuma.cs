namespace MyApp;

/// <summary>
/// Clase que representa la operación de suma.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
class OperacionSuma : IOperacion
{
    private double operandoUno;
    private double operandoDos;

    /// <summary>
    /// Asigna los valores de los operadores.
    /// </summary>
    public void SetOperador(double operandoUno, double operandoDos)
    {
        this.operandoUno = operandoUno;
        this.operandoDos = operandoDos;
    }

    /// <summary>
    /// Calcula la suma de los dos operandos.
    /// </summary>
    /// <returns>Resultado de operandoUno + operandoDos.</returns>
    public double calcularOperacion()
    {
        return operandoUno + operandoDos;
    }
}
