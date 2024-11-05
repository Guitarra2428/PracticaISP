using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaISP
{
    public interface IAve: IVolar, ICantar, IPonerHuevos
    {
       
    }  
    public interface IVolar
    {
        void Volar();
       

    }  
    public interface ICantar
    {       
        void Cantar();
       

    }  
    
    public interface IPonerHuevos
    {       
        void PonerHuevos();      

    } 
    public interface INadar
    {
        void Nadar();
     
    }   
    public interface ICazar
    {
        void Cazar();

    }
    ///Ejemplo de una gallina
    ///
    public class Gallina : IAve
    {
        public void Cantar()
        {
            throw new NotImplementedException();
        }

        public void PonerHuevos()
        {
            throw new NotImplementedException();
        }

        public void Volar()
        {
            throw new NotImplementedException();
        }
    }
}
