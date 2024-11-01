﻿class Rectangulo : Figura
{
    private double baseRectangulo;
    private double altura;

    public Rectangulo(double baseRectangulo, double altura)
    {
        this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }

    public override double CalcularArea()
    {
        return baseRectangulo * altura;

    }
}