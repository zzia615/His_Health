using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace Jaylosy.Kernel.IDCard
{
    public static class SynIDCardAPI
    {
        //////////////////////////////////////////////////////////////////////////
        //				新中新读卡器
        //				SAM端口函数
        //
        //////////////////////////////////////////////////////////////////////////
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_SetMaxRFByte(int iPort, int ucByte, int bIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_GetCOMBaud(int iPort, ref ulong puiBaudRate);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_SetCOMBaud(int iPort, ulong uiCurrBaud, ulong uiSetBaud);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_OpenPort(int iPort);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_ClosePort(int iPort);
        //////////////////////////////////////////////////////////////////////////
        //				SAM类函数
        //
        //////////////////////////////////////////////////////////////////////////
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int  Syn_ResetSAM(int iPort, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int  Syn_GetSAMStatus(int iPort, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int  Syn_GetSAMID(int iPort, ref string pucSAMID, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_GetSAMIDToStr(int iPort, ref string pcSAMID, int iIfOpen);
        //////////////////////////////////////////////////////////////////////////
        //				身份证卡类函数
        //
        //////////////////////////////////////////////////////////////////////////
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int  Syn_StartFindIDCard(int iPort, ref string pucIIN, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int  Syn_SelectIDCard(int iPort, ref string pucSN, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_ReadBaseMsg(int iPort, ref string pucCHMsg, ref int puiCHMsgLen, ref string pucPHMsg, ref int puiPHMsgLen, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int  Syn_ReadIINSNDN(int iPort, ref string pucIINSNDN, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int  Syn_ReadBaseMsgToFile(int iPort, ref string pcCHMsgFileName, ref int puiCHMsgFileLen, ref string pcPHMsgFileName, ref int puiPHMsgFileLen, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_ReadIINSNDNToASCII(int iPort, ref string pucIINSNDN, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_ReadNewAppMsg(int iPort, ref string pucAppMsg, ref int puiAppMsgLen, int iIfOpen);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_GetBmp(int iPort, ref string Wlt_File);


        [DllImport("SynIDCardAPI.Dll")]
        public static extern int  Syn_ReadMsg(int iPort, int iIfOpen, ref tagidcarddata pIDCardData);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_FindReader();

        [DllImport("SynIDCardAPI.Dll")]
        public static extern  int Syn_ReadMsg_new(int iPort, int iIfOpen, ref tagidcarddata pIDCardData);

        //////////////////////////////////////////////////////////////////////////
        //				设置附加功能函数
        //
        //////////////////////////////////////////////////////////////////////////
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_SetPhotoPath(int iOption, ref string cPhotoPath);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int  Syn_SetPhotoType(int iType);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern  int Syn_SetPhotoName(int iType);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern  int Syn_SetSexType(int iType);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern  int Syn_SetNationType(int iType);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern  int Syn_SetBornType(int iType);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern  int Syn_SetUserLifeBType(int iType);
        [DllImport("SynIDCardAPI.Dll")]
        public static extern int Syn_SetUserLifeEType(int iType, int iOption);
//新中新读卡器END
//////////////////////////////////////////////////////////////////////////
    }
}
