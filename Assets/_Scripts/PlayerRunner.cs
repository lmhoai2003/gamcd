
using UnityEngine;
using Fusion;
using Unity.Collections;

public class PlayerRunner : SimulationBehaviour, IPlayerJoined
{
    [SerializeField] private GameObject[] playerPrefab;
    public int chonNhanVat;

    public float x1, y1, z1;
    public float x2, y2, z2;
    public float x,y,z;



    public void PlayerJoined(PlayerRef player)
    {
        if (player == Runner.LocalPlayer)

        {
            var ran = Random.Range(1, 3);
            if (ran == 1)
            {
                x = x1;
                y = y1;  
                z = z1;
            }
            else
            {
                x = x2;
                y = y2;
                z = z2;
            }
        }


        // Spawn nhân vật đã chọn
        Runner.Spawn(playerPrefab[chonNhanVat], new Vector3(x,y,z), Quaternion.identity, Runner.LocalPlayer, (runner, obj) =>
        {
            var playerSetup = obj.GetComponent<PlayerSetup>();
            if (playerSetup != null)
            {
                playerSetup.SetupCamera();
            }
        });

    }
    public void ChonNhanVat1()
    {
        chonNhanVat = 0;
    }
    public void ChonNhanVat2()
    {
        chonNhanVat = 1;
    }
}




