using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathRoom : MonoBehaviour
{
    [SerializeField] private bool toiletRoomJudge;
    [SerializeField] private bool bathRoomJudge;

    [SerializeField] private int toiletPaper;
    [SerializeField] private int syampoo;
    
    void Start()
    {
        ToiletRoom toiletRoom = new(toiletPaper, toiletRoomJudge);
        toiletRoom.ToiletRoomDeb();

        Bath bath = new(syampoo , bathRoomJudge);
        bath.BathRoomDeb();
    }

    class ToiletRoom
    {
        private readonly int toiletPaper;
        private readonly bool toiletRoomJudge;


        public ToiletRoom(int toiletPaper, bool toiletRoomJudge)
        {
            this.toiletPaper = toiletPaper;
            this.toiletRoomJudge = toiletRoomJudge;
        }

        public void ToiletRoomDeb()
        {
            if (!toiletRoomJudge) return;
            {
                Debug.Log($"トイレットペーパーは{toiletPaper}個あるよ");
            }

        }
    }

    class Bath
    {
        private readonly bool bathRoomJudge;
        private readonly int syampoo;

        public Bath(int syampoo, bool bathRoomJudge)
        {
            this.syampoo = syampoo;
            this.bathRoomJudge = bathRoomJudge;
        }

        public void BathRoomDeb()
        {
            if (!bathRoomJudge) return;
            {
                Debug.Log($"シャンプーは{syampoo}個あるよ");
            }
        }
    }
}
