using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameActor : MonoBehaviour
{
    public string name;
    public void Jump()
    {
        Debug.Log("Name : " + name + " 점프");
    }

    public void Attack()
    {
        Debug.Log("Name : " + name + " 공격");
    }
}
