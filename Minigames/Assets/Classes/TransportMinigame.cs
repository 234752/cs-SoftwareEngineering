using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TransportMinigame : MonoBehaviour, IMinigame
{
    #region UI variables

    public GameObject transport1;
    public GameObject transport2;
    public GameObject transport3;
    public GameObject transport4;
    public GameObject result;

    public TextMeshProUGUI transport1Text;
    public TextMeshProUGUI transport2Text;
    public TextMeshProUGUI transport3Text;
    public TextMeshProUGUI transport4Text;
    public TextMeshProUGUI resultText;

    #endregion

    public bool IsCompleted { get; set; }
    public int EnvironmentPoints { get; set; }

    private List<MeanOfTransport> meansOfTransport = new List<MeanOfTransport>()
    {
        new MeanOfTransport("Bus", 1),
        new MeanOfTransport("Bicycle", 1),
        new MeanOfTransport("Car", 0),
        new MeanOfTransport("Motorbike", 0),
        new MeanOfTransport("Scooter", 0),
        new MeanOfTransport("Tram", 1),
        new MeanOfTransport("Train", 1),
    };
    private List<MeanOfTransport> displayedAvailableTransport;

    public void Start()
    {
        StartMinigame();
    }

    public void Update()
    {
        //Not necessary to update the text fields
    }

    public List<MeanOfTransport> DisplayListOfAvailableTransport()
    {
        List<MeanOfTransport> allMeansOfTransport = meansOfTransport;
        

        for (int i = 0; i < allMeansOfTransport.Count; i++)
        {
            MeanOfTransport temp = allMeansOfTransport[i];
            int rand = Random.Range(i, allMeansOfTransport.Count);
            meansOfTransport[i] = allMeansOfTransport[rand];
            meansOfTransport[rand] = temp;
        }

        return meansOfTransport.GetRange(0, 4);
    }

    public void StartMinigame()
    {
        resultText = result.GetComponent<TextMeshProUGUI>();
        transport1Text = transport1.GetComponent<TextMeshProUGUI>();
        transport2Text = transport2.GetComponent<TextMeshProUGUI>();
        transport3Text = transport3.GetComponent<TextMeshProUGUI>();
        transport4Text = transport4.GetComponent<TextMeshProUGUI>();

        displayedAvailableTransport = DisplayListOfAvailableTransport();

        resultText.text = "";
        transport1Text.text = displayedAvailableTransport[0].Name;
        transport2Text.text = displayedAvailableTransport[1].Name;
        transport3Text.text = displayedAvailableTransport[2].Name;
        transport4Text.text = displayedAvailableTransport[3].Name;

        //Choosing the mean of transport...

        //CalculateEnvironmentPoints(displayedAvailableTransport[0]);
    }

    public void CalculateEnvironmentPoints(MeanOfTransport chosenTransport)
    {
        EnvironmentPoints = chosenTransport.PointsValue;
        resultText.text = "Your score: " + EnvironmentPoints.ToString();
    }

    public void T1ButtonOnClick()
    {
        CalculateEnvironmentPoints(displayedAvailableTransport[0]);
        transport1Text.color = Color.blue;
    }

    public void T2ButtonOnClick()
    {
        CalculateEnvironmentPoints(displayedAvailableTransport[1]);
        transport2Text.color = Color.blue;
    }

    public void T3ButtonOnClick()
    {
        CalculateEnvironmentPoints(displayedAvailableTransport[2]);
        transport3Text.color = Color.blue;
    }

    public void T4ButtonOnClick()
    {
        CalculateEnvironmentPoints(displayedAvailableTransport[3]);
        transport4Text.color = Color.blue;
    }
}
