using System.Security.Cryptography.X509Certificates;

namespace _19.Day19_DesignPattern
{
    internal class Program
    {
        //팩토리 패턴
        //등급은 일반 0 , 희귀 10, 전설 20
        #region Iweapon
        public enum WeaponGrade
        {
            Rotten,
            Nomal,
            Rare,
            Legendery

        }
        public interface IWeapon //인터페이스 웨펀
        {
            string Name();
            int BaseAttackPower();
            int AttackPower();
            int AttackRange();
            WeaponGrade Grade();
        }
        public class IronSword : IWeapon //철검 
        {
            public string Name() => "철 검";

            private WeaponGrade _grade;
            public IronSword(WeaponGrade grade) => _grade = grade;
            public WeaponGrade Grade() => _grade;
            
            public int BaseAttackPower() => 20;
            public int AttackPower()
            {
                int basePower = BaseAttackPower();
                return (int)(basePower * (1 + GradeBouns(_grade))); //오버플로우 발생. //0.2, 0.1, 0이들어갈건데 왜 오버플로우? 아 재귀함수//해결됨.
            }
            private double GradeBouns(WeaponGrade grade) =>
                grade switch
                {
                    WeaponGrade.Rotten => -0.1,
                    WeaponGrade.Rare => 0.1,
                    WeaponGrade.Legendery => 0.2,
                    _ => 0
                };
            public int AttackRange() => 5;
            
        }
        public class WoodenLancer : IWeapon //나무창
        {
            private WeaponGrade _grade;
            public WoodenLancer(WeaponGrade grade) => _grade = grade;
            public string Name() => "나무 창";
            public int BaseAttackPower() => 30;
            public int AttackPower()
            {
                int basePower = BaseAttackPower();
                return (int)(basePower * (1 + GradeBouns(_grade)));
            }
            private double GradeBouns(WeaponGrade grade) =>
                grade switch
                {
                    WeaponGrade.Rotten => -0.1,
                    WeaponGrade.Rare => 0.1,
                    WeaponGrade.Legendery => 0.2,
                    _ => 0
                };
            public int AttackRange() => 10;
            public WeaponGrade Grade() => _grade;
        }
        public class IronAxe : IWeapon //쇠도끼
        {
            private WeaponGrade _grade;
            public IronAxe(WeaponGrade grade) => _grade = grade;
            public string Name() => "쇠 도끼";
            public int BaseAttackPower() => 40;
            public int AttackPower()
            {
                int basePower = BaseAttackPower();
                return (int)(basePower * (1 + GradeBouns(_grade)));
            }
            private double GradeBouns(WeaponGrade grade) =>
                grade switch
                {
                    WeaponGrade.Rotten => -0.1,
                    WeaponGrade.Rare => 0.1,
                    WeaponGrade.Legendery => 0.2,
                    _ => 0
                };
            public int AttackRange() => 3;
            public WeaponGrade Grade() => _grade;
        }
        #endregion

        public class WeaponFactory // 팩토리 소스코드
        {
            private static readonly Random _random = new Random();//랜덤 등급
            public static IWeapon CreateWeapon(string weapon) //무기 생성코드
            {
                WeaponGrade grade = (WeaponGrade)_random.Next(0, 4);
                return weapon switch //스위치 반환문 
                {
                    "철 검" => new IronSword(grade),
                    "나무 창" => new WoodenLancer(grade),
                    "쇠 도끼" => new IronAxe(grade),
                    _ => throw new ArgumentNullException("없는 정보 입니다.")
                };
            }
        }//등급별 공격력 계산식이 겹치는데, 따로 빼내버림되나.
        static void Main(string[] args) //weapon 1,2,3의 1,2,3을 없애고 싶다. 딕셔너리?
        {
            IWeapon weapon1 = WeaponFactory.CreateWeapon("철 검");
            Console.WriteLine($"무기 이름 : {weapon1.Name()}");
            Console.WriteLine($"등급 : {weapon1.Grade()}");
            Console.WriteLine($"공격력 : {weapon1.AttackPower()}");
            Console.WriteLine($"공격범위 : {weapon1.AttackRange()}");

            IWeapon weapon2 = WeaponFactory.CreateWeapon("나무 창");
            Console.WriteLine($"무기 이름 : {weapon2.Name()}");
            Console.WriteLine($"등급 : {weapon2.Grade()}");
            Console.WriteLine($"공격력 : {weapon2.AttackPower()}");
            Console.WriteLine($"공격범위 : {weapon2.AttackRange()}");

            IWeapon weapon3 = WeaponFactory.CreateWeapon("쇠 도끼");
            Console.WriteLine($"무기 이름 : {weapon3.Name()}");
            Console.WriteLine($"등급 : {weapon3.Grade()}");
            Console.WriteLine($"공격력 : {weapon3.AttackPower()}");
            Console.WriteLine($"공격범위 : {weapon3.AttackRange()}");
        }
    }
}
