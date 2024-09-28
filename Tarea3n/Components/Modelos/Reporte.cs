using System.ComponentModel.DataAnnotations;

public class Reporte
{
    public string Id= Guid.NewGuid().ToString();

    public Reporte()
    {
    }

    public DateTime Fecha {get; set;} = DateTime.Now;

    [Required (ErrorMessage = "El campo Descripcion es requerido")]
    [MinLength (10, ErrorMessage = "El campo Descripcion debe tener minimo 10 caracteres")]
    public required string Descripcion {get; set;}

    public string CostoEstimado {get; set;}

    public int Muertos {get; set;} = 0;

    public int Heridos {get; set;} = 0;

    public int VehiculosInvolucrados {get; set;}
}