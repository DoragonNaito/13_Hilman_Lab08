using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear : MonoBehaviour
{
    public InputField Amount;
    public InputField Value;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Cleared()
    {
        Value.text = "";
        Amount.text = "";
    }
}
