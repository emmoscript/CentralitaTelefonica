using System;

// Llamada genérica
abstract class Llamada {
    public string NumOrigen { get; set; }
    public string NumDestino { get; set; }
    public double Duracion { get; set; }

    // Constructor de Llamada
    public Llamada(string numOrigen, string numDestino, double duracion) {
        NumOrigen = numOrigen;
        NumDestino = numDestino;
        Duracion = duracion;
    }

    // Calcular el precio de la llamada
    public abstract double CalcularPrecio();

    // Sobreescribir e Imprimir los detalles de la llamada
    public override string ToString() {
        return $"Origen: {NumOrigen}, Destino: {NumDestino}, Duración: {Duracion} segundos";
    }
}