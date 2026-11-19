
using UnityEngine;
using System;

public class AnalogClock : MonoBehaviour
{
    [Header("Clock Hands")]
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        // Get current local time
        DateTime currentTime = DateTime.Now;

        // Calculate hand rotations
        float seconds = currentTime.Second + currentTime.Millisecond / 1000f;
        float minutes = currentTime.Minute + seconds / 60f;
        float hours = (currentTime.Hour % 12) + minutes / 60f;

        // Rotate clock hands
        secondHand.localRotation =
            Quaternion.Euler(seconds * 6f,0f, 0f);

        minuteHand.localRotation =
            Quaternion.Euler(minutes * 6f,0f, 0f);

        hourHand.localRotation =
            Quaternion.Euler(hours * 30f,0f, 0f);
    }
}
