﻿internal class Porcentagem
{
    public double valorA { get; private set; }
    public double valorB { get; private set; }

    public Porcentagem(double a, double b)
    {
        valorA = a;
        valorB = b;
    }

    public double TotalPor()
    {
        double total = (valorA * valorB) / 100;
        return total;
    }
}