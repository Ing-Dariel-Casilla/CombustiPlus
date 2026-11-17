# CombustiPlus — Estación Bávaro

Tarea ISW-123 (Unidad 2). Aplicación de Windows Forms en C# (.NET 8) para registrar despachos de combustible.

## Estructura
```
CombustiPlus/
├── CombustiPlus.sln
├── README.md
├── .gitignore
└── CombustiPlus/
    ├── CombustiPlus.csproj
    ├── Program.cs
    ├── Despacho.cs
    ├── Form1.cs
    └── Form1.Designer.cs
```

## Abrir y ejecutar
1. Abre `CombustiPlus.sln` en Visual Studio 2022 o superior (carga de trabajo "Desarrollo de escritorio con .NET").
2. Pulsa **F5** (o el botón verde ▶).
3. Por línea de comandos: `dotnet run --project CombustiPlus/CombustiPlus.csproj`

## Reglas
- Premium RD$ 290.00 · Regular RD$ 272.00 · Gasoil RD$ 225.00 por galón.
- Placa de exactamente 7 caracteres; galones mayores que 0.
- 20 galones o más: 2 % de descuento. Tarjeta: 3 % de recargo, aplicado después del descuento.
