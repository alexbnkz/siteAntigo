using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace com.alexbnkz.root.EnglishInCourse
{

    public partial class SplitWord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string texto = "" + Request.Form["texto"];

            List<string> text = new List<string>();
            List<int> count = new List<int>();

            texto = texto.ToLower()
                .Replace("“", " ").Replace("”", " ")
                .Replace("\"", " ").Replace(" - ", " ")
                .Replace(",", " ").Replace(".", " ")
                .Replace("!", " ").Replace("?", " ")
                .Replace(":", " ").Replace(";", " ")
                .Replace("(", " ").Replace(")", " ")
                .Replace("\n", " ").Replace("\r", " ");

            while (texto.IndexOf("  ") >= 0)
                texto = texto.Replace("     ", " ").Replace("   ", " ").Replace("  ", " ");

            if (texto != "")
            {
                var split = texto.Split(' ');

                for (int i = 0; i < split.Length; i++)
                {
                    if (text.IndexOf(split[i]) > -1)
                    {
                        count[text.IndexOf(split[i])] += 1;
                    }
                    else
                    {
                        if (split[i].Trim() != "")
                        {
                            text.Add(split[i]);
                            count.Add(1);
                        }
                    }
                }

                List<string> result = new List<string>();

                foreach (string palavra in text)
                {
                    result.Add(count[text.IndexOf(palavra)].ToString("000") + ", " + palavra);
                }

                result.Sort();

                var list = "";
                list += "the,this,so,people,back,";
                list += "be,but,up,into,after,";
                list += "to,his,out,year,use,";
                list += "of,by,if,your,two,";
                list += "and,from,about,good,how,";
                list += "a,they,who,some,our,";
                list += "in,we,get,could,work,";
                list += "that,say,which,them,first,";
                list += "have,her,go,see,well,";
                list += "I,she,me,other,way,";
                list += "it,or,when,than,even,";
                list += "for,an,make,then,new,";
                list += "not,will,can,now,want,";
                list += "on,my,like,look,because,";
                list += "with,one,time,only,any,";
                list += "he,all,no,come,these,";
                list += "as,would,just,its,give,";
                list += "you,there,him,over,day,";
                list += "do,their,know,think,most,";
                list += "at,what,take,also,us";

                list = list.ToLower();

                List<string> words = list.Split(',').ToList<string>();

                for (int i = result.Count - 1; i >= 0; i--)
                {
                    int contador = Convert.ToInt32(result[i].Split(',')[0]);
                    string palavra = result[i].Split(',')[1];

                    if (words.IndexOf(palavra.Trim()) == -1)
                        Response.Write(contador + ", " + palavra + "<br />");
                }
            }
        }
    }
}