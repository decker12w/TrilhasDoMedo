using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonRight : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textDisplay;   
    private Arvore arvore;
    private Dialogue dialogue;
    private bool acabou;
    void Start()
    {
        arvore = GameObject.FindObjectOfType<Arvore>();
        dialogue = GameObject.FindObjectOfType<Dialogue>();
        textDisplay.text = arvore.GetTextoDir(dialogue.GetIndex());
    }

void Update(){
    if (arvore.GetNode(dialogue.GetIndex()).esq == null && arvore.GetNode(dialogue.GetIndex()).dir == null)
    {
        textDisplay.text = "Quit";
        acabou = true;
    }
}
    public void OnClick()
{
    if(acabou){
        Application.Quit();
    }
    else{
     
        dialogue.StopTyping();
        dialogue.textDisplay.text = string.Empty;
        dialogue.SetIndex(arvore.GetNode(dialogue.GetIndex()).dir.aux);
        textDisplay.text = arvore.GetTextoDir(dialogue.GetIndex());
        ButtonLeft buttonLeft = GameObject.FindObjectOfType<ButtonLeft>();
        buttonLeft.UpdateText();
        dialogue.StartDialogue();
    }
    
}

public void UpdateText()
    {
        textDisplay.text = arvore.GetTextoDir(dialogue.GetIndex());
    }
}
