// Centralita telefónica
class Centralita {
    private int TotalLlamadas;
    private double TotalFacturado;

    // Registrar llamada en la centralita
    public void RegistrarLlamada(Llamada llamada) {
        TotalLlamadas++;
        TotalFacturado += llamada.CalcularPrecio();
        Console.WriteLine(llamada.ToString());
    }

    // Obtener número total de llamadas registradas
    public int GetTotalLlamadas() {
        return TotalLlamadas;
    }

    // Obtener total facturado por todas las llamadas
    public double GetTotalFacturado() {
        return TotalFacturado;
    }
}

class Practica2 {
    static void Main(string[] args) {
        // Instancia de la centralita
        Centralita centralita = new Centralita();

        // Llamadas de dos tipos
        LlamadaLocal llamadaLocal = new LlamadaLocal("8095678475", "4498574567", 120);
        LlamadaProvincial llamadaProvincial = new LlamadaProvincial("8096784563", "8098451754", 180, 2);

        // Registro de las llamadas
        centralita.RegistrarLlamada(llamadaLocal);
        centralita.RegistrarLlamada(llamadaProvincial);

        // Informe en consola
        Console.WriteLine($"Número total de llamadas registradas: {centralita.GetTotalLlamadas()}");
        Console.WriteLine($"Facturación total realizada: {centralita.GetTotalFacturado()} euros");
    }
}