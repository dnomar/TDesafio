using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Desafio entre 2 jugadores de squash en un lugar y hora determinadas
/// </summary>
public class Desafio
{
    private int id_desafio;
    private ICompetidor contendiente1;
    private ICompetidor contendiente2;
    private String lugar;
    private DateTime horario;
    private String apuesta;
    private String ganador;
    private String perdedor;
    private String macador;
    private String status_desafio;

	public Desafio()
	{
		
	}
}