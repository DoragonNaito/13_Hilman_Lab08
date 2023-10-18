using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    private float SGD = 1f;
    private float SGDUSD = 0.74f;
    private float SGDJPY = 82.78f;
    private float SGDRM = 3.08f;
    private float SGEuro = 0.63f;
    private float SGWon = 881.54f;
    private float SGTWD = 20.73f;

    public Toggle USDollar;
    public Toggle JapanseseYen;
    public Toggle MalaysianRinggit;
    public Toggle Euro;
    public Toggle KoreanWon;
    public Toggle TaiwanDollar;
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
                
                Total = amount * SGDUSD;
                Value.text = "$" + (Total);
            }
            
            else if (JapanseseYen.isOn == true)

            {
                Total = amount * SGDJPY;
                Value.text = "$" + (Total);
                USDollar.isOn = false;
            }

            else if (MalaysianRinggit == true)
            {
                Total = amount * SGDRM;
                Value.text = "$" + (Total);
            }

            else if (Euro == true)
            {
                Total = amount * SGEuro;
                Value.text = "$" + (Total);
            }

            else if (KoreanWon == true)
            {
                Total = amount * SGWon;
                Value.text = "$" + (Total);
            }

            else if (TaiwanDollar == true)
            {
                Total = amount * SGTWD;
                Value.text = "$" + (Total);
            }

            Error.text = "Debugging Text";
        }
        catch
        {
            Error.text = "Error Please Enter a value";
            Debug.Log("Something went wrong when the fire nation attack");
      

        }
        }
         public void Cleared()
    {
        Value.text = "";
        Amount.text = "";
        USDollar.isOn = false;
        JapanseseYen.isOn = false;
        
    }
        

     
}






