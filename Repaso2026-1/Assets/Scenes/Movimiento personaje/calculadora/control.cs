using UnityEngine;
using TMPro;

public class OperacionUI : MonoBehaviour
{
    [Header("Referencias UI")]
    public TMP_InputField inputA;
    public TMP_InputField inputB;
    public TMP_Text resultadoTexto;

    [Header("Tipo de operación")]
    public TipoOperacion tipoOperacion;

    private CalculadoraLogica calculadora;

    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division
    }

    // UNITY instancia este MonoBehaviour automáticamente
    private void Awake()
    {
        // Nosotros instanciamos manualmente la lógica
        calculadora = new CalculadoraLogica();

        // Registramos evento cuando el usuario presiona Enter
        inputA.onSubmit.AddListener(EjecutarOperacion);
        inputB.onSubmit.AddListener(EjecutarOperacion);
    }

    public void EjecutarOperacion(string _)
    {
        if (!float.TryParse(inputA.text, out float a) ||
            !float.TryParse(inputB.text, out float b))
        {
            resultadoTexto.text = "Entrada inválida";
            return;
        }

        try
        {
            float resultado = 0f;

            switch (tipoOperacion)
            {
                case TipoOperacion.Suma:
                    resultado = calculadora.Sumar(a, b);
                    break;

                case TipoOperacion.Resta:
                    resultado = calculadora.Restar(a, b);
                    break;

                case TipoOperacion.Multiplicacion:
                    resultado = calculadora.Multiplicar(a, b);
                    break;

                case TipoOperacion.Division:
                    resultado = calculadora.Dividir(a, b);
                    break;
            }

            resultadoTexto.text = resultado.ToString();
        }
        catch (System.DivideByZeroException e)
        {
            resultadoTexto.text = e.Message;
        }
    }
}
