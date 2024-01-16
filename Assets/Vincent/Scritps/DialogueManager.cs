using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject firstSpawn;
    private int index;

    // Start is called before the first frame update
    void Start()
    {
        
        textComponent.text = string.Empty;
        
            
        
        

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {

            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());

        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    void StartDialogue()
    {
        index = 0;
        
             StartCoroutine(TypeLine());
        
        
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    
}
