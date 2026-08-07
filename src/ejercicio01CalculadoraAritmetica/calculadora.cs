namespace MyApp;

/// <summary>
/// Clase que representa una calculadora capaz de ejecutar operaciones.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
class Calculadora
{
    /// <summary>
    /// Ejecuta una operación matemática.
    /// </summary>
    /// <param name="operacion">Objeto que implementa la interfaz IOperacion y define el cálculo.</param>
    /// <returns>Resultado de la operación.</returns>
    public double EjecutarOperacion(IOperacion operacion)
    {
        // Se delega el cálculo a la operación recibida
        return operacion.calcularOperacion();
    }
}


