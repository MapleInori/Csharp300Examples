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

namespace _174_HideHardDisk
{
    public partial class FormbtnHardDisk : Form
    {
        public FormbtnHardDisk()
        {
            InitializeComponent();
            //遍历字符‘A’到‘Z’
            for (int i = 0; i < 26; i++)
            {
                int diskNumber = 0x00000001 << i;             //产生磁盘编号
                                                              //将磁盘盘符与磁盘所对应十六进制编号作为选择添加到磁盘列表中
                cBDisk.Items.Add(Convert.ToChar('A' + i) + "盘 0x" + diskNumber.
                                  ToString("X8"), false);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormbtnHardDisk_Load(object sender, EventArgs e)
        {

        }



        private void btnHideHardDisk_Click(object sender, EventArgs e)
        {
            RegistryKey currentUser = Registry.CurrentUser; //获取注册表HKEY_CURRENT_USER基项
                                                            //打开注册表中的资源管理器项
            RegistryKey explorer = currentUser.OpenSubKey(
              @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer", true);
            if (explorer == null)
            {//资源管理器项不存在
             //创建资源管理器项
                explorer = currentUser.CreateSubKey(
                    @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer");
            }
            //设置资源管理器项中隐藏磁盘键的键值为隐藏磁盘的编号和
            explorer.SetValue("NoDrives", GetDistNumber(), RegistryValueKind.DWord);
            currentUser.Close();                        //关闭HKEY_CURRENT_USER基项
        }

        int GetDistNumber()
        {
            int diskNumber = 0x00000000;                     //硬盘编号初始值
                                                             //遍历需要隐藏的磁盘
            foreach (string chechedDisk in cBDisk.CheckedItems)
            {
                string strNumber = chechedDisk.ToString().Split(new string[] { "0x" },
                  StringSplitOptions.RemoveEmptyEntries)[1]; //获取隐藏磁盘编号
                diskNumber += Convert.ToInt32(strNumber, 16);  //将需要隐藏的磁盘编号进行累加
            }
            return diskNumber;                               //返回最终需要隐藏的磁盘编号之和
        }

    }
}
