using System;
using System.Windows;
using System.Windows.Forms;

namespace Model.Helper
{
    public class HiddenColumn : Attribute
    {
        
    }

    public class DateTimeFormat : Attribute
    {
        public string sFormat { get; set; }
        public DateTimeFormat(string sFormat)
        {
            this.sFormat = sFormat;
        }
        public override string ToString()
        {
            return sFormat;
        }
    }
    public class NumberFormat : Attribute
    {
        public string sFormat { get; set; }
        public NumberFormat(string sFormat)
        {
            this.sFormat = sFormat;
        }
        public override string ToString()
        {
            return sFormat;
        }
    }
    public class AlignCell : Attribute
    {
        public int iAlign { get; set; }
        public AlignCell(DataGridViewContentAlignment sAlign)
        {
            switch(sAlign.ToString().ToLower())
            {
                case "topleft":
                    iAlign = 1;
                    break;
                case "topcenter":
                    iAlign = 2;
                    break;
                case "topright":
                    iAlign = 4;
                    break;
                case "middleleft":
                    iAlign = 16;
                    break;
                case "middlecenter":
                    iAlign = 32;
                    break;
                case "middleright":
                    iAlign = 64;
                    break;
                case "bottomleft":
                    iAlign = 256;
                    break;
                case "bottomcenter":
                    iAlign = 512;
                    break;
                case "bottomright":
                    iAlign = 1024;
                    break;
                default:
                    iAlign = 0;
                    break;
            }
        }
    }

    public class AllowEdit : Attribute
    {
        
    }

}
