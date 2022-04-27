using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{
    public int entero1;
    public int entero2;
    
    public void BtnPress()
    {
        if (entero2 >= entero1)
        {
            Debug.Log("Error");
        }
        else
        {
            while (entero2 < entero1)
            {
                Debug.Log(entero1);
                entero1--;
            }
        }       
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
