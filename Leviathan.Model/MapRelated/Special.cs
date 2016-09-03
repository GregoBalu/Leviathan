using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Leviathan.Model.MapRelated.Specials;
using Leviathan.Model.Exceptions;

namespace Leviathan.Model.MapRelated
{
    public class Special
    {
        #region Properties

        #region General

        private SpecialType _type;
        public SpecialType Type 
        { 
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                resetDefaults();

                switch(_type)
                {
                    case SpecialType.None:
                        break;
                    case SpecialType.VariableSet:
                        break;
                    case SpecialType.Battle:
                        Enemies = new List<CharacterRelated.Character>();
                        Distances = new List<int>();
                        break;
                    case SpecialType.ExperienceGain:
                        break;
                    case SpecialType.ItemGain:
                        break;
                    case SpecialType.ChangeRegion:
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        #endregion

        #region Battle

        public List<CharacterRelated.Character> Enemies { get; set; }
        public List<Int32> Distances { get; set; }

        #endregion

        #region VariableSet

        public String VariableName { get; set; }
        public Int32 VariableValue { get; set; }

        #endregion

        #region ExperienceGain

        public Int32 ExperienceAmount { get; set; }

        #endregion

        #region ItemGain

        public CharacterRelated.InventoryRelated.Item ItemToGet { get; set; }

        #endregion

        #region Puzzle

        #endregion

        #region Conversation

        #endregion

        #region ChangeRegion

        public Region NewRegionName;

        #endregion

        #endregion

        public Special()
        {
            Type = SpecialType.None;
        }

        public Special(SpecialType st)
        {
            Type = st;
        }

        private void resetDefaults()
        {
            if (Enemies != null)
            {
                Enemies.Clear();
                Enemies = null;
            }
            if(Distances != null)
            {
                Distances.Clear();
                Distances = null;
            }

            VariableName = null;
            VariableValue = 0;

            ExperienceAmount = 0;

            ItemToGet = null;
            //TODO
        }

    }
}
