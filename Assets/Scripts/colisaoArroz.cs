using TMPro;
using UnityEngine;


public class colisaoArroz : MonoBehaviour
{

    TextMeshProUGUI Arroz;


    private int point = 0;

    void Start()
    {
        Arroz = GameObject.Find("Texto ARROZ").transform.GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Arroz") == true)
        {
            point++;
            Destroy(collision.gameObject);
            Arroz.text = "Arroz Coletado: 15/ <color=red>" + point + "</color>";
        }

        if (point >= 5)
        {
            Arroz.text = "Arroz Coletado: 15/ <color=yellow>" + point + "</color >";
        }
        if (point >= 13)
        {
            Arroz.text = "Arroz Coletado: 15/ <color=green>" + point + "</color >";
        }

        if (point == 15)
        {
            Arroz.text = "<color=green>Arroz Coletado: 15/ " + point + " Parabéns!! você conseguiu coletar todos os Arroz que estavam no labirinto. Bom jogo!! </color>";
        }
    }
}


