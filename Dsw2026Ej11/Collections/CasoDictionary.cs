namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int , string> alumnos = new Dictionary<int, string>();

    public void AgregarAlumno(int legajo, string nombre)
    {

        alumnos.Add(legajo, nombre);
    }

    public string BuscarAlumno(int legajo)
    {
        if (alumnos.ContainsKey(legajo))
        {
            return alumnos[legajo];
            
        }
        return null;

    }

    public Dictionary<int, string> ObtenerDiccionario()
    {
        return alumnos;
    }

    public void EliminarAlumno(int legajo)
    {

        alumnos.Remove(legajo);
    }




}

