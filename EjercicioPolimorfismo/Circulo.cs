class Circulo : Figura
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public override double CalcularArea()
    {
        return Math.PI
* Math.Pow(radio, 2);
    }
}