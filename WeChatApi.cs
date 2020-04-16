
namespace WeChat
{
    interface Wx_Chat_API
    {
        
         void SendPacket(int ConnID,string Packet);
        
        /// <summary>
        /// 初始化,传输DLL调用密码,用于简单的防止DLL被盗用
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="PassWord"></param>
         void Init(int ConnID, string PassWord);
        
        /// <summary>
        /// 功能_读取通讯录列表
        /// </summary>
        /// <param name="ConnID"></param>
         void GetContactList(int ConnID);
        
        /// <summary>
        /// 功能_读取群员列表
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="GroupID"></param>
         void GetGroupMember(int ConnID, string GroupID);
        
        /// <summary>
        /// 功能_下载用户详细信息
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="GroupID"></param>
        /// <param name="Wxid"></param>
         void GetWxidInfo(int ConnID, string GroupID, string Wxid);
        
        /// <summary>
        /// 功能_GetA8Key 微信浏览器操作
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
        /// <param name="URL"></param>
         void GetA8Key(int ConnID, string Wxid, string URL);
        
        /// <summary>
        /// 功能_发送文本消息
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>3
        /// <param name="AtWxidArray"></param>
        /// <param name="Message"></param>
         void SendTextMsg(int ConnID, string Wxid, string[] AtWxidArray, string Message);
        
        /// <summary>
        /// 功能_发送文件消息
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Type"></param>
        /// <param name="Wxid"></param>
        /// <param name="FilePath">欲发送文件的完整路径</param>
         void SendFileMsg(int ConnID, int Type, string Wxid, string FilePath);
        
        /// <summary>
        /// 功能_发送名片消息
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
        /// <param name="CardWxid"></param>
         void SendCardMsg(int ConnID, string Wxid, string CardWxid);
        
        /// <summary>
        /// 功能_发送地图定位消息
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
        /// <param name="MapXML"></param>
         void SendMapMsg(int ConnID, string Wxid, string MapXML);
        
        /// <summary>
        /// 功能_发送图文链接消息
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
        /// <param name="XML"></param>
         void SendURLMsg(int ConnID, string Wxid, string XML);
        
        /// <summary>
        /// 功能_发送小程序 2.7及以上版本有效
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
        /// <param name="XML"></param>
        /// <param name="ShowImage"></param>
         void SendWeChatApp(int ConnID, string Wxid, string XML, string ShowImage);
        
        /// <summary>
        /// 功能_撤回发出消息
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
        /// <param name="ServerID"></param>
        /// <param name="Message"></param>
         void RevokeMsg(int ConnID, string Wxid, string ServerID, string Message);
        
        /// <summary>
        /// 功能_接收的消息被撤回本地无提示
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Opt"></param>
         void DesRevoke(int ConnID ,bool Opt);
        
        /// <summary>
        /// 功能_接收转账
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
        /// <param name="Transid"></param>
        /// <param name="Time"></param>
         void GetMoney(int ConnID, string Wxid, string Transid, int Time);
        
        /// <summary>
        /// 功能_通过Wxid或v1添加好友
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Type"></param>
        /// <param name="AddType"></param>
        /// <param name="Wxid"></param>
        /// <param name="v2"></param>
        /// <param name="Message"></param>
         void AddFriend(int ConnID, int Type, int AddType, string Wxid, string v2, string Message);
        
        /// <summary>
        /// 功能_通过请求消息XML通过好友请求
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="ApplyXML"></param>
         void PassApply(int ConnID, string ApplyXML);
        
        /// <summary>
        /// 功能_删除好友
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
         void DelFriend(int ConnID, string Wxid);
        
        /// <summary>
        /// 功能_取消关注公众号
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="GHWxid"></param>
         void DelGHFriend(int ConnID, string GHWxid);
        
        /// <summary>
        /// 功能_设置好友备注
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
        /// <param name="Mark"></param>
         void SetFriendMark(int ConnID, string Wxid, string Mark);
        
        /// <summary>
        /// 功能_创建群聊
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="MemberArray"></param>
         void CreateGroup(int ConnID, string[] MemberArray);
       
        /// <summary>
        /// 功能_退出群聊
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="GroupID"></param>
         void QuitGroup(int ConnID, string GroupID);
        
        /// <summary>
        /// 功能_批量拉群 - 发送邀请链接或直接拉入
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Type"></param>
        /// <param name="GroupID"></param>
        /// <param name="MemberArray"></param>
         void InviteToGroup(int ConnID, int Type, string GroupID, string[] MemberArray);
        
        /// <summary>
        /// 功能_批量提出群员
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="GroupID"></param>
        /// <param name="MemberArray"></param>
         void KickGroupMember(int ConnID, string GroupID, string[] MemberArray);
        
        /// <summary>
        /// 功能_修改群名称
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="GroupID"></param>
        /// <param name="Name"></param>
         void SetGroupName(int ConnID, string GroupID, string Name);
        
        /// <summary>
        /// 群主功能_发送群公告(@所有人)
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="GroupID"></param>
        /// <param name="Boss"></param>
        /// <param name="Notice"></param>
         void SetGroupNotice(int ConnID, string GroupID, string Boss, string Notice);
        
        /// <summary>
        /// 功能_设置自己的群昵称
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="GroupID"></param>
        /// <param name="Nick"></param>
         void SetMyGroupNick(int ConnID, string GroupID, string Nick);
        
        /// <summary>
        /// 功能_获取收藏列表
        /// </summary>
        /// <param name="ConnID"></param>
         void GetFavList(int ConnID);
        
        /// <summary>
        /// 功能_发送指定收藏内容
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Wxid"></param>
        /// <param name="Index"></param>
         void SendFavMsg(int ConnID, string Wxid, int Index);
        
        /// <summary>
        /// 功能_状态操作
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Type">1=免打扰 2=置顶 3=保存通讯录 4=显示群员昵称</param>
        /// <param name="Wxid"></param>
        /// <param name="Opt"></param>
         void StateOpt(int ConnID, int Type, string Wxid, bool Opt);
        
        /// <summary>
        /// 功能_对象操作
        /// </summary>
        /// <param name="ConnID"></param>
        /// <param name="Type"> 1= 切换聊天对象 
        ///                     2= 设置指定Wxid消息已读(取消红点,不切换聊天对象,移动端同步)
        ///                     3= 一键全部已读(取消全部红点,移动端不同步) </param>
        /// <param name="Wxid"></param>
         void SetObject(int ConnID, int Type, string Wxid);
        

    }
}