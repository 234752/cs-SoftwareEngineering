using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportMinigame
{
    private List<MeanOfTransport> meansOfTransport;

    public MeanOfTransport DisplayListOfAvailableTransport()
    {
        return meansOfTransport[0];
    }
}
