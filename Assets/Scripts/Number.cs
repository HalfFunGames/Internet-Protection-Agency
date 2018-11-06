using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour {

    public int number;
    public GameObject temp;

    public void SetVariable()
    {
        temp.GetComponent< Current_Selected >().currentCountry = number;
    }

}
