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

namespace _177_RegistrySearch
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }
        delegate void SearchRegistryKeyCallback(RegistryKey key);   //搜索注册表委托
        /// 搜索注册表指定项
        /// <param name="key">注册表项</param>
        private void SearchRegistryKey(RegistryKey key)
        {
            if (key == null) return;                             //判断项是否为空
            string[] valueNames = key.GetValueNames();           //获取注册表项的键名列表
                                                                 //将注册表项加入搜索状态提示中
            SetSearchState(key.ToString());
            //遍历所有的键名，判断键名或键值中是否含有搜索的关键字
            foreach (string valueName in valueNames)
            {
                string keywords = tBKeywords.Text;                //搜索的关键字
                string value = key.GetValue(valueName).ToString();  //获取键值并转换成字符串类型
                                                                    //判断键名或键值中是否含有搜索的关键字
                if (valueName.Contains(keywords) || value.Contains(keywords))
                //如果含有搜索关键字
                {
                    //将该键在注册表中的全路径添加到搜索结果列表中
                    AddSearchState(key.ToString() + "\\" + valueName);
                }
            }
            string[] subKeyNames = key.GetSubKeyNames();     //获取项的所有子项名
            foreach (string subKeyName in subKeyNames)       //遍历所有的子项，并对其进行搜索
            {
                try
                {
                    //根据子项名获取子项
                    RegistryKey subKey = key.OpenSubKey(subKeyName);
                    if (subKey == null) continue;     //如果子项为空，则继续搜索下一子项
                    SearchRegistryKey(subKey);        //搜索子项
                }
                catch (Exception)
                {
                    continue;                //如果由于权限问题无法访问子项，则继续搜索下一子项
                }
            }
            key.Close();
        }

        private void bWSearch_DoWork(object sender, DoWorkEventArgs e)
        {
            this.SearchRegistryKey(e.Argument as RegistryKey);   //后台搜索注册表项
        }
        private void bWSearch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //提示用户搜索已完成，并显示搜索的总记录数
            MessageBox.Show("搜索完成！共有" + lBSearchResult.Items.Count + "条记录");
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            //判断后台搜索是否正在进行
            if (!bWSearch.IsBusy)
            {
                lBSearchResult.Items.Clear();                 //清空搜索结果列表
                bWSearch.RunWorkerAsync(Registry.CurrentUser);  //对注册表当前用户基项进行搜索
            }
            else
            {
                MessageBox.Show("正在搜索,请稍等...");          //提示用户正在搜索
            }

        }

        delegate void SetSearchStateCallback(string key);//设置搜索状态委托
        void SetSearchState(string key)
        {
            if (this.InvokeRequired)
                //如果需要委托调用，则使用设置搜索状态委托
                this.Invoke(new SetSearchStateCallback(SetSearchState), new object[] { key });
            else
                tSSLSeatching.Text = key;                         //设置搜索状态
        }
        delegate void AddSearchStateCallback(string key);       //添加搜索记录委托
        void AddSearchState(string key)
        {
            if (this.InvokeRequired)
                //如果需要委托调用，则使用添加搜索记录委托
                this.Invoke(new AddSearchStateCallback(AddSearchState), new object[] { key });
            else
                lBSearchResult.Items.Add(key);                    //添加搜索记录
        }
    }
}
