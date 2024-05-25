using UnityEngine;

public class MyHouse : MonoBehaviour
{

    [SerializeField] private RoomLayout roomLayout;//間取り
    [SerializeField] private bool hasLiving;//リビング
    [SerializeField] private bool hasBedRoom;//ベッド
    [SerializeField] private BedSize bedSize;
    [SerializeField] private bool hasKichin;//キッチン
    [SerializeField] private bool hasBathRoom;//風呂
    [SerializeField] private bool hasToiletRoom;//トイレ
    [SerializeField] private bool hasWorkRoom;//作業部屋
    
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
        Room room = new(roomLayout, hasLiving);
        room.RoomLayoutDeb();

        //キッチン
        KichinRoom kichinRoom = new(kichinStove, riceCooker, oven, hasKichin);
        kichinRoom.KichinRoomDeb();

        //リビング
        LivingRoom livingRoom = new(desk, chair, sofa, hasLiving);
        livingRoom.LivingDeb();

        //ベッドルーム
        BedRoom bedRoom = new(bedSize, bed, pillow, hasBedRoom);
        bedRoom.BedRoomDeb();

        //作業部屋
        WorkRoom workRoom = new(computer, closet, hasWorkRoom);
        workRoom.WorkRoomDeb();

        //バスルーム
        BathRoom bathRoom = new(syampoo, hasBathRoom);
        bathRoom.BathRoomDeb();

        ////トイレ
        ToiletRoom toiletRoom = new(toiletPaper, hasToiletRoom);
        toiletRoom.ToiletRoomDeb();
    }

    class Room
    {
        private readonly RoomLayout roomLayoutNow;
        private readonly bool hasRoomLayoutJudge;

        public Room(RoomLayout roomLayout, bool hasLiving)
        {
            roomLayoutNow = roomLayout;
            hasRoomLayoutJudge = hasLiving;
        }

        public void RoomLayoutDeb()
        {
            if (!hasRoomLayoutJudge)return;
            Debug.Log($"間取りは{roomLayoutNow}です");
        }

    }

    class LivingRoom
    {
        private readonly int desk;
        private readonly int chair;
        private readonly int sofa;
        private readonly bool hasLiving;

        public LivingRoom(int desk, int chair, int sofa, bool hasLiving)
        {
            this.desk = desk;
            this.chair = chair;
            this.sofa = sofa;
            this.hasLiving = hasLiving;
        }

        public void LivingDeb()
        {
            if (!hasLiving) return;
            Debug.Log($"机は{desk}個あるよ");
            Debug.Log($"イスは{chair}個あるよ");
            Debug.Log($"ソファは{sofa}個あるよ");
        }
    }

    class KichinRoom
    {
        private readonly int kichinStove;
        private readonly int riceCooker;
        private readonly int oven;
        private readonly bool hasKichin;


        public KichinRoom(int kichinStove, int riceCooker, int oven, bool hasKichin)
        {
            this.kichinStove = kichinStove;
            this.riceCooker = riceCooker;
            this.oven = oven;

            this.hasKichin = hasKichin;
        }

        public void KichinRoomDeb()
        {
            if (!hasKichin) return;
            Debug.Log($"キッチンストーブは{kichinStove}個あるよ");
            Debug.Log($"炊飯器は{riceCooker}個あるよ");
            Debug.Log($"オーブンは{oven}個あるよ");
        }
    }

    class BedRoom
    {
        private readonly BedSize bedSize;
        private readonly int bed;
        private readonly int pillow;
        private readonly bool hasBedRoom;

        public BedRoom(BedSize bedSize, int bed, int pillow, bool hasBedRoom)
        {
            this.bedSize = bedSize;
            this.bed = bed;
            this.pillow = pillow;
            this.hasBedRoom = hasBedRoom;
        }

        public void BedRoomDeb()
        {
            if (!hasBedRoom) return;
            Debug.Log($"ベッドは{bed}個あるよ");
            Debug.Log($"枕は{pillow}個あるよ");
        }
    }

    class WorkRoom
    {
        private readonly int computer;
        private readonly int closet;
        private readonly bool hasWorkRoom;

        public WorkRoom(int computer, int closet, bool hasWorkRoom)
        {
            this.computer = computer;
            this.closet = closet;
            this.hasWorkRoom = hasWorkRoom;
        }

        public void WorkRoomDeb()
        {
            if (!hasWorkRoom) return;
            Debug.Log($"パソコンは{computer}個あるよ");
            Debug.Log($"クローゼットは{closet}個あるよ");
        }
    }

    class ToiletRoom
    {
        private readonly int toiletPaper;
        private readonly bool hasToiletRoom;


        public ToiletRoom(int toiletPaper, bool hasToiletRoom)
        {
            this.toiletPaper = toiletPaper;
            this.hasToiletRoom = hasToiletRoom;
        }

        public void ToiletRoomDeb()
        {
            if (!hasToiletRoom) return;
            Debug.Log($"トイレットペーパーは{toiletPaper}個あるよ");
        }
    }

    class BathRoom
    {
        private readonly int syampoo;
        private readonly bool hasBathRoom;

        public BathRoom(int syampoo, bool hasBathRoom)
        {
            this.syampoo = syampoo;
            this.hasBathRoom = hasBathRoom;
        }

        public void BathRoomDeb()
        {
            if (!hasBathRoom) return;
            Debug.Log($"シャンプーは{syampoo}個あるよ");
        }
    }
}
