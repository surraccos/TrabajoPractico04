using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
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

        internal bool Eliminar(string pCodigo)
        {
            try
            {
                RepoUsuarios.Remove(pCodigo);
                return true;
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("La clave = \"pCodigo\" no existe)");
                return false;
            }

        }

        internal List<Usuario> ObtenerTodos() 
        {
            return RepoUsuarios.Values.ToList();
        }
        
        internal Usuario ObtenerPorCodigo(string pCodigo)
        {
            Usuario user = new();
            try
            {
                user = RepoUsuarios[pCodigo];
            }
            catch(KeyNotFoundException)
            {
                Console.WriteLine("No se encontró la clave especificada");
                
            }
            return user;
        }


        //Implementar 3 de estos
        internal IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            IList<Usuario> lista = RepoUsuarios.Values.ToList();
            return lista.ToImmutableSortedSet<Usuario>(pComparador);
        }

    }
}
