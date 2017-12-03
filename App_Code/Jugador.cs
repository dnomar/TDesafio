using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Jugadores de los deportes ofrecidos
/// </summary>
public class Jugador : ICompetidor
{
    private int id;
    private String nombre;
    private String apellido;
    private String categoria;
    private String mail;
    private String telefono;

	public Jugador(int id,String nombre,String apellido,String categoria,String mail,String telefono)
	{
        this.id = id;
        this.nombre=nombre;
        this.apellido = apellido;
        this.categoria = categoria;
        this.mail = mail;
        this.telefono=telefono;

	}

    public void desafiar_a(ICompetidor jug, Desafio def) { 
        //...codigo para desafiar a otro weon
    }

}