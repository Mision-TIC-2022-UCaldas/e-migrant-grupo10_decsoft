using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;
using System.Collections.Generic;

namespace Ganaderia.App.Consola
{
    class Program
    {
        private static IRepositorioMigrantes _repositorioMigrante = new RepositorioMigrantes(new Persistencia.AppContext()); 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddMigrante();
            //AddVeterinario();
            //AddEjemplares();
        }

        private static void AddMigrante()
        {
            var migrante = new Migrante
            {
                Nombre = "Sergio",
                Apellidos = "Moreno",
                Tipo_documento = "3148596562",
                Documento = "sergiomintic@mintic.edu.co",
                Pais_origen = "123456",
                Fecha_nacimiento = "50",
                Email = "la conquista",
                Telefono = "4554",
                Direccion_actual = "5454",
                Ciudad="Villavicencio",
                Situacion_laboral="Buscando empleo"
            };

            _repositorioMigrante.AddMigrantes(migrante);

        }
        private static void AddVeterinario()
        {
            

           // _repositorioVeterinario.AddVeterinario(veterinario);

            
        }

    }
}
