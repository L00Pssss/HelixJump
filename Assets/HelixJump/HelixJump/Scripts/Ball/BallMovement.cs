using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BallMovement))]
public class BallMovement : MonoBehaviour
{
    [Header("Fall")]
    [SerializeField] private float fallHeight;
    [SerializeField] private float fallSpeeDefault;
    [SerializeField] private float fallSpeedMax;
    [SerializeField] private float fallSpeedAxeleration;

    private Animator animator;

    private float fallSpeed;

    private float floorY;  

    private void Start()
    {
        enabled = false;

        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (transform.position.y > floorY)
        {
            transform.Translate(0, -fallSpeed * Time.deltaTime, 0);//локальное
                                                                   //  transform.position += Vector3.down * fallSpeed * Time.deltaTime; //глобальное 
            if (fallSpeed < fallSpeedMax)
            {
                fallSpeed += fallSpeedAxeleration * Time.deltaTime;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, floorY, transform.position.z);
            enabled = false;
        }
    }
    public void Jump()
    {
        animator.speed = 1;
        fallSpeed = fallSpeeDefault;
    }
    public void Fall(float startFloorY)
    {
        animator.speed = 0;
        enabled = true;
        floorY = startFloorY - fallHeight;
    }
    public void Stop()
    {
        animator.speed = 0;
    }

    public void floorDest(Collider other)
    {
        Transform floor = other.transform.parent;                             //Извлекаем родителя сегмента
        floor.GetComponent<Animator>().enabled = true;                          //Включаем аниматор у падающего этажа

        foreach (Collider collider in floor.GetComponentsInChildren<Collider>()) //Перебираем все сегменты этажа и выключаем коллайдер
        {
            collider.enabled = false;
        }

        foreach (Rigidbody rigidbody in floor.GetComponentsInChildren<Rigidbody>()) //Перебираем все сегменты этажа и включаем гравитацию
        {
            rigidbody.useGravity = true;
        }
    }
}
