namespace MyApp;

/// <summary>
/// Clase principal del programa (programa).
/// Inicializa la calculadora y ejecuta las operaciones solicitadas por el usuario.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
/// <remarks>
/// Este programa se ejecuta desde el método Main.
/// Permite ingresar datos por consola y mostrar resultados.
/// </remarks>

internal class programa
{
    /// <summary>
    /// Método principal del programa.
    /// Crea una calculadora y ejecuta operaciones de suma y multiplicación.
    /// </summary>
    /// <param name="args">Argumentos de línea de comandos (no utilizados).</param>
    static void Main(string[] args)
    {
        // Instancia de la calculadora
        calculadora calculadora = new calculadora();

        // Crear operación de suma
        operacion suma = new operacionSuma();
        // operador(operandoUno, operandoDos)
        suma.setOperador(5, 3);
        Console.WriteLine("Suma: " + calculadora.ejecutarOperacion(suma));

        // Crear operación de multiplicación
        operacion multiplicacion = new operacionMultiplicacion();
        // operador(operandoUno, operandoDos)
        multiplicacion.setOperador(5, 3);
        Console.WriteLine("Multiplicacion: " + calculadora.ejecutarOperacion(multiplicacion));
    }
}


