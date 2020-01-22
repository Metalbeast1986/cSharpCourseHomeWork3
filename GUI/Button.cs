using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleGame.GUI
{
    class Button : GuiObject
    {
        private Frame _notActiveFrame;
        private Frame _activeFrame;

        private bool _isActive = false;
        private TextLine _textLine;

        public Button(int x, int y, int width, int height, string buttonText) : base(x, y, width, height)
        {
            _notActiveFrame = new Frame(x, y, width, height, '+');
            _activeFrame = new Frame(x, y, width, height, '#');

            _textLine = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);
        }

        public override void Render()
        {
            if (_isActive)
            {
                _activeFrame.Render();
            }
            else
            {
                _notActiveFrame.Render();
            }

            _textLine.Render();
        }

        public void SetActive()
        {
            _isActive = true;
        }
    }
}
