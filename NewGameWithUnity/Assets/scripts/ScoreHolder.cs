using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHolder : MonoBehaviour
{
    public GameObject gb;
    public Renderer sre;
    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        sre = GetComponent<Renderer>();
        astro_hareket.coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + astro_hareket.coins;
        if(astro_hareket.coins == 50)
        {

            Box.sr.material.color = Color.black;
            Spawner.sr2.material.color = Color.green;

        }
    }
}
