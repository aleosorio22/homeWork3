using System;
class Menu
{
    static void MostrarMenu()
    {
        Console.WriteLine("1. Calcular mayor de 3 números");
        Console.WriteLine("2. Validación de la edad para entrar al club");
        Console.WriteLine("3. Calcular el precio final de un producto");
        Console.WriteLine("4. Validar usuario y contraseña");
        Console.WriteLine("5. Determinar si un número es par o impar");
        Console.WriteLine("6. Mostrar un mensaje de aprobación o rechazo de préstamo");
        Console.WriteLine("7. Calcular el área de una figura geométrica");
        Console.WriteLine("8. Convertir un número de letra a número");
        Console.WriteLine("9. Mostrar el día de la semana a partir de un número");
        Console.WriteLine("10. Calcular el importe a pagar por un servicio");
        Console.WriteLine("11. Mostrar un mensaje de bienvenida en diferentes idiomas");
        Console.WriteLine("12. Evaluar la calificación de un examen");
        Console.WriteLine("0. Salir");
    }

    static int ObtenerOpcion()
    {
        Console.Write("Elige una opción: ");
        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            return opcion;
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, introduce un nymero.");
            return -1;
        }
    }

    static int ObtenerNumero(string mensaje)
    {
        int numero = 0;
        bool entradaValida = false;

        do
        {
            try
            {
                Console.Write(mensaje);
                numero = Convert.ToInt32(Console.ReadLine());
                entradaValida = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingresa un número válido.");
            }
        } while (!entradaValida);

        return numero;
    }
    static void mayorde3()
    {
        Console.WriteLine("Calcular el Mayor de Tres Números");

        int n1 = ObtenerNumero("Ingresa el primer número: ");
        int n2 = ObtenerNumero("Ingresa el segundo número: ");
        int n3 = ObtenerNumero("Ingresa el tercer número: ");

        int mayor;

        if (n1 >= n2 && n1 >= n3)
        {
            mayor = n1;
        }
        else if (n2 >= n1 && n2 >= n3)
        {
            mayor = n2;
        }
        else
        {
            mayor = n3;
        }

        Console.WriteLine($"El mayor de {n1}, {n2} y {n3} es: {mayor}");
    }

    static void ValidarClub()
    {
        Console.WriteLine("Validar Edad para Ingresar a LeClub");

        int edad = 0;
        bool entradaValida = false;

        try
        {
            Console.Write("Ingresa tu edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 0)
            {
                entradaValida = true;
            }
            else
            {
                Console.WriteLine("Error: La edad no puede ser un número negativo.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingresa una edad válida (número entero).");
        }

        if (entradaValida)
        {
            if (edad >= 18)
            {
                Console.WriteLine("¡Bienvenido al LeClub! Puedes ingresar.");
            }
            else
            {
                Console.WriteLine("Lo siento, eres menor de 18 años. No puedes ingresar a LeClub.");
            }
        }
    }

    static double ObtenerPrecioOriginal()
    {
        double precio = 0;
        bool entValida = false;

        try
        {
            Console.Write("Ingresa el precio original del producto: Q");
            precio = Convert.ToDouble(Console.ReadLine());

            if (precio >= 0)
            {
                entValida = true;
            }
            else
            {
                Console.WriteLine("Error: El precio no puede ser un número negativo.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingresa un precio válido (número decimal).");
        }

        return precio;
    }

    static void CalcularPrecioFinal()
    {
        Console.WriteLine("Calcular el Precio Final de un Producto");

        double precioOriginal = ObtenerPrecioOriginal();
        double precioFinal;

        if (precioOriginal > 100)
        {
            precioFinal = precioOriginal * 0.9;
            Console.WriteLine($"Precio final con descuento: Q{precioFinal:F2}");
        }
        else
        {
            precioFinal = precioOriginal;
            Console.WriteLine($"Precio final sin descuento: Q{precioFinal:F2}");
        }
    }
    static void ObtenerCredenciales()
    {
        string usuario = "";
        string contrasena = "";

        try
        {
            Console.WriteLine("Escriba el usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine("Escriba la contrasena");
            contrasena = Console.ReadLine();

            if (usuario == "Usuario" && contrasena == "Contrasena")
            {
                Console.WriteLine("Credenciales Validas.");
            }
            else
            {
                Console.WriteLine("Credenciales invalidas.");
            }
            
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void ParImpar()
    {
        int numero = 0;

        try
        {
            Console.WriteLine("Ingresa un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} es un numero par. ");
            }
            else
            {
                Console.WriteLine($"{numero} es un numero impar. ");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingresa un numero entero.");
        }
    }

    static void Prestamo()
    {
        string usuario;
        int edad;
        double prestamo;

        try
        {
            Console.WriteLine("Ingrese el nombre del tramitante: ");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del tramitante: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad del prestamo a solicitar: ");
            prestamo = Convert.ToDouble(Console.ReadLine());

            if (edad > 60 || prestamo < 5000)
            {
                Console.WriteLine($"Senor(a) {usuario}, su credito fue aprobado. ");
            }
            else
            {
                Console.WriteLine($"Senor(a) {usuario}, lamentamblemente no podemos aprobar su credito:");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingresa montos y edades válidos.");
        }
    }

    static void CalcularArea()
    {
        const double pi = 3.141592653589793;
        try
        {
            Console.WriteLine("Ingrese el tipo de figura (triangulo, cuadrado, circulo): ");
            string tipoFigura = Console.ReadLine().ToLower();

            double area = 0;


            if (tipoFigura == "triangulo")
            {
                Console.WriteLine("Ingrese la base del triangulo");
                double baseTrian = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del triangulo");
                double alturaTrian = Convert.ToDouble(Console.ReadLine());

                area = 0.5 * baseTrian * alturaTrian;
            }
            else if (tipoFigura == "cuadrado")
            {
                Console.WriteLine("Ingrese el lado del cuadrado");
                double ladoCuad = Convert.ToDouble(Console.ReadLine());
                area = ladoCuad * ladoCuad;
            }
            else if (tipoFigura == "circulo")
            {
                Console.WriteLine("Ingrese el radio del circulo");
                double radio = Convert.ToDouble(Console.ReadLine());
                area = pi *  radio * radio;
            }
            else
            {
                Console.WriteLine("Tipo de figura no reconocido. Por favor, ingresa triángulo, cuadrado o círculo.");
                return;
            }
            Console.WriteLine($"El area de la figura {tipoFigura} es {area:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingresa dimensiones válidas (números).");
        }
    }

    static void LetraNumero()
    {
        Console.Write("Ingrese un número del 1 al 5 en letra (uno, dos, tres, cuatro, cinco): ");
        string numeroEnLetra = Console.ReadLine().ToLower();

        int numeroEnDigito;
        switch (numeroEnLetra)
        {
            case "uno":
                numeroEnDigito = 1;
                break;
            case "dos":
                numeroEnDigito = 2;
                break;
            case "tres":
                numeroEnDigito = 3;
                break;
            case "cuatro":
                numeroEnDigito = 4;
                break;
            case "cinco":
                numeroEnDigito = 5;
                break;
            default:
                Console.WriteLine("La entrada no es válida. Por favor, ingrese una de las opciones válidas.");
                return;
        }
        Console.WriteLine($"El número en dígito es: {numeroEnDigito}");
}

    static void DiaSemana()
    {
        Console.WriteLine("Ingrese un numero del 1 al 7:");
        int n = int.Parse(Console.ReadLine());

        string diaSemana;
        switch (n)
        {
            case 1:
                diaSemana = "lunes";
                break;
            case 2:
                diaSemana = "martes";
                break;
            case 3:
                diaSemana = "miercoles";
                break;
            case 4:
                diaSemana = "jueves";
                break;
            case 5:
                diaSemana = "viernes";
                break;
            case 6:
                diaSemana = "sabado";
                break;
            case 7:
                diaSemana = "domingo";
                break;
            default:
                Console.WriteLine("El numero que ingreso no es valido, ingrese un numero del 1 al 7.");
                return;
        }
        Console.WriteLine($"El dia de la semana correspondiente al numero {n} es: {diaSemana}.");
        
    }

    static void Servicio()
    {
        Console.Write("Ingrese el tipo de servicio (lavado de auto, cambio de aceite, revision de mecanica): ");
        string tipoServicio = Console.ReadLine().ToLower();

        double precioLavado = 15.0;
        double precioAceite = 230.0;
        double precioMecanica = 400.0;

        double totalPagar;
        switch (tipoServicio)
        {
            case "lavado de auto":
                totalPagar = precioLavado;
                break;
            case "cambio de aceite":
                totalPagar = precioAceite;
                break;
            case "revision de mecanica":
                totalPagar = precioMecanica;
                break;
            default:
                Console.WriteLine("El tipo de servicio que ingreso no existe o no es valido.");
                return;
        }
        Console.WriteLine($"El total a pagar es {totalPagar} por {tipoServicio}.");
    }

    static void Mensaje()
    {
        Console.WriteLine("Ingrese el idioma de su preferencia (Español, Ingles, Frances): ");
        string idioma = Console.ReadLine().ToLower();
        
        switch (idioma)
        {
            case "español":
                Console.WriteLine("Bienvenido Ingeniero");
                break;
            case "ingles":
                Console.WriteLine("Welcome Enginer");
                break;
            case "frances":
                Console.WriteLine("Bienvenue Ingenieur");
                break;
            default:
                Console.WriteLine("El idioma que ingreso no existe o no es valido");
                return;
        }
    }

    static void Calificacion()
    {
        Console.WriteLine("Ingrese la calificacion del examen");
        string entradaCalificacion = Console.ReadLine();

        if (int.TryParse(entradaCalificacion, out int calificacion))
        {
            string desempeno;
            switch (calificacion)
            {
                case var n when (n >= 95 && n <= 100):
                    desempeno = "Excelente";
                    break;
                case var n when (n >= 85 && n <= 94):
                    desempeno = "Normal";
                    break;
                case var n when (n >= 70 && n <= 84):
                    desempeno = "Pasable";
                    break;
                case var n when (n <= 60 && n <= 69):
                    desempeno = "Mala";
                    break;
                default:
                    desempeno = "Calificación no válida";
                    break;
            }
            Console.WriteLine($"Desempeño: {desempeno}");
        }
        else
        {
            Console.WriteLine("La entrada no es un número entero válido.");
        }
    }
    static void Main()
    {
        int opcion;

        do
        {
            MostrarMenu();
            opcion = ObtenerOpcion();   

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Seleccionaste: Calcular mayor de 3 números");
                    mayorde3();
                    break;
                case 2:
                    ValidarClub();
                    break;
                case 3:
                    CalcularPrecioFinal();
                    break;
                case 4:
                    Console.WriteLine("Seleccionaste: Validar usuario y contraseña");
                    ObtenerCredenciales();
                    break;
                case 5:
                    Console.WriteLine("Seleccionaste: Determinar si un número es par o impar");
                    ParImpar();
                    break;
                case 6:
                    Console.WriteLine("Seleccionaste: Mostrar un mensaje de aprobación o rechazo de préstamo");
                    Prestamo();
                    break;
                case 7:
                    Console.WriteLine("Seleccionaste: Calcular el área de una figura geométrica");
                    CalcularArea();
                    break;
                case 8:
                    Console.WriteLine("Seleccionaste: Convertir un número de letra a número");
                    LetraNumero();
                    break;
                case 9:
                    Console.WriteLine("Seleccionaste: Mostrar el día de la semana a partir de un número");
                    DiaSemana();
                    break;
                case 10:
                    Console.WriteLine("Seleccionaste: Calcular el importe a pagar por un servicio");
                    Servicio();
                    break;
                case 11:
                    Console.WriteLine("Seleccionaste: Mostrar un mensaje de bienvenida en diferentes idiomas");
                    Mensaje();
                    break;
                case 12:
                    Console.WriteLine("Seleccionaste: Evaluar la calificación de un examen");
                    Calificacion();
                    break;
                case 0:
                    Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                    break;
            }

            Console.WriteLine("\nPresiona Enter para continuar...");
            Console.ReadLine();
            Console.Clear();

        } while (opcion != 0);
    }
}
