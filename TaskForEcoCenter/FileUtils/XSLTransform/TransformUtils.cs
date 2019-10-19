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
        
        public static void transform(string filename)
        {
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
            xslCompiledTransform.Load(Environment.CurrentDirectory + "..\\..\\..\\FileUtils\\XSLTransform\\XSLTpattern.xslt");
            xslCompiledTransform.Transform(filename, filename.Remove(filename.Length-3,3)+"html");
        }
    }
}
