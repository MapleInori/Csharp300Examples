using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace _172_RegistryBoot
{
    public partial class FormBoot : Form
    {
        public FormBoot()
        {
            InitializeComponent();
        }

        // 重载窗体构造函数
        // <param name="bootInfo">窗体自动启动信息</param>
        public FormBoot(string bootInfo)
        {
            InitializeComponent();
            lBoot.Text = bootInfo;                        //将启动信息赋值给标签控件
        }

        private void FormBoot_Load(object sender, EventArgs e)
        {

        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            //获取注册表HKEY_LOCAL_MACHINE基项
            RegistryKey localMachine = Registry.LocalMachine;
            //获取注册表中程序启动项所在的项
            RegistryKey run = localMachine.OpenSubKey(
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
            if (run == null)                                 //判断启动项是否存在
            {
                MessageBox.Show("启动项不存在！");
            }
            else
            {
                //获取程序在开机启动项中的键值
                object registryBootValue = run.GetValue("RegistryBoot");
                if (registryBootValue != null)
                {//程序已经添加到开机启动项中
                    MessageBox.Show("该程序已经添加到启动项！");
                }
                else
                {
                    //获取程序当前路径
                    string fullPath = System.IO.Directory.GetCurrentDirectory();
                    //将程序名和程序全路径及启动参数分别写入启动项的键位和键值中
                    //键值类型设置为字符串型
                    run.SetValue("RegistryBoot", fullPath + "\\Registry_Boot.exe \"开机已自动启动\"",
                        RegistryValueKind.String);
                }
            }
            localMachine.Close();                       //关闭HKEY_LOCAL_MACHINE基项
        }
    }
}
