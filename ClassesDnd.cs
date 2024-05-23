using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_8_list_view_second_try
{
 public class ClassesDnd
    {
        //fields
        string _playerName;
        string _characterName;
        int _level;
        int _health;
        int _constitution;
        int _intellegence;

        int _proficency;


        //int _strength;
        //int _dexterity;

        //int _wisdom;
        //int _charisma;

        public ClassesDnd(string playerName)
        {
            _playerName = playerName;
        }

        public ClassesDnd(int proficency)
        {
            _proficency = proficency;
        }

        public ClassesDnd(string playerName, string characterName)
        {
            _playerName = playerName;
            _characterName = characterName;
        }

        public ClassesDnd(int constitution, int intellegence)
        {
            _constitution = constitution;
            _intellegence = intellegence;
        }

        public ClassesDnd(string playerName, string characterName, int constitution, int intellegence)
        {
            _playerName = playerName;
            _characterName = characterName;
            _constitution = constitution;
            _intellegence = intellegence;
        }

        public ClassesDnd(string playerName, string characterName, int level, int health, int constitution, int intellegence)
        {
            _playerName = playerName;
            _characterName = characterName;
            _level = level;
            _health = health;
            _constitution = constitution;
            _intellegence = intellegence;
        }

        public string PlayerName { get => _playerName; set => _playerName = value; }
        public string CharacterName { get => _characterName; set => _characterName = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }
        public int Intellegence { get => _intellegence; set => _intellegence = value; }
        public int Level { get => _level; set => _level = value; }
        public int Health { get => _health; set => _health = value; }


        public int Hacking { get => AbilityModifier(_intellegence); }

        public int WillPower { get => AbilityModifier(_constitution); }
        public int Proficency
        {   get => _proficency;

            set
            {
                if (value > 0)
                {
                    _proficency = value;
                }
                else
                {
                    throw new Exception("Enter a possitive");

                }
            }
        }
        

        public int AbilityModifier(int stat)
        {
            return (stat - 10) / 2;
        }

        //Stat - 10/2

        //8-10/2

        //8-9 -1

        //10-10/2

        //10-11/0









        //public ClassesDnd(string playerName, string className, int level, int strength, int dexterity, int constitution, int intellegence, int wisdom, int charisma)
        //{
        //    _playerName = playerName;
        //    _className = className;
        //    _level = level;
        //    _strength = strength;
        //    _dexterity = dexterity;
        //    _constitution = constitution;
        //    _intellegence = intellegence;
        //    _wisdom = wisdom;
        //    _charisma = charisma;
        //}
    }//class




}//namespace
