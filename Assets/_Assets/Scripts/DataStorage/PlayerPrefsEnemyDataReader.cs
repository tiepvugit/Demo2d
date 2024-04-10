using UnityEngine;

public class PlayerPrefsEnemyDataReader : PlayerPrefsObjectReader<EnemyData>
{

    [ContextMenu("Get")]
    public EnemyData Get()
    {
        return GetData();
    }
}


