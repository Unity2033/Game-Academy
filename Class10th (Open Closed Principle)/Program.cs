internal class Program
{
    static void Main(string[] args)
    {
        #region 개방 폐쇄 원칙
        // 소프트웨어 개체는 확장에 대해 열려 있어야 하며,
        // 수정에 대해서는 닫혀 있도록 설계되어야 하는 원칙입니다.

        Sensor sensor = new Sensor();

        Bread bread = new Bread();
        Sealant sealant = new Sealant();
        Defective defective = new Defective();

        sensor.Detect(bread);
        sensor.Detect(sealant);
        sensor.Detect(defective);

        #endregion
    }
}

