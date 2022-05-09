using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_API_DocumentReader.Domain.Models;


public class MenuItem
{
    public int RotinaId { get; set; }
    public int MenuId { get; set; }
    public string? DescMenu { get; set; }
    public string? Titulo { get; set; }
    public int? OrdemMenu { get; set; }
    public string? Rotina { get; set; }
    public int? OrdemRotina { get; set; }
    public bool Acess { get; set; }
    public string? Icone { get; set; }
    public string? IconeMenu { get; set; }
    public string? Janela { get; set; }
    public string? Descricao { get; set; }
    public string? Rota { get; set; }
    public string? Auxiliar { get; set; }
    public string? Action { get; set; }

}
