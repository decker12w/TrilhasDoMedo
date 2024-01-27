using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class ButtonLeft : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textDisplay;   
    private Arvore arvore;
    private Dialogue dialogue;
    private bool acabou;
    void Start()
    {
        arvore = GameObject.FindObjectOfType<Arvore>();
        dialogue = GameObject.FindObjectOfType<Dialogue>();
        textDisplay.text = arvore.GetTextoEsq(dialogue.GetIndex());
    }
    void Update(){
    if (arvore.GetNode(dialogue.GetIndex()).esq == null && arvore.GetNode(dialogue.GetIndex()).dir == null)
    {
        textDisplay.text = "Restart";
        acabou = true;
    }
}
    public void OnClick()
{
    if(acabou){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    else{
        dialogue.StopTyping();
        dialogue.textDisplay.text = string.Empty;
        dialogue.SetIndex(arvore.GetNode(dialogue.GetIndex()).esq.aux);
        textDisplay.text = arvore.GetTextoEsq(dialogue.GetIndex());
        ButtonRight buttonRight = GameObject.FindObjectOfType<ButtonRight>();
        buttonRight.UpdateText();
        dialogue.StartDialogue();
    }
    
}

public void UpdateText()
    {
        textDisplay.text = arvore.GetTextoEsq(dialogue.GetIndex());
    }
}
