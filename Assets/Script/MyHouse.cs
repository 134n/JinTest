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
        private readonly RoomLayout _roomLayoutNow;
        private readonly bool _roomLayoutJudge;

        public Room(RoomLayout roomLayout, bool riving)
        {
            _roomLayoutNow = roomLayout;
            _roomLayoutJudge = riving;
        }

        public void RoomLayoutDeb()
        {
            if (_roomLayoutJudge == true)
            {
                Debug.Log($"間取りは{_roomLayoutNow}です");
            }
            else
            {
                return;
            }
        }

    }

    class LivingRoom
    {
        private readonly int _desk;
        private readonly int _chair;
        private readonly int _sofa;
        private readonly int _tv;
        private readonly int _airConditioner;
        private readonly int _curtain;
        private readonly bool _living;

        public LivingRoom(int desk, int chair, int sofa, int tv, int airConditioner, int curtain, bool living)
        {
            _desk = desk;
            _chair = chair;
            _sofa = sofa;
            _tv = tv;
            _airConditioner = airConditioner;
            _curtain = curtain;
            _living = living;
        }

        public void LivingDeb()
        {
            if (_living == true)
            {
                Debug.Log($"机は{_desk}個あるよ");
                Debug.Log($"イスは{_chair}個あるよ");
                Debug.Log($"ソファは{_sofa}個あるよ");
                Debug.Log($"テレビは{_tv}個あるよ");
                Debug.Log($"エアコンは{_airConditioner}個あるよ");
                Debug.Log($"カーテンは{_curtain}個あるよ");
            }
            else { return; };

        }
    }

    class KichinRoom
    {
        private readonly int _kichinStove;
        private readonly int _riceCooker;
        private readonly int _trashCan;
        private readonly int _oven;
        private readonly int _pod;
        private readonly int _tableware;
        private readonly int _cup;
        private readonly int _knife;
        private readonly int _spoon;
        private readonly bool _kichin;


        public KichinRoom(int kichinStove, int riceCooker, int trashCan, int oven,
            int pod, int tableware, int cup, int knife, int spoon, bool kichin)
        {
            _kichinStove = kichinStove;
            _riceCooker = riceCooker;
            _trashCan = trashCan;
            _oven = oven;
            _pod = pod;
            _tableware = tableware;
            _cup = cup;
            _knife = knife;
            _spoon = spoon;

            _kichin = kichin;
        }

        public void KichinRoomDeb()
        {

            if (_kichin == true)
            {
                Debug.Log($"キッチンストーブは{_kichinStove}個あるよ");
                Debug.Log($"炊飯器は{_riceCooker}個あるよ");
                Debug.Log($"ゴミ箱は{_trashCan}個あるよ");
                Debug.Log($"オーブンは{_oven}個あるよ");
                Debug.Log($"ポッドは{_pod}個あるよ");
                Debug.Log($"食器は{_tableware}個あるよ");
                Debug.Log($"コップは{_cup}個あるよ");
                Debug.Log($"ナイフは{_knife}個あるよ");
                Debug.Log($"スプーンは{_spoon}個あるよ");
            }
            else { return; };

        }
    }

    class BedRoom
    {
        private BedSize _bedSize;
        private readonly int _bed;
        private readonly int _pillow;
        private readonly int _blanket;
        private readonly int _illumination;
        private readonly int _condom;
        private readonly bool _bedRoom;

        public BedRoom(BedSize bedSize, int bed, int pillow, int blanket, int illumination, int condom, bool bedRoom)
        {
            _bedSize = bedSize;
            _bed = bed;
            _pillow = pillow;
            _blanket = blanket;
            _illumination = illumination;
            _condom = condom;
            _bedRoom = bedRoom;
        }

        public void BedRoomDeb()
        {
            if (_bedRoom == true)
            {
                Debug.Log($"ベッドは{_bed}個あるよ");
                Debug.Log($"枕は{_pillow}個あるよ");
                Debug.Log($"毛布は{_blanket}個あるよ");
                Debug.Log($"照明は{_illumination}個あるよ");
                Debug.Log($"コンドームは{_condom}個あるよ");
            }
            else { return; };

        }
    }

    class WorkRoom
    {
        private readonly bool _workRoom;
        private readonly int _computer;
        private readonly int _closet;
        private readonly int _clothes;
        private readonly int _gameMachine;

        public WorkRoom(int computer, int closet, int clothes, int gameMachine, bool workRoom)
        {
            _computer = computer;
            _closet = closet;
            _clothes = clothes;
            _gameMachine = gameMachine;
            _workRoom = workRoom;
        }

        public void WorkRoomDeb()
        {
            if (_workRoom == true)
            {
                Debug.Log($"パソコンは{_computer}個あるよ");
                Debug.Log($"クローゼットは{_closet}個あるよ");
                Debug.Log($"服は{_clothes}個あるよ");
                Debug.Log($"ゲーム機は{_gameMachine}個あるよ");
            }
            else { return; };
        }
    }

    class ToiletRoom
    {
        private readonly int _toiletPaper;
        private readonly bool _toiletRoom;


        public ToiletRoom(int toiletPaper, bool toiletRoom)
        {
            _toiletPaper = toiletPaper;
            _toiletRoom = toiletRoom;
        }

        public void ToiletRoomDeb()
        {
            if (_toiletRoom == true)
            {
                Debug.Log($"トイレットペーパーは{_toiletPaper}個あるよ");
            }
            else { return; };

        }
    }

    class BathRoom
    {
        private readonly bool _bathRoom;
        private readonly int _syampoo;

        public BathRoom(int syampoo, bool bathRoom)
        {
            _syampoo = syampoo;
            _bathRoom = bathRoom;
        }

        public void BathRoomDeb()
        {
            if (_bathRoom == true)
            {
                Debug.Log($"シャンプーは{_syampoo}個あるよ");
            }
            else { return; };

        }
    }


}
