using System;

namespace AttributeTabControl
{
    public class OnTabControlAttribute : Attribute
    {
        public bool canBeOnTabControl = false;

        public OnTabControlAttribute(bool canBeOnTabControl)
        {
            this.canBeOnTabControl = canBeOnTabControl;
        }

        public bool getCanBeOnTabControl()
        {
            return canBeOnTabControl;
        }
    }
}