using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField]
    protected int health;
    [SerializeField]
    protected int speed;
    [SerializeField]
    protected int gems;
    [SerializeField]
    protected Transform pointA, pointB;
    // Start is called before the first frame update
    void Start()
    {

    }

    public virtual void Attack()
    {
        Debug.Log("My name is: " + this.gameObject.name);
    }

    public abstract void Update();
}
