using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WallScore : MonoBehaviour
{
    public TMP_Text numberDisplay;
    public int FinalNumber;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Randomizer();
    }

    // Update is called once per frame
    void Update()
    {     
        numberDisplay.SetText("+" + FinalNumber);
    }

    public void Randomizer()
    {
        int numberRandom;

        numberRandom = Random.Range(0, 21);
        FinalNumber = numberRandom;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Get triggered");
        player.GetComponent<PlayerControl>().score += FinalNumber;
    }
}
