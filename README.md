# Proyecto: fundamentosSCharp

## Descripción
Este proyecto contiene ejercicios en C# que aplican **conceptos fundamentales de programación orientada a objetos**.  
Los ejercicios están diseñados para reforzar la comprensión de clases abstractas, herencia, polimorfismo e interfaces, manteniendo un enfoque en **código limpio y documentado**.

---


## Objetivos
- Aplicar clases abstractas e interfaces.
- Implementar polimorfismo en operaciones matemáticas.
- Documentar con Javadoc/XML y mantener código modular y claro.

---

## Pilares aplicados
- **Abstracción:** Interfaz `IOperacion` define el contrato de las operaciones.  
- **Herencia:** `operacionSuma` y `operacionMultiplicacion` implementan la interfaz `IOperacion`.  
- **Polimorfismo:** Sobrescritura del método `calcularOperacion` en cada operación.  
- **Encapsulación:** Propiedades y clases organizadas para proteger datos.

---
  
## Sobrecarga
- Métodos `calcularOperacion` sobrecargados para distintos tipos (`int`, `double`).

---
  
## Principios SOLID
- **SRP (Responsabilidad Única):** Cada clase tiene una única responsabilidad (`operacionSuma` suma, `operacionMultiplicacion` multiplica, `calculadora` ejecuta operaciones).  
- **OCP (Abierto/Cerrado):** El sistema está abierto a extensión (pueden añadirse nuevas operaciones) y cerrado a modificación.  
- **LSP (Sustitución de Liskov):** Las clases que implementan `IOperacion` pueden sustituir a la interfaz sin alterar el comportamiento.  
- **ISP (Segregación de Interfaces):** Se usa la interfaz `IOperacion` para evitar dependencias innecesarias.  
- **DIP (Inversión de Dependencias):** `calculadora` depende de la abstracción `IOperacion`, no de las clases concretas.

---

## Contenido del proyecto
| Ejercicio              | Clase/Archivo | Descripción |
|------------------------|---------------|-------------|
| calculadoraAritmetica  | calculadora.cs, operacion.cs, operacionMultiplicacion.cs, operacionSuma.cs, programa.cs | Operaciones matemáticas básicas con polimorfismo. |

---

## Tecnologías usadas
- C#
- .NET SDK
- Visual Studio / Visual Studio Code

## Estructura del proyecto
```text
fundamentosSCharp/
├── src/
│   └── ejercicio01CalculadoraAritmetica/
│       ├── calculadora.cs
│       ├── operacion.cs
│       ├── operacionSuma.cs
│       ├── operacionMultiplicacion.cs
│       └── programa.cs
├── .gitignore
├── LICENSE
├── README.md
└── ejercicioCalculadoraAritmeticaSCharp.csproj

## Ejemplo de ejecución
Suma: 5 + 3 = 8
Multiplicación: 5 * 3 = 15

## Autor
Cristian Alexis Lucio Narváez  
Proyecto académico y portafolio profesional en C#.
  
