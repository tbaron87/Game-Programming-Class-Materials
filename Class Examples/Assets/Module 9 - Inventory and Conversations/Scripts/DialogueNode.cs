using System.Collections.Generic;

[System.Serializable]
public struct DialogueNode
{
    public string text;
    public List<string> responses;
    public List<int> responseIDs;
    public int ID;
}
