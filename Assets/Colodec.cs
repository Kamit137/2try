using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Colodec : MonoBehaviour
{

    [SerializeField] Transform maxHeight;
    [SerializeField] Transform minHeight;
    [SerializeField] float maxAngle;
    [SerializeField] Transform bucket;
    [SerializeField] CircularDrive circularDrive;
    [SerializeField] Interactable interactableDrive;
    [SerializeField] float maxSpeedToDown = 10;
    float speed = 0;
    [SerializeField] float timerBeforeFall = 1;
    float lastAngle = 0;

    void Start()
    {
        bucket.position = minHeight.position;
        speed = maxSpeedToDown;
    }

    private void Update()
    {
        if (circularDrive.outAngle > maxAngle)
        {
            circularDrive.outAngle = maxAngle;
        }
        if (circularDrive.outAngle < 0)
        {
            circularDrive.outAngle = 0;
        }
        else
        {
            if (lastAngle < circularDrive.outAngle)
            {
                StopFall();
            }
            bucket.position = Vector3.Lerp(minHeight.position, b: maxHeight.position, circularDrive.outAngle / maxAngle);
            circularDrive.outAngle -= Time.deltaTime * speed;
        }
        lastAngle = circularDrive.outAngle;
    }
    void StopFall()
    {
        StopAllCoroutines();
        speed = 0;
        StartCoroutine(StartFall());
    }
    IEnumerator StartFall()
    {
        yield return new WaitForSeconds(timerBeforeFall);
        speed = maxSpeedToDown;
    }
}