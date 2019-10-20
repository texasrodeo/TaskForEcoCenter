using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Xsl;


namespace TaskForEcoCenter.FileUtils.XSLTransform
{
    public static class TransformUtils
    {
        /// <summary>
        /// Трансформирует файл по заданному xslt в html файл
        /// </summary>
        /// <param name="filename">Путь к трансформируемому файла</param>
        /// <returns>Список XElement со всеми авторами</returns>
        public static void transform(string filename)
        {
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
            xslCompiledTransform.Load(Environment.CurrentDirectory + "..\\..\\..\\FileUtils\\XSLTransform\\XSLTpattern.xslt"); //xslt файл
            xslCompiledTransform.Transform(filename, filename.Remove(filename.Length-3,3)+"html"); //получение файла filename.html
        }
    }
}
