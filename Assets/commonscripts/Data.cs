using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//所有数据类都定义在这个命名空间里。
namespace Data
{
    

    //这是存档的数据类。
    //存档对应了一个"存档名.dat"。
    /// <summary>
    /// 游戏时使用的数据都保存在"temp.dat"里
    /// 进入游戏时，将值载入temp.dat里，退出游戏时将其中值清空。
    /// 保存游戏时，将值写入"存档名。dat"
    /// </summary>

    public class SaveData
    {
        //存档状态描述的的值；
        public bool is_Data_Writed;  //是否写入了数据

        //玩家数据区域
        public string name;
        public int round;
        public int money;
        public int kindness;
        public int badness;
        //玩家获得物品的数量
        //    public int num_item_00;
        /*以此类推*/

        //玩家装备技能的情况,默认只能有三个技能
        /*  public int equip_skill_0;
          public int equip_skill_1;
          public int equip_skill_2;
          */

        //场景数据区域
        //依据各个场景不同，每个场景的数据不同。
        /// <summary>
        /// 命名方式
        /// isopen_场景编号
        /// state_场景编号_可互动物品编号
        /// isget_场景编号_物品编号
        /// </summary>

        public bool ismidcityfirst;
        public int midcitypos;


        //场景0---------Sce0
        public bool isopen_Sce0;//是否可以进入
        public int state_Sce0_00;//表示场景里某个可互动物品状态
        public int state_Sce0_01;
        /*......省略..........*/


        //对话状态
        public int hotel_chat;
        
            
  //    public bool isget_Sce0_00;//表示场景里某个物品是否获得
                                  /*........省略........*/

        //技能数据区域

     //   public bool isgetSkill_00;//是否获得技能
        
        /*.....................*/

        public SaveData()
        {
            //构造方法，对数据附初值
            is_Data_Writed = false;
            name = "chumeng";
            round = 1;
            money = 0;
            kindness = 1;
            badness = 1;

            isopen_Sce0 = true;
            state_Sce0_00 = 0;
            state_Sce0_01 = 0;
            /*。。。。。。。。。。。。。。。*/
            hotel_chat = 0;

            ismidcityfirst = true;
            midcitypos = 0;



        }
    }

    //这是玩家数据的类
    public class PlayerData
    {
        public string name;
        public int round;   //记录了几周目
        public int money;
        public int kindness;
        public int badness;

        public PlayerData()
        {

        }
    }

    //这是描述物品的类
    public class Item
    {
        /// <summary>
        /// 物品的具体数据保存在一个 json 里
        /// </summary>
        public int ID;//用于查询的ID
        public string name;
        public string description;//描述的文本。
        public int type;//物品的类型
        public int function;//物品的效果

        public Item()
        {
            
        }
    }

    //以下是配套的方法  都在静态类 Function 类中
    public static class Function {
        public const string mainpath = "DreamTruly/";
        public const string temp = mainpath+"temp.dat";
        public const string savedata0 = mainpath+"savedata0.dat";
        public const string savedata1 = mainpath+"savedata1.dat";
        public const string savedata2 = mainpath+"savedata2.dat";
        public const string elsedata = mainpath + "elsepath";
        //把几个常用路径都定义成常量了
        public const string t_iswrite = "?tag=iswritedata";
        public const string t_name = "?tag=name";
        public const string t_round = "?tag=round";
        public const string t_money = "?tag=money";
        public const string t_chat_hotel = "?tag=chathotel";

        public const string t_ismidcityfirst = "?tag=ismidcityfirst";
        public const string t_midcitypos = "?tag=midcitypos";



        //读取存档通用功能
        static SaveData Load(string path)
        {
            SaveData temp = new SaveData();

            temp.isopen_Sce0 = ES2.Load<bool>(path+ "?tag=isopensce0");
            temp.is_Data_Writed = ES2.Load<bool>(path + t_iswrite);
            temp.badness = ES2.Load<int>(path + "?tag=badness");
            temp.kindness = ES2.Load<int>(path + "?tag=kindness");
            temp.money = ES2.Load<int>(path + t_money);
            temp.name = ES2.Load<string>(path + t_name);
            temp.round = ES2.Load<int>(path + t_round);
            temp.state_Sce0_00 = ES2.Load<int>(path + "?tag=statesce000");
            temp.state_Sce0_01 = ES2.Load<int>(path + "?tag=statesce001");
            temp.hotel_chat = ES2.Load<int>(path+t_chat_hotel);
            temp.ismidcityfirst = ES2.Load<bool>(path + t_ismidcityfirst);
            temp.midcitypos = ES2.Load<int>(path + t_midcitypos);
            /*以此类推*/
            return temp;
        }
        //通用写入存档功能
        static void Save(string path, SaveData data)
        {
            ES2.Save(data.name, path + t_name);
            ES2.Save(data.is_Data_Writed,path+t_iswrite);
            ES2.Save(data.isopen_Sce0,path+"?tag=isopensce0");
            ES2.Save(data.badness,path+"?tag=badness");
            ES2.Save(data.money,path+t_money);
            ES2.Save(data.round,path+t_round);
            ES2.Save(data.kindness,path+"?tag=kindness");
            ES2.Save(data.state_Sce0_00,path+"?tag=statesce000");
            ES2.Save(data.state_Sce0_01,path+"?tag=statesce001");
            ES2.Save(data.hotel_chat,path+t_chat_hotel);

            ES2.Save(data.ismidcityfirst, path + t_ismidcityfirst);
            ES2.Save(data.midcitypos, path + t_midcitypos);



            /*以此类推*/
        }


        //以下是外界可以调用的
        //读取存档封装
        public static SaveData LoadSaveData(int num)
        {
            SaveData savedata = new SaveData();
            switch (num)
            {
                case 0://读取存档0
                    savedata = Load(savedata0);
                    break;
                case 1:
                    savedata = Load(savedata1);
                    break;
                case 2:
                    savedata = Load(savedata2);
                    break;
                case 3:
                    savedata = Load(temp);
                    break;
                default:
                    break;
            }
            return savedata;
        }
        //把存档载入到缓存里
        public static void LoadToTemp(int num) //num要为0~2 num 可以用 playerprefs 传递
        {
            SaveData tempdata = new SaveData();
            tempdata = LoadSaveData(num);
            Save(temp, tempdata);
        }
        //封装后的写入功能
        public static void SaveToData(SaveData data,int num)
        {
            switch (num)
            {
                case 0:
                    Save(savedata0,data);
                    break;
                case 1:
                    Save(savedata1, data);
                    break;
                case 2:
                    Save(savedata2, data);
                    break;
                case 3:
                    Save(temp, data);
                    break;
                default:
                    break;
            }
        }
        //判断存档是否存在
        public static bool Is_exist_saveData()
        {
            if (ES2.Exists(temp) && ES2.Exists(savedata0)
                && ES2.Exists(savedata1) && ES2.Exists(savedata2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //重载一个判断存档目录下任意文件的
        public static bool Is_exist_saveData(string path)
        {
            if (ES2.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //新建存档文件,清空全部存档
        public static void  CreatSaveData()
        {
                SaveData data = new SaveData();
                Save(savedata0,data);
                Save(savedata1,data);
                Save(savedata2,data);
                Save(temp,data);
        }
        //清空缓存文件
        public static void Deletetemp()
        {
            SaveData NULLtemp = new SaveData();
            Save(temp,NULLtemp);
        }
        
    }



}