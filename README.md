# McorzoMultiplyNumbers

McorzoMultiplyNumbers es una biblioteca sencilla para multiplicar números en C#. Este proyecto incluye un ejemplo básico de cómo usar la función `Multiply` para realizar una multiplicación de dos números.

## Características
- Multiplicación de dos números enteros.
- Ejemplo de implementación en un programa de consola.

## Requisitos
- .NET 6.0 o superior.

## Instalación
1. Clona este repositorio:
   ```bash
   git clone https://github.com/tuusuario/McorzoMultiplyNumbers.git
   ```
2. Navega al directorio del proyecto:
   ```bash
   cd McorzoMultiplyNumbers
   ```
3. Abre el proyecto en Visual Studio o tu editor preferido.

## Uso

El siguiente código muestra cómo utilizar la función `Multiply`:

```csharp
using System;

namespace McorzoMultiplyNumbers
{
    class Program
    {
        static void Main()
        {
            // Usar la función Multiply de MathHelper
            int result = MathHelper.Multiply(5, 3);
            Console.WriteLine($"Version:1.0.1");
            Console.WriteLine($"El resultado de 5 x 3 es: {result}");
        }
    }

    public static class MathHelper
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
```

### Salida esperada
Al ejecutar el programa, deberías ver lo siguiente en la consola:

```
Version:1.0.1
El resultado de 5 x 3 es: 15
```

## Contribución
¡Las contribuciones son bienvenidas! Si tienes sugerencias o mejoras, crea un pull request o abre un issue en el repositorio.

## Licencia
Este proyecto está bajo la Licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más detalles.

## Contacto
Creador: [Tu Nombre](https://github.com/tuusuario)

Si tienes preguntas o necesitas ayuda, no dudes en contactarme.

