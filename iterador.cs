//---------------------iterador--------------------------------
using System;
using System.Collections.Generic;

public abstract class Iterador<TElemento>
  where TElemento : Elemento
{
    public string palabraClaveConsulta { protected get; set; }
    protected int indice;
    public IList<TElemento> contenido { protected get; set; }


    public void inicio()
    {
        indice = 0;
        int tamaño = contenido.Count;
        while ((indice < tamaño) &&
          (!contenido[indice].palabraClaveValida(palabraClaveConsulta)))
            indice++;
    }

    public void siguiente()
    {
        int tamaño = contenido.Count;
        indice++;
        while ((indice < tamaño) &&
          (!contenido[indice].palabraClaveValida(palabraClaveConsulta)))
            indice++;
    }

    public TElemento item()
    {
        if (indice < contenido.Count)
            return contenido[indice];
        else
            return null;
    }
}

//----------------------IteradorVehiculo.cs------------------------
public class IteradorVehiculo : Iterador<Vehiculo>
{
}
//-------------------------usuarios.cs--------------------------------------
using System;

public class Usuario
{
    static void Main(string[] args)
    {
        CatalogoVehiculo catalogo = new CatalogoVehiculo();
        IteradorVehiculo iterador = catalogo.busqueda(
          "económico");
        Vehiculo vehiculo;
        iterador.inicio();
        vehiculo = iterador.item();
        while (vehiculo != null)
        {
            vehiculo.visualiza();
            iterador.siguiente();
            vehiculo = iterador.item();
        }
    }
}
//----------------------------------------------




