using System.Collections;
using System.Collections.Generic;
using MidiJack;
using Reaktion;
using UnityEngine;

public class MidiLightController : MonoBehaviour
{
    private Light _lighting;
    

    // Start is called before the first frame update
    void Start()
    {
        _lighting = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        float r = MidiMaster.GetKnob(MidiChannel.All, 23, 0f);
        float g = MidiMaster.GetKnob(MidiChannel.All, 24, 0f);
        float b = MidiMaster.GetKnob(MidiChannel.All, 25, 0f);

        _lighting.color = new Color(r, g, b);
    }
}
