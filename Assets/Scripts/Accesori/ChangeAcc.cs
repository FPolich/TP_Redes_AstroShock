using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAcc : MonoBehaviour
{
    [SerializeField]
    List<Mesh> accesories = new List<Mesh>();

    [SerializeField]
    GameObject myGm;

    MeshFilter myFilter;

    int index = 0;

    private void Awake()
    {
        myFilter = myGm.GetComponent<MeshFilter>();

        myFilter.mesh = accesories[0];

    }

    public void ChangeAccesor(bool dir)
    {
        index += dir ? 1 : -1;
        print(index);
        if (index >= accesories.Count) index = 0;
        else if (index < 0) index = accesories.Count-1;

        myFilter.mesh = accesories[index];
        print(myFilter);

    }
}
