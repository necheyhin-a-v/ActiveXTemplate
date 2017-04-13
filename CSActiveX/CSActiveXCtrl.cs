/*
 Пример ActiveX контролла
 */
#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Reflection;
using System.Security.Permissions;
#endregion


namespace CSActiveX
{

    /// <summary>
    /// Интерфейс задает общие свойства и функции которые необходимо
    /// реализовать в контроле контрол наследует данный интерфейс
    /// </summary>
    public interface AxCSActiveXCtrl
    {
        //Свойства
        float FloatProperty { get; set; }
        //Методы
        string HelloWorld();
    }

    /// <summary>
    /// Открытый интерфейс, доступный для внешней среды описывающий события контрола
    /// Данный интерфейс связывается с классом посредством ComSourceInterfaces()
    /// Без данного интерфейса не будет возможности отлавливать события во внешней среде
    /// </summary>
    [Guid("901EE2A0-C47C-43ec-B433-985C020051D5")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface AxCSActiveXCtrlEvents
    {
        // Необходимо явно определять DISPID для каждого события, иначе,
        // адрес обратного вызова не может быть найден при вызове события
        [DispId(1)]
        void Click();
        [DispId(2)]
        void FloatPropertyChanging(float NewValue);
    }

    /// <summary>
    /// Собственно класс Контролла наследующий UserControl и интерфейс
    /// Интерфейс для предоставления событий во внешнюю среду
    /// подключается с помощью атрибута ComSourceInterfaces()
    /// </summary>
    [ClassInterface(ClassInterfaceType.None)]
    [ComSourceInterfaces(typeof(AxCSActiveXCtrlEvents))]
    [Guid("D4675E22-985D-48D0-86B4-D86581FBDF81")]
    public partial class CSActiveXCtrl : UserControl, AxCSActiveXCtrl
    {
        //В данной секции происходит инициализация контрола
        //Создание всех видимых объектов и т.д.
        #region Initialization
        public CSActiveXCtrl()
        {
            InitializeComponent();

            // Подключение к обработчику событий клик по контролу
            base.Click += new EventHandler(CSActiveXCtrl_Click);

            // Установка автоскрола, если часть контрола не видна
            this.AutoScroll = true; 
        }

        #endregion

        //В данной секции отображены все свойства контрола
        //Все открытые свойства доступны внешней среде
        #region Properties
        //Переменная, хранящая значение для свойства FloatProperty
        private float fField = 0;

        //Открытое свойство, доступное внешней среде с get и set
        public float FloatProperty
        {
            get { return this.fField; }
            set 
            {
                // При установке свойства вызывается событие FloatProperyChanging(newValue)
                if (null != FloatPropertyChanging)
                    FloatPropertyChanging(value);
                this.fField = value;
                this.lbFloatProperty.Text = value.ToString();   //Обновление текста о текущем размере float
            }
        }
        #endregion

        // В данной секции показан метод, доступный внешней среде, т.к. является public
        #region Methods
        //Функция возвращает строку либо во внешнюю среду либо может выполняться средой .NET
        public string HelloWorld()
        {
            return "Сообщение Hello World";
        }
        #endregion

        // В данной секции показаны примеры различных событий
        // Для события, которое может быть отправлено наружу(т.е. вне ActiveX) необходимо:
        // 1) Объявить делегат с необходимым заголовком функции, т.е. тип возвращаемого значения, имя и параметры
        // 2) Создать новое событие типа delegate и необходимым именем
        // 3) Произвести новое событие.
        // 4) Также данное событие должно быть описано в интерфейсе с обязательным DispID
        #region Events
        //Событие отсылаемое во внешнюю среду без параметра
        [ComVisible(false)]
        public delegate void ClickEventHandler();
        public new event ClickEventHandler Click = null;
        void CSActiveXCtrl_Click(object sender, EventArgs e)
        {
            if (null != Click) Click(); // Произвести новое событие Click.
        }

        //Событие отсылаемое во внешнюю среду с параметром
        [ComVisible(false)]
        public delegate void FloatPropertyChangingEventHandler(float NewValue);
        public event FloatPropertyChangingEventHandler FloatPropertyChanging = null;

        //Событие обрабатываемое полностью внутри приложения .NET и не может контроллироваться внешней средой
        private void btnMessage_Click(object sender, EventArgs e)
        {
            if (tbMessage.Text == "")
                MessageBox.Show("Заполните что-нибудь в текстбокс");
            else
                MessageBox.Show(tbMessage.Text, "Сообщение из текстбокса",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
