using UnityEngine;

public class PlayerPrefsEnemyDataSaver : PlayerPrefsObjectSaver<EnemyData>
{
    [ContextMenu("Save")]
    public void Save()
    {
        SaveData();
    }
    
}


