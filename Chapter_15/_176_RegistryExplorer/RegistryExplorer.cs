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

namespace _176_RegistryExplorer
{
    public partial class FormExplorer : Form
    {
        public FormExplorer()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //获取注册表当前用户基项的子项，将其加入树形控件根节点
            GetSubKey(tVRegistryExplorer.Nodes, Registry.CurrentUser);
            //遍历树形控件根节点
            foreach (TreeNode node in tVRegistryExplorer.Nodes)
            {
                //获取根节点所对应注册表项的子项，将其加入树形控件根节点的子节点中
                GetSubKey(node.Nodes, node.Tag as RegistryKey);
            }
        }
        // 获取注册表项的子节点，并将其添加到树形控件节点中
        // <param name="nodes">树形控件节点</param>
        // <param name="rootKey">注册表项</param>
        public void GetSubKey(TreeNodeCollection nodes, RegistryKey rootKey)
        {
            if (nodes.Count != 0) return;
            string[] keyNames = rootKey.GetSubKeyNames();        //获取项的子项名称列表
                                                                 //遍历子项名称
            foreach (string keyName in keyNames)
            {
                try
                {
                    RegistryKey key = rootKey.OpenSubKey(keyName); //根据子项名称功能注册表项
                                                                   //如果表项不存在，则继续遍历下一表项
                    if (key == null) continue;
                    //根据子项名称创建对应的树形控件节点
                    TreeNode TNRoot = new TreeNode(keyName);
                    TNRoot.Tag = key;        //将注册表项与树形控件节点绑定在一起
                    nodes.Add(TNRoot);                             //向树形控件中添加节点
                }
                catch
                {
                    continue;                //如果由于权限问题无法访问子项，则继续搜索下一子项
                }
            }
        }

        private void tVRegistryExplorer_AfterExpand(object sender, TreeViewEventArgs e)
        {
            //遍历展开节点的子节点
            foreach (TreeNode node in e.Node.Nodes)
            {
                //获取展开节点的子节点所对应注册表项的子项，将其加入树形控件展开节点的子节点中
                GetSubKey(node.Nodes, node.Tag as RegistryKey);
            }
        }
    }
}
