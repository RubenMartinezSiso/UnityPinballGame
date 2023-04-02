using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class points : MonoBehaviour
{
    private float pointNumber;
    private TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        text.text = pointNumber.ToString("0");
    }

    public void AddPoints(float entryPoints)
    {
        pointNumber += entryPoints;
    }
}
