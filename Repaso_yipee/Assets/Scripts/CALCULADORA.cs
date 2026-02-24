using JetBrains.Annotations;
using TMPro;
using UnityEditor;
using UnityEngine;

public class CALCULADORA : MonoBehaviour
{
    public enum Operador
    {
        suma,
        resta,
        multiplicacion,
        divicion

    }


    [SerializeField] private TMP_InputField _inputA;
    [SerializeField] private TMP_InputField _inputB;
    [SerializeField] private TMP_Text _resultado;


    [SerializeField]
    Operador _operador;

    public void AsignarOP(Operador operador)
    {


        _operador = operador;

    }


    public void Suma() => _operador = Operador.suma;

    public void Resta() => _operador = Operador.resta;

    public void Multiplicar() => _operador = Operador.multiplicacion;

    public void Divicion() => _operador = Operador.divicion;




    public void Calcular()
    {
        if(!float.TryParse(_inputA.text, out float a) || !float.TryParse(_inputB.text, out float b))
        {
             _resultado.text = "Escribe un numero papu";
            return;
        }


        switch (_operador) 
        {

            case Operador.suma:
                _resultado.text = (a + b).ToString();

                break;

            case Operador.resta:
                _resultado.text = (a - b).ToString();

                break;

            case Operador.multiplicacion:
                _resultado.text = (a * b).ToString();
                break; 

            case Operador.divicion:
                if(b == 0)
                {
                    _resultado.text = "No es posible";

                }

                else
                {
                    _resultado.text = (a / b).ToString();
                }
          

                break;

            default:

                _resultado.text = "oprime un operador valido";

                break;
        }


    }
    

}
