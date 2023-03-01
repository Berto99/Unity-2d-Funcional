using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuOpciones : MonoBehaviour
{
    public void pantallaCompleta(bool pantallaCompleta)
    {
        Screen.fullScreen = pantallaCompleta;
    }

    public void cambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
