class LlamadaLocal : Llamada {
    private const double PrecioPorSegundo = 0.15;

    // Constructor de LlamadaLocal
    public LlamadaLocal(string numOrigen, string numDestino, double duracion)
        : base(numOrigen, numDestino, duracion) {
    }

    // Calcular el precio de la llamada local
    public override double CalcularPrecio() {
        return Duracion * PrecioPorSegundo;
    }

    // Sobrescritura del método ToString para incluir detalles de la llamada local
    public override string ToString() {
        return "Llamada Local: " + base.ToString();
    }
}