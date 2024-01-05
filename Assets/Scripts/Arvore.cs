using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionNode
{
    public string Decision { get; set; }
    public DecisionNode esqOption { get; set; }
    public DecisionNode dirOption { get; set; }
    public string Result { get; set; }
}
public class Arvore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
{
    DecisionNode root = new DecisionNode
    {
        Decision = "Primeira decisão",
        esqOption = new DecisionNode
        {
            Decision = "Segunda decisão se escolher esquerda",
            esqOption = new DecisionNode { Result = "Resultado se continuar escolhendo esquerda" },
            dirOption = new DecisionNode { Result = "Resultado se escolher direita após escolher esquerda" }
        },
        dirOption = new DecisionNode
        {
            Decision = "Segunda decisão se escolher direita",
            esqOption = new DecisionNode { Result = "Resultado se escolher esquerda após escolher direita" },
            dirOption = new DecisionNode { Result = "Resultado se continuar escolhendo direita" }
        }
    };
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
