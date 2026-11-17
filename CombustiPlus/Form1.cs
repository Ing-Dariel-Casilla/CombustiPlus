using System.Globalization;

namespace CombustiPlus;

public partial class Form1 : Form
{
    // Reglas del negocio (sección "El caso")
    private const decimal GalonesParaDescuento = 20m;   // regla 3
    private const decimal PorcentajeDescuento = 0.02m;  // regla 3: 2 %
    private const decimal PorcentajeRecargoTarjeta = 0.03m; // regla 4: 3 %

    // Formato con punto decimal y coma de miles: 6,439.97
    private static readonly CultureInfo Cultura = CultureInfo.InvariantCulture;

    private readonly List<Despacho> despachos = new();

    public Form1()
    {
        InitializeComponent();

        cmbCombustible.Items.AddRange(new object[] { "Premium", "Regular", "Gasoil" });
        cmbPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
        cmbCombustible.SelectedIndex = 0;
        cmbPago.SelectedIndex = 0;

        ActualizarResumen();
    }

    // ---------------------------------------------------------------
    // Precio por galón: expresión switch (R4)
    // ---------------------------------------------------------------
    private static decimal ObtenerPrecio(string combustible) => combustible switch
    {
        "Premium" => 290m,
        "Regular" => 272m,
        "Gasoil" => 225m,
        _ => throw new ArgumentException($"Combustible desconocido: {combustible}")
    };

    private static string Dinero(decimal valor) => "RD$ " + valor.ToString("N2", Cultura);

    // ---------------------------------------------------------------
    // R3: validación con if. Devuelve false si hay algún error.
    // ---------------------------------------------------------------
    private bool ValidarDatos()
    {
        string placa = txtPlaca.Text.Trim();

        if (placa.Length != 7)
        {
            MessageBox.Show("La placa debe tener 7 caracteres.\nEjemplo: A123456",
                "Placa inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPlaca.Focus();
            return false;
        }

        if (nudGalones.Value <= 0)
        {
            MessageBox.Show("Los galones deben ser más de 0.",
                "Galones inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            nudGalones.Focus();
            return false;
        }

        if (cmbCombustible.SelectedItem is null || cmbPago.SelectedItem is null)
        {
            MessageBox.Show("Selecciona el combustible y la forma de pago.",
                "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    // ---------------------------------------------------------------
    // R4: calcula el total y devuelve también los pasos del detalle.
    // Orden: precio base -> descuento (20+ gal) -> recargo de tarjeta.
    // ---------------------------------------------------------------
    private (decimal Total, List<string> Pasos) Calcular(string combustible, decimal galones, string pago)
    {
        var pasos = new List<string>();

        decimal precio = ObtenerPrecio(combustible);
        decimal importe = Math.Round(galones * precio, 2, MidpointRounding.AwayFromZero);
        pasos.Add($"{galones.ToString("0.0", Cultura)} gal × {Dinero(precio)} = {Dinero(importe)}");

        if (galones >= GalonesParaDescuento)
        {
            importe = Math.Round(importe * (1 - PorcentajeDescuento), 2, MidpointRounding.AwayFromZero);
            pasos.Add($"Descuento 20+ galones -2 %: {Dinero(importe)}");
        }

        if (pago == "Tarjeta")
        {
            importe = Math.Round(importe * (1 + PorcentajeRecargoTarjeta), 2, MidpointRounding.AwayFromZero);
            pasos.Add($"Tarjeta +3 %: {Dinero(importe)}");
        }

        pasos.Add($"TOTAL: {Dinero(importe)}");
        return (importe, pasos);
    }

    private void MostrarDetalle(List<string> pasos)
    {
        lstDetalle.Items.Clear();
        foreach (string paso in pasos)
        {
            lstDetalle.Items.Add(paso);
        }
    }

    // ---------------------------------------------------------------
    // Botón Cotizar
    // ---------------------------------------------------------------
    private void btnCotizar_Click(object sender, EventArgs e)
    {
        if (!ValidarDatos())
        {
            return;
        }

        var (_, pasos) = Calcular(
            cmbCombustible.SelectedItem!.ToString()!,
            nudGalones.Value,
            cmbPago.SelectedItem!.ToString()!);

        MostrarDetalle(pasos);
    }

    // ---------------------------------------------------------------
    // R5: Botón Despachar -> guarda en la List<Despacho>
    // ---------------------------------------------------------------
    private void btnDespachar_Click(object sender, EventArgs e)
    {
        if (!ValidarDatos())
        {
            return;
        }

        string combustible = cmbCombustible.SelectedItem!.ToString()!;
        string pago = cmbPago.SelectedItem!.ToString()!;
        decimal galones = nudGalones.Value;

        var (total, pasos) = Calcular(combustible, galones, pago);

        var despacho = new Despacho
        {
            Numero = despachos.Count + 1,
            Placa = txtPlaca.Text.Trim().ToUpperInvariant(),
            Combustible = combustible,
            Galones = galones,
            Pago = pago,
            Total = total
        };

        despachos.Add(despacho);

        lstDespachos.Items.Add(despacho.ToString());
        MostrarDetalle(pasos);
        ActualizarResumen();
    }

    // ---------------------------------------------------------------
    // R5: resumen con foreach
    // ---------------------------------------------------------------
    private void ActualizarResumen()
    {
        if (despachos.Count == 0)
        {
            lblResumen.Text = "0 despachos";
            return;
        }

        decimal totalVendido = 0m;
        decimal totalGalones = 0m;
        Despacho mayor = despachos[0];

        foreach (Despacho d in despachos)
        {
            totalVendido += d.Total;
            totalGalones += d.Galones;
            if (d.Total > mayor.Total)
            {
                mayor = d;
            }
        }

        lblResumen.Text =
            $"{despachos.Count} despachos · Vendido {Dinero(totalVendido)} · " +
            $"Galones {totalGalones.ToString("0.0", Cultura)} · " +
            $"Mayor: #{mayor.Numero:00} {mayor.Placa} ({Dinero(mayor.Total)})";
    }

    // ---------------------------------------------------------------
    // R6: Dictionary<string, decimal> con los galones por combustible
    // ---------------------------------------------------------------
    private void btnPorCombustible_Click(object sender, EventArgs e)
    {
        lstDetalle.Items.Clear();

        if (despachos.Count == 0)
        {
            lstDetalle.Items.Add("Todavía no hay despachos.");
            return;
        }

        var galonesPorCombustible = new Dictionary<string, decimal>();

        foreach (Despacho d in despachos)
        {
            if (galonesPorCombustible.ContainsKey(d.Combustible))
            {
                galonesPorCombustible[d.Combustible] += d.Galones;
            }
            else
            {
                galonesPorCombustible[d.Combustible] = d.Galones;
            }
        }

        lstDetalle.Items.Add("Galones por combustible:");
        foreach (KeyValuePair<string, decimal> par in galonesPorCombustible)
        {
            lstDetalle.Items.Add($"{par.Key,-8} {par.Value.ToString("0.0", Cultura)} gal");
        }
    }
}
