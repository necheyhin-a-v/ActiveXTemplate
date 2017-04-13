using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace CSActiveX
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("4B9F42B2-8580-46BB-87F3-7765329D1796")]
    public class ControlManager : UserControl
    {
        private UserControl _CurrentControl;
        /// <summary>
        /// Конструктор, запускает первый контрол
        /// </summary>
        public ControlManager()
        {
            ChangeCurrentControl(new FirstControl());
            ((FirstControl)_CurrentControl).ButtonLoadSecond += ButtonLoadSecondClicked;
            ((FirstControl)_CurrentControl).ButtonLoadApp += ButtonLoadAppClicked;
        }

        private void ButtonLoadAppClicked(object sender, EventArgs e)
        {
            Thread newThread = new Thread(()=>ChangeFloatProp((FirstControl)_CurrentControl));
            newThread.Start();
            MainForm mainForm = new MainForm();
            mainForm.Show();

        }

        /// <summary>
        /// Обработчик нажатия на скрытие первого контрола
        /// </summary>
        private void ButtonLoadSecondClicked(object sender, EventArgs e)
        {
            ChangeCurrentControl(new SecondControl());
            ((SecondControl)_CurrentControl).ButtonGoMainClicked += ButtonGoMainClicked;
        }
        /// <summary>
        /// Обработчик нажатия на переход к главному контролу (первому)
        /// </summary>
        private void ButtonGoMainClicked(object sender, EventArgs e)
        {
            ChangeCurrentControl(new FirstControl());
            ((FirstControl)_CurrentControl).ButtonLoadSecond += ButtonLoadSecondClicked;
            ((FirstControl)_CurrentControl).ButtonLoadApp += ButtonLoadAppClicked;
        }

        /// <summary>
        /// Смена текущего контрола на другой
        /// При этом освобождаются ресурсы и меняются размеры контейнера
        /// </summary>
        private void ChangeCurrentControl(UserControl control)
        {
            if(_CurrentControl != null)
                _CurrentControl.Dispose();
            _CurrentControl = control;
            _CurrentControl.Parent = this;
            this.Size = _CurrentControl.Size;
            _CurrentControl.Show();
        }

        /// <summary>
        /// В новом потоке изменяется свойство
        /// </summary>
        /// <param name="control"></param>
        private void ChangeFloatProp(FirstControl control)
        {
            for(int i=0; i<1000; i++)
            {
                control.FloatProperty += 1;
                Thread.Sleep(1000);
            }
        }
    }
}
