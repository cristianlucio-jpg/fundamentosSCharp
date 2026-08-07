namespace MyApp;

/// <summary>
/// Interfaz que define el contrato para operaciones matemáticas.
/// Contiene dos operadores y un método para calcular.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
interface IOperacion
{
    /// <summary>
    /// Asigna los valores de los operadores.
    /// </summary>
    /// <param name="operandoUno">Primer operando.</param>
    /// <param name="operandoDos">Segundo operando.</param>
    void SetOperador(double operandoUno, double operandoDos);

    /// <summary>
    /// Método que debe implementar cada operación.
    /// </summary>
    /// <returns>Resultado del cálculo.</returns>
    double calcularOperacion();
}
