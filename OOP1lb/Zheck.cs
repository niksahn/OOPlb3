namespace OOP1lb
{
    /// <summary>
    /// Класс, реализующий ЖЭК
    /// </summary>
    public class Zheck
    {
        /* ПОЛЯ */

        /// <summary>
        /// Регион
        /// </summary>
        string Region;
        /// <summary>
        /// Номер ЖЭК в системе (id)
        /// </summary>
        int Number;
        /// <summary>
        /// Название ЖЭК
        /// </summary>
        string Name;
        /// <summary>
        /// Количество жителей.
        /// </summary>
        double NumberHabitians;
        /// <summary>
        /// Число плательщиков
        /// </summary>
        double NumberPayments;
        /// <summary>
        /// Количество зданий
        /// </summary>
        double NumberOfBuildings;
        /// <summary>
        /// Контактная почта
        /// </summary>
        string ContactEmail;
        /// <summary>
        /// Площадь обслуживания
        /// </summary>
        float ServiceArea;
        /// <summary>
        /// Счетчик элементов класса
        /// </summary>
        public static int counter = 0;

        /* СВОЙСТВА */
        public string Region1
        {
            get => Region;
            set
            {
                if (!Functions.IsString(value)) throw new MyException("Неверное знаение поля регион");
                Region = value;
            }
        }
        public int Number1 { get => Number; }
        public string Name1 { 
            get => Name;
            set
            {
                if (!Functions.IsString(value)) throw new MyException("Неверное знаение поля название");
                Name = value;
            }
        }
        public double NumberHabitians1 { get => NumberHabitians; set => NumberHabitians = value; }
        public double NumberPayments1 { get => NumberPayments; set => NumberPayments = value; }
        public double NumberOfBuildings1 { get => NumberOfBuildings; set => NumberOfBuildings = value; }
        public string ContactEmail1 { get => ContactEmail; set => ContactEmail = value; }
        public float ServiceArea1 { get => ServiceArea; set => ServiceArea = value; }

        /* МЕТОДЫ */

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Zheck()
        {
           
            this.Region = Functions.RandomString();
            this.Number = counter;
            this.NumberHabitians = 0;
            this.NumberPayments = 0;
            this.NumberOfBuildings = 0;
            this.ContactEmail = Functions.RandomString();
            this.ServiceArea = 0;
            this.Name = Functions.RandomString();
            counter++;
        }

        /// <summary>
        /// Конструктор с 7 параметрами
        /// </summary>
        /// /// <param name="region">Регион</param>
        /// <param name="name">Название</param>
        /// <param name="numberHabitians">Количество жителей</param>
        /// <param name="numberPayments">Число плательщиков</param>
        /// <param name="numberOfBuildings">Количество зданий</param>
        /// <param name="contactEmail">Почта</param>
        /// <param name="serviceArea">Площадь обслуживания</param>
        public Zheck(string region, string name, double numberHabitians, double numberPayments, double numberOfBuildings, string contactEmail, float serviceArea)
        {
           
            this.Region1 = region;
            this.Number = counter;
            this.NumberHabitians1 = numberHabitians;
            this.NumberPayments1 = numberPayments;
            this.NumberOfBuildings1 = numberOfBuildings;
            this.ContactEmail1 = contactEmail;
            this.ServiceArea1 = serviceArea;
            this.Name1 = name;
            counter++;
        }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="name">Название</param>
        public Zheck(string name)
        {

            this.Region1 = Functions.RandomString();
            this.Number = counter;
            this.NumberHabitians1 = 0;
            this.NumberPayments1 = 0;
            this.NumberOfBuildings1 = 0;
            this.ContactEmail1 = Functions.RandomString();
            this.ServiceArea1 = 0;
            this.Name1 = name;
            counter++;
        }
        /// <summary>
        /// Конструктор с 2 параметр
        /// </summary>
        /// <param name="region">Регион</param>
        /// <param name="name">Название</param>
        public Zheck(string region, string name)
        {
           
            this.Region1 = region;
            this.Number = counter;
            this.NumberHabitians1 = 0;
            this.NumberPayments1 = 0;
            this.NumberOfBuildings1 = 0;
            this.ContactEmail1 = Functions.RandomString();
            this.ServiceArea1 = 0;
            this.Name1 = name; 
            counter++;
        }

        /// <summary>
        /// Получить id в 16 ричной СС
        /// </summary>
        /// <returns>id в 16 ричной СС</returns>
        public string GetNumberInHex()
        {
            return Convert.ToString(Number1, 16);
        }

        /// <summary>
        /// Переопределение метода ToString()
        /// </summary>
        /// <returns>Строку с информацией о ЖЭК</returns>
        public override string ToString()
        {
            return Number + "\n" + Region + "\n" + Name + "\n" +
                 NumberHabitians + "\n" + NumberPayments + "\n" + NumberOfBuildings + "\n" + ContactEmail + "\n" + ServiceArea;
        }
    }
}
