using UnityEngine;

public class DragonMove : MonoBehaviour
{

    public float speed = 5;
    public bool goingUp = true;

    private float ratWait = 1, fireballWait = 2, speedWait = 1;
    private float ratTimer = 0, fireballTimer = 0, speedTimer = 0;

    public GameObject Rat;
    public GameObject Fireball;
    public GameObject Speed;


    // Update is called once per frame
    void Update()
    {

        ratTimer += Time.deltaTime;
        fireballTimer += Time.deltaTime;
        speedTimer += Time.deltaTime;

        if (ratTimer > ratWait)
        {

            Instantiate(Rat, transform.position, Quaternion.identity);
            ratTimer = 0;
            ratWait = Random.Range(1f, 2f);

        }

        if (fireballTimer > fireballWait)
        {

            Instantiate(Fireball, transform.position, Quaternion.identity);
            fireballTimer = 0;
            fireballWait = Random.Range(2f, 3f);

        }

        if (speedTimer > speedWait)
        {

            Instantiate(Speed, transform.position, Quaternion.identity);
            speedTimer = 0;
            speedWait = Random.Range(9f, 11f);

        }

        transform.Translate(transform.up * speed * Time.deltaTime);

        if (transform.position.y > 4 && goingUp == true)
        {

            goingUp = false;
            speed *= -1;

        }

        if (transform.position.y < -4 && goingUp == false)
        {

            goingUp = true;
            speed *= -1;

        }



    }
}
