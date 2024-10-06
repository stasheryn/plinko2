using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteHistory : MonoBehaviour
{
    public List<NumberResult> listOfHistory;
    
    
    
    public static DeleteHistory Instance
    {
        get;
        private set;
    }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void ClearHistory()
    {
        for (int i = 0; i < listOfHistory.Count; i++)
        {
            if (listOfHistory[i] != null)
            {
                Destroy(listOfHistory[i].gameObject);
            }
        }
    }
}
