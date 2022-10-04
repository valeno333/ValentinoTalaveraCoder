using UnityEngine;

public class Player : MonoBehaviour
{
    public float heal = 5;
    public float venom = 5;
    public float playerHealth = 100f;
    public Vector3 scale;
    public Vector3 movement;
    public float movementSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale += scale;

    }



    // Update is called once per frame
    void Update()
    {
        transform.position += (movement * movementSpeed) * Time.deltaTime;
        LoseHealth();
        GainHealth();
        Debug.Log("El jugador tiene " + playerHealth + " de vida");

    }
    void LoseHealth()
    {
        playerHealth -= venom * Time.deltaTime;
    }
    void GainHealth()
    {
        playerHealth += heal * Time.deltaTime;
    }
}

