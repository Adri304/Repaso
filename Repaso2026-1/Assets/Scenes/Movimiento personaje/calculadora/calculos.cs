using System;

public class CalculadoraLogica
{
    public float Sumar(float a, float b)
    {
        return a + b;
    }

    public float Restar(float a, float b)
    {
        return a - b;
    }

    public float Multiplicar(float a, float b)
    {
        return a * b;
    }

    public float Dividir(float a, float b)
    {
        if (b == 0)
            throw new DivideByZeroException("No se puede dividir entre cero");

        return a / b;
    }
}
