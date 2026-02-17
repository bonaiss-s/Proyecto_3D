using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class CALCULADORA : MonoBehaviour
{


    [SerializeField] private TMP_InputField _inputA;
    [SerializeField] private TMP_InputField _inputB;
    [SerializeField] private TMP_InputField _resultado;

 


    public string Calcular(string Operador, float _inputA, float _inputB)
    {
        switch (Operador) 
        {

            case "+":
                return _inputA + _inputB.ToString();

                break;

            case "-":
                return _inputA - _inputB.ToString(); 

                break;

            case "x":
                return _inputA * _inputB.ToString();

                break; 

            case "/":
                return _inputA / _inputB.ToString();

                break;  
        }


    }
    

}
