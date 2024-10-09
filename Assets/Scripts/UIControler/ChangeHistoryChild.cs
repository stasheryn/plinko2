using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeHistoryChild : MonoBehaviour
{
    public delegate void ChildChanged();

    public ChildChanged OnChildChanged;
    private void OnTransformChildrenChanged()
    {
        //OnChildChanged();
        OnChildChanged?.Invoke();
    }
}
