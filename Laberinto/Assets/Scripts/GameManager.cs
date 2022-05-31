using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoTiempo;

    private float tiempo = 15;

    private void FixedUpdate()
    {
        tiempo -= Time.deltaTime;
        textoTiempo.text = "" + (int)tiempo;
        if (tiempo <=0)
        {
            Muerto();
        }
    }

    private void Muerto()
    {
        SceneManager.LoadScene(0);

    }

    public void RestaPuntos()
    {
        tiempo--;
    }
}
