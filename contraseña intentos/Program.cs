// See https://aka.ms/new-console-template for more information
Console.WriteLine("3 intentos");
Console.WriteLine();

        string contraseña = "YILEINI123"; 
        int intentosMaximos = 3; 
        int intentos = 0; 

        while (intentos < intentosMaximos)
        {
            Console.WriteLine("Ingrese la contraseña:");
            string contraseñaIngresada = Console.ReadLine();

            if (contraseñaIngresada == contraseña)
            {
                Console.WriteLine("¡Contraseña correcta!");
                return; 
            }
            else
            {
                intentos++;
                Console.WriteLine("Contraseña incorrecta. Intentos restantes: " + (intentosMaximos - intentos));
            }
        }

        // Si se llega a este punto, significa que se agotaron los intentos
        Console.WriteLine("Se ha agotado el número de intentos. El programa terminará.");
    


