using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class invetoryUi : MonoBehaviour
{
    TextMeshProUGUI carootText;
    TextMeshProUGUI hartText;
    // Start is called before the first frame update
    void Start()
    {
        carootText = GetComponent<TextMeshProUGUI>();
        hartText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCarrotText(PlayerInvetort playerInvetort)
    {
        carootText.text = playerInvetort.NamberOfCarrot.ToString();
    }
    public void UpdateHartText(PlayerInvetort playerInvetort)
    {
       
        hartText.text = playerInvetort.numberOfHarts.ToString();
    }
}
