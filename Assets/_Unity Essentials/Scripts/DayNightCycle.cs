using UnityEngine;

//i used chatgpt to generate this code check it out here
//with the amaziongames@gmail.com account
//at https://chatgpt.com/c/68531e51-7254-800a-8d6d-ea49d4c8dd31

public class DayNightCycle : MonoBehaviour
{
    [Header("Day/Night Settings")]
    [Tooltip("How many seconds a full day lasts (360 degrees of rotation).")]
    [SerializeField]
    private float dayDurationInSeconds = 60f;

    private float rotationSpeed;

    void Start()
    {
        if (dayDurationInSeconds <= 0)
        {
            Debug.LogWarning("Day duration must be greater than zero. Setting to default (60s).");
            dayDurationInSeconds = 60f;
        }

        // Calculate rotation speed in degrees per second
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate around the X-axis to simulate the sun's movement
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
