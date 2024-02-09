using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    [SerializeField] private Material offMat;
    [SerializeField] private Material OnMat;
    Renderer meshRenderer;

    public delegate void Switch();
    public static Switch TurnOn;
    public static Switch TurnOff;

    void Awake()
    {
        meshRenderer = GetComponent<Renderer>();
    }

void OnEnable()
{
    TurnOn += TurnOnLight;
    TurnOff += TurnOffLight;
    
}

void OnDisable()
{
    TurnOff -= TurnOffLight;
    TurnOn -= TurnOnLight;
}


void TurnOnLight()
{
    var matCopy = meshRenderer.materials;
    matCopy[2] = OnMat;
    meshRenderer.materials = matCopy;
}

void TurnOffLight()
{
    var matCopy = meshRenderer.materials;
    matCopy[1] = offMat;
    meshRenderer.materials = matCopy;
}

}
