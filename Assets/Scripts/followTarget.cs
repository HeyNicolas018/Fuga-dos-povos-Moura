using UnityEngine;

public class followTarget : MonoBehaviour
{

    public Transform target;
    public Vector3 offset = new Vector3(0, 0, -10);
    // ESTE CODIGO SEGUE O TARGET SEMPRE
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null)
        {
            Debug.Log("Você esqueceu de colocar um target beste script.");
            Destroy(this);
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
