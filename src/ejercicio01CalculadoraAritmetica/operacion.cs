namespace MyApp;

/// <summary>
/// Clase abstracta que define el contrato para operaciones matemáticas.
/// Contiene dos operadores y un método abstracto para calcular.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>

abstract class operacion
{
    // Operandos protegidos para ser usados por las subclases
    protected double operandoUno;
    protected double operandoDos;

    /// <summary>
    /// Asigna los valores de los operadores.
    /// </summary>
    /// <param name="operandoUno">Primer operando.</param>
    /// <param name="operandoDos">Segundo operando.</param>
    public void setOperador(double operandoUno, double operandoDos)
    {
        this.operandoUno = operandoUno;
        this.operandoDos = operandoDos;
    }

    /// <summary>
    /// Método abstracto que debe implementar cada operación.
    /// </summary>
    /// <returns>Resultado del cálculo.</returns>
    public abstract double calcularOperacion();
}




