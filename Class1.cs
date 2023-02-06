/*Avigayil Sperka
 * T00386137
 * In class Lab 2
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclassLab2
{
    internal class StudentClass
    {
        //underscore implies private
        private string _studentId;
        private string _studentName;
        private decimal _mathScore;
        private decimal _historyScore;
        private decimal _scienceScore;

        //properties per each instance variable
        public string StudentId
        { get => _studentId; set { _studentId = value; } }    
            
        public string StudentName { get=> _studentName; set { _studentName = value; } }
        public decimal MathScore { 
            get => _mathScore;
            set
            {
                if (value > 0)
                {
                    _mathScore = value;
                }
                else
                {
                    Console.WriteLine("Error: Invalid math score entry. Score was not set.");
                }
            }
        }
        public decimal ScienceScore { 
            get => _scienceScore;
            set
            {
                if (value > 0)
                {
                    _scienceScore = value;
                }
                else
                {
                    Console.WriteLine("Error: Invalid science score entry. Score was not set.");
                }
            } 
        }
        public decimal HistoryScore {
            get => _historyScore;
            set
            {
                if (value > 0)
                {
                    _historyScore = value;
                }
                else
                    Console.WriteLine("Error: Invalid history score entry. Score was not set.");
            }
        }
        public StudentClass(string studentId, string studentName, decimal mathScore, decimal scienceScore, decimal historyScore)
        {
            _studentId = studentId;
            _studentName = studentName;
            _mathScore = mathScore;
            _scienceScore = scienceScore;
            _historyScore = historyScore;
        }

        public StudentClass(){}

        public decimal getAggregate()
        {
            return _mathScore + _scienceScore + _historyScore;
        }
        public decimal getPercentage()
        {
            return (getAggregate() / 50) * 100;
        }
    }
}
