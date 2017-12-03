using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Interfaz comepetidor que permite desafiar a otros
/// </summary>
public interface ICompetidor
{
    void desafiar_a(ICompetidor comp, Desafio def);
}