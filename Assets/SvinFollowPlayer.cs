
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SvinFollowPlayer : MonoBehaviour
{
    //public Transform player; // Посилання на гравця
    //public float speed = 5f; // Швидкість руху об'єкта

    //private Rigidbody rb; // Фізичне тіло об'єкта

    //void Start()
    //{
    //    // Отримуємо фізичне тіло об'єкта
    //    rb = GetComponent<Rigidbody>();
    //    // Ввімкнути гравітацію для фізичного тіла об'єкта
    //    rb.useGravity = true;
    //}

    //void FixedUpdate()
    //{
    //    // Визначаємо напрямок руху до гравця
    //    Vector3 direction = player.position - transform.position;
    //    direction.Normalize();

    //    // Рухаємо об'єкт в напрямку до гравця
    //    rb.velocity = direction * speed;
    //}


    public Transform player; // Посилання на гравця
    public float speed = 5f; // Швидкість руху об'єкта

    void Update()
    {
        // Визначаємо напрямок руху до гравця
        Vector3 direction = player.position - transform.position;
        direction.Normalize();

        // Рухаємо об'єкт в напрямку до гравця
        //   transform.position += direction * speed * Time.deltaTime;
        transform.position = new Vector3()
        {
            x = transform.position.x + direction.x * speed * Time.deltaTime,
            z = transform.position.z + direction.z * speed * Time.deltaTime,
            y = transform.position.y
        };
    }

    //   public Transform target;
    //    public float speed = 4f;
    //    Rigidbody rig;
    //// Start is called before the first frame update
    //void Start()
    //    {
    //        rig = GetComponent<Rigidbody>();
    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {
    //        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
    //        rig.MovePosition(pos);
    //        //transform.LookAt(target);

    //    }

}
