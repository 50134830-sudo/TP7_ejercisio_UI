using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Script : MonoBehaviour
{
    public TMP_InputField NumeroIngrezado;
    public TextMeshProUGUI RespuestaTXT;
    public int Respuesta = -2;
    // Start is called before the first frame update
    void Start()
    {
        RespuestaTXT.gameObject.SetActive(false);
    }

    public void Restar1()
    {
        int numero = int.Parse(NumeroIngrezado.text);

        if (Respuesta == -2){
            Respuesta = numero - 1;
        }
        else {
            Respuesta = Respuesta - 1;
        }

        if (Respuesta > 0){
            RespuestaTXT.text = Respuesta.ToString();
        }
        
        else {
            RespuestaTXT.text = "No se aceptan numeros menores a 1";
        }
        
        RespuestaTXT.gameObject.SetActive(true);

    }
}
