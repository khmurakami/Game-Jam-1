using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

    private float timer;
    private bool isTiming;

	// Use this for initialization
	void Start () {
        timer = 60;
        isTiming = true;
	}
	
	// Update is called once per frame
	void Update () {

        EndTimer();

        if (isTiming)
        {
            timer -= Time.deltaTime;
        }

        
	}

   void OnGUI()
    {
        GUI.skin.label.fontSize = 30;
        GUI.Box(new Rect(Screen.width - 80, 10, 50, 50), "");
        GUI.Label(new Rect(Screen.width - 67, 12, 50, 50), timer.ToString("0"));
    }

    void EndTimer()
    {
        if (timer <= 0)
        {
            isTiming = false;
            Debug.Log("Game over.  You ran out of time.");
        }
    }

}
