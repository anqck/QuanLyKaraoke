using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class MyComboBoxItem
    {
        public MyComboBoxItem(string text, object tag)
        {
            _Text = text;
            _Tag = tag;
        }
        private string _Text;
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        private object _Tag;
        public object Tag
        {
            get { return _Tag; }
            set { _Tag = value; }
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
