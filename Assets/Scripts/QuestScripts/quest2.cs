using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quest2 : MonoBehaviour
{
    public GameManager gm;
    public Text texto;
    public GameObject button;

    public void Update()
    {
        if (gm.dinheiro >= 1)
        {
            Destroy(this.gameObject);
            texto.color = Color.green;
            button.SetActive(true);
        }
    }
}
