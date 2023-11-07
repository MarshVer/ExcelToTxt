using System;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using NPOI.XSSF.UserModel;
using System.IO;
using NPOI.SS.UserModel;

namespace ExcelToTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string SelectFolder1(TextBox tb)
        {
            string ret = "";
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb.Text = dialog.FileName;
            }
            return ret;
        }//选择文件
        private string SelectFolder2(TextBox tb)
        {
            string ret = "";
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb.Text = dialog.SelectedPath;
            }
            return ret;
        }//选择文件夹
        private void btn_lookforshare_Click_1(object sender, EventArgs e)
        {
            SelectFolder1(excel_folder);
        }

        private void transform_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(excel_folder.Text, FileMode.Open, FileAccess.Read))
                {
                    XSSFWorkbook workBook = new XSSFWorkbook(fs);
                    ISheet sheet = workBook.GetSheetAt(0);
                    FileStream fs1 = new FileStream(dhFiler.Text + "\\LSTREC.TXT", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs1, Encoding.GetEncoding("UTF-8"));
                    sw.WriteLine("idLen;idStyle;idRec;abCat;time;name;date;place");
                    string idLen, idStyle, idRec, abCat, time, name, date, place, eventName;
                    Hashtable idStyleTable = new Hashtable();//泳姿hash表
                    FileStream fsStyle = new FileStream(dhFiler.Text + "\\LSTSTYLE.TXT", FileMode.Open, FileAccess.Read);
                    StreamReader sr1 = new StreamReader(fsStyle);//读取泳姿文件
                    string key;
                    while (sr1.Peek() >= 0)
                    {
                        key = sr1.ReadLine().ToString();
                        idStyleTable.Add(key.Split(";".ToCharArray())[1].Replace("\"", ""), key.Split(";".ToCharArray())[0].Replace("\"", ""));
                    }
                    Hashtable abCatTable = new Hashtable();//性别hash表
                    FileStream fsAbCat = new FileStream(dhFiler.Text + "\\LSTCAT.TXT", FileMode.Open, FileAccess.Read);
                    StreamReader sr2 = new StreamReader(fsAbCat);
                    while (sr2.Peek() >= 0)
                    {
                        key = sr2.ReadLine().ToString();
                        abCatTable.Add(key.Split(";".ToCharArray())[0].Replace("\"", ""), key.Split(";".ToCharArray())[1].Replace("\"", ""));
                    }

                    for (int r = 1; r < sheet.LastRowNum; r++)
                    {
                        if (sheet.GetRow(r).GetCell(5).ToString() == "")
                        {
                            continue;
                        }
                        else
                        {
                            eventName = sheet.GetRow(r).GetCell(4).ToString().Replace(" ", "");
                            idStyle = idStyleTable[eventName.Substring(eventName.IndexOf("米") + 1)].ToString();//泳姿
                            idLen = selectIdLen(eventName.Remove(eventName.IndexOf("米"), eventName.Length - eventName.IndexOf("米")));//游泳距离（50，100，200，400，800，1500）
                            idRec = selectIdRec(sheet.GetRow(r).GetCell(2).ToString().Trim());//世界纪录，亚洲纪录。全国纪录
                            try
                            {
                                abCat = abCatTable[sheet.GetRow(r).GetCell(1).ToString().Trim()].ToString();//性别
                            }
                            catch
                            {
                                abCat = "";
                            }

                            time = sheet.GetRow(r).GetCell(5).ToString().Trim();//时间
                            name = sheet.GetRow(r).GetCell(6).ToString().Trim();//姓名
                            date = sheet.GetRow(r).GetCell(8).ToString().Trim();//日期

                            place = sheet.GetRow(r).GetCell(1).ToString().Trim() + eventName.Remove(eventName.IndexOf("米"), eventName.Length - eventName.IndexOf("米")) + "米" + eventName.Substring(eventName.IndexOf("米") + 1);//备注
                            switch (idRec)
                            {
                                case "0": place = place + "wr"; break;//备注
                                case "1": place = place + "ar"; break;//备注
                                case "2": place = place + "nr"; break;//备注
                                default: break;
                            }
                        }
                        sw.WriteLine(idLen + ";" + idStyle + ";" + idRec + ";" + abCat + ";" + time + ";" + name + ";" + date + ";" + place);
                    }
                    sw.Close();
                    fs1.Close();
                    MessageBox.Show("转换成功");
                }
            }
            catch
            {
                MessageBox.Show("请选择文件");
            }
            
        }

        public string selectIdLen(string mile)
        {
            switch (mile)
            {
                case "50": mile = "0"; break;
                case "100": mile = "1"; break;
                case "200": mile = "2"; break;
                case "400": mile = "3"; break;
                case "800": mile = "4"; break;
                case "1500": mile = "5"; break;
                case "4X50": mile = "6"; break;
                case "4X100": mile = "7"; break;
                case "4X200": mile = "8"; break;
                default: break;
            }
            return mile;
        }

        public string selectIdRec(string rec)
        {
            switch (rec)
            {
                case "世界纪录": rec = "0"; break;
                case "亚洲纪录": rec = "1"; break;
                case "全国纪录": rec = "2"; break;
                default: break;
            }
            return rec;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectFolder2(dhFiler);
        }

        private void openFiler_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(dhFiler.Text);
            }
            catch
            {
                MessageBox.Show("请选择DH文件夹");
            }
        }
    }
}
