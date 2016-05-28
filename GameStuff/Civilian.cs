using UnityEngine;
using System.Collections;

public class Civilian : MonoBehaviour
{//uploads image of a civilian on start-up.  Removes it when the timer goes to 0

    private float screenTimer;
    private bool isCivilian;

    // Use this for initialization
    void Start()
    {
        screenTimer = 60;
        isCivilian = true;
        Debug.Log("Character is civilian.  Wait for him to leave!");
    }

    void OnGUI()
    {
        //upload image of a civilian.  Use spawn animation
    }

    // Update is called once per frame
    void Update()
    {

        EndTimer();

        if (isCivilian)
        {
            screenTimer -= 1;
        }
    }

    void EndTimer()
    {
        if (screenTimer <= 0)
            isCivilian = false;
        Debug.Log("Civilian is gone.");
        //remove image of civilian
    }
}
