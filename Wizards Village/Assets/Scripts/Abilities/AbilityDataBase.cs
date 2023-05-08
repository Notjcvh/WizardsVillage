using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Ability Database", menuName = "Ability Systems")]
public class AbilityDataBase : ScriptableObject, ISerializationCallbackReceiver
{
    public List<Abilites> abilites;
    public Dictionary<Abilites, int> GetId = new Dictionary<Abilites, int>();




    public void OnAfterDeserialize()
    {
        GetId = new Dictionary<Abilites, int>();
        for (int i = 0; i < abilites.Count; i++)
        {
            GetId.Add(abilites[i], i);
        }
    }

    public void OnBeforeSerialize()
    {
        
    }
}
