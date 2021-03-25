using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Fon
{
    class SaveOpenXML{
        private static SaveOpenXML SO_XML;
        XmlDocument doc = new XmlDocument();

        XElement Inv, Grp, Com;
        List<XAttribute> Atriguts = new List<XAttribute>();

        static SaveOpenXML(){
            SO_XML = new SaveOpenXML();
        }
        private SaveOpenXML() {
            if (File.Exists("ABC.xml")) doc.Load("ABC.xml");
        }
        public static SaveOpenXML SOXML() { return SO_XML; }
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        [DllImport("User32.dll")]
        private static extern int DestroyIcon(IntPtr hIcon);

        class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0;
            public const uint SHGFI_SMALLICON = 0x1;

            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath,
            uint dwFileAttributes,
            ref SHFILEINFO psfi,
            uint cbSizeFileInfo,
            uint uFlags);
        }
        public Icon GetIcon(string path, bool bolshaya){
            IntPtr hImgSmall;
            IntPtr hImgLarge;
            SHFILEINFO shinfo = new SHFILEINFO();
            if (!bolshaya){
                hImgSmall = Win32.SHGetFileInfo(path, 0, ref shinfo,
                (uint)Marshal.SizeOf(shinfo),
                Win32.SHGFI_ICON |
                Win32.SHGFI_SMALLICON);
            }else{
                hImgLarge = Win32.SHGetFileInfo(path, 0,
                ref shinfo, (uint)Marshal.SizeOf(shinfo),
                Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);
            }
            System.Drawing.Icon myIcon;
            try
            {
                myIcon = (System.Drawing.Icon)System.Drawing.Icon.FromHandle(shinfo.hIcon).Clone();
                DestroyIcon(shinfo.hIcon);
            }
            catch (Exception rr) {
                myIcon = System.Drawing.SystemIcons.Error;
            }
            return myIcon;
        }
        public void SaveO(MyTable MT)
        {
            Inv = new XElement("INVENTORY");
            foreach (Gropupa gr in MT.gr) {
                Grp = new XElement("Group");
                Atriguts.Add(new XAttribute("N", gr.Zagolovok.Text));
                Atriguts.Add(new XAttribute("lx", gr.Location.X));
                Atriguts.Add(new XAttribute("ly", gr.Location.Y));
                Atriguts.Add(new XAttribute("cr", (int)(gr.BackColor.R)));
                Atriguts.Add(new XAttribute("cg", (int)(gr.BackColor.G)));
                Atriguts.Add(new XAttribute("cb", (int)(gr.BackColor.B)));
                Atriguts.Add(new XAttribute("br", (int)(gr.Zagolovok.ForeColor.R)));
                Atriguts.Add(new XAttribute("bg", (int)(gr.Zagolovok.ForeColor.G)));
                Atriguts.Add(new XAttribute("bb", (int)(gr.Zagolovok.ForeColor.B)));
                Atriguts.Add(new XAttribute("zx", gr.SZ_X));
                Atriguts.Add(new XAttribute("zy", gr.SZ_Y));
                Atriguts.Add(new XAttribute("sh", gr.Visible));
                Grp.Add(Atriguts);
                Atriguts.Clear();
                foreach (Component cc in gr.Compot) {
                    Com = new XElement("Comp");
                    Atriguts.Add(new XAttribute("N", cc.Nane.Text));
                    Atriguts.Add(new XAttribute("P", cc.Path));
                    Com.Add(Atriguts);
                    Grp.Add(Com);
                    Atriguts.Clear();
                }
                Inv.Add(Grp);
            }
            File.WriteAllText("ABC.xml", Inv.ToString());
            GC.Collect();
        }
        public void OpenS(MyTable MT){
            XmlNodeList ListGroup = doc.GetElementsByTagName("Group");
            foreach (XmlElement grop in ListGroup)
            {
                XmlNodeList ListCom = grop.GetElementsByTagName("Comp");
                Gropupa G = new Gropupa(MT);
                foreach (XmlElement cm in ListCom)
                {
                    Component c = new Component(cm.GetAttribute("N"), cm.GetAttribute("P"), this.GetIcon(cm.GetAttribute("P"), true).ToBitmap());
                    G.AdddComp(c);
                }
                //G.Zagolovok.Text = G.Text = grop.GetAttribute("N");
                G.Location = new Point(int.Parse(grop.GetAttribute("lx")), int.Parse(grop.GetAttribute("ly")));
                G.SZ_X = int.Parse(grop.GetAttribute("zx"));
                G.SZ_Y = int.Parse(grop.GetAttribute("zy"));
                G.Show();
                G.SetAllMe(grop.GetAttribute("N"),
                    Color.FromArgb(int.Parse(grop.GetAttribute("cr")),
                    int.Parse(grop.GetAttribute("cg")),
                    int.Parse(grop.GetAttribute("cb"))),
                    Color.FromArgb(int.Parse(grop.GetAttribute("br")),
                    int.Parse(grop.GetAttribute("bg")),
                    int.Parse(grop.GetAttribute("bb"))), bool.Parse(grop.GetAttribute("sh")));
                MT.gr.Add(G);
            }
            //MT.AllShoww();
            GC.Collect();
        }
    }
}
