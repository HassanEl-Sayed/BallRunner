using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoins : MonoBehaviour
{
    void Update()
    {
        Vector3 turncoins = new Vector3(45, 0, 0);  //3:coin
        transform.Rotate(turncoins * Time.deltaTime);
    }
}
