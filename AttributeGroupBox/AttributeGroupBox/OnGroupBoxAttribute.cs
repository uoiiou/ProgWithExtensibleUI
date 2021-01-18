using System;

namespace AttributeGroupBox
{
    public class OnGroupBoxAttribute : Attribute
    {
        public bool canBeOnGroupBox = false;

        public OnGroupBoxAttribute(bool canBeOnGroupBox)
        {
            this.canBeOnGroupBox = canBeOnGroupBox;
        }

        public bool getCanBeOnGroupBox()
        {
            return canBeOnGroupBox;
        }
    }
}