namespace MyApp;

/// <summary>
/// Clase que representa una calculadora capaz de ejecutar operaciones.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
class calculadora
{
    /// <summary>
    /// Ejecuta una operación matemática.
    /// </summary>
    /// <param name="operacion">Objeto de tipo Operacion que define el cálculo.</param>
    /// <returns>Resultado de la operación.</returns>
    public double ejecutarOperacion(operacion operacion)
    {
        // Se delega el cálculo a la operación recibida
        return operacion.calcularOperacion();
    }
}

