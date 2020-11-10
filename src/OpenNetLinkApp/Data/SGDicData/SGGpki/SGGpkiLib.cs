using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using Serilog;
using Serilog.Events;
using AgLogManager;
using System.Collections.Generic;

namespace OpenNetLinkApp.Data.SGDicData.SGGpki
{ 
    internal class HsGpkiLib
    {
        //public const string strGpkiLibName = "E:\\OpenOS\\SRC\\OpenNetLink\\src\\OpenNetLinkApp\\Library\\gpkiapi64.dll";
        public const string strGpkiLibName = "gpkiapi64.dll";
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GPKI_API_Init(ref IntPtr ppCleintCtx, StringBuilder workDir);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_Finish(ref IntPtr ppCleintCtx);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_GetErrInfo(IntPtr pCleintCtx, int nAllocLen, out StringBuilder sbErrInfo);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_GetVersion(IntPtr pCleintCtx, int nAllocLen, out StringBuilder sbVersion);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_GetInfo(IntPtr pCleintCtx, int nAllocLen, out StringBuilder sbAPIInfo);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_SetOption(IntPtr pCleintCtx, int nOption);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_SetConfFile(IntPtr pCleintCtx, StringBuilder sbConfFilePath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_SetCaPubs(IntPtr pCleintCtx, IntPtr psbBinStrCaPubs);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_FreeCaPubs(IntPtr pCleintCtx);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_Str2Time(IntPtr pCleintCtx, StringBuilder sbTime, out long time);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_API_SetHashAlgo(IntPtr pCleintCtx, int nHashAlg);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_BINSTR_Create(byte[] pbinStr);
        //internal static extern int GPKI_BINSTR_Create(out IntPtr pbinStr);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int GPKI_BINSTR_Delete(out IntPtr pbinStr);
        internal static extern int GPKI_BINSTR_Delete(byte[] pbinStr);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_BINSTR_SetData(byte[] pData, int nDataLen, out IntPtr pbinStr);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_Load(IntPtr pCleintCtx, byte[] pbinStrCert);
        //internal static extern int GPKI_CERT_Load(IntPtr pCleintCtx, IntPtr pbinStrCert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_Unload(IntPtr pCleintCtx);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int GPKI_CERT_GetUID(IntPtr pCleintCtx,int nAllocLen, out StringBuilder sbUID);
        internal static extern int GPKI_CERT_GetUID(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbUID);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetVersion(IntPtr pCleintCtx, out IntPtr pnVerSion);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetSerialNum(IntPtr pCleintCtx, int nAllocLen, out StringBuilder sbSerialNum);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetSignatureAlgorithm(IntPtr pCleintCtx, int nAllocLen, out StringBuilder sbSignAlg);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetIssuerName(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbIssuerName);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetValidity(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbValidity);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetSubjectName(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbSubjectName);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetPubKeyAlg(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbAlg);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetPubKeyLen(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbLen);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetPubKey(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbPubKey);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetSignature(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbSignature);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetKeyUsage(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbKeyUsage);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetBasicConstraints(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbBasicConstraints);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetCertPolicy(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbCertPolicy);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetCertPolicyID(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbCertPolicyID);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetExtKeyUsage(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbExtKeyUsage);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetSubjectAltName(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbSubAltName);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetAuthKeyID(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbAKI);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetSubKeyID(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbSKI);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetCRLDP(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbCRLDP);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetAIA(IntPtr pCleintCtx, int nAllocLen, StringBuilder sbAIA);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetRemainDays(IntPtr pCleintCtx, IntPtr pbinstrCert, out IntPtr pnRemainDays);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_AddCert(IntPtr pCleintCtx, IntPtr pbinstrCert, out IntPtr pbinstrCerts);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetCertCount(IntPtr pCleintCtx, IntPtr pbinstrCert, out IntPtr pnCount);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_GetCert(IntPtr pCleintCtx, IntPtr pbinstrCerts, int nIndex, out IntPtr pbinstrCert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_VerifyByIVS(IntPtr pCleintCtx, StringBuilder sbConfFilePath, IntPtr pbinstrCert, IntPtr pbinstrMyCert );

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_AddTrustedCert(IntPtr pCleintCtx, IntPtr pbinstrTrustedCert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_SetVerifyEnv(IntPtr pCleintCtx, int nRange, int nCertCheck, bool bUseCache, StringBuilder sbTime, StringBuilder sbOCSPURL);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_Verify(IntPtr pCleintCtx, IntPtr pbinstrCert, int nCertType, StringBuilder sbCertPolicies, StringBuilder sbConfFilePath, bool bSign, IntPtr pbinstrMyCert, IntPtr pbinstrMyPriKey);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_CheckStatByOCSP(IntPtr pCleintCtx, IntPtr pbinstrCert, bool bSign, IntPtr pbinstrMyCert, IntPtr pbinstrMyPriKey,StringBuilder sbURL, out IntPtr pbinstrOCSPSvrCert, out Byte[] RevocationDate, IntPtr pnRevReason);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CERT_CheckStatByCRL(IntPtr pCleintCtx, IntPtr pbinstrCert, out Byte[] RevocationDate,IntPtr pnRevReason);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_OCSP_MakeOCSPReq(IntPtr pCleintCtx, IntPtr pbinstrCerts, bool bSign, IntPtr pbinstrMyCert, IntPtr pbinstrMyPriKey, out IntPtr pbinstrReqMsg);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_OCSP_SendAndRecv(IntPtr pCleintCtx, StringBuilder sbURL, StringBuilder sbCert,StringBuilder sbReqMsg, out StringBuilder sbResMsg);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_OCSP_VerifyResMsg(IntPtr pCleintCtx, IntPtr pbinstrReqMsg, IntPtr pbinstrResMsg, out IntPtr pnCertStatCnt, out IntPtr pnOCSPSvrCert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_OCSP_GetCertStatus(IntPtr pCleintCtx, int nIndex, out IntPtr pnStatus, out Byte[] RevocationDate, out IntPtr pnRevReason);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_PRIKEY_Encrypt(IntPtr pCleintCtx, int nSymAlg, StringBuilder sbPasswd, IntPtr pbinstrPriKey, out IntPtr pbinstrEncPriKey);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_PRIKEY_Decrypt(IntPtr pCleintCtx, StringBuilder sbPasswd, IntPtr pbinstrEncPriKey, out IntPtr pbinstrPriKey);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_PRIKEY_ChangePasswd(IntPtr pCleintCtx, StringBuilder sbOldPasswd, StringBuilder sbNewPasswd, IntPtr pbinstrEncPriKey, out IntPtr pbinstrNewPriKey);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_PRIKEY_CheckKeyPair(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_STORAGE_Load(IntPtr pCleintCtx, StringBuilder sbLibPath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_STORAGE_Unload(IntPtr pCleintCtx);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        //internal static extern int GPKI_STORAGE_ReadCert(IntPtr pCleintCtx, int nMediaType, StringBuilder sbInfo, int nDataType, out IntPtr pbinstrCert);
        internal static extern int GPKI_STORAGE_ReadCert(IntPtr pCleintCtx, int nMediaType, StringBuilder sbInfo, int nDataType, byte[] pbinstrCert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_STORAGE_ReadPriKey(IntPtr pCleintCtx, int nMediaType, StringBuilder sbInfo, StringBuilder sbPasswd, int nDataType, out IntPtr pbinstrPriKey);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_STORAGE_WriteCert(IntPtr pCleintCtx, int nMediaType, StringBuilder sbInfo, int nDataType, IntPtr pbinstrCert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_STORAGE_WritePriKey(IntPtr pCleintCtx, int nMediaType, StringBuilder sbInfo, StringBuilder sbPasswd, int nDataType, int nSymAlg, IntPtr pbinstrPriKey);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_STORAGE_DeleteCert(IntPtr pCleintCtx, int nMediaType, StringBuilder sbInfo, int nDataType);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_STORAGE_DeletePriKey(IntPtr pCleintCtx, int nMediaType, StringBuilder sbInfo, StringBuilder sbPasswd, int nDataType);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_STORAGE_ReadFile(IntPtr pCleintCtx, StringBuilder sbFilePath, out IntPtr pbinstrData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_STORAGE_WriteFile(IntPtr pCleintCtx, StringBuilder sbFilePath, IntPtr pbinstrData);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeSignedData(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, IntPtr pbinstrTBSData, StringBuilder sbSignTime, out IntPtr pbinstrSignedData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeSignedData_File(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, StringBuilder sbTBSDataFilePath, StringBuilder sbSignTime, StringBuilder sbSignedDataFilePath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeSignedData_NoContent_File(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, StringBuilder sbTBSDataFilePath, StringBuilder sbSignTime, StringBuilder sbSignedDataFilePath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeSignedDataWithAddSigner(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, IntPtr pbinstrSignedDataIn, StringBuilder sbSignTime, out IntPtr pbinstrSignedDataOut);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_ProcessSignedData(IntPtr pCleintCtx, IntPtr pbinstrSignedData, out IntPtr pbinstrData, out IntPtr pbinstrSignerCert, out Byte[] SignTime);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_ProcessSignedData2(IntPtr pCleintCtx, IntPtr pbinstrSignedData, out IntPtr pbinstrData, IntPtr pnSignerCnt);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_ProcessSignedData_File(IntPtr pCleintCtx, StringBuilder sbSignedDataFilePath, StringBuilder sbDataFile, out IntPtr pbinstrSignerCert, out Byte[] SignTime);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_ProcessSignedData_NoContent_File(IntPtr pCleintCtx, StringBuilder sbSignedDataFilePath, StringBuilder sbDataFile, out IntPtr pbinstrSignerCert, out Byte[] SignTime);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_GetSigner(IntPtr pCleintCtx, int nIndex, out IntPtr pbinstrCert, out Byte[] SignTime);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_GetSignerCaPubs(IntPtr pCleintCtx, out IntPtr pbinstrCaPubs);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_GetTBTData(IntPtr pCleintCtx, int nSignerIndex, out IntPtr pbinstrTBTData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_GetTimeStampToken(IntPtr pCleintCtx, int nSignerIndex, out IntPtr pbinstrTST);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_SetTimeStampToken(IntPtr pCleintCtx, IntPtr pbinstrSignedData, int nSignerIndex, IntPtr pbinstrTST, out IntPtr pbinstrSignedDataWithTST);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeEnvelopedData(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrTBEData, int nSymAlg, out IntPtr pbinstrEnvelopedData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeEnvelopedData_File(IntPtr pCleintCtx, IntPtr pbinstrCert, StringBuilder sbTBEDataFilePath, int nSymAlg, StringBuilder sbEnvelopedDataFilePath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeEnvelopedData_NoContent_File(IntPtr pCleintCtx, IntPtr pbinstrCert, StringBuilder sbTBEDataFilePath, int nSymAlg, StringBuilder sbEnvelopedDataFilePath, StringBuilder sbEncryptedContentFilePath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeEnvelopedDataWithMultiRecipients(IntPtr pCleintCtx, IntPtr pbinstrCerts, IntPtr pbinstrTBEData, int nSymAlg, out IntPtr pbinstrEnvelopedData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_ProcessEnvelopedData(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, IntPtr pbinstrEnvelopedData, out IntPtr pbinstrData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_ProcessEnvelopedData_File(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, StringBuilder sbEnvelopedDataFilePath, out StringBuilder sbDataFilePath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_ProcessEnvelopedData_NoContent_File(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, StringBuilder sbEnvelopedDataFilePath, StringBuilder sbEncryptedConentFilePath, StringBuilder sbDataFilePath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeSignedAndEnvData(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, IntPtr pbinstrRecCert, IntPtr pbinstrData, int nSymAlg, out IntPtr pbinstrSignedAndEnvlopedData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_ProcessSignedAndEnvData(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, IntPtr pbinstrSignedAndEnvlopedData, out IntPtr pbinstrData, out IntPtr pbinstrSignerCert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_MakeEncryptedData(IntPtr pCleintCtx, IntPtr pbinstrTBEData, out IntPtr pbinstrEncryptedData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CMS_ProcessEncryptedData(IntPtr pCleintCtx, IntPtr pbinstrKey, IntPtr pbinstrEncryptedData, out IntPtr pbinstrData);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_WCMS_MakeSignedContent(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, IntPtr pbinstrTBSData, StringBuilder sbSignTime, out IntPtr pbinstrSignedContent);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_WCMS_ProcessSignedContent(IntPtr pCleintCtx, IntPtr pbinstrSignedContent, out IntPtr pbinstrData, out IntPtr pbinstrSignerCert, out Byte[] SignTime);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_WCMS_MakeWapEnvelopedData(IntPtr pCleintCtx, IntPtr pbinstrRecCert, IntPtr pbinstrTBEData, int nSymAlg, out IntPtr pbinstrWapEnvelopedData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_WCMS_ProcessWapEnvelopedData(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, IntPtr pbinstrWapEnvelopedData, out IntPtr pbinstrData);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_TSP_MakeReqMsg(IntPtr pCleintCtx, IntPtr pbinstrMsg, int nHashAlg, StringBuilder sbPolicy, bool bSign, IntPtr pbinstrCert, IntPtr pbinstrPriKey, out IntPtr pbinstrReqMsg);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_TSP_SendAndRecv(IntPtr pCleintCtx, StringBuilder sbIP, int nPort, IntPtr pbinstrReqMsg,out IntPtr pbinstrResMsg);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_TSP_VerifyResMsg(IntPtr pCleintCtx, IntPtr pbinstrResMsg, out IntPtr pbinstrTSACert, out IntPtr pbinstrToken);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_TSP_VerifyToken(IntPtr pCleintCtx, IntPtr pbinstrDoc, IntPtr pbinstrToken);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_TSP_VerifyToken2(IntPtr pCleintCtx, IntPtr pbinstrDoc, IntPtr pbinstrToken,out IntPtr pbinstrTSACert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_TSP_GetTokenInfo(IntPtr pCleintCtx, IntPtr pbinstrToken, int nAllocLen, out StringBuilder sbCN, out StringBuilder sbDN, out StringBuilder sbPolicy, out StringBuilder sbHashAlg, out StringBuilder sbHashValue, out StringBuilder sbSerialNum, out StringBuilder sbGenTime, out StringBuilder sbNonce);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_VID_GetRandomFromPriKey(IntPtr pCleintCtx, IntPtr pbinstrPriKey, out IntPtr pbinstrRandom);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_VID_Verify(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrRandom, StringBuilder sbIDN);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_VID_VerifyByIVS(IntPtr pCleintCtx, StringBuilder sbConfFilePath, IntPtr pbinstrCert, IntPtr pbinstrRandom, StringBuilder sbIDN, IntPtr pbinstrMyCert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_PFX_Export(IntPtr pCleintCtx, StringBuilder sbPasswd, IntPtr pbinstrSignCert, IntPtr pbinstrSignPriKey, IntPtr pbinstrKmCert, IntPtr pbinstrKmPriKey, out IntPtr pbinstrPFX);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_PFX_Import(IntPtr pCleintCtx, StringBuilder sbPasswd, IntPtr pbinstrPFX, out IntPtr pbinstrSignCert, out IntPtr pbinstrSignPriKey, out IntPtr pbinstrKmCert, out IntPtr pbinstrKmPriKey);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_GenRandom(IntPtr pCleintCtx, int nLen, out IntPtr pbinstrRandom);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_GenKeyAndIV(IntPtr pCleintCtx, int nSymAlg);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_SetKeyAndIV(IntPtr pCleintCtx, int nSymAlg, IntPtr pbinstrKey, IntPtr pbinstrIV);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_GetKeyAndIV(IntPtr pCleintCtx, out IntPtr pnSymAlg, out IntPtr pbinstrKey, out IntPtr pbinstrIV);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_ClearKeyAndIV(IntPtr pCleintCtx);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_Encrypt(IntPtr pCleintCtx, IntPtr pbinstrPlainText, out IntPtr pbinstrCipherText);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_Encrypt_File(IntPtr pCleintCtx, StringBuilder sbPlainTextFile, StringBuilder sbCipherTextFile);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_Decrypt(IntPtr pCleintCtx, IntPtr pbinstrCipherText, out IntPtr pbinstrPlainText);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_Decrypt_File(IntPtr pCleintCtx, StringBuilder sbCipherTextFile, StringBuilder sbPlainTextFile);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_Sign(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, int nHashAlg, IntPtr pbinstrTBSData, out IntPtr pbinstrSignature);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_Sign_File(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey, int nHashAlg, StringBuilder sbDataFilePath, StringBuilder sbSignatuoutilePath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_Verify(IntPtr pCleintCtx, IntPtr pbinstrCert, int nHashAlg, IntPtr pbinstrData, IntPtr pbinstrSignature);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_Verify_File(IntPtr pCleintCtx, IntPtr pbinstrCert, int nHashAlg, StringBuilder sbDataFilePath, StringBuilder sbSignatuoutilePath);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_AsymEncrypt(IntPtr pCleintCtx, int nKeyType, IntPtr pbinstrKey, IntPtr pbinstrTBEData, out IntPtr pbinstrEncData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_AsymDecrypt(IntPtr pCleintCtx, int nKeyType, IntPtr pbinstrKey, IntPtr pbinstrEncData, out IntPtr pbinstrData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_Hash(IntPtr pCleintCtx, int nHashAlg, IntPtr pbinstrTBHData, out IntPtr pbinstrDigest);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_GenMAC(IntPtr pCleintCtx, int nMACAlg, StringBuilder sbPasswd, IntPtr pbinstrTBMData, out IntPtr pbinstrMAC);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_CRYPT_VerifyMAC(IntPtr pCleintCtx, int nMACAlg, StringBuilder sbPasswd, IntPtr pbinstrData, IntPtr pbinstrMAC);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_GetSlotList(IntPtr pCleintCtx, uint[] pSlotList, out IntPtr puintSlotCnt);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_GetTokenInfo(IntPtr pCleintCtx, uint ulSlotID, out IntPtr p_PKCS11_TOKEN_INFO_TokenInfo);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_OpenSession(IntPtr pCleintCtx, uint ulSlotID, int nTokenName);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_Login(IntPtr pCleintCtx, StringBuilder sbPIN);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_Logout(IntPtr pCleintCtx);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_CloseSession(IntPtr pCleintCtx);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_ChangePIN(IntPtr pCleintCtx, StringBuilder sbOldPIN, StringBuilder sbNewPIN);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_GetCertCnt(IntPtr pCleintCtx, out IntPtr pnCnt);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_GetCertInfo(IntPtr pCleintCtx, int nIndex, out IntPtr pnCertType,out IntPtr pbinstrCertDN, out IntPtr pbinstrKeyID);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_ReadCert(IntPtr pCleintCtx, IntPtr pbinstrKeyID, out IntPtr pbinstrCert);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_ReadRandomForVID(IntPtr pCleintCtx, IntPtr pbinstrKeyID, out IntPtr pbinstrRandom);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_WriteCertAndPriKey(IntPtr pCleintCtx, IntPtr pbinstrCert, IntPtr pbinstrPriKey);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_DeleteCertAndPriKey(IntPtr pCleintCtx, IntPtr pbinstrKeyID);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_HSM_SignData(IntPtr pCleintCtx, IntPtr pbinstrKeyID, IntPtr pbinstrData, out IntPtr pbinstrSignedData);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_BASE64_Encode(IntPtr pCleintCtx, IntPtr pbinstrData, out IntPtr pbinstrEncData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_BASE64_Decode(IntPtr pCleintCtx, IntPtr pbinstrEncData, out IntPtr pbinstrData);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_LDAP_GetDataByURL(IntPtr pCleintCtx, int nDataType, StringBuilder sbURL, out IntPtr pbinstrData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_LDAP_GetDataByCN(IntPtr pCleintCtx, StringBuilder sbIP, int nPort, StringBuilder sbCN, int nDataType, out Byte[] FullDN, out IntPtr pbinstrData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_LDAP_GetAnyDataByURL(IntPtr pCleintCtx, StringBuilder sbAttribute, StringBuilder sbURL, out IntPtr pbinstrData);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_LDAP_GetCRLByCert(IntPtr pCleintCtx, IntPtr pbinstrCert, out IntPtr pbinstrCRL);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_LDAP_GetCertPath(IntPtr pCleintCtx, IntPtr pbinstrCert, StringBuilder sbConfFilePath, out IntPtr pbinstrPath);

        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_SIGEA_MakeChallenge(IntPtr pCleintCtx, out IntPtr pbinstrChallenge);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_SIGEA_MakeResponse(IntPtr pCleintCtx, IntPtr pbinstrChallenge, IntPtr pbinstrCert, IntPtr pbinstrPriKey, out IntPtr pbinstrResponse);
        [DllImport(strGpkiLibName, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        internal static extern int GPKI_SIGEA_VerifyResponse(IntPtr pCleintCtx, IntPtr pbinstrResponse, IntPtr pbinstrChallenge, IntPtr pbinstrCert);

    }

    public class GPKICA
    {
        Dictionary<string, string> DicGpkiCA = new Dictionary<string, string>();
        public void SetData(string tag, string value)
        {
            string strTmp = "";
            if (DicGpkiCA.TryGetValue(tag, out strTmp) == true)
            {
                DicGpkiCA.Remove(tag);
            }
            DicGpkiCA[tag] = value;
        }
        public string GetData(string tag)
        {
            string strTmp = "";
            if (DicGpkiCA.TryGetValue(tag, out strTmp) != true)
            {
                return strTmp;
            }
            return DicGpkiCA[tag];
        }
    }
    public class GPKIFileInfo
    {
        public string m_strFileName;            // GPKI 인증서 파일명
        public string m_strUserID;              // GPKI 인증서 ID
        public string m_strExpiredDate;         // GPKI 인증서 만료일자
        public string m_strKeyUse;              // GPKI 인증서 사용 용도.
        public string m_strOrg;                 // GPKI 인증서 발급기관.
        //public GPKICA m_gpkiCA;                 // GPKI 인증서 발급기관 상세정보.
        //public string m_strOID;                   // GPKI 인증서 OID
        public int m_nRemainDay;                  // GPKI 인증서 남은 유효 기간
        public GPKIFileInfo()
        {
            m_strFileName = m_strUserID = m_strKeyUse = m_strOrg = "";
            m_nRemainDay = 0;
            //m_strOID = "";
            //m_gpkiCA = new GPKICA();
        }
        public void SetGPKIInfo(string userID, string expiredDate, string KeyUse, string Org)
        {
            m_strUserID = userID;               // GPKI 인증서 사용자 계정.
            m_strExpiredDate = expiredDate;     // GPKI 인증서 만료일자
            m_strKeyUse = KeyUse;               // GPKI 인증서 사용 용도.
            m_strOrg = Org;                     // GPKI 인증서 발급 기관.
        }
    }
    public class SGGpkiLib
    {
        public List<GPKIFileInfo> listGpkiFile = new List<GPKIFileInfo>();
        public string m_strWorkDir = "GPKI";
        private IntPtr m_pClientCtx = IntPtr.Zero;
        private string m_strBaseGPKIPath = "GPKI/certificate/Class2";

        private Dictionary<string, string> DicGpkiIsser = new Dictionary<string, string>();
        private Dictionary<string, string> DicGpkiOid = new Dictionary<string, string>();

        public SGGpkiLib()
        {
            GPKIUsageInit();
            GPKIOidInit();
        }
        ~SGGpkiLib()
        {
            GPKI_Finish();
        }
        public void GPKIUsageInit()
        {
            DicGpkiOid["1.2.410.100001.2.2.1"] = "행정기관(개인용)";
            DicGpkiOid["1.2.410.100001.2.1.1"] = "행정기관(전자관인용)";
            DicGpkiOid["1.2.410.100001.2.1.2"] = "행정기관(서버용)";
            DicGpkiOid["1.2.410.100001.2.1.3"] = "행정기관(특수목적용)";

            DicGpkiOid["1.2.410.100001.2.2.2"] = "공공기관(개인용)";
            DicGpkiOid["1.2.410.100001.2.1.4"] = "공공기관(전자관인용)";
            DicGpkiOid["1.2.410.100001.2.1.5"] = "공공기관(서버용)";
            DicGpkiOid["1.2.410.100001.2.1.6"] = "공공기관(특수목적용)";
        }
        public string GetConvGpkiOID(string strOID)
        {
            strOID = strOID.Replace(" ", ".");
            string strTmp = "";
            if(DicGpkiOid.TryGetValue(strOID, out strTmp)!=true)
            {
                return "공무원용";
            }
            return DicGpkiOid[strOID];
        }
        public void GPKIOidInit()
        {
            DicGpkiIsser["CertRSA01"] = "한국정보보호진흥원(KISA";
            DicGpkiIsser["KISA RootCA 1"] = "한국정보보호진흥원(KISA";
            DicGpkiIsser["KISA RootCA 4"] = "한국정보보호진흥원(KISA";
            DicGpkiIsser["yessignCA"] = "금융결제원";
            DicGpkiIsser["NCASign CA"] = "한국전산원";
            DicGpkiIsser["NCASignCA"] = "한국전산원";
            DicGpkiIsser["SignKorea CA"] = "KOSCOM";
            DicGpkiIsser["signGATE CA"] = "정보인증";
            DicGpkiIsser["signGATE CA2"] = "정보인증";
            DicGpkiIsser["signGATE FTCA02"] = "정보인증";
            DicGpkiIsser["CrossCertCA"] = "전자인증";
            DicGpkiIsser["CrossCert Certificate Authority"] = "전자인증";
            DicGpkiIsser["TradeSignCA"] = "한국무역정보통신";
            DicGpkiIsser["CA131000002"] = "행정안전부";
            DicGpkiIsser["CA128000002"] = "대검찰청";
            DicGpkiIsser["CA130000002"] = "병무청";
            DicGpkiIsser["CA129000001"] = "국방부";
            DicGpkiIsser["CA131000001"] = "행정안전부";
            DicGpkiIsser["CA131000005"] = "행정안전부";
            DicGpkiIsser["CA131000009"] = "행정안전부";
            DicGpkiIsser["CA131000010"] = "행정안전부";
            DicGpkiIsser["CA134040001"] = "교육과학기술부";
            DicGpkiIsser["CA974000001"] = "대법원";
            DicGpkiIsser["CA134100031"] = "교과부";
            DicGpkiIsser["CA134040031T"] = "교과부";
            DicGpkiIsser["SignKorea CA2"] = "KOSCOM";
            DicGpkiIsser["yessignCA Class 1"] = "금융결제원";
            DicGpkiIsser["CrossCertCA2"] = "전자인증";
            DicGpkiIsser["signGATE CA4"] = "정보인증";
            DicGpkiIsser["TradeSignCA2"] = "한국무역정보통신";
            DicGpkiIsser["GPKIRootCA1 "] = "행정안전부";
            DicGpkiIsser["GPKIRootCA"] = "행정안전부";
            DicGpkiIsser["Root CA"] = "행정안전부";
            DicGpkiIsser["Class 3 CA"] = "행정안전부";
            DicGpkiIsser["CA131000001"] = "행정안전부";
            DicGpkiIsser["CA131100001"] = "행정안전부";
            DicGpkiIsser["CA131000002"] = "행정안전부";
            DicGpkiIsser["CA128000001"] = "행정안전부";
            DicGpkiIsser["CA128000002"] = "행정안전부";
            DicGpkiIsser["CA128000002"] = "행정안전부";
            DicGpkiIsser["LGCare Online CA"] = "전자인증";
            DicGpkiIsser["MND CA"] = "국방부";
            DicGpkiIsser["CA131100002"] = "행정안전부";
            DicGpkiIsser["CA974000002"] = "대법원";
            DicGpkiIsser["CA974000031"] = "대법원";
            DicGpkiIsser["CA128000031"] = "대검찰청";
            DicGpkiIsser["CA128000032"] = "대검찰청";
            DicGpkiIsser["CA130000031"] = "병무청";
        }
        public string GetConvGpkiIsser(string strIsser)
        {
            if ( (!strIsser.Contains("CN=")) && (!strIsser.Contains("cn=")) )
                return "-";

            string[] strSubIsser = null;
            strSubIsser=strIsser.Split(",");
            if ((strSubIsser == null) || (strSubIsser.Length <= 0))
                return "-";

            string strCN = strSubIsser[0].Substring(2, strSubIsser[0].Length-2);
            strCN = strCN.Trim();

            string strTmp = "";
            if (DicGpkiIsser.TryGetValue(strCN, out strTmp) != true)
            {
                return "행정안전부";
            }
            return DicGpkiIsser[strCN];
        }
        public bool GPKI_Init()
        {
            int ret = -1;
            m_strWorkDir = Path.Combine(System.IO.Directory.GetCurrentDirectory(), m_strWorkDir);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                m_strWorkDir = m_strWorkDir.Replace("/", "\\");
            }
            else
            {
                m_strWorkDir = m_strWorkDir.Replace("\\", "/");
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(m_strWorkDir);
            ret = HsGpkiLib.GPKI_API_Init(ref m_pClientCtx, sb);
            if ((ret != 0) && (m_pClientCtx != IntPtr.Zero))
            {
                Log.Error($"GPKI_API_Init error!!");
                Log.Error(String.Format("GPKI_API_Init error!!"));
                return false;
            }
            return true;
        }
        public void GPKI_Finish()
        {
            if (m_pClientCtx != IntPtr.Zero)
                HsGpkiLib.GPKI_API_Finish(ref m_pClientCtx);
        }
        /**
        *@breif BINSTR 객체 생성 여부를 확인한다.
        *@param ref BINSTR
        *@param out byte[]
        *@return true 성공
        */
        public bool GPKIBinStrCreate(ref BINSTR binstr, out byte[] byteBinStr)
        {
            if (m_pClientCtx == IntPtr.Zero)
            {
                byteBinStr = null;
                return false;
            }

            IntPtr bytePtr = IntPtr.Zero;
            byte[] bData = StructToBytes(binstr);
            int nRet = HsGpkiLib.GPKI_BINSTR_Create(bData);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                Log.Error($"GPKI_BINSTR_Create Error");
                byteBinStr = null;
                return false;
            }
            byteBinStr = bData;
            return true;
        }

        /**
       *@breif BINSTR 객체 해제 여부를 확인한다.
       *@param BINSTR
       *@return true 성공
       */
        public int GPKIBinStrDelete(ref BINSTR binstr)
        {
            if (m_pClientCtx == IntPtr.Zero)
            {
                return -1;
            }
            IntPtr bytePtr = IntPtr.Zero;
            byte[] bData = StructToBytes(binstr);
            return HsGpkiLib.GPKI_BINSTR_Delete(bData);
        }
        /**
        *@breif GPKI 동작관련 에러 메시지를 반환한다. 
        *@param eGpkiError 에러코드
        *@return 에러메시지
        */
        public string GetGpkiError(eGpkiError err)
        {
            if (m_pClientCtx == IntPtr.Zero)
                return "";

            StringBuilder sb = new StringBuilder(128);
            int nRet = HsGpkiLib.GPKI_API_GetErrInfo(m_pClientCtx, 128, out sb);
            if (nRet == (int)eGpkiError.GPKI_OK)
            {
                Log.Error($"Gpki Error Code = {err.ToString()}");
                Log.Error($"Gpki Error Msg = {sb.ToString()}");
                return "";
            }
            return sb.ToString();
        }
        /**
        *@breif 정보를 확인할 인증서를 로드한다. 
        *@param bsCert
        *@return true 성공
        */
        public bool GpkiLoad(byte[] binStr)
        {
            if (m_pClientCtx == IntPtr.Zero)
                return false;

            if (!GpkiUnLoad())
            {
                //HsLog.err(String.Format("GpkiLoad Unload Error!"));
                return false;
            }
            int nRet = HsGpkiLib.GPKI_CERT_Load(m_pClientCtx, binStr);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GpkiLoad ErrMsg = {strErrMsg}");
                return false;
            }
            return true;
        }
        /**
        *@breif 로드된 인증서를 Unload 한다. 
        *@return true 성공
        */
        public bool GpkiUnLoad()
        {
            if (m_pClientCtx == IntPtr.Zero)
                return false;

            int nRet = HsGpkiLib.GPKI_CERT_Unload(m_pClientCtx);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GpkiUnLoad ErrMsg = {strErrMsg}");
                return false;
            }
            return true;
        }
        /**
        *@breif 해당 인증서의 사용자 계정을 반환한다.
        *@return 사용자 계정
        */
        public string GetGpkiUserID()
        {
            if (m_pClientCtx == IntPtr.Zero)
                return "";

            StringBuilder sb = new StringBuilder(128);
            int nRet = HsGpkiLib.GPKI_CERT_GetUID(m_pClientCtx, 128, sb);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GetGpkiUserID ErrMsg = {strErrMsg}");
                return "";
            }
            return sb.ToString();
        }
        /**
        *@breif 인증서의 유효기간을 반환한다.
        *@return 인증서 유효기간
        */
        public string GetGpkiValidate()
        {
            if (m_pClientCtx == IntPtr.Zero)
                return "";

            StringBuilder sb = new StringBuilder(128);
            int nRet = HsGpkiLib.GPKI_CERT_GetValidity(m_pClientCtx, 128, sb);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GetGpkiValidate ErrMsg = {strErrMsg}");
                return "";
            }

            string strDate = sb.ToString();
            string[] strSubDate = strDate.Split("~");
            if ( (strSubDate == null) || (strSubDate.Length <= 1) )
                return "";
            strDate = strSubDate[1];
            strDate = strDate.Trim();
            DateTime time = Convert.ToDateTime(strDate);
            return time.ToString("yyyy-MM-dd");
        }
        /**
        *@breif 인증서의 용도를 반환한다.
        *@return 인증서 용도
        */
        public string GetGpkiKeyUseCase()
        {
            if (m_pClientCtx == IntPtr.Zero)
                return "";

            StringBuilder sb = new StringBuilder(128);
            int nRet = HsGpkiLib.GPKI_CERT_GetKeyUsage(m_pClientCtx, 128, sb);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GetGpkiKeyUseCase ErrMsg = {strErrMsg}");
                return "";
            }
            return sb.ToString();
        }
        /**
        *@breif 해당 인증서의 남은 날짜를 반환한다.
        *@param bsCert
        *@return 해당 인증서의 남은 날짜
        */
        public int GetRemainDays(ref BINSTR bsCert)
        {
            if (m_pClientCtx == IntPtr.Zero)
                return -1;
            IntPtr pbsCert = IntPtr.Zero;
            Marshal.StructureToPtr(bsCert, pbsCert, true);
            if (pbsCert == IntPtr.Zero)
            {
                Log.Error($"GetRemainDays BINSTR to IntPtr Error!");
                return -1;
            }
            IntPtr ptrRemainDay = new IntPtr(0);
            int nRet = HsGpkiLib.GPKI_CERT_GetRemainDays(m_pClientCtx, pbsCert, out ptrRemainDay);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GetRemainDays ErrMsg = {strErrMsg}");
                return -1;
            }

            return ptrRemainDay.ToInt32();
        }
        /**
        *@breif 인증서 정책 식별자의 OID 값을 반환한다.
        *@return 인증서 정책 식별자의 OID 값
        */
        public string GetGPKIOID()
        {
            if (m_pClientCtx == IntPtr.Zero)
                return "-";

            StringBuilder sb = new StringBuilder(128);
            int nRet = HsGpkiLib.GPKI_CERT_GetCertPolicyID(m_pClientCtx, 128,sb);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GetGPKIOID ErrMsg = {strErrMsg}");
                return "-";
            }

            string strGPKIOID = GetConvGpkiOID(sb.ToString());
            return strGPKIOID;
        }

        /**
        *@breif 발급자 이름을 반환한다.
        *@return 발급자 이름
        */
        public string GetGPKIIssuerName()
        {
            if (m_pClientCtx == IntPtr.Zero)
                return "-";

            StringBuilder sb = new StringBuilder(128);
            int nRet = HsGpkiLib.GPKI_CERT_GetIssuerName(m_pClientCtx, 128, sb);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GetGPKIIssuerName ErrMsg = {strErrMsg}");
                return "-";
            }

            string strIsserName = GetConvGpkiIsser(sb.ToString());
            return strIsserName;
        }
        /**
        *@breif 랜덤값을 생성한다.
        *@param 생성된 랜덤값 버퍼
        *@return 랜덤값 길이
        */
        public int GetGenRandom(ref Byte[] randomKey)
        {
            if (m_pClientCtx == IntPtr.Zero)
                return -1;

            IntPtr ptrRandom = IntPtr.Zero;
            int nRet = HsGpkiLib.GPKI_BINSTR_Create(randomKey);
            //int nRet = HsGpkiLib.GPKI_BINSTR_Create(out ptrRandom);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GetGenRandom GPKI_BINSTR_Create ErrMsg = {strErrMsg}");
                return -1;
            }

            nRet = HsGpkiLib.GPKI_CRYPT_GenRandom(m_pClientCtx, 20, out ptrRandom);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GetGenRandom GPKI_CRYPT_GenRandom ErrMsg = {strErrMsg}");
                return -1;
            }

            BINSTR binStr = new BINSTR();
            Marshal.PtrToStructure(ptrRandom, binStr);
           // if (binStr == null)
          //  {
           //     Log.Error($"GetGenRandom IntPtr to BINSTR Error!");
          //      return -1;
           // }
            int nRetLen = binStr.nLen;
            if (nRetLen != 20)
            {
                Log.Error($"GetGenRandom binStr.nLen Error!");
                return -1;
            }
            else
                Buffer.BlockCopy(randomKey, 0, binStr.pData, 0, nRetLen);

            Marshal.StructureToPtr(binStr, ptrRandom, true);
            if (ptrRandom == IntPtr.Zero)
            {
                Log.Error($"GetGenRandom BINSTR to IntPtr Error!");
                return -1;
            }

            //HsGpkiLib.GPKI_BINSTR_Delete(out ptrRandom);
            return nRetLen;
        }
        /**
        *@breif GPKI 인증서 정보를 저장매체에서 읽어온다.
        *@param strGPKIFullPath GPKI 파일 Full Path
        *@param bsCert
        *@return IntPtr
        */
        public byte[] GetGPKIReadCert(string strGPKIFullPath, byte[] ptrCert)
        {
            if (m_pClientCtx == IntPtr.Zero)
                return null;

            StringBuilder sbGPKIFullPath = new StringBuilder(strGPKIFullPath);
            if (ptrCert == null)
            {
                Log.Error($"GetGPKIReadCert BINSTR to IntPtr Convert Error!");
                return null;
            }
            int nRet = HsGpkiLib.GPKI_STORAGE_ReadCert(m_pClientCtx, (int)eGpkiMediaType.MEDIA_TYPE_FILE_PATH, sbGPKIFullPath, (int)eGpkiDataType.DATA_TYPE_GPKI_SIGN, ptrCert);
            if (nRet != (int)eGpkiError.GPKI_OK)
            {
                string strErrMsg = GetGpkiError((eGpkiError)nRet);
                Log.Error($"GetGPKIReadCert ErrMsg = {strErrMsg}");
                return null;
            }
            return ptrCert;
        }

        /**
        *@breif 특정경로의 GPKI 파일리스트를 가져온다.
        *@param GPKI 파일 경로.
        *@return GPKI 파일 리스트
        */
        public string[] FindGPKIFile(string strGPKIPath)
        {
            DirectoryInfo di = new DirectoryInfo(strGPKIPath);
            if(!di.Exists)
            {
                Log.Information($"GPKI Directory Not Found = {strGPKIPath}");
                return null;
            }
            string[] strFileList = null;
            strFileList = Directory.GetFiles(strGPKIPath);
            if ((strFileList.Length <= 0) || (strFileList == null))
                return null;

            int nFileListLength = 0;
            for (int i = 0; i < strFileList.Length; i++)
            {
                string strFileName = Path.GetFileName(strFileList[i]);
                if (strFileName.Contains("_sig"))
                    nFileListLength++;
            }

            if (nFileListLength <= 0)
                return null;

            string[] strRetFileList = null;
            strRetFileList = new string[nFileListLength];
            int idx = 0;
            for (int i = 0; i < strFileList.Length; i++)
            {
                if (idx > nFileListLength)
                    break;
                string strFileName = Path.GetFileName(strFileList[i]);
                if (strFileName.Contains("_sig"))
                    strRetFileList[idx++] = strFileList[i];
            }

            return strRetFileList;
        }
        /**
        *@breif 기본 하드디스크의 GPKI 파일들을 로드한다..
        *@return true 성공
        */
        public bool LoadHardDiskGPKICertFile()
        {
            string strGPKIFullPath = m_strBaseGPKIPath;
            string strDriveName = "C:\\";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                strGPKIFullPath = Path.Combine(strDriveName, strGPKIFullPath);
                strGPKIFullPath = strGPKIFullPath.Replace("/", "\\");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                string strFullHomePath = Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
                strGPKIFullPath = Path.Combine(strFullHomePath, strGPKIFullPath);
                strGPKIFullPath = strGPKIFullPath.Replace("\\", "/");
            }

            Log.Information($"GPKI Path = {strGPKIFullPath}");
            string[] arrGpkiFile = FindGPKIFile(strGPKIFullPath);
            if ((arrGpkiFile == null) || (arrGpkiFile.Length <= 0))
            {
                Log.Information($"GPKI File Empty!!");
                listGpkiFile.Clear();
                return false;
            }

            listGpkiFile.Clear();

            for (int i = 0; i < arrGpkiFile.Length; i++)
            {
                string strFilename = Path.GetFileName(arrGpkiFile[i]);
                string strFileExt = Path.GetExtension(arrGpkiFile[i]);
                if (!strFileExt.Equals(".cer"))
                {
                    continue;
                }
                if (!GetGPKIFileExam(arrGpkiFile[i]))
                {
                    Log.Information($"{strFilename} is KEY File Not Exist!");
                    continue;
                }

                
                IntPtr ptrBinstr = IntPtr.Zero;
                BINSTR binStr = new BINSTR();
                byte[] byteBinStr;
                bool bRet = GPKIBinStrCreate(ref binStr,out byteBinStr);
                //int nRet = HsGpkiLib.GPKI_BINSTR_Create(ref binStr);
                if (!bRet)
                {
                    Log.Error($"{strFilename} is GPKI_BINSTR_Create fail!!");
                    continue;
                }
                GetGPKIReadCert(arrGpkiFile[i], byteBinStr);
                if (byteBinStr == null)
                {
                    Log.Error($"{strFilename} is read Fail");
                    continue;
                }

                if (!GpkiLoad(byteBinStr))
                {
                    Log.Error($"{strFilename} is Load Fail");
                    continue;
                }

                GPKIFileInfo gpkiFileInfo = null;
                gpkiFileInfo = new GPKIFileInfo();
                gpkiFileInfo.m_strFileName = arrGpkiFile[i];
                string strUserID = GetGpkiUserID();
                string strExpiredDate = GetGpkiValidate();
                string strKeyUse = GetGPKIOID();
                string strOrg = GetGPKIIssuerName();
                gpkiFileInfo.SetGPKIInfo(strUserID, strExpiredDate, strKeyUse, strOrg);
                listGpkiFile.Add(gpkiFileInfo);
            }
            return true;
        }

        /**
        *@breif 이동식 디스크의 GPKI 파일들을 로드한다.
        *@param strDriveName 이동식 디스크의 드라이브명
        *@return true 성공
        */
        public bool LoadMoveDiskGPKICertFile(string strDriveName)
        {
            
            string strGPKIFullPath = m_strBaseGPKIPath;
            strGPKIFullPath = Path.Combine(strDriveName, strGPKIFullPath);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                strGPKIFullPath = strGPKIFullPath.Replace("/", "\\");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                strGPKIFullPath = strGPKIFullPath.Replace("\\", "/");
            }

            Log.Information($"GPKI Path = {strGPKIFullPath}");
            string[] arrGpkiFile = FindGPKIFile(strGPKIFullPath);
            if ((arrGpkiFile == null) || (arrGpkiFile.Length <= 0))
            {
                Log.Information($"GPKI File Empty!!");
                listGpkiFile.Clear();
                return false;
            }

            listGpkiFile.Clear();

            for (int i = 0; i < arrGpkiFile.Length; i++)
            {
                string strFilename = Path.GetFileName(arrGpkiFile[i]);
                string strFileExt = Path.GetExtension(arrGpkiFile[i]);
                if (!strFileExt.Equals(".cer"))
                {
                    continue;
                }
                if (!GetGPKIFileExam(arrGpkiFile[i]))
                {
                    Log.Information($"{strFilename} is KEY File Not Exist!");
                    continue;
                }


                IntPtr ptrBinstr = IntPtr.Zero;
                BINSTR binStr = new BINSTR();
                byte[] byteBinStr;
                bool bRet = GPKIBinStrCreate(ref binStr, out byteBinStr);
                //int nRet = HsGpkiLib.GPKI_BINSTR_Create(ref binStr);
                if (!bRet)
                {
                    Log.Error($"{strFilename} is GPKI_BINSTR_Create fail!!");
                    continue;
                }
                GetGPKIReadCert(arrGpkiFile[i], byteBinStr);
                if (byteBinStr == null)
                {
                    Log.Error($"{strFilename} is read Fail");
                    continue;
                }

                if (!GpkiLoad(byteBinStr))
                {
                    Log.Error($"{strFilename} is Load Fail");
                    continue;
                }

                GPKIFileInfo gpkiFileInfo = null;
                gpkiFileInfo = new GPKIFileInfo();
                gpkiFileInfo.m_strFileName = arrGpkiFile[i];
                string strUserID = GetGpkiUserID();
                string strExpiredDate = GetGpkiValidate();
                string strKeyUse = GetGPKIOID();
                string strOrg = GetGPKIIssuerName();
                gpkiFileInfo.SetGPKIInfo(strUserID, strExpiredDate, strKeyUse, strOrg);
                listGpkiFile.Add(gpkiFileInfo);
            }

            return true;
        }
        /**
        *@breif GPKI 파일이 cer,key 쌍으로 존재하는지 여부를 확인한다.
        *@param strGPKIFileName GPKI 파일명
        *@return true 성공
        */
        public bool GetGPKIFileExam(string strGPKIFileFullName)
        {
            bool bCerFind = false;
            bool bKeyFind = false;
            string strFileName = Path.GetFileNameWithoutExtension(strGPKIFileFullName);
            string strFilePath = Path.GetDirectoryName(strGPKIFileFullName);

            string strFileCerName = strFileName + ".cer";
            strFileCerName = Path.Combine(strFilePath, strFileCerName);
            string strFileKeyName = strFileName + ".key";
            strFileKeyName = Path.Combine(strFilePath, strFileKeyName);
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                strFileCerName = strFileCerName.Replace("/", "\\");
                strFileKeyName = strFileKeyName.Replace("/", "\\");
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                strFileCerName = strFileCerName.Replace("\\", "/");
                strFileKeyName = strFileKeyName.Replace("\\", "/");
            }
            bCerFind = File.Exists(strFileCerName);
            bKeyFind = File.Exists(strFileKeyName);
            return (bCerFind & bKeyFind);
        }
        public List<GPKIFileInfo> GetGpkiFileList()
        {
            return listGpkiFile;
        }

        public byte[] StructToBytes(object obj)
        { 
            //구조체 사이즈 
            int iSize = Marshal.SizeOf(obj); 
            
            //사이즈 만큼 메모리 할당 받기 
            byte[] arr = new byte[iSize]; 
            IntPtr ptr = Marshal.AllocHGlobal(iSize); 

            //구조체 주소값 가져오기 
            Marshal.StructureToPtr(obj, ptr, false); 
            //메모리 복사 
            Marshal.Copy(ptr, arr, 0, iSize); 
            Marshal.FreeHGlobal(ptr); 
            return arr; 
        }
    }
}