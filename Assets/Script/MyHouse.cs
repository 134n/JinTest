using UnityEngine;

public class MyHouse : MonoBehaviour
{

    [SerializeField] private RoomLayout roomLayout;//間取り
    [SerializeField] private bool living;//リビング
    [SerializeField] private bool bedRoom;//ベッド
    [SerializeField] private BedSize bedSize;
    [SerializeField] private bool kichin;//キッチン
    [SerializeField] private bool bathRoom;//風呂
    [SerializeField] private bool toiletRoom;//トイレ
    [SerializeField] private bool workRoom;//作業部屋

    enum RoomLayout
    {
        OneRoom,
        OneK,
        OneDK,
        OneLDK,

        TwoK,
        TwoDK,
        TwoLDK,

        ThreeK,
        ThreeDK,
        ThreeLDK,
    }

    enum BedSize
    {
        SemiSingle,
        Single,
        SemiDoble,
        Doble,
        Queen,
        King,
    }

    //キッチン
    [SerializeField] private int kichinStove;
    [SerializeField] private int riceCooker;
    [SerializeField] private int oven;

    //リビング
    [SerializeField] private int desk;
    [SerializeField] private int chair;
    [SerializeField] private int sofa;

    //ベッドルーム
    [SerializeField] private int bed;
    [SerializeField] private int pillow;

    //作業部屋
    [SerializeField] private int computer;
    [SerializeField] private int closet;


    //バスルーム
    [SerializeField] private int syampoo;

    //トイレ
    [SerializeField] private int toiletPaper;

    void Start()
    {
        //間取り
        Room room = new(roomLayout, living);
        room.RoomLayoutDeb();

        //キッチン
        KichinRoom KR = new(kichinStove, riceCooker, oven, kichin);
        KR.KichinRoomDeb();

        //リビング
        LivingRoom LR = new(desk, chair, sofa, living);
        LR.LivingDeb();

        //ベッドルーム
        BedRoom BedR = new(bedSize, bed, pillow, bedRoom);
        BedR.BedRoomDeb();

        //作業部屋
        WorkRoom WR = new(computer, closet, workRoom);
        WR.WorkRoomDeb();

        //バスルーム
        BathRoom BathR = new(syampoo, bathRoom);
        BathR.BathRoomDeb();

        ////トイレ
        ToiletRoom TR = new(toiletPaper, toiletRoom);
        TR.ToiletRoomDeb();
    }

    class Room
    {
        private readonly RoomLayout roomLayoutNow;
        private readonly bool roomLayoutJudge;

        public Room(RoomLayout roomLayout, bool riving)
        {
            roomLayoutNow = roomLayout;
            roomLayoutJudge = riving;
        }

        public void RoomLayoutDeb()
        {
            if (!roomLayoutJudge)return;
            {
                Debug.Log($"間取りは{roomLayoutNow}です");
            }
        }

    }

    class LivingRoom
    {
        private readonly int desk;
        private readonly int chair;
        private readonly int sofa;
        private readonly bool living;

        public LivingRoom(int desk, int chair, int sofa,bool living)
        {
            this.desk = desk;
            this.chair = chair;
            this.sofa = sofa;
            this.living = living;
        }

        public void LivingDeb()
        {
            if (!living) return;
            {
                Debug.Log($"机は{desk}個あるよ");
                Debug.Log($"イスは{chair}個あるよ");
                Debug.Log($"ソファは{sofa}個あるよ");
            }
        }
    }

    class KichinRoom
    {
        private readonly int kichinStove;
        private readonly int riceCooker;
        private readonly int oven;
        private readonly bool kichin;


        public KichinRoom(int kichinStove, int riceCooker,int oven, bool kichin)
        {
            this.kichinStove = kichinStove;
            this.riceCooker = riceCooker;
            this.oven = oven;

            this.kichin = kichin;
        }

        public void KichinRoomDeb()
        {

            if (!kichin) return;
            {
                Debug.Log($"キッチンストーブは{kichinStove}個あるよ");
                Debug.Log($"炊飯器は{riceCooker}個あるよ");
                Debug.Log($"オーブンは{oven}個あるよ");
            }

        }
    }

    class BedRoom
    {
        private BedSize bedSize;
        private readonly int bed;
        private readonly int pillow;
        private readonly bool bedRoom;

        public BedRoom(BedSize bedSize, int bed, int pillow, bool bedRoom)
        {
            this.bedSize = bedSize;
            this.bed = bed;
            this.pillow = pillow;
            this.bedRoom = bedRoom;
        }

        public void BedRoomDeb()
        {
            if (!bedRoom) return;
            {
                Debug.Log($"ベッドは{bed}個あるよ");
                Debug.Log($"枕は{pillow}個あるよ");
            }

        }
    }

    class WorkRoom
    {
        private readonly bool workRoom;
        private readonly int computer;
        private readonly int closet;

        public WorkRoom(int computer, int closet, bool workRoom)
        {
            this.computer = computer;
            this.closet = closet;
            this.workRoom = workRoom;
        }

        public void WorkRoomDeb()
        {
            if (!workRoom) return;
            {
                Debug.Log($"パソコンは{computer}個あるよ");
                Debug.Log($"クローゼットは{closet}個あるよ");
            }
        }
    }

    class ToiletRoom
    {
        private readonly int toiletPaper;
        private readonly bool toiletRoom;


        public ToiletRoom(int toiletPaper, bool toiletRoom)
        {
            this.toiletPaper = toiletPaper;
            this.toiletRoom = toiletRoom;
        }

        public void ToiletRoomDeb()
        {
            if (!toiletRoom) return;
            {
                Debug.Log($"トイレットペーパーは{toiletPaper}個あるよ");
            }
        }
    }

    class BathRoom
    {
        private readonly bool bathRoom;
        private readonly int syampoo;

        public BathRoom(int syampoo, bool bathRoom)
        {
            this.syampoo = syampoo;
            this.bathRoom = bathRoom;
        }

        public void BathRoomDeb()
        {
            if (!bathRoom) return;
            {
                Debug.Log($"シャンプーは{syampoo}個あるよ");
            }

        }
    }


}
