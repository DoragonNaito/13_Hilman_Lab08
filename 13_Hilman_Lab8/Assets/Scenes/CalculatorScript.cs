using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    private float SGD = 1f;
    private float SGDUSD = 0.74f;
    private float SGDJPY = 82.78f;
    public Toggle USDollar;
    public Toggle JapanseseYen;
    public InputField Amount;
    public InputField Value;
    public Text Error;
    private float Total;

   


    // Start is called before the first frame update
    void Start()
    {
        USDollar.isOn = false;
        JapanseseYen.isOn = false;


    }

    // Update is called once per frame
    public void Convert()
    {

        try
        {
            float amount = float.Parse(Amount.text);
            if (USDollar.isOn == true)
            {
                JapanseseYen.isOn = false;
                Total = amount * SGDUSD;
                Value.text = "$" + (Total);
            }
            else if (USDollar.isOn == false || (JapanseseYen.isOn == false))
            {

                {
                    Value.text = "$";
                }
            }
            else if (JapanseseYen.isOn == true)

            {
                Total = amount * SGDJPY;
                Value.text = "$" + (Total);
                USDollar.isOn = false;
            }
         
                Error.text = "Debugging Text";
        }
        catch
        {
            Error.text = "Error Please Enter a value";
            Debug.Log("Something went wrong when the fire nation attack");
      

        }
        }

     
}






