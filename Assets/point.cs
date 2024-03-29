using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class point : MonoBehaviour
{
    public int Point;
    public int Carrot;
    public TMP_Text TMP_Textp;
    public TMP_Text TMP_Textc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TMP_Textc.text = ("caroot" +Carrot);
        TMP_Textp.text = ("point" + Point);
       
    }
}
