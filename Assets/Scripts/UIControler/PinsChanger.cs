using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinsChanger : MonoBehaviour
{
    [SerializeField] private GameObject pins12;
    [SerializeField] private GameObject goalBlocksPins12;

    [SerializeField] private GameObject pins14;
    [SerializeField] private GameObject goalBlocksPins14;

    [SerializeField] private GameObject pins16;
    [SerializeField] private GameObject goalBlocksPins16;
    [Header("Camera sttings")]
    [SerializeField] private Camera _camera;

    [SerializeField] private Vector3 pos12;
    [SerializeField] private Vector3 pos14;
    [SerializeField] private Vector3 pos16;
    

    // зробити статік метод у іншому класі
    public void ChangePinTo12()
    {
        pins12.SetActive(true);
        goalBlocksPins12.SetActive(true);

        pins14.SetActive(false);
        pins16.SetActive(false);
        
        goalBlocksPins14.SetActive(false);
        goalBlocksPins16.SetActive(false);
    }

    public void ChangePinTo14()
    {
        pins12.SetActive(true);
        goalBlocksPins12.SetActive(false);

        pins14.SetActive(true);
        goalBlocksPins14.SetActive(true);
        
        pins16.SetActive(false);
        goalBlocksPins16.SetActive(false);
    }

    public void ChangePinTo16()
    {
        pins12.SetActive(true);
        goalBlocksPins12.SetActive(false);

        pins14.SetActive(true);
        goalBlocksPins14.SetActive(false);
        
        pins16.SetActive(true);
        goalBlocksPins16.SetActive(false);
        
        
    }
}