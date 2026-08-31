using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
        class Device
        {
            private readonly string serviceName = "TechFix Service";
            private string deviceType;
            private string problemDescription;
            private int repairDays;
            private double repairPrice;
            private int waitingDevices;
            private bool accepted;

            public string DeviceType
            {
                get { return deviceType; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("Типът устройство не може да бъде празен!");
                    deviceType = value;
                }
            }

            public string ProblemDescription
            {
                get { return problemDescription; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value) || value.Split().Length < 4)
                        throw new ArgumentException("Описанието на повредата трябва да съдържа поне 4 думи!");
                    problemDescription = value;
                }
            }

            public int RepairDays
            {
                get { return repairDays; }
                set
                {
                    if (value < 1 || value > 30)
                        throw new ArgumentException("Времето за ремонт трябва да е между 1 и 30 дни!");
                    repairDays = value;
                }
            }

            public double RepairPrice
            {
                get { return repairPrice; }
                set
                {
                    if (value <= 0)
                        throw new ArgumentException("Цената трябва да бъде положително число!");
                    repairPrice = value;
                }
            }

            public int WaitingDevices
            {
                get { return waitingDevices; }
                set
                {
                    if (value < 0)
                        throw new ArgumentException("Броят чакащи устройства не може да е отрицателен!");
                    waitingDevices = value;
                }
            }

            public bool Accepted
            {
                get { return accepted; }
                set { accepted = value; }
            }

            public Device(string deviceType, string problemDescription, int repairDays, double repairPrice, int waitingDevices, bool accepted)
            {
                DeviceType = deviceType;
                ProblemDescription = problemDescription;
                RepairDays = repairDays;
                RepairPrice = repairPrice;
                WaitingDevices = waitingDevices;
                Accepted = accepted;
            }

            public double TotalRepairCost()
            {
                return Math.Round(repairPrice * waitingDevices, 2);
            }

              public void PrintInfo()
            {
                Console.WriteLine($"_-_-_-_-_- {serviceName} _-_-_-_-_-_-_-_-");
                Console.WriteLine($"Устройство: {deviceType}");
                Console.WriteLine($"Проблем: {problemDescription}");
                Console.WriteLine($"Дни за ремонт: {repairDays}");
                Console.WriteLine($"Цена: {repairPrice:F2} лв.");
                Console.WriteLine($"Подобни чакащи: {waitingDevices}");
                Console.WriteLine($"Прието за ремонт: {(accepted ? "Да" : "Не")}");
                Console.WriteLine($"Обща стойност на ремонтите: {TotalRepairCost():F2} лв.");
                Console.WriteLine("__--__--___--__--__--__--__--__--__--__--__");
            }


        }
    }

