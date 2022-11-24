using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities_Tool
{
    internal class NonePrintableCharacter
    {
        Dictionary<string, string> characters = new Dictionary<string, string>();
        private string _str = string.Empty;
        public string _showChar = string.Empty;
        public string _hideChar = string.Empty;
        public NonePrintableCharacter()
        {
            characters = new Dictionary<string, string>();
            Create_Dictionary();
            _showChar = string.Empty;
            _hideChar = string.Empty;
        }
        public NonePrintableCharacter(string text)
        {
            _str = text;
            characters = new Dictionary<string, string>();
            Create_Dictionary();
            _showChar = ShowNonePrintCharacter();
            _hideChar = HiddenNonePrintCharacter();
        }


        private void Create_Dictionary()
        {
            characters.Add(Convert.ToChar(0).ToString(), "<NULL>");
            characters.Add(Convert.ToChar(1).ToString(), "<SOH>");
            characters.Add(Convert.ToChar(2).ToString(), "<STX>");
            characters.Add(Convert.ToChar(3).ToString(), "<ETX>");
            characters.Add(Convert.ToChar(4).ToString(), "<EOT>");
            characters.Add(Convert.ToChar(5).ToString(), "<ENQ>");
            characters.Add(Convert.ToChar(6).ToString(), "<ACK>");
            characters.Add(Convert.ToChar(7).ToString(), "<BELL>");
            characters.Add(Convert.ToChar(8).ToString(), "<BS>");
            characters.Add(Convert.ToChar(9).ToString(), "<TAB>");
            characters.Add(Convert.ToChar(10).ToString(), "<LF>");
            characters.Add(Convert.ToChar(11).ToString(), "<VT>");
            characters.Add(Convert.ToChar(12).ToString(), "<FF>");
            characters.Add(Convert.ToChar(13).ToString(), "<CR>");
            characters.Add(Convert.ToChar(14).ToString(), "<SO>");
            characters.Add(Convert.ToChar(15).ToString(), "<SI>");
            characters.Add(Convert.ToChar(16).ToString(), "<DLE>");
            characters.Add(Convert.ToChar(17).ToString(), "<DC1>");
            characters.Add(Convert.ToChar(18).ToString(), "<DC2>");
            characters.Add(Convert.ToChar(19).ToString(), "<DC3>");
            characters.Add(Convert.ToChar(20).ToString(), "<DC4>");
            characters.Add(Convert.ToChar(21).ToString(), "<NAK>");
            characters.Add(Convert.ToChar(22).ToString(), "<SYN>");
            characters.Add(Convert.ToChar(23).ToString(), "<ETB>");
            characters.Add(Convert.ToChar(24).ToString(), "<CAN>");
            characters.Add(Convert.ToChar(25).ToString(), "<EM>");
            characters.Add(Convert.ToChar(26).ToString(), "<SUB>");
            characters.Add(Convert.ToChar(27).ToString(), "<ESC>");
            characters.Add(Convert.ToChar(28).ToString(), "<FS>");
            characters.Add(Convert.ToChar(29).ToString(), "<GS>");
            characters.Add(Convert.ToChar(30).ToString(), "<RS>");
            characters.Add(Convert.ToChar(31).ToString(), "<US>");
        }

        private string ShowNonePrintCharacter()
        {
            foreach(KeyValuePair<string,string> item in characters)
            {
                if(_str.Contains(item.Key))
                {
                    _str= _str.Replace(item.Key, item.Value);
                }
            }
            return _str;
        }
        private string HiddenNonePrintCharacter()
        {
            foreach (KeyValuePair<string, string> item in characters)
            {
                if (_str.Contains(item.Value))
                {
                    _str = _str.Replace(item.Value, item.Key);
                }
            }
            return _str;
        }
    }
}
