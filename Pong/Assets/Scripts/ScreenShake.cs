﻿/*
 * By:Esther STrathy
 * 11/13/19
 * Description: camera shake
 */




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    // Transform of the GameObject you want to shake
    private Transform trans;

    // Desired duration of the shake effect
    public float shakeDuration = 0f;

    // A measure of magnitude for the shake. Tweak based on your preference
    public float shakeMagnitude = 0.7f;

    // A measure of how quickly the shake effect should evaporate
    public float dampingSpeed = 1.0f;

    // The initial position of the GameObject
    Vector3 initialPosition;

    void Awake()
    {
        if (trans == null)
        {
            trans = GetComponent(typeof(Transform)) as Transform;
        }
    }
    void OnEnable()
    {
        initialPosition = transform.localPosition;
    }
    void Update()
    {
        if (shakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
    }
    public void TriggerShake()
    {
        shakeDuration = 2.0f;
    }

}