# Proyecto: fundamentosSCharp

## Descripción
Este proyecto contiene ejercicios en C# que aplican **conceptos fundamentales de programación orientada a objetos**.  
Los ejercicios están diseñados para reforzar la comprensión de clases abstractas, herencia, polimorfismo e interfaces, manteniendo un enfoque en **código limpio y documentado**.

## Objetivos
- Aplicar clases abstractas e interfaces.
- Implementar polimorfismo en operaciones matemáticas.
- Documentar con Javadoc/XML y mantener código modular y claro.

## Pilares aplicados
- **Abstracción:** Clase abstracta `operacion`.  
- **Herencia:** `OperacionSuma` y `OperacionMultiplicacion` heredan de `operacion`.  
- **Polimorfismo:** Sobrescritura del método `calcular`.  
- **Encapsulación:** Propiedades y clases organizadas.  

## Sobrecarga
- Métodos `calcular` sobrecargados para distintos tipos (`int`, `double`).  

- **SOLID:**
- **SRP (Responsabilidad Única):** Cada clase tiene una única responsabilidad       (`OperacionSuma` suma, `OperacionMultiplicacion` multiplica, `Calculadora` ejecuta operaciones).
- **OCP (Abierto/Cerrado):** El sistema está abierto a extensión (pueden añadirse nuevas operaciones) y cerrado a modificación.
- **LSP (Sustitución de Liskov):** Las subclases de `Operacion` pueden sustituir a la clase base sin alterar el comportamiento.
- **ISP (Segregación de Interfaces):** Se usan abstracciones (clase abstracta `Operacion`) para evitar dependencias innecesarias.
- **DIP (Inversión de Dependencias):** `Calculadora` depende de la abstracción `Operacion`, no de las clases concretas.

## Contenido del proyecto
| Ejercicio              | Clase/Archivo | Descripción |
|------------------------|---------------|-------------|
| CalculadoraAritmetica  | calculadora.cs, operacion.cs, operacionMultiplicacion.cs, operacionSuma.cs, programa.cs | Operaciones matemáticas básicas con polimorfismo. |

## Estructura del proyecto
```text
fundamentosSCharp/
├── src/
│   ├── calculadora.cs
│   ├── operacion.cs
│   ├── operacionSuma.cs
│   ├── operacionMultiplicacion.cs
│   └── programa.cs
├── .gitignore
├── README.md
├── LICENSE
└── fundamentosSCharp.csproj

## Ejemplo de ejecución
Suma: 5 + 3 = 8
Multiplicación: 5 * 3 = 15

## Autor
Cristian Alexis Lucio Narváez  
Proyecto académico y portafolio profesional en C#.
  