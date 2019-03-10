using System;

namespace LayoutSample
{
    internal class UITapGestureRecognizer
    {
        private Func<object, object> p;

        public UITapGestureRecognizer(Func<object, object> p)
        {
            this.p = p;
        }

        public int NumberOfTapsRequired { get; set; }
    }
}