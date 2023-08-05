using System.Collections;
using UnityEngine;

// A class which demonstrates how to use a real time timer
public class RealTimeTimerExample : MonoBehaviour
{

    // The time used for the timer in this example
    private const float EXAMPLE_TIME = 5.0f;
    // Flag for when the timer has completed
    private bool timerDone = false;

    public void Start()
    {
        Debug.Log("Timer started!");
        // Start the timer method as a coroutine
        StartCoroutine(timer(EXAMPLE_TIME));
    }

    public void Update()
    {
        if (timerDone)
        {
            // Print a message if the timer has completed
            Debug.Log("Timer is done!");
        }
    }

    /// <summary>
    /// A method that can be run as a coroutine to simulate a timer of a provided duration
    /// </summary>
    /// <param name="timeToWait">How long the timer should wait</param>
    /// <returns>void, use a flag or callback after the method completes</returns>
    private IEnumerator timer(float timeToWait)
    {
        yield return new WaitForSecondsRealtime(timeToWait);
        timerDone = true;
    }
}
