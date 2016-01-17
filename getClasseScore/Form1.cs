using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace getClasseScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*
            tbxMaxID.Text = "36";
            tbxClasse.Text = "144771";
            tbxCourse.Text = "40201053";
            */
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (tbxClasse.Text.Length != 6)
            {
                MessageBox.Show("请输入正确的学号前缀！", "滑稽");
                return;
            }
            if (tbxMaxID.Text.Length != 2)
            {
                MessageBox.Show("请输入正确的最大学号！", "滑稽");
                return;
            }
            int start = 1, end = int.Parse(tbxMaxID.Text);
            string courseID = tbxCourse.Text;
            string tableContent = "<head id=\"Head1\"><title>教务管理信息系统</title><link href=\"http://219.230.159.132/css/oa_Mview.css\" rel=\"stylesheet\" type=\"text/css\"><link href=\"../css/css-table.css\" rel=\"stylesheet\" type=\"text/css\"><link href=\"http://219.230.159.132/css/ASPNET2BaseCss.css\" rel=\"stylesheet\" type=\"text/css\"><style type=\"text/css\"> .GVFixedHeader { font-weight:bold; color: #A80000; position:relative; top:expression(this.parentNode.parentNode.parentNode.scrollTop-1);}.GVFixedFooter { font-weight:bold; position:relative;bottom:expression(getScrollBottom(this.parentNode.parentNode.parentNode.parentNode));}.Freezing{background-color:#FF8000;position:relative ;table-layout:fixed;top:expression(this.offsetParent.scrollTop); z-index: 10;} .Freezing th{text-overflow:ellipsis;overflow:hidden;white-space: nowrap;padding:2px;}</style></head><table class=\"dg1-table\" cellspacing=\"0\" rules=\"all\" border=\"1\" id=\"gvcj1\" width=\"98%\" style=\"left: 2px; top: 31px\"><tr class=\"dg1-item\">";
            progressBar1.Minimum = start;
            progressBar1.Maximum = end;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            progressBar1.Visible = true;
            for (int i = start; i <= end; i++)
            {
                string url = string.Format("http://219.230.159.132/web_cjgl/cx_cj_xh_gly.aspx?whfs=%E5%AD%A6%E7%94%9F%E5%88%97%E8%A1%A8%E6%88%90%E7%BB%A9&xsxh={0}{1:d2}&xsbh=&kcdm", tbxClasse.Text, i);
                string content = getPage(url);
                string[] lines = content.Split('\n');
                for (int index = 0; index < lines.Length; index++)
                {
                    if (lines[index].Contains(courseID.Trim()))
                    {
                        tableContent += lines[index];
                        tableContent += "</tr><tr class=\"dg1 - item\">";
                        break;
                    }
                }
                progressBar1.PerformStep();
            }
            tableContent += "</table>";
            WebView wv = new WebView();
            wv.Content = tableContent;
            wv.ShowDialog();
        }

        private string getPage(string url)
        {
            string content;
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream respStream = response.GetResponseStream();
            using (StreamReader reader = new StreamReader(respStream, Encoding.UTF8))
            {
                content = reader.ReadToEnd();
            }
            return content;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGetPageByName_Click(object sender, EventArgs e)
        {
            /*
            WebView wv = new WebView();
            wv.Url = "http://219.230.159.145/web_cjgl/cx_cj_xsxm_xz.aspx";
            wv.Title = "按姓名查询学生成绩";
            wv.Size = new System.Drawing.Size(350, 560);
            wv.ShowDialog();
            */
            MessageBox.Show("抱歉，暂不提供该功能。\r\n这是保护隐私的最后一道防线了……", "滑稽");
        }

        private void btnSingleScore_Click(object sender, EventArgs e)
        {
            if (tbxStudentID.Text.Length != 8)
            {
                MessageBox.Show("请输入正确的学号！", "滑稽");
                return;
            }
            WebView wv = new WebView();
            wv.Url = String.Format("http://219.230.159.145/web_cjgl/cx_cj_xh_gly.aspx?whfs=%E5%AD%A6%E7%94%9F%E5%88%97%E8%A1%A8%E6%88%90%E7%BB%A9&xsxh={0}&xsbh=&kcdm", tbxStudentID.Text);
            wv.ShowDialog();
        }

        private void btnViewPhoto_Click(object sender, EventArgs e)
        {
            if (tbxStudentID.Text.Length != 8)
            {
                MessageBox.Show("请输入正确的学号！", "滑稽");
                return;
            }
            WebView wv = new WebView();
            wv.Url = String.Format("http://219.230.159.145/images/xszp/{0}.jpg", tbxStudentID.Text);
            wv.Title = "欸嘿嘿";
            wv.Size = new System.Drawing.Size(250, 350);
            wv.ShowDialog();
        }
    }
}
