using TMPro;
using UnityEngine;

public class multiplicar : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputfile_1;
    [SerializeField] private TMP_InputField inputfile_2;
    [SerializeField] private TMP_Text _textresultado;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MultiplicarNum(float.Parse(inputfile_1.text), float.Parse (inputfile_2.text));
    }
    public float MultiplicarNum(float a, float b)
    {
        return a * b;
    }
}
