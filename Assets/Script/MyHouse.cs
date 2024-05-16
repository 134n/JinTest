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
    [SerializeField] private int trashCan;
    [SerializeField] private int oven;
    [SerializeField] private int pod;
    [SerializeField] private int tableware;
    [SerializeField] private int cup;
    [SerializeField] private int knife;
    [SerializeField] private int spoon;

    //リビング
    [SerializeField] private int desk;
    [SerializeField] private int chair;
    [SerializeField] private int sofa;
    [SerializeField] private int tv;
    [SerializeField] private int airConditioner;
    [SerializeField] private int curtain;

    //ベッドルーム
    [SerializeField] private int bed;
    [SerializeField] private int pillow;
    [SerializeField] private int blanket;
    [SerializeField] private int illumination;
    [SerializeField] private int condom;

    //作業部屋
    [SerializeField] private int computer;
    [SerializeField] private int closet;
    [SerializeField] private int clothes;
    [SerializeField] private int gameMachine;


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
        KichinRoom KR = new(kichinStove, riceCooker, trashCan, oven, pod, tableware, cup, knife, spoon, kichin);
        KR.KichinRoomDeb();

        //リビング
        LivingRoom LR = new(desk, chair, sofa, tv, airConditioner, curtain, living);
        LR.LivingDeb();

        //ベッドルーム
        BedRoom BedR = new(bedSize, bed, pillow, blanket, illumination, condom, bedRoom);
        BedR.BedRoomDeb();

        //作業部屋
        WorkRoom WR = new(computer, closet, clothes, gameMachine, workRoom);
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
            if (roomLayoutJudge == true)
            {
                Debug.Log($"間取りは{roomLayoutNow}です");
            }
            else
            {
                return;
            }
        }

    }

    class LivingRoom
    {
        private readonly int desk;
        private readonly int chair;
        private readonly int sofa;
        private readonly int tv;
        private readonly int airConditioner;
        private readonly int curtain;
        private readonly bool living;

        public LivingRoom(int desk, int chair, int sofa, int tv, int airConditioner, int curtain, bool living)
        {
            this.desk = desk;
            this.chair = chair;
            this.sofa = sofa;
            this.tv = tv;
            this.airConditioner = airConditioner;
            this.curtain = curtain;
            this.living = living;
        }

        public void LivingDeb()
        {
            if (living == true)
            {
                Debug.Log($"机は{desk}個あるよ");
                Debug.Log($"イスは{chair}個あるよ");
                Debug.Log($"ソファは{sofa}個あるよ");
                Debug.Log($"テレビは{tv}個あるよ");
                Debug.Log($"エアコンは{airConditioner}個あるよ");
                Debug.Log($"カーテンは{curtain}個あるよ");
            }
            else { return; };

        }
    }

    class KichinRoom
    {
        private readonly int kichinStove;
        private readonly int riceCooker;
        private readonly int trashCan;
        private readonly int oven;
        private readonly int pod;
        private readonly int tableware;
        private readonly int cup;
        private readonly int knife;
        private readonly int spoon;
        private readonly bool kichin;


        public KichinRoom(int kichinStove, int riceCooker, int trashCan, int oven,
            int pod, int tableware, int cup, int knife, int spoon, bool kichin)
        {
            this.kichinStove = kichinStove;
            this.riceCooker = riceCooker;
            this.trashCan = trashCan;
            this.oven = oven;
            this.pod = pod;
            this.tableware = tableware;
            this.cup = cup;
            this.knife = knife;
            this.spoon = spoon;

            this.kichin = kichin;
        }

        public void KichinRoomDeb()
        {

            if (kichin == true)
            {
                Debug.Log($"キッチンストーブは{kichinStove}個あるよ");
                Debug.Log($"炊飯器は{riceCooker}個あるよ");
                Debug.Log($"ゴミ箱は{trashCan}個あるよ");
                Debug.Log($"オーブンは{oven}個あるよ");
                Debug.Log($"ポッドは{pod}個あるよ");
                Debug.Log($"食器は{tableware}個あるよ");
                Debug.Log($"コップは{cup}個あるよ");
                Debug.Log($"ナイフは{knife}個あるよ");
                Debug.Log($"スプーンは{spoon}個あるよ");
            }
            else { return; };

        }
    }

    class BedRoom
    {
        private BedSize bedSize;
        private readonly int bed;
        private readonly int pillow;
        private readonly int blanket;
        private readonly int illumination;
        private readonly int condom;
        private readonly bool bedRoom;

        public BedRoom(BedSize bedSize, int bed, int pillow, int blanket, int illumination, int condom, bool bedRoom)
        {
            this.bedSize = bedSize;
            this.bed = bed;
            this.pillow = pillow;
            this.blanket = blanket;
            this.illumination = illumination;
            this.condom = condom;
            this.bedRoom = bedRoom;
        }

        public void BedRoomDeb()
        {
            if (bedRoom == true)
            {
                Debug.Log($"ベッドは{bed}個あるよ");
                Debug.Log($"枕は{pillow}個あるよ");
                Debug.Log($"毛布は{blanket}個あるよ");
                Debug.Log($"照明は{illumination}個あるよ");
                Debug.Log($"コンドームは{condom}個あるよ");
            }
            else { return; };

        }
    }

    class WorkRoom
    {
        private readonly bool workRoom;
        private readonly int computer;
        private readonly int closet;
        private readonly int clothes;
        private readonly int gameMachine;

        public WorkRoom(int computer, int closet, int clothes, int gameMachine, bool workRoom)
        {
            this.computer = computer;
            this.closet = closet;
            this.clothes = clothes;
            this.gameMachine = gameMachine;
            this.workRoom = workRoom;
        }

        public void WorkRoomDeb()
        {
            if (workRoom == true)
            {
                Debug.Log($"パソコンは{computer}個あるよ");
                Debug.Log($"クローゼットは{closet}個あるよ");
                Debug.Log($"服は{clothes}個あるよ");
                Debug.Log($"ゲーム機は{gameMachine}個あるよ");
            }
            else { return; };
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
            if (toiletRoom == true)
            {
                Debug.Log($"トイレットペーパーは{toiletPaper}個あるよ");
            }
            else { return; };

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
            if (bathRoom == true)
            {
                Debug.Log($"シャンプーは{syampoo}個あるよ");
            }
            else { return; };

        }
    }


}
