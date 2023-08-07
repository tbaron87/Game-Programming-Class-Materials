using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Conversation : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private List<TextMeshProUGUI> buttons;
    [SerializeField]
    private List<DialogueNode> nodes;

    private int index;
    
    public void Start()
    {
        index = 0;
    }

    public void reponseClicked(int responseIndex)
    {
        int responseToFind = nodes[index].responseIDs[responseIndex];
        foreach(DialogueNode node in nodes)
        {
            if(node.ID == responseToFind)
            {
                index = nodes.IndexOf(node);
                break;
            }
        }
        showNextDialogue();
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            showNextDialogue();
        }
    }

    private void showNextDialogue()
    {
        if (index < nodes.Count)
        {
            text.text = string.Empty;
            StartCoroutine(slowPrintText(0.1f));
            int responseIndex = 0;
            foreach (string response in nodes[index].responses)
            {
                buttons[responseIndex++].text = response;
            }
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    private IEnumerator slowPrintText(float textSpeed)
    {
        foreach (char c in nodes[index].text.ToCharArray())
        {
            text.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
