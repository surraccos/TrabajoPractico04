using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class IRepositorioUsuarios
    {
      
        //Metodos
        internal void Agregar(Usuario pUsuario)
        {

            array[count] = pBanca;
            count++;

        }

        internal void Actualizar(Usuario pUsuario)
        {

            array[count] = pBanca;
            count++;

        }

        internal void Eliminar(string pCodigo)
        {

            array[count] = pBanca;
            count++;

        }

        internal IList<Usuario> ObtenerTodos() 
        {
            return ;
        }
        
        internal Usuario ObtenerPorCodigo(string pCodigo)
        {
            return;
        }


        //Implementar 3 de estos
        internal IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            return;
        }

    }
}
