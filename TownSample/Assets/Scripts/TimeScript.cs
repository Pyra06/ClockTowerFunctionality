using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    public GameObject secondHand;
    public GameObject minHand;
    public GameObject hourHand;
    string previousSeconds;

    void Update()
    {
        UpdateClock();
    }

    private void UpdateClock()
    {
        int secInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("ss"));
        int minInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("mm"));
        int hrInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));

        secondHand.transform.eulerAngles = new Vector3(secInt * 6f, 0, 0);
        minHand.transform.eulerAngles = new Vector3(minInt * 6f, 0, 0);
        hourHand.transform.eulerAngles = new Vector3(hrInt * 30f, 0, 0);
    }
}
