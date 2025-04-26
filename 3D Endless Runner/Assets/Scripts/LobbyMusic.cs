using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyMusic : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

void Start()
{
    musicSource.time = 0f;
    musicSource.Play();
    StartCoroutine(RestartLoop());
}

IEnumerator RestartLoop()
{
    while (true)
    {
        if (musicSource.time >= 155f) // I am built different
        {
            musicSource.time = 0f;
        }
        yield return null;
    }
}

}
