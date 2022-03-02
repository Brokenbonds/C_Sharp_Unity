using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayAgain : MonoBehaviour
{
    public TextMeshProUGUI winner;
    public Button playAgain;
    public Button quit;
    public GameObject finishing;
    public Color imageColor;
    private GameObject spawnObj;
    private Spawner spawnScr;

    private Image image;
    private WinManager finishingScript;
    public void PlayingAgain()
    {
        print("you clicked Play Again");
        spawnObj = GameObject.Find("SpawnPoints");
        spawnScr = spawnObj.GetComponent<Spawner>();

        spawnScr.checkpoint = 0;

        finishingScript = finishing.GetComponent<WinManager>();

        finishingScript.HasWon = false;

        winner.gameObject.SetActive(false);
        playAgain.gameObject.SetActive(false);
        quit.gameObject.SetActive(false);

        image = GameObject.Find("FourbyFourIcon").GetComponent<UnityEngine.UI.Image>();
        image.color = imageColor;


    }
}
