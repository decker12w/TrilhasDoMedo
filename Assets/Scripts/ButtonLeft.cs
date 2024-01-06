using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonLeft : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textDisplay;   
    private Arvore arvore;
    private Dialogue dialogue;
    void Start()
    {
        arvore = GameObject.FindObjectOfType<Arvore>();
        dialogue = GameObject.FindObjectOfType<Dialogue>();
        textDisplay.text = arvore.GetTextoEsq(dialogue.GetIndex());
    }

    public void OnClick()
{
    dialogue.StopTyping();
    dialogue.textDisplay.text = string.Empty;
    dialogue.SetIndex(arvore.GetNode(dialogue.GetIndex()).esq.aux);
    textDisplay.text = arvore.GetTextoEsq(dialogue.GetIndex());
    ButtonRight buttonRight = GameObject.FindObjectOfType<ButtonRight>();
    buttonRight.UpdateText();
    dialogue.StartDialogue();
}

public void UpdateText()
    {
        textDisplay.text = arvore.GetTextoEsq(dialogue.GetIndex());
    }
}
