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
        //int _level;

        //int _strength;
        //int _dexterity;
        //int _constitution;
        //int _intellegence;
        //int _wisdom;
        //int _charisma;

        public ClassesDnd(string playerName)
        {
            _playerName = playerName;
        }

        public ClassesDnd(string playerName, string characterName)
        {
            _playerName = playerName;
            _characterName = characterName;
        }

        public string PlayerName { get => _playerName; set => _playerName = value; }

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
