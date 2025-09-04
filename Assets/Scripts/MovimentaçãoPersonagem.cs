using UnityEngine;

public class MovimentaçãoPersonagem : MonoBehaviour
{
    public float velocidade = 5;

    // Update is called once per frame
    void Update()
    {
        float movimento = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float voando = Input.GetAxisRaw("Vertical") * Time.deltaTime;
        transform.position += new Vector3(movimento * velocidade, 0);
        transform.position += new Vector3(0, voando * velocidade);

    }
}
