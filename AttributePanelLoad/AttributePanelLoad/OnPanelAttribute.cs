using System;

namespace AttributePanel
{
    public class OnPanelAttribute : Attribute
    {
        public bool canBeOnPanel = false;

        public OnPanelAttribute(bool canBeOnPanel)
        {
            this.canBeOnPanel = canBeOnPanel;
        }

        public bool getCanBeOnPanel()
        {
            return canBeOnPanel;
        }
    }
}