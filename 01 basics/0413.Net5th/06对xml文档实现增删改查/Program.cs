using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace _06对xml文档实现增删改查
{
    class Program
    {
        static void Main(string[] args)
        {
            //XMLDocument 进行操作

            #region 对XML文档实现追加的需求
            //XmlDocument doc = new XmlDocument();
            ////判断XML是否存在 存在追加，不存在新建
            //if (File.Exists("../../Student.xml"))
            //{
            //    //加载文件
            //    doc.Load("../../Student.xml");
            //    //追加操作 在根节点下面操作
            //    //获得根节点 给根节点添加
            //    XmlElement person = doc.DocumentElement;
            //    XmlElement student = doc.CreateElement("Student");
            //    student.SetAttribute("studentID","10");
            //    person.AppendChild(student);
            //    XmlElement name = doc.CreateElement("Name");
            //    name.InnerXml = "我是新来的";
            //    student.AppendChild(name);

            //    XmlElement age = doc.CreateElement("Age");
            //    age.InnerXml = "148";
            //    student.AppendChild(age);

            //    XmlElement gender = doc.CreateElement("Gender");
            //    gender.InnerXml = "女";
            //    student.AppendChild(gender);

            //}
            //else
            //{
            //    //不存在                
            //    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            //    doc.AppendChild(dec);

            //    XmlElement person = doc.CreateElement("Person");
            //    doc.AppendChild(person);

            //    XmlElement student = doc.CreateElement("Student");
            //    student.SetAttribute("studentID", "110");
            //    person.AppendChild(student);

            //    XmlElement name = doc.CreateElement("Name");
            //    name.InnerXml = "张三三李思思";
            //    student.AppendChild(name);

            //    XmlElement age = doc.CreateElement("Age");
            //    age.InnerXml = "28";
            //    student.AppendChild(age);

            //    XmlElement gender = doc.CreateElement("Gender");
            //    gender.InnerXml = "男";
            //    student.AppendChild(gender);
            //}

            //doc.Save("../../person.xml");
            //Console.WriteLine("保存成功");

            #endregion

            #region 读取XML文档
            XmlDocument doc = new XmlDocument();
            //doc.Load("../../books.xml");
            doc.Load("../../order.xml");

            //还是 先获得根节点
            //XmlElement books = doc.DocumentElement;
            XmlElement order = doc.DocumentElement;
            //获得根节点下面的所有子节点
            XmlNodeList xnl = order.ChildNodes;

            //foreach(XmlNode item in xnl)
            //{
            //    //这么做属性里的内容不能有效获取
            //    Console.WriteLine(item.InnerText);
            //}

            //根节点中的"Items"
            XmlElement items = order["Items"];
            XmlNodeList xnl2 = items.ChildNodes;
            foreach (XmlNode item in xnl2)
            {
                Console.WriteLine(item.Attributes["Name"].Value);
                Console.WriteLine(item.Attributes["Count"].Value);                
                //属性的值可以修改
                if (item.Attributes["Name"].Value == "手套")
                {
                    item.Attributes["Count"].Value = "100";
                }
            }

            #endregion

        }
    }
}
