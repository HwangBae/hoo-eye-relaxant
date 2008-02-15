using System;
using System.Runtime.InteropServices;

namespace Hush.InputDevice {
    #region ί�ж���

    /// <summary>
    /// ����ί������
    /// </summary>
    /// <param name="nCode"></param>
    /// <param name="wParam"></param>
    /// <param name="lParam"></param>
    /// <returns></returns>
    public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);

    /// <summary>
    /// �������¼�ί������
    /// </summary>
    /// <param name="x">x����</param>
    /// <param name="y">y����</param>
    public delegate void MouseUpdateEventHandler(int x, int y);

    /// <summary>
    /// �޷���ί������
    /// </summary>
    public delegate void VoidCallback();

    #endregion ί�ж���

    #region ö�ٶ���

    public enum HookTypeID : int {

        WH_KEYBOARD = 2,
        WH_MOUSE = 7,

        /// <summary>
        /// �ײ���̹���
        /// </summary>
        WH_KEYBOARD_LL = 13,


        /// <summary>
        /// �ײ���깳��
        /// </summary>
        WH_MOUSE_LL = 14
    }

    public enum WM_MOUSE : int {
        /// <summary>
        /// ��꿪ʼ
        /// </summary>
        WM_MOUSEFIRST = 0x200,

        /// <summary>
        /// ����ƶ�
        /// </summary>
        WM_MOUSEMOVE = 0x200,

        /// <summary>
        /// �������
        /// </summary>
        WM_LBUTTONDOWN = 0x201,

        /// <summary>
        /// ����ͷ�
        /// </summary>
        WM_LBUTTONUP = 0x202,

        /// <summary>
        /// ���˫��
        /// </summary>
        WM_LBUTTONDBLCLK = 0x203,

        /// <summary>
        /// �Ҽ�����
        /// </summary>
        WM_RBUTTONDOWN = 0x204,

        /// <summary>
        /// �Ҽ��ͷ�
        /// </summary>
        WM_RBUTTONUP = 0x205,

        /// <summary>
        /// �Ҽ�˫��
        /// </summary>
        WM_RBUTTONDBLCLK = 0x206,

        /// <summary>
        /// �м�����
        /// </summary>
        WM_MBUTTONDOWN = 0x207,

        /// <summary>
        /// �м��ͷ�
        /// </summary>
        WM_MBUTTONUP = 0x208,

        /// <summary>
        /// �м�˫��
        /// </summary>
        WM_MBUTTONDBLCLK = 0x209,

        /// <summary>
        /// ���ֹ���
        /// </summary>
        /// <remarks>WINNT4.0���ϲ�֧�ִ���Ϣ</remarks>
        WM_MOUSEWHEEL = 0x020A
    }

    public enum WM_KEYBOARD : int {
        /// <summary>
        /// ��ϵͳ��������
        /// </summary>
        WM_KEYDOWN = 0x100,

        /// <summary>
        /// ��ϵͳ�����ͷ�
        /// </summary>
        WM_KEYUP = 0x101,

        /// <summary>
        /// ϵͳ��������
        /// </summary>
        WM_SYSKEYDOWN = 0x104,

        /// <summary>
        /// ϵͳ�����ͷ�
        /// </summary>
        WM_SYSKEYUP = 0x105
    }

    /// <summary>
    /// SetWindowPos��־λö��
    /// </summary>
    /// <remarks>��ϸ˵��,��μ�MSDN�й���SetWindowPos����������</remarks>
    public enum SetWindowPosFlags : int {
        /// <summary>
        /// 
        /// </summary>
        SWP_NOSIZE = 0x0001,

        /// <summary>
        /// 
        /// </summary>
        SWP_NOMOVE = 0x0002,

        /// <summary>
        /// 
        /// </summary>
        SWP_NOZORDER = 0x0004,

        /// <summary>
        /// 
        /// </summary>
        SWP_NOREDRAW = 0x0008,

        /// <summary>
        /// 
        /// </summary>
        SWP_NOACTIVATE = 0x0010,

        /// <summary>
        /// 
        /// </summary>
        SWP_FRAMECHANGED = 0x0020,

        /// <summary>
        /// 
        /// </summary>
        SWP_SHOWWINDOW = 0x0040,

        /// <summary>
        /// 
        /// </summary>
        SWP_HIDEWINDOW = 0x0080,

        /// <summary>
        /// 
        /// </summary>
        SWP_NOCOPYBITS = 0x0100,

        /// <summary>
        /// 
        /// </summary>
        SWP_NOOWNERZORDER = 0x0200,

        /// <summary>
        /// 
        /// </summary>
        SWP_NOSENDCHANGING = 0x0400,

        /// <summary>
        /// 
        /// </summary>
        SWP_DRAWFRAME = 0x0020,

        /// <summary>
        /// 
        /// </summary>
        SWP_NOREPOSITION = 0x0200,

        /// <summary>
        /// 
        /// </summary>
        SWP_DEFERERASE = 0x2000,

        /// <summary>
        /// 
        /// </summary>
        SWP_ASYNCWINDOWPOS = 0x4000

    }

    #endregion ö�ٶ���

    #region �ṹ����

    [StructLayout(LayoutKind.Sequential)]
    public struct POINT {
        public int X;
        public int Y;
    }

    /// <summary>
    /// ��깳���¼��ṹ����
    /// </summary>
    /// <remarks>��ϸ˵����ο�MSDN�й��� MSLLHOOKSTRUCT ��˵��</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct MouseHookStruct {
        /// <summary>
        /// Specifies a POINT structure that contains the x- and y-coordinates of the cursor, in screen coordinates.
        /// </summary>
        public POINT Point;

        public UInt32 MouseData;
        public UInt32 Flags;
        public UInt32 Time;
        public UInt32 ExtraInfo;
    }

    /// <summary>
    /// ���̹����¼��ṹ����
    /// </summary>
    /// <remarks>��ϸ˵����ο�MSDN�й��� KBDLLHOOKSTRUCT ��˵��</remarks>
    [StructLayout(LayoutKind.Sequential)]
    public struct KeyboardHookStruct {
        /// <summary>
        /// Specifies a virtual-key code. The code must be a value in the range 1 to 254. 
        /// </summary>
        public UInt32 VKCode;

        /// <summary>
        /// Specifies a hardware scan code for the key.
        /// </summary>
        public UInt32 ScanCode;

        /// <summary>
        /// Specifies the extended-key flag, event-injected flag, context code, 
        /// and transition-state flag. This member is specified as follows. 
        /// An application can use the following values to test the keystroke flags. 
        /// </summary>
        public UInt32 Flags;

        /// <summary>
        /// Specifies the time stamp for this message. 
        /// </summary>
        public UInt32 Time;

        /// <summary>
        /// Specifies extra information associated with the message. 
        /// </summary>
        public UInt32 ExtraInfo;
    }

    #endregion �ṹ����

    /// <summary>
    /// Decalare all neccesary API for input devices
    /// </summary>
    internal static class Win32API {

        /// <summary>
        /// �������ô���
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hWndInsertAfter"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="cx"></param>
        /// <param name="cy"></param>
        /// <param name="uFlags"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx, int cy, int uFlags);

        /// <summary>
        /// ��װ����
        /// </summary>
        /// <param name="idHook"></param>
        /// <param name="lpfn"></param>
        /// <param name="hInstance"></param>
        /// <param name="threadId"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetWindowsHookEx(HookTypeID idHook, HookProc lpfn, IntPtr pInstance, int threadId);

        /// <summary>
        /// ж�ع���
        /// </summary>
        /// <param name="idHook"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(IntPtr pHookHandle);

        /// <summary>
        /// ���ݹ���
        /// </summary>
        /// <param name="idHook"></param>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(IntPtr pHookHandle, int nCode, Int32 wParam, IntPtr lParam);

        /// <summary>
        /// ת����ǰ������Ϣ
        /// </summary>
        /// <param name="uVirtKey"></param>
        /// <param name="uScanCode"></param>
        /// <param name="lpbKeyState"></param>
        /// <param name="lpwTransKey"></param>
        /// <param name="fuState"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int ToAscii(UInt32 uVirtKey, UInt32 uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, UInt32 fuState);

        /// <summary>
        /// ��ȡ����״̬
        /// </summary>
        /// <param name="pbKeyState"></param>
        /// <returns>��0��ʾ�ɹ�</returns>
        [DllImport("user32.dll")]
        public static extern int GetKeyboardState(byte[] pbKeyState);

        [DllImport("user32.dll")]
        public static extern short GetKeyStates(int vKey);

        /// <summary>
        /// ��ȡ��ǰ���λ��
        /// </summary>
        /// <param name="lpPoint"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public extern static int GetCursorPos(ref POINT lpPoint);

    }

}
