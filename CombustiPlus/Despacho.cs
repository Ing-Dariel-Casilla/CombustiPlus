using System.Globalization;

namespace CombustiPlus;

/// <summary>
/// Representa un despacho de combustible ya registrado.
/// </summary>
public class Despacho
{
    private static readonly CultureInfo Cultura = CultureInfo.InvariantCulture;

    public int Numero { get; set; }
    public string Placa { get; set; } = string.Empty;
    public string Combustible { get; set; } = string.Empty;
    public decimal Galones { get; set; }
    public string Pago { get; set; } = string.Empty;
    public decimal Total { get; set; }

    /// <summary>
    /// Una línea por despacho, como en la Figura 1:
    /// #01 A123456  Regular   10.0 gal  Efectivo  RD$  2,720.00
    /// </summary>
    public override string ToString()
    {
        return $"#{Numero:00} {Placa}  {Combustible,-8} {Galones.ToString("0.0", Cultura),5} gal  " +
               $"{Pago,-8}  RD$ {Total.ToString("N2", Cultura),9}";
    }
}
