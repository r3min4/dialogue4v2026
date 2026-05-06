using UnityEngine;
using System;

public static class Interact0M
{

    public static event Action OnInternet;

    public static void Interact()
    {
        OnInteract?.Invoke();
    }
}