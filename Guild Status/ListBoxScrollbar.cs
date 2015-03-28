using System.Windows.Forms;

namespace Guild_Status
{
    class ListBoxScrollbar : ListBox
    {

        private bool _mShowScroll;
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                if (!_mShowScroll) cp.Style = cp.Style & ~0x200000;
                return cp;
            }
        }
        public bool ShowScrollbar
        {
            get { return _mShowScroll; }
            set
            {
                if (value != _mShowScroll)
                {
                    _mShowScroll = value;
                    if (IsHandleCreated) RecreateHandle();
                }
            }
        }
    }
}
