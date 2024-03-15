// Llamada provincial
class LlamadaProvincial : Llamada {
    private static readonly double[] PreciosPorFranja = {0.20, 0.25, 0.30};
    private int FranjaHoraria;

    // Constructor de Llamada Provincial
    public LlamadaProvincial(string numOrigen, string numDestino, double duracion, int franjaHoraria)
        : base(numOrigen, numDestino, duracion) {
        FranjaHoraria = franjaHoraria;
    }

    // Calcular el precio de la llamada provincial
    public override double CalcularPrecio() {
        return Duracion * PreciosPorFranja[FranjaHoraria - 1];
    }

    // Sobreescribir método ToString para incluir detalles de la llamada provincial

    // Franja Horaria Rangos
    // Mañana - 6:00-11:59
    // Tarde - 12:00-6:59
    // Noche - 7:00-5:59

    private string ObtenerDescripcionFranjaHoraria(int franjaHoraria)
    {
        if (franjaHoraria >= 6 && franjaHoraria < 12)
        {
            return "Mañana";
        }
        else if (franjaHoraria >= 12 && franjaHoraria < 18)
        {
            return "Tarde";
        }
        else
        {
            return "Noche";
        }
    }

    public override string ToString()
    {
        string franjaHorariaDescripcion = ObtenerDescripcionFranjaHoraria(FranjaHoraria);
        return $"Llamada Provincial - {base.ToString()}, Franja Horaria: {franjaHorariaDescripcion}";
    }
}