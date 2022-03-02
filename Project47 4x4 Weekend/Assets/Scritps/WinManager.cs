using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class WinManager : MonoBehaviour
{
    private bool _hasWon = false;
    private GameObject jeep;
    private CarController jeepScript;
    private GameObject canvas;
    private Timer timer;

   
    public TextMeshProUGUI  Winner;
    public Button playAgain;
    public Button quit;

   

    public bool HasWon { get => _hasWon; set { _hasWon = value; print("is" + value); } }




    private void Update()
    {
        if (_hasWon)
        {
            if (jeepScript.enabled)
            {
                jeepScript.enabled = !jeepScript.enabled;
            }
            
            jeepScript.Breaking();

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            jeep = GameObject.Find("Jeep(Clone)");
            jeepScript = jeep.GetComponent<CarController>();
            canvas = GameObject.Find("Canvas");
            timer = canvas.GetComponent<Timer>();
            _hasWon = true;
            timer.timerActive = false;
            Winner.gameObject.SetActive(true);
            playAgain.gameObject.SetActive(true);
            quit.gameObject.SetActive(true);
            

            
        }
    }

}
