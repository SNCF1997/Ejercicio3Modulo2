using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Text;

namespace EjercicioClase3Modulo2EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Pasos previos
            //Ejecutar el script de base de datos en Management Studio para crear la base de datos y la tabla con datos
            //Instalar Microsoft.EntityFrameworkCore y Microsoft.EntityFrameworkCore.SqlServer
            //Crear las entidades necesarias
            //Crear el dbcontext
            //Configurar aqui el connection string e instanciar el contexto de la base de datos.

            #region Configuracion inicial
            var opcion = new DbContextOptionsBuilder<BDContext>();
            opcion.UseSqlServer("Data Source=CDA-AR-0987\\SQL2022POO;Initial Catalog=SimpleIMDB;User ID=sa;Password=SNcf.1208;Encrypt=False");
            var context = new BDContext(opcion.Options);
            var resultado = context.Actor.ToList();
            #endregion
            #endregion

            #region ejercicio 1
            //Obtener un listado de todos los actores y actrices de la tabla actor
            var ListadoTodosAct = context.Actor.Where(Actor => Actor.IdActor > 0).ToList();
            #endregion

            #region ejercicio 2
            //Obtener listado de todas las actrices de la tabla actor
            var ListadoActrices = context.Actor.Where(Actor => Actor.GeneroActor == 'F').ToList();
            #endregion

            #region ejercicio 3
            //Obtener un listado de todos los actores y actrices mayores de 50 años de la tabla actor
            var ListadoActExp = context.Actor.Where(Actor => Actor.EdadActor >= 50).ToList();
            #endregion

            #region ejercicio 4
            //Obtener la edad de la actriz "Julia Roberts"
            var JuliaRoberts = context.Actor.Where(Actor => Actor.NombreActor == "Julia" && Actor.ApellidoActor == "Roberts").Select(Actor => Actor.EdadActor).ToList();
            #endregion

            #region ejercicio 5
            //Insertar un nuevo actor en la tabla actor con los siguientes datos:
            //nombre: Ricardo
            //apellido: Darin
            //edad: 67 años
            //nombre_artistico: Ricardo Darin
            //nacionalidad: argentino
            //género: Masculino.
            Actor NuevoActor = new Actor() { NombreActor = "Ricardo", ApellidoActor = "Darin", EdadActor = 67, NomArtActor = "Ricardo Darín", NacionalidadActor = "Argentino", GeneroActor = 'M' };
            context.Actor.Add(NuevoActor);
            context.SaveChanges();
            #endregion

            #region ejercicio 6
            //obtener la cantidad de actores y actrices que no son de Estados Unidos.
            var CantidadNoYankees = context.Actor.Where(Actor => Actor.NacionalidadActor != "USA").Count();
            #endregion

            #region ejercicio 7
            //obtener los nombres y apellidos de todos los actores maculinos.
            var ActoresNombres = context.Actor.Where(Masculino => Masculino.GeneroActor == 'M').Select(Masculino => new { Masculino.NombreActor, Masculino.ApellidoActor }).ToList();

            #endregion
        }
    }
}