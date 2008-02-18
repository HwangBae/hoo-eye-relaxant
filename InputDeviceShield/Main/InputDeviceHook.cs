using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Hoo.InputDevice {
    public abstract class InputDeviceHook {
       
        /// <summary>
        /// Type ID of hook, such as WH_KEYBOARD_LL or WH_MOUSE_LL;
        /// Every concrete class should define it.
        /// </summary> 
        protected HookTypeID _hookType;


        /// <summary>
        /// hook for mouse or keyboard
        /// </summary>
        protected IntPtr _hook = IntPtr.Zero;


        /// <summary>
        /// ���̹���ί��ʵ��
        /// </summary>
        /// <remarks>
        /// ��Ҫ��ͼʡ�Դ˱���,���򽫻ᵼ��
        /// ���� CallbackOnCollectedDelegate �йܵ������� (MDA)�� 
        /// ��ϸ��μ�MSDN�й��� CallbackOnCollectedDelegate ������
        /// </remarks>
        protected HookProc _hookHandler;


        public virtual bool DisableDevice { get; set; }
       

        /// <summary>
        /// ���̹��Ӵ�����
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>      
        protected abstract int HookProc(int nCode, Int32 wParam, IntPtr lParam);


        /// <summary>
        /// ��װ����
        /// </summary>
        /// <returns></returns>
        public virtual bool InstallHook() {
           
            IntPtr pInstance = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().ManifestModule);

            if (this._hook == IntPtr.Zero) {
                this._hookHandler = new HookProc(HookProc);
                this._hook = Win32API.SetWindowsHookEx(_hookType, this._hookHandler, pInstance, 0);
                if (this._hook == IntPtr.Zero) {
                    this.UnInstallHook();
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// ж�ع���
        /// </summary>
        /// <returns></returns>
        public virtual bool UnInstallHook() {
            bool result = true;        
            if (this._hook != IntPtr.Zero) {
                result = (Win32API.UnhookWindowsHookEx(this._hook) && result);
                this._hook = IntPtr.Zero;
            }

            return result;
        }
        
    }
}
