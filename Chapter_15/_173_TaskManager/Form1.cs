using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _173_TaskManager
{
    public partial class FormTaskManager : Form
    {
        public FormTaskManager()
        {
            InitializeComponent();
        }

        private void btnTaskManager_Click(object sender, EventArgs e)
        {
            //获取注册表HKEY_CURRENT_USER基项
            RegistryKey currentUser = Registry.CurrentUser;
            //打开注册表中的系统项
            RegistryKey system = currentUser.OpenSubKey(
              @"Software\Microsoft\Windows\CurrentVersion\Policies\System", true);
            if (system == null)                              //系统项不存在
            {
                system = currentUser.CreateSubKey(            //创建系统项
                    @"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            }
            //设置系统项中禁用任管理器键的值为1
            system.SetValue("DisableTaskmgr", 1, RegistryValueKind.DWord);
            currentUser.Close();                             //关闭HKEY_CURRENT_USER基项
        }
    }
}
