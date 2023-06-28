using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porridge : MonoBehaviour
{
    [SerializeField] private float temperature; 
    // Start is called before the first frame update
    
    private void Start()
    {
        temperature = 100;
    }

    // Update is called once per frame
    void Update()
    {
        temperature = temperature - Time.deltaTime;
        
        if (temperature > 70)
        {
            Debug.Log("temperature is too hot!" + (int)temperature);
        }
        else if (temperature < 40)
        {
            Debug.Log("temperature is too cold!" + (int)temperature);
        }
        else 
        {
            Debug.Log("temperature is fit for Goldilocks" + (int)temperature);
        }
        Debug.Log("The temperature as an interger is " + (string)(int)temperature + "")
    }
}
