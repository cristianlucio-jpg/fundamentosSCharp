namespace MyApp;

/// <summary>
/// Clase que representa la operación de multiplicación.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
class OperacionMultiplicacion : IOperacion
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
    /// Calcula la multiplicación de los dos operandos.
    /// </summary>
    /// <returns>Resultado de operandoUno * operandoDos.</returns>
    public double calcularOperacion()
    {
        return operandoUno * operandoDos;
    }
}
