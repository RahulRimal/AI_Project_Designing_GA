using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI textMesh;


    void Update()
    {
        textMesh.text = "Score: "+score.ToString();    
    }


}
