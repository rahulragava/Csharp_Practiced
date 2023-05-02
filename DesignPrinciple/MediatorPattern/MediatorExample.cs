using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple.MediatorPattern
{
    public abstract class UIControl
    {
        protected DialogBox dialogBox;

        
        public UIControl(DialogBox dialogBox)
        {
            this.dialogBox = dialogBox;
        }

        public abstract void DoSomeThing();
    }

    public class ListBox : UIControl
    {
        private string _selection;

        public ListBox(DialogBox dialogBox) : base(dialogBox)
        {
        }

        public string Selection
        {
            get { return _selection; }
            set
            {
                _selection = value;
                dialogBox.OnChange(this);
            }

        }
        public override void DoSomeThing()
        {
            throw new NotImplementedException();
        }
    }

    public class Button : UIControl
    {
        private bool _buttonState;

        public Button(DialogBox dialogBox) : base(dialogBox)
        {
        }

        public bool Selection
        {
            get { return _buttonState; }
            set
            {
                _buttonState = value;
                dialogBox.OnChange(this);
            }

        }
        public override void DoSomeThing()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class DialogBox
    {
        public abstract void OnChange(UIControl uiControl);
    }

    public class ArticleDialogBox
    {
        private Button _button;
        private ListBox _listBox;

        public ArticleDialogBox(Button button, ListBox listBox)
        {
            _button = button;
            _listBox = listBox;
        }

        public void OnChange(UIControl control)
        {
            if (control == _button)
            {

            }
            else if(control == _listBox)
            {

            }
        }
    }

    public class MediatorExample
    {
    }
}
