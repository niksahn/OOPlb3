namespace OOP1lb
{
    internal static class Program
    {
       static MyHashTable zheckList = new MyHashTable();

        /// <summary>
        ///  ������� ����� � ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Win32.MessageBox(0, "������������ ������ � 1. �����. ����������� �����\r\n������. ��������� ����������", "������ 4: �����, �������", 0);
            
            Application.Run(new Form1(zheckList));
        }
    }
}