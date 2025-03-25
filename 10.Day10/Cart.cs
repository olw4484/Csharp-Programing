using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _10.Day10
{

    public class Cart
    {
        public string? Name { get; set; }
        public string? Rating { get; set; }
        public float MaxSpeed { get; set; }
        public int Acceleration { get; set; }
        public int BoostTime { get; set; }
        public int BoostCharge { get; set; }
        public int StartBoost { get; set; }

        public Cart(string? name, string? rating, float maxSpeed, int acceleration, int boostTime, int boostCharge, int startBoost)
        {
            Name = name;
            Rating = rating;
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            BoostTime = boostTime;
            BoostCharge = boostCharge;
            StartBoost = startBoost;
        }
        public override string ToString()
        {
            return $"이름 : {Name} / 등급 : {Rating} \n최고속도 : {MaxSpeed}km/s \n가속도 : {Acceleration}\n부스트시간 : {BoostTime}\n부스트충전 : {BoostCharge}\n시작가속도 : {StartBoost}";
        }

    }
    
    
}
