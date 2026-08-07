namespace MyApp;

/// <summary>
/// Clase principal del programa.
/// Inicializa la calculadora y ejecuta las operaciones solicitadas por el usuario.
/// </summary>
/// <author>Cristian Alexis Lucio Narváez</author>
/// <remarks>
/// Este programa se ejecuta desde el método Main.
/// Permite ingresar datos por consola y mostrar resultados.
/// </remarks>
internal class Programa
{
    /// <summary>
    /// Método principal del programa.
    /// Crea una calculadora y ejecuta operaciones de suma y multiplicación.
    /// </summary>
    /// <param name="args">Argumentos de línea de comandos (no utilizados).</param>
    static void Main(string[] args)
    {
        // Instancia de la calculadora
        Calculadora calculadora = new Calculadora();

        // Crear operación de suma
        IOperacion suma = new OperacionSuma();
        suma.SetOperador(5, 3);
        Console.WriteLine("Suma: " + calculadora.EjecutarOperacion(suma));

        // Crear operación de multiplicación
        IOperacion multiplicacion = new OperacionMultiplicacion();
        multiplicacion.SetOperador(5, 3);
        Console.WriteLine("Multiplicación: " + calculadora.EjecutarOperacion(multiplicacion));
    }
}

