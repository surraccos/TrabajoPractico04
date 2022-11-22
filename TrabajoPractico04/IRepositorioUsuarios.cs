using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class IRepositorioUsuarios

    {
        Dictionary<string, Usuario> RepoUsuarios = new();  
        
        //Metodos
        internal void Agregar(Usuario pUsuario)
        {
            try
            {
                RepoUsuarios.Add(pUsuario.Codigo, pUsuario);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Ya existe un elemento con la clave = \"Codigo\".");
            }
        }

        internal void Actualizar(Usuario pUsuario)
        {
            try
            {
                RepoUsuarios[pUsuario.Codigo] = pUsuario;
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("La clave = \"Codigo\" no existe)");
            }
        }

        internal void Eliminar(string pCodigo)
        {
            try
            {
                RepoUsuarios.Remove(pCodigo);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("La clave = \"pCodigo\" no existe)");
            }

        }

        internal List<Usuario> ObtenerTodos() 
        {
            return RepoUsuarios.Values.ToList();
        }
        
        internal Usuario ObtenerPorCodigo(string pCodigo)
        {
            return RepoUsuarios[pCodigo];
        }

        //Implementar 3 de estos
        //internal IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        //{
        //    return;
        //}

    }
}
