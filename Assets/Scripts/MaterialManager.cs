using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    [SerializeField] private Material offMat;
    [SerializeField] private Material OnMat;

    [SerializeField] private Material offMat2;
    [SerializeField] private Material OnMat2;

    [SerializeField] private Material offMat3;
    [SerializeField] private Material OnMat3;
    Renderer meshRenderer;

    public delegate void Switch();
    public static Switch TurnOn1;
    public static Switch TurnOff1;

    public static Switch TurnOn2;
    public static Switch TurnOff2;

    public static Switch TurnOn3;
    public static Switch TurnOff3;

    void Awake()
    {
        meshRenderer = GetComponent<Renderer>();
    }

void OnEnable()
{
    TurnOn1 += TurnOnLight;
    TurnOn2 += TurnOnLight2;
    TurnOn3 += TurnOnLight3;
    TurnOff1 += TurnOffLight;
    TurnOff2 += TurnOffLight;
    TurnOff3 += TurnOffLight;
    
}

void OnDisable()
{
    TurnOn1 -= TurnOnLight;
    TurnOn2 -= TurnOnLight2;
    TurnOn3 -= TurnOnLight3;
    TurnOff1 -= TurnOffLight;
    TurnOff2 -= TurnOffLight;
    TurnOff3 -= TurnOffLight;
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

void TurnOnLight2()
{
    var matCopy = meshRenderer.materials;
    matCopy[4] = OnMat2;
    meshRenderer.materials = matCopy;
}

void TurnOnLight3()
{
    var matCopy = meshRenderer.materials;
    matCopy[6
    ] = OnMat3;
    meshRenderer.materials = matCopy;
}



}
